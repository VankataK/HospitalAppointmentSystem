using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Rating;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HospitalAppointmentSystem.Services
{
    public class RatingService : BaseService, IRatingService
    {
        private readonly IRepository<Rating, Guid> ratingRepository;

        public RatingService(IRepository<Rating, Guid> ratingRepository)
        {
            this.ratingRepository = ratingRepository;
        }
        
        public async Task<IEnumerable<RatingAdminViewModel>> GetAllRatingsAsync(RatingFilterViewModel inputModel)
        {
            IQueryable<Rating> ratingsQuery = this.ratingRepository
                .GetAllAttached()
                .Include(r => r.Appointment)
                .ThenInclude(a => a.Doctor)
                .ThenInclude(d => d.User)
                .Include(r => r.Appointment)
                .ThenInclude(a => a.Patient);

            if (!string.IsNullOrWhiteSpace(inputModel.DoctorName))
            {
                ratingsQuery = ratingsQuery
                    .Where(r => (r.Appointment.Doctor.User.FirstName + " " + r.Appointment.Doctor.User.LastName).ToLower().Contains(inputModel.DoctorName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(inputModel.PatientName))
            {
                ratingsQuery = ratingsQuery
                    .Where(r => (r.Appointment.Patient.FirstName + " " + r.Appointment.Patient.LastName).ToLower().Contains(inputModel.PatientName.ToLower()));
            }

            if (inputModel.FromDate.HasValue)
            {
                ratingsQuery = ratingsQuery
                    .Where(r => r.Appointment.AppointmentDateTime >= inputModel.FromDate.Value);
            }

            if (inputModel.ToDate.HasValue)
            {
                ratingsQuery = ratingsQuery
                    .Where(r => r.Appointment.AppointmentDateTime <= inputModel.ToDate.Value);
            }

            return await ratingsQuery
                .Select(r => new RatingAdminViewModel
                {
                    DoctorName = $"{r.Appointment.Doctor.User.FirstName} {r.Appointment.Doctor.User.LastName}",
                    PatientName = $"{r.Appointment.Patient.FirstName} {r.Appointment.Patient.LastName}",
                    AppointmentDateTime = r.Appointment.AppointmentDateTime,
                    Professionalism = r.Professionalism,
                    Attitude = r.Attitude
                })
                .ToListAsync();
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
