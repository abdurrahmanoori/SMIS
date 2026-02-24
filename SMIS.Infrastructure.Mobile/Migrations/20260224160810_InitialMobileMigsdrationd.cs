using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class InitialMobileMigsdrationd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 1, 37, 78, DateTimeKind.Utc).AddTicks(9334), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Unspecified).AddTicks(1166), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 78, DateTimeKind.Utc).AddTicks(8531), new DateTime(2026, 2, 24, 16, 1, 37, 78, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Utc).AddTicks(4924), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Unspecified).AddTicks(6437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Utc).AddTicks(3979), new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Utc).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(79), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Unspecified).AddTicks(2375), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Utc).AddTicks(9061), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3311), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Unspecified).AddTicks(3319), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3300), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3340), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Unspecified).AddTicks(3346), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3336), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3373), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Unspecified).AddTicks(3379), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3370), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3376) });
        }
    }
}
