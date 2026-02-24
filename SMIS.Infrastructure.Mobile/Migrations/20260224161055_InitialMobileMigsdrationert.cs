using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class InitialMobileMigsdrationert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 8, 9, 996, DateTimeKind.Utc).AddTicks(1594), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 8, 9, 996, DateTimeKind.Unspecified).AddTicks(3371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 8, 9, 996, DateTimeKind.Utc).AddTicks(720), new DateTime(2026, 2, 24, 16, 8, 9, 996, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 8, 9, 996, DateTimeKind.Utc).AddTicks(6668), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 8, 9, 996, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 8, 9, 996, DateTimeKind.Utc).AddTicks(5812), new DateTime(2026, 2, 24, 16, 8, 9, 996, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(1896), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Unspecified).AddTicks(3825), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(875), new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(4751), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Unspecified).AddTicks(4759), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(4740), new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(4779), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Unspecified).AddTicks(4785), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(4775), new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(4857), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Unspecified).AddTicks(4863), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(4853), new DateTime(2026, 2, 24, 16, 8, 9, 997, DateTimeKind.Utc).AddTicks(4860) });
        }
    }
}
