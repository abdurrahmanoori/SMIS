using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class InitialMobileMigration : Migration
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
                    { "1", "BEV", null, new DateTime(2026, 2, 24, 16, 1, 37, 78, DateTimeKind.Utc).AddTicks(9334), "Drinks and beverages", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Unspecified).AddTicks(1166), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 78, DateTimeKind.Utc).AddTicks(8531), "Beverages", "1", null, new DateTime(2026, 2, 24, 16, 1, 37, 78, DateTimeKind.Utc).AddTicks(9971) },
                    { "2", "FOOD", null, new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Utc).AddTicks(4924), "Edible products and snacks", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Unspecified).AddTicks(6437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Utc).AddTicks(3979), "Food Items", "1", null, new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Utc).AddTicks(5704) },
                    { "3", "STAT", null, new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(79), "Office and school supplies", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Unspecified).AddTicks(2375), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 79, DateTimeKind.Utc).AddTicks(9061), "Stationery", "1", null, new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(1003) },
                    { "4", "GROC", null, new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3311), "Daily household items", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Unspecified).AddTicks(3319), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3300), "Grocery", "1", null, new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3315) },
                    { "5", "CARE", null, new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3340), "Health and hygiene products", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Unspecified).AddTicks(3346), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3336), "Personal Care", "1", null, new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3343) },
                    { "6", "ELEC", null, new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3373), "Electronic devices and accessories", 0, true, true, new DateTimeOffset(new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Unspecified).AddTicks(3379), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3370), "Electronics", "1", null, new DateTime(2026, 2, 24, 16, 1, 37, 80, DateTimeKind.Utc).AddTicks(3376) }
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
