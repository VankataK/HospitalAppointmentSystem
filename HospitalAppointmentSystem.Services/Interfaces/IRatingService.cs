using HospitalAppointmentSystem.ViewModels.Rating;

namespace HospitalAppointmentSystem.Services.Interfaces
{
    public interface IRatingService
    {
        Task<bool> SubmitRatingAsync(RatingViewModel model);
    }
}
