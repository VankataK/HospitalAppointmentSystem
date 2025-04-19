using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Doctor;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace HospitalAppointmentSystem.Services
{
    public class DoctorService : BaseService, IDoctorService
    {
        private readonly IRepository<Doctor, Guid> doctorRepository;

        public DoctorService(IRepository<Doctor, Guid> doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }

        public async Task<IEnumerable<DoctorIndexViewModel>> GetDoctorsBySpecializationAsync(DoctorListViewModel inputModel)
        {
            IQueryable<Doctor> doctors = this.doctorRepository
                .GetAllAttached()
                .Include(d => d.User)
                .Include(d => d.Specialization);

            Guid specGuid = Guid.Empty;

            if (IsGuidValid(inputModel.SelectedSpecializationId, ref specGuid))
            {
                doctors = doctors.Where(d => d.SpecializationId == specGuid);
            }

            return await doctors
                .Select(d => new DoctorIndexViewModel
                {
                    Id = d.Id.ToString(),
                    FullName = $"{d.User.FirstName} {d.User.LastName}",
                    SpecializationName = d.Specialization.Name
                })
                .ToListAsync();
        }

        public async Task<DoctorIndexViewModel?> GetDoctorByIdAsync(Guid id)
        {
            Doctor? doctor = await this.doctorRepository
                .GetAllAttached()
                .Include(d => d.User)
                .Include(d => d.Specialization)
                .Include(d => d.Appointments)
                .Include(d => d.Vacations)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (doctor == null)
            {
                return null;
            }

            DoctorIndexViewModel viewModel = new DoctorIndexViewModel
            {
                Id = doctor.Id.ToString(),
                FullName = $"{doctor.User.FirstName} {doctor.User.LastName}",
                SpecializationName = doctor.Specialization.Name
            };
            return viewModel;
        }

        public async Task<DoctorDetailsViewModel?> GetDoctorAvailabilityAsync(Guid doctorId, int weekOffset)
        {
            Doctor? doctor = await this.doctorRepository
                .GetAllAttached()
                .Include(d => d.User)
                .Include(d => d.Specialization)
                .Include(d => d.Appointments)
                .Include(d => d.Vacations)
                .FirstOrDefaultAsync(d => d.Id == doctorId);

            if (doctor == null)
            {
                return null;
            }

            DateTime today = DateTime.Today;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Monday).Date;
            startOfWeek = startOfWeek.AddDays(weekOffset * 7);

            DoctorDetailsViewModel? viewModel = new DoctorDetailsViewModel
            {
                DoctorId = doctor.Id.ToString(),
                DoctorName = $"{doctor.User.FirstName} {doctor.User.LastName}",
                SpecializationName = doctor.Specialization.Name,
                WeekStart = startOfWeek
            };

            for (int i = 0; i < 7; i++)
            {
                DateTime date = startOfWeek.AddDays(i);
                bool isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
                bool isVacation = doctor.Vacations.Any(v => date >= v.StartDate.Date && date <= v.EndDate.Date);

                DayAvailability dayAvailability = new DayAvailability
                {
                    Date = date,
                    DayOfWeekName = date.ToString("dddd", new System.Globalization.CultureInfo("bg-BG")),
                    IsVacationOrWeekend = isWeekend || isVacation
                };

                if (!dayAvailability.IsVacationOrWeekend)
                {
                    for (TimeSpan t = TimeSpan.FromHours(9); t < TimeSpan.FromHours(17); t += TimeSpan.FromMinutes(30))
                    {
                        DateTime slotDateTime = date.Date + t;
                        bool isTaken = doctor.Appointments.Any(a => a.AppointmentDateTime == slotDateTime);
                        dayAvailability.TimeSlots.Add(new TimeSlot { Time = t, IsAvailable = !isTaken });
                    }
                }

                viewModel.Days.Add(dayAvailability);
            }

            return viewModel;
        }

        public async Task<bool> IsUserDoctorAsync(string? userId)
        {
            if (String.IsNullOrWhiteSpace(userId))
            {
                return false;
            }

            bool result = await this.doctorRepository
                .GetAllAttached()
                .AnyAsync(d => d.Id.ToString().ToLower() == userId);

            return result;
        }

        public async Task<DoctorScheduleViewModel> GetDoctorScheduleAsync(Guid doctorId, int dayOffset)
        {
            DateTime selectedDate = DateTime.Today.AddDays(dayOffset);

            Doctor? doctor = await doctorRepository
                .GetAllAttached()
                .Include(d => d.User)
                .Include(d => d.Appointments)
                .ThenInclude(a => a.Patient)
                .FirstOrDefaultAsync(d => d.Id == doctorId);

            List<Appointment> appointments = doctor.Appointments
                .Where(a => a.DoctorId == doctorId && a.AppointmentDateTime.Date == selectedDate)
                .OrderBy(a => a.AppointmentDateTime)
                .ToList();

            DoctorScheduleViewModel viewModel = new DoctorScheduleViewModel
            {
                DoctorName = $"{doctor.User.FirstName} {doctor.User.LastName}",
                Appointments = appointments.Select(a => new DoctorAppointmentViewModel
                {
                    Time = a.AppointmentDateTime.TimeOfDay,
                    PatientName = $"{a.Patient.FirstName} {a.Patient.LastName}",
                    Gender = a.Patient.Gender,
                    Age = a.Patient.Age
                }).ToList()
            };

            return viewModel;
        }
    }
}
