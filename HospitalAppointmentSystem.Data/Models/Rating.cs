using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAppointmentSystem.Data.Models
{
    public class Rating
    {
        [Key]
        [Comment("Rating Identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Appointment Identifier")]
        public Guid AppointmentId { get; set; }

        [ForeignKey(nameof(AppointmentId))]
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public Appointment Appointment { get; set; } = null!;

        [Required]
        [Comment("Doctor Professionalism")]
        [Column(TypeName ="decimal(4,2)")]
        public decimal Professionalism { get; set; }

        [Required]
        [Comment("Doctor Attitude")]
        [Column(TypeName = "decimal(4,2)")]
        public decimal Attitude { get; set; }
    }
}