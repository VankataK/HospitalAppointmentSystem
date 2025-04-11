using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Appointment;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Services
{
    public class AppointmentService : BaseService, IAppointmentService
    {
        private readonly IRepository<Appointment, Guid> appointmentRepository;

        public AppointmentService(IRepository<Appointment, Guid> appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

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

        public async Task<IEnumerable<MyAppointmentsViewModel>> GetAppointmentsByPatientIdAsync(Guid patientId)
        {
            IEnumerable<MyAppointmentsViewModel> appointments = await this.appointmentRepository
                .GetAllAttached()
                .Include(a => a.Doctor)
                .ThenInclude(d => d.User)
                .Where(a => a.PatientId == patientId)
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
    }
}
