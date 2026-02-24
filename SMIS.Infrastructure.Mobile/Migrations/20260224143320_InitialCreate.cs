using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    EntityState = table.Column<int>(type: "INTEGER", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "ShopId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(7188), "Drinks and beverages", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(6372), "Beverages", "1", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(7188) },
                    { "2", "FOOD", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8452), "Edible products and snacks", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Unspecified).AddTicks(8452), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8449), "Food Items", "1", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8453) },
                    { "3", "STAT", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8455), "Office and school supplies", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Unspecified).AddTicks(8454), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8454), "Stationery", "1", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8455) },
                    { "4", "GROC", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8456), "Daily household items", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Unspecified).AddTicks(8456), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8456), "Grocery", "1", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8457) },
                    { "5", "CARE", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8458), "Health and hygiene products", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8458), "Personal Care", "1", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8459) },
                    { "6", "ELEC", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8460), "Electronic devices and accessories", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Unspecified).AddTicks(8460), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8459), "Electronics", "1", null, new DateTime(2026, 2, 24, 14, 33, 19, 845, DateTimeKind.Utc).AddTicks(8460) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Code",
                table: "Categories",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IsSyncedToServer",
                table: "Categories",
                column: "IsSyncedToServer");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_LastModifiedUtc",
                table: "Categories",
                column: "LastModifiedUtc");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ShopId",
                table: "Categories",
                column: "ShopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
