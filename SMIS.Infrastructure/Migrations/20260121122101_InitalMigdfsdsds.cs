using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitalMigdfsdsds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ee98b4e-06a7-4b33-b46d-84947f1ec3a5", "AQAAAAIAAYagAAAAEHC3B3vNsw07FVq0TWM04oDDK7G4A9asCTiVD8KP+hrcP9CxBupQWOiJiucx5jhqmw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37bb0eb3-eee0-4cd6-994b-abe48c9c93b1", "AQAAAAIAAYagAAAAEIdibySXcSQ4lksVM5NjlJCHMk6PiRDPqIrrEk7KLdImpzzONTszwsxnpicEPFTipA==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(4841), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(4937), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(4960), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(8708), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(9104), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(9107), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(3070), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(3074), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(3075), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(3076), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(7149), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(7624), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(7629), new DateTime(2026, 1, 21, 16, 51, 0, 872, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 870, DateTimeKind.Local).AddTicks(8267), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(6200), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(6203), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(6204), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(6205), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9301), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9768), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9770), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9772), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9773), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9774), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9776), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9754), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9758), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9760), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9761), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9763), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9764), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9765), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9767), new DateTime(2026, 1, 21, 16, 51, 0, 871, DateTimeKind.Local).AddTicks(9767) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85c99687-9666-4863-8aa8-406ebf7174aa", "AQAAAAIAAYagAAAAEKKRsTrdIpaJLsc9J+UOTt0YDeTh+aNChV+z8cO2WDu2mtT0CADoeHFN76MEyCeXXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5faab7b8-e1fc-4504-beb1-47ee30aa965c", "AQAAAAIAAYagAAAAEN+0NjxnGzEmH123pmtlQCGlIVu7AsGD175k9D8iZW10mPjudNv5jA6uqtY81dlFBA==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5410), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5688), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5692), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(4165), new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(5517), new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(5522), new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1409), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1416), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1418), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1419), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(623), new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(2093), new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(2098), new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 284, DateTimeKind.Local).AddTicks(9407), new DateTime(2026, 1, 21, 16, 42, 44, 285, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1697), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1702), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1704), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1706), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(5674), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6259), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6261), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6263), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6264), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6266), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6267), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6245), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6249), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6250), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6252), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6254), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6255), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6257), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6258), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6258) });
        }
    }
}
