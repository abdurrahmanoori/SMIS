using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSkuBarcodeImageUrlToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "Product",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Product",
                type: "TEXT",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Product",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c80b9789-1fe4-429e-bd57-c83eab77f3ae", "AQAAAAIAAYagAAAAELeLdIeeW6/hoD1H7V73m1a+k0aWVTcTaRy2LglP4MTdQS6bBxigorUKBnqhMqHc4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83de9ecc-c543-452a-9633-27c65b38e1d5", "AQAAAAIAAYagAAAAELoQxFq7GvqXb6tCd2eoi1pYxT+oJlccEWEZSwGhj+ksoBk2mAOlzQajK4wt0kIz1g==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(9973), new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 695, DateTimeKind.Local).AddTicks(1509), new DateTime(2026, 1, 21, 20, 44, 47, 695, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 695, DateTimeKind.Local).AddTicks(1519), new DateTime(2026, 1, 21, 20, 44, 47, 695, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6491), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6830), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6834), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Barcode", "CreatedDate", "ImageUrl", "SKU", "UpdatedDate" },
                values: new object[] { "1234567890123", new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(3692), "https://example.com/images/paracetamol.jpg", "PAR-500MG-001", new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Barcode", "CreatedDate", "ImageUrl", "SKU", "UpdatedDate" },
                values: new object[] { "1234567890124", new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(6674), "https://example.com/images/ibuprofen.jpg", "IBU-200MG-002", new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Barcode", "CreatedDate", "ImageUrl", "SKU", "UpdatedDate" },
                values: new object[] { "1234567890125", new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(6682), "https://example.com/images/aspirin.jpg", "ASP-100MG-003", new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(266), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(291), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(298), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(300), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(5161), new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(7929), new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(7947), new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 688, DateTimeKind.Local).AddTicks(7169), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4968), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4976), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4978), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4980), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1116), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1794), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1795), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1797), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1799), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1800), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1802), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1778), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1782), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1784), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1785), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1787), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1789), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1790), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1792), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1793) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Product");

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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(7720), new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(8888), new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(8893), new DateTime(2026, 1, 21, 20, 13, 59, 501, DateTimeKind.Local).AddTicks(8894) });

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
    }
}
