using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigrgfkjuytsdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "ProductUnit",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitName",
                table: "ProductUnit",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

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
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(2291), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7389), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7393), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "Dozen" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "Dozen" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 0, 0, 0, 0)), "Pencil Set", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7423), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7305), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7426), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7442), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7492), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7498), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7503), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7508), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7327), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7512), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7519), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7332), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7336), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7364), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "Box" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7369), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "Carton" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "LastModifiedUtc", "ProductName", "UnitName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 31, 6, 6, 44, 998, DateTimeKind.Unspecified).AddTicks(7374), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "Box" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "UnitName",
                table: "ProductUnit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "deea7d91-1f7f-489d-8ef1-41049c38cff1", "AQAAAAIAAYagAAAAEArqj+Bhv9A3jcUGWhJibfnJ+vFMmmP4QGgakz29t2ryGNQk5b5MUcL7d9ORnxWl5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a72557c5-f0fd-4727-bd73-f17e52b1ffa3", "AQAAAAIAAYagAAAAEP3/y/NyZ+Z9g6VEBFX3d1eCZ1KVoPkzf/HSv0WeehM0jDRed00Jedh5QoOtzhBxWQ==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7154), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(7162), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7491), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(7495), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7496), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(7499), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7501), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7508), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(7512), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7513), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(7516), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(3327), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(3429), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(3433), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(3434), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(3437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(1466), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(1796), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(1800), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 562, DateTimeKind.Local).AddTicks(8079), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 562, DateTimeKind.Unspecified).AddTicks(8096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 562, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4565), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4568), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4574), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4578), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4583), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4589), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4594), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4597), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4602), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4605), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4609), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4613), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4618), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4621), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(2221), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(3605), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(3615), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4489), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4500), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4516), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4519), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4525), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4528), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4533), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4536), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4542), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4545), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4555), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 564, DateTimeKind.Unspecified).AddTicks(4559), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 564, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(7048), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8678), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8683), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8691), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8694), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8697), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8578), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8707), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8718), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8723), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8726), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8729), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8733), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8736), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8739), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8602), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8747), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8606), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8647), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8662), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 551, DateTimeKind.Unspecified).AddTicks(8669), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(1993), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2441), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2448), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2415), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2419), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2422), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2425), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2429), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(1511), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(1526), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(1528), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(1531), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(1532), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(1536), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(1539), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(7533), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 555, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 562, DateTimeKind.Local).AddTicks(2814), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 562, DateTimeKind.Unspecified).AddTicks(2848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 562, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 562, DateTimeKind.Local).AddTicks(3455), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 562, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 562, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 552, DateTimeKind.Local).AddTicks(4313), new DateTime(2026, 7, 31, 6, 0, 18, 552, DateTimeKind.Utc).AddTicks(1863), new DateTime(2026, 1, 21, 6, 0, 18, 552, DateTimeKind.Utc).AddTicks(1801), new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(7064), new DateTime(2026, 8, 31, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(7042), new DateTime(2026, 1, 26, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(7041), new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(8688), new DateTime(2026, 4, 30, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(8674), new DateTime(2026, 1, 16, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(8672), new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(9483), new DateTime(2026, 1, 11, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(9477), new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(4476), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(4842), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5207), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(5212), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5213), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(5216), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5217), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(5220), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5221), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(5224), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5225), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(5228), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5229), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(5232), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5233), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(5236), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7205), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7425), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7428), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7429), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7443), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7447), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7390), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7395), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7400), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7404), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7407), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7408), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7412), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7415), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7416), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7420), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 554, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 30, 18, 554, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5370), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5660), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5628), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5631), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5635), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5641), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 0, 18, 555, DateTimeKind.Unspecified).AddTicks(5644), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
