using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class namechanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "UnitOfMeasure",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Translations",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "TranslationKeys",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Shop",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "ProvinceTranslations",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Provinces",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "ProductUnit",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Product",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Languages",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Districts",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Category",
                newName: "EntityState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "AppLogs",
                newName: "EntityState");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f51d3ad7-a6f9-41bf-bbfe-574bfcf94772", "AQAAAAIAAYagAAAAEE3tu3clGWvFLq+C2UbX6iyQ1qxwtRu8hRisflrmYje8PQ9nAxtOvqLfr62rjjN3OQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c06aeeca-5413-435d-a70e-ca789ac14de2", "AQAAAAIAAYagAAAAEOO9Bwa9VT2Vahfpci6P27QFK2WB2LZjN3QcAYG9A39siGVf9NUzFVLS8jWnSptVMg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(7537), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8482), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(8498), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8501), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(8503), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8504), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8508), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(8510), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8512), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(8514), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 502, DateTimeKind.Local).AddTicks(8829), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(8855), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 502, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 502, DateTimeKind.Local).AddTicks(9363), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 502, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 502, DateTimeKind.Local).AddTicks(9390), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(9393), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 502, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(6627), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 517, DateTimeKind.Local).AddTicks(7283), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 517, DateTimeKind.Unspecified).AddTicks(7305), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 517, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3284), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3298), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3301), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3306), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3308), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3314), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3316), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3321), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3324), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3328), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3331), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3336), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3338), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(1471), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(2419), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3194), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3207), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3242), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3245), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3252), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3255), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3261), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3263), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3268), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3276), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 520, DateTimeKind.Unspecified).AddTicks(3279), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 520, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(2502), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3757), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3761), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3793), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3796), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3803), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3807), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3701), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3810), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3812), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3814), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3823), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3826), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3828), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3830), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3833), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3706), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3835), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3837), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3709), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3717), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4637), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4775), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4578), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4585), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4592), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4611), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4619), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4624), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4632), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(9279), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(9304), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(9310), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(9329), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(9332), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(9334), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(9337), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 504, DateTimeKind.Local).AddTicks(3106), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 504, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 504, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 516, DateTimeKind.Local).AddTicks(7833), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 516, DateTimeKind.Unspecified).AddTicks(7883), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 516, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 516, DateTimeKind.Local).AddTicks(8864), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 516, DateTimeKind.Unspecified).AddTicks(8877), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 516, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 499, DateTimeKind.Local).AddTicks(2378), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 500, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7674), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 500, DateTimeKind.Unspecified).AddTicks(7687), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7689), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 500, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7693), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 500, DateTimeKind.Unspecified).AddTicks(7695), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7696), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 500, DateTimeKind.Unspecified).AddTicks(7698), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7699), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 500, DateTimeKind.Unspecified).AddTicks(7728), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7729), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 500, DateTimeKind.Unspecified).AddTicks(7732), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7733), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 500, DateTimeKind.Unspecified).AddTicks(7735), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 500, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2078), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2831), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2833), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2834), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2836), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2837), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2790), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2800), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2802), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2804), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2805), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2807), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2808), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2812), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2820), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2821), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2823), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2824), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2828), new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 501, DateTimeKind.Unspecified).AddTicks(2830), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 18, 36, 55, 501, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(7589), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8684), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8660), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8668), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8679), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8682), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "UnitOfMeasure",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "Translations",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "TranslationKeys",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "Shop",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "ProvinceTranslations",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "Provinces",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "ProductUnit",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "Product",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "Languages",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "Districts",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "Category",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EntityState",
                table: "AppLogs",
                newName: "State");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a473dc92-463f-45d5-985b-825144b747c6", "AQAAAAIAAYagAAAAEIL1E/CYBAxUDy6zbCknVZjk6eOMcF6WMb1R6m+Eeb8Y/yziJeQZFgQDa0/RIbwfDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62d28cd4-4014-46c5-86e3-01354eebd478", "AQAAAAIAAYagAAAAENKRazi3kBFydoMU+BvZ9rO+K2FIfjbMxBnrLcwPwwhV78f65SJRRuujXU4pxUP7Jg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7492), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7502), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7875), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7880), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7882), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7886), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7887), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7891), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7892), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7901), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7905), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1532), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1717), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(1722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1723), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 210, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 210, DateTimeKind.Unspecified).AddTicks(614), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 210, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(9596), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 225, DateTimeKind.Unspecified).AddTicks(9617), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4835), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4842), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4849), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4853), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4856), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4865), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4869), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4871), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4875), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4878), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4892), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(3609), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4295), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4305), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4771), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4778), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4788), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4800), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4805), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4809), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4813), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4817), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4820), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4828), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4832), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8388), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8392), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8396), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8401), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8405), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8436), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8440), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8449), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8457), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8462), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8466), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8470), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8474), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8478), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8482), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8335), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8495), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8340), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8344), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8357), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8361), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8365), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9953), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(476), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(436), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(441), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(450), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(454), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(459), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(463), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(467), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(472), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9433), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9443), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9445), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9450), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9451), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9455), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9456), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9459), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(6497), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(6506), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(3024), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 225, DateTimeKind.Unspecified).AddTicks(3087), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(3923), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 225, DateTimeKind.Unspecified).AddTicks(3936), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 210, DateTimeKind.Local).AddTicks(3400), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2514), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2522), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2523), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2527), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2529), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2538), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2539), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2543), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2544), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2549), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2553), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2554), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5333), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5680), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5685), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5688), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5689), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5621), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5641), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5642), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5647), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5657), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5660), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5662), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5666), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5670), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5671), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5675), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4012), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4332), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4298), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4303), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4311), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4320), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4324), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "LastModifiedUtc", "State" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4328), new TimeSpan(0, 0, 0, 0, 0)), 4 });
        }
    }
}
