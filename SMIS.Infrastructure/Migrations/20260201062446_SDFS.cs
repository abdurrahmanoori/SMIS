using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SDFS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "AspNetRoles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedUtc",
                table: "AspNetRoles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "AspNetRoles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "EntityState", "LastModifiedUtc", "PasswordHash", "Version" },
                values: new object[] { "20301c6f-0dd3-4dbb-9b36-0d81d51c63fd", "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEOh+55cCCBSnlcVTaZHqj3WptQ/b5ql1q2CLjwuqagP61RB8vJvnjqI5c0KBU53+Zg==", 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "EntityState", "LastModifiedUtc", "PasswordHash", "Version" },
                values: new object[] { "d48ceeb4-49fb-4b64-aa79-ca3ecdb0a2f5", "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEArnWdEgXrXcGFv7XRk3buKfbN0E1YS3IgchUwZxkrWLtQt/z2zspiCHA5165C32Hg==", 0 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(1732), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(1742), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2178), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2182), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2184), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2186), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2188), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2191), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2192), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2198), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2199), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 254, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 254, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(848), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(854), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(1031), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(1035), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(1036), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(1040), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(495), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 252, DateTimeKind.Local).AddTicks(2343), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 252, DateTimeKind.Unspecified).AddTicks(2369), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 252, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9012), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9015), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9020), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9024), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9029), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9037), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9050), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9058), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9062), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9066), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(6450), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(6487), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(7632), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8895), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8909), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8954), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8966), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8973), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8977), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8983), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8986), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8992), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(8995), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9003), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 253, DateTimeKind.Unspecified).AddTicks(9006), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 253, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 238, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2074), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2078), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2081), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2084), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2088), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2118), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2125), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2039), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2132), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2135), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2139), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2142), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2156), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2165), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2049), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2053), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2057), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2060), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2064), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 239, DateTimeKind.Unspecified).AddTicks(2071), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9968), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9971), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9940), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9943), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9947), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9950), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9953), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9956), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9961), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(8921), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(8930), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9089), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9092), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9093), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9097), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(5002), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(5009), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 244, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 251, DateTimeKind.Local).AddTicks(6380), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 251, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 251, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 251, DateTimeKind.Local).AddTicks(7073), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 251, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 251, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 239, DateTimeKind.Local).AddTicks(6926), new DateTime(2026, 8, 1, 6, 24, 46, 239, DateTimeKind.Utc).AddTicks(4294), new DateTime(2026, 1, 22, 6, 24, 46, 239, DateTimeKind.Utc).AddTicks(4249), new DateTime(2026, 2, 1, 10, 54, 46, 240, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(3993), new DateTime(2026, 9, 1, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(3944), new DateTime(2026, 1, 27, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(3941), new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(5634), new DateTime(2026, 5, 1, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(5623), new DateTime(2026, 1, 17, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(5622), new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(6636), new DateTime(2026, 1, 12, 6, 24, 46, 241, DateTimeKind.Utc).AddTicks(6616), new DateTime(2026, 2, 1, 10, 54, 46, 241, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(677), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7836), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(5806), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7012), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7788), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7800), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7811), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7818), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7823), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7830), new DateTime(2026, 2, 1, 10, 54, 46, 242, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(2903), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3201), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3565), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3571), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3575), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3580), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3583), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3583), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3588), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3591), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(3594), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5523), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5532), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5831), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5835), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5839), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5797), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5801), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5802), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5806), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5807), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5809), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5810), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5813), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5814), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5817), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5818), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5821), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5825), new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 243, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 54, 46, 243, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(2882), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3199), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3175), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3186), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 6, 24, 46, 244, DateTimeKind.Unspecified).AddTicks(3195), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "LastModifiedUtc",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f8eb21a-72a8-4d9e-8d80-f18b56710cfc", "AQAAAAIAAYagAAAAEMijzHQIPNsdxDgrOuumx08vGrx23/EoNZ66G9t7M3goGN8OA5sqC8RzwL2pR9AAYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6249b1a-8894-42f9-bb8b-8d3d16255c18", "AQAAAAIAAYagAAAAEONjS/PDVkucLAWihhmzAmkjNPrmjrQfPo8mkhnOANFB5l1X70hKtg6P51hEeE4MHA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1341), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1348), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1699), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1706), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1708), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1712), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1716), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1719), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1720), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 738, DateTimeKind.Unspecified).AddTicks(1723), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 738, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6817), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6919), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(6926), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6927), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(5724), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 736, DateTimeKind.Local).AddTicks(4454), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 736, DateTimeKind.Unspecified).AddTicks(4466), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 736, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9210), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9217), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9223), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9226), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9231), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9234), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9239), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9247), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9255), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9258), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9263), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9267), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(7209), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(7230), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(8321), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9139), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9145), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9159), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9162), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9168), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9172), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9177), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9180), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9186), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9201), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 737, DateTimeKind.Unspecified).AddTicks(9205), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 737, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 721, DateTimeKind.Unspecified).AddTicks(8575), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9336), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9339), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9346), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9352), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9355), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9359), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9385), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9389), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9293), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9396), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9399), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9404), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9407), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9414), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9417), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9421), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9427), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9302), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9432), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9435), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9306), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9309), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9320), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9329), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 722, DateTimeKind.Unspecified).AddTicks(9332), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5323), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5774), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5777), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5754), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5760), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5764), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5767), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(5771), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4829), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(4839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4841), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(4848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4849), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(4852), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4852), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(4855), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 729, DateTimeKind.Local).AddTicks(893), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 729, DateTimeKind.Unspecified).AddTicks(901), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 729, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 735, DateTimeKind.Local).AddTicks(8802), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 735, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 735, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 735, DateTimeKind.Local).AddTicks(9485), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 735, DateTimeKind.Unspecified).AddTicks(9493), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 735, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 724, DateTimeKind.Local).AddTicks(8139), new DateTime(2026, 7, 31, 11, 22, 8, 723, DateTimeKind.Utc).AddTicks(1532), new DateTime(2026, 1, 21, 11, 22, 8, 723, DateTimeKind.Utc).AddTicks(1485), new DateTime(2026, 1, 31, 15, 52, 8, 725, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(493), new DateTime(2026, 8, 31, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(468), new DateTime(2026, 1, 26, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(467), new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(2036), new DateTime(2026, 4, 30, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(2026), new DateTime(2026, 1, 16, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(2025), new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(2862), new DateTime(2026, 1, 11, 11, 22, 8, 726, DateTimeKind.Utc).AddTicks(2855), new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(6784), new DateTime(2026, 1, 31, 15, 52, 8, 726, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3684), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(1527), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(2558), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3636), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3652), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3659), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3665), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3670), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3677), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8179), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8847), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8853), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8856), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8857), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8861), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8864), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8865), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8871), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8871), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8874), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8875), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 727, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 727, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1050), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1289), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1293), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1296), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1297), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1300), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1229), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1233), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1234), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1237), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1238), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1242), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1245), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1246), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1276), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1277), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1281), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1285), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(1288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 52, 8, 728, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(8833), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9105), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9075), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9079), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9082), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9086), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9089), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9095), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9098), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 22, 8, 728, DateTimeKind.Unspecified).AddTicks(9101), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
