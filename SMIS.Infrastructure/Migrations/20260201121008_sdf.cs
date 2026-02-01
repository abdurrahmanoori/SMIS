using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopId",
                table: "Category",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(274), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(770), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(777), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(784), new TimeSpan(0, 0, 0, 0, 0)), "2", new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(785), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(788), new TimeSpan(0, 0, 0, 0, 0)), "2", new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(789), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(792), new TimeSpan(0, 0, 0, 0, 0)), "3", new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(793), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 10, 7, 712, DateTimeKind.Unspecified).AddTicks(796), new TimeSpan(0, 0, 0, 0, 0)), "3", new DateTime(2026, 2, 1, 16, 40, 7, 712, DateTimeKind.Local).AddTicks(794) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Category_ShopId",
                table: "Category",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Shop_ShopId",
                table: "Category",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Shop_ShopId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ShopId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "896cb323-d784-4531-90a2-1da421676e95", "AQAAAAIAAYagAAAAEI5puNkwo3rFYjXvRzfKlGmr2w20aUFimXV/4AmUuWqoFDodtTjwwAjue4KGCNT5eg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6af2e7a0-c8c1-4d42-a5e0-60377daa5d53", "AQAAAAIAAYagAAAAEO5YOlnpLyyXUE5Pm4sYLZ8SzR5YpOL9EynF+MfNajOsUZAxyHtfw+fZQjKVAsCnuQ==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4010), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4443), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4460), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4463), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4464), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4468), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4472), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(4474), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(9973), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(9979), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(185), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(190), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(191), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(194), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(3252), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(3259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(6866), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 280, DateTimeKind.Unspecified).AddTicks(6879), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1947), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1950), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1954), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1957), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1962), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1969), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1977), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1980), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1984), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1987), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1992), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 281, DateTimeKind.Local).AddTicks(9821), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 281, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 281, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(972), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(979), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1881), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1886), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1902), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1910), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1918), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1921), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1926), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1938), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 282, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 282, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 267, DateTimeKind.Unspecified).AddTicks(7141), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(350), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(353), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(371), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(374), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(378), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(381), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(312), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(387), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(391), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(394), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(402), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(405), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(408), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(417), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(420), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(327), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(334), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(342), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 268, DateTimeKind.Unspecified).AddTicks(346), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8853), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8861), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8828), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8832), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(8850), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7688), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7886), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(7891), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7892), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(7895), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7896), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(4790), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(4814), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 273, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(1403), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 280, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(2033), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 280, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 280, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 268, DateTimeKind.Local).AddTicks(4926), new DateTime(2026, 8, 1, 9, 45, 25, 268, DateTimeKind.Utc).AddTicks(2327), new DateTime(2026, 1, 22, 9, 45, 25, 268, DateTimeKind.Utc).AddTicks(2288), new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(7288), new DateTime(2026, 9, 1, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(7267), new DateTime(2026, 1, 27, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(7266), new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(8744), new DateTime(2026, 5, 1, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(8735), new DateTime(2026, 1, 17, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(8734), new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(9633), new DateTime(2026, 1, 12, 9, 45, 25, 269, DateTimeKind.Utc).AddTicks(9626), new DateTime(2026, 2, 1, 14, 15, 25, 269, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(3288), new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(981), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(8838), new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(9983), new DateTime(2026, 2, 1, 14, 15, 25, 270, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(919), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(938), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(954), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(961), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(967), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(974), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(5839), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(6368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8165), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8213), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8216), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8221), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8222), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8225), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8226), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8230), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8231), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8235), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8236), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8239), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8240), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 271, DateTimeKind.Unspecified).AddTicks(8244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 271, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(910), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(918), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1284), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1302), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1305), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1306), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1309), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1246), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1254), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1255), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1258), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1259), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1262), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1263), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1266), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1267), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1271), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1275), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1276), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1280), new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 272, DateTimeKind.Unspecified).AddTicks(1283), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 14, 15, 25, 272, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2218), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2534), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2495), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2505), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2508), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 9, 45, 25, 273, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
