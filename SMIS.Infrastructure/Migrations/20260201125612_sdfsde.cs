using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfsde : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1b4fdeb-15ff-42e0-a61f-5c88b189bce0", "AQAAAAIAAYagAAAAELeKg4ouDxhvCPD/bPCUqIZz4aHDLxAIFIhWqMkfJ64doBXks4S15WOud4W9PxeIlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b785a0e-0e86-423f-a4a2-11d6d7bccd41", "AQAAAAIAAYagAAAAEASAee8634LSvKHAyKRwml62dl11TTMfXOaRD/4Bq13wixIFOytB30IN1bYmm/67zg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(4485), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Unspecified).AddTicks(4532), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(551), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(560), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(587), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(588), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(590), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(590), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(591), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(592), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(593), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(593), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(206), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 151, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(652), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 151, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(661), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 151, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 146, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 146, DateTimeKind.Unspecified).AddTicks(4043), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 146, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 167, DateTimeKind.Local).AddTicks(8703), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 167, DateTimeKind.Unspecified).AddTicks(8748), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 167, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(900), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(908), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(916), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(925), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(936), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(940), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(945), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(949), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(955), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(958), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(964), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(968), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 169, DateTimeKind.Local).AddTicks(8088), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 169, DateTimeKind.Unspecified).AddTicks(8134), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 169, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 169, DateTimeKind.Local).AddTicks(9765), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 169, DateTimeKind.Unspecified).AddTicks(9776), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 169, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(817), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(841), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(845), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(858), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(870), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(874), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(880), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(884), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(890), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(894), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(5181), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9862), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9866), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9881), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9885), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9903), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9912), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9916), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9920), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9932), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9936), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9941), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9950), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9954), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9843), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9848), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9857), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(4321), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6362), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6365), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6321), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6331), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6346), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6349), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6352), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6354), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6357), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(1488), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2328), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(2345), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2348), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(2352), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2354), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(2356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 153, DateTimeKind.Local).AddTicks(478), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 153, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 153, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 166, DateTimeKind.Local).AddTicks(8552), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 166, DateTimeKind.Unspecified).AddTicks(8615), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 166, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 166, DateTimeKind.Local).AddTicks(9682), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 166, DateTimeKind.Unspecified).AddTicks(9694), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 166, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 138, DateTimeKind.Local).AddTicks(6960), new DateTime(2026, 8, 1, 12, 56, 12, 138, DateTimeKind.Utc).AddTicks(2878), new DateTime(2026, 1, 22, 12, 56, 12, 138, DateTimeKind.Utc).AddTicks(2810), new DateTime(2026, 2, 1, 17, 26, 12, 139, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 141, DateTimeKind.Local).AddTicks(2241), new DateTime(2026, 9, 1, 12, 56, 12, 141, DateTimeKind.Utc).AddTicks(2147), new DateTime(2026, 1, 27, 12, 56, 12, 141, DateTimeKind.Utc).AddTicks(2141), new DateTime(2026, 2, 1, 17, 26, 12, 141, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 141, DateTimeKind.Local).AddTicks(8998), new DateTime(2026, 5, 1, 12, 56, 12, 141, DateTimeKind.Utc).AddTicks(8919), new DateTime(2026, 1, 17, 12, 56, 12, 141, DateTimeKind.Utc).AddTicks(8911), new DateTime(2026, 2, 1, 17, 26, 12, 141, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 142, DateTimeKind.Local).AddTicks(1548), new DateTime(2026, 1, 12, 12, 56, 12, 142, DateTimeKind.Utc).AddTicks(1502), new DateTime(2026, 2, 1, 17, 26, 12, 142, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 143, DateTimeKind.Local).AddTicks(1570), new DateTime(2026, 2, 1, 17, 26, 12, 143, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4502), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 144, DateTimeKind.Local).AddTicks(7198), new DateTime(2026, 2, 1, 17, 26, 12, 144, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(818), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4328), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4436), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4451), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4465), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4476), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4490), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(1884), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(2743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5912), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(5970), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5973), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(5977), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5978), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(5991), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5992), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(5996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5997), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(6001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(6002), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(6006), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(6007), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(5934), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(6024), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7337), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7344), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7349), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7350), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7216), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7234), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7241), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7249), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7291), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7292), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7299), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7305), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7330), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7331), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7336), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 151, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(4171), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5074), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5099), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5118), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5124), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66f11f08-7431-45ac-b18b-2599756b1071", "AQAAAAIAAYagAAAAEG06VD9jL1hGE4fAETaPCmu5DxNtEpCWkuajW3ESCx6hKyluk9jGnKMxYVq5fdYV5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57e7aa22-b54c-4c21-a631-2107615bf50b", "AQAAAAIAAYagAAAAEMev0fQ65pjfCy18ItiEVL1cd2dKg7Si9bm0lZeBOWNu6v+Klb9wfRKotWCXgoHhSg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(8051), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Unspecified).AddTicks(8109), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2102), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Unspecified).AddTicks(2109), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2125), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Unspecified).AddTicks(2126), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2128), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2130), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Unspecified).AddTicks(2131), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2132), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Unspecified).AddTicks(2133), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 875, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(8779), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(9296), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(9306), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(9308), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(9312), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(3437), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(3789), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 870, DateTimeKind.Local).AddTicks(1554), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 870, DateTimeKind.Unspecified).AddTicks(1619), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 870, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2652), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2670), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2675), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2686), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2692), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2701), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2707), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2717), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(3048), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(3074), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(3109), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(3115), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 872, DateTimeKind.Local).AddTicks(8142), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 872, DateTimeKind.Unspecified).AddTicks(8213), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 872, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(820), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2523), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2536), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2562), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2579), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2595), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2611), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2628), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 873, DateTimeKind.Unspecified).AddTicks(2642), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 873, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(567), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4941), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4946), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4956), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4967), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4973), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4979), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4987), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4992), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4872), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4997), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5009), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5018), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5023), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5059), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5065), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5069), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5074), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4900), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5080), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4908), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4913), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4919), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 845, DateTimeKind.Unspecified).AddTicks(4934), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(2914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5310), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5312), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5315), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5271), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5279), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5285), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5288), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5296), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(5307), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(1165), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(1207), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(1534), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(1541), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(1542), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(1548), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(1549), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 852, DateTimeKind.Unspecified).AddTicks(1554), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 852, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 854, DateTimeKind.Local).AddTicks(8615), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 854, DateTimeKind.Unspecified).AddTicks(8708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 854, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 868, DateTimeKind.Local).AddTicks(8310), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 868, DateTimeKind.Unspecified).AddTicks(8569), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 868, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 869, DateTimeKind.Local).AddTicks(1917), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 869, DateTimeKind.Unspecified).AddTicks(1946), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 869, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 846, DateTimeKind.Local).AddTicks(1461), new DateTime(2026, 8, 1, 12, 53, 57, 845, DateTimeKind.Utc).AddTicks(8104), new DateTime(2026, 1, 22, 12, 53, 57, 845, DateTimeKind.Utc).AddTicks(8042), new DateTime(2026, 2, 1, 17, 23, 57, 847, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 847, DateTimeKind.Local).AddTicks(7575), new DateTime(2026, 9, 1, 12, 53, 57, 847, DateTimeKind.Utc).AddTicks(7539), new DateTime(2026, 1, 27, 12, 53, 57, 847, DateTimeKind.Utc).AddTicks(7536), new DateTime(2026, 2, 1, 17, 23, 57, 847, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 847, DateTimeKind.Local).AddTicks(9566), new DateTime(2026, 5, 1, 12, 53, 57, 847, DateTimeKind.Utc).AddTicks(9545), new DateTime(2026, 1, 17, 12, 53, 57, 847, DateTimeKind.Utc).AddTicks(9542), new DateTime(2026, 2, 1, 17, 23, 57, 847, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 848, DateTimeKind.Local).AddTicks(651), new DateTime(2026, 1, 12, 12, 53, 57, 848, DateTimeKind.Utc).AddTicks(632), new DateTime(2026, 2, 1, 17, 23, 57, 848, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 848, DateTimeKind.Local).AddTicks(6158), new DateTime(2026, 2, 1, 17, 23, 57, 848, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(1000), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 849, DateTimeKind.Local).AddTicks(7098), new DateTime(2026, 2, 1, 17, 23, 57, 849, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 849, DateTimeKind.Local).AddTicks(8759), new DateTime(2026, 2, 1, 17, 23, 57, 849, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(903), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(960), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(973), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(979), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(986), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(993), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(8443), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9589), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(9595), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9597), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(9601), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9602), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(9607), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9608), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(9611), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9612), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9617), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(9620), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9632), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 850, DateTimeKind.Unspecified).AddTicks(9636), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 850, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3348), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3377), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3783), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3787), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3788), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3792), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3796), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3742), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3748), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3750), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3753), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3755), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3758), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3759), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3763), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3763), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3767), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3768), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3771), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3772), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3776), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3777), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 851, DateTimeKind.Unspecified).AddTicks(3782), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 23, 57, 851, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 853, DateTimeKind.Unspecified).AddTicks(2855), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 854, DateTimeKind.Unspecified).AddTicks(1115), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 853, DateTimeKind.Unspecified).AddTicks(8761), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 854, DateTimeKind.Unspecified).AddTicks(196), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 854, DateTimeKind.Unspecified).AddTicks(1057), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 854, DateTimeKind.Unspecified).AddTicks(1078), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 854, DateTimeKind.Unspecified).AddTicks(1084), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 854, DateTimeKind.Unspecified).AddTicks(1089), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 854, DateTimeKind.Unspecified).AddTicks(1103), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 53, 57, 854, DateTimeKind.Unspecified).AddTicks(1109), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
