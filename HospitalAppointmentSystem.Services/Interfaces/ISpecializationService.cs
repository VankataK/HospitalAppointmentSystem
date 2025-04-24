using HospitalAppointmentSystem.ViewModels.Specialization;

namespace HospitalAppointmentSystem.Services.Interfaces
{
    public interface ISpecializationService
    {
        Task<IEnumerable<SpecializationViewModel>> GetAllAsync();
        Task CreateAsync(AddSpecializationViewModel model);
    }
}
