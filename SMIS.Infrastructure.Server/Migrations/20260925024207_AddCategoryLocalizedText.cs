using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryLocalizedText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add the FK column as nullable first. Existing production categories need
            // their own LocalizedText row before the relationship can become required.
            migrationBuilder.AddColumn<string>(
                name: "NameLocalizedTextId",
                table: "Category",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LocalizedText",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DefaultValue = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizedText", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalizedTextTranslation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocalizedTextId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    LanguageId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizedTextTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalizedTextTranslation_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocalizedTextTranslation_LocalizedText_LocalizedTextId",
                        column: x => x.LocalizedTextId,
                        principalTable: "LocalizedText",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LocalizedText",
                columns: new[] { "Id", "DefaultValue", "EntityState", "LastModifiedUtc", "Version" },
                values: new object[,]
                {
                    { "abababab-0000-0000-0000-000000000001", "Beverages", "Added", "2026-01-01 00:00:00.000000", 0 },
                    { "abababab-0000-0000-0000-000000000002", "Food Items", "Added", "2026-01-01 00:00:00.000000", 0 },
                    { "abababab-0000-0000-0000-000000000003", "Stationery", "Added", "2026-01-01 00:00:00.000000", 0 },
                    { "abababab-0000-0000-0000-000000000004", "Grocery", "Added", "2026-01-01 00:00:00.000000", 0 },
                    { "abababab-0000-0000-0000-000000000005", "Personal Care", "Added", "2026-01-01 00:00:00.000000", 0 },
                    { "abababab-0000-0000-0000-000000000006", "Electronics", "Added", "2026-01-01 00:00:00.000000", 0 }
                });

            migrationBuilder.InsertData(
                table: "LocalizedTextTranslation",
                columns: new[] { "Id", "EntityState", "LanguageId", "LastModifiedUtc", "LocalizedTextId", "Value", "Version" },
                values: new object[,]
                {
                    { "acacacac-0000-0000-0000-000000000001", "Added", "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000001", "Beverages", 0 },
                    { "acacacac-0000-0000-0000-000000000002", "Added", "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000002", "Food Items", 0 },
                    { "acacacac-0000-0000-0000-000000000003", "Added", "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000003", "Stationery", 0 },
                    { "acacacac-0000-0000-0000-000000000004", "Added", "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000004", "Grocery", 0 },
                    { "acacacac-0000-0000-0000-000000000005", "Added", "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000005", "Personal Care", 0 },
                    { "acacacac-0000-0000-0000-000000000006", "Added", "22222222-0000-0000-0000-000000000001", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000006", "Electronics", 0 },
                    { "acacacac-0000-0000-0000-000000000007", "Added", "22222222-0000-0000-0000-000000000003", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000001", "نوشیدنی‌ها", 0 },
                    { "acacacac-0000-0000-0000-000000000008", "Added", "22222222-0000-0000-0000-000000000003", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000002", "مواد غذایی", 0 },
                    { "acacacac-0000-0000-0000-000000000009", "Added", "22222222-0000-0000-0000-000000000003", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000003", "لوازم تحریر", 0 },
                    { "acacacac-0000-0000-0000-000000000010", "Added", "22222222-0000-0000-0000-000000000003", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000004", "مواد خوراکی", 0 },
                    { "acacacac-0000-0000-0000-000000000011", "Added", "22222222-0000-0000-0000-000000000003", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000005", "مراقبت شخصی", 0 },
                    { "acacacac-0000-0000-0000-000000000012", "Added", "22222222-0000-0000-0000-000000000003", "2026-01-01 00:00:00.000000", "abababab-0000-0000-0000-000000000006", "وسایل الکترونیکی", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                column: "NameLocalizedTextId",
                value: "abababab-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                column: "NameLocalizedTextId",
                value: "abababab-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                column: "NameLocalizedTextId",
                value: "abababab-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                column: "NameLocalizedTextId",
                value: "abababab-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                column: "NameLocalizedTextId",
                value: "abababab-0000-0000-0000-000000000005");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                column: "NameLocalizedTextId",
                value: "abababab-0000-0000-0000-000000000006");

            // Backfill every non-seeded production category with its own localized
            // text aggregate. English is the source/default value during the POC.
            migrationBuilder.Sql(
                """
                UPDATE [Category]
                SET [NameLocalizedTextId] = LOWER(CONVERT(nvarchar(36), NEWID()))
                WHERE [NameLocalizedTextId] IS NULL;

                INSERT INTO [LocalizedText] ([Id], [DefaultValue], [Version], [EntityState], [LastModifiedUtc])
                SELECT
                    c.[NameLocalizedTextId],
                    c.[Name],
                    0,
                    N'Added',
                    c.[LastModifiedUtc]
                FROM [Category] c
                WHERE NOT EXISTS (
                    SELECT 1
                    FROM [LocalizedText] lt
                    WHERE lt.[Id] = c.[NameLocalizedTextId]
                );

                INSERT INTO [LocalizedTextTranslation]
                    ([Id], [LocalizedTextId], [LanguageId], [Value], [Version], [EntityState], [LastModifiedUtc])
                SELECT
                    LOWER(CONVERT(nvarchar(36), NEWID())),
                    c.[NameLocalizedTextId],
                    N'22222222-0000-0000-0000-000000000001',
                    c.[Name],
                    0,
                    N'Added',
                    c.[LastModifiedUtc]
                FROM [Category] c
                WHERE NOT EXISTS (
                    SELECT 1
                    FROM [LocalizedTextTranslation] t
                    WHERE t.[LocalizedTextId] = c.[NameLocalizedTextId]
                      AND t.[LanguageId] = N'22222222-0000-0000-0000-000000000001'
                );
                """);

            migrationBuilder.AlterColumn<string>(
                name: "NameLocalizedTextId",
                table: "Category",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "UX_Category_NameLocalizedTextId",
                table: "Category",
                column: "NameLocalizedTextId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocalizedTextTranslation_LanguageId",
                table: "LocalizedTextTranslation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalizedTextTranslation_LocalizedTextId_LanguageId",
                table: "LocalizedTextTranslation",
                columns: new[] { "LocalizedTextId", "LanguageId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_LocalizedText_NameLocalizedTextId",
                table: "Category",
                column: "NameLocalizedTextId",
                principalTable: "LocalizedText",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_LocalizedText_NameLocalizedTextId",
                table: "Category");

            migrationBuilder.DropTable(
                name: "LocalizedTextTranslation");

            migrationBuilder.DropTable(
                name: "LocalizedText");

            migrationBuilder.DropIndex(
                name: "UX_Category_NameLocalizedTextId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "NameLocalizedTextId",
                table: "Category");
        }
    }
}
