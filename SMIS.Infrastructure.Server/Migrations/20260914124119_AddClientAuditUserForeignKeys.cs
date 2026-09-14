using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddClientAuditUserForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var clientAuditedTables = new[]
            {
                "Category",
                "Customers",
                "Product",
                "ProductPrice",
                "ProductUnit",
                "Shop",
                "UnitOfMeasure"
            };

            foreach (var table in clientAuditedTables)
            {
                migrationBuilder.Sql($"""
                    UPDATE entity
                    SET ClientCreatedBy = NULL
                    FROM [{table}] AS entity
                    LEFT JOIN AspNetUsers AS users ON users.Id = entity.ClientCreatedBy
                    WHERE entity.ClientCreatedBy IS NOT NULL
                      AND users.Id IS NULL;

                    UPDATE entity
                    SET ClientModifiedBy = NULL
                    FROM [{table}] AS entity
                    LEFT JOIN AspNetUsers AS users ON users.Id = entity.ClientModifiedBy
                    WHERE entity.ClientModifiedBy IS NOT NULL
                      AND users.Id IS NULL;
                    """);
            }

            migrationBuilder.AlterColumn<string>(
                name: "ClientModifiedBy",
                table: "Shop",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientCreatedBy",
                table: "Shop",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            foreach (var table in clientAuditedTables)
            {
                migrationBuilder.CreateIndex(
                    name: $"IX_{table}_ClientCreatedBy",
                    table: table,
                    column: "ClientCreatedBy");

                migrationBuilder.CreateIndex(
                    name: $"IX_{table}_ClientModifiedBy",
                    table: table,
                    column: "ClientModifiedBy");

                migrationBuilder.AddForeignKey(
                    name: $"FK_{table}_AspNetUsers_ClientCreatedBy",
                    table: table,
                    column: "ClientCreatedBy",
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);

                migrationBuilder.AddForeignKey(
                    name: $"FK_{table}_AspNetUsers_ClientModifiedBy",
                    table: table,
                    column: "ClientModifiedBy",
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var clientAuditedTables = new[]
            {
                "Category",
                "Customers",
                "Product",
                "ProductPrice",
                "ProductUnit",
                "Shop",
                "UnitOfMeasure"
            };

            foreach (var table in clientAuditedTables)
            {
                migrationBuilder.DropForeignKey(
                    name: $"FK_{table}_AspNetUsers_ClientCreatedBy",
                    table: table);

                migrationBuilder.DropForeignKey(
                    name: $"FK_{table}_AspNetUsers_ClientModifiedBy",
                    table: table);

                migrationBuilder.DropIndex(
                    name: $"IX_{table}_ClientCreatedBy",
                    table: table);

                migrationBuilder.DropIndex(
                    name: $"IX_{table}_ClientModifiedBy",
                    table: table);
            }

            migrationBuilder.AlterColumn<string>(
                name: "ClientModifiedBy",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientCreatedBy",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);
        }
    }
}
