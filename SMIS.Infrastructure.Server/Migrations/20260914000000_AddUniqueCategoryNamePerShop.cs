using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SMIS.Infrastructure.Server.Context;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20260914000000_AddUniqueCategoryNamePerShop")]
public partial class AddUniqueCategoryNamePerShop : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateIndex(
            name: "UX_Category_ShopId_Name",
            table: "Category",
            columns: new[] { "ShopId", "Name" },
            unique: true,
            filter: "[IsDeleted] = 0");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropIndex(
            name: "UX_Category_ShopId_Name",
            table: "Category");
    }
}
