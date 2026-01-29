using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddReq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a473dc92-463f-45d5-985b-825144b747c6", "AQAAAAIAAYagAAAAEIL1E/CYBAxUDy6zbCknVZjk6eOMcF6WMb1R6m+Eeb8Y/yziJeQZFgQDa0/RIbwfDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62d28cd4-4014-46c5-86e3-01354eebd478", "AQAAAAIAAYagAAAAENKRazi3kBFydoMU+BvZ9rO+K2FIfjbMxBnrLcwPwwhV78f65SJRRuujXU4pxUP7Jg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7492), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7502), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7875), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7880), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7882), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7886), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7887), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7891), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7892), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7901), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(7905), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1532), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1717), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(1722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1723), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 210, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 210, DateTimeKind.Unspecified).AddTicks(614), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 210, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(9596), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 225, DateTimeKind.Unspecified).AddTicks(9617), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4835), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4842), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4849), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4853), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4856), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4865), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4869), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4871), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4875), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4878), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4892), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(3609), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4295), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4305), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4771), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4778), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4788), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4800), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4805), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4809), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4813), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4817), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4820), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4828), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 227, DateTimeKind.Unspecified).AddTicks(4832), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 227, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8392), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8396), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8401), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8405), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8440), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8449), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8457), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8462), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8466), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8470), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8474), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8482), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8335), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8495), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8340), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8344), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8357), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8361), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8365), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 209, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9953), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(441), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(450), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(454), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(459), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(463), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(467), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(472), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9433), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9443), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9445), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9450), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9451), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9455), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9456), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(9459), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(6497), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(6506), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(3024), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 225, DateTimeKind.Unspecified).AddTicks(3087), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(3923), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 225, DateTimeKind.Unspecified).AddTicks(3936), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 210, DateTimeKind.Local).AddTicks(3400), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2514), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2522), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2523), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2527), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2529), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2538), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2539), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2543), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2544), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2549), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2553), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2554), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5333), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5680), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5685), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5688), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5689), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5621), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5641), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5642), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5647), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5657), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5660), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5662), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5666), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5670), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5671), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5675), new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 211, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 12, 26, 34, 211, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4012), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4332), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4298), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4303), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4311), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4320), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 29, 7, 56, 34, 212, DateTimeKind.Unspecified).AddTicks(4328), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37abbd11-7733-4fdc-88e6-c9239bec2432", "AQAAAAIAAYagAAAAEI1iT25XrohV/uqHygRIoiyo/wH7jLL/Ru2sr51iV+1F294J/v42icpjFBxbU4EfpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "231ad4ff-2cf3-4422-a9ba-037061ce04c2", "AQAAAAIAAYagAAAAEC7EO0AU7A8MdnTA6uq2mIBbTfyUtCkdv/2r/ZSioR9xXQ8e7OjoPJ0clA8Srj+H9g==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(7177), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(7206), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8241), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8254), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8257), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8262), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8266), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8268), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8270), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8272), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1105), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(1127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1441), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1453), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 529, DateTimeKind.Unspecified).AddTicks(2034), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 529, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 529, DateTimeKind.Unspecified).AddTicks(2872), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 552, DateTimeKind.Local).AddTicks(9994), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(62), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2492), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2495), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2497), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2502), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2506), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2509), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2511), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2516), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2521), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2523), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2418), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2440), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2443), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2451), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2453), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2456), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2461), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2466), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2468), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2470), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2475), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2490), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(7433), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8786), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8788), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8791), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8794), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8797), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8734), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8811), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8825), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8834), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8842), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8739), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8903), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8906), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8747), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(7067), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8504), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8473), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8477), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8480), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8493), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8496), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5329), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5405), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(5407), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5409), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(5421), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5423), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(5426), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 535, DateTimeKind.Local).AddTicks(4468), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 535, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 535, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 551, DateTimeKind.Local).AddTicks(5297), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 551, DateTimeKind.Unspecified).AddTicks(5366), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 551, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 551, DateTimeKind.Local).AddTicks(7164), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 551, DateTimeKind.Unspecified).AddTicks(7181), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 551, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 529, DateTimeKind.Local).AddTicks(7728), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4777), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4793), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4796), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4801), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4803), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4805), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4807), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4809), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4811), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4813), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4831), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4833), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(21), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(40), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(787), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(790), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(791), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(793), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(795), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(797), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(736), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(751), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(754), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(755), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(760), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(761), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(763), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(765), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(768), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(769), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(780), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(782), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(784), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(786), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9700), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9708), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9797), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9800), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
