using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddSupplierPayableAccounting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierPayable",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SupplierId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    PurchaseOrderId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    TotalAmount = table.Column<long>(type: "bigint", nullable: false),
                    CreditAmount = table.Column<long>(type: "bigint", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPayable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierPayable_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPayable_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPayable_PurchaseOrder_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPayable_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierPayment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SupplierId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    PaidAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierPayment_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPayment_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPayment_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierPayableEntry",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SupplierPayableId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    OperationId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    OccurredAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPayableEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierPayableEntry_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPayableEntry_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPayableEntry_SupplierPayable_SupplierPayableId",
                        column: x => x.SupplierPayableId,
                        principalTable: "SupplierPayable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierPaymentAllocation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SupplierPaymentId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SupplierPayableId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPaymentAllocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierPaymentAllocation_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPaymentAllocation_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPaymentAllocation_SupplierPayable_SupplierPayableId",
                        column: x => x.SupplierPayableId,
                        principalTable: "SupplierPayable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPaymentAllocation_SupplierPayment_SupplierPaymentId",
                        column: x => x.SupplierPaymentId,
                        principalTable: "SupplierPayment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayable_CreatedBy",
                table: "SupplierPayable",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayable_PurchaseOrderId",
                table: "SupplierPayable",
                column: "PurchaseOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayable_ShopId_SupplierId",
                table: "SupplierPayable",
                columns: new[] { "ShopId", "SupplierId" });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayable_SupplierId",
                table: "SupplierPayable",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayable_UpdatedBy",
                table: "SupplierPayable",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayableEntry_CreatedBy",
                table: "SupplierPayableEntry",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayableEntry_ShopId_OperationId",
                table: "SupplierPayableEntry",
                columns: new[] { "ShopId", "OperationId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayableEntry_SupplierPayableId",
                table: "SupplierPayableEntry",
                column: "SupplierPayableId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayableEntry_UpdatedBy",
                table: "SupplierPayableEntry",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayment_CreatedBy",
                table: "SupplierPayment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayment_ShopId_SupplierId_PaidAtUtc",
                table: "SupplierPayment",
                columns: new[] { "ShopId", "SupplierId", "PaidAtUtc" });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayment_SupplierId",
                table: "SupplierPayment",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayment_UpdatedBy",
                table: "SupplierPayment",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentAllocation_CreatedBy",
                table: "SupplierPaymentAllocation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentAllocation_SupplierPayableId",
                table: "SupplierPaymentAllocation",
                column: "SupplierPayableId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentAllocation_SupplierPaymentId_SupplierPayableId",
                table: "SupplierPaymentAllocation",
                columns: new[] { "SupplierPaymentId", "SupplierPayableId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentAllocation_UpdatedBy",
                table: "SupplierPaymentAllocation",
                column: "UpdatedBy");

            // Existing purchase receipts predate supplier finance. Create the initial
            // immutable payable entries from the original stock-movement quantities,
            // never from today's mutable ProductUnit conversion.
            migrationBuilder.Sql(@"
                ;WITH ReceiptValues AS (
                    SELECT po.Id AS PurchaseOrderId, po.ShopId, po.SupplierId,
                        SUM(CONVERT(bigint, ROUND(
                            CONVERT(decimal(28, 8), movement.QuantityBase) *
                            CONVERT(decimal(28, 8), line.UnitCostBase), 0))) AS TotalAmount
                    FROM StockMovement AS movement
                    INNER JOIN PurchaseOrderLine AS line ON line.Id = movement.ReferenceId
                    INNER JOIN PurchaseOrder AS po ON po.Id = line.PurchaseOrderId
                    WHERE movement.ReferenceType = 'PurchaseOrderLine'
                        AND movement.Reason = 'PurchaseReceipt'
                        AND line.IsDeleted = 0 AND po.IsDeleted = 0
                    GROUP BY po.Id, po.ShopId, po.SupplierId
                )
                INSERT INTO SupplierPayable
                    (Id, ShopId, SupplierId, PurchaseOrderId, TotalAmount, CreditAmount,
                     Version, LastModifiedUtc, IsDeleted)
                SELECT CONVERT(nvarchar(36), NEWID()), ShopId, SupplierId, PurchaseOrderId,
                    TotalAmount, 0, 0,
                    FORMAT(SYSUTCDATETIME(), 'yyyy-MM-dd HH:mm:ss.ffffff', 'en-US'), 0
                FROM ReceiptValues
                WHERE TotalAmount > 0;

                ;WITH ReceiptOperations AS (
                    SELECT payable.Id AS SupplierPayableId, po.ShopId, movement.OperationId,
                        MIN(movement.OccurredAtUtc) AS OccurredAtUtc,
                        SUM(CONVERT(bigint, ROUND(
                            CONVERT(decimal(28, 8), movement.QuantityBase) *
                            CONVERT(decimal(28, 8), line.UnitCostBase), 0))) AS Amount
                    FROM StockMovement AS movement
                    INNER JOIN PurchaseOrderLine AS line ON line.Id = movement.ReferenceId
                    INNER JOIN PurchaseOrder AS po ON po.Id = line.PurchaseOrderId
                    INNER JOIN SupplierPayable AS payable ON payable.PurchaseOrderId = po.Id
                    WHERE movement.ReferenceType = 'PurchaseOrderLine'
                        AND movement.Reason = 'PurchaseReceipt'
                        AND line.IsDeleted = 0 AND po.IsDeleted = 0
                    GROUP BY payable.Id, po.ShopId, movement.OperationId
                )
                INSERT INTO SupplierPayableEntry
                    (Id, ShopId, SupplierPayableId, OperationId, Kind, Amount, OccurredAtUtc,
                     Version, LastModifiedUtc, IsDeleted)
                SELECT CONVERT(nvarchar(36), NEWID()), ShopId, SupplierPayableId,
                    OperationId, 'Receipt', Amount, OccurredAtUtc, 0,
                    FORMAT(SYSUTCDATETIME(), 'yyyy-MM-dd HH:mm:ss.ffffff', 'en-US'), 0
                FROM ReceiptOperations
                WHERE Amount > 0;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierPayableEntry");

            migrationBuilder.DropTable(
                name: "SupplierPaymentAllocation");

            migrationBuilder.DropTable(
                name: "SupplierPayable");

            migrationBuilder.DropTable(
                name: "SupplierPayment");
        }
    }
}
