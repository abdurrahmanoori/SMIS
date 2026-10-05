using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class MakeProductSkuNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UX_Product_ShopId_SKU_Active",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Product",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "UX_Product_ShopId_SKU_Active",
                table: "Product",
                columns: new[] { "ShopId", "SKU" },
                unique: true,
                filter: "[IsDeleted] = 0 AND [SKU] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UX_Product_ShopId_SKU_Active",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Product",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "UX_Product_ShopId_SKU_Active",
                table: "Product",
                columns: new[] { "ShopId", "SKU" },
                unique: true,
                filter: "[IsDeleted] = 0");
        }
    }
}
