using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAppointmentSystem.Data.Models
{
    /// <summary>
    /// Модел за отпуска на доктора.
    /// </summary>
    public class Vacation
    {
        [Key]
        [Comment("Vacation Identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Doctor Identifier")]
        public Guid DoctorId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public Doctor Doctor { get; set; } = null!;

        [Required]
        [Comment("Vacation Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Comment("Vacation End Date")]
        public DateTime EndDate { get; set; }
    }
}