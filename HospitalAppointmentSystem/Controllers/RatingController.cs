using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HospitalAppointmentSystem.Infrastructure.Extensions;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Rating;

namespace HospitalAppointmentSystem.Controllers
{
    [Authorize(Roles = "Patient")]
    public class RatingController : BaseController
    {
        private readonly IRatingService ratingService;
        private readonly IAppointmentService appointmentService;

        public RatingController(IRatingService ratingService, IAppointmentService appointmentService, IDoctorService doctorService) 
            : base(doctorService)
        {
            this.ratingService = ratingService;
            this.appointmentService = appointmentService;
        }

        [HttpGet]
        public async Task<IActionResult> Rate(string appointmentId)
        {
            Guid userId = Guid.Parse(this.User.GetUserId()!);

            Guid appointmentGuid = Guid.Empty;
            if(!IsGuidValid(appointmentId, ref appointmentGuid))
            {
                return RedirectToAction("MyAppointments", "Appointment");
            }

            RatingViewModel? model = 
                await appointmentService.GetAppointmentForRatingAsync(appointmentGuid, userId);

            if (model == null)
            {
                return RedirectToAction("MyAppointments", "Appointment");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Rate(RatingViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool result = await this.ratingService.SubmitRatingAsync(model);

            if (result == false)
            {
                return View(model);
            }

            return RedirectToAction("MyAppointments", "Appointment");
        }
    }
}
