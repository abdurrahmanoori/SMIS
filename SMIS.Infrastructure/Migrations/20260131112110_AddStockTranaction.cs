using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStockTranaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockTransaction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    StockBatchId = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", precision: 18, scale: 4, nullable: false),
                    UnitId = table.Column<string>(type: "TEXT", nullable: false),
                    UnitName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Reference = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockTransaction_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f01bdce5-86e3-4f9e-8305-ce890844dea5", "AQAAAAIAAYagAAAAEP6twNDcF+1JQ2XyZd0+STAJN7lWtxaj5pSOWtCdw3XPE894JeMTwJnxJX8kUfQfPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "649f04eb-40c3-4d39-9c6a-04253a83d1f2", "AQAAAAIAAYagAAAAEEbgKjZ8ShJIZATcqtEmI8WpRML2vxzZu3Px3zFxcX3J9SzRAOJz1kWEyB1JgF/tZw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(448), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(456), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(797), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(802), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(805), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(806), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(812), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(813), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(817), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 917, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 917, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1787), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(1793), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1876), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1881), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(693), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(1009), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(1016), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 915, DateTimeKind.Local).AddTicks(3695), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 915, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 915, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8365), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8374), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8377), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8382), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8387), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8391), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8399), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8402), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8406), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8414), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(6450), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(7517), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(7525), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8300), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8309), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8323), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8327), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8332), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8336), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8341), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8344), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8349), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8352), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8357), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 916, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 916, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 902, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5268), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5272), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5276), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5279), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5286), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5217), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5298), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5302), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5305), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5312), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5315), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5327), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5331), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5233), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5334), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5252), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 903, DateTimeKind.Unspecified).AddTicks(5256), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(894), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(897), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(874), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(883), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(886), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(34), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(42), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(44), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(48), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(51), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(52), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(58), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(5617), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(5623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 908, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 914, DateTimeKind.Local).AddTicks(8427), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 914, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 914, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 914, DateTimeKind.Local).AddTicks(9051), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 914, DateTimeKind.Unspecified).AddTicks(9059), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 914, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 904, DateTimeKind.Local).AddTicks(671), new DateTime(2026, 7, 31, 11, 21, 9, 903, DateTimeKind.Utc).AddTicks(7588), new DateTime(2026, 1, 21, 11, 21, 9, 903, DateTimeKind.Utc).AddTicks(7540), new DateTime(2026, 1, 31, 15, 51, 9, 904, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(2444), new DateTime(2026, 8, 31, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(2426), new DateTime(2026, 1, 26, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(2424), new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(4092), new DateTime(2026, 4, 30, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(4080), new DateTime(2026, 1, 16, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(4080), new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(4952), new DateTime(2026, 1, 11, 11, 21, 9, 905, DateTimeKind.Utc).AddTicks(4944), new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(9394), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 1, 31, 15, 51, 9, 905, DateTimeKind.Local).AddTicks(9403), 0 },
                    { "10", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8587), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 5m, "Sale #005", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8587), 0 },
                    { "2", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(6138), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 20m, "Sale #001", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(6142), 0 },
                    { "3", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(7267), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(7269), 0 },
                    { "4", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8527), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 15m, "Sale #002", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8529), 0 },
                    { "5", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8553), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 50m, "Purchase Order #003", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8553), 0 },
                    { "6", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8562), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 10m, "Sale #003", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8562), 0 },
                    { "7", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8568), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 2m, "Damage - Expired", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "2", "Bottle", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8568), 0 },
                    { "8", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8574), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 200m, "Purchase Order #004", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8574), 0 },
                    { "9", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8580), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 25m, "Sale #004", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 1, 31, 15, 51, 9, 906, DateTimeKind.Local).AddTicks(8581), 0 }
                });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(3700), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4046), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4428), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4434), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4438), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4441), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4442), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4446), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4449), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4450), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4454), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6564), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6816), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6820), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6823), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6824), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6827), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6769), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6773), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6775), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6778), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6779), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6782), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6783), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6797), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6800), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6801), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6804), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6805), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6812), new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 907, DateTimeKind.Unspecified).AddTicks(6815), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 15, 51, 9, 907, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3885), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3845), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3862), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3865), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3878), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 11, 21, 9, 908, DateTimeKind.Unspecified).AddTicks(3882), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_ProductId",
                table: "StockTransaction",
                column: "ProductId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockTransaction");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4293fcc4-9265-4a52-a08b-83e3f4cc84bf", "AQAAAAIAAYagAAAAEBfLFSqW0Tw2CGiNdg1IO6OaIT5I80SjZdcYEzav1S4jIx6QdLlfS5bdh5DPcAiH1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fba6e935-93ad-48c8-ab0e-0efa40c6e29c", "AQAAAAIAAYagAAAAEDtvzVfPEw7J8AqwmQa847dh3kead7+nKFi/TdtT4erKKf715sixoYFtAa2LTRcgsA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(6970), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(6978), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7255), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7261), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7265), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7279), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7285), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(7288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6562), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(6568), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6656), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(6660), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6661), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(6948), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(6952), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(9961), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 609, DateTimeKind.Unspecified).AddTicks(9974), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4880), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4883), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4887), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4895), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4904), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4911), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4914), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4918), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4921), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4926), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4928), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(2884), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4020), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4029), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4814), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4826), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4839), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4848), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4851), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4856), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4860), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4865), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4867), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4872), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 611, DateTimeKind.Unspecified).AddTicks(4875), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 611, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(2947), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5624), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5627), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5634), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5641), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5645), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5649), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5655), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5685), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5607), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 598, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5253), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5670), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5635), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5653), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5659), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(5662), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4840), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4848), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(4851), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4852), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(4855), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4856), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(4858), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 602, DateTimeKind.Local).AddTicks(1470), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 602, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 602, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(4419), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 609, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(5093), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 609, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 609, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 598, DateTimeKind.Local).AddTicks(9928), new DateTime(2026, 7, 31, 7, 18, 40, 598, DateTimeKind.Utc).AddTicks(7608), new DateTime(2026, 1, 21, 7, 18, 40, 598, DateTimeKind.Utc).AddTicks(7557), new DateTime(2026, 1, 31, 11, 48, 40, 599, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(2699), new DateTime(2026, 8, 31, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(2665), new DateTime(2026, 1, 26, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(2663), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(4216), new DateTime(2026, 4, 30, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(4204), new DateTime(2026, 1, 16, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(4203), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(4957), new DateTime(2026, 1, 11, 7, 18, 40, 600, DateTimeKind.Utc).AddTicks(4951), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9249), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9875), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9879), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9880), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9889), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9892), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9893), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9896), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9897), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9900), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9901), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9903), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9904), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 600, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 600, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(1820), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(1832), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2039), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2043), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2048), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2051), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2005), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2009), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2011), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2016), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2017), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2020), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2021), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2024), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2025), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2028), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2028), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2031), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2032), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2035), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2036), new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(2038), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 11, 48, 40, 601, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8347), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8571), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8574), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8580), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8583), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8592), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 7, 18, 40, 601, DateTimeKind.Unspecified).AddTicks(8595), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
