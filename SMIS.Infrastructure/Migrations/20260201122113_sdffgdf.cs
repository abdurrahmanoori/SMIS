using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdffgdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50b61241-4944-4576-9c9a-221dec169faa", "AQAAAAIAAYagAAAAEEqfVjQydQHZCvECTladgBm+rbkfcvG1mPBMqIQsYB45mw53gV/eEN27w1Vj96bu3Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c352b040-ea5c-4953-8f08-7de66237b1fd", "AQAAAAIAAYagAAAAEJ9Cw2I79KzjgkXm2a+C/g2ra5emcoDVQ7o0vJzVnWxY9gcSinnakhNRTVPRJVyw2Q==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(274), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(770), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(777), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(784), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(785), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(788), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(789), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(792), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(793), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(796), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(2063), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(2235), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(2239), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(2240), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(2245), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(856), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 710, DateTimeKind.Local).AddTicks(3393), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 710, DateTimeKind.Unspecified).AddTicks(3407), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 710, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8091), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8099), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8105), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8110), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8113), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8123), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8132), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8135), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8139), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8142), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8147), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8150), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(6050), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(6066), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(7243), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8032), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8051), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8059), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8062), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8067), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8075), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8084), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 711, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 711, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 698, DateTimeKind.Unspecified).AddTicks(7877), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(653), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(657), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(660), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(664), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(669), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(679), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(683), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(613), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(686), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(689), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(692), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(696), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(699), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(703), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(706), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(709), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(731), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(738), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(626), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(630), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(639), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(643), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 699, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1235), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1206), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1210), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1213), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1225), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1228), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(1231), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(269), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(389), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(394), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(402), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(405), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(6223), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(6237), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 703, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 709, DateTimeKind.Local).AddTicks(7773), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 709, DateTimeKind.Unspecified).AddTicks(7820), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 709, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 709, DateTimeKind.Local).AddTicks(8470), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 709, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 709, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 699, DateTimeKind.Local).AddTicks(4785), new DateTime(2026, 8, 1, 12, 10, 7, 699, DateTimeKind.Utc).AddTicks(2687), new DateTime(2026, 1, 22, 12, 10, 7, 699, DateTimeKind.Utc).AddTicks(2648), new DateTime(2026, 2, 1, 16, 40, 7, 700, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 700, DateTimeKind.Local).AddTicks(6667), new DateTime(2026, 9, 1, 12, 10, 7, 700, DateTimeKind.Utc).AddTicks(6641), new DateTime(2026, 1, 27, 12, 10, 7, 700, DateTimeKind.Utc).AddTicks(6640), new DateTime(2026, 2, 1, 16, 40, 7, 700, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 700, DateTimeKind.Local).AddTicks(8119), new DateTime(2026, 5, 1, 12, 10, 7, 700, DateTimeKind.Utc).AddTicks(8109), new DateTime(2026, 1, 17, 12, 10, 7, 700, DateTimeKind.Utc).AddTicks(8108), new DateTime(2026, 2, 1, 16, 40, 7, 700, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 700, DateTimeKind.Local).AddTicks(8978), new DateTime(2026, 1, 12, 12, 10, 7, 700, DateTimeKind.Utc).AddTicks(8972), new DateTime(2026, 2, 1, 16, 40, 7, 700, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(2586), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(9003), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(7378), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8307), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8960), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8971), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8978), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8985), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8991), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8997), new DateTime(2026, 2, 1, 16, 40, 7, 701, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3157), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(3450), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3897), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3904), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(3907), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3908), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3912), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(3915), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3916), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(3919), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3920), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(3928), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3929), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(3932), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6507), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6518), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6863), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6866), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6866), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6870), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6873), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6827), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6831), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6832), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6835), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6836), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6840), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6843), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6843), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6847), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6854), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6855), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6858), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6859), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 702, DateTimeKind.Unspecified).AddTicks(6862), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 16, 40, 7, 702, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4052), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4314), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4287), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4290), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4297), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4300), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4303), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 703, DateTimeKind.Unspecified).AddTicks(4311), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
