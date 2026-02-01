using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdffgdfdfg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopId",
                table: "UnitOfMeasure",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d406284-97be-45a0-8828-50550bc1ea1b", "AQAAAAIAAYagAAAAENZ0IF7J9e3fgAkBFd8ch0O24BAEHkB09DLrgLdAZDmoHi0iAPqOL7h2sLmCWNLqkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8671540-3b2b-4214-b98b-6f29ef5faffc", "AQAAAAIAAYagAAAAENNosjGgQJ24jZOMg9UZngQ1STv9vodjOTMsUKKapGYSoP674WIVt0352gTxZo2e5g==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 491, DateTimeKind.Local).AddTicks(5008), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 57, 48, 491, DateTimeKind.Unspecified).AddTicks(5060), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 491, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9449), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Unspecified).AddTicks(9458), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9487), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Unspecified).AddTicks(9488), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9491), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Unspecified).AddTicks(9492), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9494), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Unspecified).AddTicks(9495), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9497), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Unspecified).AddTicks(9498), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 492, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(6061), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(6071), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(6359), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(6365), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(6385), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 473, DateTimeKind.Unspecified).AddTicks(4246), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 473, DateTimeKind.Unspecified).AddTicks(4747), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 473, DateTimeKind.Unspecified).AddTicks(4753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 488, DateTimeKind.Local).AddTicks(17), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 488, DateTimeKind.Unspecified).AddTicks(50), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 488, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9469), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9476), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9488), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9494), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9529), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9535), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9545), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9551), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9561), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9568), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9577), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9582), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9592), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9598), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(5369), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(5443), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(7704), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(7721), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9310), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9322), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9359), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9369), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9379), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9385), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9395), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9400), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9414), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9421), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9432), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 490, DateTimeKind.Unspecified).AddTicks(9455), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 490, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 465, DateTimeKind.Unspecified).AddTicks(5802), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3542), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3550), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3560), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3568), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3575), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3582), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3596), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3635), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3642), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3649), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3663), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3670), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3681), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3728), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3482), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3498), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3505), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3520), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 466, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(3339), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4245), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4251), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4257), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4262), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4268), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(4282), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(9985), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(448), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(2027), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(2057), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(2060), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(2066), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(2067), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 475, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 475, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 476, DateTimeKind.Local).AddTicks(5469), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(5496), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 476, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 487, DateTimeKind.Local).AddTicks(455), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 487, DateTimeKind.Unspecified).AddTicks(525), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 487, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 487, DateTimeKind.Local).AddTicks(1599), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 487, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 487, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 467, DateTimeKind.Local).AddTicks(4470), new DateTime(2026, 8, 1, 12, 27, 48, 466, DateTimeKind.Utc).AddTicks(8567), new DateTime(2026, 1, 22, 12, 27, 48, 466, DateTimeKind.Utc).AddTicks(8484), new DateTime(2026, 2, 1, 16, 57, 48, 468, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 470, DateTimeKind.Local).AddTicks(4560), new DateTime(2026, 9, 1, 12, 27, 48, 470, DateTimeKind.Utc).AddTicks(4490), new DateTime(2026, 1, 27, 12, 27, 48, 470, DateTimeKind.Utc).AddTicks(4484), new DateTime(2026, 2, 1, 16, 57, 48, 470, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 470, DateTimeKind.Local).AddTicks(7083), new DateTime(2026, 5, 1, 12, 27, 48, 470, DateTimeKind.Utc).AddTicks(7053), new DateTime(2026, 1, 17, 12, 27, 48, 470, DateTimeKind.Utc).AddTicks(7050), new DateTime(2026, 2, 1, 16, 57, 48, 470, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 470, DateTimeKind.Local).AddTicks(8525), new DateTime(2026, 1, 12, 12, 27, 48, 470, DateTimeKind.Utc).AddTicks(8512), new DateTime(2026, 2, 1, 16, 57, 48, 470, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 471, DateTimeKind.Local).AddTicks(6105), new DateTime(2026, 2, 1, 16, 57, 48, 471, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9877), new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(6312), new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(8468), new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9793), new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9814), new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9825), new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9835), new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9847), new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9867), new DateTime(2026, 2, 1, 16, 57, 48, 472, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 473, DateTimeKind.Local).AddTicks(9241), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 473, DateTimeKind.Unspecified).AddTicks(9753), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 473, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(324), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(334), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(338), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(340), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(357), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(359), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(364), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(365), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(370), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(371), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(376), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(377), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(382), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(3940), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(3991), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4489), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4494), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4495), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4500), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4501), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4508), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4430), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4439), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4445), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4460), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4464), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4466), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4472), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4476), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4477), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4482), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4483), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 474, DateTimeKind.Unspecified).AddTicks(4488), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 57, 48, 474, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(333), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(1029), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(981), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(988), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(994), new TimeSpan(0, 0, 0, 0, 0)), "2" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(999), new TimeSpan(0, 0, 0, 0, 0)), "2" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(1004), new TimeSpan(0, 0, 0, 0, 0)), "2" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(1009), new TimeSpan(0, 0, 0, 0, 0)), "3" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, 0, 0, 0, 0)), "3" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 1, 12, 27, 48, 476, DateTimeKind.Unspecified).AddTicks(1023), new TimeSpan(0, 0, 0, 0, 0)), "3" });

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfMeasure_ShopId",
                table: "UnitOfMeasure",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_UnitOfMeasure_Shop_ShopId",
                table: "UnitOfMeasure",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnitOfMeasure_Shop_ShopId",
                table: "UnitOfMeasure");

            migrationBuilder.DropIndex(
                name: "IX_UnitOfMeasure_ShopId",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "UnitOfMeasure");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "477a2c98-c855-4cc8-97c9-6bf51bc7b9d5", "AQAAAAIAAYagAAAAEF+IrX47jUJacRP3vIglvr/UKucYTscyt+tnL6duHS2GuZX5uvsv1JxUkoUoSMqjzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59c28f5d-2f18-4ec2-a540-8ac9cf4919dc", "AQAAAAIAAYagAAAAEI7+TGJlghb2Nr0gh6W98IIqZCPsGvO9vtiBBiQ58aSUfpxcbJ9G0MhqjOtbTZWnew==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 34, DateTimeKind.Local).AddTicks(748), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 51, 13, 34, DateTimeKind.Unspecified).AddTicks(778), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 34, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(559), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Unspecified).AddTicks(563), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(575), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Unspecified).AddTicks(575), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(577), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Unspecified).AddTicks(577), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(578), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(579), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 35, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(5654), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(5857), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(5861), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(5862), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(5865), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(5481), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(5755), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 31, DateTimeKind.Local).AddTicks(7860), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 31, DateTimeKind.Unspecified).AddTicks(7879), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 31, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5105), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5109), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5114), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5117), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5122), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5125), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5630), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5713), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5750), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5757), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5778), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5805), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5811), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(190), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(2078), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(2091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(4994), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5017), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5052), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5055), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5062), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5065), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5071), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5075), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5083), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5092), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 33, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 33, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(933), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4078), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4082), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4085), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4089), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4097), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4101), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4104), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4107), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4111), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4020), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4114), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4125), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4128), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4135), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4138), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4146), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4031), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4040), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4044), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 20, DateTimeKind.Unspecified).AddTicks(4055), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4856), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4859), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4823), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4827), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4831), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4842), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4849), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(3969), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(3981), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(4087), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(4092), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4095), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(4105), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(4109), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(9617), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(9624), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 31, DateTimeKind.Local).AddTicks(2501), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 31, DateTimeKind.Unspecified).AddTicks(2526), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 31, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 31, DateTimeKind.Local).AddTicks(3085), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 31, DateTimeKind.Unspecified).AddTicks(3093), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 31, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 20, DateTimeKind.Local).AddTicks(8174), new DateTime(2026, 8, 1, 12, 21, 13, 20, DateTimeKind.Utc).AddTicks(6050), new DateTime(2026, 1, 22, 12, 21, 13, 20, DateTimeKind.Utc).AddTicks(6018), new DateTime(2026, 2, 1, 16, 51, 13, 21, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 21, DateTimeKind.Local).AddTicks(9834), new DateTime(2026, 9, 1, 12, 21, 13, 21, DateTimeKind.Utc).AddTicks(9809), new DateTime(2026, 1, 27, 12, 21, 13, 21, DateTimeKind.Utc).AddTicks(9809), new DateTime(2026, 2, 1, 16, 51, 13, 21, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 22, DateTimeKind.Local).AddTicks(1278), new DateTime(2026, 5, 1, 12, 21, 13, 22, DateTimeKind.Utc).AddTicks(1267), new DateTime(2026, 1, 17, 12, 21, 13, 22, DateTimeKind.Utc).AddTicks(1266), new DateTime(2026, 2, 1, 16, 51, 13, 22, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 22, DateTimeKind.Local).AddTicks(2091), new DateTime(2026, 1, 12, 12, 21, 13, 22, DateTimeKind.Utc).AddTicks(2085), new DateTime(2026, 2, 1, 16, 51, 13, 22, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 22, DateTimeKind.Local).AddTicks(6360), new DateTime(2026, 2, 1, 16, 51, 13, 22, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3852), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(1918), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3087), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3806), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3817), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3824), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3830), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3836), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3843), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(7965), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8589), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(8594), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8595), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8599), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(8602), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8602), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8610), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(8613), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8614), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(8617), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8618), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 23, DateTimeKind.Unspecified).AddTicks(8620), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 23, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(717), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(980), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(983), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(984), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(987), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(988), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(947), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(951), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(952), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(954), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(955), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(958), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(959), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(965), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(966), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(969), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(970), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(972), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(973), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(976), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(977), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 51, 13, 24, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7615), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7871), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7843), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7846), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7849), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7861), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7864), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 21, 13, 24, DateTimeKind.Unspecified).AddTicks(7868), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
