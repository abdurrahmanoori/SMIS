using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLegacySyncMetadataGlobally : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_ClientCreatedBy",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_ClientModifiedBy",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ClientCreatedBy",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ClientModifiedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "StockMovement");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "StockMovement");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "StockCountSession");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "StockCountSession");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "StockCountSession");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "StockCountSession");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "StockCountLine");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "StockCountLine");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "StockCountLine");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "StockCountLine");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "StockBatch");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "StockBatch");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "ShopOwner");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "ShopOwner");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "ShopOwner");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "ShopOwner");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "SaleLine");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "SaleLine");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "PurchaseOrderLine");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "PurchaseOrderLine");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "PurchaseOrderLine");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "PurchaseOrderLine");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "ProvinceTranslations");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "LocalizedTextTranslation");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "LocalizedText");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "LoanAccountPayment");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "LoanAccountPayment");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "LoanAccountPayment");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "LoanAccountPayment");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "IdempotencyRecord");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "IdempotencyRecord");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ClientModifiedDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "EntityState",
                table: "AppLogs");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "AppLogs");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "AppLogs");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "AppLogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "Supplier",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Supplier",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Supplier",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Supplier",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "StockMovement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "StockMovement",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "StockCountSession",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "StockCountSession",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "StockCountSession",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "StockCountSession",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "StockCountLine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "StockCountLine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "StockCountLine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "StockCountLine",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "StockBatch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "StockBatch",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "ShopOwner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "ShopOwner",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "ShopOwner",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "ShopOwner",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "SaleLine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "SaleLine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "Sale",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Sale",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "PurchaseOrderLine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "PurchaseOrderLine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "PurchaseOrderLine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "PurchaseOrderLine",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "PurchaseOrder",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "PurchaseOrder",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "PurchaseOrder",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "PurchaseOrder",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "ProvinceTranslations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "Provinces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Provinces",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Provinces",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Provinces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "LocalizedTextTranslation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "LocalizedText",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "LoanAccountPayment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "LoanAccountPayment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "LoanAccountPayment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "LoanAccountPayment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "LoanAccount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "LoanAccount",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "LoanAccount",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "LoanAccount",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "IdempotencyRecord",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "IdempotencyRecord",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "Districts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Districts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Districts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "Customers",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "Customers",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntityState",
                table: "AppLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "AppLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "AppLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "AppLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000001",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000002",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000003",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000004",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000005",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000006",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000007",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000008",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000016",
                column: "EntityState",
                value: "Unchanged");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "EntityState", "IsPublic" },
                values: new object[] { null, null, null, null, "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedText",
                keyColumn: "Id",
                keyValue: "abababab-0000-0000-0000-000000000001",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedText",
                keyColumn: "Id",
                keyValue: "abababab-0000-0000-0000-000000000002",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedText",
                keyColumn: "Id",
                keyValue: "abababab-0000-0000-0000-000000000003",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedText",
                keyColumn: "Id",
                keyValue: "abababab-0000-0000-0000-000000000004",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedText",
                keyColumn: "Id",
                keyValue: "abababab-0000-0000-0000-000000000005",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedText",
                keyColumn: "Id",
                keyValue: "abababab-0000-0000-0000-000000000006",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000001",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000002",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000003",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000004",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000005",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000006",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000007",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000008",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000009",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000010",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000011",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "LocalizedTextTranslation",
                keyColumn: "Id",
                keyValue: "acacacac-0000-0000-0000-000000000012",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                column: "EntityState",
                value: "Added");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000004",
                columns: new[] { "EntityState", "IsPublic", "IsSyncedToServer", "LastSyncedAt" },
                values: new object[] { "Unchanged", false, true, null });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "EntityState", "IsPublic" },
                values: new object[] { "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "EntityState", "IsPublic" },
                values: new object[] { "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "EntityState", "IsPublic" },
                values: new object[] { "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "EntityState", "IsPublic" },
                values: new object[] { "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                columns: new[] { "EntityState", "IsPublic" },
                values: new object[] { "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                columns: new[] { "EntityState", "IsPublic" },
                values: new object[] { "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                columns: new[] { "EntityState", "IsPublic" },
                values: new object[] { "Unchanged", false });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                columns: new[] { "EntityState", "IsPublic" },
                values: new object[] { "Unchanged", false });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ClientCreatedBy",
                table: "Customers",
                column: "ClientCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ClientModifiedBy",
                table: "Customers",
                column: "ClientModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_ClientCreatedBy",
                table: "Customers",
                column: "ClientCreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_ClientModifiedBy",
                table: "Customers",
                column: "ClientModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
