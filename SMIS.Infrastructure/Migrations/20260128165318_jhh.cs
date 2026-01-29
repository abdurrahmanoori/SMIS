using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class jhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "UnitOfMeasure",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "UnitOfMeasure",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "UnitOfMeasure",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "Translations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Translations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Translations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "TranslationKeys",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "TranslationKeys",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "TranslationKeys",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "Shop",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Shop",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Shop",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "ProvinceTranslations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "ProvinceTranslations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "ProvinceTranslations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "Provinces",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Provinces",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Provinces",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "ProductUnit",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "ProductUnit",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "ProductUnit",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "Product",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "Languages",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Languages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Languages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "Districts",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Districts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Districts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "Category",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Category",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Category",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "AppLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "AppLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "AppLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a63d85e2-30fe-434b-af9b-a34db73ec3d9", "AQAAAAIAAYagAAAAEAmJZ8rKrg6lWtESJiPzK3Q7ZG1GuSHMQ+x09iUOUOP3wYrGI24um2ru8J8tlP4+pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24a5fa9f-8dfb-4358-8904-46a06a896d4c", "AQAAAAIAAYagAAAAEG5UJ0rjwCUHv0sR/xFQaZPf1aBacjp8Ds40jeHuOE77Epf8T43UKmot5GyoXtYXRg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7001), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(7015), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7003), 0 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7982), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(7993), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7984), 0 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7996), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(7998), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7996), 0 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(6858), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(6861), 0 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(7167), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(7169), 0 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(7177), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(7179), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(7178), 0 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 857, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 857, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 857, DateTimeKind.Unspecified).AddTicks(4320), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(2208), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(2211), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(4403), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(4413), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(4405), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(4417), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(4420), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(4417), 0 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 856, DateTimeKind.Unspecified).AddTicks(7924), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 856, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 856, DateTimeKind.Unspecified).AddTicks(9262), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(3052), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4675), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4645), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4650), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4653), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4656), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4659), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4662), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4670), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4673), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1644), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1655), 0 });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1709), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1709), 0 });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1713), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1713), 0 });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1716), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1717), 0 });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 863, DateTimeKind.Local).AddTicks(4857), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(4873), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 863, DateTimeKind.Local).AddTicks(4860), 0 });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 863, DateTimeKind.Local).AddTicks(7785), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 863, DateTimeKind.Local).AddTicks(7788), 0 });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 864, DateTimeKind.Local).AddTicks(3459), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 864, DateTimeKind.Unspecified).AddTicks(3474), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 864, DateTimeKind.Local).AddTicks(3462), 0 });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 857, DateTimeKind.Local).AddTicks(9066), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(5428), 0 });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8467), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8478), 0 });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8498), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8498), 0 });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8501), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8507), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8505), 0 });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8508), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8511), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8509), 0 });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8513), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8513), 0 });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8554), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8556), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8554), 0 });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8558), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8560), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8558), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8145), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8218), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8156), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8945), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8948), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8946), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8949), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8951), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8949), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8952), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8954), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8953), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8901), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8911), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8904), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8914), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8916), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8914), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8918), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8920), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8918), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8921), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8922), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8925), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8927), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8925), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8928), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8929), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8934), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8936), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8934), 0 });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "State", "UpdatedDate", "Version" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8937), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8944), new TimeSpan(0, 0, 0, 0, 0)), 0, new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8938), 0 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(603), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(606), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(609), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "LastModifiedUtc", "State", "Version" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(611), new TimeSpan(0, 0, 0, 0, 0)), 4, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "State",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "State",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "ProvinceTranslations");

            migrationBuilder.DropColumn(
                name: "State",
                table: "ProvinceTranslations");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "ProvinceTranslations");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "State",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "AppLogs");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AppLogs");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "AppLogs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "11ccf456-d270-472b-89e0-38d26c0305d7", "AQAAAAIAAYagAAAAEFvqRn2KCmjYvMDdZ1ubID5Zgb8/eGQmUVxI7fVF51FFwhE3yQk726Ehqb6QuMjlAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68c05f9c-6cb6-4948-9732-91c6032fc72d", "AQAAAAIAAYagAAAAEAb1FV00CELiQcmlhCs4qFO7RQyLaYehn8T0Rf4elXtzAUoHRDRY+eVFoQDDGoup2A==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(2583), new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(4916), new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(4931), new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7019), new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7547), new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7553), new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 727, DateTimeKind.Local).AddTicks(4254), new DateTime(2026, 1, 22, 20, 50, 52, 727, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 728, DateTimeKind.Local).AddTicks(5873), new DateTime(2026, 1, 22, 20, 50, 52, 728, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 728, DateTimeKind.Local).AddTicks(5910), new DateTime(2026, 1, 22, 20, 50, 52, 728, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7931), new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7963), new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7970), new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7976), new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 725, DateTimeKind.Local).AddTicks(6626), new DateTime(2026, 1, 22, 20, 50, 52, 725, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 726, DateTimeKind.Local).AddTicks(185), new DateTime(2026, 1, 22, 20, 50, 52, 726, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 726, DateTimeKind.Local).AddTicks(205), new DateTime(2026, 1, 22, 20, 50, 52, 726, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 716, DateTimeKind.Local).AddTicks(2632), new DateTime(2026, 1, 22, 20, 50, 52, 718, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2208), new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2236), new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2241), new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2244), new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2246), new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2249), new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2251), new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 720, DateTimeKind.Local).AddTicks(1881), new DateTime(2026, 1, 22, 20, 50, 52, 720, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1823), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1825), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1828), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1763), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1789), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1792), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1795), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1797), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1799), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1818), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1820), new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1821) });
        }
    }
}
