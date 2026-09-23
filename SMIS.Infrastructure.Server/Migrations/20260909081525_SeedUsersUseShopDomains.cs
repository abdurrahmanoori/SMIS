using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersUseShopDomains : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "368b0a3e-6480-4654-92ff-2699d64d47d9", "superadmin@mainstore.com", "SUPERADMIN@MAINSTORE.COM", "AQAAAAIAAYagAAAAEPvDkjibb6ZafRWH9zBrVvMTWDMRRzcGnZd2M/H4yHhn41pxtoWXAUqz7iO6Nn/e/Q==", null, "c2b13429-dee2-49a4-8793-78d31a5ddcce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "975bc94f-6d1e-4e93-863f-ed244ba97a71", "wadmin@mainstore.com", "WADMIN@MAINSTORE.COM", "AQAAAAIAAYagAAAAEMpQILVnquPf3UY6f4HDYuG9Dytnr9QQL69eTlG/O02Y3MDYLOAwaPFH8U1BNN7FrA==", null, "c03d6af2-304f-41b9-8308-f4174d4ae113" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b008ccbe-4b73-4e5e-aa74-bcaca4d7b837", "wadministration@mainstore.com", "WADMINISTRATION@MAINSTORE.COM", "AQAAAAIAAYagAAAAEFV27/FEHgaXCXE9ogBAMlcY8rDXZzAcfDOVhErswF1T/GAvxYJ1m0n+4cvRj0QGzA==", null, "1b7d33b6-a85a-4ee6-8ebf-0eecfd75bec2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b543cce4-2f70-4896-8e1d-21a12eea6251", "wmanager@mainstore.com", "WMANAGER@MAINSTORE.COM", "AQAAAAIAAYagAAAAEGMMmS3S1/pScYnXonHIDdD08CwAlRbirg9qe2SVt6JEdHLw5xoyTDYxpla/TcFT5g==", null, "0ee1f103-09a0-4d92-9176-05296ffc222a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "14783360-0bb8-4959-bba0-f8983788a394", "wstaff@mainstore.com", "WSTAFF@MAINSTORE.COM", "AQAAAAIAAYagAAAAEEVKe+gbc+G8zZBYHh8mj+cWOqwqe7wTDagoyEcxyDSGiUVjK+HKiBIDJqh++LR+Zg==", null, "4b4ebb89-842a-42df-835e-3347698b62a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "fb50ee47-0b7e-462f-8c8b-89590caac3a6", "wviewer@mainstore.com", "WVIEWER@MAINSTORE.COM", "AQAAAAIAAYagAAAAEFdF5ey/3Wyc7AkBKk0tyRBqgdmYld6K4d99zYGk3vuLIoycYxf+QSF61lMEGHQuqA==", null, "9cd196d5-2742-4be1-a489-76316a2b54af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "13eb8304-2b6f-459f-9639-e904fc43ff50", "weditor@mainstore.com", "WEDITOR@MAINSTORE.COM", "AQAAAAIAAYagAAAAEHkaYMHFRBOXPfee585X6PcOAmxQpl1RPoGWfuy3rJu7fslraAfBKtNrW24JvUX1aA==", null, "8218fad8-2fd4-4598-8222-cb0244d9ce9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2c5abc4a-1e40-48e4-88d5-173e7f7ca8dd", "wuser@mainstore.com", "WUSER@MAINSTORE.COM", "AQAAAAIAAYagAAAAEGmBnCBZ7PObQ6Zj/0OhVHoeBcT9AYgau0riKnDSI9x3U+/RYKXFc5e9GLSCKCNn8A==", null, "62943abd-93cd-456b-a5dc-91b2ed89c52e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "81ff25eb-ae88-46e0-bf8c-124c3c436c4e", "radmin@branchstore.com", "RADMIN@BRANCHSTORE.COM", "AQAAAAIAAYagAAAAEJ2EikG8Nej0eK46vwJGH1PgBk5O9Wxoijv4Guf7ur+lcQDVVlU8xuGXriA44eLS+g==", null, "03d42160-15bb-4571-a0f5-7ca22989eb5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "726eb25d-c6b8-42fb-8641-50919d12f3c2", "radministration@branchstore.com", "RADMINISTRATION@BRANCHSTORE.COM", "AQAAAAIAAYagAAAAEJDAKjZLVnTZWCWGYhbIyyyKYcT5DRa7LAx+N0etoOuFv0qaNUlqaCVudlC9IK35hg==", null, "dfa84088-d18e-449e-86ea-1ce0184c6f18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "0386b4de-ca97-4fc6-894f-ff8eae2174aa", "rmanager@branchstore.com", "RMANAGER@BRANCHSTORE.COM", "AQAAAAIAAYagAAAAEEt/1015Rszo8urAZbDiL6VncBPvfENvu0hmJkDyKmxCP8cTOgr+tYOYpWcPAnBSvQ==", null, "19819400-4d24-4f68-bd67-7c610844f672" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "39f1871f-81c1-4277-9155-77b18347d8d3", "rstaff@branchstore.com", "RSTAFF@BRANCHSTORE.COM", "AQAAAAIAAYagAAAAELMvi8E2fqvuz08pInfWRXKAa1l8ZSVMH44CPccY+iLojIN3dmaBPG+Vkj0L0UEl5Q==", null, "92202ea0-0260-470c-acd0-95583854c537" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f9a73262-3766-47ea-a5cd-905c2e53e6de", "rviewer@branchstore.com", "RVIEWER@BRANCHSTORE.COM", "AQAAAAIAAYagAAAAEG0jqVbfauOJdbvHVVDxDnliFsxqJiiSjMy4bPuBTEXx73HLms0CBKe1+YFIJg9PuQ==", null, "d3d2befb-a92d-4357-9988-62571aa36a12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b7920011-6dcf-4936-98e3-bf0a926d375b", "reditor@branchstore.com", "REDITOR@BRANCHSTORE.COM", "AQAAAAIAAYagAAAAEBVeePGBy4LGfU3SGOTT8C6EVpDb+RnrIQRxy6aEd7209ISF76WWbT/jHk/JS9PxiQ==", null, "ff5f943f-e46d-4c9e-b2c8-324023b23f0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "eb963f89-2996-428e-8aba-e204aebbc733", "ruser@branchstore.com", "RUSER@BRANCHSTORE.COM", "AQAAAAIAAYagAAAAEA8DvM18rYGuqGVZRdOnFp7ObMGj2pMOAdqiDRAUyq7N1Cdw55yHkelYzK6mNxlnig==", null, "ebd827c8-9726-4695-a5fa-dc9548892a99" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7586), "2026-09-09 08:15:24.730772", new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7741), "2026-09-09 08:15:24.730774", new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7751), "2026-09-09 08:15:24.730775", new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7756), "2026-09-09 08:15:24.730775", new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7764), "2026-09-09 08:15:24.730776", new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7767), "2026-09-09 08:15:24.730776", new DateTime(2026, 9, 9, 8, 15, 24, 730, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 737, DateTimeKind.Utc).AddTicks(7907), "2026-09-09 08:15:24.737805", new DateTime(2026, 9, 9, 8, 15, 24, 737, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 737, DateTimeKind.Utc).AddTicks(9118), "2026-09-09 08:15:24.737968", new DateTime(2026, 9, 9, 8, 15, 24, 737, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(760), "2026-09-09 08:15:24.738153", new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1846), "2026-09-09 08:15:24.738185", new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1863), "2026-09-09 08:15:24.738186", new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1884), "2026-09-09 08:15:24.738188", new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1902), "2026-09-09 08:15:24.738190", new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1914), "2026-09-09 08:15:24.738191", new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1925), "2026-09-09 08:15:24.738192", new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1936), "2026-09-09 08:15:24.738193", new DateTime(2026, 9, 9, 8, 15, 24, 738, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724361");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724386");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724386");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723047");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723090");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723090");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 745, DateTimeKind.Utc).AddTicks(4652), new DateTime(2026, 10, 9, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), "2026-09-09 08:15:24.745480", new DateTime(2026, 8, 10, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 745, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 745, DateTimeKind.Utc).AddTicks(7046), new DateTime(2026, 9, 24, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), "2026-09-09 08:15:24.745758", new DateTime(2026, 8, 25, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 745, DateTimeKind.Utc).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 745, DateTimeKind.Utc).AddTicks(9355), new DateTime(2026, 9, 29, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), "2026-09-09 08:15:24.745997", new DateTime(2026, 8, 30, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 745, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(255), new DateTime(2026, 10, 24, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), "2026-09-09 08:15:24.746026", new DateTime(2026, 9, 4, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(274), new DateTime(2026, 9, 19, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), "2026-09-09 08:15:24.746027", new DateTime(2026, 8, 20, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(289), new DateTime(2026, 9, 27, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), "2026-09-09 08:15:24.746029", new DateTime(2026, 8, 28, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(304), "2026-09-09 08:15:24.746030", new DateTime(2026, 8, 15, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(320), new DateTime(2026, 9, 21, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), "2026-09-09 08:15:24.746032", new DateTime(2026, 8, 22, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(335), new DateTime(2026, 10, 1, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), "2026-09-09 08:15:24.746033", new DateTime(2026, 9, 1, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(353), new DateTime(2026, 10, 6, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), "2026-09-09 08:15:24.746035", new DateTime(2026, 9, 6, 8, 15, 24, 744, DateTimeKind.Utc).AddTicks(2837), new DateTime(2026, 9, 9, 8, 15, 24, 746, DateTimeKind.Utc).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(2184), "2026-09-09 08:15:24.733239", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(3996), "2026-09-09 08:15:24.733465", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(5932), "2026-09-09 08:15:24.733675", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7070), "2026-09-09 08:15:24.733707", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7108), "2026-09-09 08:15:24.733711", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7120), "2026-09-09 08:15:24.733712", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7133), "2026-09-09 08:15:24.733713", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7145), "2026-09-09 08:15:24.733714", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7158), "2026-09-09 08:15:24.733716", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7183), "2026-09-09 08:15:24.733718", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7195), "2026-09-09 08:15:24.733719", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7207), "2026-09-09 08:15:24.733721", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7244), "2026-09-09 08:15:24.733724", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7257), "2026-09-09 08:15:24.733726", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7270), "2026-09-09 08:15:24.733727", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7297), "2026-09-09 08:15:24.733730", new DateTime(2026, 9, 9, 8, 15, 24, 733, DateTimeKind.Utc).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(5589), "2026-09-09 08:15:24.736574", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(6422), "2026-09-09 08:15:24.736723", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(7940), "2026-09-09 08:15:24.736881", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9125), "2026-09-09 08:15:24.736913", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9135), "2026-09-09 08:15:24.736913", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9146), "2026-09-09 08:15:24.736914", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9152), "2026-09-09 08:15:24.736915", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9158), "2026-09-09 08:15:24.736916", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9164), "2026-09-09 08:15:24.736916", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9192), "2026-09-09 08:15:24.736919", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9199), "2026-09-09 08:15:24.736920", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9212), "2026-09-09 08:15:24.736921", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9218), "2026-09-09 08:15:24.736922", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9226), "2026-09-09 08:15:24.736922", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9232), "2026-09-09 08:15:24.736923", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9238), "2026-09-09 08:15:24.736924", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9244), "2026-09-09 08:15:24.736924", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9250), "2026-09-09 08:15:24.736925", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9256), "2026-09-09 08:15:24.736925", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9262), "2026-09-09 08:15:24.736926", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9267), "2026-09-09 08:15:24.736927", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9275), "2026-09-09 08:15:24.736927", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9281), "2026-09-09 08:15:24.736928", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9286), "2026-09-09 08:15:24.736928", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9292), "2026-09-09 08:15:24.736929", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9298), "2026-09-09 08:15:24.736930", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9304), "2026-09-09 08:15:24.736930", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9309), "2026-09-09 08:15:24.736931", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9321), "2026-09-09 08:15:24.736932", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9328), "2026-09-09 08:15:24.736933", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9334), "2026-09-09 08:15:24.736933", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9339), "2026-09-09 08:15:24.736934", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9345), "2026-09-09 08:15:24.736934", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9351), "2026-09-09 08:15:24.736935", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9356), "2026-09-09 08:15:24.736935", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9362), "2026-09-09 08:15:24.736936", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9368), "2026-09-09 08:15:24.736937", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9375), "2026-09-09 08:15:24.736937", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9380), "2026-09-09 08:15:24.736938", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9386), "2026-09-09 08:15:24.736938", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9392), "2026-09-09 08:15:24.736939", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9398), "2026-09-09 08:15:24.736940", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9403), "2026-09-09 08:15:24.736940", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9409), "2026-09-09 08:15:24.736941", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9421), "2026-09-09 08:15:24.736942", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9428), "2026-09-09 08:15:24.736943", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9434), "2026-09-09 08:15:24.736943", new DateTime(2026, 9, 9, 8, 15, 24, 736, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735064");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735154");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735249");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735304");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735305");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735306");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735312");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735312");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735313");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735314");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735314");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735315");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735316");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735317");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735317");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735318");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735318");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735319");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735320");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735320");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735322");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735322");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735323");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735324");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735324");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735325");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735326");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735326");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735327");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735328");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735328");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735329");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735329");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735330");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735331");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735331");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735332");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735332");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735333");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735334");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735334");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735336");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735337");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735337");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735338");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735339");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.735339");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724203");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724243");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724245");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724245");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724246");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724246");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724246");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724246");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724247");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724247");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724247");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724247");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724141");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724158");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724158");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.724158");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 728, DateTimeKind.Utc).AddTicks(3714), "2026-09-09 08:15:24.728441", new DateTime(2026, 9, 9, 8, 15, 24, 728, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 728, DateTimeKind.Utc).AddTicks(5837), "2026-09-09 08:15:24.728659", new DateTime(2026, 9, 9, 8, 15, 24, 728, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 728, DateTimeKind.Utc).AddTicks(7603), "2026-09-09 08:15:24.728852", new DateTime(2026, 9, 9, 8, 15, 24, 728, DateTimeKind.Utc).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 739, DateTimeKind.Utc).AddTicks(8577), "2026-09-09 08:15:24.739872", new DateTime(2026, 9, 9, 12, 45, 24, 738, DateTimeKind.Local).AddTicks(5903), new DateTime(2026, 9, 9, 8, 15, 24, 739, DateTimeKind.Utc).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 739, DateTimeKind.Utc).AddTicks(9917), "2026-09-09 08:15:24.740066", new DateTime(2026, 9, 9, 12, 45, 24, 739, DateTimeKind.Local).AddTicks(8744), new DateTime(2026, 9, 9, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(1633), "2026-09-09 08:15:24.740241", new DateTime(2026, 9, 9, 12, 45, 24, 740, DateTimeKind.Local).AddTicks(887), new DateTime(2026, 9, 9, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 741, DateTimeKind.Utc).AddTicks(2132), new DateTime(2027, 3, 9, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(4837), "2026-09-09 08:15:24.741245", new DateTime(2026, 8, 30, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(4837), new DateTime(2026, 9, 9, 8, 15, 24, 741, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 741, DateTimeKind.Utc).AddTicks(3758), new DateTime(2027, 4, 9, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(4837), "2026-09-09 08:15:24.741430", new DateTime(2026, 9, 4, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(4837), new DateTime(2026, 9, 9, 8, 15, 24, 741, DateTimeKind.Utc).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 741, DateTimeKind.Utc).AddTicks(5240), new DateTime(2026, 12, 9, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(4837), "2026-09-09 08:15:24.741599", new DateTime(2026, 8, 25, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(4837), new DateTime(2026, 9, 9, 8, 15, 24, 741, DateTimeKind.Utc).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 741, DateTimeKind.Utc).AddTicks(6288), "2026-09-09 08:15:24.741629", new DateTime(2026, 8, 20, 8, 15, 24, 740, DateTimeKind.Utc).AddTicks(4837), new DateTime(2026, 9, 9, 8, 15, 24, 741, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(3043), "2026-09-09 08:15:24.743319", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(5084), "2026-09-09 08:15:24.743566", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(6836), "2026-09-09 08:15:24.743765", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(7986), "2026-09-09 08:15:24.743799", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8002), "2026-09-09 08:15:24.743800", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8013), "2026-09-09 08:15:24.743801", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8024), "2026-09-09 08:15:24.743802", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8034), "2026-09-09 08:15:24.743803", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8045), "2026-09-09 08:15:24.743804", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8054), "2026-09-09 08:15:24.743805", new DateTime(2026, 9, 9, 8, 15, 24, 743, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723420");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723461");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723461");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723461");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723462");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723463");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723463");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723463");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723746");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723777");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723777");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723777");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723778");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723778");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723778");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723779");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723779");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723779");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723779");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.723779");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.729743");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.729919");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.730023");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.730077");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.730079");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.730080");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.730080");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.730081");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.730081");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-09 08:15:24.730082");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "aa6100ff-1d21-43cf-a183-5a144a162878", "superadmin@smis.com", "SUPERADMIN@SMIS.COM", "AQAAAAIAAYagAAAAED76YzVtW2FavBuyzGdLJesLx3sVq8uxahlR6Qb+pWHm/iMN0k4j2iaVSge+/W1Lew==", "+855123456789", "acd9cce8-ad13-4d1c-ac51-2d7be2f3b10a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b460112d-130a-4ac4-96d8-6b079f30e3e8", "wadmin@smis.com", "WADMIN@SMIS.COM", "AQAAAAIAAYagAAAAECzzQ7hiMOuCcs5Ldseuo9HgFT/Ki77iMWquvKoqq8Acbd+kUscrVuVGUAGjqx8M/w==", "+855123456790", "27002c7e-2a54-4d62-8b7b-591097b2ab1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "6a2abad8-5bef-4c4f-b535-5bec94cfec20", "wadministration@smis.com", "WADMINISTRATION@SMIS.COM", "AQAAAAIAAYagAAAAEC4o+rH7OMgLdpp+nPmxdmelFQOOqvTuTEEy1JvOjNFjaZgRpJChaU9VgudJbRS99w==", "+855123456791", "53bbc95f-8fbd-4503-b611-e9553d2c7225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "8f137402-8a6d-4463-82a1-4afbb6a5847e", "wmanager@smis.com", "WMANAGER@SMIS.COM", "AQAAAAIAAYagAAAAEMcI62rlssqts5mPiUqltJcbsh0/R3oDtKxFDXmJtggJjg3bphptR0Z7Y0t2BywGrg==", "+855123456792", "3e6a463c-cb76-4f51-8900-4519e26052d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2a1a206c-691b-45fb-b802-1e11ff387cc4", "wstaff@smis.com", "WSTAFF@SMIS.COM", "AQAAAAIAAYagAAAAEPo9md6NHRG2klg3PU0wzh1eYALooZ1LCMEEOaJzRUj+jIhE6CZEsq/q0cMf0TkegQ==", "+855123456793", "62a3ef6e-fbf6-4bc5-bcc0-63ec34124691" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f7e42162-f89a-474b-8e96-dd4d2e70705f", "wviewer@smis.com", "WVIEWER@SMIS.COM", "AQAAAAIAAYagAAAAEBrRmP5BzBXEJet1ySXwCbP5V2wCfMoapGJJLG9mcucRcYGwylLLptPB0D2dk0yQdQ==", "+8512345634366", "174ebaed-c468-4ee3-9d44-7b09f1011ffd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "9d80059c-4bb0-42ec-98f5-576db9d4aa07", "weditor@smis.com", "WEDITOR@SMIS.COM", "AQAAAAIAAYagAAAAEOH5oEnvi++hQaxRUC3hB+Nboy+4Q03UB/XdHoJpLy1GOcW8p2rvG+0YzZy5cly4Lg==", "+855123456795", "402bebd1-02ae-49e2-b6f4-b1b158346ef4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "16871a85-06b5-4d2b-adfd-81107e82b2c7", "wuser@smis.com", "WUSER@SMIS.COM", "AQAAAAIAAYagAAAAEKBB7kjMfrlY6WK5BgjelEKCLhZa/1utJMU+/3t0fvM9my/elR36ikiR9XBZNZJjoA==", "+855123456796", "74ffe48f-3ec6-44af-9a8d-1cac4773ed33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "800006d0-ae8f-47d2-86ae-2add7f4dd363", "radmin@smis.com", "RADMIN@SMIS.COM", "AQAAAAIAAYagAAAAEENlJEy0V4dKDLWkq1xm/io8p5UgdPKtPPbazrCMK7r0IL4v5N/uQMTL1dS3+sKb6A==", "+855123456797", "201f34b3-d610-4e10-a5f3-846abfa74818" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "17352f72-b148-4b90-86c3-c16921a40b99", "radministration@smis.com", "RADMINISTRATION@SMIS.COM", "AQAAAAIAAYagAAAAEImW0y591CQ1HXjow8h97kZ/1Cyyys9v3TMZKyhiqIwvGbqpv1dMtXhHIDr2PAVLEQ==", "+855123456798", "10510f8a-0904-4703-8634-e3bfe7722fac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "6e899841-bda6-4922-a5b6-a02d2cb6e6ae", "rmanager@smis.com", "RMANAGER@SMIS.COM", "AQAAAAIAAYagAAAAEICZKiyjG9Ayfsw9jjlCDOF5ZA48N/doIo3r7cXFI9Wv4wGyEUAo2jhrjzhuS6Bd/A==", "+855123456799", "adaa1f34-b2a6-486b-93dd-c8deb580e093" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "612846a0-2f20-4510-a07a-841d8b8abf58", "rstaff@smis.com", "RSTAFF@SMIS.COM", "AQAAAAIAAYagAAAAENlT2MD8ayd4iDNTGndhDXCEzUIjymXk41lwSN0q1UZM2sf85Xmr1GuTDIzYl1me3A==", "+855123456800", "78e52712-86bf-4451-b897-afa5a645517b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "4b7245ec-990b-4dca-905e-e06e8307a0f4", "rviewer@smis.com", "RVIEWER@SMIS.COM", "AQAAAAIAAYagAAAAEIK619Y7DtVVzeZo7MdFZReLP0+Wo4nx8JKmsqC6H17B58gOFdHMimN9JiRoQirJWA==", "+855123456801", "4c971b9c-8b33-4601-96a9-cc099ed6643b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f03a6f44-e230-4c80-afd2-02e2868c5dab", "reditor@smis.com", "REDITOR@SMIS.COM", "AQAAAAIAAYagAAAAEAuFquC07leDZylTgzlgOPd2sJby5VdxduEXD9xX9q0zXgrTJEsTT3/gIVa4d/pdFQ==", "+855123456802", "176b0b09-0293-47a2-9a7d-883798571fcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "04a9321a-595f-40ca-97f0-b25daa91fc4d", "ruser@smis.com", "RUSER@SMIS.COM", "AQAAAAIAAYagAAAAEF06DB82Ry7tiXj07KEkpzG/zuWekQ/byG84732XnaH7lqaj2ENa0d1JXTUHG0x+Qg==", "+855123456803", "333e9c0d-10fc-4ae0-90e2-2ae8cf27581a" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(7944), "2026-09-06 12:36:54.988805", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8079), "2026-09-06 12:36:54.988808", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8084), "2026-09-06 12:36:54.988808", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8087), "2026-09-06 12:36:54.988808", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8101), "2026-09-06 12:36:54.988810", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8105), "2026-09-06 12:36:54.988810", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 996, DateTimeKind.Utc).AddTicks(7374), "2026-09-06 12:36:54.996754", new DateTime(2026, 9, 6, 12, 36, 54, 996, DateTimeKind.Utc).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 996, DateTimeKind.Utc).AddTicks(9068), "2026-09-06 12:36:54.997001", new DateTime(2026, 9, 6, 12, 36, 54, 996, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(1311), "2026-09-06 12:36:54.997447", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5192), "2026-09-06 12:36:54.997521", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5223), "2026-09-06 12:36:54.997522", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5237), "2026-09-06 12:36:54.997524", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5250), "2026-09-06 12:36:54.997525", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5267), "2026-09-06 12:36:54.997527", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5280), "2026-09-06 12:36:54.997528", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5293), "2026-09-06 12:36:54.997529", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982477");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982509");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982510");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.980791");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.980845");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.980846");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(2653), new DateTime(2026, 10, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006288", new DateTime(2026, 8, 7, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(5597), new DateTime(2026, 9, 21, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006633", new DateTime(2026, 8, 22, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(8449), new DateTime(2026, 9, 26, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006923", new DateTime(2026, 8, 27, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9581), new DateTime(2026, 10, 21, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006958", new DateTime(2026, 9, 1, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9605), new DateTime(2026, 9, 16, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006960", new DateTime(2026, 8, 17, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9690), new DateTime(2026, 9, 24, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006969", new DateTime(2026, 8, 25, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9706), "2026-09-06 12:36:55.006971", new DateTime(2026, 8, 12, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9723), new DateTime(2026, 9, 18, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006972", new DateTime(2026, 8, 19, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9739), new DateTime(2026, 9, 28, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006974", new DateTime(2026, 8, 29, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9759), new DateTime(2026, 10, 3, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006976", new DateTime(2026, 9, 3, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(2284), "2026-09-06 12:36:54.991248", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(4686), "2026-09-06 12:36:54.991559", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(7161), "2026-09-06 12:36:54.991818", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8567), "2026-09-06 12:36:54.991857", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8587), "2026-09-06 12:36:54.991859", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8601), "2026-09-06 12:36:54.991860", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8615), "2026-09-06 12:36:54.991861", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8629), "2026-09-06 12:36:54.991863", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8643), "2026-09-06 12:36:54.991865", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8659), "2026-09-06 12:36:54.991866", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8671), "2026-09-06 12:36:54.991867", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8686), "2026-09-06 12:36:54.991869", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8744), "2026-09-06 12:36:54.991874", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8756), "2026-09-06 12:36:54.991876", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8769), "2026-09-06 12:36:54.991877", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8781), "2026-09-06 12:36:54.991878", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(1884), "2026-09-06 12:36:54.995216", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(3400), "2026-09-06 12:36:54.995453", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(5427), "2026-09-06 12:36:54.995646", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6844), "2026-09-06 12:36:54.995685", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6863), "2026-09-06 12:36:54.995686", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6870), "2026-09-06 12:36:54.995687", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6956), "2026-09-06 12:36:54.995696", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6964), "2026-09-06 12:36:54.995696", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6972), "2026-09-06 12:36:54.995697", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6979), "2026-09-06 12:36:54.995698", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6985), "2026-09-06 12:36:54.995698", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6991), "2026-09-06 12:36:54.995699", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7019), "2026-09-06 12:36:54.995702", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7026), "2026-09-06 12:36:54.995702", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7032), "2026-09-06 12:36:54.995703", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7039), "2026-09-06 12:36:54.995704", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7046), "2026-09-06 12:36:54.995704", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7053), "2026-09-06 12:36:54.995705", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7060), "2026-09-06 12:36:54.995706", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7067), "2026-09-06 12:36:54.995707", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7075), "2026-09-06 12:36:54.995707", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7082), "2026-09-06 12:36:54.995708", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7088), "2026-09-06 12:36:54.995709", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7133), "2026-09-06 12:36:54.995713", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7141), "2026-09-06 12:36:54.995714", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7148), "2026-09-06 12:36:54.995715", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7155), "2026-09-06 12:36:54.995715", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7162), "2026-09-06 12:36:54.995716", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7170), "2026-09-06 12:36:54.995717", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7176), "2026-09-06 12:36:54.995717", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7183), "2026-09-06 12:36:54.995718", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7189), "2026-09-06 12:36:54.995719", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7195), "2026-09-06 12:36:54.995719", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7201), "2026-09-06 12:36:54.995720", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7212), "2026-09-06 12:36:54.995721", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7219), "2026-09-06 12:36:54.995722", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7226), "2026-09-06 12:36:54.995722", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7232), "2026-09-06 12:36:54.995723", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7238), "2026-09-06 12:36:54.995724", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7244), "2026-09-06 12:36:54.995724", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7279), "2026-09-06 12:36:54.995728", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7286), "2026-09-06 12:36:54.995728", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7293), "2026-09-06 12:36:54.995729", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7299), "2026-09-06 12:36:54.995730", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7307), "2026-09-06 12:36:54.995731", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7313), "2026-09-06 12:36:54.995731", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7319), "2026-09-06 12:36:54.995732", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993418");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993544");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993663");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993731");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993732");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993733");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993734");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993734");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993735");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993736");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993736");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993737");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993740");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993741");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993741");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993747");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993748");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993748");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993749");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993750");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993751");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993751");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993752");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993753");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993753");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993754");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993755");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993755");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993756");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993757");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993757");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993758");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993758");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993759");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993760");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993764");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993764");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993765");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993766");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993766");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993767");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993768");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993768");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993769");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993770");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993770");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.993771");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982136");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982191");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982193");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982193");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982194");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982194");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982194");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982194");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982198");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982199");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982199");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982199");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982058");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982079");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982079");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982080");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(858), "2026-09-06 12:36:54.985152", new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(3139), "2026-09-06 12:36:54.985426", new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(5652), "2026-09-06 12:36:54.985682", new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(4741), "2026-09-06 12:36:54.999496", new DateTime(2026, 9, 6, 17, 6, 54, 998, DateTimeKind.Local).AddTicks(43), new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(6220), "2026-09-06 12:36:54.999697", new DateTime(2026, 9, 6, 17, 6, 54, 999, DateTimeKind.Local).AddTicks(4980), new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(8182), "2026-09-06 12:36:54.999913", new DateTime(2026, 9, 6, 17, 6, 54, 999, DateTimeKind.Local).AddTicks(7316), new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(901), new DateTime(2027, 3, 6, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), "2026-09-06 12:36:55.001134", new DateTime(2026, 8, 27, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(3392), new DateTime(2027, 4, 6, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), "2026-09-06 12:36:55.001419", new DateTime(2026, 9, 1, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(5427), new DateTime(2026, 12, 6, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), "2026-09-06 12:36:55.001632", new DateTime(2026, 8, 22, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(6677), "2026-09-06 12:36:55.001668", new DateTime(2026, 8, 17, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 3, DateTimeKind.Utc).AddTicks(7857), "2026-09-06 12:36:55.003801", new DateTime(2026, 9, 6, 12, 36, 55, 3, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(283), "2026-09-06 12:36:55.004110", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(2558), "2026-09-06 12:36:55.004354", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4196), "2026-09-06 12:36:55.004420", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4218), "2026-09-06 12:36:55.004422", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4276), "2026-09-06 12:36:55.004428", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4288), "2026-09-06 12:36:55.004429", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4299), "2026-09-06 12:36:55.004430", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4309), "2026-09-06 12:36:55.004431", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4318), "2026-09-06 12:36:55.004432", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981220");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981267");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981268");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981268");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981268");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981275");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981275");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981276");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981583");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981618");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981619");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981619");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981619");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981619");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981621");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981622");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981622");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981623");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981623");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981623");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.987748");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.987886");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.987995");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.988059");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.988059");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.988061");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.988061");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.988071");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.988072");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.988072");
        }
    }
}
