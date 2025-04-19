using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.ViewModels.Vacation;

namespace HospitalAppointmentSystem.Services.Interfaces
{
    public interface IVacationService
    {
        Task<IEnumerable<VacationViewModel>> GetVacationsByDoctorId(Guid doctorId);
        Task<Vacation?> GetVacationById(Guid id);
        Task AddVacationAsync(AddVacationViewModel model, Guid doctorId);
        Task<bool> DeleteVacationAsync(Vacation vacation);
    }
}
