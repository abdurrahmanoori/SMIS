using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SMIS.Infrastructure.Server.Context;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20260914031055_EnforceForeignKeyRelationships")]
public partial class EnforceForeignKeyRelationships : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        var auditedTables = new[]
        {
            "Category",
            "Customers",
            "Districts",
            "LoanAccount",
            "LoanAccountPayment",
            "Product",
            "ProductPrice",
            "ProductUnit",
            "Provinces",
            "Shop",
            "ShopOwner",
            "StockBatch",
            "StockTransaction",
            "TranslationKeys",
            "Translations",
            "UnitOfMeasure"
        };

        foreach (var table in auditedTables)
        {
            migrationBuilder.Sql($"""
                UPDATE entity
                SET CreatedBy = NULL
                FROM [{table}] AS entity
                LEFT JOIN AspNetUsers AS users ON users.Id = entity.CreatedBy
                WHERE entity.CreatedBy IS NOT NULL
                  AND users.Id IS NULL;

                UPDATE entity
                SET UpdatedBy = NULL
                FROM [{table}] AS entity
                LEFT JOIN AspNetUsers AS users ON users.Id = entity.UpdatedBy
                WHERE entity.UpdatedBy IS NOT NULL
                  AND users.Id IS NULL;
                """);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: table,
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: table,
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: $"IX_{table}_CreatedBy",
                table: table,
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: $"IX_{table}_UpdatedBy",
                table: table,
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: $"FK_{table}_AspNetUsers_CreatedBy",
                table: table,
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: $"FK_{table}_AspNetUsers_UpdatedBy",
                table: table,
                column: "UpdatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        migrationBuilder.Sql("""
            UPDATE customer
            SET DeletedBy = NULL
            FROM Customers AS customer
            LEFT JOIN AspNetUsers AS users ON users.Id = customer.DeletedBy
            WHERE customer.DeletedBy IS NOT NULL
              AND users.Id IS NULL;
            """);

        migrationBuilder.AlterColumn<string>(
            name: "DeletedBy",
            table: "Customers",
            type: "nvarchar(450)",
            maxLength: 450,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)",
            oldNullable: true);

        migrationBuilder.CreateIndex(
            name: "IX_Customers_DeletedBy",
            table: "Customers",
            column: "DeletedBy");

        migrationBuilder.AddForeignKey(
            name: "FK_Customers_AspNetUsers_DeletedBy",
            table: "Customers",
            column: "DeletedBy",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Restrict);

        migrationBuilder.Sql("""
            UPDATE l
            SET l.UserId = NULL
            FROM AppLogs AS l
            LEFT JOIN AspNetUsers AS u ON u.Id = l.UserId
            WHERE l.UserId IS NOT NULL
              AND u.Id IS NULL;
            """);

        migrationBuilder.Sql("""
            UPDATE so
            SET so.ProvinceId = NULL
            FROM ShopOwner AS so
            LEFT JOIN Provinces AS p ON p.Id = so.ProvinceId
            WHERE so.ProvinceId IS NOT NULL
              AND p.Id IS NULL;
            """);

        migrationBuilder.Sql("""
            UPDATE so
            SET so.DistrictId = NULL
            FROM ShopOwner AS so
            LEFT JOIN Districts AS d ON d.Id = so.DistrictId
            WHERE so.DistrictId IS NOT NULL
              AND d.Id IS NULL;
            """);

        migrationBuilder.AlterColumn<string>(
            name: "ProvinceId",
            table: "ShopOwner",
            type: "nvarchar(450)",
            maxLength: 450,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(50)",
            oldMaxLength: 50,
            oldNullable: true);

        migrationBuilder.AlterColumn<string>(
            name: "DistrictId",
            table: "ShopOwner",
            type: "nvarchar(450)",
            maxLength: 450,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(50)",
            oldMaxLength: 50,
            oldNullable: true);

        migrationBuilder.CreateIndex(
            name: "IX_ShopOwner_DistrictId",
            table: "ShopOwner",
            column: "DistrictId");

        migrationBuilder.CreateIndex(
            name: "IX_ShopOwner_ProvinceId",
            table: "ShopOwner",
            column: "ProvinceId");

        migrationBuilder.AddForeignKey(
            name: "FK_AppLogs_AspNetUsers_UserId",
            table: "AppLogs",
            column: "UserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.SetNull);

        migrationBuilder.AddForeignKey(
            name: "FK_ShopOwner_Districts_DistrictId",
            table: "ShopOwner",
            column: "DistrictId",
            principalTable: "Districts",
            principalColumn: "Id",
            onDelete: ReferentialAction.SetNull);

        migrationBuilder.AddForeignKey(
            name: "FK_ShopOwner_Provinces_ProvinceId",
            table: "ShopOwner",
            column: "ProvinceId",
            principalTable: "Provinces",
            principalColumn: "Id",
            onDelete: ReferentialAction.SetNull);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        var auditedTables = new[]
        {
            "Category",
            "Customers",
            "Districts",
            "LoanAccount",
            "LoanAccountPayment",
            "Product",
            "ProductPrice",
            "ProductUnit",
            "Provinces",
            "Shop",
            "ShopOwner",
            "StockBatch",
            "StockTransaction",
            "TranslationKeys",
            "Translations",
            "UnitOfMeasure"
        };

        migrationBuilder.DropForeignKey(
            name: "FK_Customers_AspNetUsers_DeletedBy",
            table: "Customers");

        migrationBuilder.DropIndex(
            name: "IX_Customers_DeletedBy",
            table: "Customers");

        migrationBuilder.AlterColumn<string>(
            name: "DeletedBy",
            table: "Customers",
            type: "nvarchar(max)",
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(450)",
            oldMaxLength: 450,
            oldNullable: true);

        foreach (var table in auditedTables)
        {
            migrationBuilder.DropForeignKey(
                name: $"FK_{table}_AspNetUsers_CreatedBy",
                table: table);

            migrationBuilder.DropForeignKey(
                name: $"FK_{table}_AspNetUsers_UpdatedBy",
                table: table);

            migrationBuilder.DropIndex(
                name: $"IX_{table}_CreatedBy",
                table: table);

            migrationBuilder.DropIndex(
                name: $"IX_{table}_UpdatedBy",
                table: table);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: table,
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: table,
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);
        }

        migrationBuilder.DropForeignKey(
            name: "FK_AppLogs_AspNetUsers_UserId",
            table: "AppLogs");

        migrationBuilder.DropForeignKey(
            name: "FK_ShopOwner_Districts_DistrictId",
            table: "ShopOwner");

        migrationBuilder.DropForeignKey(
            name: "FK_ShopOwner_Provinces_ProvinceId",
            table: "ShopOwner");

        migrationBuilder.DropIndex(
            name: "IX_ShopOwner_DistrictId",
            table: "ShopOwner");

        migrationBuilder.DropIndex(
            name: "IX_ShopOwner_ProvinceId",
            table: "ShopOwner");

        migrationBuilder.AlterColumn<string>(
            name: "ProvinceId",
            table: "ShopOwner",
            type: "nvarchar(50)",
            maxLength: 50,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(450)",
            oldMaxLength: 450,
            oldNullable: true);

        migrationBuilder.AlterColumn<string>(
            name: "DistrictId",
            table: "ShopOwner",
            type: "nvarchar(50)",
            maxLength: 50,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(450)",
            oldMaxLength: 450,
            oldNullable: true);
    }
}

