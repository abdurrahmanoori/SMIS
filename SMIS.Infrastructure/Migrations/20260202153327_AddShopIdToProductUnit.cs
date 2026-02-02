using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddShopIdToProductUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopId",
                table: "ProductUnit",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "ProductUnit",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b4e82f3-1c20-4fe8-95cf-19d2e96ad637", "AQAAAAIAAYagAAAAEEp4zOZxOMtsK5R9WdIGaDRNKU+AJlbdDiORJXUBYHke/Wxs7EPMJYZ7Orx5htj3fg==", "b76231e3-3734-4a26-80e8-fee238b76a21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f75f3b11-0a13-46b7-990d-71c2ed819a29", "AQAAAAIAAYagAAAAEINDq8hiYXwdEnhUOdJH+QL6EeS9esTIz3NSe4VpAm4sHG3GHoUQDtSQ54tovmkRrA==", "803706bf-589f-4947-94f0-f51c08f1b229" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c05a2bfb-b8a1-4e51-9430-1cfd26b17950", "AQAAAAIAAYagAAAAEINtemQwCBoBQhgdbnPEd9Tju8Xcg96QMCwUeoTH1iBck5Q0bGC+mO/gtALcxD4LCw==", "598980f2-5c7d-4767-8413-306acc9aa24e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83b24b56-5ffe-499f-93f2-875da2f9a4db", "AQAAAAIAAYagAAAAEJqk1rLFwJBJR5JUqLdJNE5675YQ4Dt8IYRLyZ1DpWwSdjssei3I6+O0kuaWLC0tAw==", "325e6866-9ca2-4bb4-a2c0-854564fff5b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f34f5e-5d5c-4354-9aea-965b8e122e78", "AQAAAAIAAYagAAAAELntysho0Sc3jz0YunGwxZ7CVe8EA5Kl2Fr3Eeud3Mpd9nCn28n7JFvldCRzwHSw5g==", "ee9ee218-2a59-40e6-90e7-1cc70352489f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98569b3e-37a0-4b39-86f8-8cf581a6788d", "AQAAAAIAAYagAAAAEOp+JWKxZhPGw5IJpyP2VV3byj02Ql1DTOfAwGbccQvTdZ9AvMpOneP3lFYD4tfN+Q==", "ec050207-20f3-417c-a2c0-c8fcce7e9030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1c35a33-1feb-4f46-a94d-49926b3f4a3a", "AQAAAAIAAYagAAAAEKNpsUXRyOAfRmWWZEMD3PWepkgKhSnEnPBKnkKBKx+ieioGG0aA8I/dzDJmDWryyQ==", "8f0ec868-40d6-4aa8-8172-d4491cc0f7d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da839075-7d34-453f-acba-6a56f169bba4", "AQAAAAIAAYagAAAAEJRzymEJ2CKP1ztgeXezZR4+mVARZxlmuXCnMnq5TGpCqLUd16EFMM3OnpPd5Eo4hQ==", "2a2e8319-f4e1-4f5e-9abf-da8b09e830ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3a5523a-8c98-46fd-a9da-6632efecdc52", "AQAAAAIAAYagAAAAEGnctsCsv+DXg2nKo3PIYhxRm1mT6rQUH/8xvn+sPh+oY+7cNLOjYuGJLVf1pzXbqw==", "bbaf2899-4873-4f81-9dd0-d9c5d77c1c9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "104e5841-157d-4f06-8b5b-ab987f533aae", "AQAAAAIAAYagAAAAEE4QHb7ElsHGSCsKp1TF0VEHP9cOLnof5EQnB89IhyDjE3pss6ZcEyCKCoHCo/P7GA==", "2ab3a28d-9778-4b20-8b6d-8f752bfa3e9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10d90644-6a61-409b-9d6b-e1b53f2f169a", "AQAAAAIAAYagAAAAEKkJ2/4CXydLHkTgkH1cOc7QQ5NVJLbuTvFKOyWVZn3cI+b/bqs5RbOOMe8A1ArcKA==", "fcc8893c-ba4e-4f9e-8c97-75a293c43f42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "096d516b-bbd7-4bff-9e2c-754a63205234", "AQAAAAIAAYagAAAAEIkj3N8C1WNjG6qqCqgPvx2f+eTWk2FIosWx5+kKrMXKqEp0BHreUnQYgVaYoC6l/g==", "d934bd49-021a-4682-8e5c-cb6d085e095b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e5ff3a0-4ffd-424b-bcfd-5eab8bbab549", "AQAAAAIAAYagAAAAEMbZlPrGQV9Oc5D7B+CFcwjdcHF+xngvMIzj5yKMgzJut93hNmUy1dElakxd/E2hgQ==", "9df2acfe-c765-42d1-aaf2-9b25cf44f8f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b377e5a8-f194-48b2-88c3-1348adf08b6b", "AQAAAAIAAYagAAAAEI069g3vRtiiQ+Mb9g7myx2etiHbO0ZdZx/Pt0BmSHjX/flWsH3aGTbiJoy9XVUipw==", "7670dba8-a345-49d0-aff5-5092ddf16b08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d0341e5-834d-4d57-bdf2-a5495fabf9ad", "AQAAAAIAAYagAAAAEKBPM72BlW9RPzlS8UtkJ1lWAbQ2s2hz1seXcAoDHLxJzWLE85AXrpBWWPIv/NCrWg==", "40c6dfb1-ffb1-46d9-9a77-14d3021f4c41" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(5431), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Unspecified).AddTicks(5473), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(8976), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(8992), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9041), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9046), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(9047), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9049), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9052), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(9054), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(4835), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(4852), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(5508), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(5518), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(5519), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(5522), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 618, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 618, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 618, DateTimeKind.Unspecified).AddTicks(6628), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 630, DateTimeKind.Local).AddTicks(302), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 630, DateTimeKind.Unspecified).AddTicks(341), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 630, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(459), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(474), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(549), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(552), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(564), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(581), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(583), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(593), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(606), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 633, DateTimeKind.Local).AddTicks(2585), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 633, DateTimeKind.Unspecified).AddTicks(2635), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 633, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 633, DateTimeKind.Local).AddTicks(7064), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 633, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 633, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(288), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(360), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(385), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(398), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(411), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(413), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(424), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(427), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(446), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(448), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 442, DateTimeKind.Unspecified).AddTicks(4190), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7454), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7460), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7465), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7476), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7494), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7797), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7362), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7815), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7821), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7831), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7836), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7847), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7852), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7858), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7862), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7868), new TimeSpan(0, 0, 0, 0, 0)), "3", "Warehouse" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7405), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7427), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7433), new TimeSpan(0, 0, 0, 0, 0)), "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "LastModifiedUtc", "ShopId", "ShopName" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7437), new TimeSpan(0, 0, 0, 0, 0)), "2", "Branch Store" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(133), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1719), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1722), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1670), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1683), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1706), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1709), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1712), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8053), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 621, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8566), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 621, DateTimeKind.Unspecified).AddTicks(8574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8576), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 621, DateTimeKind.Unspecified).AddTicks(8578), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8580), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 621, DateTimeKind.Unspecified).AddTicks(8583), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 624, DateTimeKind.Local).AddTicks(9897), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(9933), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 624, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 628, DateTimeKind.Local).AddTicks(4827), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 628, DateTimeKind.Unspecified).AddTicks(4884), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 628, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 628, DateTimeKind.Local).AddTicks(6697), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 628, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 628, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 472, DateTimeKind.Local).AddTicks(9782), new DateTime(2026, 8, 2, 15, 33, 23, 472, DateTimeKind.Utc).AddTicks(2285), new DateTime(2026, 1, 23, 15, 33, 23, 472, DateTimeKind.Utc).AddTicks(2054), new DateTime(2026, 2, 2, 20, 3, 23, 476, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 478, DateTimeKind.Local).AddTicks(6770), new DateTime(2026, 9, 2, 15, 33, 23, 478, DateTimeKind.Utc).AddTicks(6673), new DateTime(2026, 1, 28, 15, 33, 23, 478, DateTimeKind.Utc).AddTicks(6666), new DateTime(2026, 2, 2, 20, 3, 23, 478, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 479, DateTimeKind.Local).AddTicks(1994), new DateTime(2026, 5, 2, 15, 33, 23, 479, DateTimeKind.Utc).AddTicks(1953), new DateTime(2026, 1, 18, 15, 33, 23, 479, DateTimeKind.Utc).AddTicks(1950), new DateTime(2026, 2, 2, 20, 3, 23, 479, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 479, DateTimeKind.Local).AddTicks(5429), new DateTime(2026, 1, 13, 15, 33, 23, 479, DateTimeKind.Utc).AddTicks(5412), new DateTime(2026, 2, 2, 20, 3, 23, 479, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 480, DateTimeKind.Local).AddTicks(7512), new DateTime(2026, 2, 2, 20, 3, 23, 480, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(30), new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(3450), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(7535), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9846), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9962), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9983), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9994), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(4), new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(20), new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(5533), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(6624), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8426), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8442), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8446), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8449), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8451), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8456), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8459), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8461), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8464), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8466), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8483), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(5399), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(5439), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6494), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6498), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6500), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6501), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6398), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6408), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6410), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6441), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6443), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6447), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6461), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6464), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6465), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6487), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6490), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6491), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6493), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 623, DateTimeKind.Unspecified).AddTicks(1311), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3348), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(804), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(2368), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3306), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3312), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3317), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_ShopId",
                table: "ProductUnit",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_Shop_ShopId",
                table: "ProductUnit",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_Shop_ShopId",
                table: "ProductUnit");

            migrationBuilder.DropIndex(
                name: "IX_ProductUnit_ShopId",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "ProductUnit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9facdc9-f0c4-4fd5-81d2-0d052fc3e6ad", "AQAAAAIAAYagAAAAEJlTsRLJGO1hFJZKileTT16i4IMcgupuYUwUFrCAdSjAC9yYgz2wEcL7ljhreCtpNw==", "d8999f81-4671-4c84-93fc-92038270e009" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00f975ee-c42d-4a2f-9b70-d0f9d57caaef", "AQAAAAIAAYagAAAAEAdv4om/OY7sHp8nPgSILMWKZgTNvPzHr1JFh8QaA93BxD2SfMl5stCvUeCDIQnigw==", "846fac22-e2e8-46e6-8b05-ee06bae74371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee54f1ef-7237-4fc1-869b-683302a12c9c", "AQAAAAIAAYagAAAAEBzKLB5oZOA2ldukl411OMZxzR/GWxFYTrUFe+f6erUiqthymiKlbNKkApyLbQpcQA==", "0d7cd615-9d67-4871-8acd-c9644899194a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "246e89e4-1f26-423a-bb2c-a186ab02a0ea", "AQAAAAIAAYagAAAAEP4ZX7tza4BIPRNrRDO1VnJrvxUI5hfzh8kj6QWCEVtIUS8q4Ajo7BffQmFDmjX2xA==", "cd99e351-6d27-4a2f-a451-705e4cb61ce7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02932d31-689e-4761-9017-266362398f9f", "AQAAAAIAAYagAAAAEJ0dRr2seenP2jM3cwN+SGIi2uQEdMZwhAE/REyHAglP/8W8cRhM0hooBlKWG0Zh8A==", "5c32663e-1b05-4ecd-8470-0026d2998664" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9a9ce7-4825-4a4d-ae36-354a28d658bf", "AQAAAAIAAYagAAAAEEpZe6JJRUlR1ggG8HSOPYGG4P4PRAz/d4Tsw+OiBdcMjg3wzFerTRAUE0DGPPE/8w==", "1a74b2f5-cd39-4bd8-aa3a-ce19ca7783ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0bf111c-82de-447f-91cd-b54000bcf1c4", "AQAAAAIAAYagAAAAEKWXRwmot2IkgdN/QXQW1ABIYOPpqLXe9lIcvn+lynEsA3lvoumwDlrQqSlaEUJiVA==", "e9a01a6c-35f5-4d05-85f1-c8b27207ee3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e7e2fc1-b240-4e0b-a24c-e5e3334a3a45", "AQAAAAIAAYagAAAAEBpyQNfiy+Pq4yn2f6xVYMZ/ZvMwByZpBT+0YppYoxfmCyyCX2HSyu900aKvbvDN8Q==", "3739eca6-564b-4602-80a5-bcab1195a946" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b53ddd99-d01a-4740-b66e-c1da8b725e7e", "AQAAAAIAAYagAAAAEDPIK2UaC/m4oT3qH6KBSuw0qQJLN9rpU5wqZtCgTBfVLyRiPnLh6hnoTQ+YjIWiLA==", "2863005f-87a7-4ee0-8dfa-293ba0797e3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5102cffe-6860-4285-a7d1-5ada3af0c5c8", "AQAAAAIAAYagAAAAEGIVzKG1jD/GJ2n1BNZ0hRDVfOwH5cvUSYII2qvu72Jxtzl/gqgbBZCZnR22UVwtzg==", "bcf5164d-da6d-4fe9-87ab-e6d82ef49695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb99e6e6-24cf-40e6-8630-acd167507b9c", "AQAAAAIAAYagAAAAEBAEPVVtc5fUl/n6u0hoPs/jSXIU2ndQ+3Obz51QxpUSbKe1NPWdyS95s9R8w2LiTg==", "106a6a5d-a8ae-49fe-afd7-8d352a4a128b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f42354bb-1777-4555-b7a4-dca7d93688e6", "AQAAAAIAAYagAAAAEBYHYxIQPF35nDNKnYW8n2RyJXBwtGGtkYySG+Hjq23bgqRhUqZqo+OMi8T0mNQybA==", "0ec7dfb1-8978-4991-98ad-fc814a5dc462" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "381c570a-c509-46ff-b667-bebe4b42a330", "AQAAAAIAAYagAAAAENLVzhQYX+dzPMgbMF97rhmM7g5R5FkMFYu59SCggqO6EiUeqG5QIKLiAlpke3OHcg==", "f0888707-649c-4db5-8554-24ad54d82eb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0de3c85-aa3c-49e2-bad3-f01d5ac681c2", "AQAAAAIAAYagAAAAEGk+U9IJ5n6mvntA0FRdS9WYiwqummylq7Uo3TtoirtI1dtfKz2+Uhik067LieP03w==", "a18b3a27-9821-45a8-825a-968a95be1e24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4340440-7148-4ef4-9a96-fcfc1e219b0d", "AQAAAAIAAYagAAAAELml67u53a9VP/M1TBsnGt3ti76bHlbw/tU21iVGlBpdOEVgIWxG55k27zcZdC+x/w==", "1ad58caa-c759-4e9b-a832-0fa5bb2b2206" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(6065), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Unspecified).AddTicks(6092), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4638), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4641), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4652), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4652), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4654), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4655), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4655), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4656), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4657), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3004), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(3025), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3268), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3274), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(3278), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(1772), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(1776), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 223, DateTimeKind.Local).AddTicks(3039), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 223, DateTimeKind.Unspecified).AddTicks(3073), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 223, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3637), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3641), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3649), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3652), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3671), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3682), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3700), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3711), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3716), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3723), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(1052), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(1096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(2596), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3489), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3495), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3512), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3524), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3535), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3545), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3561), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3564), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3572), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3605), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4077), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4085), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4089), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4155), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4166), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4034), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4178), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4188), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4191), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4194), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4206), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4209), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4212), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4055), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4066), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1911), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1918), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1921), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1924), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(420), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(442), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(576), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(581), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(582), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(586), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(587), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(590), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 221, DateTimeKind.Local).AddTicks(4200), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(4222), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 221, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(5930), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 222, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(6655), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 222, DateTimeKind.Unspecified).AddTicks(6665), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 615, DateTimeKind.Local).AddTicks(1642), new DateTime(2026, 8, 2, 11, 58, 25, 614, DateTimeKind.Utc).AddTicks(9355), new DateTime(2026, 1, 23, 11, 58, 25, 614, DateTimeKind.Utc).AddTicks(9320), new DateTime(2026, 2, 2, 16, 28, 25, 615, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(3244), new DateTime(2026, 9, 2, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(3225), new DateTime(2026, 1, 28, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(3223), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(4770), new DateTime(2026, 5, 2, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(4759), new DateTime(2026, 1, 18, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(4758), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(5537), new DateTime(2026, 1, 13, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(5502), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(9185), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5983), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(4230), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5234), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5938), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5949), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5955), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5962), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5968), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5974), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4230), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4925), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4929), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4931), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4973), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4974), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4978), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4979), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4990), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4994), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4994), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4998), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4999), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(6994), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7308), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7360), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7362), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7366), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7369), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7255), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7259), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7260), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7264), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7268), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7274), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7275), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7277), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7278), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7299), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7300), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7304), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7307), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(440), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1501), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
