using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class sdfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 10, 54, 991, DateTimeKind.Utc).AddTicks(4572), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 10, 54, 991, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 10, 54, 991, DateTimeKind.Utc).AddTicks(3758), new DateTime(2026, 2, 24, 16, 10, 54, 991, DateTimeKind.Utc).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 10, 54, 991, DateTimeKind.Utc).AddTicks(9797), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Unspecified).AddTicks(1372), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 10, 54, 991, DateTimeKind.Utc).AddTicks(8946), new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(5365), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Unspecified).AddTicks(7309), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(4342), new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(8319), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Unspecified).AddTicks(8327), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(8308), new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(8348), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Unspecified).AddTicks(8354), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(8344), new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(8371), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Unspecified).AddTicks(8377), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(8368), new DateTime(2026, 2, 24, 16, 10, 54, 992, DateTimeKind.Utc).AddTicks(8374) });
        }
    }
}
