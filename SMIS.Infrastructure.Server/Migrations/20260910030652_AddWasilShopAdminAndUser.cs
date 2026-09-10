using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddWasilShopAdminAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EntityState", "LastModifiedUtc", "Name", "NormalizedName", "Version" },
                values: new object[] { "33333333-0000-0000-0000-000000000016", null, "Unchanged", "0001-01-01 00:00:00.000000", "WasilShopAdmin", "WASILSHOPADMIN", 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a87d6116-6fa3-4a45-8df4-c0849527cfb2", "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==", "03e5a1ef-9f95-4b84-b44e-9f985c64a4f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1b80119-8536-440a-b872-43ce8e53fc91", "AQAAAAIAAYagAAAAEL9IvmY0whoq068TwS3zlt6qpofuQMDhfAdXqrmhv8oSphpPN871q5shwY/r3naUpA==", "07b957aa-9b34-48c1-965c-eadefba3f701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48531371-6d42-4886-b6fc-757b543d70f5", "AQAAAAIAAYagAAAAEHpawGOIRdlsVr9wqO6169tuuLIYSvFpACytnWX29izmuMn5CULwN2vg7+nVfOrGhg==", "ecac5a56-de80-4aa5-b29d-383b3594f668" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02f51a9b-3e11-4a9c-9a6d-080f8c83f84c", "AQAAAAIAAYagAAAAEGa0n4zf6N/lrCoPvj4okX2zRaQEylrN985SBpENJWh8lg0q1t935widPp81xGpuxQ==", "76acccaf-0899-4f4d-99fc-bb41576646e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8419b9fb-56d7-4d3a-af49-ac76ae8c8d87", "AQAAAAIAAYagAAAAENR8TdwguUiNpSTHQbawymJ3mO8EG/QGTjMOCyBVVTLyhDhFTZbYMnNVXANus1pcTA==", "ef2ead29-065b-4d04-b203-f245a847cb30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd9630e8-ce1e-42c3-8e54-cc29da5b17ba", "AQAAAAIAAYagAAAAEN7V73Zh1NzCGKWravgkd8/Dv6JrYFruyytVb0jtdcdl7BrozNl86y2aTC8y7l9V6Q==", "357b3c60-1fab-450e-a44c-077db8008ad9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98cdde53-fc38-48f9-9e11-4c896c49f570", "AQAAAAIAAYagAAAAEAXTlYpV8I5NgiL5hCCsTOpONHVm+l0+Jo5z3yS/Fxa3BDaHG7Autgv3y0nb0ll+AQ==", "25f63e36-9cb5-446d-83f2-10785290de77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98f2289e-c02b-4a6b-8a53-4c7d80063326", "AQAAAAIAAYagAAAAEOVZIdu/eX/xvePvFXk+dhj7MPzD+1YoIFVKpSPZZ0ljEicrQiYdDNP4kpQGWUpzeg==", "684d2f01-7c79-4e58-b1b7-5579a681f69c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de7fe49f-2738-4520-952a-9e7163e036f4", "AQAAAAIAAYagAAAAEMWnOV+dPj0AnhWM3wrqgT+824MzVWtNyuRjq1viM0h/CHYNBMO1pdLlbD7bqS0J9A==", "5738c022-a326-439a-aaa6-ae924fb330ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8679c3c-8902-43c1-a19d-6669c8e50aca", "AQAAAAIAAYagAAAAEKV5DJ36/KHMD2tZGk53eJm+RMFbmQH8b0Ov4tXHwPm6+bgpp4pttkyK/5MtjJVSzA==", "d0e0a477-2946-40ae-90f4-c6a3388f46ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9be5bc44-03e3-43e6-a05b-eeb0354546e9", "AQAAAAIAAYagAAAAEHA9haolrPXiANWZkfzmzvfEsbbjXvSRRPWzAFMY/jtABlxzWyTul1kSWkYFeGlJaw==", "213d51bc-82a5-48d6-b8b8-037326626feb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2066713c-6da6-4504-a2a5-084fec41fdba", "AQAAAAIAAYagAAAAEBdkWrKnNePnuhCv3LwEPueMGv1Z4gY1g2pnDp+SSMdyjag0qfjb6M/F3/yaleGbxA==", "e5ce5ce9-c9be-4ffc-b87d-70dd78ea699d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f5f13fa-4e10-448d-a70f-ddd81013459f", "AQAAAAIAAYagAAAAEPht3yicjh6ZwbPGHczlm/PLwbis5QDMycVEP54P69TJB8GIaPwAwXHaZg5Sjc4mDA==", "72e8ade5-b6bd-49a7-a614-e3ae3b8dbd92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f10984f-f7af-46fa-ae52-785296f7b652", "AQAAAAIAAYagAAAAEHPf7T0aiY/x78uRSejhxuch6bz9c/4A7HKUCAFdJ1doPpQAtCsgGlOcuIif1K8kdg==", "0b0703df-dd3b-493b-a446-160e11d1507d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68159d5f-9154-4c06-b7d7-40ef3b64ffaf", "AQAAAAIAAYagAAAAEAdT1ivP+sHMf5jtcRBuaA2gY3s51oKHzBtvluXx0NMPtJHQ+j14T5oYzrzDEJ0KhA==", "e72e741b-de1a-4936-8e2f-807b51cb7b0f" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1063), "2026-09-10 03:06:50.802116", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1192), "2026-09-10 03:06:50.802119", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1196), "2026-09-10 03:06:50.802119", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1217), "2026-09-10 03:06:50.802121", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1221), "2026-09-10 03:06:50.802122", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1224), "2026-09-10 03:06:50.802122", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(281), "2026-09-10 03:06:50.813077", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(5129), "2026-09-10 03:06:50.813666", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(7914), "2026-09-10 03:06:50.813886", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9228), "2026-09-10 03:06:50.813923", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9255), "2026-09-10 03:06:50.813925", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9278), "2026-09-10 03:06:50.813928", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9291), "2026-09-10 03:06:50.813929", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9305), "2026-09-10 03:06:50.813930", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9317), "2026-09-10 03:06:50.813932", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9330), "2026-09-10 03:06:50.813933", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794374");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794405");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794406");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792004");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792050");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792050");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 831, DateTimeKind.Utc).AddTicks(200), new DateTime(2026, 10, 10, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.831061", new DateTime(2026, 8, 11, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 831, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 831, DateTimeKind.Utc).AddTicks(9375), new DateTime(2026, 9, 25, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.832195", new DateTime(2026, 8, 26, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 832, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 832, DateTimeKind.Utc).AddTicks(9344), new DateTime(2026, 9, 30, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833133", new DateTime(2026, 8, 31, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2314), new DateTime(2026, 10, 25, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833233", new DateTime(2026, 9, 5, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2369), new DateTime(2026, 9, 20, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833237", new DateTime(2026, 8, 21, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2405), new DateTime(2026, 9, 28, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833241", new DateTime(2026, 8, 29, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2444), "2026-09-10 03:06:50.833245", new DateTime(2026, 8, 16, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2481), new DateTime(2026, 9, 22, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833248", new DateTime(2026, 8, 23, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2539), new DateTime(2026, 10, 2, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833254", new DateTime(2026, 9, 2, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2574), new DateTime(2026, 10, 7, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833258", new DateTime(2026, 9, 7, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(3899), "2026-09-10 03:06:50.804410", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(5644), "2026-09-10 03:06:50.804633", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(7775), "2026-09-10 03:06:50.804870", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9101), "2026-09-10 03:06:50.804910", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9121), "2026-09-10 03:06:50.804912", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9142), "2026-09-10 03:06:50.804914", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9185), "2026-09-10 03:06:50.804918", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9199), "2026-09-10 03:06:50.804920", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9217), "2026-09-10 03:06:50.804922", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9235), "2026-09-10 03:06:50.804923", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9248), "2026-09-10 03:06:50.804925", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9264), "2026-09-10 03:06:50.804926", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9277), "2026-09-10 03:06:50.804928", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9292), "2026-09-10 03:06:50.804929", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9304), "2026-09-10 03:06:50.804930", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9328), "2026-09-10 03:06:50.804933", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(2161), "2026-09-10 03:06:50.809262", new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(4161), "2026-09-10 03:06:50.809635", new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(8155), "2026-09-10 03:06:50.810051", new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1597), "2026-09-10 03:06:50.810161", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1630), "2026-09-10 03:06:50.810163", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1649), "2026-09-10 03:06:50.810165", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1667), "2026-09-10 03:06:50.810167", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1683), "2026-09-10 03:06:50.810168", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1699), "2026-09-10 03:06:50.810170", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1715), "2026-09-10 03:06:50.810172", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1755), "2026-09-10 03:06:50.810176", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1773), "2026-09-10 03:06:50.810177", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1789), "2026-09-10 03:06:50.810179", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1804), "2026-09-10 03:06:50.810181", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1819), "2026-09-10 03:06:50.810182", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1833), "2026-09-10 03:06:50.810183", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1848), "2026-09-10 03:06:50.810185", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1863), "2026-09-10 03:06:50.810187", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1882), "2026-09-10 03:06:50.810188", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1897), "2026-09-10 03:06:50.810190", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1911), "2026-09-10 03:06:50.810191", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1927), "2026-09-10 03:06:50.810193", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1968), "2026-09-10 03:06:50.810197", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1986), "2026-09-10 03:06:50.810199", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2001), "2026-09-10 03:06:50.810200", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2017), "2026-09-10 03:06:50.810202", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2035), "2026-09-10 03:06:50.810204", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2068), "2026-09-10 03:06:50.810207", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2084), "2026-09-10 03:06:50.810209", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2100), "2026-09-10 03:06:50.810210", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2115), "2026-09-10 03:06:50.810212", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2129), "2026-09-10 03:06:50.810213", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2144), "2026-09-10 03:06:50.810215", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2159), "2026-09-10 03:06:50.810216", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2178), "2026-09-10 03:06:50.810218", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2193), "2026-09-10 03:06:50.810219", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2208), "2026-09-10 03:06:50.810221", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2223), "2026-09-10 03:06:50.810222", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2238), "2026-09-10 03:06:50.810224", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2254), "2026-09-10 03:06:50.810225", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2268), "2026-09-10 03:06:50.810227", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2283), "2026-09-10 03:06:50.810229", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2305), "2026-09-10 03:06:50.810231", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2320), "2026-09-10 03:06:50.810232", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2349), "2026-09-10 03:06:50.810235", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2364), "2026-09-10 03:06:50.810237", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2378), "2026-09-10 03:06:50.810238", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806308");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806396");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806495");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806550");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806551");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806552");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806553");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806554");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806554");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806555");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806556");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806556");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806557");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806558");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806558");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806559");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806560");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806560");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806561");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806563");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806563");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806564");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806565");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806565");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806566");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806566");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806567");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806568");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806568");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806569");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806570");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806570");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806571");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806572");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806572");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806573");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806573");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806574");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806575");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806575");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806577");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806577");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806578");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806579");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806579");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806580");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806581");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793833");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794014");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794016");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794016");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794016");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794016");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794018");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794018");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794018");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794018");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794019");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794019");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793652");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793671");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793671");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793671");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 799, DateTimeKind.Utc).AddTicks(5255), "2026-09-10 03:06:50.799643", new DateTime(2026, 9, 10, 3, 6, 50, 799, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 799, DateTimeKind.Utc).AddTicks(8380), "2026-09-10 03:06:50.799923", new DateTime(2026, 9, 10, 3, 6, 50, 799, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 800, DateTimeKind.Utc).AddTicks(384), "2026-09-10 03:06:50.800134", new DateTime(2026, 9, 10, 3, 6, 50, 800, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "Email", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[] { "11111111-0000-0000-0000-000000000004", "Kabul Center", null, null, null, null, null, new DateTime(2026, 9, 10, 3, 6, 50, 800, DateTimeKind.Utc).AddTicks(1863), null, "wasil@wasilshop.com", "Unchanged", true, false, false, "2026-09-10 03:06:50.800187", "Wasil Shop", "0700000004", "RetailShop", "TAX004", null, new DateTime(2026, 9, 10, 3, 6, 50, 800, DateTimeKind.Utc).AddTicks(1870), 0 });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 818, DateTimeKind.Utc).AddTicks(8113), "2026-09-10 03:06:50.818861", new DateTime(2026, 9, 10, 7, 36, 50, 814, DateTimeKind.Local).AddTicks(5623), new DateTime(2026, 9, 10, 3, 6, 50, 818, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(2201), "2026-09-10 03:06:50.819372", new DateTime(2026, 9, 10, 7, 36, 50, 818, DateTimeKind.Local).AddTicks(8679), new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(5127), "2026-09-10 03:06:50.819606", new DateTime(2026, 9, 10, 7, 36, 50, 819, DateTimeKind.Local).AddTicks(4072), new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 821, DateTimeKind.Utc).AddTicks(2813), new DateTime(2027, 3, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "2026-09-10 03:06:50.821390", new DateTime(2026, 8, 31, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), new DateTime(2026, 9, 10, 3, 6, 50, 821, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 821, DateTimeKind.Utc).AddTicks(7442), new DateTime(2027, 4, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "2026-09-10 03:06:50.821924", new DateTime(2026, 9, 5, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), new DateTime(2026, 9, 10, 3, 6, 50, 821, DateTimeKind.Utc).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 822, DateTimeKind.Utc).AddTicks(4334), new DateTime(2026, 12, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "2026-09-10 03:06:50.822722", new DateTime(2026, 8, 26, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), new DateTime(2026, 9, 10, 3, 6, 50, 822, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 822, DateTimeKind.Utc).AddTicks(8268), "2026-09-10 03:06:50.822828", new DateTime(2026, 8, 21, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), new DateTime(2026, 9, 10, 3, 6, 50, 822, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 825, DateTimeKind.Utc).AddTicks(6884), "2026-09-10 03:06:50.825726", new DateTime(2026, 9, 10, 3, 6, 50, 825, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 826, DateTimeKind.Utc).AddTicks(1522), "2026-09-10 03:06:50.826335", new DateTime(2026, 9, 10, 3, 6, 50, 826, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 826, DateTimeKind.Utc).AddTicks(8312), "2026-09-10 03:06:50.827053", new DateTime(2026, 9, 10, 3, 6, 50, 826, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1530), "2026-09-10 03:06:50.827154", new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1579), "2026-09-10 03:06:50.827158", new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1610), "2026-09-10 03:06:50.827161", new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1637), "2026-09-10 03:06:50.827164", new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1665), "2026-09-10 03:06:50.827167", new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1723), "2026-09-10 03:06:50.827173", new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1751), "2026-09-10 03:06:50.827175", new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792497");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792544");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792545");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792545");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792547");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792547");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792548");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792548");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793168");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793205");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793205");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793205");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793206");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793207");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793209");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793209");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793210");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793210");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793210");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793210");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801047");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801126");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801214");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801293");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801293");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801295");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801295");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801296");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801296");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.801297");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[] { "44444444-0000-0000-0000-000000000016", 0, "ee934745-fd5f-48ce-ba22-634a94988516", "wasil@wasilshop.com", true, "Unchanged", "Wasil", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Admin", false, null, "WASIL@WASILSHOP.COM", "WASIL", "AQAAAAIAAYagAAAAEIyC1cEzOHxhIb9e4ybNuX8WnTGPAOiTzw/eyDXdpnR9zzyXQZ6xNXKwwBBoJh3djw==", null, true, "af022341-38f5-4c39-80d5-2550a1d6aeed", "11111111-0000-0000-0000-000000000004", "Wasil Shop", false, "wasil", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "RoleName", "UserName" },
                values: new object[] { "33333333-0000-0000-0000-000000000016", "44444444-0000-0000-0000-000000000016", "WasilShopAdmin", "wasil" });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DeletedAt", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[] { "ffffffff-0000-0000-0000-000000000004", "Kabul Center", "44444444-0000-0000-0000-000000000016", null, new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(6405), null, null, "wasil@wasilshop.com", null, "Unchanged", "Wasil", true, false, false, true, "2026-09-10 03:06:50.819641", "Admin", null, "123456789", 100.0m, "+1234567890", null, "11111111-0000-0000-0000-000000000004", "Wasil Shop", new DateTime(2026, 9, 10, 7, 36, 50, 819, DateTimeKind.Local).AddTicks(6362), null, new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(6409), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000016", "44444444-0000-0000-0000-000000000016" });

            migrationBuilder.DeleteData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000016");

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "368b0a3e-6480-4654-92ff-2699d64d47d9", "AQAAAAIAAYagAAAAEPvDkjibb6ZafRWH9zBrVvMTWDMRRzcGnZd2M/H4yHhn41pxtoWXAUqz7iO6Nn/e/Q==", "c2b13429-dee2-49a4-8793-78d31a5ddcce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "975bc94f-6d1e-4e93-863f-ed244ba97a71", "AQAAAAIAAYagAAAAEMpQILVnquPf3UY6f4HDYuG9Dytnr9QQL69eTlG/O02Y3MDYLOAwaPFH8U1BNN7FrA==", "c03d6af2-304f-41b9-8308-f4174d4ae113" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b008ccbe-4b73-4e5e-aa74-bcaca4d7b837", "AQAAAAIAAYagAAAAEFV27/FEHgaXCXE9ogBAMlcY8rDXZzAcfDOVhErswF1T/GAvxYJ1m0n+4cvRj0QGzA==", "1b7d33b6-a85a-4ee6-8ebf-0eecfd75bec2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b543cce4-2f70-4896-8e1d-21a12eea6251", "AQAAAAIAAYagAAAAEGMMmS3S1/pScYnXonHIDdD08CwAlRbirg9qe2SVt6JEdHLw5xoyTDYxpla/TcFT5g==", "0ee1f103-09a0-4d92-9176-05296ffc222a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14783360-0bb8-4959-bba0-f8983788a394", "AQAAAAIAAYagAAAAEEVKe+gbc+G8zZBYHh8mj+cWOqwqe7wTDagoyEcxyDSGiUVjK+HKiBIDJqh++LR+Zg==", "4b4ebb89-842a-42df-835e-3347698b62a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb50ee47-0b7e-462f-8c8b-89590caac3a6", "AQAAAAIAAYagAAAAEFdF5ey/3Wyc7AkBKk0tyRBqgdmYld6K4d99zYGk3vuLIoycYxf+QSF61lMEGHQuqA==", "9cd196d5-2742-4be1-a489-76316a2b54af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13eb8304-2b6f-459f-9639-e904fc43ff50", "AQAAAAIAAYagAAAAEHkaYMHFRBOXPfee585X6PcOAmxQpl1RPoGWfuy3rJu7fslraAfBKtNrW24JvUX1aA==", "8218fad8-2fd4-4598-8222-cb0244d9ce9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c5abc4a-1e40-48e4-88d5-173e7f7ca8dd", "AQAAAAIAAYagAAAAEGmBnCBZ7PObQ6Zj/0OhVHoeBcT9AYgau0riKnDSI9x3U+/RYKXFc5e9GLSCKCNn8A==", "62943abd-93cd-456b-a5dc-91b2ed89c52e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81ff25eb-ae88-46e0-bf8c-124c3c436c4e", "AQAAAAIAAYagAAAAEJ2EikG8Nej0eK46vwJGH1PgBk5O9Wxoijv4Guf7ur+lcQDVVlU8xuGXriA44eLS+g==", "03d42160-15bb-4571-a0f5-7ca22989eb5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "726eb25d-c6b8-42fb-8641-50919d12f3c2", "AQAAAAIAAYagAAAAEJDAKjZLVnTZWCWGYhbIyyyKYcT5DRa7LAx+N0etoOuFv0qaNUlqaCVudlC9IK35hg==", "dfa84088-d18e-449e-86ea-1ce0184c6f18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0386b4de-ca97-4fc6-894f-ff8eae2174aa", "AQAAAAIAAYagAAAAEEt/1015Rszo8urAZbDiL6VncBPvfENvu0hmJkDyKmxCP8cTOgr+tYOYpWcPAnBSvQ==", "19819400-4d24-4f68-bd67-7c610844f672" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f1871f-81c1-4277-9155-77b18347d8d3", "AQAAAAIAAYagAAAAELMvi8E2fqvuz08pInfWRXKAa1l8ZSVMH44CPccY+iLojIN3dmaBPG+Vkj0L0UEl5Q==", "92202ea0-0260-470c-acd0-95583854c537" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9a73262-3766-47ea-a5cd-905c2e53e6de", "AQAAAAIAAYagAAAAEG0jqVbfauOJdbvHVVDxDnliFsxqJiiSjMy4bPuBTEXx73HLms0CBKe1+YFIJg9PuQ==", "d3d2befb-a92d-4357-9988-62571aa36a12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7920011-6dcf-4936-98e3-bf0a926d375b", "AQAAAAIAAYagAAAAEBVeePGBy4LGfU3SGOTT8C6EVpDb+RnrIQRxy6aEd7209ISF76WWbT/jHk/JS9PxiQ==", "ff5f943f-e46d-4c9e-b2c8-324023b23f0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb963f89-2996-428e-8aba-e204aebbc733", "AQAAAAIAAYagAAAAEA8DvM18rYGuqGVZRdOnFp7ObMGj2pMOAdqiDRAUyq7N1Cdw55yHkelYzK6mNxlnig==", "ebd827c8-9726-4695-a5fa-dc9548892a99" });

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
    }
}
