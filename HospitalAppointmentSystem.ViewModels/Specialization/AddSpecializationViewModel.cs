using System.ComponentModel.DataAnnotations;
using static HospitalAppointmentSystem.Common.Constants.EntityConstants;
using static HospitalAppointmentSystem.Common.Constants.EntityMessages;

namespace HospitalAppointmentSystem.ViewModels.Specialization
{
    public class AddSpecializationViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(SpecializationNameMaxLength, ErrorMessage = "Името на специалността трябва да е между {2} и {1} знака.", MinimumLength = SpecializationNameMinLength)]
        [Display(Name = "Име на специалността")]
        public string Name { get; set; } = null!;
    }
}
