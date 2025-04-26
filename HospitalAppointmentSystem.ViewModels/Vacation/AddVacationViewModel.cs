using System.ComponentModel.DataAnnotations;
using static HospitalAppointmentSystem.Common.Constants.EntityMessages;

namespace HospitalAppointmentSystem.ViewModels.Vacation
{
    public class AddVacationViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [DataType(DataType.Date)]
        [Display(Name = "Начална дата")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [DataType(DataType.Date)]
        [Display(Name = "Крайна дата")]
        public DateTime EndDate { get; set; }
    }
}
