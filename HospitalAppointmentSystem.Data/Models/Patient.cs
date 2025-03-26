using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HospitalAppointmentSystem.Data.Models
{
    public class Patient
    {
        [Key]
        [Comment("Patient Identifier")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Id))]
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
