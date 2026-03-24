using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class softmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Translations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Translations",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "TranslationKeys",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TranslationKeys",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Categories",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1192), null, false, new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1340), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(987), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1465), null, false, new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1466), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1464), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1473), null, false, new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1473), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1472), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1485), null, false, new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1485), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1484), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1489), null, false, new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1490), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1489), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DeletedAt", "IsDeleted", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1495), null, false, new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1495), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1494), new DateTime(2026, 3, 24, 9, 53, 12, 562, DateTimeKind.Local).AddTicks(1495) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(1960), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2259), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(1720), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2415), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2415), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2414), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2428), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2429), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2428), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2434), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2434), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2433), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2439), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2439), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2438), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2443), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2444), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2443), new DateTime(2026, 3, 23, 13, 43, 57, 7, DateTimeKind.Local).AddTicks(2444) });
        }
    }
}
