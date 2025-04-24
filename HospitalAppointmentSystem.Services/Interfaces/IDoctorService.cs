using HospitalAppointmentSystem.ViewModels.Doctor;
using HospitalAppointmentSystem.ViewModels.Specialization;
namespace HospitalAppointmentSystem.Services.Interfaces
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorAdminViewModel>> GetAllOrderedByNameAsync();
        Task<IEnumerable<DoctorIndexViewModel>> GetDoctorsBySpecializationAsync(DoctorListViewModel inputModel);
        Task<DoctorIndexViewModel?> GetDoctorByIdAsync(Guid id);
        Task<DoctorDetailsViewModel?> GetDoctorAvailabilityAsync(Guid doctorId, int weekOffset);
        Task<bool> IsUserDoctorAsync(string? userId);
        Task<DoctorScheduleViewModel> GetDoctorScheduleAsync(Guid doctorId, int dayOffset);
        Task<bool> AddDoctorAsync(AddDoctorViewModel inputModel);
        Task<bool> IsHavingAppointmentsAsync(Guid doctorId, DateTime fromDate, DateTime toDate);
    }
}
