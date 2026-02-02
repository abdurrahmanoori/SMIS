using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfsdfdfgfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EntityState", "LastModifiedUtc", "Name", "NormalizedName", "Version" },
                values: new object[,]
                {
                    { "1", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "SuperAdmin", "SUPERADMIN", 0 },
                    { "10", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopEditor", "RSHOPEDITOR", 0 },
                    { "11", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopUser", "RSHOPUSER", 0 },
                    { "2", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopAdmin", "WSHOPADMIN", 0 },
                    { "3", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopAdministration", "WSHOPADMINISTRATION", 0 },
                    { "4", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopViewer", "WSHOPVIEWER", 0 },
                    { "5", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopEditor", "WSHOPEDITOR", 0 },
                    { "6", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopUser", "WSHOPUSER", 0 },
                    { "7", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopAdmin", "RSHOPADMIN", 0 },
                    { "8", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopAdministration", "RSHOPADMINISTRATION", 0 },
                    { "9", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopViewer", "RSHOPVIEWER", 0 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49b33d77-b6d8-43e4-a949-aae8b88aa5f4", "6e081f8c-2f55-4537-a136-b1defbda8929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef6de8f5-c016-42dd-ad05-ab6ee03e4789", "91b79aed-a9f5-4eac-a387-b55f311489a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4f8a3f5-5c1b-4e1c-8613-19911de4304b", "13077145-e631-431b-af1a-8476c10a3421" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b6c2e28-316d-4000-969b-609fc2fd6b75", "89773f3c-a491-4210-86ba-56298365cf89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f98a1c29-0d61-40df-b652-f12948ef94d9", "27a2ca82-c202-4dc4-9f6d-80a5e97c16b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5fbf8cd6-8dc8-4e28-b181-609656d15451", "76cdf9b3-a2f1-4737-add2-a14f17b3584f" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(7725), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(5984), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Unspecified).AddTicks(5988), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(5996), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Unspecified).AddTicks(5996), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(5998), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Unspecified).AddTicks(5998), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(5999), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Unspecified).AddTicks(5999), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(6000), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Unspecified).AddTicks(6000), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 907, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(5749), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(5754), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(5916), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(5920), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(5921), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(5924), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(5835), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 905, DateTimeKind.Local).AddTicks(388), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 905, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 905, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5696), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5705), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5713), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5716), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5721), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5725), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5730), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5738), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5745), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5748), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(3509), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(3526), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(4688), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(4695), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5585), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5592), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5605), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5619), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5628), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5631), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5636), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5688), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 906, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 906, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(4885), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7714), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7721), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7729), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7733), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7805), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7811), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7815), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7819), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7678), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7822), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7833), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7837), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7845), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7855), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7859), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7696), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 896, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4480), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4909), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4913), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4876), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4880), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4884), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4894), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4903), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(3915), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(3922), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(4079), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4083), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(4084), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(4088), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(4091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 903, DateTimeKind.Local).AddTicks(4033), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(4042), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 903, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 904, DateTimeKind.Local).AddTicks(5481), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 904, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 904, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 904, DateTimeKind.Local).AddTicks(6072), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 904, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 904, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 897, DateTimeKind.Local).AddTicks(2031), new DateTime(2026, 8, 2, 11, 15, 25, 896, DateTimeKind.Utc).AddTicks(9809), new DateTime(2026, 1, 23, 11, 15, 25, 896, DateTimeKind.Utc).AddTicks(9778), new DateTime(2026, 2, 2, 15, 45, 25, 898, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 899, DateTimeKind.Local).AddTicks(699), new DateTime(2026, 9, 2, 11, 15, 25, 899, DateTimeKind.Utc).AddTicks(647), new DateTime(2026, 1, 28, 11, 15, 25, 899, DateTimeKind.Utc).AddTicks(645), new DateTime(2026, 2, 2, 15, 45, 25, 899, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 899, DateTimeKind.Local).AddTicks(2429), new DateTime(2026, 5, 2, 11, 15, 25, 899, DateTimeKind.Utc).AddTicks(2418), new DateTime(2026, 1, 18, 11, 15, 25, 899, DateTimeKind.Utc).AddTicks(2416), new DateTime(2026, 2, 2, 15, 45, 25, 899, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 899, DateTimeKind.Local).AddTicks(4350), new DateTime(2026, 1, 13, 11, 15, 25, 899, DateTimeKind.Utc).AddTicks(4330), new DateTime(2026, 2, 2, 15, 45, 25, 899, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 900, DateTimeKind.Local).AddTicks(1704), new DateTime(2026, 2, 2, 15, 45, 25, 900, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(213), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 900, DateTimeKind.Local).AddTicks(8007), new DateTime(2026, 2, 2, 15, 45, 25, 900, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 900, DateTimeKind.Local).AddTicks(9430), new DateTime(2026, 2, 2, 15, 45, 25, 900, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(167), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(178), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(185), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(190), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(197), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(207), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8144), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(8429), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8815), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8821), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(8824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8825), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(8828), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8829), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(8831), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8832), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(8835), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8836), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8840), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 901, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 901, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(769), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(778), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1099), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1103), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1103), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1107), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1110), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1021), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1025), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1027), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1030), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1031), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1033), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1034), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1037), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1038), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1041), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1042), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1045), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1048), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1049), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(1098), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 15, 45, 25, 902, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 902, DateTimeKind.Unspecified).AddTicks(7943), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(1997), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(977), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(1572), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(1967), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(1973), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(1978), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(1982), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(1986), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 15, 25, 903, DateTimeKind.Unspecified).AddTicks(1990), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1405c30d-dceb-4440-bda3-57f11021fb6c", "94d41659-8c89-4d56-9b65-e24f31853b3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2835f88c-cfa2-4351-82a6-fca8b3cd8df5", "c6fa9d36-8a35-47be-85d9-b177cf3a32a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4a9471cc-395d-4754-81c9-07dc65cadc99", "5853bbed-afaf-4f7e-a6bf-cb2738bd3de3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36c3325c-a147-407e-8c4c-8fba92a3d68e", "4be10e78-53af-41d5-802c-7a9e1072384d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d33e60af-ac4f-4292-88f9-a94bfae29f72", "c57f22d7-7876-407e-8a43-001b884f5aca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a45a9a3d-1037-48ba-93dc-33ad5d1bd73b", "8b8369ee-6ffc-4218-aaa3-c02dbd4bbf1b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(7984), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Unspecified).AddTicks(8014), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2442), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2447), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2471), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2472), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2475), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2476), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2477), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2480), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2481), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(7041), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(7061), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(8007), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(8032), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(8035), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(8046), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 531, DateTimeKind.Unspecified).AddTicks(9013), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 531, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 531, DateTimeKind.Unspecified).AddTicks(9920), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 542, DateTimeKind.Local).AddTicks(491), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 542, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 542, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4334), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4350), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4364), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4377), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4379), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4391), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4396), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4407), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4420), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4423), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 544, DateTimeKind.Local).AddTicks(8321), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 544, DateTimeKind.Unspecified).AddTicks(8343), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 544, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(1484), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(1500), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4150), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4165), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4223), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4228), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4251), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4266), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4284), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4304), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4307), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4319), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4322), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 524, DateTimeKind.Unspecified).AddTicks(3430), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(336), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(350), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(355), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(361), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(372), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(378), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(459), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(465), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(481), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(500), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(297), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(309), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(314), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(1013), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3378), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3385), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3178), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3187), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3196), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3201), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3364), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(6896), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 535, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7536), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 535, DateTimeKind.Unspecified).AddTicks(7563), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7567), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 535, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7580), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 535, DateTimeKind.Unspecified).AddTicks(7590), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 538, DateTimeKind.Local).AddTicks(9848), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(9884), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 538, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 541, DateTimeKind.Local).AddTicks(642), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 541, DateTimeKind.Unspecified).AddTicks(686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 541, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 541, DateTimeKind.Local).AddTicks(1676), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 541, DateTimeKind.Unspecified).AddTicks(1760), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 541, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 525, DateTimeKind.Local).AddTicks(9043), new DateTime(2026, 8, 1, 16, 19, 5, 525, DateTimeKind.Utc).AddTicks(4154), new DateTime(2026, 1, 22, 16, 19, 5, 525, DateTimeKind.Utc).AddTicks(4109), new DateTime(2026, 2, 1, 20, 49, 5, 527, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 528, DateTimeKind.Local).AddTicks(5729), new DateTime(2026, 9, 1, 16, 19, 5, 528, DateTimeKind.Utc).AddTicks(5685), new DateTime(2026, 1, 27, 16, 19, 5, 528, DateTimeKind.Utc).AddTicks(5683), new DateTime(2026, 2, 1, 20, 49, 5, 528, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 528, DateTimeKind.Local).AddTicks(8883), new DateTime(2026, 5, 1, 16, 19, 5, 528, DateTimeKind.Utc).AddTicks(8867), new DateTime(2026, 1, 17, 16, 19, 5, 528, DateTimeKind.Utc).AddTicks(8864), new DateTime(2026, 2, 1, 20, 49, 5, 528, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 529, DateTimeKind.Local).AddTicks(868), new DateTime(2026, 1, 12, 16, 19, 5, 529, DateTimeKind.Utc).AddTicks(854), new DateTime(2026, 2, 1, 20, 49, 5, 529, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 529, DateTimeKind.Local).AddTicks(8283), new DateTime(2026, 2, 1, 20, 49, 5, 529, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5643), new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(336), new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(3343), new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5434), new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5487), new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5520), new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5549), new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5577), new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5607), new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(4790), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(5476), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(8923), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(8955), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(8960), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9130), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9134), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9143), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9145), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9152), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9155), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9174), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9181), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9184), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9190), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(1248), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(1303), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3683), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3690), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3704), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3707), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3561), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3583), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3596), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3606), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3609), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3622), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3646), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3649), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3656), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3666), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3669), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3678), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 537, DateTimeKind.Unspecified).AddTicks(4858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(5059), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4077), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4904), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4929), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4936), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4942), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4948), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(5054), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
