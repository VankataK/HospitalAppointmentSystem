using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HospitalAppointmentSystem.Common.Constants.EntityConstants;

namespace HospitalAppointmentSystem.Data.Models
{
    public class Doctor
    {
        [Key]
        [Comment("Doctor Identifier")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Id))]
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("Specialization Identifier")]
        public Guid SpecializationId { get; set; }

        [ForeignKey(nameof(SpecializationId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Specialization Specialization { get; set; } = null!;

        [MaxLength(DoctorDescriptionMaxLength)]
        [Comment("Doctor Description")]
        public string? Description { get; set; }
        
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

        public ICollection<Vacation> Vacations { get; set; } = new List<Vacation>();
    }
}
