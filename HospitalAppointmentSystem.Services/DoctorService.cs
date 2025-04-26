using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Doctor;

namespace HospitalAppointmentSystem.Services
{
    public class DoctorService : BaseService, IDoctorService
    {
        private readonly IRepository<Doctor, Guid> doctorRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public DoctorService(IRepository<Doctor, Guid> doctorRepository, UserManager<ApplicationUser> userManager)
        {
            this.doctorRepository = doctorRepository;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<DoctorAdminViewModel>> GetAllOrderedByNameAsync()
        {
            IEnumerable<DoctorAdminViewModel> doctors = await this.doctorRepository
                .GetAllAttached()
                .Include(d => d.User)
                .Include(d => d.Specialization)
                .OrderBy(d => d.User.FirstName)
                .ThenBy(d => d.User.LastName)
                .Select(d => new DoctorAdminViewModel
                {
                    Id = d.Id.ToString(),
                    FullName = $"{d.User.FirstName} {d.User.LastName}",
                    Email = d.User.Email,
                    Age = d.User.Age,
                    Gender = d.User.Gender,
                    Specialization = d.Specialization.Name
                })
                .ToListAsync();

            return doctors;
        }

        public async Task<IEnumerable<DoctorIndexViewModel>> GetDoctorsBySpecializationAsync(DoctorListViewModel inputModel)
        {
            IQueryable<Doctor> doctors = this.doctorRepository
                .GetAllAttached()
                .Include(d => d.User)
                .Include(d => d.Specialization)
                .Include(d => d.Appointments)
                .ThenInclude(a => a.Rating);

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
                    Gender = d.User.Gender,
                    Age = d.User.Age,
                    SpecializationName = d.Specialization.Name,
                    AverageProfessionalism = d.Appointments
                    .Where(a => a.Rating != null).Count() >= 20
                    ? d.Appointments.Where(a => a.Rating != null).Average(a => a.Rating!.Professionalism).ToString("F2")
                    : "-",
                    AverageAttitude = d.Appointments
                    .Where(a => a.Rating != null).Count() >= 20
                    ? d.Appointments.Where(a => a.Rating != null).Average(a => a.Rating!.Attitude).ToString("F2")
                    : "-"
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
                Gender = doctor.User.Gender,
                Age = doctor.User.Age,
                SpecializationName = doctor.Specialization.Name,
                Description = doctor.Description,
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

                        if (date.Date == DateTime.Today && slotDateTime <= DateTime.Now)
                        {
                            continue;
                        }

                        bool isTaken = doctor.Appointments.Any(a => a.AppointmentDateTime == slotDateTime);
                        dayAvailability.TimeSlots.Add(new TimeSlot { Time = t, IsAvailable = !isTaken });
                    }
                }

                viewModel.Days.Add(dayAvailability);
            }

            return viewModel;
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

        public async Task<bool> AddDoctorAsync(AddDoctorViewModel inputModel)
        {
            Guid specializationGuid = Guid.Empty;
            if (!IsGuidValid(inputModel.SpecializationId, ref specializationGuid))
            {
                return false;
            }

            ApplicationUser user = new ApplicationUser
            {
                Id = Guid.NewGuid(),
                Email = inputModel.Email,
                UserName = inputModel.Email,
                NormalizedEmail = inputModel.Email.ToUpper(),
                NormalizedUserName = inputModel.Email.ToUpper(),
                FirstName = inputModel.FirstName,
                LastName = inputModel.LastName,
                Gender = inputModel.Gender,
                Age = inputModel.Age,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            IdentityResult result = await userManager.CreateAsync(user, inputModel.Password);

            if (!result.Succeeded)
            {
                return false;
            }

            Doctor doctor = new Doctor
            {
                Id = user.Id,
                SpecializationId = specializationGuid
            };

            await this.doctorRepository.AddAsync(doctor);

            return true;
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

        public async Task<bool> IsHavingAppointmentsAsync(Guid doctorId, DateTime fromDate, DateTime toDate)
        {
            Doctor? doctor = await this.doctorRepository
                .GetAllAttached()
                .Include(d => d.Appointments)
                .FirstOrDefaultAsync(d => d.Id == doctorId);

            return doctor!.Appointments
                .Any(a =>
                a.AppointmentDateTime.Date >= fromDate.Date &&
                a.AppointmentDateTime.Date <= toDate.Date);
        }
    }
}
