using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalAppointmentSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("49909919-cb78-4b6e-a71c-d3e06e3e1ad8"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("13e3dad7-c62d-48f3-86d7-d493e3893dd4"), 0, "5349fb9c-b6d8-42ff-a915-993436e93c10", "elena.simeonova@mail.com", false, "Елена", "Симеонова", false, null, "elena.simeonova@mail.com", "elena.simeonova", "AQAAAAIAAYagAAAAEBeFNL/1e7PVDHnjA1WhZaZ84n70Y4CD9Me3jseGRk2rjbdwk7xqP1GZRFuzUcfLKA==", null, false, "4cc05338-a1db-4f8c-9575-0bebad2e4483", false, "elena.simeonova" },
                    { new Guid("3441ba80-a702-49fa-b95b-072d817b09aa"), 0, "c6d83a7e-ba4e-4c12-b88c-28e2674dc497", "georgi.ivanov@mail.com", false, "Георги", "Иванов", false, null, "georgi.ivanov@mail.com", "georgi.ivanov", "AQAAAAIAAYagAAAAEF76wey2DByX0HyWsOz4jTixDXE8/RShSsEYYFT75mjBPq7JgTXVRxtrr/VsnuCF4g==", null, false, "01c54532-6555-4d14-976c-fd9e24358058", false, "georgi.ivanov" },
                    { new Guid("840dc7e0-7f6f-4e39-b6e0-3b00e72b4d57"), 0, "3ec3902b-1c42-4f51-b564-ec34143d04c5", "maria.georgieva@mail.com", false, "Мария", "Георгиева", false, null, "maria.georgieva@mail.com", "maria.georgieva", "AQAAAAIAAYagAAAAEMTToAgGxflGLEmReodqcaMWqxN+Brr9nmZ5YO/kRj/BPO0MsL8Mn7KAsAt2PvJoMw==", null, false, "fa839606-c749-4d7c-b4bf-6531280913c3", false, "maria.georgieva" },
                    { new Guid("99514004-7d19-4c49-8078-b586a00556ef"), 0, "28d58c23-56cd-4352-adf7-a94c80be0b0a", "ivan.petrov@mail.com", false, "Иван", "Петров", false, null, "ivan.petrov@mail.com", "ivan.petrov", "AQAAAAIAAYagAAAAECvS309N66Tswv7QqedE6CO/h9nT7Gd5EHIFqWpExReD1a3dziPHW+Z/KoUXBvvjHg==", null, false, "8c3bb87f-26d3-4812-995e-3d36e6b1c799", false, "ivan.petrov" },
                    { new Guid("d7d3ce60-901c-49aa-8034-1e8bf56ea24b"), 0, "7fb4cad2-7061-471b-9210-afd7134493ba", "admin@mail.com", false, "Админ", "Админов", false, null, "admin@mail.com", "admin", "AQAAAAIAAYagAAAAEEPI2cLASd1a+eVLk16crCkUj7St+9hXfepcZx8cY1Y9GuQfmrEhALR5ingfscLPAQ==", null, false, "7f2a0a7d-926e-4c05-a5c6-563ee7120d38", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2a38c763-f02d-4462-b4a8-3db8fe07c40b"), "Невролог" },
                    { new Guid("a23cdf24-2cc1-4a7e-83bc-9c60e6e1ad81"), "Кардиолог" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("49909919-cb78-4b6e-a71c-d3e06e3e1ad8"), new Guid("d7d3ce60-901c-49aa-8034-1e8bf56ea24b") });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "SpecializationId" },
                values: new object[,]
                {
                    { new Guid("840dc7e0-7f6f-4e39-b6e0-3b00e72b4d57"), new Guid("2a38c763-f02d-4462-b4a8-3db8fe07c40b") },
                    { new Guid("99514004-7d19-4c49-8078-b586a00556ef"), new Guid("a23cdf24-2cc1-4a7e-83bc-9c60e6e1ad81") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                column: "Id",
                values: new object[]
                {
                    new Guid("13e3dad7-c62d-48f3-86d7-d493e3893dd4"),
                    new Guid("3441ba80-a702-49fa-b95b-072d817b09aa")
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("49909919-cb78-4b6e-a71c-d3e06e3e1ad8"), new Guid("d7d3ce60-901c-49aa-8034-1e8bf56ea24b") });

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("840dc7e0-7f6f-4e39-b6e0-3b00e72b4d57"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("99514004-7d19-4c49-8078-b586a00556ef"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("13e3dad7-c62d-48f3-86d7-d493e3893dd4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3441ba80-a702-49fa-b95b-072d817b09aa"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("49909919-cb78-4b6e-a71c-d3e06e3e1ad8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13e3dad7-c62d-48f3-86d7-d493e3893dd4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3441ba80-a702-49fa-b95b-072d817b09aa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("840dc7e0-7f6f-4e39-b6e0-3b00e72b4d57"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("99514004-7d19-4c49-8078-b586a00556ef"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7d3ce60-901c-49aa-8034-1e8bf56ea24b"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("2a38c763-f02d-4462-b4a8-3db8fe07c40b"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("a23cdf24-2cc1-4a7e-83bc-9c60e6e1ad81"));
        }
    }
}
