using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HospitalAppointmentSystem.Controllers;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Specialization;
using static HospitalAppointmentSystem.Common.Constants.ApplicationConstants;

namespace HospitalAppointmentSystem.Areas.Admin.Controllers
{
    /// <summary>
    /// Контролер за управление на специалностите на докторите в административния панел.
    /// </summary>
    [Area(AdminRoleName)]
    [Authorize(Roles = AdminRoleName)]
    public class SpecializationManagementController : BaseController
    {
        private readonly ISpecializationService specializationService;

        public SpecializationManagementController(ISpecializationService specializationService, IDoctorService doctorService) 
            : base(doctorService)
        {
            this.specializationService = specializationService;
        }

        /// <summary>
        /// Показва всички налични специалности.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> AllSpecializations()
        {
            IEnumerable<SpecializationViewModel> specializations = 
                await this.specializationService.GetAllAsync();

            return View(specializations);
        }

        /// <summary>
        /// Показва формата за създаване на нова специалност.
        /// </summary>
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// Обработва пост заявка за създаване на нова специалност.
        /// </summary>
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
