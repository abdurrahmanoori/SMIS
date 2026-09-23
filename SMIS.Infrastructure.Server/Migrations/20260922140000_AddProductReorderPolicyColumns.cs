using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SMIS.Infrastructure.Server.Context;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20260922140000_AddProductReorderPolicyColumns")]
public partial class AddProductReorderPolicyColumns : Migration
{
    protected override void Up(
        MigrationBuilder migrationBuilder
    )
    {
        migrationBuilder.AddColumn<decimal>(
            name: "ReorderPointBase",
            table: "Product",
            type: "decimal(18,4)",
            precision: 18,
            scale: 4,
            nullable: false,
            defaultValue: 0m);

        migrationBuilder.AddColumn<decimal>(
            name: "ReorderQuantityBase",
            table: "Product",
            type: "decimal(18,4)",
            precision: 18,
            scale: 4,
            nullable: false,
            defaultValue: 0m);
    }

    protected override void Down(
        MigrationBuilder migrationBuilder
    )
    {
        migrationBuilder.DropColumn(
            name: "ReorderPointBase",
            table: "Product");

        migrationBuilder.DropColumn(
            name: "ReorderQuantityBase",
            table: "Product");
    }
}
