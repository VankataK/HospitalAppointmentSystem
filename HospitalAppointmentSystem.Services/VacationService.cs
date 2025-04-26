using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Vacation;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Services
{
    public class VacationService : BaseService, IVacationService
    {
        private readonly IRepository<Appointment, Guid> appointmentRepository;
        private readonly IRepository<Vacation, Guid> vacationRepository;

        public VacationService(IRepository<Vacation, Guid> vacationRepository)
        {
            this.vacationRepository = vacationRepository;
        }

        public async Task<IEnumerable<VacationViewModel>> GetVacationsByDoctorId(Guid doctorId)
        {
            IEnumerable<VacationViewModel> vacations = await this.vacationRepository
                .GetAllAttached()
                .Where(v => v.DoctorId == doctorId)
                .OrderBy(v => v.StartDate)
                .Select(v => new VacationViewModel
                {
                    Id = v.Id.ToString(),
                    StartDate = v.StartDate,
                    EndDate = v.EndDate
                })
                .ToListAsync();

            return vacations;
        }

        public async Task<Vacation?> GetVacationById(Guid id)
        {
            Vacation? vacation = await this.vacationRepository
                .GetAllAttached()
                .FirstOrDefaultAsync(v => v.Id == id);

            return vacation;
        }

        public async Task AddVacationAsync(AddVacationViewModel model, Guid doctorId)
        {
            Vacation vacation = new Vacation
            {
                Id = Guid.NewGuid(),
                DoctorId = doctorId,
                StartDate = model.StartDate,
                EndDate = model.EndDate
            };

            await this.vacationRepository.AddAsync(vacation);
        }

        public async Task<bool> DeleteVacationAsync(Vacation vacation)
        {
            bool result = await this.vacationRepository.DeleteAsync(vacation);

            return result;
        }
    }
}
