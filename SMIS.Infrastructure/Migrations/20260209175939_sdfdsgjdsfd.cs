using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfdsgjdsfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_Shop_ShopId",
                table: "ProductUnit");

            migrationBuilder.DropIndex(
                name: "IX_ProductUnit_ShopId",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "ProductUnit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ba020ee-6736-41d5-8157-037630263e39", "AQAAAAIAAYagAAAAENmxNBbe8u2EjUf2WnObg4dYfy2cWw83s3gIWiN1xJY2lskyZRvL1Sow7VhKapD/UA==", "e9a8f382-2cdd-4608-baa7-c9571964a02a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f16fd5e-5c20-4d30-83cd-f70606f32095", "AQAAAAIAAYagAAAAEEGCPn0Ocgog/D23KLdKVCpgLyM3CrxWdxizXCRvjuo6xlQRUOtAb+li1ExnLwI+AQ==", "eb0f17c2-538c-4602-9ea5-8b705ecdcf02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff745d71-9135-40de-965d-3430bff38954", "AQAAAAIAAYagAAAAEFzJ+bEK2NSaUEsfCX1CDg+7vstv+y5SOCzm/Q7MK0QLPCOxsjVoOD3YqaU6JaJvoA==", "ba01bfb1-87d1-40aa-b5fd-2ea577c9ea67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e99a15f-4244-4b7c-9091-b7eb39161dae", "AQAAAAIAAYagAAAAEOsT62O8L4YrOdNISygb0nW/dc7g5HAhEvNl4cPa4cC4wIStlI+fxlnD0FY0Mh5RDA==", "f64d378c-ddce-43e3-9591-60e38d120ae7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f1a8fc4-95cf-4baf-a505-dacd1f631faa", "AQAAAAIAAYagAAAAEO9XoX564hfp7X+RSuwhBDuOL4RJD22ZiQcauJcXnZR65yFs47SjogSuIlkqQWrMyg==", "5d0da871-830e-4ffd-b128-d3c6464150bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b94098c7-5c85-4686-95bc-720b2cbcc180", "AQAAAAIAAYagAAAAEF6VOmH0zjfi5BRv4KSTT1wfkU3kv3p1q6zAnuajAqdyyrfkIE6/RamLEWDwj4w6BA==", "fab5fc9a-60cd-46e1-928c-5f185792e683" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4316b54-19b0-413d-9a93-a333ba48f959", "AQAAAAIAAYagAAAAEHCYeh2u0qh1lqzl7HKPk7s3maZcU7/hdnbqBmZJKgoYFZpLfyB0mhRhxftEWPjHjA==", "cd082d70-66bc-4e29-a6ff-bf4686254eb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "674a8ab1-7a38-4075-a25d-83ca24dfb445", "AQAAAAIAAYagAAAAEO8FvToZm03QqidIQ1hev4/1rMJ/9mtyFeA+EXPySH7N3Z0rtvch7TXpUDDCX+zrdw==", "35c9e261-84f0-4b6e-82a7-805aaa3f2327" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d989218-c360-45fc-bbc3-b08dff2f640d", "AQAAAAIAAYagAAAAED5cMoyqGKYfVMTqhbA9GsN6iPIJYmP5/xhXsF62+5rNk6vwLmxrzwYC90MYpHT70g==", "eba31eb3-1171-4171-b674-86aadeb7306d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51dbf6fc-430a-43fa-b262-6de25fb8f0a3", "AQAAAAIAAYagAAAAEOYc1OzUYopaTG+U+ZNriNVYaQ2lWKJPQSCPqdtehEhTQR2ZqMEteym2KK2OblVaEg==", "3f5518e2-dfa1-4ce1-827f-8a5c302c2e14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae19688e-ac8c-4cec-9352-f83b4ca0fdd4", "AQAAAAIAAYagAAAAEPAOslESVp23uM00FuPJynu2XWH+jp8YqM9PU2DRo/fbpoUE5JCCj99VzrZYrEql7A==", "c2b2e18e-91ad-46cf-bbab-d6c866cb3a5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0752e067-5273-47a3-89c0-e90b6a685aba", "AQAAAAIAAYagAAAAEGEo7l0ZcYIhPxlDVHkIaDzGXTVEX6BMVQLs1v2wYk8vENa2mWnHT8osHWWszVwMow==", "a5a3b330-b8f0-4939-ad1a-1c433cb36bf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04b29cb5-31a6-4b50-aef4-1b75e2ee8fe1", "AQAAAAIAAYagAAAAEHxqRYVadBq2QVuPs2VHgZ/9abgC6yaRLR1hjmo7jH59XxLaeHHEu9oIonD7soiyEA==", "11f98dab-7ab5-4b2d-98f6-7547ba7a65f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2930fd9-5d25-4a0d-9c23-4a36f9bcda25", "AQAAAAIAAYagAAAAEGs4f/MaS4hEG/uIU+tRX+6HoyRVlzcgX0/qtOBm8NrmySb99YAToM3lxtF+5y/gaA==", "281f94ee-1ebf-4180-a0f9-99b2b0d4b76f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa114aa4-eb73-476f-bf54-87f5033c29bd", "AQAAAAIAAYagAAAAEGCkikinRT9Ze5oxpoKJ0xf8/sSQ/3+wBszeLTo0NR/iXqN7/ZnncbLPTZCOeoMNMQ==", "677d0807-a13a-4c98-8e39-d8b98422ee01" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 347, DateTimeKind.Local).AddTicks(1494), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 347, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 347, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6634), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6641), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6662), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6665), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6666), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6668), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6669), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6670), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 349, DateTimeKind.Local).AddTicks(3819), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 349, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 349, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9407), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9410), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(5827), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(7835), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(7847), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9234), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9245), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9316), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9319), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9331), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9333), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9348), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9350), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9360), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9362), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9373), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9382), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(8997), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9560), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(9570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9572), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 334, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 334, DateTimeKind.Unspecified).AddTicks(8112), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 334, DateTimeKind.Unspecified).AddTicks(8116), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 716, DateTimeKind.Local).AddTicks(3093), new DateTime(2026, 3, 11, 17, 59, 35, 715, DateTimeKind.Utc).AddTicks(7183), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 716, DateTimeKind.Unspecified).AddTicks(3119), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 59, 35, 715, DateTimeKind.Utc).AddTicks(7182), new DateTime(2026, 2, 9, 22, 29, 35, 716, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 717, DateTimeKind.Local).AddTicks(9932), new DateTime(2026, 2, 24, 17, 59, 35, 717, DateTimeKind.Utc).AddTicks(9862), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 718, DateTimeKind.Unspecified).AddTicks(13), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 59, 35, 717, DateTimeKind.Utc).AddTicks(9860), new DateTime(2026, 2, 9, 22, 29, 35, 717, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 718, DateTimeKind.Local).AddTicks(3164), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 718, DateTimeKind.Unspecified).AddTicks(3194), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 59, 35, 718, DateTimeKind.Utc).AddTicks(3154), new DateTime(2026, 2, 9, 22, 29, 35, 718, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 342, DateTimeKind.Local).AddTicks(8856), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 342, DateTimeKind.Unspecified).AddTicks(8896), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 342, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7173), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7184), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7195), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7207), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7209), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7230), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7241), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7253), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 345, DateTimeKind.Local).AddTicks(9759), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 345, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 345, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(4296), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(4381), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7029), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7041), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7092), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7095), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7106), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7118), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7120), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7130), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7146), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 683, DateTimeKind.Local).AddTicks(8150), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 685, DateTimeKind.Unspecified).AddTicks(7013), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 685, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2462), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2465), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2472), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2475), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2480), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2484), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2489), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2498), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2507), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2512), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2521), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2546), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2556), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2569), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2578), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2582), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 686, DateTimeKind.Local).AddTicks(9019), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 686, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 686, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2587), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2596), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2599), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2604), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2616), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2620), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2625), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2628), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2633), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2642), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2654), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2657), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2689), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2694), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2700), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2704), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2709), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2713), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(1012), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(1029), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2717), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2741), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2745), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2769), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2772), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2777), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2786), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2789), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2794), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2798), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2803), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2806), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2811), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2815), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2820), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2826), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2832), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2835), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2307), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2322), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2840), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2843), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2849), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2852), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2858), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2861), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2866), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2875), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2884), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2887), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2892), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2904), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2908), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2347), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2351), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2359), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2386), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2390), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2442), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2453), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2457), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 679, DateTimeKind.Unspecified).AddTicks(1163), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(748), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(768), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(773), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(784), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(790), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 680, DateTimeKind.Unspecified).AddTicks(7940), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(797), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(810), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(822), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(828), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(885), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 680, DateTimeKind.Unspecified).AddTicks(9722), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(896), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(903), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(919), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(936), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(942), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(950), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(955), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(968), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(986), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(992), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(997), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(1005), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(1011), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(669), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(710), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(5676), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6932), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6938), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6879), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6906), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6918), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6925), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4218), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(4231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4586), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(4594), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4596), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(4599), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4612), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(4614), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 338, DateTimeKind.Local).AddTicks(7867), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(7883), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 338, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 341, DateTimeKind.Local).AddTicks(5316), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 341, DateTimeKind.Unspecified).AddTicks(5388), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 341, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 341, DateTimeKind.Local).AddTicks(7590), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 341, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 341, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 696, DateTimeKind.Local).AddTicks(3771), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 696, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 696, DateTimeKind.Local).AddTicks(3723), new DateTime(2026, 2, 9, 22, 29, 35, 696, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(7210), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 714, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(7197), new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(9811), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 714, DateTimeKind.Unspecified).AddTicks(9827), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(9806), new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 688, DateTimeKind.Local).AddTicks(5678), new DateTime(2026, 8, 9, 17, 59, 35, 687, DateTimeKind.Utc).AddTicks(8577), new DateTime(2026, 1, 30, 17, 59, 35, 687, DateTimeKind.Utc).AddTicks(8491), new DateTime(2026, 2, 9, 22, 29, 35, 688, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 690, DateTimeKind.Local).AddTicks(4127), new DateTime(2026, 9, 9, 17, 59, 35, 690, DateTimeKind.Utc).AddTicks(4046), new DateTime(2026, 2, 4, 17, 59, 35, 690, DateTimeKind.Utc).AddTicks(4039), new DateTime(2026, 2, 9, 22, 29, 35, 690, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 690, DateTimeKind.Local).AddTicks(7957), new DateTime(2026, 5, 9, 17, 59, 35, 690, DateTimeKind.Utc).AddTicks(7919), new DateTime(2026, 1, 25, 17, 59, 35, 690, DateTimeKind.Utc).AddTicks(7915), new DateTime(2026, 2, 9, 22, 29, 35, 690, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 691, DateTimeKind.Local).AddTicks(686), new DateTime(2026, 1, 20, 17, 59, 35, 691, DateTimeKind.Utc).AddTicks(651), new DateTime(2026, 2, 9, 22, 29, 35, 691, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 692, DateTimeKind.Local).AddTicks(4173), new DateTime(2026, 2, 9, 22, 29, 35, 692, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4400), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 694, DateTimeKind.Local).AddTicks(5013), new DateTime(2026, 2, 9, 22, 29, 35, 694, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(295), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4214), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4299), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4323), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4341), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4361), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4381), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(1890), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(1916), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2848), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2880), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2883), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2885), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2886), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2901), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2903), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2904), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2906), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2907), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2909), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2911), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2913), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(7269), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8323), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8327), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8330), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8334), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8232), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8244), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8270), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8272), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8281), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8283), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8284), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8286), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8288), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8315), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8317), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8319), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8320), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8322), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 337, DateTimeKind.Unspecified).AddTicks(4183), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(4007), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3948), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3970), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3974), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3978), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopId",
                table: "ProductUnit",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "ProductUnit",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84fb800d-f03e-4764-9f44-3a1dbd878a86", "AQAAAAIAAYagAAAAENOBYyefNEna9fO3t0F4XU6jq+bRFbvpx38y1GFJAlZj+/Is106Bz+6a2SAs5o7UvA==", "9fc25fc7-6278-40e8-b9e0-a42e4f6a5781" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e50db5ce-f577-4598-86f4-cac1de8bd30c", "AQAAAAIAAYagAAAAEH+QNW57hx4iE2LT5aP7qBc8SMhnv3TPIgC72x/d7Mq7qAcIseOM/l2AxV1mUAzvqA==", "8b50993e-5d70-41fa-9ce3-440e9e1ba3f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3461df7-05d0-4846-a88e-592586c9253b", "AQAAAAIAAYagAAAAEJXs3xECTC8IYc+MUSHAXmcOpkjYlJZSdeNaHQ6Qw9/+a/YC2UKuIJqu2iOcqJ0dcQ==", "58b249cb-fd07-48f9-8031-f6d09416e216" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8877a279-9c29-4d3e-a015-90369a6bf552", "AQAAAAIAAYagAAAAEKP2b8UWrZ84y1stjiYjfH0Y0QRmqn5xXHD4al+fLT5dY4jMBAYhBUC6YTLakVPyiA==", "538fb3e8-c1da-4aaa-8acc-c3516cf041f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d41f17d-6050-4bfb-bdc8-a7ece47e163b", "AQAAAAIAAYagAAAAEHI8GHPDu8zrMzZ8Mphx6tkwUOOqDLnxooXRy9KCvexKHRNt49HXzDULwo3F+Pe+tw==", "a77c8d35-ff45-47cf-b447-55ca5eb08710" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6368475a-3fbc-4880-97c3-bd052fda8d5f", "AQAAAAIAAYagAAAAEFRVjUJvK9qNnpg799JzyIXYAHbSFhV6t69Nk/ItQjZAbgpwagdKaGEio7uSYGie4Q==", "b6370187-6907-48d3-a280-f6461bd15a11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35d1c203-82e7-4970-b64a-aa2b50a7b51a", "AQAAAAIAAYagAAAAELD7w7HgDHMYr4B5xXX1c+5DZ/7xfDaY6XEiEwJ02g5ocDFZTCX7Yw3/uGBnfSPAWQ==", "6fffe26e-4349-406c-9224-4ab775ce1dd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e05a771-676e-4252-a9ef-35bd626d05c9", "AQAAAAIAAYagAAAAEDrp8oE8SBPJofZuNQSZmKGPgMQxLDq+no9Pkz/VhoZNHcP5Pr76S2YyFmN2N3ntsQ==", "46f23331-5771-4009-9900-91e27505cc13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d11cd1c-f2a1-4947-ae1e-5eac2dd2ba6a", "AQAAAAIAAYagAAAAEDemQnP4Jkm/KGtEETfuKfTA+aR48IUKUHETt/RJcz92NcsbUGylq9m5ZdMO05iQ0w==", "c0d6f7ba-3e2f-4826-b5a1-9ab36b495c7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d7a874-2a43-4496-ae4b-17604b821450", "AQAAAAIAAYagAAAAEPNVT1AK6lJzT3sT69onnd3laTNKUSMi4gJphzI90husS7P1QmfP+EW56gDS+A2FTQ==", "6a0e8702-a1c8-49dd-8dc0-dcfb2837260d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "110eca8a-aca0-4187-90fa-2df0f2b029f2", "AQAAAAIAAYagAAAAEAt8hgoIPO2GIs5YUpEroRCUciJ+BN05YTU9nIUmouPh5wUWS2wasuk5/vYEqEwp0w==", "fa51cbd0-327f-45ad-b8d0-b8845c3cb243" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aa7ac38-ef3d-4b09-a8fd-80c762164650", "AQAAAAIAAYagAAAAEGL85qYQPNP0lVIkKyVQ+IZyjH2KmXcNGpGTJnubDMJLfygcUUoSi3C/kSVJBqn9Bg==", "ab0c14ef-f4cc-428e-b491-668adc163cab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60c733a2-7eab-4eab-962f-9147b6be484a", "AQAAAAIAAYagAAAAEEUiyHb8aDto/U+MN9x8lk7N7NhjuzbtHmFrtIcZ/YgrbefHghUoqTtHFkuxr0AtkQ==", "7ed0c1dd-8b33-4084-aa79-2cda404aa70f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b1d2288-29af-4452-b4a6-642eae9f740f", "AQAAAAIAAYagAAAAEJym63She2GGxLl+yBu0H0ZO+M1nbLNsg8sdF9n7nkPv3fc8C8uMAnDhPB99zh+yxg==", "795fde35-1620-407d-98b8-10a07b22548c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12337781-1b82-499c-9ecd-51ae7c041271", "AQAAAAIAAYagAAAAEFpJehnb4qCIA7m3MxL3aQ9JiCMlBLcu+IgV4WiQOTzr6Q0DWtARvoAkkIdu5zM1tg==", "c12b38c5-beb7-459d-8628-40c92cf516f4" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 617, DateTimeKind.Local).AddTicks(1436), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 617, DateTimeKind.Unspecified).AddTicks(1484), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 617, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(78), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(84), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(111), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(112), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(114), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(115), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(116), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(117), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(118), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 620, DateTimeKind.Local).AddTicks(4024), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 620, DateTimeKind.Unspecified).AddTicks(4213), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 620, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5658), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5669), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 622, DateTimeKind.Local).AddTicks(8929), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 622, DateTimeKind.Unspecified).AddTicks(8956), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 622, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(2691), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(2717), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5278), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5314), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5437), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5444), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5478), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5529), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5572), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5578), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5620), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5626), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(9647), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(9663), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 603, DateTimeKind.Local).AddTicks(324), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 603, DateTimeKind.Unspecified).AddTicks(335), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 603, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 603, DateTimeKind.Local).AddTicks(338), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 603, DateTimeKind.Unspecified).AddTicks(340), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 603, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 599, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 599, DateTimeKind.Unspecified).AddTicks(9693), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 599, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 55, DateTimeKind.Local).AddTicks(6338), new DateTime(2026, 3, 11, 17, 34, 37, 55, DateTimeKind.Utc).AddTicks(1508), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 55, DateTimeKind.Unspecified).AddTicks(6356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 34, 37, 55, DateTimeKind.Utc).AddTicks(1507), new DateTime(2026, 2, 9, 22, 4, 37, 55, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 56, DateTimeKind.Local).AddTicks(9001), new DateTime(2026, 2, 24, 17, 34, 37, 56, DateTimeKind.Utc).AddTicks(8983), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 56, DateTimeKind.Unspecified).AddTicks(9054), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 34, 37, 56, DateTimeKind.Utc).AddTicks(8981), new DateTime(2026, 2, 9, 22, 4, 37, 56, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 57, DateTimeKind.Local).AddTicks(1524), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 57, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 34, 37, 57, DateTimeKind.Utc).AddTicks(1518), new DateTime(2026, 2, 9, 22, 4, 37, 57, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 612, DateTimeKind.Local).AddTicks(626), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 612, DateTimeKind.Unspecified).AddTicks(681), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 612, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6051), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6055), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6074), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6095), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6118), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6122), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6140), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6147), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6211), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6241), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 615, DateTimeKind.Local).AddTicks(8197), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 615, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 615, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(2572), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5756), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5771), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5843), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5902), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5912), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5958), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5993), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5997), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6017), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6031), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 30, DateTimeKind.Local).AddTicks(6629), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 32, DateTimeKind.Unspecified).AddTicks(1336), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 32, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3004), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3007), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3011), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3020), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3024), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3027), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3030), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3032), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3035), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3041), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3044), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3086), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3093), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3095), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3098), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3118), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3124), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(324), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3127), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3130), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3133), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3139), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3141), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3145), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3150), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3153), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3156), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3159), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3162), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3165), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3168), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3179), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3185), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2038), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2066), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3191), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3193), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3196), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3199), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3203), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3208), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3214), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3217), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3220), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3225), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3229), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3234), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3237), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3240), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3245), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2936), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3252), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3257), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3263), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3266), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3269), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3277), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3283), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3288), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3291), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3294), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3297), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2973), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2980), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2986), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2992), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2998), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 26, DateTimeKind.Unspecified).AddTicks(626), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2464), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2471), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2476), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2481), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2498), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 27, DateTimeKind.Unspecified).AddTicks(9783), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2524), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2530), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2535), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2541), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2546), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2551), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2559), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2605), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2625), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2641), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2646), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2402), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2653), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2658), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2665), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2672), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2677), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2683), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2689), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2694), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2428), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2434), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2447), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2452), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(4753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6474), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6481), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6434), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6439), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6443), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6447), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6458), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6465), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(2591), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3073), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3087), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3091), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(3093), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 606, DateTimeKind.Local).AddTicks(1326), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 606, DateTimeKind.Unspecified).AddTicks(1382), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 606, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 610, DateTimeKind.Local).AddTicks(2512), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 610, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 610, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 610, DateTimeKind.Local).AddTicks(5102), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 610, DateTimeKind.Unspecified).AddTicks(5144), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 610, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 39, DateTimeKind.Local).AddTicks(5027), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 39, DateTimeKind.Unspecified).AddTicks(5042), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 39, DateTimeKind.Local).AddTicks(5023), new DateTime(2026, 2, 9, 22, 4, 37, 39, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(3422), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 54, DateTimeKind.Unspecified).AddTicks(3467), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(3409), new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(5814), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 54, DateTimeKind.Unspecified).AddTicks(5826), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(5811), new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 34, DateTimeKind.Local).AddTicks(3157), new DateTime(2026, 8, 9, 17, 34, 37, 33, DateTimeKind.Utc).AddTicks(8498), new DateTime(2026, 1, 30, 17, 34, 37, 33, DateTimeKind.Utc).AddTicks(8398), new DateTime(2026, 2, 9, 22, 4, 37, 34, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(5261), new DateTime(2026, 9, 9, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(5238), new DateTime(2026, 2, 4, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(5237), new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(8003), new DateTime(2026, 5, 9, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(7990), new DateTime(2026, 1, 25, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(7988), new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(9988), new DateTime(2026, 1, 20, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(9966), new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 36, DateTimeKind.Local).AddTicks(8211), new DateTime(2026, 2, 9, 22, 4, 37, 36, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9150), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(3006), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(6202), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9046), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9090), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9102), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9112), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9129), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9140), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(5342), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6437), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6462), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6465), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6466), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6469), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6470), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6474), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6476), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6479), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6481), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6484), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6486), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6489), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(2523), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(2545), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3653), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3659), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3663), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3516), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3534), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3537), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3539), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3540), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3543), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3545), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3548), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3550), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3553), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3555), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3642), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3645), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3649), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3651), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 603, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 604, DateTimeKind.Unspecified).AddTicks(7788), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1810), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1849), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1875), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_ShopId",
                table: "ProductUnit",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_Shop_ShopId",
                table: "ProductUnit",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
