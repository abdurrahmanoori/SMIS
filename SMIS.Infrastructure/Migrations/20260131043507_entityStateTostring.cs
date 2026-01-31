using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class entityStateTostring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "UnitOfMeasure",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "Translations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "TranslationKeys",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "StockBatch",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "Shop",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "ProvinceTranslations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "Provinces",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "ProductUnit",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "Product",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "Languages",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "Districts",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "Category",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "AppLogs",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cf2d74f-8271-4d0f-859a-cc9180b3322d", "AQAAAAIAAYagAAAAEBL4XuIE9KcJWeku7ytZyVre9f0Lv3rGZbdV+exfSkiNpoNxbbIkm7oIxuIltKm3bA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63a5b5ae-597b-408c-9c28-4a8493260436", "AQAAAAIAAYagAAAAEKdx6bv7MZjze/s9ayLZ1UCH535pFKdmvxIP6FGYT5aJfqyy/7gnavi2+os+WLTDIg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2462), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2890), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(2894), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2896), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2901), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(2904), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2905), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(2912), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2913), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(2916), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(5095), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(5099), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(5180), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(5184), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(5185), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(5188), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(4586), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(4838), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 453, DateTimeKind.Local).AddTicks(6900), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 453, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 453, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(127), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(130), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(133), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(135), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(138), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(141), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(143), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(148), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(150), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(153), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(155), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(158), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(160), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(170), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 454, DateTimeKind.Local).AddTicks(9148), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 454, DateTimeKind.Unspecified).AddTicks(9167), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 454, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 454, DateTimeKind.Local).AddTicks(9713), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 454, DateTimeKind.Unspecified).AddTicks(9719), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 454, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(80), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(85), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(92), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(102), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(105), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(108), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(111), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(117), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(122), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 455, DateTimeKind.Unspecified).AddTicks(125), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 455, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4336), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4827), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4850), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4853), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4857), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4860), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4863), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4866), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4793), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4873), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4876), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4882), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4885), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4891), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4895), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4898), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4796), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4901), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4904), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4806), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4810), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4814), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 442, DateTimeKind.Unspecified).AddTicks(4824), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4274), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4277), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4280), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4236), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4240), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4247), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4250), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4253), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4257), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(3379), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(3394), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(3398), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(3398), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(3402), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(3403), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(3405), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(8956), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(8963), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 453, DateTimeKind.Local).AddTicks(952), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 453, DateTimeKind.Unspecified).AddTicks(1001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 453, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 453, DateTimeKind.Local).AddTicks(1734), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 453, DateTimeKind.Unspecified).AddTicks(1743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 453, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 442, DateTimeKind.Local).AddTicks(8695), "Unchanged", new DateTime(2026, 7, 31, 4, 35, 7, 442, DateTimeKind.Utc).AddTicks(6809), new DateTime(2026, 1, 21, 4, 35, 7, 442, DateTimeKind.Utc).AddTicks(6764), new DateTime(2026, 1, 31, 9, 5, 7, 443, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(1189), "Unchanged", new DateTime(2026, 8, 31, 4, 35, 7, 444, DateTimeKind.Utc).AddTicks(1158), new DateTime(2026, 1, 26, 4, 35, 7, 444, DateTimeKind.Utc).AddTicks(1157), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(2301), "Unchanged", new DateTime(2026, 4, 30, 4, 35, 7, 444, DateTimeKind.Utc).AddTicks(2288), new DateTime(2026, 1, 16, 4, 35, 7, 444, DateTimeKind.Utc).AddTicks(2286), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(2798), "Unchanged", new DateTime(2026, 1, 11, 4, 35, 7, 444, DateTimeKind.Utc).AddTicks(2792), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7324), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7972), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(7977), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7978), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7995), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(7998), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7999), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(8002), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(8003), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(8006), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(8009), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(8010), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 444, DateTimeKind.Unspecified).AddTicks(8013), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 444, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(42), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(52), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(260), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(263), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(264), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(267), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(268), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(228), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(233), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(236), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(237), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(240), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(240), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(244), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(247), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(248), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(251), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(252), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(254), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(255), "Unchanged", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 9, 5, 7, 445, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(6882), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(7180), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(7152), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(7160), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(7163), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(7166), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(7169), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(7172), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 4, 35, 7, 445, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "UnitOfMeasure",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "Translations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "TranslationKeys",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "StockBatch",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "Shop",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "ProvinceTranslations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "Provinces",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "ProductUnit",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "Languages",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "Districts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "Category",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "AppLogs",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

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
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(2191), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(2211), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3351), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3365), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3369), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3373), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3386), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3389), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3390), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 270, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 270, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(5972), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(5986), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(6311), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(6327), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(6329), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(6332), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 244, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(285), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(289), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 265, DateTimeKind.Local).AddTicks(6357), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 265, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 265, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6088), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6099), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6108), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6121), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6124), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6131), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6133), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6141), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6144), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6151), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6153), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(3661), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(3721), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(4919), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(4937), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(5885), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6011), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6024), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6034), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6036), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6044), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6046), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6056), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 269, DateTimeKind.Unspecified).AddTicks(6059), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 269, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8742), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8744), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8755), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8760), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8811), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8818), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8823), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8685), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8688), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8705), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8708), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 240, DateTimeKind.Unspecified).AddTicks(8711), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(2184), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3694), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3697), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3661), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3666), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3672), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3686), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(912), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(927), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(930), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(959), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(960), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(964), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 247, DateTimeKind.Unspecified).AddTicks(966), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 247, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 248, DateTimeKind.Local).AddTicks(8298), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(8343), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 248, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 264, DateTimeKind.Local).AddTicks(3697), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 264, DateTimeKind.Unspecified).AddTicks(3756), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 264, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 264, DateTimeKind.Local).AddTicks(4913), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 264, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 264, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 241, DateTimeKind.Local).AddTicks(6075), 0, new DateTime(2026, 7, 30, 16, 9, 15, 241, DateTimeKind.Utc).AddTicks(2173), new DateTime(2026, 1, 20, 16, 9, 15, 241, DateTimeKind.Utc).AddTicks(2115), new DateTime(2026, 1, 30, 20, 39, 15, 243, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(2344), 0, new DateTime(2026, 8, 30, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(2297), new DateTime(2026, 1, 25, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(2293), new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(3829), 0, new DateTime(2026, 4, 30, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(3793), new DateTime(2026, 1, 15, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(3791), new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(4680), 0, new DateTime(2026, 1, 10, 16, 9, 15, 244, DateTimeKind.Utc).AddTicks(4667), new DateTime(2026, 1, 30, 20, 39, 15, 244, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(5807), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(6698), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7967), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(7980), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7983), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(7985), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7987), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(7989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7990), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(7993), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7994), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(8007), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(8009), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(8011), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(8013), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 245, DateTimeKind.Unspecified).AddTicks(8015), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 245, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(2954), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(2970), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3677), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3680), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3684), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3633), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3643), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3646), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3649), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3650), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3652), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3653), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3656), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3657), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3666), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3670), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3672), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3673), 0, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 246, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 20, 39, 15, 246, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2165), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2172), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2175), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2178), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2186), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2188), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2026, 1, 30, 16, 9, 15, 248, DateTimeKind.Unspecified).AddTicks(2191), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
