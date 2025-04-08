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
                values: new object[,]
                {
                    { new Guid("92fd9b84-4722-4e0c-9807-a310f7d406a9"), null, "Patient", "PATIENT" },
                    { new Guid("c883fa21-d196-4b08-b8e9-11e9b184a1af"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3d6b8b41-5912-4b58-b538-57a0fe9901e9"), 0, "faad381e-b88e-4e9c-bdad-45e8a17fbc47", "admin@mail.com", false, "Админ", "Админов", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAIAAYagAAAAEK0Y8frZNl1ieqOKrh3crbq6L3JDOW+bqUH0pxH/EzZw8lMlfoMLhOMKrd0aG5ztow==", null, false, "35c47275-9d0f-470c-911e-4c8cd461f897", false, "admin@mail.com" },
                    { new Guid("450eea46-7cb1-40c6-8289-cf6fd7f8e6be"), 0, "af31722f-3d8a-4248-bfef-72117f02e4fb", "ivan.petrov@mail.com", false, "Иван", "Петров", false, null, "ivan.petrov@mail.com", "ivan.petrov@mail.com", "AQAAAAIAAYagAAAAELTWJbnxvDpgL1NWB3tTjHwsQbrcXUqmcFnMPorBsV6jPP+eNHPfqZhfbnNN8ndRQw==", null, false, "b1936fa1-8700-498f-8b87-2bea71affb11", false, "ivan.petrov@mail.com" },
                    { new Guid("69e1bf98-ab82-4240-beac-376c8d51a023"), 0, "35e05388-8dd6-4431-9379-081210a5a2ef", "georgi.ivanov@mail.com", false, "Георги", "Иванов", false, null, "georgi.ivanov@mail.com", "georgi.ivanov@mail.com", "AQAAAAIAAYagAAAAEImLVDID9N3Q48i1iAqvfUIRaPh74sHN1jJJZ/KfVwtWoaJMyDO1XbbW6urqI00H0w==", null, false, "9dc96852-61ac-4111-a521-0d612f77d648", false, "georgi.ivanov@mail.com" },
                    { new Guid("82551aa1-593d-45f0-8b71-6ef5947ca701"), 0, "0b4f2997-e8ba-4f7a-b01f-0a54992fd09a", "elena.simeonova@mail.com", false, "Елена", "Симеонова", false, null, "elena.simeonova@mail.com", "elena.simeonova@mail.com", "AQAAAAIAAYagAAAAEPlUVdYBAipfz4tgd5AJvZiratJHVbrVjbwGqVH8Zyivzi10rKq+w8MGh8jm0Lp6KQ==", null, false, "f9c85c04-59fd-46d2-ab99-8c977c21164e", false, "elena.simeonova@mail.com" },
                    { new Guid("afb6f444-5453-4026-8a18-35e8e797cfb8"), 0, "65695a06-7862-4d77-a4d4-aa25d2752ed9", "maria.georgieva@mail.com", false, "Мария", "Георгиева", false, null, "maria.georgieva@mail.com", "maria.georgieva@mail.com", "AQAAAAIAAYagAAAAEHGFQxRRMk5gZsa+I7bxYVsdGQYhxu9SOVeo1Oq2j6v1pgUEbTv7qpBr9r9LNdXQwQ==", null, false, "0f1b4a13-178a-48b9-8f54-320d1378092f", false, "maria.georgieva@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0b7ef214-706b-4fd2-9a22-e45d0b2eb1f4"), "Кардиолог" },
                    { new Guid("dd8522e7-1750-4518-ab5e-64f5c5597aca"), "Невролог" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c883fa21-d196-4b08-b8e9-11e9b184a1af"), new Guid("3d6b8b41-5912-4b58-b538-57a0fe9901e9") },
                    { new Guid("92fd9b84-4722-4e0c-9807-a310f7d406a9"), new Guid("69e1bf98-ab82-4240-beac-376c8d51a023") },
                    { new Guid("92fd9b84-4722-4e0c-9807-a310f7d406a9"), new Guid("82551aa1-593d-45f0-8b71-6ef5947ca701") }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "SpecializationId" },
                values: new object[,]
                {
                    { new Guid("450eea46-7cb1-40c6-8289-cf6fd7f8e6be"), new Guid("0b7ef214-706b-4fd2-9a22-e45d0b2eb1f4") },
                    { new Guid("afb6f444-5453-4026-8a18-35e8e797cfb8"), new Guid("dd8522e7-1750-4518-ab5e-64f5c5597aca") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c883fa21-d196-4b08-b8e9-11e9b184a1af"), new Guid("3d6b8b41-5912-4b58-b538-57a0fe9901e9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("92fd9b84-4722-4e0c-9807-a310f7d406a9"), new Guid("69e1bf98-ab82-4240-beac-376c8d51a023") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("92fd9b84-4722-4e0c-9807-a310f7d406a9"), new Guid("82551aa1-593d-45f0-8b71-6ef5947ca701") });

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("450eea46-7cb1-40c6-8289-cf6fd7f8e6be"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("afb6f444-5453-4026-8a18-35e8e797cfb8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("92fd9b84-4722-4e0c-9807-a310f7d406a9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c883fa21-d196-4b08-b8e9-11e9b184a1af"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3d6b8b41-5912-4b58-b538-57a0fe9901e9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("450eea46-7cb1-40c6-8289-cf6fd7f8e6be"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("69e1bf98-ab82-4240-beac-376c8d51a023"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("82551aa1-593d-45f0-8b71-6ef5947ca701"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afb6f444-5453-4026-8a18-35e8e797cfb8"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("0b7ef214-706b-4fd2-9a22-e45d0b2eb1f4"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("dd8522e7-1750-4518-ab5e-64f5c5597aca"));
        }
    }
}
