using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class jhhk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxNumber",
                table: "Shop",
                type: "TEXT",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Shop",
                type: "TEXT",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Shop",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Shop",
                type: "TEXT",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0a55957-6b8e-48e3-a77b-5c3b2923589b", "AQAAAAIAAYagAAAAEGQO+W489EBVXpjyYT/WUWDT/KwUOX8k6gmJ+Sn6vmBHTG28Xl89uHHQlr8Oy7NPIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7392b5e7-a8ab-4a2c-aece-7525326a1ff9", "AQAAAAIAAYagAAAAEFsLYGt6ppZqYnrFxybZKAMvh/9ZQrOu079x2HZ1IyhEcq9qD3j31fn3iFc0NLtp0Q==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(3405), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(3420), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(4269), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(4279), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(4281), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(4284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(6759), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(7070), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(7079), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(7081), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 632, DateTimeKind.Unspecified).AddTicks(21), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 632, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 632, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(7950), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 651, DateTimeKind.Unspecified).AddTicks(7968), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(420), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(436), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(439), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 631, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 631, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 631, DateTimeKind.Unspecified).AddTicks(7220), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4544), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4547), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4502), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4509), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4512), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4523), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4526), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4529), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2042), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(2058), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2061), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(2064), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2065), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(2073), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2074), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(2077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 636, DateTimeKind.Local).AddTicks(4533), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 636, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(2043), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 651, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(3348), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 651, DateTimeKind.Unspecified).AddTicks(3377), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 632, DateTimeKind.Local).AddTicks(5788), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 633, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 633, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(27), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(42), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(45), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(71), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(74), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(75), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(77), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(78), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(89), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(91), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(93), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(4844), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5512), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5514), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5515), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5517), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5519), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5521), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5467), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5478), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5481), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5482), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5484), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5486), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5488), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5490), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5493), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5494), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5504), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5505), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5507), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5509), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5511), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(9941), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(540), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(544), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(546), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(549), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxNumber",
                table: "Shop",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Shop",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Shop",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Shop",
                type: "TEXT",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 500,
                oldNullable: true);

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
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7001), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(7015), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7982), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(7993), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7996), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(7998), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(6858), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(7167), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(7177), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(7179), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 857, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 857, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 857, DateTimeKind.Unspecified).AddTicks(4320), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(2208), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(4403), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(4413), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(4417), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 865, DateTimeKind.Unspecified).AddTicks(4420), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 865, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 856, DateTimeKind.Unspecified).AddTicks(7924), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 856, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 856, DateTimeKind.Unspecified).AddTicks(9262), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(3052), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4675), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4645), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4650), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4653), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4656), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4659), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4662), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4670), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(4673), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1644), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1709), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1713), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1716), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 862, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 862, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 863, DateTimeKind.Local).AddTicks(4857), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(4873), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 863, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 863, DateTimeKind.Local).AddTicks(7785), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 863, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 864, DateTimeKind.Local).AddTicks(3459), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 864, DateTimeKind.Unspecified).AddTicks(3474), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 864, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 857, DateTimeKind.Local).AddTicks(9066), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8467), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8498), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8501), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8507), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8508), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8511), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8513), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8554), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8556), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8558), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 859, DateTimeKind.Unspecified).AddTicks(8560), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 859, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8145), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8218), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8945), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8948), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8949), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8951), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8952), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8954), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8901), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8911), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8914), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8916), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8918), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8920), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8921), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8925), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8927), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8928), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8934), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8936), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8937), new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 860, DateTimeKind.Unspecified).AddTicks(8944), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 23, 16, 860, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(603), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(606), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(609), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 16, 53, 16, 863, DateTimeKind.Unspecified).AddTicks(611), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
