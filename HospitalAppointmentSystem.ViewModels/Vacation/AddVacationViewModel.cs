using System.ComponentModel.DataAnnotations;

namespace HospitalAppointmentSystem.ViewModels.Vacation
{
    public class AddVacationViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Начална дата")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Крайна дата")]
        public DateTime EndDate { get; set; }
    }
}
