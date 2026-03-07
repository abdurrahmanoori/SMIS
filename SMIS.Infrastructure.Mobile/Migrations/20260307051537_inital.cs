using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
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
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TranslationKeys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    MessageCode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
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
                    table.PrimaryKey("PK_TranslationKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    TranslationKeyId = table.Column<string>(type: "TEXT", nullable: false),
                    LanguageNo = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
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
                    table.PrimaryKey("PK_Translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translations_Languages_LanguageNo",
                        column: x => x.LanguageNo,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Translations_TranslationKeys_TranslationKeyId",
                        column: x => x.TranslationKeyId,
                        principalTable: "TranslationKeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "ShopId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(1116), "Drinks and beverages", "Unchanged", true, true, new DateTimeOffset(new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Unspecified).AddTicks(1824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(765), "Beverages", "1", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(1282) },
                    { "2", "FOOD", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(4146), "Edible products and snacks", "Unchanged", true, true, new DateTimeOffset(new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Unspecified).AddTicks(4736), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(3617), "Food Items", "1", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(4481) },
                    { "3", "STAT", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(6479), "Office and school supplies", "Unchanged", true, true, new DateTimeOffset(new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(6032), "Stationery", "1", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(6839) },
                    { "4", "GROC", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(8717), "Daily household items", "Unchanged", true, true, new DateTimeOffset(new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Unspecified).AddTicks(8723), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(8703), "Grocery", "1", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(8720) },
                    { "5", "CARE", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(8734), "Health and hygiene products", "Unchanged", true, true, new DateTimeOffset(new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(8732), "Personal Care", "1", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(8735) },
                    { "6", "ELEC", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(8746), "Electronic devices and accessories", "Unchanged", true, true, new DateTimeOffset(new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Unspecified).AddTicks(8748), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(8744), "Electronics", "1", null, new DateTime(2026, 3, 7, 5, 15, 37, 593, DateTimeKind.Utc).AddTicks(8747) }
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

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                table: "Languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslationKeys_MessageCode",
                table: "TranslationKeys",
                column: "MessageCode");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageNo",
                table: "Translations",
                column: "LanguageNo");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_TranslationKeyId_LanguageNo",
                table: "Translations",
                columns: new[] { "TranslationKeyId", "LanguageNo" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "TranslationKeys");
        }
    }
}
