using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAppointmentSystem.Data.Models
{
    public class Appointment
    {
        [Key]
        [Comment("Appointment Identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Patient Identifier")]
        public Guid PatientId { get; set; }

        [ForeignKey(nameof(PatientId))]
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public ApplicationUser Patient { get; set; } = null!;

        [Required]
        [Comment("Doctor Identifier")]
        public Guid DoctorId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Doctor Doctor { get; set; } = null!;

        [Required]
        [Comment("Appointment date and time")]
        public DateTime AppointmentDateTime { get; set; }

        [Comment("Appointment Rating")]
        public Rating? Rating { get; set; }
    }
}