using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStockTranactionsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f8eb21a-72a8-4d9e-8d80-f18b56710cfc", "AQAAAAIAAYagAAAAEMijzHQIPNsdxDgrOuumx08vGrx23/EoNZ66G9t7M3goGN8OA5sqC8RzwL2pR9AAYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6249b1a-8894-42f9-bb8b-8d3d16255c18", "AQAAAAIAAYagAAAAEONjS/PDVkucLAWihhmzAmkjNPrmjrQfPo8mkhnOANFB5l1X70hKtg6P51hEeE4MHA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1341), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1348), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1699), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1706), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1708), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1712), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1716), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1719), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1720), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1723), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6817), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6919), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(6926), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6927), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(5724), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 736, DateTimeKind.Local).AddTicks(4454), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 736, DateTimeKind.Unspecified).AddTicks(4466), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 736, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9210), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9217), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9223), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9226), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9231), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9234), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9239), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9247), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9255), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9258), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9263), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9267), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(7209), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(7230), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(8321), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9139), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9145), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9159), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9162), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9168), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9172), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9177), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9180), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9186), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9201), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9205), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 721, DateTimeKind.Unspecified).AddTicks(8575), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9336), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9339), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9346), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9352), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9355), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9359), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9385), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9389), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9293), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9396), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9399), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9404), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9407), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9414), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9417), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9421), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9427), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9302), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9432), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9435), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9306), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9309), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9320), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9329), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9332), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5323), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5774), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5777), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5754), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5760), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5764), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5767), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5771), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4829), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(4839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4841), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(4848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4849), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(4852), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4852), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(4855), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 729, DateTimeKind.Local).AddTicks(893), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 729, DateTimeKind.Unspecified).AddTicks(901), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 729, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 735, DateTimeKind.Local).AddTicks(8802), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 735, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 735, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 735, DateTimeKind.Local).AddTicks(9485), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 735, DateTimeKind.Unspecified).AddTicks(9493), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 735, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 724, DateTimeKind.Local).AddTicks(8139), new DateTime(2026, 7, 31, 11, 22, 8, 723, DateTimeKind.Utc).AddTicks(1532), new DateTime(2026, 1, 21, 11, 22, 8, 723, DateTimeKind.Utc).AddTicks(1485), new DateTime(2026, 1, 31, 15, 52, 8, 725, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(493), new DateTime(2026, 8, 31, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(468), new DateTime(2026, 1, 26, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(467), new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(2036), new DateTime(2026, 4, 30, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(2026), new DateTime(2026, 1, 16, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(2025), new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(2862), new DateTime(2026, 1, 11, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(2855), new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(6784), new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3684), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(1527), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(2558), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3636), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3652), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3659), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3665), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3670), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3677), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8179), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8847), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8853), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8856), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8857), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8861), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8864), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8865), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8871), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8871), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8874), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8875), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1050), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1289), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1293), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1296), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1297), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1300), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1229), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1233), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1234), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1237), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1238), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1242), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1245), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1246), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1276), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1277), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1281), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1285), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(8833), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9105), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9075), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9079), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9082), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9086), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9089), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9095), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9098), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9101), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f01bdce5-86e3-4f9e-8305-ce890844dea5", "AQAAAAIAAYagAAAAEP6twNDcF+1JQ2XyZd0+STAJN7lWtxaj5pSOWtCdw3XPE894JeMTwJnxJX8kUfQfPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "649f04eb-40c3-4d39-9c6a-04253a83d1f2", "AQAAAAIAAYagAAAAEEbgKjZ8ShJIZATcqtEmI8WpRML2vxzZu3Px3zFxcX3J9SzRAOJz1kWEyB1JgF/tZw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(448), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(456), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(797), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(802), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(805), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(806), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(812), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(813), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(817), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1787), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(1793), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1876), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1881), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(693), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(1009), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(1016), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 915, DateTimeKind.Local).AddTicks(3695), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 915, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 915, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8365), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8374), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8377), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8382), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8387), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8391), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8399), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8402), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8406), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8414), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(6450), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(7517), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(7525), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8300), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8309), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8323), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8327), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8332), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8336), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8341), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8344), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8349), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8352), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8357), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 902, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5268), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5272), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5276), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5279), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5286), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5217), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5298), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5302), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5305), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5312), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5315), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5327), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5331), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5233), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5334), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5252), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5256), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(894), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(897), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(874), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(883), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(886), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(34), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(42), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(44), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(48), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(51), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(52), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(58), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(5617), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(5623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 914, DateTimeKind.Local).AddTicks(8427), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 914, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 914, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 914, DateTimeKind.Local).AddTicks(9051), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 914, DateTimeKind.Unspecified).AddTicks(9059), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 914, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 904, DateTimeKind.Local).AddTicks(671), new DateTime(2026, 7, 31, 11, 21, 9, 903, DateTimeKind.Utc).AddTicks(7588), new DateTime(2026, 1, 21, 11, 21, 9, 903, DateTimeKind.Utc).AddTicks(7540), new DateTime(2026, 1, 31, 15, 51, 9, 904, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(2444), new DateTime(2026, 8, 31, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(2426), new DateTime(2026, 1, 26, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(2424), new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(4092), new DateTime(2026, 4, 30, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(4080), new DateTime(2026, 1, 16, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(4080), new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(4952), new DateTime(2026, 1, 11, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(4944), new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(9394), new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8587), new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(6138), new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(7267), new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8527), new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8553), new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8562), new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8568), new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8574), new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8580), new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(3700), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4046), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4428), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4434), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4438), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4441), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4442), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4446), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4449), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4450), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4454), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6564), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6816), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6820), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6823), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6824), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6827), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6769), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6773), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6775), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6778), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6779), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6782), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6783), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6797), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6800), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6801), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6804), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6805), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6812), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6815), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3885), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3845), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3862), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3865), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3878), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3882), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
