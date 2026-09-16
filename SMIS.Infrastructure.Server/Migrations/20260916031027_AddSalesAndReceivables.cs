using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddSalesAndReceivables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // LoanAccount previously doubled as both a merchandise line and a debt row.
            // Those records cannot be translated safely into Sale-linked receivables because
            // no Sale/SaleLine IDs existed. The project data is disposable, so clear the old
            // debt/payment rows rather than pretending the old UnitId is a valid SaleId.
            migrationBuilder.Sql("DELETE FROM [LoanAccountPayment]; DELETE FROM [LoanAccount];");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanAccount_Product_ProductId",
                table: "LoanAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanAccount_UnitOfMeasure_UnitId",
                table: "LoanAccount");

            migrationBuilder.DropIndex(
                name: "IX_LoanAccount_ProductId",
                table: "LoanAccount");

            migrationBuilder.DropIndex(
                name: "IX_LoanAccount_UnitId",
                table: "LoanAccount");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000005");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000006");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000007");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000008");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000009");

            migrationBuilder.DeleteData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000010");

            migrationBuilder.DropColumn(
                name: "PriceAtLoanTime",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "UnitName",
                table: "LoanAccount");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "LoanAccount",
                newName: "SaleId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "LoanAccount",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    SaleDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TotalAmount = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    table.PrimaryKey("PK_Sale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sale_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sale_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sale_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sale_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleLine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SaleId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductUnitId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    QuantityEntered = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    UnitPrice = table.Column<long>(type: "bigint", nullable: false),
                    LineTotal = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_SaleLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleLine_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLine_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLine_ProductUnit_ProductUnitId_ProductId",
                        columns: x => new { x.ProductUnitId, x.ProductId },
                        principalTable: "ProductUnit",
                        principalColumns: new[] { "Id", "ProductId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLine_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleLine_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_SaleId",
                table: "LoanAccount",
                column: "SaleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sale_CreatedBy",
                table: "Sale",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_CustomerId",
                table: "Sale",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_PaymentType",
                table: "Sale",
                column: "PaymentType");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_SaleDateUtc",
                table: "Sale",
                column: "SaleDateUtc");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_ShopId",
                table: "Sale",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_UpdatedBy",
                table: "Sale",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_CreatedBy",
                table: "SaleLine",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_ProductId",
                table: "SaleLine",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_ProductUnitId",
                table: "SaleLine",
                column: "ProductUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_ProductUnitId_ProductId",
                table: "SaleLine",
                columns: new[] { "ProductUnitId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_SaleId",
                table: "SaleLine",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_UpdatedBy",
                table: "SaleLine",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanAccount_Sale_SaleId",
                table: "LoanAccount",
                column: "SaleId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanAccount_Sale_SaleId",
                table: "LoanAccount");

            migrationBuilder.DropTable(
                name: "SaleLine");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_LoanAccount_SaleId",
                table: "LoanAccount");

            migrationBuilder.RenameColumn(
                name: "SaleId",
                table: "LoanAccount",
                newName: "UnitId");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "LoanAccount",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<long>(
                name: "PriceAtLoanTime",
                table: "LoanAccount",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "LoanAccount",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "LoanAccount",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "LoanAccount",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "UnitName",
                table: "LoanAccount",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DeletedAt", "DueDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "44444444-4444-0000-0000-000000000001", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(2011), "eeeeeeee-0000-0000-0000-000000000001", "John", null, new DateTime(2026, 10, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675217", null, new DateTime(2026, 8, 16, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Coca Cola loan for John", 5000L, "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 10m, "11111111-0000-0000-0000-000000000001", "Main Store", 1, 50000L, "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(2100), 0 },
                    { "44444444-4444-0000-0000-000000000002", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(4303), "eeeeeeee-0000-0000-0000-000000000002", "Jane", null, new DateTime(2026, 9, 30, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675501", null, new DateTime(2026, 8, 31, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Oreo biscuits for Jane", 4000L, "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", 5m, "11111111-0000-0000-0000-000000000001", "Main Store", 1, 20000L, "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(4681), 0 },
                    { "44444444-4444-0000-0000-000000000003", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(7016), "eeeeeeee-0000-0000-0000-000000000003", "Michael", null, new DateTime(2026, 10, 5, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675788", null, new DateTime(2026, 9, 5, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Notebooks for Michael", 3000L, "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", 20m, "11111111-0000-0000-0000-000000000001", "Main Store", 1, 60000L, "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(7553), 0 },
                    { "44444444-4444-0000-0000-000000000004", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8201), "eeeeeeee-0000-0000-0000-000000000001", "John", null, new DateTime(2026, 10, 30, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675820", null, new DateTime(2026, 9, 10, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Cooking oil bulk order", 8000L, "cccccccc-0000-0000-0000-000000000010", "Cooking Oil 1L", 15m, "11111111-0000-0000-0000-000000000001", "Main Store", 1, 120000L, "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8205), 0 },
                    { "44444444-4444-0000-0000-000000000005", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8227), "eeeeeeee-0000-0000-0000-000000000004", "Sarah", null, new DateTime(2026, 9, 25, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675823", null, new DateTime(2026, 8, 26, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Pepsi for Sarah", 4500L, "cccccccc-0000-0000-0000-000000000002", "Pepsi 500ml", 24m, "11111111-0000-0000-0000-000000000002", "Branch Store", 1, 108000L, "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8229), 0 },
                    { "44444444-4444-0000-0000-000000000006", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8245), "eeeeeeee-0000-0000-0000-000000000005", "David", null, new DateTime(2026, 10, 3, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675824", null, new DateTime(2026, 9, 3, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Blue pens for David", 500L, "cccccccc-0000-0000-0000-000000000008", "Blue Pen", 50m, "11111111-0000-0000-0000-000000000002", "Branch Store", 1, 25000L, "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8247), 0 },
                    { "44444444-4444-0000-0000-000000000007", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8263), "eeeeeeee-0000-0000-0000-000000000006", "Lisa", null, null, "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675826", null, new DateTime(2026, 8, 21, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Rice bulk purchase", 2000L, "cccccccc-0000-0000-0000-000000000011", "Rice 1kg", 100m, "11111111-0000-0000-0000-000000000002", "Branch Store", 1, 200000L, "aaaaaaaa-0000-0000-0000-000000000007", "Kilogram", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8265), 0 },
                    { "44444444-4444-0000-0000-000000000008", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8282), "eeeeeeee-0000-0000-0000-000000000007", "Robert", null, new DateTime(2026, 9, 27, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675828", null, new DateTime(2026, 8, 28, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Mineral water for Robert", 3000L, "cccccccc-0000-0000-0000-000000000003", "Mineral Water 1L", 48m, "11111111-0000-0000-0000-000000000003", "Warehouse", 1, 144000L, "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8283), 0 },
                    { "44444444-4444-0000-0000-000000000009", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8299), "eeeeeeee-0000-0000-0000-000000000008", "Emily", null, new DateTime(2026, 10, 7, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675830", null, new DateTime(2026, 9, 7, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Instant noodles for Emily", 1500L, "cccccccc-0000-0000-0000-000000000006", "Instant Noodles", 30m, "11111111-0000-0000-0000-000000000003", "Warehouse", 1, 45000L, "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8300), 0 },
                    { "44444444-4444-0000-0000-000000000010", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8316), "eeeeeeee-0000-0000-0000-000000000009", "James", null, new DateTime(2026, 10, 12, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "Unchanged", true, false, false, true, "2026-09-15 13:28:08.675831", null, new DateTime(2026, 9, 12, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(9506), "USB cables for James", 1000L, "cccccccc-0000-0000-0000-000000000015", "USB Cable", 100m, "11111111-0000-0000-0000-000000000003", "Warehouse", 1, 100000L, "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 15, 13, 28, 8, 675, DateTimeKind.Utc).AddTicks(8317), 0 }
                });

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648522");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648523");

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648524");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648524");

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648525");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648526");

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648527");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.648527");

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

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 671, DateTimeKind.Utc).AddTicks(7138), new DateTime(2027, 3, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), "2026-09-15 13:28:08.671749", new DateTime(2026, 9, 5, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), new DateTime(2026, 9, 15, 13, 28, 8, 671, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 671, DateTimeKind.Utc).AddTicks(8421), new DateTime(2027, 4, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), "2026-09-15 13:28:08.671932", new DateTime(2026, 9, 10, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), new DateTime(2026, 9, 15, 13, 28, 8, 671, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(65), new DateTime(2026, 12, 15, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), "2026-09-15 13:28:08.672102", new DateTime(2026, 8, 31, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), new DateTime(2026, 9, 15, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(1835), "2026-09-15 13:28:08.672184", new DateTime(2026, 8, 26, 13, 28, 8, 670, DateTimeKind.Utc).AddTicks(7080), new DateTime(2026, 9, 15, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(837), "2026-09-15 13:28:08.673098", new DateTime(2026, 9, 5, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(3918), new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(2022), "2026-09-15 13:28:08.673305", new DateTime(2026, 9, 10, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(3918), new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(3826), "2026-09-15 13:28:08.673508", new DateTime(2026, 8, 31, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(3918), new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "OccurredAtUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(5470), "2026-09-15 13:28:08.673547", new DateTime(2026, 8, 26, 13, 28, 8, 672, DateTimeKind.Utc).AddTicks(3918), new DateTime(2026, 9, 15, 13, 28, 8, 673, DateTimeKind.Utc).AddTicks(5476) });

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647659");

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647661");

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647662");

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647663");

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647664");

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
                column: "LastModifiedUtc",
                value: "2026-09-15 13:28:08.647665");

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

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_ProductId",
                table: "LoanAccount",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_UnitId",
                table: "LoanAccount",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanAccount_Product_ProductId",
                table: "LoanAccount",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanAccount_UnitOfMeasure_UnitId",
                table: "LoanAccount",
                column: "UnitId",
                principalTable: "UnitOfMeasure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
