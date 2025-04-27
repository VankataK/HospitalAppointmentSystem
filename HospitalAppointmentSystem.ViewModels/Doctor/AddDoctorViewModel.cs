using HospitalAppointmentSystem.ViewModels.Specialization;
using System.ComponentModel.DataAnnotations;
using static HospitalAppointmentSystem.Common.Constants.EntityConstants;
using static HospitalAppointmentSystem.Common.Constants.EntityMessages;
namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    /// <summary>
    /// Модел за създаване на нов доктор от администратора.
    /// Съдържа лични данни, имейл, парола и избор на специалност.
    /// </summary>
    public class AddDoctorViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(UserFirstNameMaxLength, ErrorMessage = "Името трябва да е между {2} и {1} знака.", MinimumLength = UserFirstNameMinLength)]
        [Display(Name = "Име")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(UserLastNameMaxLength, ErrorMessage = "Фамилията трябва да е между {2} и {1} знака.", MinimumLength = UserLastNameMinLength)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Пол")]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(UserAgeMinValue, UserAgeMaxValue, ErrorMessage = "Възрастта трябва да е между {1} и {2}.")]
        [Display(Name = "Възраст")]
        public int Age { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [EmailAddress]
        [Display(Name = "Имейл")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(100, ErrorMessage = "Паролата трябва да е поне {2} и максимум {1} знака.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]

        [DataType(DataType.Password)]
        [Display(Name = "Потвърждаване на паролата")]
        [Compare("Password", ErrorMessage = "Паролите не съвпадат.")]
        public string ConfirmPassword { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Специалност")]
        public string SpecializationId { get; set; } = null!;

        [StringLength(DoctorDescriptionMaxLength, ErrorMessage = "Описанието не може да е повече от {1} знака.")]
        [Display(Name = "Описание")]
        public string? Description {  get; set; }

        public IEnumerable<SpecializationViewModel> Specializations { get; set; } = new List<SpecializationViewModel>();
    }
}
