using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Doctor;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Services
{
    public class DoctorService : BaseService, IDoctorService
    {
        private readonly IRepository<Doctor, Guid> doctorRepository;

        public DoctorService(IRepository<Doctor, Guid> doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }

        public async Task<IEnumerable<DoctorIndexViewModel>> GetDoctorsBySpecializationAsync(DoctorListViewModel inputModel)
        {
            IQueryable<Doctor> doctors = this.doctorRepository
                .GetAllAttached()
                .Include(d => d.User)
                .Include(d => d.Specialization);

            Guid specGuid = Guid.Empty;

            if (IsGuidValid(inputModel.SelectedSpecializationId, ref specGuid))
            {
                doctors = doctors.Where(d => d.SpecializationId == specGuid);
            }

            return await doctors
                .Select(d => new DoctorIndexViewModel
                {
                    Id = d.Id.ToString(),
                    FullName = $"{d.User.FirstName} {d.User.LastName}",
                    SpecializationName = d.Specialization.Name
                })
                .ToListAsync();
        }
    }
}
