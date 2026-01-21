using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shops",
                table: "Shops");

            migrationBuilder.RenameTable(
                name: "Shops",
                newName: "Shop");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shop",
                table: "Shop",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    BaseUnitId = table.Column<string>(type: "TEXT", nullable: false),
                    SalePricePerBaseUnit = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_UnitOfMeasure_BaseUnitId",
                        column: x => x.BaseUnitId,
                        principalTable: "UnitOfMeasure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85c99687-9666-4863-8aa8-406ebf7174aa", "AQAAAAIAAYagAAAAEKKRsTrdIpaJLsc9J+UOTt0YDeTh+aNChV+z8cO2WDu2mtT0CADoeHFN76MEyCeXXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5faab7b8-e1fc-4504-beb1-47ee30aa965c", "AQAAAAIAAYagAAAAEN+0NjxnGzEmH123pmtlQCGlIVu7AsGD175k9D8iZW10mPjudNv5jA6uqtY81dlFBA==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5410), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5688), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5692), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BaseUnitId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsPublic", "Name", "SalePricePerBaseUnit", "ShopId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "1", null, new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(4165), "Pain reliever", true, false, "Paracetamol 500mg", 50, "1", null, new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(4168) },
                    { "2", "1", null, new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(5517), "Anti-inflammatory", true, false, "Ibuprofen 200mg", 30, "1", null, new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(5520) },
                    { "3", "1", null, new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(5522), "Blood thinner", true, false, "Aspirin 100mg", 20, "2", null, new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(5523) }
                });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1409), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1416), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1418), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1419), new DateTime(2026, 1, 21, 16, 42, 44, 287, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(623), new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(2093), new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(2098), new DateTime(2026, 1, 21, 16, 42, 44, 288, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 284, DateTimeKind.Local).AddTicks(9407), new DateTime(2026, 1, 21, 16, 42, 44, 285, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1697), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1702), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1704), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1706), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(5674), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6259), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6261), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6263), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6264), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6266), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6267), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6245), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6249), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6250), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6252), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6254), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6255), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6257), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6258), new DateTime(2026, 1, 21, 16, 42, 44, 286, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.CreateIndex(
                name: "IX_Product_BaseUnitId",
                table: "Product",
                column: "BaseUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShopId",
                table: "Product",
                column: "ShopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shop",
                table: "Shop");

            migrationBuilder.RenameTable(
                name: "Shop",
                newName: "Shops");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shops",
                table: "Shops",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "771afb92-01a2-41c6-b972-b8836078aac5", "AQAAAAIAAYagAAAAEJVD8EsEuWUtJKEn/tWoWHw69Ni77ONvosxlGjmB47esJ4ajKqC3tNgTV+WKv5B3MQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ccef1c3-b242-4e49-8fa3-ed1a0404be4b", "AQAAAAIAAYagAAAAEB4dcPb8VLCSUB/tRqurPEPJ8HuigziqExAbjpljakxDZHXsbfqEchj3ipxvhOyzuA==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(429), new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(1089), new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(1092), new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(8502), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(8508), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(8509), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(8511), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(4078), new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(5206), new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(5210), new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 629, DateTimeKind.Local).AddTicks(8486), new DateTime(2026, 1, 21, 15, 25, 29, 631, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(380), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(387), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(389), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(390), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4009), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4445), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4446), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4447), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4448), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4449), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4450), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4434), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4437), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4438), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4439), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4440), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4441), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4442), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4444), new DateTime(2026, 1, 21, 15, 25, 29, 632, DateTimeKind.Local).AddTicks(4444) });
        }
    }
}
