using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigrgf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91857dc4-2cab-4939-b5e2-10f00f730bb0", "AQAAAAIAAYagAAAAEIxElwjIznNUtmPZaG3mo81s9Zc9X/wBxZCeDmuz/jAhq57LMLAdKCCJuNFhAF8PyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5944d536-1a89-41d7-afbb-3f88da590b39", "AQAAAAIAAYagAAAAEI06ggjfoAjBuCP7gU6B0LlOiBdvhjqLvUf22T/z3zgIl8miCD4RNAgHIuI/isAJ1w==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8488), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8510), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8833), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8839), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8842), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8843), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8847), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8850), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8851), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8855), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(400), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(409), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(504), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(509), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(510), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 504, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 504, DateTimeKind.Unspecified).AddTicks(5518), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 504, DateTimeKind.Unspecified).AddTicks(5522), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 513, DateTimeKind.Local).AddTicks(1584), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 513, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 513, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6322), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6330), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6333), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6338), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6341), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6346), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6353), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6361), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6363), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6368), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(4254), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(5333), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6237), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6247), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6277), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6286), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6294), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6298), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6303), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6311), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5197), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5714), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5723), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5734), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5740), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5743), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5648), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5749), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5756), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5759), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5768), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5771), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5774), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5777), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5655), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5707), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8973), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9406), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9410), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9414), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9378), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9382), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9399), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9403), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8385), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8396), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8401), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8404), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8404), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8407), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(4640), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(4646), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 512, DateTimeKind.Local).AddTicks(6392), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 512, DateTimeKind.Unspecified).AddTicks(6414), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 512, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 512, DateTimeKind.Local).AddTicks(7027), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 512, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 512, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 502, DateTimeKind.Local).AddTicks(9695), new DateTime(2026, 7, 31, 5, 46, 29, 502, DateTimeKind.Utc).AddTicks(7697), new DateTime(2026, 1, 21, 5, 46, 29, 502, DateTimeKind.Utc).AddTicks(7657), new DateTime(2026, 1, 31, 10, 16, 29, 503, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(1914), new DateTime(2026, 8, 31, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(1887), new DateTime(2026, 1, 26, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(1886), new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(2972), new DateTime(2026, 4, 30, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(2956), new DateTime(2026, 1, 16, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(2955), new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(3452), new DateTime(2026, 1, 11, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(3446), new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1151), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1931), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1938), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1942), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1945), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1946), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1955), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1956), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1959), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1960), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1963), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1964), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1967), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4615), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4990), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4993), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4995), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4999), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(5000), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(5004), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4907), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4913), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4915), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4919), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4920), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4924), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4925), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4933), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4935), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4938), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4939), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4978), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4983), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4985), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2428), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2760), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2719), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2727), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2730), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2747), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2750), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70ba9a48-3193-4ab4-bc59-e7d68968a796", "AQAAAAIAAYagAAAAEMAx8pwooWaldmpfgVvuX61e3TOsAE7Pg/fEF1KGPhKzNZ9gSXLNQcKYe1WxQBwWMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5c25039-835a-4dd6-a7eb-afef8104adaa", "AQAAAAIAAYagAAAAEDLIiRYx3e4Jgq6NZFj/Xp4NPywksaS8TOQkZ9B0F3llBZiub6bVuI/EBLGFygVX0w==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(7760), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(7771), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8104), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8109), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8111), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8115), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8118), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8119), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8123), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8124), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8230), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8235), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(8240), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 335, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 335, DateTimeKind.Unspecified).AddTicks(7512), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 335, DateTimeKind.Unspecified).AddTicks(7516), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 345, DateTimeKind.Local).AddTicks(5025), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 345, DateTimeKind.Unspecified).AddTicks(5051), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 345, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4952), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4956), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4965), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4969), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4977), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4982), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4989), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4994), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5003), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(5006), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5013), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(5017), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5026), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(5032), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(1563), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(3375), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(3395), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4831), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4886), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4898), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4902), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4909), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4912), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4920), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4934), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4941), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4945), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8296), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8785), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8799), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8824), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8834), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8874), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8877), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8768), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8772), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6715), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7168), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7172), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7176), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7126), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7151), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6214), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6236), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6238), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6243), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6250), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6253), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 337, DateTimeKind.Local).AddTicks(2309), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(2317), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 337, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 344, DateTimeKind.Local).AddTicks(8834), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 344, DateTimeKind.Unspecified).AddTicks(8888), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 344, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 344, DateTimeKind.Local).AddTicks(9598), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 344, DateTimeKind.Unspecified).AddTicks(9606), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 344, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 334, DateTimeKind.Local).AddTicks(2853), new DateTime(2026, 7, 31, 5, 34, 57, 334, DateTimeKind.Utc).AddTicks(876), new DateTime(2026, 1, 21, 5, 34, 57, 334, DateTimeKind.Utc).AddTicks(835), new DateTime(2026, 1, 31, 10, 4, 57, 334, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(3969), new DateTime(2026, 8, 31, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(3943), new DateTime(2026, 1, 26, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(3942), new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(4976), new DateTime(2026, 4, 30, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(4966), new DateTime(2026, 1, 16, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(4965), new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(5461), new DateTime(2026, 1, 11, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(5455), new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(9796), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(113), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(568), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(590), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(591), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(595), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(596), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(599), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(600), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(603), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(604), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(608), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(616), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2604), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2816), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2820), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2820), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2823), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2824), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2780), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2786), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2789), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2790), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2793), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2794), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2798), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2802), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2808), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2812), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2812), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(496), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(465), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(473), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(483), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(489), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
