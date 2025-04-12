using HospitalAppointmentSystem.ViewModels.Appointment;
using HospitalAppointmentSystem.ViewModels.Rating;

namespace HospitalAppointmentSystem.Services.Interfaces
{
    public interface IAppointmentService
    {
        Task AddAppointmentAsync(AppointmentConfirmationViewModel inputModel, string patientId);
        Task<IEnumerable<MyAppointmentsViewModel>> GetAppointmentsByPatientIdAsync(Guid patientId);
        Task<RatingViewModel?> GetAppointmentForRatingAsync(Guid appointmentId, Guid userId);

    }
}
