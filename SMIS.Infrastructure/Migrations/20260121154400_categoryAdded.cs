using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class categoryAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "306f1488-d5f0-4cca-b942-4c6814925f1e", "AQAAAAIAAYagAAAAENIkyvQDhHIjd6wK4hUNw+dsUl8BDHit4jGZMETAz+Zn2aAPT74UMZpCONYBRYOOMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9dc5fe5e-f666-411f-8478-33ef8baee4dd", "AQAAAAIAAYagAAAAEBf3wTd4nSdD0fVx3r2nBKKZ+Ktp3CjEnd1sRlIxlsUV4N2l1NRjR70XdV6SOgBEgA==" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsPublic", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(7720), "Drinks and beverages", true, false, "Beverages", null, new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(7723) },
                    { "2", "SOFT", null, new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(8888), "Carbonated and non-carbonated drinks", true, false, "Soft Drinks", null, new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(8891) },
                    { "3", "FOOD", null, new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(8893), "Edible products", true, false, "Food Items", null, new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(8894) }
                });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(9539), new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(9855), new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(9859), new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(3736), new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(5268), new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(5274), new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(3202), new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(3208), new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(3210), new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(3211), new DateTime(2026, 1, 21, 20, 13, 59, 499, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 500, DateTimeKind.Local).AddTicks(7498), new DateTime(2026, 1, 21, 20, 13, 59, 500, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 500, DateTimeKind.Local).AddTicks(9771), new DateTime(2026, 1, 21, 20, 13, 59, 500, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 500, DateTimeKind.Local).AddTicks(9779), new DateTime(2026, 1, 21, 20, 13, 59, 500, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 496, DateTimeKind.Local).AddTicks(3197), new DateTime(2026, 1, 21, 20, 13, 59, 497, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(422), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(427), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(429), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(432), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(5501), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6156), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6158), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6159), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6161), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6162), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6164), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6140), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6145), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6146), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6148), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6150), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6151), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6153), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6155), new DateTime(2026, 1, 21, 20, 13, 59, 498, DateTimeKind.Local).AddTicks(6155) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2cefece-85b2-4e9d-b076-c3fa059cd286", "AQAAAAIAAYagAAAAEAsx9PxftKgQdP3CU+h+2zF+Roabp/0SSO4JdRbohmyhlMIhMtjgWRLuctyBXmpW9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8c9b7a1-30b1-4eb1-a8d8-c374d0b4b26c", "AQAAAAIAAYagAAAAEFviCCsU9+pFVXMg/xIcQP9J3QeYU/4Fd8T9cRF8v26pluz6ZHlCGDcIfjYDsNvEzg==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(6639), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(6735), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(6736), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 260, DateTimeKind.Local).AddTicks(307), new DateTime(2026, 1, 21, 16, 52, 5, 260, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 260, DateTimeKind.Local).AddTicks(680), new DateTime(2026, 1, 21, 16, 52, 5, 260, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 260, DateTimeKind.Local).AddTicks(682), new DateTime(2026, 1, 21, 16, 52, 5, 260, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(4882), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(4887), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(4888), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(4889), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(8896), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(9346), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(9348), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(2105), new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(9005), new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(9008), new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(9009), new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(9011), new DateTime(2026, 1, 21, 16, 52, 5, 258, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1490), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1705), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1706), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1707), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1708), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1709), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1710), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1696), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1698), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1699), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1700), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1701), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1702), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1703), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1704), new DateTime(2026, 1, 21, 16, 52, 5, 259, DateTimeKind.Local).AddTicks(1704) });
        }
    }
}
