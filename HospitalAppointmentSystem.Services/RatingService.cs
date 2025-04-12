using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Rating;

namespace HospitalAppointmentSystem.Services
{
    public class RatingService : BaseService, IRatingService
    {
        private readonly IRepository<Rating, Guid> ratingRepository;

        public RatingService(IRepository<Rating, Guid> ratingRepository)
        {
            this.ratingRepository = ratingRepository;
        }
        
        public async Task<bool> SubmitRatingAsync(RatingViewModel model)
        {
            Guid appointmentGuid = Guid.Empty;
            if (!IsGuidValid(model.AppointmentId, ref appointmentGuid))
            {
                return false;
            }

            Rating rating = new Rating
            {
                Id = Guid.NewGuid(),
                AppointmentId = appointmentGuid,
                Professionalism = model.Professionalism,
                Attitude = model.Attitude
            };

            await ratingRepository.AddAsync(rating);

            return true;
        }
    }
}
