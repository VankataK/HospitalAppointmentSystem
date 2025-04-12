using HospitalAppointmentSystem.Infrastructure.Extensions;
using HospitalAppointmentSystem.Services;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Rating;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
            Guid userId = Guid.Parse(User.GetUserId()!);

            Guid appointmentGuid = Guid.Empty;
            if(!IsGuidValid(appointmentId, ref appointmentGuid))
            {
                return RedirectToAction("MyAppointments", "Appointment");
            }

            RatingViewModel? viewModel = await appointmentService.GetAppointmentForRatingAsync(appointmentGuid, userId);

            if (viewModel == null)
            {
                return RedirectToAction("MyAppointments", "Appointment");
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Rate(RatingViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            bool result = await this.ratingService.SubmitRatingAsync(viewModel);

            if (result == false)
            {
                return View(viewModel);
            }

            return RedirectToAction("MyAppointments", "Appointment");
        }
    }
}
