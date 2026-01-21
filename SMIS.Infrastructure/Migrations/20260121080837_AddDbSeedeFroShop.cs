using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDbSeedeFroShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86282817-376a-42ad-947f-1611e67b264d", "AQAAAAIAAYagAAAAEIgY7+DydSdK9UAE5UIE/0iSHfxl+IDcQ1cCHMdIpqYh+TrzHIoRjZlWRzRroeJoiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a502a25-569e-44f3-9988-6f986e9db6fd", "AQAAAAIAAYagAAAAEN2GGpwqvwq8oR6eAi8InNPQQkKofWMALVKF8uXLZ88BmaIgoEf9RGfjGOSEubnoMA==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(3970), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(4113), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(4114), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1541), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1545), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1546), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1548), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "PublicId", "Address", "CreatedBy", "CreatedDate", "Email", "Id", "IsActive", "IsPublic", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(7539), "main@pharmacy.local", 1, true, false, "Main Pharmacy", "0700000001", 1, "TAX001", null, new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(7542) },
                    { "2", "Herat Center", null, new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(8264), "city@pharmacy.local", 2, true, false, "City Pharmacy", "0700000002", 2, "TAX002", null, new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(8265) },
                    { "3", "Kandahar Center", null, new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(8268), "health@store.local", 3, true, false, "Health Store", "0700000003", 1, "TAX003", null, new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(8268) }
                });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 968, DateTimeKind.Local).AddTicks(6936), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4807), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4810), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4812), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4813), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7685), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7936), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7938), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7939), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7940), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7941), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7942), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7926), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7928), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7929), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7931), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7932), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7933), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7934), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7935), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7936) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2bd06897-de6d-44af-a9e8-367affb98dd2", "AQAAAAIAAYagAAAAEFo4Wk1Z/eb0FMgSjCDrXoXvdqDejQDSa+rz/e6aWsHwjfGy9GJPT/fJt95/Rwz0Dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09fe8ffd-72a4-48b4-8cc6-c624495f812f", "AQAAAAIAAYagAAAAEFv8//Id7RqUsttTrZJblZittfzfLieQup5NsMS+t3mANiiHbDAEKgJhBGFty5mYEQ==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(9899), new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 325, DateTimeKind.Local).AddTicks(231), new DateTime(2026, 1, 21, 12, 35, 16, 325, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 325, DateTimeKind.Local).AddTicks(236), new DateTime(2026, 1, 21, 12, 35, 16, 325, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5024), new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5033), new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5035), new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5037), new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 321, DateTimeKind.Local).AddTicks(3143), new DateTime(2026, 1, 21, 12, 35, 16, 322, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2232), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2240), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2243), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2245), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(7603), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8310), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8312), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8314), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8316), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8318), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8319), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8291), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8297), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8299), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8301), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8303), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8305), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8307), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8309), new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8309) });
        }
    }
}
