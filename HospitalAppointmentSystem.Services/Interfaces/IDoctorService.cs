using HospitalAppointmentSystem.ViewModels.Doctor;
namespace HospitalAppointmentSystem.Services.Interfaces
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorIndexViewModel>> GetDoctorsBySpecializationAsync(DoctorListViewModel inputModel);
        Task<DoctorIndexViewModel?> GetDoctorByIdAsync(Guid id);
        Task<DoctorDetailsViewModel?> GetDoctorAvailabilityAsync(Guid doctorId, int weekOffset);
    }
}
