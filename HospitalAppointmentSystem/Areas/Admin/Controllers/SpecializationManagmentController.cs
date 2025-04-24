using HospitalAppointmentSystem.Controllers;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Specialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static HospitalAppointmentSystem.Common.Constants.ApplicationConstants;

namespace HospitalAppointmentSystem.Areas.Admin.Controllers
{
    [Area(AdminRoleName)]
    [Authorize(Roles = AdminRoleName)]
    public class SpecializationManagmentController : BaseController
    {
        private readonly ISpecializationService specializationService;

        public SpecializationManagmentController(ISpecializationService specializationService, IDoctorService doctorService) 
            : base(doctorService)
        {
            this.specializationService = specializationService;
        }

        [HttpGet]
        public async Task<IActionResult> AllSpecializations()
        {
            IEnumerable<SpecializationViewModel> specializations = 
                await this.specializationService.GetAllAsync();

            return View(specializations);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddSpecializationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await specializationService.CreateAsync(model);

            TempData["Success"] = "Специалността беше добавена успешно.";
            return RedirectToAction(nameof(AllSpecializations));
        }
    }
}
