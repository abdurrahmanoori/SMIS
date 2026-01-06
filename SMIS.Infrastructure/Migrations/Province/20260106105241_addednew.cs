using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations.Province
{
    /// <inheritdoc />
    public partial class addednew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProvinceTranslations_ProvinceId_Language",
                table: "ProvinceTranslations");

            migrationBuilder.DeleteData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.RenameColumn(
                name: "Language",
                table: "ProvinceTranslations",
                newName: "LanguageCode");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "ProvinceTranslations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "381a56f0-77ac-4bce-911f-e17e584ec9fc", "AQAAAAIAAYagAAAAEFbK/9RjsWhtuP1/QTGSp/6e1ys3GVn6dpbkMZz062pJq47zYs9XXhFWM7PdBNPNQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8457ac1f-a946-4421-b000-4b6a37be37bf", "AQAAAAIAAYagAAAAEAxBG7PtnTzv0IuJN39seyotdu+u/prNNtAGKEA9oxBSIk8259hXw/0ZVvjXVmgJDQ==" });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 22, 41, 195, DateTimeKind.Local).AddTicks(1372), new DateTime(2026, 1, 6, 15, 22, 41, 195, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 22, 41, 195, DateTimeKind.Local).AddTicks(1394), new DateTime(2026, 1, 6, 15, 22, 41, 195, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 22, 41, 195, DateTimeKind.Local).AddTicks(1399), new DateTime(2026, 1, 6, 15, 22, 41, 195, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "LabTestGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicId",
                value: "ec00ec5d-fbf3-4335-8509-5b4ac80b37d6");

            migrationBuilder.UpdateData(
                table: "LabTestGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: "e63814ca-a52f-40ca-8997-4b0a050499e0");

            migrationBuilder.UpdateData(
                table: "LabTestGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicId",
                value: "1d73f9d6-77a0-41fb-bffd-4173464bd4d5");

            migrationBuilder.UpdateData(
                table: "LabTests",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicId",
                value: "232324e3-04af-4f37-8056-add21c0c01fb");

            migrationBuilder.UpdateData(
                table: "LabTests",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: "addecc6d-b6d2-4c8d-be86-d0e9cce1427c");

            migrationBuilder.UpdateData(
                table: "LabTests",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicId",
                value: "4dabb21a-f60b-44fb-b258-1cc9b6ec98b8");

            migrationBuilder.UpdateData(
                table: "LabTests",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicId",
                value: "b06ed9e0-1415-49b8-8eff-da21a50725fd");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicId",
                value: "e68f49cb-9b58-49c2-8432-e844f7d13b47");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: "3f5754ba-9908-40b2-b385-017475349dbb");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicId",
                value: "17331303-47a0-4405-b748-99e4c96301ec");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LanguageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LanguageCode", "LanguageId", "Name" },
                values: new object[] { "ps", 2, "کابل" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LanguageCode", "LanguageId", "Name" },
                values: new object[] { "fa", 3, "کابل" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LanguageId", "Name" },
                values: new object[] { 1, "Herat" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LanguageCode", "LanguageId", "Name" },
                values: new object[] { "ps", 2, "هرات" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LanguageCode", "LanguageId", "Name" },
                values: new object[] { "fa", 3, "هرات" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LanguageId", "Name" },
                values: new object[] { 1, "Kandahar" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LanguageCode", "LanguageId", "Name" },
                values: new object[] { "ps", 2, "کندهار" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LanguageCode", "LanguageId", "Name" },
                values: new object[] { "fa", 3, "قندهار" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LanguageId", "Name" },
                values: new object[] { 1, "Balkh" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "LanguageCode", "LanguageId", "Name" },
                values: new object[] { "ps", 2, "بلخ" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LanguageCode", "LanguageId", "Name" },
                values: new object[] { "fa", 3, "بلخ" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsPublic", "PublicId" },
                values: new object[] { false, "db2d6472-2da8-457e-83ba-6fdaf1e0d209" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsPublic", "Name", "PublicId" },
                values: new object[] { false, "Herat", "92e46ae3-df6f-4610-a651-c82a485470be" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsPublic", "Name", "PublicId" },
                values: new object[] { false, "Kandahar", "0fdb8350-1c34-4936-9246-09b3413dd8ea" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsPublic", "Name", "PublicId" },
                values: new object[] { false, "Balkh", "5db313f6-91e3-4244-8e6e-a5e940be62f7" });

            migrationBuilder.CreateIndex(
                name: "IX_ProvinceTranslations_LanguageId",
                table: "ProvinceTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvinceTranslations_ProvinceId_LanguageId",
                table: "ProvinceTranslations",
                columns: new[] { "ProvinceId", "LanguageId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProvinceTranslations_Languages_LanguageId",
                table: "ProvinceTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProvinceTranslations_Languages_LanguageId",
                table: "ProvinceTranslations");

            migrationBuilder.DropIndex(
                name: "IX_ProvinceTranslations_LanguageId",
                table: "ProvinceTranslations");

            migrationBuilder.DropIndex(
                name: "IX_ProvinceTranslations_ProvinceId_LanguageId",
                table: "ProvinceTranslations");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "ProvinceTranslations");

            migrationBuilder.RenameColumn(
                name: "LanguageCode",
                table: "ProvinceTranslations",
                newName: "Language");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b32b67e0-e08c-4a2e-8004-445e8b0b23a3", "AQAAAAIAAYagAAAAEIZAMFHWcwt9yfxvolCbjdFWmyGaLi/38j6aeO3IwaIxhkWLKPzTOR/wqbZVneRzvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a4348ef-497d-4f19-a394-4a205f2b01a4", "AQAAAAIAAYagAAAAEC0OfgbHl7eTk6TwT5yWK4sxKu7Il0fQlM1wFs91+9oW4doJSi1LOTKvydvh2RH2Tg==" });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 15, 16, 16, 48, 468, DateTimeKind.Local).AddTicks(757), new DateTime(2025, 9, 15, 16, 16, 48, 468, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 15, 16, 16, 48, 468, DateTimeKind.Local).AddTicks(774), new DateTime(2025, 9, 15, 16, 16, 48, 468, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 9, 15, 16, 16, 48, 468, DateTimeKind.Local).AddTicks(779), new DateTime(2025, 9, 15, 16, 16, 48, 468, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "LabTestGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicId",
                value: "9fe7c58d-eddb-4941-9ae9-5e258aa11a07");

            migrationBuilder.UpdateData(
                table: "LabTestGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: "5b087451-b5ca-4351-895f-663f504edd42");

            migrationBuilder.UpdateData(
                table: "LabTestGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicId",
                value: "efbddbec-3a42-404e-876d-86023bb1e749");

            migrationBuilder.UpdateData(
                table: "LabTests",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicId",
                value: "1d2d4dd5-e3f4-4fcf-8aa7-c3989c0245e7");

            migrationBuilder.UpdateData(
                table: "LabTests",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: "10dddaff-c6cf-46ad-a89a-be5eba14f163");

            migrationBuilder.UpdateData(
                table: "LabTests",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicId",
                value: "355a4a3d-e263-4835-a80b-d37234b2a83c");

            migrationBuilder.UpdateData(
                table: "LabTests",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicId",
                value: "200e8a72-cd9a-48ac-8d9e-ef061f02e7ea");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicId",
                value: "f924bc50-0d6d-40bc-8c18-ee1ff0d4f7e8");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: "1c5d27e5-6a3f-413a-8b51-c90ea1539d82");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicId",
                value: "327f33af-68fc-4bfc-9866-e7e2fe0711cd");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Language", "Name" },
                values: new object[] { "fa", "????" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Language", "Name" },
                values: new object[] { "ps", "????" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Kandahar");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Language", "Name" },
                values: new object[] { "fa", "??????" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Language", "Name" },
                values: new object[] { "ps", "??????" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Herat");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Language", "Name" },
                values: new object[] { "fa", "????" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Language", "Name" },
                values: new object[] { "ps", "????" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Nangarhar");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Language", "Name" },
                values: new object[] { "fa", "???????" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Language", "Name" },
                values: new object[] { "ps", "???????" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsPublic", "PublicId" },
                values: new object[] { true, "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsPublic", "Name", "PublicId" },
                values: new object[] { true, "Kandahar", "22222222-2222-2222-2222-222222222222" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsPublic", "Name", "PublicId" },
                values: new object[] { true, "Herat", "33333333-3333-3333-3333-333333333333" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsPublic", "Name", "PublicId" },
                values: new object[] { true, "Nangarhar", "44444444-4444-4444-4444-444444444444" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "HospitalId", "IsPublic", "Name", "PublicId" },
                values: new object[,]
                {
                    { 5, 0, true, "Balkh", "55555555-5555-5555-5555-555555555555" },
                    { 6, 0, true, "Ghazni", "66666666-6666-6666-6666-666666666666" },
                    { 7, 0, true, "Kunduz", "77777777-7777-7777-7777-777777777777" }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "IsDefault", "Language", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 13, true, "en", "Balkh", 5 },
                    { 14, false, "fa", "???", 5 },
                    { 15, false, "ps", "???", 5 },
                    { 16, true, "en", "Ghazni", 6 },
                    { 17, false, "fa", "????", 6 },
                    { 18, false, "ps", "????", 6 },
                    { 19, true, "en", "Kunduz", 7 },
                    { 20, false, "fa", "?????", 7 },
                    { 21, false, "ps", "?????", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProvinceTranslations_ProvinceId_Language",
                table: "ProvinceTranslations",
                columns: new[] { "ProvinceId", "Language" },
                unique: true);
        }
    }
}
