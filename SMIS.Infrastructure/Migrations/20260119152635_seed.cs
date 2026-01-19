using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "0190ce58-1112-4f55-a90a-e96e11c32d12");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "12e54a53-152d-49da-a420-901848d7d327");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "217a1115-ec3c-4cb9-af45-340aa1a9ac93");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "308ae1f8-abad-4908-8523-b5f25f87ab78");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "37bd2739-be75-46d5-990b-e834444af56c");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "3e85fb43-d242-4a91-a1bf-bd39def471ec");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "728aeec2-4c25-4335-b4f4-94012c22433b");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "77c6fc32-80ad-4808-8d65-e1382622590d");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "82391871-5c0e-40f1-8b6a-0bd5001d0527");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "a6783979-a527-4426-a2ca-5d1b42993a84");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "a72f57b6-5b63-4af8-b786-1d44ed4235f5");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "b482a6e7-6790-4f2f-84c5-85a29342ea9a");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "bf128153-1822-405c-af47-35c9404d478f");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "d234cb50-a752-4692-b110-491df6ce1986");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "daa72ad0-7b53-4f9c-a965-58421ff5fad3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c115599-c02c-49a0-a016-0bd4674274e3", "AQAAAAIAAYagAAAAEMMSO8VPFQU1um5Jf6+4hLBm9Ttr5sFwNbf6QZZOc95j3dXdKH9MbuFJWENjnDbSXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5d678c6-6a0c-40f4-96c8-02554c0c890e", "AQAAAAIAAYagAAAAEL7xJw4Awx64PkS1D2rJdNJQMLf5UNpqmLCH0rnc/3ef8uugt/iU5TXmnOeU/jD3GQ==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-herat-center-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 870, DateTimeKind.Local).AddTicks(2493), new DateTime(2026, 1, 19, 19, 56, 33, 870, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-kabul-center-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 870, DateTimeKind.Local).AddTicks(2117), new DateTime(2026, 1, 19, 19, 56, 33, 870, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-kabul-north-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 870, DateTimeKind.Local).AddTicks(2480), new DateTime(2026, 1, 19, 19, 56, 33, 870, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 869, DateTimeKind.Local).AddTicks(6319), "09e942d8-8520-4ae1-9518-5e4ef8a1d909", new DateTime(2026, 1, 19, 19, 56, 33, 869, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 869, DateTimeKind.Local).AddTicks(6358), "4f23fe62-2e17-452b-8abc-36664ccc9d08", new DateTime(2026, 1, 19, 19, 56, 33, 869, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 869, DateTimeKind.Local).AddTicks(6362), "6bce773d-28b3-4349-8739-2714fa8ef291", new DateTime(2026, 1, 19, 19, 56, 33, 869, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 869, DateTimeKind.Local).AddTicks(6365), "973f4757-7d32-499a-9e2c-cb7685bc5c18", new DateTime(2026, 1, 19, 19, 56, 33, 869, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_herat_center",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(2639), new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_kabul_center",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 866, DateTimeKind.Local).AddTicks(7187), new DateTime(2026, 1, 19, 19, 56, 33, 867, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_kabul_north",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(2622), new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "province_herat",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(2646), new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "province_kabul",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(2643), new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsPublic", "LanguageNo", "Name", "TranslationKeyPublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "0dd05a1b-6cb0-40e4-9add-0637471cfb79", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8838), 9, false, 3, "", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8838) },
                    { "18d0ade6-1047-4c77-bb19-a3910717fe01", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8791), 5, false, 2, "", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8791) },
                    { "311fff13-a944-4768-9e85-ea4d7a6c5825", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8824), 7, false, 1, "", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8824) },
                    { "462fd37e-4c02-42bf-946b-799c5e22024d", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8849), 13, false, 1, "", "province_herat", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8849) },
                    { "46cb7ca1-4a43-47f5-b49e-8b1daa4c4c9f", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8843), 11, false, 2, "", "province_kabul", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8844) },
                    { "4b117deb-9a69-4e49-8b56-3618127edc62", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8851), 14, false, 2, "", "province_herat", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8852) },
                    { "5b0e233e-c804-417d-8575-4c2af651867e", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8821), 6, false, 3, "", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8821) },
                    { "5ded76fc-9fd6-43f6-a168-4e592827699c", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8846), 12, false, 3, "", "province_kabul", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8846) },
                    { "70937a31-eb87-412b-af7c-01e0ef078972", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8771), 2, false, 2, "", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8774) },
                    { "70f47b9b-6235-43cd-9403-fa8a19b497ab", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8081), 1, false, 1, "", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8085) },
                    { "71c75022-5237-4d52-b043-8573033d7542", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8784), 3, false, 3, "", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8785) },
                    { "9f4c961e-c323-4a13-9263-f649575d1c4b", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8854), 15, false, 3, "", "province_herat", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8855) },
                    { "c0e5b266-9e16-4ae1-835a-b3d02f3f94ca", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8787), 4, false, 1, "", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8788) },
                    { "cac3e32e-92fc-40e5-bd2b-8341a5489792", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8840), 10, false, 1, "", "province_kabul", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8841) },
                    { "f08664da-f030-4d0c-bb99-c71ee1364092", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8827), 8, false, 2, "", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 56, 33, 868, DateTimeKind.Local).AddTicks(8827) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "0dd05a1b-6cb0-40e4-9add-0637471cfb79");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "18d0ade6-1047-4c77-bb19-a3910717fe01");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "311fff13-a944-4768-9e85-ea4d7a6c5825");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "462fd37e-4c02-42bf-946b-799c5e22024d");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "46cb7ca1-4a43-47f5-b49e-8b1daa4c4c9f");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "4b117deb-9a69-4e49-8b56-3618127edc62");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "5b0e233e-c804-417d-8575-4c2af651867e");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "5ded76fc-9fd6-43f6-a168-4e592827699c");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "70937a31-eb87-412b-af7c-01e0ef078972");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "70f47b9b-6235-43cd-9403-fa8a19b497ab");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "71c75022-5237-4d52-b043-8573033d7542");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "9f4c961e-c323-4a13-9263-f649575d1c4b");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "c0e5b266-9e16-4ae1-835a-b3d02f3f94ca");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "cac3e32e-92fc-40e5-bd2b-8341a5489792");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "f08664da-f030-4d0c-bb99-c71ee1364092");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3f098f9-4fb4-4c8e-b7cb-a59df53a4be6", "AQAAAAIAAYagAAAAENTsGBYh0SKmnXk8SlGYXwVstdvixnSoCYYN+DjreLtIDgS4P2KGIbBwmoH6iwjgJg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de2bbebf-b2c2-496a-8840-edeeca5c6f13", "AQAAAAIAAYagAAAAECRZANrhX+c12xSiLOSnxy8vhaDYhxMIZXRintS5RMT0zZaEuDHe2HlbQ5urFyK62g==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-herat-center-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1584), new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-kabul-center-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1263), new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-kabul-north-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1574), new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6453), "9b304f04-2ea4-4820-8579-46ee622b4080", new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6527), "054edae0-6f68-46fc-b2b4-17bbc3452b39", new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6531), "1ef4f354-dc47-41b5-81c9-cd5f11e99084", new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6544), "29f2d416-4afc-4b36-a7b9-2f8ed5a9f927", new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_herat_center",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1122), new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_kabul_center",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 460, DateTimeKind.Local).AddTicks(9499), new DateTime(2026, 1, 19, 19, 44, 40, 462, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_kabul_north",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1102), new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "province_herat",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1141), new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "province_kabul",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1137), new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsPublic", "LanguageNo", "Name", "TranslationKeyPublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "0190ce58-1112-4f55-a90a-e96e11c32d12", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7557), 2, false, 2, "", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7559) },
                    { "12e54a53-152d-49da-a420-901848d7d327", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7599), 12, false, 3, "", "province_kabul", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7600) },
                    { "217a1115-ec3c-4cb9-af45-340aa1a9ac93", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7574), 5, false, 2, "", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7574) },
                    { "308ae1f8-abad-4908-8523-b5f25f87ab78", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7577), 6, false, 3, "", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7577) },
                    { "37bd2739-be75-46d5-990b-e834444af56c", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7594), 10, false, 1, "", "province_kabul", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7595) },
                    { "3e85fb43-d242-4a91-a1bf-bd39def471ec", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7586), 7, false, 1, "", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7586) },
                    { "728aeec2-4c25-4335-b4f4-94012c22433b", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7630), 14, false, 2, "", "province_herat", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7631) },
                    { "77c6fc32-80ad-4808-8d65-e1382622590d", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7597), 11, false, 2, "", "province_kabul", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7597) },
                    { "82391871-5c0e-40f1-8b6a-0bd5001d0527", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7635), 15, false, 3, "", "province_herat", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7635) },
                    { "a6783979-a527-4426-a2ca-5d1b42993a84", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(6698), 1, false, 1, "", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(6701) },
                    { "a72f57b6-5b63-4af8-b786-1d44ed4235f5", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7588), 8, false, 2, "", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7589) },
                    { "b482a6e7-6790-4f2f-84c5-85a29342ea9a", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7591), 9, false, 3, "", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7592) },
                    { "bf128153-1822-405c-af47-35c9404d478f", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7568), 3, false, 3, "", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7569) },
                    { "d234cb50-a752-4692-b110-491df6ce1986", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7602), 13, false, 1, "", "province_herat", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7603) },
                    { "daa72ad0-7b53-4f9c-a965-58421ff5fad3", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7571), 4, false, 1, "", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7571) }
                });
        }
    }
}
