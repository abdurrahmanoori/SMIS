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
        migrationBuilder.Sql("""
            IF EXISTS (
                SELECT 1
                FROM [ProductUnit]
                GROUP BY [ProductId], [UnitOfMeasureId]
                HAVING COUNT(*) > 1
            )
                THROW 50001, 'Cannot enforce UNIQUE(ProductId, UnitOfMeasureId) because duplicate ProductUnit pairs exist.', 1;
            """);

        migrationBuilder.RenameColumn(
            name: "ConversionFactor",
            table: "ProductUnit",
            newName: "BaseUnitQuantity");

        migrationBuilder.DropIndex(
            name: "IX_ProductUnit_ProductId",
            table: "ProductUnit");

        migrationBuilder.AddUniqueConstraint(
            name: "AK_ProductUnit_ProductId_UnitOfMeasureId",
            table: "ProductUnit",
            columns: new[] { "ProductId", "UnitOfMeasureId" });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropUniqueConstraint(
            name: "AK_ProductUnit_ProductId_UnitOfMeasureId",
            table: "ProductUnit");

        migrationBuilder.CreateIndex(
            name: "IX_ProductUnit_ProductId",
            table: "ProductUnit",
            column: "ProductId");

        migrationBuilder.RenameColumn(
            name: "BaseUnitQuantity",
            table: "ProductUnit",
            newName: "ConversionFactor");
    }
}
