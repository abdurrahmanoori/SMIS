using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLegacySyncMetadataFromFlutterEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_AspNetUsers_ClientCreatedBy",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_AspNetUsers_ClientModifiedBy",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_ClientCreatedBy",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_ClientModifiedBy",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_AspNetUsers_ClientCreatedBy",
                table: "ProductPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_AspNetUsers_ClientModifiedBy",
                table: "ProductPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_AspNetUsers_ClientCreatedBy",
                table: "ProductUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_AspNetUsers_ClientModifiedBy",
                table: "ProductUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_AspNetUsers_ClientCreatedBy",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_AspNetUsers_ClientModifiedBy",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitOfMeasure_AspNetUsers_ClientCreatedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitOfMeasure_AspNetUsers_ClientModifiedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropIndex(
                name: "IX_UnitOfMeasure_ClientCreatedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropIndex(
                name: "IX_UnitOfMeasure_ClientModifiedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropIndex(
                name: "IX_Shop_ClientCreatedBy",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Shop_ClientModifiedBy",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_ProductUnit_ClientCreatedBy",
                table: "ProductUnit");

            migrationBuilder.DropIndex(
                name: "IX_ProductUnit_ClientModifiedBy",
                table: "ProductUnit");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_ClientCreatedBy",
                table: "ProductPrice");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_ClientModifiedBy",
                table: "ProductPrice");

            migrationBuilder.DropIndex(
                name: "IX_Product_ClientCreatedBy",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ClientModifiedBy",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Category_ClientCreatedBy",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ClientModifiedBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Category");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "UnitOfMeasure",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "UnitOfMeasure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "UnitOfMeasure",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "UnitOfMeasure",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "UnitOfMeasure",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "UnitOfMeasure",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "UnitOfMeasure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "Shop",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "Shop",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "Shop",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Shop",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "ProductUnit",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "ProductUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "ProductUnit",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "ProductUnit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "ProductUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "ProductUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "ProductUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "ProductPrice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "ProductPrice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "ProductPrice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "ProductPrice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "ProductPrice",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "ProductPrice",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "ProductPrice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "Product",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "Product",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "Category",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "Category",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "Category",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { null, null, null, "Unchanged", false, true, null });

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfMeasure_ClientCreatedBy",
                table: "UnitOfMeasure",
                column: "ClientCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfMeasure_ClientModifiedBy",
                table: "UnitOfMeasure",
                column: "ClientModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_ClientCreatedBy",
                table: "Shop",
                column: "ClientCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_ClientModifiedBy",
                table: "Shop",
                column: "ClientModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_ClientCreatedBy",
                table: "ProductUnit",
                column: "ClientCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_ClientModifiedBy",
                table: "ProductUnit",
                column: "ClientModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ClientCreatedBy",
                table: "ProductPrice",
                column: "ClientCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ClientModifiedBy",
                table: "ProductPrice",
                column: "ClientModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ClientCreatedBy",
                table: "Product",
                column: "ClientCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ClientModifiedBy",
                table: "Product",
                column: "ClientModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ClientCreatedBy",
                table: "Category",
                column: "ClientCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ClientModifiedBy",
                table: "Category",
                column: "ClientModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_AspNetUsers_ClientCreatedBy",
                table: "Category",
                column: "ClientCreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_AspNetUsers_ClientModifiedBy",
                table: "Category",
                column: "ClientModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_ClientCreatedBy",
                table: "Product",
                column: "ClientCreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_ClientModifiedBy",
                table: "Product",
                column: "ClientModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_AspNetUsers_ClientCreatedBy",
                table: "ProductPrice",
                column: "ClientCreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_AspNetUsers_ClientModifiedBy",
                table: "ProductPrice",
                column: "ClientModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_AspNetUsers_ClientCreatedBy",
                table: "ProductUnit",
                column: "ClientCreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_AspNetUsers_ClientModifiedBy",
                table: "ProductUnit",
                column: "ClientModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_AspNetUsers_ClientCreatedBy",
                table: "Shop",
                column: "ClientCreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_AspNetUsers_ClientModifiedBy",
                table: "Shop",
                column: "ClientModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitOfMeasure_AspNetUsers_ClientCreatedBy",
                table: "UnitOfMeasure",
                column: "ClientCreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitOfMeasure_AspNetUsers_ClientModifiedBy",
                table: "UnitOfMeasure",
                column: "ClientModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
