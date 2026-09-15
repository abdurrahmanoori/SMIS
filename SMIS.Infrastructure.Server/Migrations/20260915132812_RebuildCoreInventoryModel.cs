using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class RebuildCoreInventoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_Product_ProductId",
                table: "ProductPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_StockBatch_Product_ProductId",
                table: "StockBatch");

            migrationBuilder.DropForeignKey(
                name: "FK_StockBatch_UnitOfMeasure_UnitId",
                table: "StockBatch");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitOfMeasure_Shop_ShopId",
                table: "UnitOfMeasure");

            migrationBuilder.DropTable(
                name: "StockTransaction");

            migrationBuilder.DropIndex(
                name: "IX_UnitOfMeasure_ShopId",
                table: "UnitOfMeasure");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_IsActive",
                table: "ProductPrice");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_ProductId_ProductUnitId_EffectiveDate",
                table: "ProductPrice");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_ProductUnitId",
                table: "ProductPrice");

            migrationBuilder.DropIndex(
                name: "IX_Product_ShopId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "StockBatch");

            migrationBuilder.DropColumn(
                name: "UnitName",
                table: "StockBatch");

            migrationBuilder.DropColumn(
                name: "BuyPrice",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductPrice");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "StockBatch",
                newName: "ShopId");

            migrationBuilder.RenameColumn(
                name: "ReceivedDate",
                table: "StockBatch",
                newName: "ReceivedAtUtc");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "StockBatch",
                newName: "RemainingQuantityBase");

            migrationBuilder.RenameColumn(
                name: "PurchasePrice",
                table: "StockBatch",
                newName: "UnitCostBase");

            migrationBuilder.RenameIndex(
                name: "IX_StockBatch_UnitId",
                table: "StockBatch",
                newName: "IX_StockBatch_ShopId");

            migrationBuilder.AddColumn<string>(
                name: "ReceivedProductUnitId",
                table: "StockBatch",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ReceivedQuantity",
                table: "StockBatch",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ReceivedQuantityBase",
                table: "StockBatch",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<long>(
                name: "PriceAtLoanTime",
                table: "LoanAccount",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_StockBatch_Id_ShopId",
                table: "StockBatch",
                columns: new[] { "Id", "ShopId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ProductUnit_Id_ProductId",
                table: "ProductUnit",
                columns: new[] { "Id", "ProductId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Product_Id_ShopId",
                table: "Product",
                columns: new[] { "Id", "ShopId" });

            migrationBuilder.CreateTable(
                name: "StockMovement",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    StockBatchId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductUnitId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    QuantityEntered = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    QuantityBase = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OccurredAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReferenceType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReferenceId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
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
                    table.PrimaryKey("PK_StockMovement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockMovement_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMovement_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMovement_ProductUnit_ProductUnitId",
                        column: x => x.ProductUnitId,
                        principalTable: "ProductUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMovement_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMovement_StockBatch_StockBatchId_ShopId",
                        columns: x => new { x.StockBatchId, x.ShopId },
                        principalTable: "StockBatch",
                        principalColumns: new[] { "Id", "ShopId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7224), "2026-09-15 13:28:08.656730", new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7328), "2026-09-15 13:28:08.656732", new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7335), "2026-09-15 13:28:08.656733", new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7341), "2026-09-15 13:28:08.656734", new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7346), "2026-09-15 13:28:08.656734", new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7352), "2026-09-15 13:28:08.656735", new DateTime(2026, 9, 15, 13, 28, 8, 656, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 666, DateTimeKind.Utc).AddTicks(1298), "2026-09-15 13:28:08.666178", new DateTime(2026, 9, 15, 13, 28, 8, 666, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 666, DateTimeKind.Utc).AddTicks(5717), "2026-09-15 13:28:08.666734", new DateTime(2026, 9, 15, 13, 28, 8, 666, DateTimeKind.Utc).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 666, DateTimeKind.Utc).AddTicks(9993), "2026-09-15 13:28:08.667106", new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1414), "2026-09-15 13:28:08.667142", new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1434), "2026-09-15 13:28:08.667143", new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1450), "2026-09-15 13:28:08.667145", new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1464), "2026-09-15 13:28:08.667146", new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1477), "2026-09-15 13:28:08.667148", new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1490), "2026-09-15 13:28:08.667149", new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1509), "2026-09-15 13:28:08.667151", new DateTime(2026, 9, 15, 13, 28, 8, 667, DateTimeKind.Utc).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648666");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648689");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648689");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.646841");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.646896");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.646897");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(2011), new DateTime(2026, 10, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "2026-09-15 13:28:08.675217", new DateTime(2026, 8, 16, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 5000L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(4303), new DateTime(2026, 9, 30, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "2026-09-15 13:28:08.675501", new DateTime(2026, 8, 31, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 4000L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(7016), new DateTime(2026, 10, 5, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "2026-09-15 13:28:08.675788", new DateTime(2026, 9, 5, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 3000L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8201), new DateTime(2026, 10, 30, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "2026-09-15 13:28:08.675820", new DateTime(2026, 9, 10, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 8000L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8227), new DateTime(2026, 9, 25, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "2026-09-15 13:28:08.675823", new DateTime(2026, 8, 26, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 4500L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8245), new DateTime(2026, 10, 3, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "2026-09-15 13:28:08.675824", new DateTime(2026, 9, 3, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 500L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8263), "2026-09-15 13:28:08.675826", new DateTime(2026, 8, 21, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 2000L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8282), new DateTime(2026, 9, 27, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "2026-09-15 13:28:08.675828", new DateTime(2026, 8, 28, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 3000L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8299), new DateTime(2026, 10, 7, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "2026-09-15 13:28:08.675830", new DateTime(2026, 9, 7, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 1500L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8316), new DateTime(2026, 10, 12, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "2026-09-15 13:28:08.675831", new DateTime(2026, 9, 12, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), 1000L, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 658, DateTimeKind.Utc).AddTicks(9942), "2026-09-15 13:28:08.659012", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(1693), "2026-09-15 13:28:08.659227", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(3635), "2026-09-15 13:28:08.659457", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4932), "2026-09-15 13:28:08.659493", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4955), "2026-09-15 13:28:08.659495", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4969), "2026-09-15 13:28:08.659497", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4984), "2026-09-15 13:28:08.659498", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(4999), "2026-09-15 13:28:08.659500", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5015), "2026-09-15 13:28:08.659501", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5030), "2026-09-15 13:28:08.659503", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5054), "2026-09-15 13:28:08.659505", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5070), "2026-09-15 13:28:08.659507", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5085), "2026-09-15 13:28:08.659508", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5099), "2026-09-15 13:28:08.659510", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5114), "2026-09-15 13:28:08.659511", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5128), "2026-09-15 13:28:08.659513", new DateTime(2026, 9, 15, 13, 28, 8, 659, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(2359), "2026-09-15 13:28:08.663249", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(3571), "2026-09-15 13:28:08.663486", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(6571), "2026-09-15 13:28:08.663835", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(8949), "2026-09-15 13:28:08.663896", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(8972), "2026-09-15 13:28:08.663897", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(8996), "2026-09-15 13:28:08.663900", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9009), "2026-09-15 13:28:08.663901", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9023), "2026-09-15 13:28:08.663902", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9043), "2026-09-15 13:28:08.663904", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9059), "2026-09-15 13:28:08.663906", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9073), "2026-09-15 13:28:08.663907", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9087), "2026-09-15 13:28:08.663909", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9101), "2026-09-15 13:28:08.663910", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9114), "2026-09-15 13:28:08.663912", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9130), "2026-09-15 13:28:08.663913", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9143), "2026-09-15 13:28:08.663914", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9173), "2026-09-15 13:28:08.663917", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9187), "2026-09-15 13:28:08.663919", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9199), "2026-09-15 13:28:08.663920", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9212), "2026-09-15 13:28:08.663921", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9225), "2026-09-15 13:28:08.663923", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9243), "2026-09-15 13:28:08.663924", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9258), "2026-09-15 13:28:08.663926", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9272), "2026-09-15 13:28:08.663927", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9292), "2026-09-15 13:28:08.663929", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9308), "2026-09-15 13:28:08.663931", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9323), "2026-09-15 13:28:08.663932", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9335), "2026-09-15 13:28:08.663934", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9350), "2026-09-15 13:28:08.663935", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9361), "2026-09-15 13:28:08.663936", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9373), "2026-09-15 13:28:08.663937", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9384), "2026-09-15 13:28:08.663938", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9398), "2026-09-15 13:28:08.663940", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9419), "2026-09-15 13:28:08.663942", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9433), "2026-09-15 13:28:08.663943", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9446), "2026-09-15 13:28:08.663945", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9460), "2026-09-15 13:28:08.663946", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9474), "2026-09-15 13:28:08.663947", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9486), "2026-09-15 13:28:08.663949", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9501), "2026-09-15 13:28:08.663950", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9521), "2026-09-15 13:28:08.663952", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9534), "2026-09-15 13:28:08.663953", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9546), "2026-09-15 13:28:08.663955", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9560), "2026-09-15 13:28:08.663956", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9572), "2026-09-15 13:28:08.663958", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9591), "2026-09-15 13:28:08.663959", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9600), "2026-09-15 13:28:08.663960", new DateTime(2026, 9, 15, 13, 28, 8, 663, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.660970");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661053");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661146");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661204");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661205");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661206");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661206");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661207");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661208");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661212");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661213");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661215");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661216");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661216");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661217");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661218");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661219");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661220");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661221");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661221");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661222");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661223");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661224");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661225");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661225");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661226");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661227");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661228");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661229");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661230");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661231");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661232");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661233");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661234");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661235");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661236");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661236");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661237");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661238");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661239");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661240");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661240");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661241");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661242");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661243");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661244");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.661245");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648443");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.648522", "کابل" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.648523", "کابل" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648523");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.648524", "هرات" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.648524", "هرات" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648525");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.648525", "کندهار" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.648526", "قندهار" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648527");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.648527", "بلخ" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.648527", "بلخ" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648361");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648384");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648385");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648385");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 654, DateTimeKind.Utc).AddTicks(3820), "2026-09-15 13:28:08.654584", new DateTime(2026, 9, 15, 13, 28, 8, 654, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 654, DateTimeKind.Utc).AddTicks(7079), "2026-09-15 13:28:08.654788", new DateTime(2026, 9, 15, 13, 28, 8, 654, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 654, DateTimeKind.Utc).AddTicks(8862), "2026-09-15 13:28:08.655014", new DateTime(2026, 9, 15, 13, 28, 8, 654, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 655, DateTimeKind.Utc).AddTicks(750), "2026-09-15 13:28:08.655076", new DateTime(2026, 9, 15, 13, 28, 8, 655, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 669, DateTimeKind.Utc).AddTicks(8946), "2026-09-15 13:28:08.669914", new DateTime(2026, 9, 15, 17, 58, 8, 667, DateTimeKind.Local).AddTicks(7653), new DateTime(2026, 9, 15, 13, 28, 8, 669, DateTimeKind.Utc).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(627), "2026-09-15 13:28:08.670173", new DateTime(2026, 9, 15, 17, 58, 8, 669, DateTimeKind.Local).AddTicks(9160), new DateTime(2026, 9, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(3003), "2026-09-15 13:28:08.670398", new DateTime(2026, 9, 15, 17, 58, 8, 670, DateTimeKind.Local).AddTicks(2088), new DateTime(2026, 9, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(4453), "2026-09-15 13:28:08.670446", new DateTime(2026, 9, 15, 17, 58, 8, 670, DateTimeKind.Local).AddTicks(4401), new DateTime(2026, 9, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(4460) });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ReceivedAtUtc", "ReceivedProductUnitId", "ReceivedQuantity", "ReceivedQuantityBase", "RemainingQuantityBase", "ShopId", "Status", "UnitCostBase", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "11111111-1111-0000-0000-000000000001", "CC-001", null, new DateTime(2026, 9, 15, 13, 28, 8, 671, DateTimeKind.Utc).AddTicks(7138), "Unchanged", new DateTime(2027, 3, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), false, "2026-09-15 13:28:08.671749", "cccccccc-0000-0000-0000-000000000001", new DateTime(2026, 9, 5, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), "dddddddd-0000-0000-0000-000000000001", 100m, 100m, 100m, "11111111-0000-0000-0000-000000000001", "Active", 40000L, null, new DateTime(2026, 9, 15, 13, 28, 8, 671, DateTimeKind.Utc).AddTicks(7332), 0 },
                    { "11111111-1111-0000-0000-000000000002", "CC-002", null, new DateTime(2026, 9, 15, 13, 28, 8, 671, DateTimeKind.Utc).AddTicks(8421), "Unchanged", new DateTime(2027, 4, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), false, "2026-09-15 13:28:08.671932", "cccccccc-0000-0000-0000-000000000001", new DateTime(2026, 9, 10, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), "dddddddd-0000-0000-0000-000000000001", 80m, 80m, 80m, "11111111-0000-0000-0000-000000000001", "Active", 42000L, null, new DateTime(2026, 9, 15, 13, 28, 8, 671, DateTimeKind.Utc).AddTicks(8886), 0 },
                    { "11111111-1111-0000-0000-000000000003", "OREO-101", null, new DateTime(2026, 9, 15, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(65), "Unchanged", new DateTime(2026, 12, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), false, "2026-09-15 13:28:08.672102", "cccccccc-0000-0000-0000-000000000004", new DateTime(2026, 8, 31, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), "dddddddd-0000-0000-0000-000000000010", 50m, 50m, 50m, "11111111-0000-0000-0000-000000000001", "Active", 25000L, null, new DateTime(2026, 9, 15, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(662), 0 },
                    { "11111111-1111-0000-0000-000000000004", "NB-009", null, new DateTime(2026, 9, 15, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(1835), "Unchanged", null, false, "2026-09-15 13:28:08.672184", "cccccccc-0000-0000-0000-000000000007", new DateTime(2026, 8, 26, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), "dddddddd-0000-0000-0000-000000000019", 200m, 200m, 200m, "11111111-0000-0000-0000-000000000001", "Active", 120000L, null, new DateTime(2026, 9, 15, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(1844), 0 }
                });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647283");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647326");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647326");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647327");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647328");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647328");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647329");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647329");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647615");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000002",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.647659", "منطقه مرکز کابل" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647660");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000004",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.647661", "منطقه شمال کابل" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647662");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000006",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.647662", "منطقه مرکز هرات" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647663");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000008",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.647663", "ولایت کابل" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647664");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000010",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.647664", "ولایت هرات" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647665");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-15 13:28:08.647665", "پیام خوش آمدید" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.655801");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.655875");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.655993");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.656061");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.656062");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.656063");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.656064");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.656064");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.656065");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.656065");

            migrationBuilder.InsertData(
                table: "StockMovement",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Direction", "EntityState", "IsPublic", "LastModifiedUtc", "OccurredAtUtc", "ProductUnitId", "QuantityBase", "QuantityEntered", "Reason", "ReferenceId", "ReferenceType", "ShopId", "StockBatchId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "22222222-2222-0000-0000-000000000001", null, new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(837), "In", "Unchanged", false, "2026-09-15 13:28:08.673098", new DateTime(2026, 9, 5, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(3918), "dddddddd-0000-0000-0000-000000000001", 100m, 100m, "PurchaseReceipt", "11111111-1111-0000-0000-000000000001", "Seed", "11111111-0000-0000-0000-000000000001", "11111111-1111-0000-0000-000000000001", null, new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(929), 0 },
                    { "22222222-2222-0000-0000-000000000002", null, new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(2022), "In", "Unchanged", false, "2026-09-15 13:28:08.673305", new DateTime(2026, 9, 10, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(3918), "dddddddd-0000-0000-0000-000000000001", 80m, 80m, "PurchaseReceipt", "11111111-1111-0000-0000-000000000002", "Seed", "11111111-0000-0000-0000-000000000001", "11111111-1111-0000-0000-000000000002", null, new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(2599), 0 },
                    { "22222222-2222-0000-0000-000000000003", null, new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(3826), "In", "Unchanged", false, "2026-09-15 13:28:08.673508", new DateTime(2026, 8, 31, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(3918), "dddddddd-0000-0000-0000-000000000010", 50m, 50m, "PurchaseReceipt", "11111111-1111-0000-0000-000000000003", "Seed", "11111111-0000-0000-0000-000000000001", "11111111-1111-0000-0000-000000000003", null, new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(4524), 0 },
                    { "22222222-2222-0000-0000-000000000004", null, new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(5470), "In", "Unchanged", false, "2026-09-15 13:28:08.673547", new DateTime(2026, 8, 26, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(3918), "dddddddd-0000-0000-0000-000000000019", 200m, 200m, "PurchaseReceipt", "11111111-1111-0000-0000-000000000004", "Seed", "11111111-0000-0000-0000-000000000001", "11111111-1111-0000-0000-000000000004", null, new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(5476), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "UX_UnitOfMeasure_Name_Active",
                table: "UnitOfMeasure",
                column: "Name",
                unique: true,
                filter: "[IsDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "UX_UnitOfMeasure_Symbol_Active",
                table: "UnitOfMeasure",
                column: "Symbol",
                unique: true,
                filter: "[IsDeleted] = 0 AND [Symbol] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_ProductId_ShopId",
                table: "StockBatch",
                columns: new[] { "ProductId", "ShopId" });

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_ReceivedAtUtc",
                table: "StockBatch",
                column: "ReceivedAtUtc");

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_ReceivedProductUnitId",
                table: "StockBatch",
                column: "ReceivedProductUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_ReceivedProductUnitId_ProductId",
                table: "StockBatch",
                columns: new[] { "ReceivedProductUnitId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductUnitId_EffectiveDate",
                table: "ProductPrice",
                columns: new[] { "ProductUnitId", "EffectiveDate" });

            migrationBuilder.CreateIndex(
                name: "UX_Product_ShopId_Barcode_Active",
                table: "Product",
                columns: new[] { "ShopId", "Barcode" },
                unique: true,
                filter: "[IsDeleted] = 0 AND [Barcode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UX_Product_ShopId_SKU_Active",
                table: "Product",
                columns: new[] { "ShopId", "SKU" },
                unique: true,
                filter: "[IsDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_CreatedBy",
                table: "StockMovement",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_OccurredAtUtc",
                table: "StockMovement",
                column: "OccurredAtUtc");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_ProductUnitId",
                table: "StockMovement",
                column: "ProductUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_ReferenceType_ReferenceId",
                table: "StockMovement",
                columns: new[] { "ReferenceType", "ReferenceId" });

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_ShopId",
                table: "StockMovement",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_StockBatchId",
                table: "StockMovement",
                column: "StockBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_StockBatchId_ShopId",
                table: "StockMovement",
                columns: new[] { "StockBatchId", "ShopId" });

            migrationBuilder.CreateIndex(
                name: "IX_StockMovement_UpdatedBy",
                table: "StockMovement",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_StockBatch_ProductUnit_ReceivedProductUnitId_ProductId",
                table: "StockBatch",
                columns: new[] { "ReceivedProductUnitId", "ProductId" },
                principalTable: "ProductUnit",
                principalColumns: new[] { "Id", "ProductId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockBatch_Product_ProductId_ShopId",
                table: "StockBatch",
                columns: new[] { "ProductId", "ShopId" },
                principalTable: "Product",
                principalColumns: new[] { "Id", "ShopId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockBatch_Shop_ShopId",
                table: "StockBatch",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockBatch_ProductUnit_ReceivedProductUnitId_ProductId",
                table: "StockBatch");

            migrationBuilder.DropForeignKey(
                name: "FK_StockBatch_Product_ProductId_ShopId",
                table: "StockBatch");

            migrationBuilder.DropForeignKey(
                name: "FK_StockBatch_Shop_ShopId",
                table: "StockBatch");

            migrationBuilder.DropTable(
                name: "StockMovement");

            migrationBuilder.DropIndex(
                name: "UX_UnitOfMeasure_Name_Active",
                table: "UnitOfMeasure");

            migrationBuilder.DropIndex(
                name: "UX_UnitOfMeasure_Symbol_Active",
                table: "UnitOfMeasure");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_StockBatch_Id_ShopId",
                table: "StockBatch");

            migrationBuilder.DropIndex(
                name: "IX_StockBatch_ProductId_ShopId",
                table: "StockBatch");

            migrationBuilder.DropIndex(
                name: "IX_StockBatch_ReceivedAtUtc",
                table: "StockBatch");

            migrationBuilder.DropIndex(
                name: "IX_StockBatch_ReceivedProductUnitId",
                table: "StockBatch");

            migrationBuilder.DropIndex(
                name: "IX_StockBatch_ReceivedProductUnitId_ProductId",
                table: "StockBatch");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ProductUnit_Id_ProductId",
                table: "ProductUnit");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_ProductUnitId_EffectiveDate",
                table: "ProductPrice");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Product_Id_ShopId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "UX_Product_ShopId_Barcode_Active",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "UX_Product_ShopId_SKU_Active",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ReceivedProductUnitId",
                table: "StockBatch");

            migrationBuilder.DropColumn(
                name: "ReceivedQuantity",
                table: "StockBatch");

            migrationBuilder.DropColumn(
                name: "ReceivedQuantityBase",
                table: "StockBatch");

            migrationBuilder.RenameColumn(
                name: "UnitCostBase",
                table: "StockBatch",
                newName: "PurchasePrice");

            migrationBuilder.RenameColumn(
                name: "ShopId",
                table: "StockBatch",
                newName: "UnitId");

            migrationBuilder.RenameColumn(
                name: "RemainingQuantityBase",
                table: "StockBatch",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "ReceivedAtUtc",
                table: "StockBatch",
                newName: "ReceivedDate");

            migrationBuilder.RenameIndex(
                name: "IX_StockBatch_ShopId",
                table: "StockBatch",
                newName: "IX_StockBatch_UnitId");

            migrationBuilder.AddColumn<string>(
                name: "ShopId",
                table: "UnitOfMeasure",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "StockBatch",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitName",
                table: "StockBatch",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BuyPrice",
                table: "ProductPrice",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductPrice",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "ProductPrice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "PriceAtLoanTime",
                table: "LoanAccount",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "StockTransaction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    StockBatchId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnitId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockTransaction_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_StockBatch_StockBatchId",
                        column: x => x.StockBatchId,
                        principalTable: "StockBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_UnitOfMeasure_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitOfMeasure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1063), "2026-09-10 03:06:50.802116", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1192), "2026-09-10 03:06:50.802119", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1196), "2026-09-10 03:06:50.802119", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1217), "2026-09-10 03:06:50.802121", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1221), "2026-09-10 03:06:50.802122", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1224), "2026-09-10 03:06:50.802122", new DateTime(2026, 9, 10, 3, 6, 50, 802, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(281), "2026-09-10 03:06:50.813077", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(5129), "2026-09-10 03:06:50.813666", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(7914), "2026-09-10 03:06:50.813886", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9228), "2026-09-10 03:06:50.813923", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9255), "2026-09-10 03:06:50.813925", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9278), "2026-09-10 03:06:50.813928", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9291), "2026-09-10 03:06:50.813929", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9305), "2026-09-10 03:06:50.813930", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9317), "2026-09-10 03:06:50.813932", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9330), "2026-09-10 03:06:50.813933", new DateTime(2026, 9, 10, 3, 6, 50, 813, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794374");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794405");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794406");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792004");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792050");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792050");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 831, DateTimeKind.Utc).AddTicks(200), new DateTime(2026, 10, 10, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.831061", new DateTime(2026, 8, 11, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 5000m, new DateTime(2026, 9, 10, 3, 6, 50, 831, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 831, DateTimeKind.Utc).AddTicks(9375), new DateTime(2026, 9, 25, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.832195", new DateTime(2026, 8, 26, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 4000m, new DateTime(2026, 9, 10, 3, 6, 50, 832, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 832, DateTimeKind.Utc).AddTicks(9344), new DateTime(2026, 9, 30, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833133", new DateTime(2026, 8, 31, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 3000m, new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2314), new DateTime(2026, 10, 25, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833233", new DateTime(2026, 9, 5, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 8000m, new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2369), new DateTime(2026, 9, 20, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833237", new DateTime(2026, 8, 21, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 4500m, new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2405), new DateTime(2026, 9, 28, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833241", new DateTime(2026, 8, 29, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 500m, new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2444), "2026-09-10 03:06:50.833245", new DateTime(2026, 8, 16, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 2000m, new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2481), new DateTime(2026, 9, 22, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833248", new DateTime(2026, 8, 23, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 3000m, new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2539), new DateTime(2026, 10, 2, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833254", new DateTime(2026, 9, 2, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 1500m, new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2574), new DateTime(2026, 10, 7, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), "2026-09-10 03:06:50.833258", new DateTime(2026, 9, 7, 3, 6, 50, 828, DateTimeKind.Utc).AddTicks(184), 1000m, new DateTime(2026, 9, 10, 3, 6, 50, 833, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(3899), "2026-09-10 03:06:50.804410", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(5644), "2026-09-10 03:06:50.804633", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(7775), "2026-09-10 03:06:50.804870", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9101), "2026-09-10 03:06:50.804910", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9121), "2026-09-10 03:06:50.804912", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9142), "2026-09-10 03:06:50.804914", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9185), "2026-09-10 03:06:50.804918", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9199), "2026-09-10 03:06:50.804920", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9217), "2026-09-10 03:06:50.804922", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9235), "2026-09-10 03:06:50.804923", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9248), "2026-09-10 03:06:50.804925", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9264), "2026-09-10 03:06:50.804926", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9277), "2026-09-10 03:06:50.804928", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9292), "2026-09-10 03:06:50.804929", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9304), "2026-09-10 03:06:50.804930", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9328), "2026-09-10 03:06:50.804933", new DateTime(2026, 9, 10, 3, 6, 50, 804, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 140L, new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(2161), true, "2026-09-10 03:06:50.809262", "cccccccc-0000-0000-0000-000000000001", new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 1680L, new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(4161), true, "2026-09-10 03:06:50.809635", "cccccccc-0000-0000-0000-000000000001", new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 3360L, new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(8155), true, "2026-09-10 03:06:50.810051", "cccccccc-0000-0000-0000-000000000001", new DateTime(2026, 9, 10, 3, 6, 50, 809, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 130L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1597), true, "2026-09-10 03:06:50.810161", "cccccccc-0000-0000-0000-000000000002", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 1560L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1630), true, "2026-09-10 03:06:50.810163", "cccccccc-0000-0000-0000-000000000002", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 3120L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1649), true, "2026-09-10 03:06:50.810165", "cccccccc-0000-0000-0000-000000000002", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 70L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1667), true, "2026-09-10 03:06:50.810167", "cccccccc-0000-0000-0000-000000000003", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 420L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1683), true, "2026-09-10 03:06:50.810168", "cccccccc-0000-0000-0000-000000000003", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 840L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1699), true, "2026-09-10 03:06:50.810170", "cccccccc-0000-0000-0000-000000000003", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 230L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1715), true, "2026-09-10 03:06:50.810172", "cccccccc-0000-0000-0000-000000000004", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 2760L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1755), true, "2026-09-10 03:06:50.810176", "cccccccc-0000-0000-0000-000000000004", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 11040L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1773), true, "2026-09-10 03:06:50.810177", "cccccccc-0000-0000-0000-000000000004", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 160L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1789), true, "2026-09-10 03:06:50.810179", "cccccccc-0000-0000-0000-000000000005", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 3200L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1804), true, "2026-09-10 03:06:50.810181", "cccccccc-0000-0000-0000-000000000005", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 9600L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1819), true, "2026-09-10 03:06:50.810182", "cccccccc-0000-0000-0000-000000000005", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 110L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1833), true, "2026-09-10 03:06:50.810183", "cccccccc-0000-0000-0000-000000000006", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 2640L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1848), true, "2026-09-10 03:06:50.810185", "cccccccc-0000-0000-0000-000000000006", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 7920L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1863), true, "2026-09-10 03:06:50.810187", "cccccccc-0000-0000-0000-000000000006", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 280L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1882), true, "2026-09-10 03:06:50.810188", "cccccccc-0000-0000-0000-000000000007", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 3360L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1897), true, "2026-09-10 03:06:50.810190", "cccccccc-0000-0000-0000-000000000007", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 14000L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1911), true, "2026-09-10 03:06:50.810191", "cccccccc-0000-0000-0000-000000000007", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 45L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1927), true, "2026-09-10 03:06:50.810193", "cccccccc-0000-0000-0000-000000000008", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 540L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1968), true, "2026-09-10 03:06:50.810197", "cccccccc-0000-0000-0000-000000000008", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 6480L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1986), true, "2026-09-10 03:06:50.810199", "cccccccc-0000-0000-0000-000000000008", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 380L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2001), true, "2026-09-10 03:06:50.810200", "cccccccc-0000-0000-0000-000000000009", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 7600L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2017), true, "2026-09-10 03:06:50.810202", "cccccccc-0000-0000-0000-000000000009", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 430L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2035), true, "2026-09-10 03:06:50.810204", "cccccccc-0000-0000-0000-000000000010", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 5160L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2068), true, "2026-09-10 03:06:50.810207", "cccccccc-0000-0000-0000-000000000010", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 10320L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2084), true, "2026-09-10 03:06:50.810209", "cccccccc-0000-0000-0000-000000000010", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 260L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2100), true, "2026-09-10 03:06:50.810210", "cccccccc-0000-0000-0000-000000000011", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 2600L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2115), true, "2026-09-10 03:06:50.810212", "cccccccc-0000-0000-0000-000000000011", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 6500L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2129), true, "2026-09-10 03:06:50.810213", "cccccccc-0000-0000-0000-000000000011", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 180L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2144), true, "2026-09-10 03:06:50.810215", "cccccccc-0000-0000-0000-000000000012", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 3600L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2159), true, "2026-09-10 03:06:50.810216", "cccccccc-0000-0000-0000-000000000012", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 9000L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2178), true, "2026-09-10 03:06:50.810218", "cccccccc-0000-0000-0000-000000000012", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 330L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2193), true, "2026-09-10 03:06:50.810219", "cccccccc-0000-0000-0000-000000000013", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 3960L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2208), true, "2026-09-10 03:06:50.810221", "cccccccc-0000-0000-0000-000000000013", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 7920L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2223), true, "2026-09-10 03:06:50.810222", "cccccccc-0000-0000-0000-000000000013", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 160L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2238), true, "2026-09-10 03:06:50.810224", "cccccccc-0000-0000-0000-000000000014", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 3840L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2254), true, "2026-09-10 03:06:50.810225", "cccccccc-0000-0000-0000-000000000014", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 11520L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2268), true, "2026-09-10 03:06:50.810227", "cccccccc-0000-0000-0000-000000000014", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 230L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2283), true, "2026-09-10 03:06:50.810229", "cccccccc-0000-0000-0000-000000000015", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 11500L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2305), true, "2026-09-10 03:06:50.810231", "cccccccc-0000-0000-0000-000000000015", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 46000L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2320), true, "2026-09-10 03:06:50.810232", "cccccccc-0000-0000-0000-000000000015", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 750L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2349), true, "2026-09-10 03:06:50.810235", "cccccccc-0000-0000-0000-000000000016", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 15000L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2364), true, "2026-09-10 03:06:50.810237", "cccccccc-0000-0000-0000-000000000016", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "BuyPrice", "CreatedDate", "IsActive", "LastModifiedUtc", "ProductId", "UpdatedDate" },
                values: new object[] { 75000L, new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2378), true, "2026-09-10 03:06:50.810238", "cccccccc-0000-0000-0000-000000000016", new DateTime(2026, 9, 10, 3, 6, 50, 810, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806308");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806396");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806495");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806550");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806551");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806552");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806553");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806554");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806554");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806555");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806556");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806556");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806557");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806558");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806558");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806559");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806560");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806560");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806561");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806563");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806563");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806564");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806565");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806565");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806566");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806566");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806567");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806568");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806568");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806569");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806570");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806570");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806571");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806572");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806572");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806573");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806573");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806574");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806575");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806575");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806577");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806577");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806578");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806579");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806579");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806580");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.806581");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793833");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.794014", "+�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.794016", "+�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794016");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.794016", "+�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.794016", "+�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794018");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.794018", "+�+�+�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.794018", "+�+�+�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.794018");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.794019", "+�+�+�" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.794019", "+�+�+�" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793652");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793671");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793671");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793671");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 799, DateTimeKind.Utc).AddTicks(5255), "2026-09-10 03:06:50.799643", new DateTime(2026, 9, 10, 3, 6, 50, 799, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 799, DateTimeKind.Utc).AddTicks(8380), "2026-09-10 03:06:50.799923", new DateTime(2026, 9, 10, 3, 6, 50, 799, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 800, DateTimeKind.Utc).AddTicks(384), "2026-09-10 03:06:50.800134", new DateTime(2026, 9, 10, 3, 6, 50, 800, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 800, DateTimeKind.Utc).AddTicks(1863), "2026-09-10 03:06:50.800187", new DateTime(2026, 9, 10, 3, 6, 50, 800, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 818, DateTimeKind.Utc).AddTicks(8113), "2026-09-10 03:06:50.818861", new DateTime(2026, 9, 10, 7, 36, 50, 814, DateTimeKind.Local).AddTicks(5623), new DateTime(2026, 9, 10, 3, 6, 50, 818, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(2201), "2026-09-10 03:06:50.819372", new DateTime(2026, 9, 10, 7, 36, 50, 818, DateTimeKind.Local).AddTicks(8679), new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(5127), "2026-09-10 03:06:50.819606", new DateTime(2026, 9, 10, 7, 36, 50, 819, DateTimeKind.Local).AddTicks(4072), new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(6405), "2026-09-10 03:06:50.819641", new DateTime(2026, 9, 10, 7, 36, 50, 819, DateTimeKind.Local).AddTicks(6362), new DateTime(2026, 9, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ProductName", "ReceivedDate", "UnitId", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 821, DateTimeKind.Utc).AddTicks(2813), new DateTime(2027, 3, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "2026-09-10 03:06:50.821390", "Coca Cola 500ml", new DateTime(2026, 8, 31, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", new DateTime(2026, 9, 10, 3, 6, 50, 821, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ProductName", "ReceivedDate", "UnitId", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 821, DateTimeKind.Utc).AddTicks(7442), new DateTime(2027, 4, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "2026-09-10 03:06:50.821924", "Coca Cola 500ml", new DateTime(2026, 9, 5, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", new DateTime(2026, 9, 10, 3, 6, 50, 821, DateTimeKind.Utc).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ProductName", "ReceivedDate", "UnitId", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 822, DateTimeKind.Utc).AddTicks(4334), new DateTime(2026, 12, 10, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "2026-09-10 03:06:50.822722", "Oreo Biscuits", new DateTime(2026, 8, 26, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "aaaaaaaa-0000-0000-0000-000000000003", "Pack", new DateTime(2026, 9, 10, 3, 6, 50, 822, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ProductName", "ReceivedDate", "UnitId", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 10, 3, 6, 50, 822, DateTimeKind.Utc).AddTicks(8268), "2026-09-10 03:06:50.822828", "A4 Notebook", new DateTime(2026, 8, 21, 3, 6, 50, 819, DateTimeKind.Utc).AddTicks(9199), "aaaaaaaa-0000-0000-0000-000000000001", "Piece", new DateTime(2026, 9, 10, 3, 6, 50, 822, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "22222222-2222-0000-0000-000000000001", null, new DateTime(2026, 9, 10, 3, 6, 50, 825, DateTimeKind.Utc).AddTicks(6884), "Unchanged", false, "2026-09-10 03:06:50.825726", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 100m, "Purchase Order #001", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000001", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 10, 3, 6, 50, 825, DateTimeKind.Utc).AddTicks(7121), 0 },
                    { "22222222-2222-0000-0000-000000000002", null, new DateTime(2026, 9, 10, 3, 6, 50, 826, DateTimeKind.Utc).AddTicks(1522), "Unchanged", false, "2026-09-10 03:06:50.826335", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 20m, "Sale #001", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000001", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 10, 3, 6, 50, 826, DateTimeKind.Utc).AddTicks(2469), 0 },
                    { "22222222-2222-0000-0000-000000000003", null, new DateTime(2026, 9, 10, 3, 6, 50, 826, DateTimeKind.Utc).AddTicks(8312), "Unchanged", false, "2026-09-10 03:06:50.827053", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 80m, "Purchase Order #002", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000002", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 10, 3, 6, 50, 826, DateTimeKind.Utc).AddTicks(9563), 0 },
                    { "22222222-2222-0000-0000-000000000004", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1530), "Unchanged", false, "2026-09-10 03:06:50.827154", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 15m, "Sale #002", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000002", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1543), 0 },
                    { "22222222-2222-0000-0000-000000000005", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1579), "Unchanged", false, "2026-09-10 03:06:50.827158", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", 50m, "Purchase Order #003", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000003", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1585), 0 },
                    { "22222222-2222-0000-0000-000000000006", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1610), "Unchanged", false, "2026-09-10 03:06:50.827161", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", 10m, "Sale #003", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000003", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1616), 0 },
                    { "22222222-2222-0000-0000-000000000007", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1637), "Unchanged", false, "2026-09-10 03:06:50.827164", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", 2m, "Damage - Expired", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000003", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1642), 0 },
                    { "22222222-2222-0000-0000-000000000008", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1665), "Unchanged", false, "2026-09-10 03:06:50.827167", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", 200m, "Purchase Order #004", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000004", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1671), 0 },
                    { "22222222-2222-0000-0000-000000000009", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1723), "Unchanged", false, "2026-09-10 03:06:50.827173", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", 25m, "Sale #004", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000004", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1728), 0 },
                    { "22222222-2222-0000-0000-000000000010", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1751), "Unchanged", false, "2026-09-10 03:06:50.827175", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", 5m, "Sale #005", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000004", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 10, 3, 6, 50, 827, DateTimeKind.Utc).AddTicks(1756), 0 }
                });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792497");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792544");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792545");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792545");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792547");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792547");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792548");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.792548");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793168");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000002",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.793205", "+�+�+++�+� +�+�+�+� +�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793205");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000004",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.793205", "+�+�+++�+� +�+�+�+� +�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793206");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000006",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.793207", "+�+�+++�+� +�+�+�+� +�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793209");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000008",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.793209", "+�+�+���+� +�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793210");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000010",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.793210", "+�+�+���+� +�+�+�+�" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-10 03:06:50.793210");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012",
                columns: new[] { "LastModifiedUtc", "Name" },
                values: new object[] { "2026-09-10 03:06:50.793210", "++��+�+� +�+�+� +�+�+���+�" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801047", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801126", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801214", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801293", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801293", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801295", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801295", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801296", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801296", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                columns: new[] { "LastModifiedUtc", "ShopId" },
                values: new object[] { "2026-09-10 03:06:50.801297", "11111111-0000-0000-0000-000000000001" });

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfMeasure_ShopId",
                table: "UnitOfMeasure",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_IsActive",
                table: "ProductPrice",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductId_ProductUnitId_EffectiveDate",
                table: "ProductPrice",
                columns: new[] { "ProductId", "ProductUnitId", "EffectiveDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductUnitId",
                table: "ProductPrice",
                column: "ProductUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShopId",
                table: "Product",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_CreatedBy",
                table: "StockTransaction",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_ProductId",
                table: "StockTransaction",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_ShopId",
                table: "StockTransaction",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_StockBatchId",
                table: "StockTransaction",
                column: "StockBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_TransactionDate",
                table: "StockTransaction",
                column: "TransactionDate");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_Type",
                table: "StockTransaction",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_UnitId",
                table: "StockTransaction",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_UpdatedBy",
                table: "StockTransaction",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_Product_ProductId",
                table: "ProductPrice",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockBatch_Product_ProductId",
                table: "StockBatch",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockBatch_UnitOfMeasure_UnitId",
                table: "StockBatch",
                column: "UnitId",
                principalTable: "UnitOfMeasure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitOfMeasure_Shop_ShopId",
                table: "UnitOfMeasure",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
