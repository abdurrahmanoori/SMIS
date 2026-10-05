using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddLocalizedTextTranslationShopScope : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopId",
                table: "LocalizedTextTranslation",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000001",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000002",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000003",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000004",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000005",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000006",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000007",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000008",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000009",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000010",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000011",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000012",
                column: "ShopId",
                value: "11111111-0000-0000-0000-000000000003");

            migrationBuilder.Sql(
                """
                UPDATE translation
                SET [ShopId] = category.[ShopId]
                FROM [LocalizedTextTranslation] AS translation
                INNER JOIN [LocalizedText] AS localized_text
                    ON localized_text.[Id] = translation.[LocalizedTextId]
                INNER JOIN [Category] AS category
                    ON category.[NameLocalizedTextId] = localized_text.[Id]
                WHERE translation.[ShopId] IS NULL;
                """);

            migrationBuilder.CreateIndex(
                name: "IX_LocalizedTextTranslation_ShopId",
                table: "LocalizedTextTranslation",
                column: "ShopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LocalizedTextTranslation_ShopId",
                table: "LocalizedTextTranslation");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "LocalizedTextTranslation");
        }
    }
}
