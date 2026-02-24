using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class sdfssd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(3268), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Unspecified).AddTicks(5450), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(2577), new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(9060), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(8093), new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(4600), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(3506), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7647), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(7657), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7635), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7677), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7674), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7701), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(7707), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7697), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7704) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 11, 44, 59, DateTimeKind.Utc).AddTicks(2511), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 11, 44, 59, DateTimeKind.Unspecified).AddTicks(4324), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 11, 44, 59, DateTimeKind.Utc).AddTicks(1653), new DateTime(2026, 2, 24, 16, 11, 44, 59, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 11, 44, 59, DateTimeKind.Utc).AddTicks(7557), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 11, 44, 59, DateTimeKind.Unspecified).AddTicks(9127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 11, 44, 59, DateTimeKind.Utc).AddTicks(6714), new DateTime(2026, 2, 24, 16, 11, 44, 59, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(2743), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Unspecified).AddTicks(4733), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(1721), new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(5661), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Unspecified).AddTicks(5670), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(5650), new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(5700), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(5697), new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(5723), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Unspecified).AddTicks(5786), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(5719), new DateTime(2026, 2, 24, 16, 11, 44, 60, DateTimeKind.Utc).AddTicks(5725) });
        }
    }
}
