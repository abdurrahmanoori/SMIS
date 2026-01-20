using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopType = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TaxNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.PublicId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dba11324-fe94-4068-924d-147322b91df6", "AQAAAAIAAYagAAAAEBRRaeetm0NPJx+wYieuiOwhb5VDba+gKiGC6IciPUEaj0wv9yTd8xOvCylqSpjePg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0961f3b8-58ec-4e43-95ba-269295143df9", "AQAAAAIAAYagAAAAEAuat2Wao9tKVlKjJbaLPSbd2L1zBiTfpyl7fJ2zqANNPw3qKuXDsu59yjjw09bKAw==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-herat-center-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 765, DateTimeKind.Local).AddTicks(8445), new DateTime(2026, 1, 20, 19, 8, 20, 765, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-kabul-center-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 765, DateTimeKind.Local).AddTicks(7781), new DateTime(2026, 1, 20, 19, 8, 20, 765, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-kabul-north-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 765, DateTimeKind.Local).AddTicks(8397), new DateTime(2026, 1, 20, 19, 8, 20, 765, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 764, DateTimeKind.Local).AddTicks(8157), "55ec7228-f49b-44d4-8bbf-ae991c024004", new DateTime(2026, 1, 20, 19, 8, 20, 764, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 764, DateTimeKind.Local).AddTicks(8257), "426dbcc1-1d84-4a46-b258-bf4ac7e199f6", new DateTime(2026, 1, 20, 19, 8, 20, 764, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 764, DateTimeKind.Local).AddTicks(8263), "a57e486e-454f-479f-b524-b69207a0d6d4", new DateTime(2026, 1, 20, 19, 8, 20, 764, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 764, DateTimeKind.Local).AddTicks(8268), "11b89730-c72c-4ba8-ae77-be28701984b5", new DateTime(2026, 1, 20, 19, 8, 20, 764, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_herat_center",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 762, DateTimeKind.Local).AddTicks(9362), new DateTime(2026, 1, 20, 19, 8, 20, 762, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_kabul_center",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 760, DateTimeKind.Local).AddTicks(5143), new DateTime(2026, 1, 20, 19, 8, 20, 762, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_kabul_north",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 762, DateTimeKind.Local).AddTicks(9321), new DateTime(2026, 1, 20, 19, 8, 20, 762, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "province_herat",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 762, DateTimeKind.Local).AddTicks(9373), new DateTime(2026, 1, 20, 19, 8, 20, 762, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "province_kabul",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 8, 20, 762, DateTimeKind.Local).AddTicks(9367), new DateTime(2026, 1, 20, 19, 8, 20, 762, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsPublic", "LanguageNo", "Name", "TranslationKeyPublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "13028604-db8a-490b-8324-45a1d02b7a73", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6500), 14, false, 2, "", "province_herat", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6500) },
                    { "184ce035-b220-4043-b967-ad00588b2b96", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6487), 11, false, 2, "", "province_kabul", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6487) },
                    { "2aeb768c-a24a-4e45-84de-6339927e45f1", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(5660), 1, false, 1, "", "district_kabul_center", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(5672) },
                    { "44d8b469-3019-43fd-bc7d-8da929135ca3", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6503), 15, false, 3, "", "province_herat", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6504) },
                    { "6265b91b-23b8-4069-81e1-fd16e5bcee36", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6479), 10, false, 1, "", "province_kabul", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6483) },
                    { "66a4c53b-f242-473c-9eb2-7dcf42a0fcd6", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6430), 3, false, 3, "", "district_kabul_center", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6431) },
                    { "68596b11-6343-4c89-859e-4ab604b26cc2", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6467), 7, false, 1, "", "district_herat_center", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6468) },
                    { "6da4ecb5-d988-40b4-a14c-3bd5e9a91599", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6414), 2, false, 2, "", "district_kabul_center", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6417) },
                    { "702e347b-c4e3-43f2-b14b-820df3c7e58f", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6434), 4, false, 1, "", "district_kabul_north", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6435) },
                    { "8c987644-0331-447f-b98c-95f08269e705", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6493), 13, false, 1, "", "province_herat", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6494) },
                    { "a1c74eb6-f4d7-4093-9356-9392408f2264", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6475), 9, false, 3, "", "district_herat_center", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6476) },
                    { "a4ffedc3-e53a-4a8f-aaf5-2add02d7f0d0", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6490), 12, false, 3, "", "province_kabul", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6490) },
                    { "a542bf36-397f-4b3c-b266-cf5b46906a6a", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6453), 6, false, 3, "", "district_kabul_north", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6453) },
                    { "b0de1511-24af-4002-86cd-029f56f00b2c", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6437), 5, false, 2, "", "district_kabul_north", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6438) },
                    { "b1a7bc39-f42a-436c-9eb0-ed46bc8c6265", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6472), 8, false, 2, "", "district_herat_center", null, new DateTime(2026, 1, 20, 19, 8, 20, 763, DateTimeKind.Local).AddTicks(6472) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "13028604-db8a-490b-8324-45a1d02b7a73");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "184ce035-b220-4043-b967-ad00588b2b96");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "2aeb768c-a24a-4e45-84de-6339927e45f1");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "44d8b469-3019-43fd-bc7d-8da929135ca3");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "6265b91b-23b8-4069-81e1-fd16e5bcee36");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "66a4c53b-f242-473c-9eb2-7dcf42a0fcd6");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "68596b11-6343-4c89-859e-4ab604b26cc2");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "6da4ecb5-d988-40b4-a14c-3bd5e9a91599");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "702e347b-c4e3-43f2-b14b-820df3c7e58f");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "8c987644-0331-447f-b98c-95f08269e705");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "a1c74eb6-f4d7-4093-9356-9392408f2264");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "a4ffedc3-e53a-4a8f-aaf5-2add02d7f0d0");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "a542bf36-397f-4b3c-b266-cf5b46906a6a");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "b0de1511-24af-4002-86cd-029f56f00b2c");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "b1a7bc39-f42a-436c-9eb0-ed46bc8c6265");

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
    }
}
