using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Doctor;
using HospitalAppointmentSystem.ViewModels.Specialization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.Controllers
{
    public class DoctorController : BaseController
    {
        private readonly IDoctorService doctorService;
        private readonly ISpecializationService specializationService;

        public DoctorController(IDoctorService doctorService, ISpecializationService specializationService)
        {
            this.doctorService = doctorService;
            this.specializationService = specializationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(DoctorListViewModel inputModel)
        {
            IEnumerable<DoctorIndexViewModel> doctors =
                await this.doctorService.GetDoctorsBySpecializationAsync(inputModel);
            IEnumerable<SpecializationViewModel> specializations = 
                await this.specializationService.GetAllAsync();

            DoctorListViewModel viewModel = new DoctorListViewModel
            {
                SelectedSpecializationId = inputModel.SelectedSpecializationId,
                Doctors = doctors,
                Specializations = specializations
            };

            return View(viewModel);
        }
    }
}
