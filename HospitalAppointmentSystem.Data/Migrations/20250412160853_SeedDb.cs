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
                    { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), null, "Patient", "PATIENT" },
                    { new Guid("a2c8ed8e-207f-4bff-96ad-e60eb020b220"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0474b09e-b40c-4a07-821b-608382e23074"), 0, 42, "4f2d512d-9d55-4112-8501-e995da5e4423", "doctor3@mail.com", false, "Станимир", "Мъж", "Колев", false, null, "DOCTOR3@MAIL.COM", "DOCTOR3@MAIL.COM", "AQAAAAEAACcQAAAAEP/5zxJPPx/zPP7+zbwsxz6rj9mJI/QvGV3KC+EXje9eJeT2rVM+vYzWCC9AuqqAAA==", null, false, "9d2cd0f8-d36a-4709-9298-10e09991a32e", false, "doctor3@mail.com" },
                    { new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), 0, 41, "eabc12c0-3e93-47b7-8185-cb728c8147eb", "doctor2@mail.com", false, "Виктория", "Жена", "Стоянова", false, null, "DOCTOR2@MAIL.COM", "DOCTOR2@MAIL.COM", "AQAAAAEAACcQAAAAEGQSxCiXHDVjC1dp3E4jm182JsCrpFZhcQ+etIir3TS0BRf9fEJ6SwRQcJ3D438wJA==", null, false, "38134987-3d84-4df7-ae9c-ed988122ba31", false, "doctor2@mail.com" },
                    { new Guid("248cf7a1-4b05-461f-a6a2-155f897921de"), 0, 44, "f9218698-aadf-4647-a0ed-d5e1ff241fff", "doctor5@mail.com", false, "Виктор", "Мъж", "Борисов", false, null, "DOCTOR5@MAIL.COM", "DOCTOR5@MAIL.COM", "AQAAAAEAACcQAAAAEAE6lhlO13nZeaETIYKFa4VHqbGBxJwJ8MYdch1zY2TiiscZOG5l8v2C3JqZe1GPoA==", null, false, "40b538a7-f23c-4a80-a725-0edec5b954a9", false, "doctor5@mail.com" },
                    { new Guid("27f342da-167d-43a6-a140-a63826b18da2"), 0, 26, "32194970-ebe0-4846-84d3-a6cff2a6083f", "patient2@mail.com", false, "Елена", "Жена", "Симеонова", false, null, "PATIENT2@MAIL.COM", "PATIENT2@MAIL.COM", "AQAAAAEAACcQAAAAEOlKJZyUZjGH6K6uF6415IkLwb4d2YkXvAl1FksXCQ0PqF4kQAFkz7fIgYBJDCpdRw==", null, false, "bccc80b9-53b4-4745-ab34-37723726d108", false, "patient2@mail.com" },
                    { new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), 0, 40, "dce4ae2e-723a-4ba3-907f-69c7e88b0e1e", "doctor1@mail.com", false, "Иван", "Мъж", "Петров", false, null, "DOCTOR1@MAIL.COM", "DOCTOR1@MAIL.COM", "AQAAAAEAACcQAAAAEOBksZMKtQuIxrp2bVHaTFA9lJYmDyNmAO5H/Sv0Hd6ZeB5a5Dov5kI6D7BeC3mSAw==", null, false, "cb31147e-0229-4c11-af86-2a1e1c0532e2", false, "doctor1@mail.com" },
                    { new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d"), 0, 27, "271dca0a-5fde-4cc9-8fc4-f4912d3ff427", "patient3@mail.com", false, "Петър", "Мъж", "Николов", false, null, "PATIENT3@MAIL.COM", "PATIENT3@MAIL.COM", "AQAAAAEAACcQAAAAEE3xG/laMFOFV4B+ab4MtiPdO3i3WAO0YFQQ+Vmi4mpomCV/MDnukvEC7WLBW5oeRA==", null, false, "57a9e70f-357b-42c9-9880-1f1da9dfb211", false, "patient3@mail.com" },
                    { new Guid("4eb44df6-f425-4243-bee9-e18d19968f06"), 0, 29, "29c5b84c-b157-44b4-accf-b5140d1c6a2e", "patient5@mail.com", false, "Ивайло", "Мъж", "Димитров", false, null, "PATIENT5@MAIL.COM", "PATIENT5@MAIL.COM", "AQAAAAEAACcQAAAAEBF3mM9z3Borf6wGQ+3/yzk+SvtYkIn4ojTatp7w0+pJmd0AmvKCLK3qbXiWOPFZ9w==", null, false, "5bbc0b4f-c8a6-4d63-9d6e-90880c83c0e2", false, "patient5@mail.com" },
                    { new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a"), 0, 25, "1cd445a0-e5d6-465d-826c-891b69983a16", "patient1@mail.com", false, "Георги", "Мъж", "Иванов", false, null, "PATIENT1@MAIL.COM", "PATIENT1@MAIL.COM", "AQAAAAEAACcQAAAAEIZcyBSyRCvjTSOf2LF/xfh/d8VIqYZp8UypGab47bhbQu6kXeZ9Ld/g3XZBGFOCCw==", null, false, "58b7de3d-25bc-486f-946b-74392c0c8d51", false, "patient1@mail.com" },
                    { new Guid("88e0d517-065a-49ab-bf2f-b9545e6791b1"), 0, 43, "faba99c9-de7c-43cf-8b0e-e557a4ad4152", "doctor4@mail.com", false, "Яна", "Жена", "Танева", false, null, "DOCTOR4@MAIL.COM", "DOCTOR4@MAIL.COM", "AQAAAAEAACcQAAAAEBTo2+6kpPTCzk2hA3emz5f9iAiyYYVB9T+z/I1mLRwo/dv6wgrnKmMEXnEG1FRGIg==", null, false, "e2dfade3-dc45-47f6-b6a2-6dc5394706de", false, "doctor4@mail.com" },
                    { new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009"), 0, 28, "419bac6a-56c2-44a7-a191-2a19fd6bdc67", "patient4@mail.com", false, "Мария", "Жена", "Тодорова", false, null, "PATIENT4@MAIL.COM", "PATIENT4@MAIL.COM", "AQAAAAEAACcQAAAAEJ7RBu9rATRCkO3aLaofoQ+zzS9eYaLJBkcZ+ZUD5+zivudPcCvnk+9UWP9ASX/uGQ==", null, false, "40b27e12-d967-4bdd-82f3-5bff11acb5d4", false, "patient4@mail.com" },
                    { new Guid("b2a9f3f8-70ef-4e4b-9214-61426bfe43df"), 0, 0, "8bbad1ee-4d7c-49e0-9fd7-6c83d268a7b9", "admin@mail.com", false, "Админ", "Друг", "Админов", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEGux4xH8kNXEcAm9EehvFGZ3hUPrGcP63DzriDkLBmFMLA8D1rxUKV65nL57Lj/S4Q==", null, false, "657b10c6-e643-429e-9404-d119888490c4", false, "admin@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ad750ee-b4d1-49ee-b4d8-349f7f54efd8"), "Ортопед" },
                    { new Guid("34f31b29-3a0e-4203-8a32-01ac8690e314"), "Дерматолог" },
                    { new Guid("d3495565-b898-4f91-b2b1-81907eee1249"), "Кардиолог" },
                    { new Guid("f4d444aa-ba0b-4ac3-a58f-5a34c317b29a"), "Невролог" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009") },
                    { new Guid("a2c8ed8e-207f-4bff-96ad-e60eb020b220"), new Guid("b2a9f3f8-70ef-4e4b-9214-61426bfe43df") }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "SpecializationId" },
                values: new object[,]
                {
                    { new Guid("0474b09e-b40c-4a07-821b-608382e23074"), new Guid("34f31b29-3a0e-4203-8a32-01ac8690e314") },
                    { new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), new Guid("f4d444aa-ba0b-4ac3-a58f-5a34c317b29a") },
                    { new Guid("248cf7a1-4b05-461f-a6a2-155f897921de"), new Guid("d3495565-b898-4f91-b2b1-81907eee1249") },
                    { new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), new Guid("d3495565-b898-4f91-b2b1-81907eee1249") },
                    { new Guid("88e0d517-065a-49ab-bf2f-b9545e6791b1"), new Guid("0ad750ee-b4d1-49ee-b4d8-349f7f54efd8") }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDateTime", "DoctorId", "IsDeleted", "PatientId" },
                values: new object[,]
                {
                    { new Guid("052496b2-68eb-45e3-a23d-95ba0beb862d"), new DateTime(2025, 2, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("0e20d835-ac99-40e3-98fe-5b09776f6fe0"), new DateTime(2025, 3, 12, 13, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("1249ffc1-3e3e-4c2c-a171-bd676cd61a1a"), new DateTime(2025, 4, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("1942c711-74a6-4c14-a7cb-0008992d50d0"), new DateTime(2025, 3, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("1c8b6619-b4c2-415f-9ace-137e9ee09eaa"), new DateTime(2025, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("1d79bfda-5689-4622-b1ed-782781ab6747"), new DateTime(2025, 4, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("24dbe302-b40a-4a12-9abd-9a6010a5d366"), new DateTime(2025, 2, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("2a74bed8-733b-41f4-a7bf-32144cbb1362"), new DateTime(2025, 3, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("2f3c1008-a8ef-4a08-ae84-a091ab93fbf1"), new DateTime(2025, 3, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("31126dc3-96d4-42af-9d82-cc7d4f5d5261"), new DateTime(2025, 3, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("3467edc2-c077-450a-b589-c38b03f0edbd"), new DateTime(2025, 3, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("382e3325-f8ed-4553-93c5-874c0c47ce11"), new DateTime(2025, 2, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("393458e5-cbbb-4d71-8777-828346d67dfe"), new DateTime(2025, 3, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("3ee0e249-e351-4218-8d43-d2bc58bbad26"), new DateTime(2025, 3, 11, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("41cfa92a-ff97-423d-8d0c-064e71f2b627"), new DateTime(2025, 2, 19, 15, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("446cb7af-e113-4d23-8f27-725332e0394d"), new DateTime(2025, 3, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("4871f900-8082-47bc-823d-8d8f5e6f2c24"), new DateTime(2025, 2, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("4e2615dd-35ae-46cc-b080-6348653e17f8"), new DateTime(2025, 3, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("5707228a-76cc-46bd-9818-7f79e922368a"), new DateTime(2025, 2, 18, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009") },
                    { new Guid("5f415103-635c-4634-b9ce-b4da537017a2"), new DateTime(2025, 2, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), new Guid("88e0d517-065a-49ab-bf2f-b9545e6791b1"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("60d4b19d-cfe3-466a-9a26-656e61f80749"), new DateTime(2025, 2, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("6170cb48-3031-44b3-87c2-de30e41ab79a"), new DateTime(2025, 3, 26, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("248cf7a1-4b05-461f-a6a2-155f897921de"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("64dddc66-5804-41cd-b051-60f20a622edc"), new DateTime(2025, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("6a124d66-072c-4aca-9b44-847c4640d3f8"), new DateTime(2025, 4, 8, 14, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("6dc70be1-4e2b-41a6-963d-f62b1dd23864"), new DateTime(2025, 2, 6, 13, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("753776d6-c099-443e-9a1e-8bb7d051a97a"), new DateTime(2025, 4, 4, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("7a632a32-f7be-4053-8fd1-17d00a978a9a"), new DateTime(2025, 2, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), new Guid("248cf7a1-4b05-461f-a6a2-155f897921de"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("7a910ff0-8d94-4b80-b3a1-bb41523950e0"), new DateTime(2025, 2, 21, 15, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("7b4df03b-2f57-4137-a30d-fc7139d9552b"), new DateTime(2025, 2, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("8df2fa2b-64a4-4369-8ead-a3ea0d7a1cdb"), new DateTime(2025, 2, 20, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("88e0d517-065a-49ab-bf2f-b9545e6791b1"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("8e49b6a3-baf0-4aea-9305-fef5650991b9"), new DateTime(2025, 3, 12, 13, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("90be8ee1-5bb4-41d4-b409-8b0e7f2ebb90"), new DateTime(2025, 3, 5, 14, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("91123b74-79b7-4803-94ca-32d924a233aa"), new DateTime(2025, 3, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("91a85cdd-f72b-420f-af04-770c18d4be3f"), new DateTime(2025, 3, 25, 15, 30, 0, 0, DateTimeKind.Unspecified), new Guid("88e0d517-065a-49ab-bf2f-b9545e6791b1"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("95315d13-1072-47dc-bed6-20e06a7df556"), new DateTime(2025, 2, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009") },
                    { new Guid("964a813c-eff6-46e5-879a-1494954ce8ba"), new DateTime(2025, 4, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("9dce4aec-d57b-407b-9de8-4ad7f04b0cdc"), new DateTime(2025, 2, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("9ec62beb-e40c-47ed-a5a0-f7007335f37c"), new DateTime(2025, 3, 18, 9, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("9fa1e77c-6fa6-4d9b-9b5f-058ff24b6eda"), new DateTime(2025, 3, 26, 15, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("a3548917-2546-4e5a-b84e-6613b6fcdf09"), new DateTime(2025, 3, 4, 14, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("a6bfc058-d44c-4227-8fd1-b31147b0cb3a"), new DateTime(2025, 3, 24, 15, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009") },
                    { new Guid("aa269968-3c28-489d-af93-7263ec1c37bd"), new DateTime(2025, 4, 9, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("b0bf14a6-8741-4c4e-a74b-84ece71ea253"), new DateTime(2025, 4, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("b0f432ae-9f3e-4cbc-ba2e-9e71a78d98ab"), new DateTime(2025, 2, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("b80b5a46-2611-42be-92fd-081058a2a829"), new DateTime(2025, 3, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("bf80af05-1aba-4890-9800-ea6ba6ab935b"), new DateTime(2025, 2, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009") },
                    { new Guid("bfc0623c-246d-4214-8bb7-d74832be08a3"), new DateTime(2025, 2, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009") },
                    { new Guid("c010937e-0471-4678-b0de-2b2016195ef3"), new DateTime(2025, 3, 18, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("88e0d517-065a-49ab-bf2f-b9545e6791b1"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("c5d35a4d-a4ce-4898-a245-b51b4ad52a56"), new DateTime(2025, 2, 27, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") },
                    { new Guid("c933f520-2956-4bbc-be40-0042ee83889f"), new DateTime(2025, 2, 27, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("cdd6c199-71a8-4941-b8f6-b7fbfcb3b5ba"), new DateTime(2025, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("cf14ee62-4e3e-40f9-9d06-ab628340d6ac"), new DateTime(2025, 4, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("d4733e99-f7a6-4a4a-8077-e23e8bd2c4ef"), new DateTime(2025, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88e0d517-065a-49ab-bf2f-b9545e6791b1"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("d4cc8af5-655f-4bc3-883e-f684e2c77545"), new DateTime(2025, 2, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("d852ea7a-1fc1-4707-a16d-ee5cd8c820c0"), new DateTime(2025, 2, 3, 13, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("dda049e1-e528-4cdd-a896-27dab901bb24"), new DateTime(2025, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("ddb502eb-5387-42a8-8062-992968592a13"), new DateTime(2025, 3, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("e805d376-575a-4cef-9380-19c1c5e17109"), new DateTime(2025, 3, 31, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("e88a0ae4-2ddb-400a-a3bb-17ddbff698eb"), new DateTime(2025, 2, 25, 14, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("e8fcc85c-990f-4d06-bfd8-8e8240c797d7"), new DateTime(2025, 4, 3, 13, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009") },
                    { new Guid("eb8f1e2b-005d-47b8-81c9-b0beaed7b2cd"), new DateTime(2025, 2, 21, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("ec360590-8ec6-4e04-a1c6-654cfbf91bc3"), new DateTime(2025, 3, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("f13f0923-1c69-484b-98ac-34d769c9536b"), new DateTime(2025, 2, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("f26c2321-5668-4e5e-a221-ea09e7306a11"), new DateTime(2025, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") },
                    { new Guid("f2c20ee6-95e5-4f45-ad9a-20ae40d64754"), new DateTime(2025, 2, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"), false, new Guid("27f342da-167d-43a6-a140-a63826b18da2") },
                    { new Guid("fc07145b-be67-4023-887e-c7614a1ded2b"), new DateTime(2025, 3, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") },
                    { new Guid("fe012971-4961-46dc-8808-1bafc1b3b935"), new DateTime(2025, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0474b09e-b40c-4a07-821b-608382e23074"), false, new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "AppointmentId", "Attitude", "Professionalism" },
                values: new object[,]
                {
                    { new Guid("0c6e1cf9-d753-4d90-a34d-e067d3d1c953"), new Guid("7a910ff0-8d94-4b80-b3a1-bb41523950e0"), 10m, 8m },
                    { new Guid("0ec83724-6a75-4519-9eab-fa8fa3dbae17"), new Guid("8e49b6a3-baf0-4aea-9305-fef5650991b9"), 7m, 9m },
                    { new Guid("11c0582a-877b-436b-9067-b097ac9159dd"), new Guid("b0bf14a6-8741-4c4e-a74b-84ece71ea253"), 9m, 9m },
                    { new Guid("15d0992d-f744-4a62-8720-93c5878783a7"), new Guid("7a632a32-f7be-4053-8fd1-17d00a978a9a"), 10m, 9m },
                    { new Guid("16ce12ea-3cde-4c30-8bb3-8878c7d6ded1"), new Guid("31126dc3-96d4-42af-9d82-cc7d4f5d5261"), 9m, 9m },
                    { new Guid("1a863759-bc69-4a0d-a548-9a44fd559678"), new Guid("95315d13-1072-47dc-bed6-20e06a7df556"), 10m, 8m },
                    { new Guid("1b739264-a1ae-4b7b-87d0-32593dddc9de"), new Guid("c010937e-0471-4678-b0de-2b2016195ef3"), 9m, 8m },
                    { new Guid("1c0d6a5f-3a47-42cc-9e36-c0d2e7d17131"), new Guid("24dbe302-b40a-4a12-9abd-9a6010a5d366"), 8m, 8m },
                    { new Guid("2660d173-8c5f-4d9b-b57b-0671e885cddf"), new Guid("0e20d835-ac99-40e3-98fe-5b09776f6fe0"), 8m, 10m },
                    { new Guid("2a37a5d2-6c01-4281-b06e-8729971a20ce"), new Guid("1c8b6619-b4c2-415f-9ace-137e9ee09eaa"), 7m, 8m },
                    { new Guid("31ddb090-10e7-48c8-b814-b5fd7a0d44aa"), new Guid("1d79bfda-5689-4622-b1ed-782781ab6747"), 8m, 7m },
                    { new Guid("35332c43-6412-4765-a44f-2409843a04e5"), new Guid("ddb502eb-5387-42a8-8062-992968592a13"), 7m, 9m },
                    { new Guid("3739cf6b-ed92-4c08-8032-80cb83defce4"), new Guid("ec360590-8ec6-4e04-a1c6-654cfbf91bc3"), 10m, 8m },
                    { new Guid("37eb0f7e-21c1-4d96-8b08-6fc3317d9ac3"), new Guid("3467edc2-c077-450a-b589-c38b03f0edbd"), 9m, 8m },
                    { new Guid("3835abb2-d92d-47a3-9e85-b649dd94c1e1"), new Guid("2f3c1008-a8ef-4a08-ae84-a091ab93fbf1"), 9m, 7m },
                    { new Guid("39447118-52c8-4626-a71f-d90fb59c5078"), new Guid("a6bfc058-d44c-4227-8fd1-b31147b0cb3a"), 10m, 10m },
                    { new Guid("3c9e3b78-8ea6-4dfd-a8a0-917eb031c53a"), new Guid("7b4df03b-2f57-4137-a30d-fc7139d9552b"), 8m, 10m },
                    { new Guid("411ab272-d666-4990-996a-5e8285cd56e0"), new Guid("3ee0e249-e351-4218-8d43-d2bc58bbad26"), 8m, 10m },
                    { new Guid("441271b2-c9eb-43f2-ac1c-b266c4605696"), new Guid("e805d376-575a-4cef-9380-19c1c5e17109"), 9m, 9m },
                    { new Guid("45bc2c65-98de-4fc4-bb7e-b7da8f5be3e3"), new Guid("e8fcc85c-990f-4d06-bfd8-8e8240c797d7"), 9m, 10m },
                    { new Guid("479abbb5-f2cc-4c11-a70f-06f8e0e59fa7"), new Guid("90be8ee1-5bb4-41d4-b409-8b0e7f2ebb90"), 10m, 9m },
                    { new Guid("49e9306e-4af9-44c5-9619-94ffd52bb774"), new Guid("91123b74-79b7-4803-94ca-32d924a233aa"), 10m, 7m },
                    { new Guid("4cf50c30-94ad-4282-b8d8-34831c5e1826"), new Guid("bfc0623c-246d-4214-8bb7-d74832be08a3"), 7m, 7m },
                    { new Guid("58ae04e5-161c-4ac2-8bbb-8f8722145e66"), new Guid("8df2fa2b-64a4-4369-8ead-a3ea0d7a1cdb"), 9m, 10m },
                    { new Guid("5c5380f6-53e0-41b4-830a-9f232a9ec14f"), new Guid("382e3325-f8ed-4553-93c5-874c0c47ce11"), 7m, 9m },
                    { new Guid("602f0ed9-3b4d-445a-9628-71e7cb6e22e3"), new Guid("f13f0923-1c69-484b-98ac-34d769c9536b"), 8m, 8m },
                    { new Guid("65902beb-0363-414d-b56d-48d3e2b6c527"), new Guid("4e2615dd-35ae-46cc-b080-6348653e17f8"), 8m, 8m },
                    { new Guid("66192e99-7bdf-4e9b-bb41-d1f53a2c3687"), new Guid("d4cc8af5-655f-4bc3-883e-f684e2c77545"), 9m, 8m },
                    { new Guid("73015d2e-850d-4f46-9f9f-0b279bbbc39e"), new Guid("b80b5a46-2611-42be-92fd-081058a2a829"), 8m, 8m },
                    { new Guid("757ceed4-cc99-4d92-94c9-012b7419a9d9"), new Guid("6a124d66-072c-4aca-9b44-847c4640d3f8"), 9m, 8m },
                    { new Guid("76119f2f-4e67-4985-9753-4aaa22fa7095"), new Guid("41cfa92a-ff97-423d-8d0c-064e71f2b627"), 9m, 8m },
                    { new Guid("78467ecf-5859-4574-bae5-33f7a87c28d4"), new Guid("052496b2-68eb-45e3-a23d-95ba0beb862d"), 8m, 8m },
                    { new Guid("7a999084-7b6d-4759-b43f-9c5091688c15"), new Guid("c5d35a4d-a4ce-4898-a245-b51b4ad52a56"), 10m, 9m },
                    { new Guid("80831d9a-4813-4741-9655-709bb25bc6f3"), new Guid("9fa1e77c-6fa6-4d9b-9b5f-058ff24b6eda"), 7m, 8m },
                    { new Guid("94c64559-0840-4440-bed4-afd63301114e"), new Guid("6dc70be1-4e2b-41a6-963d-f62b1dd23864"), 9m, 8m },
                    { new Guid("94f4aca2-b6be-49f6-a53e-7b912b71bf6a"), new Guid("c933f520-2956-4bbc-be40-0042ee83889f"), 9m, 10m },
                    { new Guid("9add6575-6f15-453d-8036-a32d95321ea3"), new Guid("bf80af05-1aba-4890-9800-ea6ba6ab935b"), 9m, 9m },
                    { new Guid("9f35cb4a-7921-4371-95a7-1c33d06223c8"), new Guid("60d4b19d-cfe3-466a-9a26-656e61f80749"), 8m, 9m },
                    { new Guid("a27db7c4-cabb-4f47-8555-bb5bb8b7dcec"), new Guid("fc07145b-be67-4023-887e-c7614a1ded2b"), 8m, 10m },
                    { new Guid("a395c3e7-9f8b-4f12-8ecc-8660ea94261b"), new Guid("f26c2321-5668-4e5e-a221-ea09e7306a11"), 9m, 9m },
                    { new Guid("a42cf7a2-ac0c-48f0-a0cc-6abc57c34103"), new Guid("cdd6c199-71a8-4941-b8f6-b7fbfcb3b5ba"), 8m, 10m },
                    { new Guid("acaabf8a-8bb9-4d66-be86-daa42b56db07"), new Guid("1942c711-74a6-4c14-a7cb-0008992d50d0"), 9m, 9m },
                    { new Guid("b172a154-31ec-4b77-9b35-fa1218c7fba9"), new Guid("2a74bed8-733b-41f4-a7bf-32144cbb1362"), 8m, 9m },
                    { new Guid("b9b5aa80-bcbc-4caa-a7c6-c50ac9743c98"), new Guid("aa269968-3c28-489d-af93-7263ec1c37bd"), 8m, 7m },
                    { new Guid("bfad4888-3147-4440-86ea-fc3cc023da01"), new Guid("d4733e99-f7a6-4a4a-8077-e23e8bd2c4ef"), 7m, 7m },
                    { new Guid("c40a990b-1e80-4466-b1cd-6a6601036ff4"), new Guid("d852ea7a-1fc1-4707-a16d-ee5cd8c820c0"), 9m, 8m },
                    { new Guid("c933e98a-dbad-4a7c-a8f0-060c1e162799"), new Guid("5707228a-76cc-46bd-9818-7f79e922368a"), 8m, 8m },
                    { new Guid("ca9e78ec-2d99-49a5-bd71-c718b79b57e1"), new Guid("64dddc66-5804-41cd-b051-60f20a622edc"), 10m, 10m },
                    { new Guid("cd480414-292d-4afe-96ca-128ca108a39c"), new Guid("eb8f1e2b-005d-47b8-81c9-b0beaed7b2cd"), 9m, 8m },
                    { new Guid("d502fe4f-dffe-489d-8b2b-6af13e0fbdfa"), new Guid("964a813c-eff6-46e5-879a-1494954ce8ba"), 10m, 8m },
                    { new Guid("d76e7677-e90a-4f76-ba13-c88a278e1a7e"), new Guid("f2c20ee6-95e5-4f45-ad9a-20ae40d64754"), 9m, 8m },
                    { new Guid("d91299c1-2545-4492-aeb3-ee462b5ca65a"), new Guid("4871f900-8082-47bc-823d-8d8f5e6f2c24"), 10m, 7m },
                    { new Guid("ea98339c-d764-4356-887d-0459a3a8d0b5"), new Guid("1249ffc1-3e3e-4c2c-a171-bd676cd61a1a"), 8m, 9m },
                    { new Guid("ebb1d54e-e17c-4c51-b8b3-a2e5cff860c4"), new Guid("446cb7af-e113-4d23-8f27-725332e0394d"), 7m, 9m },
                    { new Guid("efbb1bca-9957-4f30-9651-c099e952d679"), new Guid("a3548917-2546-4e5a-b84e-6613b6fcdf09"), 10m, 8m },
                    { new Guid("f3393077-3de9-4aa2-b1ce-d3f4d6615751"), new Guid("b0f432ae-9f3e-4cbc-ba2e-9e71a78d98ab"), 8m, 8m },
                    { new Guid("f7e1f18b-3c11-4552-8656-81e7dfc1c70d"), new Guid("9dce4aec-d57b-407b-9de8-4ad7f04b0cdc"), 8m, 9m },
                    { new Guid("fc0a5717-62a7-4e7a-b7b8-53f83f2212a2"), new Guid("753776d6-c099-443e-9a1e-8bb7d051a97a"), 8m, 7m },
                    { new Guid("fdd44599-bc7d-47d5-8fc2-3408adfd4fba"), new Guid("9ec62beb-e40c-47ed-a5a0-f7007335f37c"), 8m, 10m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("393458e5-cbbb-4d71-8777-828346d67dfe"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5f415103-635c-4634-b9ce-b4da537017a2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6170cb48-3031-44b3-87c2-de30e41ab79a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("91a85cdd-f72b-420f-af04-770c18d4be3f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("cf14ee62-4e3e-40f9-9d06-ab628340d6ac"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("dda049e1-e528-4cdd-a896-27dab901bb24"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e88a0ae4-2ddb-400a-a3bb-17ddbff698eb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fe012971-4961-46dc-8808-1bafc1b3b935"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("27f342da-167d-43a6-a140-a63826b18da2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("4eb44df6-f425-4243-bee9-e18d19968f06") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"), new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a2c8ed8e-207f-4bff-96ad-e60eb020b220"), new Guid("b2a9f3f8-70ef-4e4b-9214-61426bfe43df") });

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0c6e1cf9-d753-4d90-a34d-e067d3d1c953"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0ec83724-6a75-4519-9eab-fa8fa3dbae17"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("11c0582a-877b-436b-9067-b097ac9159dd"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("15d0992d-f744-4a62-8720-93c5878783a7"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("16ce12ea-3cde-4c30-8bb3-8878c7d6ded1"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("1a863759-bc69-4a0d-a548-9a44fd559678"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("1b739264-a1ae-4b7b-87d0-32593dddc9de"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("1c0d6a5f-3a47-42cc-9e36-c0d2e7d17131"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("2660d173-8c5f-4d9b-b57b-0671e885cddf"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("2a37a5d2-6c01-4281-b06e-8729971a20ce"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("31ddb090-10e7-48c8-b814-b5fd7a0d44aa"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("35332c43-6412-4765-a44f-2409843a04e5"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3739cf6b-ed92-4c08-8032-80cb83defce4"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("37eb0f7e-21c1-4d96-8b08-6fc3317d9ac3"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3835abb2-d92d-47a3-9e85-b649dd94c1e1"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("39447118-52c8-4626-a71f-d90fb59c5078"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("3c9e3b78-8ea6-4dfd-a8a0-917eb031c53a"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("411ab272-d666-4990-996a-5e8285cd56e0"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("441271b2-c9eb-43f2-ac1c-b266c4605696"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("45bc2c65-98de-4fc4-bb7e-b7da8f5be3e3"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("479abbb5-f2cc-4c11-a70f-06f8e0e59fa7"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("49e9306e-4af9-44c5-9619-94ffd52bb774"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4cf50c30-94ad-4282-b8d8-34831c5e1826"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("58ae04e5-161c-4ac2-8bbb-8f8722145e66"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("5c5380f6-53e0-41b4-830a-9f232a9ec14f"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("602f0ed9-3b4d-445a-9628-71e7cb6e22e3"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("65902beb-0363-414d-b56d-48d3e2b6c527"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("66192e99-7bdf-4e9b-bb41-d1f53a2c3687"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("73015d2e-850d-4f46-9f9f-0b279bbbc39e"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("757ceed4-cc99-4d92-94c9-012b7419a9d9"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("76119f2f-4e67-4985-9753-4aaa22fa7095"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("78467ecf-5859-4574-bae5-33f7a87c28d4"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7a999084-7b6d-4759-b43f-9c5091688c15"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("80831d9a-4813-4741-9655-709bb25bc6f3"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("94c64559-0840-4440-bed4-afd63301114e"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("94f4aca2-b6be-49f6-a53e-7b912b71bf6a"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9add6575-6f15-453d-8036-a32d95321ea3"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9f35cb4a-7921-4371-95a7-1c33d06223c8"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("a27db7c4-cabb-4f47-8555-bb5bb8b7dcec"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("a395c3e7-9f8b-4f12-8ecc-8660ea94261b"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("a42cf7a2-ac0c-48f0-a0cc-6abc57c34103"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("acaabf8a-8bb9-4d66-be86-daa42b56db07"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("b172a154-31ec-4b77-9b35-fa1218c7fba9"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("b9b5aa80-bcbc-4caa-a7c6-c50ac9743c98"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bfad4888-3147-4440-86ea-fc3cc023da01"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("c40a990b-1e80-4466-b1cd-6a6601036ff4"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("c933e98a-dbad-4a7c-a8f0-060c1e162799"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ca9e78ec-2d99-49a5-bd71-c718b79b57e1"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("cd480414-292d-4afe-96ca-128ca108a39c"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d502fe4f-dffe-489d-8b2b-6af13e0fbdfa"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d76e7677-e90a-4f76-ba13-c88a278e1a7e"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d91299c1-2545-4492-aeb3-ee462b5ca65a"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ea98339c-d764-4356-887d-0459a3a8d0b5"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ebb1d54e-e17c-4c51-b8b3-a2e5cff860c4"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("efbb1bca-9957-4f30-9651-c099e952d679"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("f3393077-3de9-4aa2-b1ce-d3f4d6615751"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("f7e1f18b-3c11-4552-8656-81e7dfc1c70d"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fc0a5717-62a7-4e7a-b7b8-53f83f2212a2"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fdd44599-bc7d-47d5-8fc2-3408adfd4fba"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("052496b2-68eb-45e3-a23d-95ba0beb862d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0e20d835-ac99-40e3-98fe-5b09776f6fe0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1249ffc1-3e3e-4c2c-a171-bd676cd61a1a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1942c711-74a6-4c14-a7cb-0008992d50d0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1c8b6619-b4c2-415f-9ace-137e9ee09eaa"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1d79bfda-5689-4622-b1ed-782781ab6747"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("24dbe302-b40a-4a12-9abd-9a6010a5d366"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2a74bed8-733b-41f4-a7bf-32144cbb1362"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2f3c1008-a8ef-4a08-ae84-a091ab93fbf1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("31126dc3-96d4-42af-9d82-cc7d4f5d5261"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3467edc2-c077-450a-b589-c38b03f0edbd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("382e3325-f8ed-4553-93c5-874c0c47ce11"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3ee0e249-e351-4218-8d43-d2bc58bbad26"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("41cfa92a-ff97-423d-8d0c-064e71f2b627"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("446cb7af-e113-4d23-8f27-725332e0394d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4871f900-8082-47bc-823d-8d8f5e6f2c24"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4e2615dd-35ae-46cc-b080-6348653e17f8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5707228a-76cc-46bd-9818-7f79e922368a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("60d4b19d-cfe3-466a-9a26-656e61f80749"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("64dddc66-5804-41cd-b051-60f20a622edc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6a124d66-072c-4aca-9b44-847c4640d3f8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6dc70be1-4e2b-41a6-963d-f62b1dd23864"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("753776d6-c099-443e-9a1e-8bb7d051a97a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7a632a32-f7be-4053-8fd1-17d00a978a9a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7a910ff0-8d94-4b80-b3a1-bb41523950e0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7b4df03b-2f57-4137-a30d-fc7139d9552b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8df2fa2b-64a4-4369-8ead-a3ea0d7a1cdb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8e49b6a3-baf0-4aea-9305-fef5650991b9"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("90be8ee1-5bb4-41d4-b409-8b0e7f2ebb90"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("91123b74-79b7-4803-94ca-32d924a233aa"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("95315d13-1072-47dc-bed6-20e06a7df556"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("964a813c-eff6-46e5-879a-1494954ce8ba"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9dce4aec-d57b-407b-9de8-4ad7f04b0cdc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9ec62beb-e40c-47ed-a5a0-f7007335f37c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9fa1e77c-6fa6-4d9b-9b5f-058ff24b6eda"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a3548917-2546-4e5a-b84e-6613b6fcdf09"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a6bfc058-d44c-4227-8fd1-b31147b0cb3a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("aa269968-3c28-489d-af93-7263ec1c37bd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b0bf14a6-8741-4c4e-a74b-84ece71ea253"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b0f432ae-9f3e-4cbc-ba2e-9e71a78d98ab"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b80b5a46-2611-42be-92fd-081058a2a829"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("bf80af05-1aba-4890-9800-ea6ba6ab935b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("bfc0623c-246d-4214-8bb7-d74832be08a3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c010937e-0471-4678-b0de-2b2016195ef3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c5d35a4d-a4ce-4898-a245-b51b4ad52a56"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c933f520-2956-4bbc-be40-0042ee83889f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("cdd6c199-71a8-4941-b8f6-b7fbfcb3b5ba"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d4733e99-f7a6-4a4a-8077-e23e8bd2c4ef"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d4cc8af5-655f-4bc3-883e-f684e2c77545"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d852ea7a-1fc1-4707-a16d-ee5cd8c820c0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ddb502eb-5387-42a8-8062-992968592a13"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e805d376-575a-4cef-9380-19c1c5e17109"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e8fcc85c-990f-4d06-bfd8-8e8240c797d7"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("eb8f1e2b-005d-47b8-81c9-b0beaed7b2cd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ec360590-8ec6-4e04-a1c6-654cfbf91bc3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f13f0923-1c69-484b-98ac-34d769c9536b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f26c2321-5668-4e5e-a221-ea09e7306a11"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f2c20ee6-95e5-4f45-ad9a-20ae40d64754"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fc07145b-be67-4023-887e-c7614a1ded2b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("913c67ca-b617-487b-a742-5c2ad69bf257"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2c8ed8e-207f-4bff-96ad-e60eb020b220"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b2a9f3f8-70ef-4e4b-9214-61426bfe43df"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("27f342da-167d-43a6-a140-a63826b18da2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("346499bb-4636-4791-93c8-7ef0fd32a87d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4eb44df6-f425-4243-bee9-e18d19968f06"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("74f6ca22-d948-4352-b4ba-722ed47b676a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab61bdab-b0ff-42e2-bd61-e2e389b8b009"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0474b09e-b40c-4a07-821b-608382e23074"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("248cf7a1-4b05-461f-a6a2-155f897921de"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("88e0d517-065a-49ab-bf2f-b9545e6791b1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0474b09e-b40c-4a07-821b-608382e23074"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("14108175-e9b7-41e4-a85b-e69b16df9b60"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("248cf7a1-4b05-461f-a6a2-155f897921de"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a023c7e-5733-4364-aed5-fc81fbd673dc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88e0d517-065a-49ab-bf2f-b9545e6791b1"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("0ad750ee-b4d1-49ee-b4d8-349f7f54efd8"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("34f31b29-3a0e-4203-8a32-01ac8690e314"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("d3495565-b898-4f91-b2b1-81907eee1249"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("f4d444aa-ba0b-4ac3-a58f-5a34c317b29a"));
        }
    }
}
