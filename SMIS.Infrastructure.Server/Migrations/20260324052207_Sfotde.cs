using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class Sfotde : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Translations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Translations",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "TranslationKeys",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TranslationKeys",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ShopOwner",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ShopOwner",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Shop",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Shop",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Provinces",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Provinces",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductPrice",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductPrice",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Product",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "LoanAccountPayment",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LoanAccountPayment",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "LoanAccount",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LoanAccount",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Districts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Districts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Category",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Category",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "AppLogs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395c5a0e-ded9-46dc-8e15-b4efeb2055cd", "AQAAAAIAAYagAAAAEP/0xkXRE5nLLhVrrmYLnkW9YB/2F8GTnERmEUdmAtQx+iOBIJxuH360JUQ3T2YtuQ==", "5d1d5cc3-8d4f-42b9-9838-188237872646" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3348e266-9cee-4c1b-99f7-f92c869b9855", "AQAAAAIAAYagAAAAEJoyRXvKAu6bHfJ4qLkJxsK6g247h3lYOI064xmDUqcdjfQmZRyd86/Hi9gxbCWSpA==", "cf4960d9-68bc-4afa-8784-58c2899b44ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a86f6a5-dcf7-403a-a1ff-ac34a6f349f6", "AQAAAAIAAYagAAAAEMzD72Vx3swgS6FnzlWv7N0u8AfrCUCa5J5sF1YrwQRsyRiAkVKi/BywiQzR+JnSUA==", "42b6d28e-9078-41a0-94fb-ea3bba9de365" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7108501-2fe4-4d1f-bb1a-d71dd7adaa55", "AQAAAAIAAYagAAAAEEFCpUHiT8R2U7R8ZrveaGyGOv+MlMwGgvH23dEW4dsoh0KYLftbRofRQ436sZGaYw==", "dd9cc2ed-0ea0-407a-9e17-ce87a567b6e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dbc2b8a-1512-420d-b22d-bbabd1f51514", "AQAAAAIAAYagAAAAEIkFLJmLXXoCmLkf/GLQIY8CYjovwIQkkoD3mxJ7dn9jZr15umSxAhAX6W6OdnxFNw==", "7d0fbb9b-40e8-48e5-9661-07edc05503eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6da4daa-9357-498a-a9f4-1079cf602435", "AQAAAAIAAYagAAAAEFT2XqGPP9Rb1mfjEFwbnc+4uXHWyZrols/zbpTuvX8/t6dVcsgd3nNVKikW8ZRJqg==", "ffaad652-a715-47de-95e3-00d1c62a8f90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70c54dc5-a65c-4f60-8660-ac21e0d0491e", "AQAAAAIAAYagAAAAEBmVdwr5aqqp2a7Y/W7Dp9sMxJxYXUmhS3QyhMmkJTDfMD7F+7gY1qrDcSE50FobTw==", "7e8ae369-4168-4784-b316-b4aba329658c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d91ed95f-9d08-4856-b54c-c2bc94153eef", "AQAAAAIAAYagAAAAEB59Rk4GCisj8XNkZ1uRy6vbc2nQJgm9NrdMVaW/b7lDQahqJmehozlBBq3aA+znFg==", "6f2cc2d8-e7c0-41e7-b5ff-7b431cb338fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84e22e44-f7c6-4042-8f68-101523560db0", "AQAAAAIAAYagAAAAEIjxvoen01CHjwZKXW2JX3zYQuvZ9LWoXu2ZGcdTtLZhLe/05cPVv6F13Vlx2GRR5w==", "0d4cd748-6fa5-4fd2-969b-bbcd0a38dc95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3169ec6c-1ecb-45a4-bd1a-ffee3b7fff76", "AQAAAAIAAYagAAAAEFyMy1PDDTAshDLtvn5E5PNv8O+9VBY3LtXzf9qjQFLHOnaarS/cPE58wC3/bFmoRA==", "8e396b86-20ce-4ec8-af80-49b85dd08a18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "333eadaf-3dd7-4b55-b761-9f7196a0c108", "AQAAAAIAAYagAAAAEBvLKRk0w2TXUaP+BgbRjAQYjKa0gaHGJP21GBt80PxKpa1h2f5NUvrMPVcLq4XNsg==", "24ae20c9-a4fb-4bf8-abe9-112124da6ba7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eccb32d-72e6-4e44-82c4-588769f5f422", "AQAAAAIAAYagAAAAEFXwRkyH5RrQSYC4pDpAMfXpJEud9GoABIZ2ZKGH2y1MBXQ4wjWFtJqBmngugFGUfw==", "a33b16a3-9f64-430f-b113-1a142b88e61b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9009bc2a-b47c-4e07-b8a0-385c3a99fe39", "AQAAAAIAAYagAAAAENmWzIfLvjeVk9GESIDAgYzmwOd6soqQ84l7AxpigCWne5oL7o3wYEj1C+hly4fk8g==", "3b8566d0-428c-41d4-a53d-17e48f19d036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b6809bf-5d7a-4ed3-890e-714187df9ee6", "AQAAAAIAAYagAAAAECE9JeDHkE31fLoT9Na5RyxEs6k+u2NlT5Eng+36+/Akjx2Jn8fSi/smy0UDLxWgNA==", "32f001a4-d677-40b4-b6aa-aecc3c9a1da0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7cd945d-67a4-49d2-bb0f-b43a39957db4", "AQAAAAIAAYagAAAAEMZnezWwrqT1RjlzNF4mvcuSutWCkdXbBJlqAVZzn8gw9Qa2NCfJqu7f5CHLsRXYUA==", "9761cb7b-85c9-4756-a322-59f28aaf09bd" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(402), null, false, "2026-03-24 05:22:06.027040", new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(419), null, false, "2026-03-24 05:22:06.027042", new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(423), null, false, "2026-03-24 05:22:06.027042", new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(426), null, false, "2026-03-24 05:22:06.027042", new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(429), null, false, "2026-03-24 05:22:06.027043", new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(438), null, false, "2026-03-24 05:22:06.027043", new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(9178), "2026-03-24 05:22:06.027937", new DateTime(2026, 3, 24, 5, 22, 6, 27, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3431), "2026-03-24 05:22:06.028343", new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(499), "2026-03-24 05:22:06.028111", new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(2298), "2026-03-24 05:22:06.028304", new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3352), "2026-03-24 05:22:06.028335", new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3368), "2026-03-24 05:22:06.028337", new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3381), "2026-03-24 05:22:06.028338", new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3392), "2026-03-24 05:22:06.028339", new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3408), "2026-03-24 05:22:06.028341", new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3419), "2026-03-24 05:22:06.028342", new DateTime(2026, 3, 24, 5, 22, 6, 28, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020991" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.021007" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.021008" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.019878");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.019909");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.019910");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DeletedAt", "DueDate", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 335, DateTimeKind.Utc).AddTicks(7259), null, new DateTime(2026, 4, 23, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), false, "2026-03-24 05:22:05.335761", new DateTime(2026, 2, 22, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 335, DateTimeKind.Utc).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DeletedAt", "DueDate", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6803), null, new DateTime(2026, 4, 20, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), false, "2026-03-24 05:22:05.336680", new DateTime(2026, 3, 21, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DeletedAt", "DueDate", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(2957), null, new DateTime(2026, 4, 8, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), false, "2026-03-24 05:22:05.336359", new DateTime(2026, 3, 9, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DeletedAt", "DueDate", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(5647), null, new DateTime(2026, 4, 13, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), false, "2026-03-24 05:22:05.336636", new DateTime(2026, 3, 14, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DeletedAt", "DueDate", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6658), null, new DateTime(2026, 5, 8, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), false, "2026-03-24 05:22:05.336666", new DateTime(2026, 3, 19, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DeletedAt", "DueDate", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6680), null, new DateTime(2026, 4, 3, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), false, "2026-03-24 05:22:05.336668", new DateTime(2026, 3, 4, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DeletedAt", "DueDate", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6696), null, new DateTime(2026, 4, 11, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), false, "2026-03-24 05:22:05.336669", new DateTime(2026, 3, 12, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6711), null, false, "2026-03-24 05:22:05.336671", new DateTime(2026, 2, 27, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DeletedAt", "DueDate", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6773), null, new DateTime(2026, 4, 5, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), false, "2026-03-24 05:22:05.336677", new DateTime(2026, 3, 6, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DeletedAt", "DueDate", "IsDeleted", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6789), null, new DateTime(2026, 4, 15, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), false, "2026-03-24 05:22:05.336679", new DateTime(2026, 3, 16, 5, 22, 5, 333, DateTimeKind.Utc).AddTicks(3432), new DateTime(2026, 3, 24, 5, 22, 5, 336, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 25, DateTimeKind.Utc).AddTicks(9216), null, false, "2026-03-24 05:22:06.025937", new DateTime(2026, 3, 24, 5, 22, 6, 25, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4197), null, false, "2026-03-24 05:22:06.026420", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4206), null, false, "2026-03-24 05:22:06.026420", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4249), null, false, "2026-03-24 05:22:06.026425", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4266), null, false, "2026-03-24 05:22:06.026426", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4278), null, false, "2026-03-24 05:22:06.026428", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4287), null, false, "2026-03-24 05:22:06.026429", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4297), null, false, "2026-03-24 05:22:06.026430", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(964), null, false, "2026-03-24 05:22:06.026157", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(2935), null, false, "2026-03-24 05:22:06.026381", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4107), null, false, "2026-03-24 05:22:06.026411", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4121), null, false, "2026-03-24 05:22:06.026412", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4138), null, false, "2026-03-24 05:22:06.026414", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4163), null, false, "2026-03-24 05:22:06.026416", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4173), null, false, "2026-03-24 05:22:06.026417", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4183), null, false, "2026-03-24 05:22:06.026419", new DateTime(2026, 3, 24, 5, 22, 6, 26, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(3801), null, false, "2026-03-24 05:22:05.315431", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8397), null, false, "2026-03-24 05:22:05.315840", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8406), null, false, "2026-03-24 05:22:05.315840", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8432), null, false, "2026-03-24 05:22:05.315843", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8442), null, false, "2026-03-24 05:22:05.315844", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8450), null, false, "2026-03-24 05:22:05.315845", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8459), null, false, "2026-03-24 05:22:05.315846", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8467), null, false, "2026-03-24 05:22:05.315847", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8475), null, false, "2026-03-24 05:22:05.315847", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8485), null, false, "2026-03-24 05:22:05.315848", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8494), null, false, "2026-03-24 05:22:05.315849", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(5395), null, false, "2026-03-24 05:22:05.315625", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8502), null, false, "2026-03-24 05:22:05.315850", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8511), null, false, "2026-03-24 05:22:05.315851", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8519), null, false, "2026-03-24 05:22:05.315852", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8527), null, false, "2026-03-24 05:22:05.315853", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8535), null, false, "2026-03-24 05:22:05.315853", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8543), null, false, "2026-03-24 05:22:05.315854", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8577), null, false, "2026-03-24 05:22:05.315858", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8586), null, false, "2026-03-24 05:22:05.315858", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8594), null, false, "2026-03-24 05:22:05.315859", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8603), null, false, "2026-03-24 05:22:05.315860", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(7002), null, false, "2026-03-24 05:22:05.315794", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8611), null, false, "2026-03-24 05:22:05.315861", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8619), null, false, "2026-03-24 05:22:05.315862", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8627), null, false, "2026-03-24 05:22:05.315863", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8634), null, false, "2026-03-24 05:22:05.315863", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8644), null, false, "2026-03-24 05:22:05.315864", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8652), null, false, "2026-03-24 05:22:05.315865", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8660), null, false, "2026-03-24 05:22:05.315866", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8668), null, false, "2026-03-24 05:22:05.315867", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8677), null, false, "2026-03-24 05:22:05.315867", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8685), null, false, "2026-03-24 05:22:05.315868", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8298), null, false, "2026-03-24 05:22:05.315830", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8693), null, false, "2026-03-24 05:22:05.315869", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8701), null, false, "2026-03-24 05:22:05.315870", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8711), null, false, "2026-03-24 05:22:05.315871", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8719), null, false, "2026-03-24 05:22:05.315872", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8727), null, false, "2026-03-24 05:22:05.315873", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8758), null, false, "2026-03-24 05:22:05.315876", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8766), null, false, "2026-03-24 05:22:05.315877", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8775), null, false, "2026-03-24 05:22:05.315877", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8312), null, false, "2026-03-24 05:22:05.315831", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8322), null, false, "2026-03-24 05:22:05.315832", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8330), null, false, "2026-03-24 05:22:05.315836", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8375), null, false, "2026-03-24 05:22:05.315837", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8384), null, false, "2026-03-24 05:22:05.315838", new DateTime(2026, 3, 24, 5, 22, 5, 315, DateTimeKind.Utc).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313418");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313713");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313714");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313714");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313715");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313715");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313716");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313717");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313717");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313718");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313719");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313553");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313719");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313720");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313720");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313721");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313721");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313722");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313723");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313723");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313724");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313731");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313651");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313731");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313732");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313733");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313733");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313734");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313735");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313735");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313736");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313736");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313737");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313706");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313738");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313738");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313739");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313740");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313740");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313741");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313741");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313742");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313707");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313707");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313710");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313711");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:05.313712");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020853");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020898");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020898");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020898");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020895");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020896");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020896");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020897");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020897");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020897");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020897");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.020897");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020798" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020811" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020811" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020812" });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 23, DateTimeKind.Utc).AddTicks(3652), null, false, "2026-03-24 05:22:06.023379", new DateTime(2026, 3, 24, 5, 22, 6, 23, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 23, DateTimeKind.Utc).AddTicks(4632), null, false, "2026-03-24 05:22:06.023536", new DateTime(2026, 3, 24, 5, 22, 6, 23, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 6, 23, DateTimeKind.Utc).AddTicks(6078), null, false, "2026-03-24 05:22:06.023691", new DateTime(2026, 3, 24, 5, 22, 6, 23, DateTimeKind.Utc).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 331, DateTimeKind.Utc).AddTicks(6216), null, false, "2026-03-24 05:22:05.331674", new DateTime(2026, 3, 24, 9, 52, 5, 320, DateTimeKind.Local).AddTicks(5960), new DateTime(2026, 3, 24, 5, 22, 5, 331, DateTimeKind.Utc).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 331, DateTimeKind.Utc).AddTicks(9039), null, false, "2026-03-24 05:22:05.332084", new DateTime(2026, 3, 24, 9, 52, 5, 331, DateTimeKind.Local).AddTicks(6783), new DateTime(2026, 3, 24, 5, 22, 5, 332, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 332, DateTimeKind.Utc).AddTicks(3310), null, false, "2026-03-24 05:22:05.332546", new DateTime(2026, 3, 24, 9, 52, 5, 332, DateTimeKind.Local).AddTicks(1662), new DateTime(2026, 3, 24, 5, 22, 5, 332, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 317, DateTimeKind.Utc).AddTicks(7232), new DateTime(2026, 9, 24, 5, 22, 5, 316, DateTimeKind.Utc).AddTicks(1112), "2026-03-24 05:22:05.317756", new DateTime(2026, 3, 14, 5, 22, 5, 316, DateTimeKind.Utc).AddTicks(1112), new DateTime(2026, 3, 24, 5, 22, 5, 317, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 317, DateTimeKind.Utc).AddTicks(8938), new DateTime(2026, 10, 24, 5, 22, 5, 316, DateTimeKind.Utc).AddTicks(1112), "2026-03-24 05:22:05.317962", new DateTime(2026, 3, 19, 5, 22, 5, 316, DateTimeKind.Utc).AddTicks(1112), new DateTime(2026, 3, 24, 5, 22, 5, 317, DateTimeKind.Utc).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 318, DateTimeKind.Utc).AddTicks(1057), new DateTime(2026, 6, 24, 5, 22, 5, 316, DateTimeKind.Utc).AddTicks(1112), "2026-03-24 05:22:05.318191", new DateTime(2026, 3, 9, 5, 22, 5, 316, DateTimeKind.Utc).AddTicks(1112), new DateTime(2026, 3, 24, 5, 22, 5, 318, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 318, DateTimeKind.Utc).AddTicks(2235), "2026-03-24 05:22:05.318224", new DateTime(2026, 3, 4, 5, 22, 5, 316, DateTimeKind.Utc).AddTicks(1112), new DateTime(2026, 3, 24, 5, 22, 5, 318, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(3666), "2026-03-24 05:22:05.319378", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8144), "2026-03-24 05:22:05.319814", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(5233), "2026-03-24 05:22:05.319582", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(6936), "2026-03-24 05:22:05.319773", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8024), "2026-03-24 05:22:05.319803", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8078), "2026-03-24 05:22:05.319808", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8091), "2026-03-24 05:22:05.319809", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8108), "2026-03-24 05:22:05.319811", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8121), "2026-03-24 05:22:05.319812", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8132), "2026-03-24 05:22:05.319813", new DateTime(2026, 3, 24, 5, 22, 5, 319, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020164" });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020195" });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020195" });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020196" });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020196" });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020196" });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020197" });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020197" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020424" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020459" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020461" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020461" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020452" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020452" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020458" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020458" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020458" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020459" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020459" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "DeletedAt", "IsDeleted", "LastModifiedUtc" },
                values: new object[] { null, false, "2026-03-24 05:22:06.020459" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021631");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021908");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021755");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021854");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021904");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021904");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021906");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021906");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021907");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-24 05:22:06.021907");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ShopOwner");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ShopOwner");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "LoanAccountPayment");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LoanAccountPayment");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "AppLogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppLogs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d178bf12-a5da-4b07-9f59-dee22334739d", "AQAAAAIAAYagAAAAEBeLYaW+FzvGDqBKbstnt3irKphLVEcdiPAZ5uyDORKszLsPL0ye+2VRqKV4bVBH2g==", "44a63d44-094c-44c5-97e0-fcb7b1094587" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "282128db-7789-495c-96a6-8bcf26fb78e2", "AQAAAAIAAYagAAAAELVmROYMrFOIQTHeniKzZOueS00qFV+J97OOlghOPEeLDU69QI8prnyQUt63kVryqQ==", "338401ab-a6b0-45eb-8393-70fe03b9f316" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fbf8add-25eb-4fba-bc6f-b80f3b6b19b8", "AQAAAAIAAYagAAAAENqVHt6jys3VCQwtsKnMWBehaV7QACxQens1wUt0DCz9hKbnY9WAe1z2G3eq3sWYrg==", "76eb923b-b187-481b-9552-46faba01c37e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5649485b-da4c-4ee1-b797-5f591e306139", "AQAAAAIAAYagAAAAEBUn9DANludZr6uJMkPz3SmGCjnQKUcCskE6xtPlzzdsFLjJLKOTZDB40D6Z33fA/A==", "9adb3f46-6170-465c-ad37-8d9555ff9de2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ffb8a04-04f3-4711-a983-b4aba6a7c952", "AQAAAAIAAYagAAAAEPUkheUcKmv3AfekW6kw4R1C9tWRphzJDKZClYABlFh8CKXUqb6Bm63i/e87cbni3w==", "99338b6d-d566-4abf-b093-bfd1813cd2ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4770cf02-45aa-4a7c-b1bd-39a94ff257a9", "AQAAAAIAAYagAAAAEDpmgGjsQf7pBPB8I51786i75C/ikERVND0b/z36dZHwRJvdHOFjUPdyDSTbUm5Zfg==", "3d56b06a-9c96-4173-82dd-fb99816cd62d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48a140b8-d6c6-4dde-81b8-db0d8953a3cd", "AQAAAAIAAYagAAAAEO6/BMcIfe67XcvKDV8Ic4ybzZP31mTq9S7DVoQiWmkbyRFs4z9DgzZ/52OH+hLTUg==", "f4742b1b-f560-416b-89e4-15c6d9112877" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adbe102e-85e3-4acc-9f32-ad20553dee98", "AQAAAAIAAYagAAAAECZnxHOrg8KSphCzmYCgGo7vm4haFfIfck0RJQAIpZYwrOBAzxI+OYks5t5+41RmuA==", "fa923f0e-0284-45cc-9cab-1dbc5e45cc92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "026afaf5-05cf-4925-97e3-90fb894f6dc7", "AQAAAAIAAYagAAAAEKSPxchd+ZTYkG8u4pb6nzIOvK6Kaxu6fbDbRVgLPRVLLUsarBCm1CLruTSFCLnf5g==", "b4a5673c-70e3-4c80-b8bf-a50b581523a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "155ad53e-0c58-4ed3-9795-7507de36e187", "AQAAAAIAAYagAAAAEKfpS5zyOQEGAAFIieKZPoXbhL/okXB5gW5SdAYX46rjBS4wNQCVq43zUDYJiOgh9g==", "c5323619-d881-44e8-a849-8db6a950bd30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4e52e27-2699-4e0c-b55d-bf598b8b83e6", "AQAAAAIAAYagAAAAEN8kt8WCJ2M/IQm6FpFxTEqXh+xbDJ6zC4LbPjaPfsazTZu/XU66Y4nCIundCVw9Mw==", "d6d002d4-db92-4b35-be19-d2a3756afd35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a50b142b-e7f7-4b7e-83a8-13fa09e28d8b", "AQAAAAIAAYagAAAAEBL7R89Dw/sMEJ20wqHl+QY4beQnrgiYzZ65zeKWukcBxd6FF5KHrO0RQPRp5zAWrg==", "6f2906d0-00d4-4888-b434-1307ad7b0459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8d7fd1d-ec33-4737-87ac-7ef509c49122", "AQAAAAIAAYagAAAAEF5MK8Jl4ao03OXMORGSHFqdXFb8f5P6/KPkfLbYrTB6nBVXCE8B3GBgGa9+yHsrCQ==", "02236308-bc65-4a08-a4d4-8d70ff262bb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3872471c-72bc-43bf-b6f8-e87a313ee824", "AQAAAAIAAYagAAAAEEJXWFS5fI6Xi6L1IsPVNLfXG7IvFw/nJg8JYM7RsrTa59z4KLjzSzmffLW9gJFKAQ==", "0b58a648-92b8-4a9b-884f-99dc50d9d580" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae18e1ba-6e9b-4837-b285-f02977329728", "AQAAAAIAAYagAAAAEGzIi2eCdeu3Mz28xkhL9dp76Tch2yTqlNs/x3ppIL2Cv0L36a+uQ2UTWc3P7R788w==", "31645338-e5d7-4daa-8c6d-acc019292cad" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8076), "2026-03-23 14:27:42.647808", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8092), "2026-03-23 14:27:42.647809", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8095), "2026-03-23 14:27:42.647809", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8099), "2026-03-23 14:27:42.647809", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8106), "2026-03-23 14:27:42.647810", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8109), "2026-03-23 14:27:42.647811", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 648, DateTimeKind.Local).AddTicks(6233), "2026-03-23 14:27:42.648638", new DateTime(2026, 3, 23, 14, 27, 42, 648, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(225), "2026-03-23 14:27:42.649022", new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 648, DateTimeKind.Local).AddTicks(7420), "2026-03-23 14:27:42.648801", new DateTime(2026, 3, 23, 14, 27, 42, 648, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 648, DateTimeKind.Local).AddTicks(9031), "2026-03-23 14:27:42.648981", new DateTime(2026, 3, 23, 14, 27, 42, 648, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(150), "2026-03-23 14:27:42.649015", new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(165), "2026-03-23 14:27:42.649016", new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(177), "2026-03-23 14:27:42.649018", new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(192), "2026-03-23 14:27:42.649019", new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(203), "2026-03-23 14:27:42.649020", new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(213), "2026-03-23 14:27:42.649021", new DateTime(2026, 3, 23, 14, 27, 42, 649, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.641353");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.641372");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.641373");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.640002");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.640063");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.640064");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(1019), new DateTime(2026, 4, 22, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), "2026-03-23 14:27:42.048113", new DateTime(2026, 2, 21, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(6062), new DateTime(2026, 4, 19, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), "2026-03-23 14:27:42.048606", new DateTime(2026, 3, 20, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(2912), new DateTime(2026, 4, 7, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), "2026-03-23 14:27:42.048337", new DateTime(2026, 3, 8, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5063), new DateTime(2026, 4, 12, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), "2026-03-23 14:27:42.048567", new DateTime(2026, 3, 13, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5950), new DateTime(2026, 5, 7, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), "2026-03-23 14:27:42.048595", new DateTime(2026, 3, 18, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5968), new DateTime(2026, 4, 2, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), "2026-03-23 14:27:42.048597", new DateTime(2026, 3, 3, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5981), new DateTime(2026, 4, 10, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), "2026-03-23 14:27:42.048598", new DateTime(2026, 3, 11, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5995), "2026-03-23 14:27:42.048599", new DateTime(2026, 2, 26, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(6012), new DateTime(2026, 4, 4, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), "2026-03-23 14:27:42.048603", new DateTime(2026, 3, 5, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(6049), new DateTime(2026, 4, 14, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), "2026-03-23 14:27:42.048605", new DateTime(2026, 3, 15, 14, 27, 42, 47, DateTimeKind.Local).AddTicks(1330), new DateTime(2026, 3, 23, 14, 27, 42, 48, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 646, DateTimeKind.Local).AddTicks(7367), "2026-03-23 14:27:42.646751", new DateTime(2026, 3, 23, 14, 27, 42, 646, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2343), "2026-03-23 14:27:42.647234", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2361), "2026-03-23 14:27:42.647236", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2371), "2026-03-23 14:27:42.647237", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2421), "2026-03-23 14:27:42.647242", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2431), "2026-03-23 14:27:42.647243", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2441), "2026-03-23 14:27:42.647244", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2526), "2026-03-23 14:27:42.647253", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 646, DateTimeKind.Local).AddTicks(8897), "2026-03-23 14:27:42.646948", new DateTime(2026, 3, 23, 14, 27, 42, 646, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(969), "2026-03-23 14:27:42.647190", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2234), "2026-03-23 14:27:42.647224", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2289), "2026-03-23 14:27:42.647229", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2300), "2026-03-23 14:27:42.647230", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2312), "2026-03-23 14:27:42.647231", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2321), "2026-03-23 14:27:42.647232", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2331), "2026-03-23 14:27:42.647233", new DateTime(2026, 3, 23, 14, 27, 42, 647, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(3901), "2026-03-23 14:27:42.034428", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8523), "2026-03-23 14:27:42.034852", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8531), "2026-03-23 14:27:42.034853", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8538), "2026-03-23 14:27:42.034854", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8547), "2026-03-23 14:27:42.034855", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8571), "2026-03-23 14:27:42.034857", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8578), "2026-03-23 14:27:42.034858", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8628), "2026-03-23 14:27:42.034863", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8636), "2026-03-23 14:27:42.034863", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8644), "2026-03-23 14:27:42.034864", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8651), "2026-03-23 14:27:42.034865", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(5151), "2026-03-23 14:27:42.034591", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8658), "2026-03-23 14:27:42.034866", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8667), "2026-03-23 14:27:42.034867", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8674), "2026-03-23 14:27:42.034867", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8681), "2026-03-23 14:27:42.034868", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8688), "2026-03-23 14:27:42.034869", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8695), "2026-03-23 14:27:42.034869", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8702), "2026-03-23 14:27:42.034870", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8709), "2026-03-23 14:27:42.034871", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8717), "2026-03-23 14:27:42.034871", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8725), "2026-03-23 14:27:42.034872", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(7268), "2026-03-23 14:27:42.034816", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8732), "2026-03-23 14:27:42.034873", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8739), "2026-03-23 14:27:42.034874", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8746), "2026-03-23 14:27:42.034874", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8753), "2026-03-23 14:27:42.034875", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8760), "2026-03-23 14:27:42.034876", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8767), "2026-03-23 14:27:42.034876", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8797), "2026-03-23 14:27:42.034879", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8805), "2026-03-23 14:27:42.034880", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8813), "2026-03-23 14:27:42.034881", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8820), "2026-03-23 14:27:42.034882", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8468), "2026-03-23 14:27:42.034847", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8827), "2026-03-23 14:27:42.034882", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8834), "2026-03-23 14:27:42.034883", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8841), "2026-03-23 14:27:42.034884", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8848), "2026-03-23 14:27:42.034885", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8855), "2026-03-23 14:27:42.034885", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8863), "2026-03-23 14:27:42.034886", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8870), "2026-03-23 14:27:42.034887", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8877), "2026-03-23 14:27:42.034887", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8485), "2026-03-23 14:27:42.034848", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8494), "2026-03-23 14:27:42.034849", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8502), "2026-03-23 14:27:42.034850", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8509), "2026-03-23 14:27:42.034851", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8516), "2026-03-23 14:27:42.034851", new DateTime(2026, 3, 23, 14, 27, 42, 34, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032050");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032937");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032939");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032940");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032943");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032944");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032944");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032945");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032945");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032946");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032946");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032803");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032947");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032947");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032948");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032948");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032949");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032949");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032950");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032950");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032951");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032952");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032882");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032952");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032953");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032953");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032954");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032954");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032955");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032955");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032956");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032956");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032957");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032934");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032957");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032958");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032958");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032959");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032959");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032962");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032963");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032963");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032934");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032935");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032935");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032936");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.032936");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641187");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641236");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641236");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641236");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641232");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641235");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641235");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641235");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641235");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641235");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641236");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-23 09:57:42.641236");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.641092");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.641108");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.641109");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.641109");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 644, DateTimeKind.Local).AddTicks(3141), "2026-03-23 14:27:42.644328", new DateTime(2026, 3, 23, 14, 27, 42, 644, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 644, DateTimeKind.Local).AddTicks(4114), "2026-03-23 14:27:42.644487", new DateTime(2026, 3, 23, 14, 27, 42, 644, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 644, DateTimeKind.Local).AddTicks(5580), "2026-03-23 14:27:42.644643", new DateTime(2026, 3, 23, 14, 27, 42, 644, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 46, DateTimeKind.Local).AddTicks(3387), "2026-03-23 14:27:42.046357", new DateTime(2026, 3, 23, 14, 27, 42, 40, DateTimeKind.Local).AddTicks(669), new DateTime(2026, 3, 23, 14, 27, 42, 46, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 46, DateTimeKind.Local).AddTicks(4533), "2026-03-23 14:27:42.046516", new DateTime(2026, 3, 23, 14, 27, 42, 46, DateTimeKind.Local).AddTicks(3586), new DateTime(2026, 3, 23, 14, 27, 42, 46, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 46, DateTimeKind.Local).AddTicks(6101), "2026-03-23 14:27:42.046715", new DateTime(2026, 3, 23, 14, 27, 42, 46, DateTimeKind.Local).AddTicks(5435), new DateTime(2026, 3, 23, 14, 27, 42, 46, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 36, DateTimeKind.Local).AddTicks(7304), new DateTime(2026, 9, 23, 14, 27, 42, 35, DateTimeKind.Local).AddTicks(2424), "2026-03-23 14:27:42.036772", new DateTime(2026, 3, 13, 14, 27, 42, 35, DateTimeKind.Local).AddTicks(2424), new DateTime(2026, 3, 23, 14, 27, 42, 36, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 36, DateTimeKind.Local).AddTicks(9311), new DateTime(2026, 10, 23, 14, 27, 42, 35, DateTimeKind.Local).AddTicks(2424), "2026-03-23 14:27:42.037004", new DateTime(2026, 3, 18, 14, 27, 42, 35, DateTimeKind.Local).AddTicks(2424), new DateTime(2026, 3, 23, 14, 27, 42, 36, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 37, DateTimeKind.Local).AddTicks(1626), new DateTime(2026, 6, 23, 14, 27, 42, 35, DateTimeKind.Local).AddTicks(2424), "2026-03-23 14:27:42.037260", new DateTime(2026, 3, 8, 14, 27, 42, 35, DateTimeKind.Local).AddTicks(2424), new DateTime(2026, 3, 23, 14, 27, 42, 37, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 37, DateTimeKind.Local).AddTicks(2939), "2026-03-23 14:27:42.037294", new DateTime(2026, 3, 3, 14, 27, 42, 35, DateTimeKind.Local).AddTicks(2424), new DateTime(2026, 3, 23, 14, 27, 42, 37, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 38, DateTimeKind.Local).AddTicks(6649), "2026-03-23 14:27:42.038678", new DateTime(2026, 3, 23, 14, 27, 42, 38, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6383), "2026-03-23 14:27:42.039638", new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 38, DateTimeKind.Local).AddTicks(8881), "2026-03-23 14:27:42.039209", new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(4975), "2026-03-23 14:27:42.039595", new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6304), "2026-03-23 14:27:42.039631", new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6329), "2026-03-23 14:27:42.039633", new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6340), "2026-03-23 14:27:42.039634", new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6350), "2026-03-23 14:27:42.039635", new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6361), "2026-03-23 14:27:42.039636", new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6372), "2026-03-23 14:27:42.039637", new DateTime(2026, 3, 23, 14, 27, 42, 39, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640406");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640449");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640449");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640449");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640449");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640449");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640450");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640450");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640698");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640749");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640749");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640750");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640742");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640742");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640743");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640743");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640748");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640749");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640749");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.640749");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642082");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642440");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642239");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642357");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642431");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642431");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642437");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642438");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642438");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-23 14:27:42.642439");
        }
    }
}
