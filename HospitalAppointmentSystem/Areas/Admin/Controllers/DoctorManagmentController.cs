using HospitalAppointmentSystem.Controllers;
using HospitalAppointmentSystem.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HospitalAppointmentSystem.ViewModels.Doctor;
using static HospitalAppointmentSystem.Common.Constants.ApplicationConstants;
using HospitalAppointmentSystem.ViewModels.Specialization;
namespace HospitalAppointmentSystem.Areas.Admin.Controllers
{
    [Area(AdminRoleName)]
    [Authorize(Roles = AdminRoleName)]
    public class DoctorManagmentController : BaseController
    {
        private readonly ISpecializationService specializationService;

        public DoctorManagmentController(ISpecializationService specializationService, IDoctorService doctorService)
            : base(doctorService)
        {
            this.specializationService = specializationService;
        }

        [HttpGet]
        public async Task<IActionResult> AllDoctors()
        {
            var doctors = await doctorService.GetAllOrderedByNameAsync();

            return View(doctors);
        }

        [HttpGet]
        public async Task<IActionResult> AddDoctor()
        {
            IEnumerable<SpecializationViewModel> specializations = 
                await this.specializationService.GetAllAsync();

            AddDoctorViewModel viewModel = new AddDoctorViewModel
            {
                Specializations = specializations
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddDoctor(AddDoctorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Specializations = await specializationService.GetAllAsync();
                return View(model);
            }

            bool result = await doctorService.AddDoctorAsync(model);

            if (!result)
            {
                model.Specializations = await specializationService.GetAllAsync();
                return View(model);
            }

            TempData["Success"] = "Докторът беше успешно добавен.";
            return RedirectToAction(nameof(AllDoctors));
        }
    }
}
