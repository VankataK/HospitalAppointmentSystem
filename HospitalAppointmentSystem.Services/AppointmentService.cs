using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Appointment;

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
    }
}
