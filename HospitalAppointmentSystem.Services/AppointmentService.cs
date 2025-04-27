using Microsoft.EntityFrameworkCore;
using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Appointment;
using HospitalAppointmentSystem.ViewModels.Rating;

namespace HospitalAppointmentSystem.Services
{
    /// <summary>
    /// Клас за управление на прегледите.
    /// </summary>
    public class AppointmentService : BaseService, IAppointmentService
    {
        private readonly IRepository<Appointment, Guid> appointmentRepository;

        public AppointmentService(IRepository<Appointment, Guid> appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        /// <summary>
        /// Връща списък с всички прегледи на даден пациент.
        /// </summary>
        public async Task<IEnumerable<MyAppointmentsViewModel>> GetAppointmentsByPatientIdAsync(Guid patientId)
        {
            IEnumerable<MyAppointmentsViewModel> appointments = await this.appointmentRepository
                .GetAllAttached()
                .Include(a => a.Doctor)
                .ThenInclude(d => d.User)
                .Where(a => a.PatientId == patientId && a.IsDeleted == false)
                .OrderByDescending(a => a.AppointmentDateTime)
                .Select(a => new MyAppointmentsViewModel
                {
                    Id = a.Id.ToString(),
                    DoctorName = $"{a.Doctor.User.FirstName} {a.Doctor.User.LastName}",
                    AppointmentDateTime = a.AppointmentDateTime,
                    HasRating = a.Rating != null
                })
                .ToListAsync();

            return appointments;
        }

        /// <summary>
        /// Връща информация за преглед по идентификатор.
        /// </summary>
        public async Task<Appointment?> GetAppointmentByIdAsync(Guid id)
        {
            Appointment? appointment = await this.appointmentRepository
                .GetAllAttached()
                .Where(a => a.IsDeleted == false)
                .FirstOrDefaultAsync(a => a.Id == id);

            return appointment;
        }

        /// <summary>
        /// Връща преглед за оценяване.
        /// </summary>
        public async Task<RatingViewModel?> GetAppointmentForRatingAsync(Guid appointmentId, Guid userId)
        {
            Appointment? appointment = await appointmentRepository
            .GetAllAttached()
            .Where(a => a.IsDeleted == false)
            .Include(a => a.Rating)
            .FirstOrDefaultAsync(a => a.Id == appointmentId && a.PatientId == userId);

            if (appointment == null)
            {
                return null;
            }

            if (appointment.AppointmentDateTime > DateTime.Now)
            {
                return null;
            }

            if (appointment.Rating != null)
            {
                return null;
            }

            return new RatingViewModel
            {
                AppointmentId = appointmentId.ToString()
            };
        }

        /// <summary>
        /// Добавя нов преглед в системата.
        /// </summary>
        public async Task AddAppointmentAsync(AppointmentConfirmationViewModel inputModel, string patientId)
        {
            Appointment appointment = new Appointment
            {
                Id = Guid.NewGuid(),
                PatientId = Guid.Parse(patientId),
                DoctorId = Guid.Parse(inputModel.DoctorId),
                AppointmentDateTime = inputModel.AppointmentDateTime,
            };

            await this.appointmentRepository.AddAsync(appointment);
        }

        /// <summary>
        /// Извършва изтриване на прегледа (без физическо триене от базата).
        /// </summary>
        public async Task<bool> SoftDeleteAppointmentAsync(Guid id)
        {
            Appointment? appointmentToDelete = await this.appointmentRepository
                .FirstOrDefaultAsync(a => a.Id == id);

            if (appointmentToDelete == null)
            {
                return false;
            }

            appointmentToDelete.IsDeleted = true;
            return await this.appointmentRepository.UpdateAsync(appointmentToDelete);
        }
    }
}
