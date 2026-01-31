using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigrgfkjuytsddsdsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f8c6f1f-06f1-4851-9a98-ccdd47be7c4b", "AQAAAAIAAYagAAAAEBprDTNHNdJBhfP2FHPBvRBixeBu8YdJvRxE3yd+wxlpwi8bfi4xxlFEofSU7BPtOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ad09dc9-57d1-484b-9738-11a16ea83f01", "AQAAAAIAAYagAAAAEPUNMwgNeqOtn8nu1Nd1FTpoYz0yuYXtH8/FqwSYMRwjomRgmInOaaGgVq1pcfCY+w==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7053), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7369), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7376), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7378), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7381), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7382), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7385), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7394), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7400), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(4942), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4947), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(5032), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(5036), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(5037), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(5040), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(4904), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(5247), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 830, DateTimeKind.Local).AddTicks(212), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 830, DateTimeKind.Unspecified).AddTicks(228), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 830, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4945), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4956), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4959), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4964), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4967), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4971), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4974), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4979), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4982), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4986), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4994), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4997), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(2841), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(2870), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4063), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4071), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4883), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4889), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4903), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4907), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4912), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4916), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4921), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4924), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4929), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4932), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4937), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 831, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 831, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 818, DateTimeKind.Unspecified).AddTicks(9025), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2629), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2632), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2663), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2667), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2675), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2691), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2695), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2698), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2702), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2705), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2710), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2714), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2724), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2727), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2595), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2730), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2734), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2603), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2607), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 819, DateTimeKind.Unspecified).AddTicks(2625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3719), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4127), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4133), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4109), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4116), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(4122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3265), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3282), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3285), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3289), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(3292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(9215), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(9234), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 829, DateTimeKind.Local).AddTicks(4759), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 829, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 829, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 829, DateTimeKind.Local).AddTicks(5475), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 829, DateTimeKind.Unspecified).AddTicks(5493), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 829, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 819, DateTimeKind.Local).AddTicks(7060), new DateTime(2026, 7, 31, 7, 15, 55, 819, DateTimeKind.Utc).AddTicks(4851), new DateTime(2026, 1, 21, 7, 15, 55, 819, DateTimeKind.Utc).AddTicks(4804), new DateTime(2026, 1, 31, 11, 45, 55, 820, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 820, DateTimeKind.Local).AddTicks(9852), new DateTime(2026, 8, 31, 7, 15, 55, 820, DateTimeKind.Utc).AddTicks(9824), new DateTime(2026, 1, 26, 7, 15, 55, 820, DateTimeKind.Utc).AddTicks(9823), new DateTime(2026, 1, 31, 11, 45, 55, 820, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(2081), new DateTime(2026, 4, 30, 7, 15, 55, 821, DateTimeKind.Utc).AddTicks(2064), new DateTime(2026, 1, 16, 7, 15, 55, 821, DateTimeKind.Utc).AddTicks(2063), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(2853), new DateTime(2026, 1, 11, 7, 15, 55, 821, DateTimeKind.Utc).AddTicks(2847), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(7535), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(7822), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8150), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8160), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8163), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8164), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8167), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8167), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8170), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8171), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8174), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8175), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8178), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8179), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 821, DateTimeKind.Unspecified).AddTicks(8182), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 821, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(43), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(48), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(240), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(245), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(248), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(249), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(252), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(206), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(213), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(214), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(217), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(218), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(221), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(221), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(225), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(228), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(229), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(233), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(236), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(236), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(239), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 45, 55, 822, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(6903), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7236), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7206), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7215), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7219), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7223), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7227), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 15, 55, 822, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_StockBatch_Product_ProductId",
                table: "StockBatch",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockBatch_Product_ProductId",
                table: "StockBatch");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bbc60b0-02db-434f-ad9a-81ac737a6633", "AQAAAAIAAYagAAAAEIok9bXYjXs4/ScZgGdtY2AabAh0lGRy2z/d68VXcynYYZEMsDc8Pa6DoW4LTKfeKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8420612b-3c08-4730-8a92-b0961792ccfa", "AQAAAAIAAYagAAAAEM7FLLjWx9WuSugrZ7YKWqB/aeqDRpajmaHj9RFpDb51S3NFABbaDty4jP3qd31PjA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4040), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4329), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4333), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4334), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4338), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4343), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4347), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(4350), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4381), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(4392), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4493), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(4497), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4498), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(4501), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(3083), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(3379), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 584, DateTimeKind.Local).AddTicks(4545), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 584, DateTimeKind.Unspecified).AddTicks(4575), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 584, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1708), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1712), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1716), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1719), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1724), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1727), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1731), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1738), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1741), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1746), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1749), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1753), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1758), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 585, DateTimeKind.Local).AddTicks(9640), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 585, DateTimeKind.Unspecified).AddTicks(9661), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 585, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(838), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1636), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1641), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1655), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1658), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1664), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1667), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1678), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1687), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1701), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 586, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 586, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 571, DateTimeKind.Unspecified).AddTicks(8343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1155), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1165), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1187), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1193), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1235), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1245), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1248), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1126), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1252), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1255), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1134), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1141), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 572, DateTimeKind.Unspecified).AddTicks(1151), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3312), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3317), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3320), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3281), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3294), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3298), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3301), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3305), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(3309), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2401), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2411), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2413), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2416), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2417), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2422), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(2425), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(8735), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 575, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 583, DateTimeKind.Local).AddTicks(6892), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 583, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 583, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 583, DateTimeKind.Local).AddTicks(8281), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 583, DateTimeKind.Unspecified).AddTicks(8292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 583, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 572, DateTimeKind.Local).AddTicks(5852), new DateTime(2026, 7, 31, 6, 11, 2, 572, DateTimeKind.Utc).AddTicks(3311), new DateTime(2026, 1, 21, 6, 11, 2, 572, DateTimeKind.Utc).AddTicks(3259), new DateTime(2026, 1, 31, 10, 41, 2, 573, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 573, DateTimeKind.Local).AddTicks(8984), new DateTime(2026, 8, 31, 6, 11, 2, 573, DateTimeKind.Utc).AddTicks(8954), new DateTime(2026, 1, 26, 6, 11, 2, 573, DateTimeKind.Utc).AddTicks(8953), new DateTime(2026, 1, 31, 10, 41, 2, 573, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(480), new DateTime(2026, 4, 30, 6, 11, 2, 574, DateTimeKind.Utc).AddTicks(467), new DateTime(2026, 1, 16, 6, 11, 2, 574, DateTimeKind.Utc).AddTicks(465), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(1232), new DateTime(2026, 1, 11, 6, 11, 2, 574, DateTimeKind.Utc).AddTicks(1226), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(6379), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7055), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7060), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7061), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7071), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7074), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7075), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7078), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7082), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7085), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7086), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9208), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9465), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9467), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9468), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9473), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9474), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9476), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9427), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9431), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9432), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9440), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9443), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9444), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9447), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9448), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9451), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9452), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9456), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9456), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9460), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9460), new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 574, DateTimeKind.Unspecified).AddTicks(9464), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 41, 2, 574, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6917), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6904), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6907), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6911), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 6, 11, 2, 575, DateTimeKind.Unspecified).AddTicks(6914), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
