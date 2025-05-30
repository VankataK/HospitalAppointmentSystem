﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Data.Models
{
    /// <summary>
    /// Модел за запазване на преглед.
    /// </summary>
    public class Appointment
    {
        [Key]
        [Comment("Appointment Identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Patient Identifier")]
        public Guid PatientId { get; set; }

        [ForeignKey(nameof(PatientId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
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

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        [Comment("Appointment Rating")]
        public Rating? Rating { get; set; }
    }
}