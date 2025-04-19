using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Infrastructure.Extensions;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Doctor;
using HospitalAppointmentSystem.ViewModels.Specialization;
using HospitalAppointmentSystem.ViewModels.Vacation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Controllers
{
    public class DoctorController : BaseController
    {
        private readonly ISpecializationService specializationService;
        private readonly IVacationService vacationService;
        private readonly UserManager<ApplicationUser> userManager;

        public DoctorController(ISpecializationService specializationService, IVacationService vacationService, UserManager<ApplicationUser> userManager, IDoctorService doctorService)
            :base(doctorService)
        {
            this.specializationService = specializationService;
            this.vacationService = vacationService;
            this.userManager = userManager;
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

        [HttpGet]
        public async Task<IActionResult> Details(string id, int weekOffset = 0)
        {
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(id, ref doctorGuid)) 
            { 
                return RedirectToAction(nameof(Index)); 
            }

            DoctorDetailsViewModel? viewModel = await doctorService.GetDoctorAvailabilityAsync(doctorGuid, weekOffset);
            if (viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }

            ViewBag.WeekOffset = weekOffset;

            return View(viewModel);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Schedule(int dayOffset = 0)
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction(nameof(Index));
            }

            string doctorId = this.userManager.GetUserId(User)!;
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(doctorId, ref doctorGuid))
            {
                return this.RedirectToAction(nameof(Index));
            }

            if (dayOffset < 0)
            {
                return this.RedirectToAction(nameof(Schedule), new { dayOffset = 0 });
            }

            DoctorScheduleViewModel model = await doctorService.GetDoctorScheduleAsync(doctorGuid, dayOffset);
            
            ViewBag.DayOffset = dayOffset;

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> MyVacations()
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction(nameof(Index));
            }

            string doctorId = this.userManager.GetUserId(User)!;
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(doctorId, ref doctorGuid))
            {
                return this.RedirectToAction(nameof(Index));
            }

            IEnumerable<VacationViewModel> vacations = await this.vacationService
                .GetVacationsByDoctorId(doctorGuid);

            return View(vacations);
        }

        [HttpGet]
        public async Task<IActionResult> AddVacation()
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction(nameof(Index));
            }

            AddVacationViewModel viewModel =  new AddVacationViewModel
            {
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(1)
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddVacation(AddVacationViewModel viewModel)
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid || viewModel.EndDate < viewModel.StartDate)
            {
                ModelState.AddModelError(string.Empty, "Крайната дата трябва да е след началната.");
                return View(viewModel);
            }

            string doctorId = this.userManager.GetUserId(User)!;
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(doctorId, ref doctorGuid))
            {
                return this.RedirectToAction(nameof(Index));
            }

            await this.vacationService.AddVacationAsync(viewModel, doctorGuid);

            TempData["Success"] = "Успешно добавена отпуска.";
            return RedirectToAction(nameof(MyVacations));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteVacation(string vacationId)
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction(nameof(Index));
            }

            string doctorId = this.userManager.GetUserId(User)!;
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(doctorId, ref doctorGuid))
            {
                return this.RedirectToAction(nameof(Index));
            }

            Guid vacationGuid = Guid.Empty;
            if (!IsGuidValid(vacationId, ref vacationGuid))
            {
                return this.RedirectToAction(nameof(MyVacations));
            }

            Vacation vacation = await this.vacationService.GetVacationById(vacationGuid);

            if (vacation == null)
            {
                return this.RedirectToAction(nameof(MyVacations));
            }

            bool result = await this.vacationService.DeleteVacationAsync(vacation);

            if (result)
            {
                TempData["Success"] = "Отпуската е отменена успешно.";
            }

            return RedirectToAction(nameof(MyVacations));
        }
    }
}
