using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.SeedData;
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
            builder.Entity<ApplicationUser>().HasData(JsonSeeder.LoadJson<ApplicationUser>("users.json"));
            builder.Entity<Doctor>().HasData(JsonSeeder.LoadJson<Doctor>("doctors.json"));
            builder.Entity<Specialization>().HasData(JsonSeeder.LoadJson<Specialization>("specializations.json"));
            builder.Entity<Appointment>().HasData(JsonSeeder.LoadJson<Appointment>("appointments.json"));
            builder.Entity<Rating>().HasData(JsonSeeder.LoadJson<Rating>("ratings.json"));
            builder.Entity<IdentityRole<Guid>>().HasData(JsonSeeder.LoadJson<IdentityRole<Guid>>("roles.json"));
            builder.Entity<IdentityUserRole<Guid>>().HasData(JsonSeeder.LoadJson<IdentityUserRole<Guid>>("userRoles.json"));
            
            base.OnModelCreating(builder);
        }
    }
}
