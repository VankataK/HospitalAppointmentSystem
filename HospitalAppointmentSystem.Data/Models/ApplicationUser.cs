using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static HospitalAppointmentSystem.Common.Constants.EntityConstants;

namespace HospitalAppointmentSystem.Data.Models
{
    /// <summary>
    /// Разширен модел на потребител, използващ ASP.NET Identity с допълнителни данни.
    /// </summary>
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(UserLastNameMaxLength)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [PersonalData]
        public string Gender { get; set; } = string.Empty;

        [Required]
        [Range(UserAgeMinValue, UserAgeMaxValue)]
        [PersonalData]
        public int Age { get; set; }
    }
}
