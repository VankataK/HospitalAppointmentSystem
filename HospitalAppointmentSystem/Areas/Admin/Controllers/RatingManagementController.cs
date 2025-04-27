using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Rating;
using static HospitalAppointmentSystem.Common.Constants.ApplicationConstants;

namespace HospitalAppointmentSystem.Areas.Admin.Controllers
{
    [Area(AdminRoleName)]
    [Authorize(Roles = AdminRoleName)]
    public class RatingManagementController : Controller
    {
        private readonly IRatingService ratingService;

        public RatingManagementController(IRatingService ratingService)
        {
            this.ratingService = ratingService;
        }

        public async Task<IActionResult> AllRatings(RatingFilterViewModel inputModel)
        {
            IEnumerable<RatingAdminViewModel> ratings = 
                await this.ratingService.GetAllRatingsAsync(inputModel);

            RatingFilterViewModel model = new RatingFilterViewModel
            {
                DoctorName = inputModel.DoctorName,
                PatientName = inputModel.PatientName,
                FromDate = inputModel.FromDate,
                ToDate = inputModel.ToDate,
                Ratings = ratings
            };

            return View(model);
        }
    }
}
