using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addstockBatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockBatch",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BatchNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", precision: 18, scale: 4, nullable: false),
                    UnitId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PurchasePrice = table.Column<long>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<int>(type: "INTEGER", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockBatch", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c9337a5-5306-49eb-9ca5-e0f410fb64a7", "AQAAAAIAAYagAAAAEAnsv1nNzHnRXeS5sePKdSIQ0m6v1VLDEfeAC9/kG8NMPmHXKqIFXbyxj1qtESU+2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ae7756a-3951-4801-85ad-d40b3bd387e5", "AQAAAAIAAYagAAAAEEnv5Vszp0k5E7bTiMHyTCA+cmd9iRCz6Wd5tPmv6EEi6bL/5+YKEe1TB2PhqGbtgg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(2191), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(2211), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3351), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3365), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3369), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3373), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3386), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3389), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3390), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(5972), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(5986), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(6311), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(6327), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(6329), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(6332), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 244, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(285), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(289), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 265, DateTimeKind.Local).AddTicks(6357), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 265, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 265, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6088), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6099), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6108), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6121), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6124), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6131), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6133), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6141), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6144), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6151), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6153), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(3661), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(3721), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(4919), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(4937), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(5885), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6011), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6024), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6034), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6036), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6044), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6046), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6056), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6059), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8744), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8747), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8755), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8760), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8811), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8818), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8823), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8685), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8705), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8708), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8711), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(2184), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3694), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3697), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3661), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3666), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3680), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3686), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(912), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(927), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(930), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(959), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(960), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(964), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(966), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 248, DateTimeKind.Local).AddTicks(8298), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(8343), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 248, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 264, DateTimeKind.Local).AddTicks(3697), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 264, DateTimeKind.Unspecified).AddTicks(3756), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 264, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 264, DateTimeKind.Local).AddTicks(4913), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 264, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 264, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 1, 30, 20, 39, 15, 241, DateTimeKind.Local).AddTicks(6075), 0, new DateTime(2026, 7, 30, 16, 9, 15, 241, DateTimeKind.Utc).AddTicks(2173), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", 40000L, 100m, new DateTime(2026, 1, 20, 16, 9, 15, 241, DateTimeKind.Utc).AddTicks(2115), "Active", "1", null, new DateTime(2026, 1, 30, 20, 39, 15, 243, DateTimeKind.Local).AddTicks(1150), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(2344), 0, new DateTime(2026, 8, 30, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(2297), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", 42000L, 80m, new DateTime(2026, 1, 25, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(2293), "Active", "1", null, new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(2348), 0 },
                    { "3", "BS-101", null, new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(3829), 0, new DateTime(2026, 4, 30, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(3793), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", 25000L, 50m, new DateTime(2026, 1, 15, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(3791), "Active", "2", null, new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(3832), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(4680), 0, null, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", 120000L, 200m, new DateTime(2026, 1, 10, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(4667), "Active", "3", null, new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(4682), 0 }
                });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(5807), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(6698), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7967), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(7980), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7983), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(7985), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7987), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(7989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7990), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(7993), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7994), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(8007), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(8009), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(8011), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(8013), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(8015), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(2954), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(2970), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3677), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3680), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3684), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3633), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3643), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3646), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3649), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3650), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3652), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3653), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3656), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3657), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3666), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3670), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3672), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3673), new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2194), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2165), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2172), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2175), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2178), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2186), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2188), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2191), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_BatchNumber",
                table: "StockBatch",
                column: "BatchNumber");

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_ExpirationDate",
                table: "StockBatch",
                column: "ExpirationDate");

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_ProductId",
                table: "StockBatch",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_Status",
                table: "StockBatch",
                column: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockBatch");

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
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(6627), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 0, 0, 0, 0)));

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
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(2502), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3757), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3761), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3793), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3796), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3807), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3701), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3810), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3812), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3814), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3823), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3826), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3828), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3833), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3706), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3835), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3837), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3709), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 498, DateTimeKind.Unspecified).AddTicks(3754), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4637), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4813), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4578), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4585), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4592), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4624), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 502, DateTimeKind.Unspecified).AddTicks(4632), new TimeSpan(0, 0, 0, 0, 0)));

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
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(7589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8660), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8668), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8679), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 30, 14, 6, 55, 503, DateTimeKind.Unspecified).AddTicks(8682), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
