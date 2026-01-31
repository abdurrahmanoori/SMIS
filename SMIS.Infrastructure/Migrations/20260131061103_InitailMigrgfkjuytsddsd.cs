using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigrgfkjuytsddsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bbc60b0-02db-434f-ad9a-81ac737a6633", "AQAAAAIAAYagAAAAEIok9bXYjXs4/ScZgGdtY2AabAh0lGRy2z/d68VXcynYYZEMsDc8Pa6DoW4LTKfeKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8420612b-3c08-4730-8a92-b0961792ccfa", "AQAAAAIAAYagAAAAEM7FLLjWx9WuSugrZ7YKWqB/aeqDRpajmaHj9RFpDb51S3NFABbaDty4jP3qd31PjA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4040), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4329), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4333), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4334), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4338), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4343), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4347), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4350), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4381), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(4392), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4493), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(4497), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4498), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(4501), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(3083), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(3379), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 584, DateTimeKind.Local).AddTicks(4545), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 584, DateTimeKind.Unspecified).AddTicks(4575), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 584, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1708), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1712), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1716), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1719), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1724), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1727), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1731), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1738), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1741), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1746), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1749), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1753), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1758), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 585, DateTimeKind.Local).AddTicks(9640), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 585, DateTimeKind.Unspecified).AddTicks(9661), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 585, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(838), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1636), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1641), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1655), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1658), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1664), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1667), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1678), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1687), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1701), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 571, DateTimeKind.Unspecified).AddTicks(8343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1155), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1165), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1187), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1193), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1235), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1245), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1248), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1126), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1252), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1255), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1134), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1141), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1151), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3312), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3317), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3320), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3281), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3294), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3298), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3301), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3305), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3309), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2401), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2411), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2413), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2416), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2417), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2422), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2425), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(8735), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 583, DateTimeKind.Local).AddTicks(6892), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 583, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 583, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 583, DateTimeKind.Local).AddTicks(8281), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 583, DateTimeKind.Unspecified).AddTicks(8292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 583, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 572, DateTimeKind.Local).AddTicks(5852), new DateTime(2026, 7, 31, 6, 11, 2, 572, DateTimeKind.Utc).AddTicks(3311), new DateTime(2026, 1, 21, 6, 11, 2, 572, DateTimeKind.Utc).AddTicks(3259), new DateTime(2026, 1, 31, 10, 41, 2, 573, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 573, DateTimeKind.Local).AddTicks(8984), new DateTime(2026, 8, 31, 6, 11, 2, 573, DateTimeKind.Utc).AddTicks(8954), new DateTime(2026, 1, 26, 6, 11, 2, 573, DateTimeKind.Utc).AddTicks(8953), new DateTime(2026, 1, 31, 10, 41, 2, 573, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(480), new DateTime(2026, 4, 30, 6, 11, 2, 574, DateTimeKind.Utc).AddTicks(467), new DateTime(2026, 1, 16, 6, 11, 2, 574, DateTimeKind.Utc).AddTicks(465), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(1232), new DateTime(2026, 1, 11, 6, 11, 2, 574, DateTimeKind.Utc).AddTicks(1226), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(6379), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7055), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7060), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7061), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7071), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7074), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7075), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7078), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7082), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7085), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7086), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9208), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9465), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9467), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9468), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9473), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9474), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9476), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9427), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9431), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9432), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9440), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9443), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9444), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9447), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9448), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9451), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9452), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9456), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9456), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9460), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9460), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9464), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6917), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6904), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6907), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6911), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6914), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d632c6d-3335-4115-8267-c3ed4e01993e", "AQAAAAIAAYagAAAAEEoQi1RqEc9+IpLsfC4ttlVZ12n/EFvnNkond8EBktnypkJIJUh4B+QGISI/J4poBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a7c9741-a240-4dbf-bf96-0b6e289fe1d2", "AQAAAAIAAYagAAAAEDw4Rw8w4MpB842s8YAXFvJR85+Wt/e3Unxr8drAr2EGiVyN5Hap81RcRkPY/z/DQg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(3870), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(3880), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4210), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(4215), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4216), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4221), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(4228), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4229), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(4235), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4236), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(4239), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(4723), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(4819), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(4823), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(4824), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(4827), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(3684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 11, DateTimeKind.Local).AddTicks(1347), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 11, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 11, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(594), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(597), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(602), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(610), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(620), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(628), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(635), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(655), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(658), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 12, DateTimeKind.Local).AddTicks(7327), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 12, DateTimeKind.Unspecified).AddTicks(7377), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 12, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 12, DateTimeKind.Local).AddTicks(9385), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 12, DateTimeKind.Unspecified).AddTicks(9414), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 12, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(517), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(530), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(547), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(551), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(557), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(560), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(565), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(569), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(575), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(584), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 13, DateTimeKind.Unspecified).AddTicks(588), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 13, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(2291), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7389), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7393), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7423), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7305), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7426), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7442), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7492), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7498), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7503), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7508), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7327), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7512), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7519), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7332), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7336), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7364), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7369), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7374), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3773), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3776), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3736), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3740), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3743), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3756), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3761), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3764), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(3769), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(2792), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(2807), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(2809), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(2812), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(2813), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(2817), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(2821), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(8963), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(8971), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 2, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 10, DateTimeKind.Local).AddTicks(2597), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 10, DateTimeKind.Unspecified).AddTicks(2649), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 10, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 10, DateTimeKind.Local).AddTicks(3371), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 10, DateTimeKind.Unspecified).AddTicks(3380), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 10, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 44, 999, DateTimeKind.Local).AddTicks(4782), new DateTime(2026, 7, 31, 6, 6, 44, 999, DateTimeKind.Utc).AddTicks(914), new DateTime(2026, 1, 21, 6, 6, 44, 999, DateTimeKind.Utc).AddTicks(853), new DateTime(2026, 1, 31, 10, 36, 45, 0, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 0, DateTimeKind.Local).AddTicks(8860), new DateTime(2026, 8, 31, 6, 6, 45, 0, DateTimeKind.Utc).AddTicks(8809), new DateTime(2026, 1, 26, 6, 6, 45, 0, DateTimeKind.Utc).AddTicks(8808), new DateTime(2026, 1, 31, 10, 36, 45, 0, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(573), new DateTime(2026, 4, 30, 6, 6, 45, 1, DateTimeKind.Utc).AddTicks(552), new DateTime(2026, 1, 16, 6, 6, 45, 1, DateTimeKind.Utc).AddTicks(550), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(1347), new DateTime(2026, 1, 11, 6, 6, 45, 1, DateTimeKind.Utc).AddTicks(1341), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(6577), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(6917), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7280), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(7297), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7298), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(7301), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7302), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(7305), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7306), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7311), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(7314), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7315), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(7318), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7318), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(7321), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9416), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9427), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9677), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9680), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9681), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9684), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9685), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9688), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9644), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9648), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9649), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9652), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9653), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9656), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9657), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9660), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9661), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9664), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9665), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9668), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9668), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9671), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9672), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 1, DateTimeKind.Unspecified).AddTicks(9677), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 36, 45, 1, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(7008), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(6978), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(6993), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(6996), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(7000), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 45, 2, DateTimeKind.Unspecified).AddTicks(7003), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
