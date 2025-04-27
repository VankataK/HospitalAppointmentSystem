using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HospitalAppointmentSystem.Common.Constants.EntityConstants;

namespace HospitalAppointmentSystem.Data.Models
{
    /// <summary>
    /// Модел за специалност на доктора.
    /// </summary>
    public class Specialization
    {
        [Key]
        [Comment("Specialization Identifier")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(SpecializationNameMaxLength)]
        [Comment("Specialization Name")]
        public string Name { get; set; } = null!;

        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}