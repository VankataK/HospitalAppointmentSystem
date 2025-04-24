using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Specialization;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Services
{
    public class SpecializationService : ISpecializationService
    {
        private readonly IRepository<Specialization, Guid> specializationRepository;

        public SpecializationService(IRepository<Specialization, Guid> specializationRepository)
        {
            this.specializationRepository = specializationRepository;
        }

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
