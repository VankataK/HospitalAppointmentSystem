using HospitalAppointmentSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
namespace HospitalAppointmentSystem.Data.SeedDb
{
    public class SeedData
    {
        public ApplicationUser FirstPatientUser { get; set; } = null!;
        public ApplicationUser SecondPatientUser { get; set; } = null!;
        public ApplicationUser FirstDoctorUser { get; set; } = null!;
        public ApplicationUser SecondDoctorUser { get; set; } = null!;
        public ApplicationUser AdminUser { get; set; } = null!;
        public IdentityRole<Guid> AdminRole { get; set; } = null!;
        public IdentityUserRole<Guid> AdminInRole { get; set; } = null!;
        public Patient FirstPatient { get; set; } = null!;
        public Patient SecondPatient { get; set; } = null!;
        public Doctor FirstDoctor { get; set; } = null!;
        public Doctor SecondDoctor { get; set; } = null!;
        public Specialization CardiologySpecialization { get; set; } = null!;
        public Specialization NeurologySpecialization { get; set; } = null!;

        public SeedData()
        {
            SeedSpecializations();
            SeedUsers();
            SeedAdminInRole();
        }

        private void SeedSpecializations()
        {
            CardiologySpecialization = new Specialization()
            {
                Id = Guid.NewGuid(),
                Name = "Кардиолог"
            };

            NeurologySpecialization = new Specialization()
            {
                Id = Guid.NewGuid(),
                Name = "Невролог"
            };
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            AdminUser = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                UserName = "admin@mail.com",
                NormalizedUserName = "admin@mail.com",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com",
                FirstName = "Админ",
                LastName = "Админов",
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            AdminUser.PasswordHash =
                hasher.HashPassword(AdminUser, "admin123");

            FirstPatientUser = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                UserName = "georgi.ivanov@mail.com",
                NormalizedUserName = "georgi.ivanov@mail.com",
                Email = "georgi.ivanov@mail.com",
                NormalizedEmail = "georgi.ivanov@mail.com",
                FirstName = "Георги",
                LastName = "Иванов",
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            FirstPatientUser.PasswordHash =
                hasher.HashPassword(FirstPatientUser, "georgi123");

            FirstPatient = new Patient()
            {
                Id = FirstPatientUser.Id
            };

            SecondPatientUser = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                UserName = "elena.simeonova@mail.com",
                NormalizedUserName = "elena.simeonova@mail.com",
                Email = "elena.simeonova@mail.com",
                NormalizedEmail = "elena.simeonova@mail.com",
                FirstName = "Елена",
                LastName = "Симеонова",
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            SecondPatientUser.PasswordHash =
                hasher.HashPassword(SecondPatientUser, "elena123");

            SecondPatient = new Patient()
            {
                Id = SecondPatientUser.Id
            };

            FirstDoctorUser = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                UserName = "ivan.petrov@mail.com",
                NormalizedUserName = "ivan.petrov@mail.com",
                Email = "ivan.petrov@mail.com",
                NormalizedEmail = "ivan.petrov@mail.com",
                FirstName = "Иван",
                LastName = "Петров",
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            FirstDoctorUser.PasswordHash =
                hasher.HashPassword(FirstDoctorUser, "ivan123");

            FirstDoctor = new Doctor()
            {
                Id = FirstDoctorUser.Id,
                SpecializationId = CardiologySpecialization.Id
            };

            SecondDoctorUser = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                UserName = "maria.georgieva@mail.com",
                NormalizedUserName = "maria.georgieva@mail.com",
                Email = "maria.georgieva@mail.com",
                NormalizedEmail = "maria.georgieva@mail.com",
                FirstName = "Мария",
                LastName = "Георгиева",
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            SecondDoctorUser.PasswordHash =
                hasher.HashPassword(SecondDoctorUser, "maria123");

            SecondDoctor = new Doctor()
            {
                Id = SecondDoctorUser.Id,
                SpecializationId = NeurologySpecialization.Id
            };
        }

        private void SeedAdminInRole()
        {
            AdminRole = new IdentityRole<Guid>
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            };

            AdminInRole = new IdentityUserRole<Guid>
            {
                UserId = AdminUser.Id,
                RoleId = AdminRole.Id,
            };
        }
    }
}
