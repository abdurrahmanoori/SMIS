using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SMIS.Infrastructure.Server.Context;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20260915070000_RenameProductUnitBaseUnitQuantityAndEnforceUniquePair")]
public partial class RenameProductUnitBaseUnitQuantityAndEnforceUniquePair : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "ConversionFactor",
            table: "ProductUnit",
            newName: "BaseUnitQuantity");

        migrationBuilder.CreateIndex(
            name: "IX_ProductUnit_ProductId_UnitOfMeasureId",
            table: "ProductUnit",
            columns: new[] { "ProductId", "UnitOfMeasureId" },
            unique: true,
            filter: "[IsDeleted] = 0");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropIndex(
            name: "IX_ProductUnit_ProductId_UnitOfMeasureId",
            table: "ProductUnit");

        migrationBuilder.RenameColumn(
            name: "BaseUnitQuantity",
            table: "ProductUnit",
            newName: "ConversionFactor");
    }
}
