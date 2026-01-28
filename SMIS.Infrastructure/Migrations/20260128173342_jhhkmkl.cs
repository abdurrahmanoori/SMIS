using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class jhhkmkl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37abbd11-7733-4fdc-88e6-c9239bec2432", "AQAAAAIAAYagAAAAEI1iT25XrohV/uqHygRIoiyo/wH7jLL/Ru2sr51iV+1F294J/v42icpjFBxbU4EfpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "231ad4ff-2cf3-4422-a9ba-037061ce04c2", "AQAAAAIAAYagAAAAEC7EO0AU7A8MdnTA6uq2mIBbTfyUtCkdv/2r/ZSioR9xXQ8e7OjoPJ0clA8Srj+H9g==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(7177), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(7206), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Code", "CreatedDate", "Description", "LastModifiedUtc", "Name", "UpdatedDate" },
                values: new object[] { "FOOD", new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8241), "Edible products and snacks", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8254), new TimeSpan(0, 0, 0, 0, 0)), "Food Items", new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Code", "CreatedDate", "Description", "LastModifiedUtc", "Name", "UpdatedDate" },
                values: new object[] { "STAT", new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8257), "Office and school supplies", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8260), new TimeSpan(0, 0, 0, 0, 0)), "Stationery", new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "State", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "4", "GROC", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8262), "Daily household items", true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 0, 0, 0, 0)), "Grocery", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8262), 0 },
                    { "5", "CARE", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8266), "Health and hygiene products", true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8268), new TimeSpan(0, 0, 0, 0, 0)), "Personal Care", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8266), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8270), "Electronic devices and accessories", true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(8272), new TimeSpan(0, 0, 0, 0, 0)), "Electronics", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(8271), 0 }
                });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1105), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(1127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1441), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1453), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 534, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 529, DateTimeKind.Unspecified).AddTicks(2034), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 529, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 529, DateTimeKind.Unspecified).AddTicks(2872), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Barcode", "BaseUnitId", "CreatedDate", "Description", "ImageUrl", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { "1234567890001", "2", new DateTime(2026, 1, 28, 22, 3, 40, 552, DateTimeKind.Local).AddTicks(9994), "Classic cola drink", null, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(62), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "COKE-500ML-001", 150, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Barcode", "BaseUnitId", "CreatedDate", "Description", "ImageUrl", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { "1234567890002", "2", new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2418), "Cola soft drink", null, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "PEPSI-500ML-002", 140, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Barcode", "BaseUnitId", "CategoryId", "CreatedDate", "Description", "ImageUrl", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { "1234567890003", "2", "1", new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2440), "Pure drinking water", null, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2443), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "WATER-1L-003", 80, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "ShopId", "State", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "4", "1234567890004", "3", "2", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2451), "Chocolate sandwich cookies", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2453), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "OREO-PACK-004", 250, "1", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2451), 0 },
                    { "5", "1234567890005", "3", "2", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2456), "Potato chips", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2458), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "LAYS-PACK-005", 180, "2", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2456), 0 },
                    { "6", "1234567890006", "3", "2", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2461), "Quick meal noodles", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "NOODLE-PACK-006", 120, "3", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2461), 0 },
                    { "7", "1234567890007", "1", "3", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2466), "200 pages ruled notebook", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2468), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "NOTE-A4-007", 300, "1", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2466), 0 },
                    { "8", "1234567890008", "1", "3", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2470), "Ballpoint pen", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "PEN-BLUE-008", 50, "2", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2471), 0 },
                    { "9", "1234567890009", "4", "3", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2475), "12 pencils per box", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2490), new TimeSpan(0, 0, 0, 0, 0)), "Pencil Set", "PENCIL-BOX-009", 400, "3", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2476), 0 }
                });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConversionFactor", "LastModifiedUtc", "UnitOfMeasureId" },
                values: new object[] { 12m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(7433), new TimeSpan(0, 0, 0, 0, 0)), "4" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConversionFactor", "LastModifiedUtc", "UnitOfMeasureId" },
                values: new object[] { 24m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8734), new TimeSpan(0, 0, 0, 0, 0)), "5" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "UnitOfMeasureId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8739), new TimeSpan(0, 0, 0, 0, 0)), "4" });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "LastModifiedUtc", "ProductId", "State", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "4", 24m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8742), new TimeSpan(0, 0, 0, 0, 0)), "2", 4, "5", 0 },
                    { "5", 6m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 0, 0, 0, 0)), "3", 4, "4", 0 },
                    { "6", 12m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8747), new TimeSpan(0, 0, 0, 0, 0)), "3", 4, "5", 0 }
                });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(7067), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8504), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8473), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8477), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8480), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8493), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(8496), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5329), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5405), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(5407), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5409), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(5421), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5423), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 533, DateTimeKind.Unspecified).AddTicks(5426), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 533, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 535, DateTimeKind.Local).AddTicks(4468), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 535, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 535, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 551, DateTimeKind.Local).AddTicks(5297), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 551, DateTimeKind.Unspecified).AddTicks(5366), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 551, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 551, DateTimeKind.Local).AddTicks(7164), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 551, DateTimeKind.Unspecified).AddTicks(7181), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 551, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 529, DateTimeKind.Local).AddTicks(7728), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4777), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4793), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4796), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4801), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4803), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4805), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4807), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4809), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4811), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4813), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4831), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4833), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 531, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 531, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(21), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(40), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(787), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(790), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(791), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(793), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(795), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(797), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(736), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(751), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(754), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(755), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(760), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(761), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(763), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(765), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(768), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(769), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(780), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(782), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(784), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 532, DateTimeKind.Unspecified).AddTicks(786), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 22, 3, 40, 532, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Description", "LastModifiedUtc" },
                values: new object[] { "Individual items", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Description", "LastModifiedUtc", "Name", "Symbol" },
                values: new object[] { "Liquid containers", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9684), new TimeSpan(0, 0, 0, 0, 0)), "Bottle", "btl" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Description", "LastModifiedUtc", "Name", "Symbol" },
                values: new object[] { "Small packages", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9700), new TimeSpan(0, 0, 0, 0, 0)), "Pack", "pk" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Description", "LastModifiedUtc" },
                values: new object[] { "Medium containers", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Description", "LastModifiedUtc", "Name", "Symbol" },
                values: new object[] { "Large containers", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9708), new TimeSpan(0, 0, 0, 0, 0)), "Carton", "ctn" });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "LastModifiedUtc", "Name", "State", "Symbol", "Version" },
                values: new object[,]
                {
                    { "10", "12 pieces", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 0, 0, 0, 0)), "Dozen", 4, "dz", 0 },
                    { "6", "Volume measurement", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9797), new TimeSpan(0, 0, 0, 0, 0)), "Liter", 4, "L", 0 },
                    { "7", "Weight measurement", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9800), new TimeSpan(0, 0, 0, 0, 0)), "Kilogram", 4, "kg", 0 },
                    { "8", "Small weight measurement", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9803), new TimeSpan(0, 0, 0, 0, 0)), "Gram", 4, "g", 0 },
                    { "9", "Small volume measurement", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 534, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)), "Milliliter", 4, "ml", 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "ShopId", "State", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "10", "1234567890010", "2", "4", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2492), "Sunflower cooking oil", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2495), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "OIL-1L-010", 450, "1", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2493), 0 },
                    { "11", "1234567890011", "7", "4", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2497), "Basmati rice", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "RICE-1KG-011", 280, "2", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2498), 0 },
                    { "12", "1234567890012", "7", "4", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2502), "White granulated sugar", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "SUGAR-1KG-012", 200, "3", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2502), 0 },
                    { "13", "1234567890013", "2", "5", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2506), "Hair care shampoo", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2509), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "SHAMP-400ML-013", 350, "1", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2507), 0 },
                    { "14", "1234567890014", "1", "5", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2511), "Dental care paste", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "TOOTH-PASTE-014", 180, "2", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2512), 0 },
                    { "15", "1234567890015", "1", "6", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2516), "Type-C charging cable", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "USB-CABLE-015", 250, "1", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2516), 0 },
                    { "16", "1234567890016", "1", "6", null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2521), "Fast charging adapter", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 553, DateTimeKind.Unspecified).AddTicks(2523), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "CHARGER-016", 800, "3", 0, null, new DateTime(2026, 1, 28, 22, 3, 40, 553, DateTimeKind.Local).AddTicks(2521), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "LastModifiedUtc", "ProductId", "State", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "10", 60m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 0, 0, 0, 0)), "5", 4, "5", 0 },
                    { "11", 24m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 0, 0, 0, 0)), "6", 4, "4", 0 },
                    { "12", 72m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8786), new TimeSpan(0, 0, 0, 0, 0)), "6", 4, "5", 0 },
                    { "13", 12m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8788), new TimeSpan(0, 0, 0, 0, 0)), "7", 4, "10", 0 },
                    { "14", 50m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8791), new TimeSpan(0, 0, 0, 0, 0)), "7", 4, "4", 0 },
                    { "15", 12m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8794), new TimeSpan(0, 0, 0, 0, 0)), "8", 4, "10", 0 },
                    { "16", 144m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8797), new TimeSpan(0, 0, 0, 0, 0)), "8", 4, "4", 0 },
                    { "17", 20m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 0, 0, 0, 0)), "9", 4, "5", 0 },
                    { "7", 12m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 0, 0, 0, 0)), "4", 4, "4", 0 },
                    { "8", 48m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8753), new TimeSpan(0, 0, 0, 0, 0)), "4", 4, "5", 0 },
                    { "9", 20m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 0, 0, 0, 0)), "5", 4, "4", 0 },
                    { "18", 12m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 0, 0, 0, 0)), "10", 4, "4", 0 },
                    { "19", 24m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 0, 0, 0, 0)), "10", 4, "5", 0 },
                    { "20", 10m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8811), new TimeSpan(0, 0, 0, 0, 0)), "11", 4, "4", 0 },
                    { "21", 25m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 0, 0, 0, 0)), "11", 4, "5", 0 },
                    { "22", 20m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 0, 0, 0, 0)), "12", 4, "4", 0 },
                    { "23", 50m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 0, 0, 0, 0)), "12", 4, "5", 0 },
                    { "24", 12m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8825), new TimeSpan(0, 0, 0, 0, 0)), "13", 4, "4", 0 },
                    { "25", 24m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 0, 0, 0, 0)), "13", 4, "5", 0 },
                    { "26", 24m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8834), new TimeSpan(0, 0, 0, 0, 0)), "14", 4, "4", 0 },
                    { "27", 72m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 0, 0, 0, 0)), "14", 4, "5", 0 },
                    { "28", 50m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, 0, 0, 0, 0)), "15", 4, "4", 0 },
                    { "29", 200m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8842), new TimeSpan(0, 0, 0, 0, 0)), "15", 4, "5", 0 },
                    { "30", 20m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8903), new TimeSpan(0, 0, 0, 0, 0)), "16", 4, "4", 0 },
                    { "31", 100m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 33, 40, 528, DateTimeKind.Unspecified).AddTicks(8906), new TimeSpan(0, 0, 0, 0, 0)), "16", 4, "5", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0a55957-6b8e-48e3-a77b-5c3b2923589b", "AQAAAAIAAYagAAAAEGQO+W489EBVXpjyYT/WUWDT/KwUOX8k6gmJ+Sn6vmBHTG28Xl89uHHQlr8Oy7NPIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7392b5e7-a8ab-4a2c-aece-7525326a1ff9", "AQAAAAIAAYagAAAAEFsLYGt6ppZqYnrFxybZKAMvh/9ZQrOu079x2HZ1IyhEcq9qD3j31fn3iFc0NLtp0Q==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(3405), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(3420), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Code", "CreatedDate", "Description", "LastModifiedUtc", "Name", "UpdatedDate" },
                values: new object[] { "SOFT", new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(4269), "Carbonated and non-carbonated drinks", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(4279), new TimeSpan(0, 0, 0, 0, 0)), "Soft Drinks", new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Code", "CreatedDate", "Description", "LastModifiedUtc", "Name", "UpdatedDate" },
                values: new object[] { "FOOD", new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(4281), "Edible products", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(4284), new TimeSpan(0, 0, 0, 0, 0)), "Food Items", new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(6759), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(7070), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(7079), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(7081), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 632, DateTimeKind.Unspecified).AddTicks(21), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 632, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 632, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Barcode", "BaseUnitId", "CreatedDate", "Description", "ImageUrl", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { "1234567890123", "1", new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(7950), "Pain reliever", "https://example.com/images/paracetamol.jpg", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 651, DateTimeKind.Unspecified).AddTicks(7968), new TimeSpan(0, 0, 0, 0, 0)), "Paracetamol 500mg", "PAR-500MG-001", 50, new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Barcode", "BaseUnitId", "CreatedDate", "Description", "ImageUrl", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { "1234567890124", "1", new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(420), "Anti-inflammatory", "https://example.com/images/ibuprofen.jpg", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(432), new TimeSpan(0, 0, 0, 0, 0)), "Ibuprofen 200mg", "IBU-200MG-002", 30, new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Barcode", "BaseUnitId", "CategoryId", "CreatedDate", "Description", "ImageUrl", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { "1234567890125", "1", "2", new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(436), "Blood thinner", "https://example.com/images/aspirin.jpg", new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 652, DateTimeKind.Unspecified).AddTicks(439), new TimeSpan(0, 0, 0, 0, 0)), "Aspirin 100mg", "ASP-100MG-003", 20, new DateTime(2026, 1, 28, 21, 58, 34, 652, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConversionFactor", "LastModifiedUtc", "UnitOfMeasureId" },
                values: new object[] { 10m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 631, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConversionFactor", "LastModifiedUtc", "UnitOfMeasureId" },
                values: new object[] { 100m, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 631, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 0, 0, 0, 0)), "2" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "UnitOfMeasureId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 631, DateTimeKind.Unspecified).AddTicks(7220), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4544), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4547), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4502), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4509), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4512), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4523), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4526), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(4529), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2042), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(2058), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2061), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(2064), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2065), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(2073), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2074), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(2077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 635, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 636, DateTimeKind.Local).AddTicks(4533), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 636, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(2043), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 651, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(3348), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 651, DateTimeKind.Unspecified).AddTicks(3377), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 651, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 632, DateTimeKind.Local).AddTicks(5788), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 633, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 633, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(27), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(42), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(45), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(71), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(74), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(75), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(77), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(78), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(89), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(91), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(93), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(4844), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5512), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5514), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5515), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5517), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5519), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5521), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5467), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5478), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5481), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5482), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5484), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5486), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5488), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5490), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5493), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5494), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5504), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5505), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5507), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5509), new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 634, DateTimeKind.Unspecified).AddTicks(5511), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 28, 21, 58, 34, 634, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Description", "LastModifiedUtc" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 635, DateTimeKind.Unspecified).AddTicks(9941), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Description", "LastModifiedUtc", "Name", "Symbol" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(540), new TimeSpan(0, 0, 0, 0, 0)), "Gram", "g" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Description", "LastModifiedUtc", "Name", "Symbol" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(544), new TimeSpan(0, 0, 0, 0, 0)), "Milliliter", "ml" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Description", "LastModifiedUtc" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(546), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Description", "LastModifiedUtc", "Name", "Symbol" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2026, 1, 28, 17, 28, 34, 636, DateTimeKind.Unspecified).AddTicks(549), new TimeSpan(0, 0, 0, 0, 0)), "Bottle", "btl" });
        }
    }
}
