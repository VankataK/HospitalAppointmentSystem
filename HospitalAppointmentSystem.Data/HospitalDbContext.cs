using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.SeedDb;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Data
{
    public class HospitalDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Appointment> Appointments { get; set; } = null!;
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Rating> Ratings { get; set; } = null!;
        public DbSet<Specialization> Specializations { get; set; } = null!;
        public DbSet<Vacation> Vacations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            SeedData data = new SeedData();

            builder.Entity<ApplicationUser>().HasData(data.AdminUser, data.FirstPatientUser, 
                data.SecondPatientUser, data.FirstDoctorUser, data.SecondDoctorUser);
            builder.Entity<IdentityRole<Guid>>().HasData(data.AdminRole, data.PatientRole);
            builder.Entity<IdentityUserRole<Guid>>().HasData(data.UsersInRoles);
            builder.Entity<Specialization>().HasData(data.CardiologySpecialization, data.NeurologySpecialization);
            builder.Entity<Doctor>().HasData(data.FirstDoctor, data.SecondDoctor);
            
            base.OnModelCreating(builder);
        }
    }
}
