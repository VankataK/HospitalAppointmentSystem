using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Infrastructure.Extensions;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Appointment;
using HospitalAppointmentSystem.ViewModels.Doctor;
using HospitalAppointmentSystem.ViewModels.Specialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.Controllers
{
    public class DoctorController : BaseController
    {
        private readonly ISpecializationService specializationService;
        private readonly UserManager<ApplicationUser> userManager;

        public DoctorController(ISpecializationService specializationService, UserManager<ApplicationUser> userManager, IDoctorService doctorService)
            :base(doctorService)
        {
            this.specializationService = specializationService;
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
    }
}
