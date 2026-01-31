using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigrgfkjuyt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "ExpirationDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 552, DateTimeKind.Local).AddTicks(4313), new DateTime(2026, 7, 31, 6, 0, 18, 552, DateTimeKind.Utc).AddTicks(1863), "Coca Cola 500ml", new DateTime(2026, 1, 21, 6, 0, 18, 552, DateTimeKind.Utc).AddTicks(1801), "Bottle", new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(7064), new DateTime(2026, 8, 31, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(7042), "Coca Cola 500ml", new DateTime(2026, 1, 26, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(7041), "Bottle", new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(8688), new DateTime(2026, 4, 30, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(8674), "Oreo Biscuits", new DateTime(2026, 1, 16, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(8672), "Pack", new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(9483), "A4 Notebook", new DateTime(2026, 1, 11, 6, 0, 18, 553, DateTimeKind.Utc).AddTicks(9477), "Piece", new DateTime(2026, 1, 31, 10, 30, 18, 553, DateTimeKind.Local).AddTicks(9483) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79a76cc8-43e2-42e1-a570-b72332c30531", "AQAAAAIAAYagAAAAELlCCnXfkCcPrqeDYo7PwOIFz/pCClYSn0dsSMh5TlA6s9D4ycwQx9A7XGR4NFy01Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5027f1e1-08d9-459f-b3e8-ab9f3a5b2b39", "AQAAAAIAAYagAAAAEL1uwYncZKGQ+tHIlDApQEECOkmI84MR4YqsY2JNFNg1bINb51ILvEyeHzRRxpi2pA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(3750), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(3758), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4059), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4065), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4068), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4069), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4073), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4078), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4081), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1090), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1198), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(1202), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1203), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(1206), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(778), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(5768), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 798, DateTimeKind.Unspecified).AddTicks(5781), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1580), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1589), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1597), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1600), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1605), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1613), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1616), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1620), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1625), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1630), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 799, DateTimeKind.Local).AddTicks(9216), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 799, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 799, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(521), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(535), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1505), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1512), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1531), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1541), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1550), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1557), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1563), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1571), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1389), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1916), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1919), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1926), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1930), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1955), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1958), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1961), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1964), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1969), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1975), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1978), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1981), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1873), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1985), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1988), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1877), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1887), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(202), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(207), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(210), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(177), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(188), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(191), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(195), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9360), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9367), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9370), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9383), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9384), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9388), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9391), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(5623), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(222), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 798, DateTimeKind.Unspecified).AddTicks(262), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(931), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 798, DateTimeKind.Unspecified).AddTicks(939), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 788, DateTimeKind.Local).AddTicks(6076), new DateTime(2026, 7, 31, 5, 58, 45, 788, DateTimeKind.Utc).AddTicks(3982), null, new DateTime(2026, 1, 21, 5, 58, 45, 788, DateTimeKind.Utc).AddTicks(3940), null, new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(7286), new DateTime(2026, 8, 31, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(7252), null, new DateTime(2026, 1, 26, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(7251), null, new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(8259), new DateTime(2026, 4, 30, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(8229), null, new DateTime(2026, 1, 16, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(8228), null, new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(8757), null, new DateTime(2026, 1, 11, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(8751), null, new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3044), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3724), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3730), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3738), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3739), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3744), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3747), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3748), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3751), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3752), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3756), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6047), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6061), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6293), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6297), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6301), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6302), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6305), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6255), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6262), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6268), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6269), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6273), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6273), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6276), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6277), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6281), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6285), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6289), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3158), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3433), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3443), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3447), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3450), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3454), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3457), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3460), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
