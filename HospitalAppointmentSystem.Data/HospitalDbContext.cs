using HospitalAppointmentSystem.Data.Models;
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
    }
}
