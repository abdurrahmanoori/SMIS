using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class SyncCurrentModelAndRestrictDeletes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppLogs_AspNetUsers_UserId",
                table: "AppLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Languages_LanguageId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Districts_DistrictId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Provinces_ProvinceId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_TranslationKeys_TranslationKeyId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanAccountPayment_LoanAccount_LoanAccountId",
                table: "LoanAccountPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_Product_ProductId",
                table: "ProductUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_UnitOfMeasure_UnitOfMeasureId",
                table: "ProductUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvinceTranslations_Provinces_ProvinceId",
                table: "ProvinceTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopOwner_Districts_DistrictId",
                table: "ShopOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopOwner_Provinces_ProvinceId",
                table: "ShopOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_TranslationKeys_TranslationKeyId",
                table: "Translations");

            migrationBuilder.AddColumn<string>(
                name: "OperationId",
                table: "StockMovement",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ReturnedQuantityEntered",
                table: "SaleLine",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "ReturnedAmount",
                table: "Sale",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Sale",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "CreditAmount",
                table: "LoanAccount",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "IdempotencyRecord",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActorId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Scope = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdempotencyRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdempotencyRecord_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IdempotencyRecord_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockCountSession",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    StartedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCountSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockCountSession_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockCountSession_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockCountSession_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supplier_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Supplier_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Supplier_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockCountLine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StockCountSessionId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    StockBatchId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ExpectedQuantityBase = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    CountedQuantityBase = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    DifferenceBase = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCountLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockCountLine_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockCountLine_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockCountLine_StockBatch_StockBatchId",
                        column: x => x.StockBatchId,
                        principalTable: "StockBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockCountLine_StockCountSession_StockCountSessionId",
                        column: x => x.StockCountSessionId,
                        principalTable: "StockCountSession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SupplierId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OrderedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderLine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PurchaseOrderId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductUnitId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    OrderedQuantityEntered = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    ReceivedQuantityEntered = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    ReturnedQuantityEntered = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    UnitCostBase = table.Column<long>(type: "bigint", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderLine_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderLine_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderLine_ProductUnit_ProductUnitId_ProductId",
                        columns: x => new { x.ProductUnitId, x.ProductId },
                        principalTable: "ProductUnit",
                        principalColumns: new[] { "Id", "ProductId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderLine_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderLine_PurchaseOrder_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6389), "2026-09-23 06:36:54.794649", new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6515), "2026-09-23 06:36:54.794651", new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6522), "2026-09-23 06:36:54.794652", new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6528), "2026-09-23 06:36:54.794652", new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6534), "2026-09-23 06:36:54.794653", new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6539), "2026-09-23 06:36:54.794653", new DateTime(2026, 9, 23, 6, 36, 54, 794, DateTimeKind.Utc).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 803, DateTimeKind.Utc).AddTicks(6748), "2026-09-23 06:36:54.803692", new DateTime(2026, 9, 23, 6, 36, 54, 803, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 803, DateTimeKind.Utc).AddTicks(8104), "2026-09-23 06:36:54.803876", new DateTime(2026, 9, 23, 6, 36, 54, 803, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 803, DateTimeKind.Utc).AddTicks(9814), "2026-09-23 06:36:54.804068", new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1028), "2026-09-23 06:36:54.804103", new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1048), "2026-09-23 06:36:54.804105", new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1064), "2026-09-23 06:36:54.804106", new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1079), "2026-09-23 06:36:54.804108", new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1093), "2026-09-23 06:36:54.804109", new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1106), "2026-09-23 06:36:54.804111", new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1124), "2026-09-23 06:36:54.804112", new DateTime(2026, 9, 23, 6, 36, 54, 804, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788674");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788694");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788695");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787343");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787388");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787389");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(364), "2026-09-23 06:36:54.798059", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(2715), "2026-09-23 06:36:54.798341", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(4948), "2026-09-23 06:36:54.798589", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6228), "2026-09-23 06:36:54.798623", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6249), "2026-09-23 06:36:54.798625", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6265), "2026-09-23 06:36:54.798626", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6282), "2026-09-23 06:36:54.798628", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6307), "2026-09-23 06:36:54.798631", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6323), "2026-09-23 06:36:54.798632", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6338), "2026-09-23 06:36:54.798634", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6353), "2026-09-23 06:36:54.798636", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6379), "2026-09-23 06:36:54.798638", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6394), "2026-09-23 06:36:54.798639", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6409), "2026-09-23 06:36:54.798641", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6423), "2026-09-23 06:36:54.798642", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6440), "2026-09-23 06:36:54.798644", new DateTime(2026, 9, 23, 6, 36, 54, 798, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(984), "2026-09-23 06:36:54.802112", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(2776), "2026-09-23 06:36:54.802379", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(4839), "2026-09-23 06:36:54.802586", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6346), "2026-09-23 06:36:54.802635", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6360), "2026-09-23 06:36:54.802636", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6373), "2026-09-23 06:36:54.802637", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6383), "2026-09-23 06:36:54.802638", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6393), "2026-09-23 06:36:54.802639", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6409), "2026-09-23 06:36:54.802641", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6422), "2026-09-23 06:36:54.802642", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6431), "2026-09-23 06:36:54.802643", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6441), "2026-09-23 06:36:54.802644", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6450), "2026-09-23 06:36:54.802645", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6459), "2026-09-23 06:36:54.802646", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6468), "2026-09-23 06:36:54.802647", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6477), "2026-09-23 06:36:54.802648", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6499), "2026-09-23 06:36:54.802650", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6509), "2026-09-23 06:36:54.802651", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6518), "2026-09-23 06:36:54.802652", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6528), "2026-09-23 06:36:54.802653", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6536), "2026-09-23 06:36:54.802653", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6545), "2026-09-23 06:36:54.802654", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6555), "2026-09-23 06:36:54.802655", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6563), "2026-09-23 06:36:54.802656", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6574), "2026-09-23 06:36:54.802657", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6583), "2026-09-23 06:36:54.802658", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6592), "2026-09-23 06:36:54.802659", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6602), "2026-09-23 06:36:54.802660", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6611), "2026-09-23 06:36:54.802661", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6621), "2026-09-23 06:36:54.802662", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6630), "2026-09-23 06:36:54.802663", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6638), "2026-09-23 06:36:54.802664", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6649), "2026-09-23 06:36:54.802665", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6664), "2026-09-23 06:36:54.802666", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6673), "2026-09-23 06:36:54.802667", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6683), "2026-09-23 06:36:54.802668", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6691), "2026-09-23 06:36:54.802669", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6700), "2026-09-23 06:36:54.802670", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6709), "2026-09-23 06:36:54.802671", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6717), "2026-09-23 06:36:54.802672", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6727), "2026-09-23 06:36:54.802673", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6736), "2026-09-23 06:36:54.802673", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6745), "2026-09-23 06:36:54.802674", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6755), "2026-09-23 06:36:54.802675", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6764), "2026-09-23 06:36:54.802676", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6772), "2026-09-23 06:36:54.802677", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6782), "2026-09-23 06:36:54.802678", new DateTime(2026, 9, 23, 6, 36, 54, 802, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800155");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800247");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800361");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800418");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800419");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800420");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800421");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800423");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800424");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800425");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800425");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800427");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800428");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800429");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800430");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800431");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800432");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800433");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800433");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800434");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800435");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800436");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800437");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800438");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800439");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800440");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800441");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800441");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800442");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800443");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800445");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800446");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800447");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800447");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800448");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800449");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800450");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800451");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800452");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800453");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800454");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800454");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800455");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800456");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800457");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800458");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.800459");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788496");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788547");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788547");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788548");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788549");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788549");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788549");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788550");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788550");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788551");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788551");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788552");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788432");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788449");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788450");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788450");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 792, DateTimeKind.Utc).AddTicks(4813), "2026-09-23 06:36:54.792551", new DateTime(2026, 9, 23, 6, 36, 54, 792, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 792, DateTimeKind.Utc).AddTicks(6749), "2026-09-23 06:36:54.792750", new DateTime(2026, 9, 23, 6, 36, 54, 792, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 792, DateTimeKind.Utc).AddTicks(8280), "2026-09-23 06:36:54.792925", new DateTime(2026, 9, 23, 6, 36, 54, 792, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 792, DateTimeKind.Utc).AddTicks(9612), "2026-09-23 06:36:54.792961", new DateTime(2026, 9, 23, 6, 36, 54, 792, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 806, DateTimeKind.Utc).AddTicks(3017), "2026-09-23 06:36:54.806320", new DateTime(2026, 9, 23, 11, 6, 54, 804, DateTimeKind.Local).AddTicks(6134), new DateTime(2026, 9, 23, 6, 36, 54, 806, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 806, DateTimeKind.Utc).AddTicks(4664), "2026-09-23 06:36:54.806531", new DateTime(2026, 9, 23, 11, 6, 54, 806, DateTimeKind.Local).AddTicks(3223), new DateTime(2026, 9, 23, 6, 36, 54, 806, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 806, DateTimeKind.Utc).AddTicks(6422), "2026-09-23 06:36:54.806737", new DateTime(2026, 9, 23, 11, 6, 54, 806, DateTimeKind.Local).AddTicks(5539), new DateTime(2026, 9, 23, 6, 36, 54, 806, DateTimeKind.Utc).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 806, DateTimeKind.Utc).AddTicks(7706), "2026-09-23 06:36:54.806771", new DateTime(2026, 9, 23, 11, 6, 54, 806, DateTimeKind.Local).AddTicks(7670), new DateTime(2026, 9, 23, 6, 36, 54, 806, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(501), new DateTime(2027, 3, 23, 6, 36, 54, 807, DateTimeKind.Utc).AddTicks(501), "2026-09-23 06:36:54.808087", new DateTime(2026, 9, 13, 6, 36, 54, 807, DateTimeKind.Utc).AddTicks(501), new DateTime(2026, 9, 23, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(1892), new DateTime(2027, 4, 23, 6, 36, 54, 807, DateTimeKind.Utc).AddTicks(501), "2026-09-23 06:36:54.808280", new DateTime(2026, 9, 18, 6, 36, 54, 807, DateTimeKind.Utc).AddTicks(501), new DateTime(2026, 9, 23, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(3532), new DateTime(2026, 12, 23, 6, 36, 54, 807, DateTimeKind.Utc).AddTicks(501), "2026-09-23 06:36:54.808449", new DateTime(2026, 9, 8, 6, 36, 54, 807, DateTimeKind.Utc).AddTicks(501), new DateTime(2026, 9, 23, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(4845), "2026-09-23 06:36:54.808485", new DateTime(2026, 9, 3, 6, 36, 54, 807, DateTimeKind.Utc).AddTicks(501), new DateTime(2026, 9, 23, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "OperationId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 809, DateTimeKind.Utc).AddTicks(4248), "2026-09-23 06:36:54.809440", new DateTime(2026, 9, 13, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(6787), "9bbc7686-dc1a-4b3e-aa1a-ca6a022164c4", new DateTime(2026, 9, 23, 6, 36, 54, 809, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "OperationId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 809, DateTimeKind.Utc).AddTicks(5284), "2026-09-23 06:36:54.809608", new DateTime(2026, 9, 18, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(6787), "8216d201-83d9-4270-8299-e89da05617a4", new DateTime(2026, 9, 23, 6, 36, 54, 809, DateTimeKind.Utc).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "OperationId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 809, DateTimeKind.Utc).AddTicks(6822), "2026-09-23 06:36:54.809787", new DateTime(2026, 9, 8, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(6787), "90dcc936-d9fa-4cfe-9dbd-4b0bac652c44", new DateTime(2026, 9, 23, 6, 36, 54, 809, DateTimeKind.Utc).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "OperationId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 6, 36, 54, 809, DateTimeKind.Utc).AddTicks(8301), "2026-09-23 06:36:54.809830", new DateTime(2026, 9, 3, 6, 36, 54, 808, DateTimeKind.Utc).AddTicks(6787), "0de1486b-37b3-4bd3-8569-ddf8a7641771", new DateTime(2026, 9, 23, 6, 36, 54, 809, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787701");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787743");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787744");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787744");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787745");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787746");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787746");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.787747");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788020");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788050");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788050");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788052");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788053");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788053");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788054");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788054");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788055");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788055");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788055");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.788056");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.793783");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.793863");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.793954");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.794012");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.794013");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.794014");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.794015");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.794015");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.794016");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-23 06:36:54.794017");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_OperationId",
                table: "StockMovement",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Status",
                table: "Sale",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_IdempotencyRecord_CreatedBy",
                table: "IdempotencyRecord",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_IdempotencyRecord_UpdatedBy",
                table: "IdempotencyRecord",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "UX_IdempotencyRecord_Actor_Scope_Key",
                table: "IdempotencyRecord",
                columns: new[] { "ActorId", "Scope", "Key" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_CreatedBy",
                table: "PurchaseOrder",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_OrderedAtUtc",
                table: "PurchaseOrder",
                column: "OrderedAtUtc");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_ShopId",
                table: "PurchaseOrder",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_ShopId_ReferenceNumber",
                table: "PurchaseOrder",
                columns: new[] { "ShopId", "ReferenceNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_Status",
                table: "PurchaseOrder",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_SupplierId",
                table: "PurchaseOrder",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_UpdatedBy",
                table: "PurchaseOrder",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLine_CreatedBy",
                table: "PurchaseOrderLine",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLine_ProductId",
                table: "PurchaseOrderLine",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLine_ProductUnitId",
                table: "PurchaseOrderLine",
                column: "ProductUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLine_ProductUnitId_ProductId",
                table: "PurchaseOrderLine",
                columns: new[] { "ProductUnitId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLine_PurchaseOrderId",
                table: "PurchaseOrderLine",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLine_UpdatedBy",
                table: "PurchaseOrderLine",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockCountLine_CreatedBy",
                table: "StockCountLine",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockCountLine_StockBatchId",
                table: "StockCountLine",
                column: "StockBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_StockCountLine_StockCountSessionId_StockBatchId",
                table: "StockCountLine",
                columns: new[] { "StockCountSessionId", "StockBatchId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockCountLine_UpdatedBy",
                table: "StockCountLine",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockCountSession_CreatedBy",
                table: "StockCountSession",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockCountSession_ShopId",
                table: "StockCountSession",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_StockCountSession_StartedAtUtc",
                table: "StockCountSession",
                column: "StartedAtUtc");

            migrationBuilder.CreateIndex(
                name: "IX_StockCountSession_Status",
                table: "StockCountSession",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_StockCountSession_UpdatedBy",
                table: "StockCountSession",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_CreatedBy",
                table: "Supplier",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_UpdatedBy",
                table: "Supplier",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "UX_Supplier_ShopId_Name_Active",
                table: "Supplier",
                columns: new[] { "ShopId", "Name" },
                unique: true,
                filter: "[IsDeleted] = 0");

            migrationBuilder.AddForeignKey(
                name: "FK_AppLogs_AspNetUsers_UserId",
                table: "AppLogs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Languages_LanguageId",
                table: "AspNetUsers",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Districts_DistrictId",
                table: "Customers",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Provinces_ProvinceId",
                table: "Customers",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_TranslationKeys_TranslationKeyId",
                table: "Districts",
                column: "TranslationKeyId",
                principalTable: "TranslationKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanAccountPayment_LoanAccount_LoanAccountId",
                table: "LoanAccountPayment",
                column: "LoanAccountId",
                principalTable: "LoanAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_Product_ProductId",
                table: "ProductUnit",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_UnitOfMeasure_UnitOfMeasureId",
                table: "ProductUnit",
                column: "UnitOfMeasureId",
                principalTable: "UnitOfMeasure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProvinceTranslations_Provinces_ProvinceId",
                table: "ProvinceTranslations",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopOwner_Districts_DistrictId",
                table: "ShopOwner",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopOwner_Provinces_ProvinceId",
                table: "ShopOwner",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_TranslationKeys_TranslationKeyId",
                table: "Translations",
                column: "TranslationKeyId",
                principalTable: "TranslationKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppLogs_AspNetUsers_UserId",
                table: "AppLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Languages_LanguageId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Districts_DistrictId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Provinces_ProvinceId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_TranslationKeys_TranslationKeyId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanAccountPayment_LoanAccount_LoanAccountId",
                table: "LoanAccountPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_Product_ProductId",
                table: "ProductUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_UnitOfMeasure_UnitOfMeasureId",
                table: "ProductUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvinceTranslations_Provinces_ProvinceId",
                table: "ProvinceTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopOwner_Districts_DistrictId",
                table: "ShopOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopOwner_Provinces_ProvinceId",
                table: "ShopOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_TranslationKeys_TranslationKeyId",
                table: "Translations");

            migrationBuilder.DropTable(
                name: "IdempotencyRecord");

            migrationBuilder.DropTable(
                name: "PurchaseOrderLine");

            migrationBuilder.DropTable(
                name: "StockCountLine");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "StockCountSession");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_StockMovement_OperationId",
                table: "StockMovement");

            migrationBuilder.DropIndex(
                name: "IX_Sale_Status",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "OperationId",
                table: "StockMovement");

            migrationBuilder.DropColumn(
                name: "ReturnedQuantityEntered",
                table: "SaleLine");

            migrationBuilder.DropColumn(
                name: "ReturnedAmount",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "CreditAmount",
                table: "LoanAccount");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9499), "2026-09-16 03:10:25.796965", new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9677), "2026-09-16 03:10:25.796967", new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9685), "2026-09-16 03:10:25.796968", new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9691), "2026-09-16 03:10:25.796969", new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9698), "2026-09-16 03:10:25.796969", new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9706), "2026-09-16 03:10:25.796970", new DateTime(2026, 9, 16, 3, 10, 25, 796, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 812, DateTimeKind.Utc).AddTicks(3824), "2026-09-16 03:10:25.812441", new DateTime(2026, 9, 16, 3, 10, 25, 812, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 812, DateTimeKind.Utc).AddTicks(7622), "2026-09-16 03:10:25.813065", new DateTime(2026, 9, 16, 3, 10, 25, 812, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(4390), "2026-09-16 03:10:25.813823", new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9864), "2026-09-16 03:10:25.813988", new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9904), "2026-09-16 03:10:25.813990", new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9932), "2026-09-16 03:10:25.813993", new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9951), "2026-09-16 03:10:25.813995", new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9970), "2026-09-16 03:10:25.813997", new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9987), "2026-09-16 03:10:25.813999", new DateTime(2026, 9, 16, 3, 10, 25, 813, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 814, DateTimeKind.Utc).AddTicks(5), "2026-09-16 03:10:25.814000", new DateTime(2026, 9, 16, 3, 10, 25, 814, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786903");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786932");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786933");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785194");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785249");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785250");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 799, DateTimeKind.Utc).AddTicks(8672), "2026-09-16 03:10:25.799891", new DateTime(2026, 9, 16, 3, 10, 25, 799, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(1575), "2026-09-16 03:10:25.800235", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(4132), "2026-09-16 03:10:25.800524", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5855), "2026-09-16 03:10:25.800586", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5880), "2026-09-16 03:10:25.800588", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5899), "2026-09-16 03:10:25.800590", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5919), "2026-09-16 03:10:25.800592", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5936), "2026-09-16 03:10:25.800593", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5952), "2026-09-16 03:10:25.800595", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5977), "2026-09-16 03:10:25.800598", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5997), "2026-09-16 03:10:25.800600", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6026), "2026-09-16 03:10:25.800603", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6043), "2026-09-16 03:10:25.800604", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6060), "2026-09-16 03:10:25.800606", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6078), "2026-09-16 03:10:25.800608", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6096), "2026-09-16 03:10:25.800610", new DateTime(2026, 9, 16, 3, 10, 25, 800, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 807, DateTimeKind.Utc).AddTicks(8138), "2026-09-16 03:10:25.807859", new DateTime(2026, 9, 16, 3, 10, 25, 807, DateTimeKind.Utc).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 808, DateTimeKind.Utc).AddTicks(1007), "2026-09-16 03:10:25.808399", new DateTime(2026, 9, 16, 3, 10, 25, 808, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 808, DateTimeKind.Utc).AddTicks(7031), "2026-09-16 03:10:25.809079", new DateTime(2026, 9, 16, 3, 10, 25, 808, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2238), "2026-09-16 03:10:25.809227", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2461), "2026-09-16 03:10:25.809248", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2524), "2026-09-16 03:10:25.809253", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2577), "2026-09-16 03:10:25.809258", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2611), "2026-09-16 03:10:25.809262", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2643), "2026-09-16 03:10:25.809265", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2680), "2026-09-16 03:10:25.809269", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2714), "2026-09-16 03:10:25.809272", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2801), "2026-09-16 03:10:25.809281", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2841), "2026-09-16 03:10:25.809285", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2872), "2026-09-16 03:10:25.809288", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2910), "2026-09-16 03:10:25.809291", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2940), "2026-09-16 03:10:25.809294", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2970), "2026-09-16 03:10:25.809298", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3031), "2026-09-16 03:10:25.809304", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3065), "2026-09-16 03:10:25.809307", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3097), "2026-09-16 03:10:25.809310", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3127), "2026-09-16 03:10:25.809313", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3159), "2026-09-16 03:10:25.809316", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3195), "2026-09-16 03:10:25.809320", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3227), "2026-09-16 03:10:25.809323", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3260), "2026-09-16 03:10:25.809327", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3293), "2026-09-16 03:10:25.809330", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3325), "2026-09-16 03:10:25.809333", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3356), "2026-09-16 03:10:25.809336", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3388), "2026-09-16 03:10:25.809339", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3419), "2026-09-16 03:10:25.809342", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3453), "2026-09-16 03:10:25.809346", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3484), "2026-09-16 03:10:25.809349", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3515), "2026-09-16 03:10:25.809352", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3570), "2026-09-16 03:10:25.809358", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3604), "2026-09-16 03:10:25.809361", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3635), "2026-09-16 03:10:25.809364", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3666), "2026-09-16 03:10:25.809367", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3698), "2026-09-16 03:10:25.809370", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3734), "2026-09-16 03:10:25.809374", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3766), "2026-09-16 03:10:25.809377", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3798), "2026-09-16 03:10:25.809380", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3831), "2026-09-16 03:10:25.809384", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3863), "2026-09-16 03:10:25.809387", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3892), "2026-09-16 03:10:25.809390", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3923), "2026-09-16 03:10:25.809393", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3953), "2026-09-16 03:10:25.809396", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3990), "2026-09-16 03:10:25.809399", new DateTime(2026, 9, 16, 3, 10, 25, 809, DateTimeKind.Utc).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.802563");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.802866");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803053");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803141");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803142");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803143");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803144");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803145");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803146");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803160");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803161");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803162");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803165");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803166");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803167");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803168");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803169");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803171");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803172");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803173");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803173");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803175");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803176");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803176");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803177");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803179");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803180");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803181");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803182");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803183");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803184");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803186");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803187");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803188");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803189");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803190");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803191");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803192");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803193");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803194");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803195");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803196");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803197");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803198");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803199");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803200");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.803201");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786678");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786734");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786735");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786735");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786736");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786737");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786737");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786738");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786738");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786739");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786739");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786740");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786605");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786623");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786623");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786624");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 794, DateTimeKind.Utc).AddTicks(1299), "2026-09-16 03:10:25.794209", new DateTime(2026, 9, 16, 3, 10, 25, 794, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 794, DateTimeKind.Utc).AddTicks(3700), "2026-09-16 03:10:25.794502", new DateTime(2026, 9, 16, 3, 10, 25, 794, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 794, DateTimeKind.Utc).AddTicks(6076), "2026-09-16 03:10:25.794737", new DateTime(2026, 9, 16, 3, 10, 25, 794, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 794, DateTimeKind.Utc).AddTicks(7870), "2026-09-16 03:10:25.794787", new DateTime(2026, 9, 16, 3, 10, 25, 794, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 819, DateTimeKind.Utc).AddTicks(828), "2026-09-16 03:10:25.819139", new DateTime(2026, 9, 16, 7, 40, 25, 814, DateTimeKind.Local).AddTicks(7051), new DateTime(2026, 9, 16, 3, 10, 25, 819, DateTimeKind.Utc).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 819, DateTimeKind.Utc).AddTicks(5300), "2026-09-16 03:10:25.820088", new DateTime(2026, 9, 16, 7, 40, 25, 819, DateTimeKind.Local).AddTicks(1440), new DateTime(2026, 9, 16, 3, 10, 25, 819, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 820, DateTimeKind.Utc).AddTicks(6860), "2026-09-16 03:10:25.821068", new DateTime(2026, 9, 16, 7, 40, 25, 820, DateTimeKind.Local).AddTicks(2682), new DateTime(2026, 9, 16, 3, 10, 25, 820, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 821, DateTimeKind.Utc).AddTicks(2416), "2026-09-16 03:10:25.821245", new DateTime(2026, 9, 16, 7, 40, 25, 821, DateTimeKind.Local).AddTicks(2156), new DateTime(2026, 9, 16, 3, 10, 25, 821, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 823, DateTimeKind.Utc).AddTicks(9974), new DateTime(2027, 3, 16, 3, 10, 25, 821, DateTimeKind.Utc).AddTicks(8661), "2026-09-16 03:10:25.824042", new DateTime(2026, 9, 6, 3, 10, 25, 821, DateTimeKind.Utc).AddTicks(8661), new DateTime(2026, 9, 16, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(1777), new DateTime(2027, 4, 16, 3, 10, 25, 821, DateTimeKind.Utc).AddTicks(8661), "2026-09-16 03:10:25.824268", new DateTime(2026, 9, 11, 3, 10, 25, 821, DateTimeKind.Utc).AddTicks(8661), new DateTime(2026, 9, 16, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(3579), new DateTime(2026, 12, 16, 3, 10, 25, 821, DateTimeKind.Utc).AddTicks(8661), "2026-09-16 03:10:25.824534", new DateTime(2026, 9, 1, 3, 10, 25, 821, DateTimeKind.Utc).AddTicks(8661), new DateTime(2026, 9, 16, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(5796), "2026-09-16 03:10:25.824580", new DateTime(2026, 8, 27, 3, 10, 25, 821, DateTimeKind.Utc).AddTicks(8661), new DateTime(2026, 9, 16, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 825, DateTimeKind.Utc).AddTicks(7425), "2026-09-16 03:10:25.825761", new DateTime(2026, 9, 6, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(8367), new DateTime(2026, 9, 16, 3, 10, 25, 825, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 825, DateTimeKind.Utc).AddTicks(8583), "2026-09-16 03:10:25.825977", new DateTime(2026, 9, 11, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(8367), new DateTime(2026, 9, 16, 3, 10, 25, 825, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 826, DateTimeKind.Utc).AddTicks(702), "2026-09-16 03:10:25.826196", new DateTime(2026, 9, 1, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(8367), new DateTime(2026, 9, 16, 3, 10, 25, 826, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 16, 3, 10, 25, 826, DateTimeKind.Utc).AddTicks(2388), "2026-09-16 03:10:25.826239", new DateTime(2026, 8, 27, 3, 10, 25, 824, DateTimeKind.Utc).AddTicks(8367), new DateTime(2026, 9, 16, 3, 10, 25, 826, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785671");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785723");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785723");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785724");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785724");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785725");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785726");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.785727");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786116");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786155");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786155");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786156");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786156");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786157");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786158");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786158");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786159");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786159");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786160");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.786160");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.795778");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.795882");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.795992");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.796103");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.796104");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.796105");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.796105");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.796106");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.796107");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-16 03:10:25.796108");

            migrationBuilder.AddForeignKey(
                name: "FK_AppLogs_AspNetUsers_UserId",
                table: "AppLogs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Languages_LanguageId",
                table: "AspNetUsers",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Districts_DistrictId",
                table: "Customers",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Provinces_ProvinceId",
                table: "Customers",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_TranslationKeys_TranslationKeyId",
                table: "Districts",
                column: "TranslationKeyId",
                principalTable: "TranslationKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanAccountPayment_LoanAccount_LoanAccountId",
                table: "LoanAccountPayment",
                column: "LoanAccountId",
                principalTable: "LoanAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_Product_ProductId",
                table: "ProductUnit",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_UnitOfMeasure_UnitOfMeasureId",
                table: "ProductUnit",
                column: "UnitOfMeasureId",
                principalTable: "UnitOfMeasure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProvinceTranslations_Provinces_ProvinceId",
                table: "ProvinceTranslations",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_TranslationKeys_TranslationKeyId",
                table: "Translations",
                column: "TranslationKeyId",
                principalTable: "TranslationKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
