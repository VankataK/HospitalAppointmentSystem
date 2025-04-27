using Microsoft.EntityFrameworkCore;
using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Vacation;

namespace HospitalAppointmentSystem.Services
{
    /// <summary>
    /// Клас за управление на отпуските на докторите.
    /// </summary>
    public class VacationService : BaseService, IVacationService
    {
        private readonly IRepository<Vacation, Guid> vacationRepository;

        public VacationService(IRepository<Vacation, Guid> vacationRepository)
        {
            this.vacationRepository = vacationRepository;
        }

        /// <summary>
        /// Връща всички отпуски на конкретен доктор.
        /// </summary>
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

        /// <summary>
        /// Връща отпуска по идентификатор.
        /// </summary>
        public async Task<Vacation?> GetVacationById(Guid id)
        {
            Vacation? vacation = await this.vacationRepository
                .GetByIdAsync(id);

            return vacation;
        }

        /// <summary>
        /// Добавя нова отпуска на доктор.
        /// </summary>
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

        /// <summary>
        /// Изтрива отпуска.
        /// </summary>
        public async Task<bool> DeleteVacationAsync(Vacation vacation)
        {
            bool result = await this.vacationRepository.DeleteAsync(vacation);

            return result;
        }
    }
}
