using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Infrastructure.Extensions;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Appointment;
using HospitalAppointmentSystem.ViewModels.Doctor;

namespace HospitalAppointmentSystem.Controllers
{
    [Authorize(Roles = "Patient")]
    public class AppointmentController : BaseController
    {
        private readonly IAppointmentService appointmentService;
        private readonly UserManager<ApplicationUser> userManager;

        public AppointmentController(IAppointmentService appointmentService, UserManager<ApplicationUser> userManager, IDoctorService doctorService)
            :base(doctorService)
        {
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

            DoctorIndexViewModel? doctor = await doctorService.GetDoctorByIdAsync(doctorGuid);
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
        public async Task<IActionResult> Book(AppointmentConfirmationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = this.userManager.GetUserId(User)!;

            await this.appointmentService.AddAppointmentAsync(model, userId);

            return RedirectToAction(nameof(MyAppointments));
        }

        [HttpGet]
        public async Task<IActionResult> MyAppointments()
        {
            string? userId = User.GetUserId();
            if(userId == null)
            {
                return Unauthorized();
            }

            Guid userGuid = Guid.Empty;
            if (!IsGuidValid(userId, ref userGuid))
            {
                return RedirectToAction("Index", "Home");
            }

            IEnumerable<MyAppointmentsViewModel> appointments = 
                await this.appointmentService.GetAppointmentsByPatientIdAsync(userGuid);

            return View(appointments);
        }
    }
}
