using HospitalAppointmentSystem.ViewModels.Rating;

namespace HospitalAppointmentSystem.Services.Interfaces
{
    public interface IRatingService
    {
        Task<IEnumerable<RatingAdminViewModel>> GetAllRatingsAsync(RatingFilterViewModel inputModel);
        Task<bool> SubmitRatingAsync(RatingViewModel model);
    }
}
