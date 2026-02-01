using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sfe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "896cb323-d784-4531-90a2-1da421676e95", "AQAAAAIAAYagAAAAEI5puNkwo3rFYjXvRzfKlGmr2w20aUFimXV/4AmUuWqoFDodtTjwwAjue4KGCNT5eg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6af2e7a0-c8c1-4d42-a5e0-60377daa5d53", "AQAAAAIAAYagAAAAEO5YOlnpLyyXUE5Pm4sYLZ8SzR5YpOL9EynF+MfNajOsUZAxyHtfw+fZQjKVAsCnuQ==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4010), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4443), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4460), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4463), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4464), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4468), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4472), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4474), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(9973), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(9979), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(185), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(190), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(191), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(194), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(3252), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(3259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(6866), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 280, DateTimeKind.Unspecified).AddTicks(6879), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1947), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1950), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1954), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1957), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1962), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1969), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1977), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1980), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1984), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1987), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1992), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 281, DateTimeKind.Local).AddTicks(9821), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 281, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 281, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(972), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(979), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1881), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1886), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1902), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1910), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1918), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1921), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1926), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1938), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 267, DateTimeKind.Unspecified).AddTicks(7141), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(350), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(353), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(371), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(374), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(378), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(381), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(312), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(387), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(391), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(394), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(402), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(405), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(408), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(417), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(420), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(327), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(334), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(342), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(346), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8853), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8861), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8828), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8832), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8850), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7688), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7886), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(7891), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7892), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(7895), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7896), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(4790), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(4814), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(1403), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 280, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(2033), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 280, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 268, DateTimeKind.Local).AddTicks(4926), new DateTime(2026, 8, 1, 9, 45, 25, 268, DateTimeKind.Utc).AddTicks(2327), new DateTime(2026, 1, 22, 9, 45, 25, 268, DateTimeKind.Utc).AddTicks(2288), new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(7288), new DateTime(2026, 9, 1, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(7267), new DateTime(2026, 1, 27, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(7266), new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(8744), new DateTime(2026, 5, 1, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(8735), new DateTime(2026, 1, 17, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(8734), new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(9633), new DateTime(2026, 1, 12, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(9626), new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(3288), new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(981), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(8838), new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(9983), new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(919), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(938), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(954), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(961), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(967), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(974), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(5839), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(6368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8165), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8213), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8216), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8221), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8222), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8225), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8226), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8230), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8231), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8235), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8236), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8239), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8240), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(910), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(918), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1284), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1302), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1305), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1306), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1309), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1246), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1254), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1255), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1258), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1259), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1262), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1263), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1266), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1267), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1271), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1275), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1276), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1280), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1283), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2218), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2534), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2495), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2505), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2508), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20301c6f-0dd3-4dbb-9b36-0d81d51c63fd", "AQAAAAIAAYagAAAAEOh+55cCCBSnlcVTaZHqj3WptQ/b5ql1q2CLjwuqagP61RB8vJvnjqI5c0KBU53+Zg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d48ceeb4-49fb-4b64-aa79-ca3ecdb0a2f5", "AQAAAAIAAYagAAAAEArnWdEgXrXcGFv7XRk3buKfbN0E1YS3IgchUwZxkrWLtQt/z2zspiCHA5165C32Hg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(1732), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(1742), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2178), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2182), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2184), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2186), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2188), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2191), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2192), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2198), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2199), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(848), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(854), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(1031), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(1035), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(1036), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(1040), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(495), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 252, DateTimeKind.Local).AddTicks(2343), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 252, DateTimeKind.Unspecified).AddTicks(2369), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 252, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9012), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9015), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9020), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9024), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9029), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9037), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9050), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9058), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9062), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9066), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(6450), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(6487), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(7632), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8895), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8909), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8954), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8966), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8973), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8977), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8983), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8986), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8992), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8995), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9003), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9006), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 238, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2074), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2078), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2081), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2084), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2088), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2118), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2125), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2039), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2132), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2135), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2139), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2142), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2156), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2165), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2049), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2053), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2057), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2060), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2064), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2071), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9968), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9971), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9940), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9943), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9947), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9950), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9953), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9956), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9961), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(8921), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(8930), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9089), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9092), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9093), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9097), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(5002), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(5009), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 251, DateTimeKind.Local).AddTicks(6380), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 251, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 251, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 251, DateTimeKind.Local).AddTicks(7073), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 251, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 251, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 239, DateTimeKind.Local).AddTicks(6926), new DateTime(2026, 8, 1, 6, 24, 46, 239, DateTimeKind.Utc).AddTicks(4294), new DateTime(2026, 1, 22, 6, 24, 46, 239, DateTimeKind.Utc).AddTicks(4249), new DateTime(2026, 2, 1, 10, 54, 46, 240, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(3993), new DateTime(2026, 9, 1, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(3944), new DateTime(2026, 1, 27, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(3941), new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(5634), new DateTime(2026, 5, 1, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(5623), new DateTime(2026, 1, 17, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(5622), new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(6636), new DateTime(2026, 1, 12, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(6616), new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(677), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7836), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(5806), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7012), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7788), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7800), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7811), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7818), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7823), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7830), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(2903), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3201), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3565), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3571), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3575), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3580), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3583), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3583), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3588), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3591), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3594), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5523), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5532), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5831), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5835), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5839), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5797), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5801), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5802), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5806), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5807), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5809), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5810), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5813), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5814), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5817), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5818), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5821), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5825), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(2882), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3199), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3175), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3186), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3195), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
