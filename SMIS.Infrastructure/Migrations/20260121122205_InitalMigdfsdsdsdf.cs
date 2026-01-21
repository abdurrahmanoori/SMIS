using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitalMigdfsdsdsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
