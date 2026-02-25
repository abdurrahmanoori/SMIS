using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class sdfwe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EntityState",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 12, 34, 19, 684, DateTimeKind.Utc).AddTicks(5341), "Unchanged", new DateTimeOffset(new DateTime(2026, 2, 25, 12, 34, 19, 684, DateTimeKind.Unspecified).AddTicks(5842), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 12, 34, 19, 684, DateTimeKind.Utc).AddTicks(5002), new DateTime(2026, 2, 25, 12, 34, 19, 684, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 12, 34, 19, 684, DateTimeKind.Utc).AddTicks(8075), "Unchanged", new DateTimeOffset(new DateTime(2026, 2, 25, 12, 34, 19, 684, DateTimeKind.Unspecified).AddTicks(8781), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 12, 34, 19, 684, DateTimeKind.Utc).AddTicks(7344), new DateTime(2026, 2, 25, 12, 34, 19, 684, DateTimeKind.Utc).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(547), "Unchanged", new DateTimeOffset(new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(116), new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(1611), "Unchanged", new DateTimeOffset(new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Unspecified).AddTicks(1615), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(1607), new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(1632), "Unchanged", new DateTimeOffset(new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Unspecified).AddTicks(1635), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(1631), new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(1643), "Unchanged", new DateTimeOffset(new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Unspecified).AddTicks(1645), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(1642), new DateTime(2026, 2, 25, 12, 34, 19, 685, DateTimeKind.Utc).AddTicks(1644) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EntityState",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 771, DateTimeKind.Utc).AddTicks(4540), 0, new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 771, DateTimeKind.Unspecified).AddTicks(7686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 771, DateTimeKind.Utc).AddTicks(3660), new DateTime(2026, 2, 25, 1, 6, 42, 771, DateTimeKind.Utc).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(1237), 0, new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(2821), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(374), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(6994), 0, new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(8949), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(5974), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9879), 0, new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9867), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9908), 0, new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9904), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "EntityState", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9930), 0, new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(9936), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9926), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9933) });
        }
    }
}
