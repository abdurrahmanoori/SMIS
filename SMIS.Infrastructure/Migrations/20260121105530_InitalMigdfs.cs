using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitalMigdfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShopType",
                table: "Shops",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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
                columns: new[] { "CreatedDate", "ShopType", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(4078), "RetailShop", new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ShopType", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(5206), "WholesaleShop", new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ShopType", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(5210), "RetailShop", new DateTime(2026, 1, 21, 15, 25, 29, 633, DateTimeKind.Local).AddTicks(5210) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ShopType",
                table: "Shops",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "706ca6d0-69a8-456c-9fa4-f7a677b4a089", "AQAAAAIAAYagAAAAEGcfTMnAhd1vwdVvDvoa2q8fSRU5Mn/iKyL+KzLbxyiGNmKEST9aAjzAeousDa4pZg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "298e1b4f-240e-4626-8500-2cef7559495a", "AQAAAAIAAYagAAAAEPEoAISbUASJ9c2RBAxVW7iwkwzVmgQ5awsb2rA6XEzwrmA/XfOy28GZYil/yIae7w==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2251), new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2371), new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2373), new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(182), new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(188), new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(190), new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(191), new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ShopType", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(4916), 1, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ShopType", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(5463), 2, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ShopType", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(5466), 1, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 802, DateTimeKind.Local).AddTicks(4732), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3254), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3260), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3262), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3263), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6213), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6478), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6479), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6481), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6482), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6483), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6484), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6468), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6470), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6471), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6472), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6473), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6475), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6476), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6477), new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6477) });
        }
    }
}
