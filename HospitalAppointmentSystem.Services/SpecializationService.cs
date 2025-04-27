using Microsoft.EntityFrameworkCore;
using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Specialization;

namespace HospitalAppointmentSystem.Services
{
    /// <summary>
    /// Клас за управление на специалностите.
    /// </summary>
    public class SpecializationService : ISpecializationService
    {
        private readonly IRepository<Specialization, Guid> specializationRepository;

        public SpecializationService(IRepository<Specialization, Guid> specializationRepository)
        {
            this.specializationRepository = specializationRepository;
        }

        /// <summary>
        /// Връща всички специалности, подредени по име.
        /// </summary>
        public async Task<IEnumerable<SpecializationViewModel>> GetAllAsync()
        {
            return await specializationRepository
                .GetAllAttached()
                .OrderBy(s => s.Name)
                .Select(s => new SpecializationViewModel
                {
                    Id = s.Id.ToString(),
                    Name = s.Name
                })
                .ToListAsync();
        }

        /// <summary>
        /// Добавя нова специалност.
        /// </summary>
        public async Task CreateAsync(AddSpecializationViewModel model)
        {
            Specialization specialization = new Specialization
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
            };

            await this.specializationRepository.AddAsync(specialization);
        }
    }
}
