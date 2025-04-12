using System.ComponentModel.DataAnnotations;
using static HospitalAppointmentSystem.Common.Constants.EntityConstants;
using static HospitalAppointmentSystem.Common.Constants.EntityMessages;
namespace HospitalAppointmentSystem.ViewModels.Rating
{
    public class RatingViewModel
    {
        public string AppointmentId { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), RatingMinValue, RatingMaxValue, ErrorMessage = RatingProfessionalismRangeMessage)]
        public decimal Professionalism { get; set; }

        [Required]
        [Range(typeof(decimal), RatingMinValue, RatingMaxValue, ErrorMessage = RatingAttitudeRangeMessage)]
        public decimal Attitude { get; set; }
    }
}
