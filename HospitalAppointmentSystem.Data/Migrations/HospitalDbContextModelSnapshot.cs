﻿// <auto-generated />
using System;
using HospitalAppointmentSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalAppointmentSystem.Data.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    partial class HospitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d7d3ce60-901c-49aa-8034-1e8bf56ea24b"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7fb4cad2-7061-471b-9210-afd7134493ba",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Админ",
                            LastName = "Админов",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@mail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEEPI2cLASd1a+eVLk16crCkUj7St+9hXfepcZx8cY1Y9GuQfmrEhALR5ingfscLPAQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f2a0a7d-926e-4c05-a5c6-563ee7120d38",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("3441ba80-a702-49fa-b95b-072d817b09aa"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c6d83a7e-ba4e-4c12-b88c-28e2674dc497",
                            Email = "georgi.ivanov@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Георги",
                            LastName = "Иванов",
                            LockoutEnabled = false,
                            NormalizedEmail = "georgi.ivanov@mail.com",
                            NormalizedUserName = "georgi.ivanov",
                            PasswordHash = "AQAAAAIAAYagAAAAEF76wey2DByX0HyWsOz4jTixDXE8/RShSsEYYFT75mjBPq7JgTXVRxtrr/VsnuCF4g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "01c54532-6555-4d14-976c-fd9e24358058",
                            TwoFactorEnabled = false,
                            UserName = "georgi.ivanov"
                        },
                        new
                        {
                            Id = new Guid("13e3dad7-c62d-48f3-86d7-d493e3893dd4"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5349fb9c-b6d8-42ff-a915-993436e93c10",
                            Email = "elena.simeonova@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Елена",
                            LastName = "Симеонова",
                            LockoutEnabled = false,
                            NormalizedEmail = "elena.simeonova@mail.com",
                            NormalizedUserName = "elena.simeonova",
                            PasswordHash = "AQAAAAIAAYagAAAAEBeFNL/1e7PVDHnjA1WhZaZ84n70Y4CD9Me3jseGRk2rjbdwk7xqP1GZRFuzUcfLKA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4cc05338-a1db-4f8c-9575-0bebad2e4483",
                            TwoFactorEnabled = false,
                            UserName = "elena.simeonova"
                        },
                        new
                        {
                            Id = new Guid("99514004-7d19-4c49-8078-b586a00556ef"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "28d58c23-56cd-4352-adf7-a94c80be0b0a",
                            Email = "ivan.petrov@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Иван",
                            LastName = "Петров",
                            LockoutEnabled = false,
                            NormalizedEmail = "ivan.petrov@mail.com",
                            NormalizedUserName = "ivan.petrov",
                            PasswordHash = "AQAAAAIAAYagAAAAECvS309N66Tswv7QqedE6CO/h9nT7Gd5EHIFqWpExReD1a3dziPHW+Z/KoUXBvvjHg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8c3bb87f-26d3-4812-995e-3d36e6b1c799",
                            TwoFactorEnabled = false,
                            UserName = "ivan.petrov"
                        },
                        new
                        {
                            Id = new Guid("840dc7e0-7f6f-4e39-b6e0-3b00e72b4d57"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3ec3902b-1c42-4f51-b564-ec34143d04c5",
                            Email = "maria.georgieva@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Мария",
                            LastName = "Георгиева",
                            LockoutEnabled = false,
                            NormalizedEmail = "maria.georgieva@mail.com",
                            NormalizedUserName = "maria.georgieva",
                            PasswordHash = "AQAAAAIAAYagAAAAEMTToAgGxflGLEmReodqcaMWqxN+Brr9nmZ5YO/kRj/BPO0MsL8Mn7KAsAt2PvJoMw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fa839606-c749-4d7c-b4bf-6531280913c3",
                            TwoFactorEnabled = false,
                            UserName = "maria.georgieva"
                        });
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Appointment Identifier");

                    b.Property<DateTime>("AppointmentDateTime")
                        .HasColumnType("datetime2")
                        .HasComment("Appointment date and time");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Doctor Identifier");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Patient Identifier");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Doctor Identifier");

                    b.Property<Guid>("SpecializationId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Specialization Identifier");

                    b.HasKey("Id");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("99514004-7d19-4c49-8078-b586a00556ef"),
                            SpecializationId = new Guid("a23cdf24-2cc1-4a7e-83bc-9c60e6e1ad81")
                        },
                        new
                        {
                            Id = new Guid("840dc7e0-7f6f-4e39-b6e0-3b00e72b4d57"),
                            SpecializationId = new Guid("2a38c763-f02d-4462-b4a8-3db8fe07c40b")
                        });
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Patient Identifier");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3441ba80-a702-49fa-b95b-072d817b09aa")
                        },
                        new
                        {
                            Id = new Guid("13e3dad7-c62d-48f3-86d7-d493e3893dd4")
                        });
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Rating Identifier");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Appointment Identifier");

                    b.Property<decimal>("Attitude")
                        .HasColumnType("decimal(4,2)")
                        .HasComment("Doctor Attitude");

                    b.Property<decimal>("Professionalism")
                        .HasColumnType("decimal(4,2)")
                        .HasComment("Doctor Professionalism");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Specialization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Specialization Identifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Specialization Name");

                    b.HasKey("Id");

                    b.ToTable("Specializations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a23cdf24-2cc1-4a7e-83bc-9c60e6e1ad81"),
                            Name = "Кардиолог"
                        },
                        new
                        {
                            Id = new Guid("2a38c763-f02d-4462-b4a8-3db8fe07c40b"),
                            Name = "Невролог"
                        });
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Vacation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Vacation Identifier");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Doctor Identifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasComment("Vacation End Date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasComment("Vacation Start Date");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("49909919-cb78-4b6e-a71c-d3e06e3e1ad8"),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("d7d3ce60-901c-49aa-8034-1e8bf56ea24b"),
                            RoleId = new Guid("49909919-cb78-4b6e-a71c-d3e06e3e1ad8")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Appointment", b =>
                {
                    b.HasOne("HospitalAppointmentSystem.Data.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HospitalAppointmentSystem.Data.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Doctor", b =>
                {
                    b.HasOne("HospitalAppointmentSystem.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAppointmentSystem.Data.Models.Specialization", "Specialization")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Specialization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Patient", b =>
                {
                    b.HasOne("HospitalAppointmentSystem.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Rating", b =>
                {
                    b.HasOne("HospitalAppointmentSystem.Data.Models.Appointment", "Appointment")
                        .WithOne("Rating")
                        .HasForeignKey("HospitalAppointmentSystem.Data.Models.Rating", "AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Vacation", b =>
                {
                    b.HasOne("HospitalAppointmentSystem.Data.Models.Doctor", "Doctor")
                        .WithMany("Vacations")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("HospitalAppointmentSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("HospitalAppointmentSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAppointmentSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("HospitalAppointmentSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Appointment", b =>
                {
                    b.Navigation("Rating");
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Vacations");
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("HospitalAppointmentSystem.Data.Models.Specialization", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
