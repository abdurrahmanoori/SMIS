using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class shopEnityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ShopType = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    TaxNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(4816), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(4975), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(4593), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5120), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5121), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5119), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5128), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5129), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5127), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5134), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5135), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5134), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5140), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5141), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5140), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5145), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5146), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5145), new DateTime(2026, 4, 8, 16, 31, 14, 820, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedAt", "Email", "EntityState", "IsActive", "IsDeleted", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3736), null, "main@store.local", "Unchanged", true, false, true, new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3738), new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3595), "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3737) },
                    { "2", "Herat Center", null, new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3983), null, "branch@store.local", "Unchanged", true, false, true, new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3984), new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3982), "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3984) },
                    { "3", "Kandahar Center", null, new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3997), null, "warehouse@store.local", "Unchanged", true, false, true, new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3998), new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3997), "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 4, 8, 16, 31, 14, 829, DateTimeKind.Local).AddTicks(3998) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shops_IsSyncedToServer",
                table: "Shops",
                column: "IsSyncedToServer");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_LastModifiedUtc",
                table: "Shops",
                column: "LastModifiedUtc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(6005), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(7334), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(4968), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8123), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8126), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8121), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8156), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8158), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8155), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8167), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8168), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8166), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8205), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8207), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8204), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8216), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8217), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8215), new DateTime(2026, 3, 26, 23, 47, 4, 749, DateTimeKind.Local).AddTicks(8216) });
        }
    }
}
