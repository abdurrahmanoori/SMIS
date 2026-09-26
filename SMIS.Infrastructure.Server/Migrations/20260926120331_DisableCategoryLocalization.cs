using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class DisableCategoryLocalization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_LocalizedText_NameLocalizedTextId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "UX_Category_NameLocalizedTextId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "NameLocalizedTextId",
                table: "Category");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameLocalizedTextId",
                table: "Category",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "UX_Category_NameLocalizedTextId",
                table: "Category",
                column: "NameLocalizedTextId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_LocalizedText_NameLocalizedTextId",
                table: "Category",
                column: "NameLocalizedTextId",
                principalTable: "LocalizedText",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
