using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLegacyTranslationKeysAndTranslations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_TranslationKeys_TranslationKeyId",
                table: "Districts");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "TranslationKeys");

            migrationBuilder.DropIndex(
                name: "IX_Districts_TranslationKeyId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "TranslationKeyId",
                table: "Districts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TranslationKeyId",
                table: "Districts",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TranslationKeys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MessageCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslationKeys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslationKeys_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TranslationKeys_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LanguageNo = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    TranslationKeyId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translations_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Translations_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Translations_Languages_LanguageNo",
                        column: x => x.LanguageNo,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Translations_TranslationKeys_TranslationKeyId",
                        column: x => x.TranslationKeyId,
                        principalTable: "TranslationKeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "TranslationKeyId",
                value: "55555555-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "TranslationKeyId",
                value: "55555555-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "TranslationKeyId",
                value: "55555555-0000-0000-0000-000000000003");

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "55555555-0000-0000-0000-000000000001", null, null, null, "Unchanged", true, false, false, true, "2026-01-01 00:00:00.000000", null, "1001", "Kabul Center District", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000002", null, null, null, "Unchanged", true, false, false, true, "2026-01-01 00:00:00.000000", null, "1002", "Kabul North District", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000003", null, null, null, "Unchanged", true, false, false, true, "2026-01-01 00:00:00.000000", null, "1003", "Herat Center District", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000004", null, null, null, "Unchanged", true, false, false, true, "2026-01-01 00:00:00.000000", null, "2001", "Kabul Province", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000005", null, null, null, "Unchanged", true, false, false, true, "2026-01-01 00:00:00.000000", null, "2002", "Herat Province", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000006", null, null, null, "Unchanged", true, false, false, true, "2026-01-01 00:00:00.000000", null, "3001", "Welcome Message", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000007", null, null, null, "Unchanged", true, false, false, true, "2026-01-01 00:00:00.000000", null, "3002", "Error Message", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000008", null, null, null, "Unchanged", true, false, false, true, "2026-01-01 00:00:00.000000", null, "3003", "Success Message", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LanguageNo", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "66666666-0000-0000-0000-000000000001", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", null, "Kabul Center District", "55555555-0000-0000-0000-000000000001", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000002", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-01-01 00:00:00.000000", null, "منطقه مرکز کابل", "55555555-0000-0000-0000-000000000001", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000003", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", null, "Kabul North District", "55555555-0000-0000-0000-000000000002", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000004", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-01-01 00:00:00.000000", null, "منطقه شمال کابل", "55555555-0000-0000-0000-000000000002", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000005", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", null, "Herat Center District", "55555555-0000-0000-0000-000000000003", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000006", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-01-01 00:00:00.000000", null, "منطقه مرکز هرات", "55555555-0000-0000-0000-000000000003", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000007", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", null, "Kabul Province", "55555555-0000-0000-0000-000000000004", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000008", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-01-01 00:00:00.000000", null, "ولایت کابل", "55555555-0000-0000-0000-000000000004", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000009", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", null, "Herat Province", "55555555-0000-0000-0000-000000000005", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000010", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-01-01 00:00:00.000000", null, "ولایت هرات", "55555555-0000-0000-0000-000000000005", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000011", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", null, "Welcome Message", "55555555-0000-0000-0000-000000000006", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000012", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-01-01 00:00:00.000000", null, "پیام خوش آمدید", "55555555-0000-0000-0000-000000000006", null, null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Districts_TranslationKeyId",
                table: "Districts",
                column: "TranslationKeyId",
                unique: true,
                filter: "[TranslationKeyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TranslationKeys_CreatedBy",
                table: "TranslationKeys",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TranslationKeys_MessageCode",
                table: "TranslationKeys",
                column: "MessageCode");

            migrationBuilder.CreateIndex(
                name: "IX_TranslationKeys_UpdatedBy",
                table: "TranslationKeys",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_CreatedBy",
                table: "Translations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageNo",
                table: "Translations",
                column: "LanguageNo");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_TranslationKeyId_LanguageNo",
                table: "Translations",
                columns: new[] { "TranslationKeyId", "LanguageNo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Translations_UpdatedBy",
                table: "Translations",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_TranslationKeys_TranslationKeyId",
                table: "Districts",
                column: "TranslationKeyId",
                principalTable: "TranslationKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
