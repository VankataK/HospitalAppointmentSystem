using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Appointment;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.Controllers
{
    public class AppointmentController : BaseController
    {
        private readonly IDoctorService doctorService;
        private readonly IAppointmentService appointmentService;
        private readonly UserManager<ApplicationUser> userManager;

        public AppointmentController(IDoctorService doctorService, IAppointmentService appointmentService, UserManager<ApplicationUser> userManager)
        {
            this.doctorService = doctorService;
            this.appointmentService = appointmentService;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Book(string doctorId)
        {
            string? dateTimeStr = Request.Query["dateTime"];
            if (!DateTime.TryParse(dateTimeStr, out DateTime dateTime))
            {
                return RedirectToAction("Index", "Doctor");
            }

            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(doctorId, ref doctorGuid))
            {
                return RedirectToAction("Index", "Doctor");
            }

            var doctor = await doctorService.GetDoctorByIdAsync(doctorGuid);
            if (doctor == null)
            {
                return RedirectToAction("Index", "Doctor");
            }

            AppointmentConfirmationViewModel model = new AppointmentConfirmationViewModel
            {
                DoctorId = doctor.Id,
                DoctorName = doctor.FullName,
                SpecializationName = doctor.SpecializationName,
                AppointmentDateTime = dateTime
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Book(AppointmentConfirmationViewModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            string userId = this.userManager.GetUserId(User)!;
            if (String.IsNullOrWhiteSpace(userId))
            {
                return this.RedirectToPage("/Identity/Account/Login");
            }

            await this.appointmentService.AddAppointmentAsync(inputModel, userId);

            return RedirectToAction("Index", "Home");
        }

        
    }
}
