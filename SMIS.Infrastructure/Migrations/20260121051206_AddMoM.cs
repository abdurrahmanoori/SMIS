using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMoM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "UnitOfMeasure",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasure", x => x.PublicId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0dc01c7a-a6ce-4cdb-8907-431cb40e7c58", "AQAAAAIAAYagAAAAEOQQdctpPGyjA0BrYklJErlBkNnMbkndt43SWEVQln4Tbvo9U6H9v4610VaekDiaag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93d71dd7-c807-4b8e-bf5e-8cf47b27fe57", "AQAAAAIAAYagAAAAEKRt1QYI2CH2Etmd1cMs4UIChA1CHRgR6VOaFH3xW2Y8N0Uc4KOPOLnPQzHau46/Jg==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-herat-center-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(2752), new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-kabul-center-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(2614), new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "district-kabul-north-guid",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(2747), new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(333), "d7cedbaf-9384-4d9c-a91c-a3c37dffacff", new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(349), "a3d83459-8522-4ca5-a88d-7ba726ffea8e", new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(353), "e39be51e-32b8-4d79-b327-f0ea971afd94", new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(357), "eb5a1bd8-8292-4958-977d-077a85d00f34", new DateTime(2026, 1, 21, 9, 42, 6, 318, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_herat_center",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(4623), new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_kabul_center",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 316, DateTimeKind.Local).AddTicks(6362), new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "district_kabul_north",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(4614), new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "province_herat",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(4631), new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "province_kabul",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(4627), new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsPublic", "LanguageNo", "Name", "TranslationKeyPublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "15255650-5536-4a0e-8024-710bee436069", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7204), 10, false, 1, "", "province_kabul", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7205) },
                    { "165e745d-1440-42f9-a8ee-c0d0ab58d190", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7158), 4, false, 1, "", "district_kabul_north", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7158) },
                    { "384e3842-dab6-4994-a29c-cfbab3dd2a66", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7211), 12, false, 3, "", "province_kabul", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7211) },
                    { "4bc2ff52-11cb-4632-b699-56d10ebbc7f6", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7174), 7, false, 1, "", "district_herat_center", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7174) },
                    { "715a1f93-0d75-4b7d-8d09-01444d6e93cb", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7222), 15, false, 3, "", "province_herat", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7222) },
                    { "7305a23a-c4c1-4a0c-a046-478c550cb6f3", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7171), 6, false, 3, "", "district_kabul_north", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7171) },
                    { "75e9a018-41c5-48d6-822a-51ba52f2bc31", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7201), 9, false, 3, "", "district_herat_center", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7201) },
                    { "8e07ac3e-c705-456e-ae27-b4e32a800ab1", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7197), 8, false, 2, "", "district_herat_center", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7198) },
                    { "94b6f2b6-2c3f-4a1d-86c0-9247aed0b184", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7150), 3, false, 3, "", "district_kabul_center", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7150) },
                    { "94cbdac7-24c9-41bb-bb36-7c3dbebc7cb7", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7167), 5, false, 2, "", "district_kabul_north", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7167) },
                    { "97acfcc2-d59f-48b2-be29-7e258267bb92", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7219), 14, false, 2, "", "province_herat", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7219) },
                    { "b1433f0f-f83a-4ada-9f12-b3f23635d4a6", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(6937), 1, false, 1, "", "district_kabul_center", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(6939) },
                    { "b2980dee-595d-4f9f-9feb-4c55a4d43735", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7144), 2, false, 2, "", "district_kabul_center", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7145) },
                    { "d8187247-3882-4b07-a9cf-0a71e761b290", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7216), 13, false, 1, "", "province_herat", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7216) },
                    { "eff3ef08-8c4d-4cca-9696-d74a5df1a7fb", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7208), 11, false, 2, "", "province_kabul", null, new DateTime(2026, 1, 21, 9, 42, 6, 317, DateTimeKind.Local).AddTicks(7208) }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "PublicId", "Description", "Id", "Name", "Symbol" },
                values: new object[,]
                {
                    { "03b70143-39b7-40b4-8c67-d0cb7389f4ad", null, 4, "Box", "box" },
                    { "43d1c372-1fba-4967-8d12-d43536332d0a", null, 2, "Gram", "g" },
                    { "96dec467-b8d2-4811-9aa7-b2bdbb31a0ea", null, 3, "Milliliter", "ml" },
                    { "c53691a7-2bcb-485d-8b26-88033f253114", null, 5, "Bottle", "btl" },
                    { "eee75272-ca66-4782-9dbd-96e7ac0a88d4", null, 1, "Piece", "pcs" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitOfMeasure");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "15255650-5536-4a0e-8024-710bee436069");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "165e745d-1440-42f9-a8ee-c0d0ab58d190");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "384e3842-dab6-4994-a29c-cfbab3dd2a66");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "4bc2ff52-11cb-4632-b699-56d10ebbc7f6");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "715a1f93-0d75-4b7d-8d09-01444d6e93cb");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "7305a23a-c4c1-4a0c-a046-478c550cb6f3");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "75e9a018-41c5-48d6-822a-51ba52f2bc31");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "8e07ac3e-c705-456e-ae27-b4e32a800ab1");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "94b6f2b6-2c3f-4a1d-86c0-9247aed0b184");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "94cbdac7-24c9-41bb-bb36-7c3dbebc7cb7");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "97acfcc2-d59f-48b2-be29-7e258267bb92");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "b1433f0f-f83a-4ada-9f12-b3f23635d4a6");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "b2980dee-595d-4f9f-9feb-4c55a4d43735");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "d8187247-3882-4b07-a9cf-0a71e761b290");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "eff3ef08-8c4d-4cca-9696-d74a5df1a7fb");

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
    }
}
