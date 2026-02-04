using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ShopId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    FatherName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    TaxNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ProvinceId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    DistrictId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Customer_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Customer_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55556010-9249-4c72-a386-b9dded8159ef", "AQAAAAIAAYagAAAAELNq2YGve1eHZFW84aEUWSDdqFGTMjjGx/HVk8A4DPj4LF0NXVLmtdraihcUDIxLgg==", "92460a80-c564-443d-a958-fdf4ae2ffdbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "102c341c-0503-4153-b124-73b240bd7af6", "AQAAAAIAAYagAAAAEDa4IQDCvJe5X4T/+ihNndIteqkjjLdZCKDT6UUzhM8Xwb7QLgdE2Wjf0lJcgU9ApA==", "ec3fe724-780b-41ba-af11-c65f8b3d8930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08d07cc2-0145-404c-9e05-57a7cb4ee8da", "AQAAAAIAAYagAAAAEGBZle8yGH5du7brRQgOyFpVshqHIH2deaDY9uJVRkB17T7s22yRMHXwblgYFiC2IQ==", "b11d30ee-3c73-4de2-86ec-0a3ec0a2a643" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab928fb0-3e3b-470e-8267-005b34610a3b", "AQAAAAIAAYagAAAAEPbniN3CrJ/Nq7mwf2bH8OkiK1Ob2KfJApPA8B+htzKoTGwKPa/6jW1h3byXRTU5ng==", "f971380e-003a-4635-be14-54922f40407d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "574ecf26-ec13-488d-b6f7-2fef855fcf61", "AQAAAAIAAYagAAAAEOsk2GmY7J8fUGi0uMvTfvBhhGoNwY/mCQLd+Z3O3pcl/3V/KkkQ3oIWt8029cEVkQ==", "534021e5-a000-47a0-8591-dbd8e6ed0571" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "757bf76f-5f64-48f8-822d-0a598bfce261", "AQAAAAIAAYagAAAAEHB+eotNfyyqyZDJmw7kZp2Sgbz9HuceL6RQ9ULCOja5OsRACRYo2zqzI2sULbslJw==", "2434a6b0-5436-41e9-a040-9e0d87c2f8ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f2e2f89-9f20-4f22-a590-610c4952e701", "AQAAAAIAAYagAAAAECFGXBfuQRo3vuGf6cF3AOQ1IPdxGsHo9o56l/7Tum/BTQeOfj/i/w2gav39+XIcJg==", "d2201751-bfe2-4b83-a4f2-49d9cf7daf66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8607e673-60e1-4e86-b90f-1092301c88c9", "AQAAAAIAAYagAAAAEHr84ShiJYavPNKtpYkYPT9MMJDOl4BIgINxpzo2ofZa1hVMdxP+CPHTTVZEKx/Rtg==", "795980a6-8f30-4c99-b103-5a532204b258" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b93b3566-9d39-4312-8ab1-47aaadca5a61", "AQAAAAIAAYagAAAAEOYM10Ox2PBEupCf7JBgb8zW1CL7O96s7JEIQ3VJgCq3TO/4xxC0cNHF1vJwb99fVw==", "0179c53a-2ae2-4b17-85f0-0799b57bda07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4448bb17-d6de-41b2-9f27-ab4cefa1a1ba", "AQAAAAIAAYagAAAAECZtCytPj7yY5LNggLqrEGXTBKBTkF2VJ4ilIufAseSzpujA8PDqJ44XIr+dDAqBAQ==", "40ddfb08-51fe-46f4-9601-5e9d352d9b95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8e480e4-348c-4cc2-8369-8dfac8c539b7", "AQAAAAIAAYagAAAAEJrfo2nXD4RlW+ISCfH5D8nV6kqnqNZgHOtTyMPr0O/uAXhYxHQgZZgGNCXNkSnzfA==", "59ed1079-4903-4c0b-8943-a55fa1c2a76e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e08908d-e04a-474c-875c-9b39a85772fb", "AQAAAAIAAYagAAAAEPL4mEZKlK2DkK8APdLLOedA50AV5l+qALcamfCd27a69QRoPhD/XQON8s96xIBeTQ==", "289ffb77-07f7-44fe-9bc8-f6f2794cc09e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cd544f2-d5f8-4440-abd7-038a563c141c", "AQAAAAIAAYagAAAAEL8TbsYMeycsfiiVFglAsZB1+rhh/j3jf4YpVZ4O5zrqoH/N1eCYoKVk5+ACp/QaNQ==", "4a906d93-03fa-4e83-8a9b-06c0152b2f0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dd6512c-e5a8-41fa-9481-d7ceee6846bd", "AQAAAAIAAYagAAAAEC2bM1CvUX4XCCTa0B/PCIsw2/yb268VIGiX2PcjKLBPP53Z7XFTNMdgo9diiKhPcw==", "9bb493cf-f4c6-42a5-a34e-aee5cb9d39fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "571d0a4b-c380-4528-99a4-711e0d4ec252", "AQAAAAIAAYagAAAAEPJvedX3nIoR/vTG7UkErJULmIw9R7+luqjOftnchTzTOfZYMpji9IzJp5fDjvomnw==", "a9e65610-800c-4648-b80a-15b9226739e7" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(8333), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6596), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Unspecified).AddTicks(6606), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6659), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Unspecified).AddTicks(6660), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6663), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6666), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6669), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 515, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(9961), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(9975), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 505, DateTimeKind.Local).AddTicks(564), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 505, DateTimeKind.Unspecified).AddTicks(573), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 505, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 505, DateTimeKind.Local).AddTicks(576), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 505, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 505, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 502, DateTimeKind.Unspecified).AddTicks(6753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 502, DateTimeKind.Unspecified).AddTicks(7685), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 502, DateTimeKind.Unspecified).AddTicks(7688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 510, DateTimeKind.Local).AddTicks(1183), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 510, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 510, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3638), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3640), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3649), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3651), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3671), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3683), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3697), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3699), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3708), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3710), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3720), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 512, DateTimeKind.Local).AddTicks(7924), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 512, DateTimeKind.Unspecified).AddTicks(7943), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 512, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(961), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(973), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3502), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3514), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3562), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3587), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3589), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3599), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3601), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3611), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3613), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3626), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 513, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 513, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 102, DateTimeKind.Local).AddTicks(367), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 103, DateTimeKind.Unspecified).AddTicks(4736), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 103, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2844), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2849), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2851), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2854), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2859), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2862), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2864), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2866), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2872), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2874), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2876), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2881), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2883), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2886), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2888), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2891), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(314), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(329), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2896), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2900), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2903), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2905), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2908), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2910), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(1919), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2771), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2815), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2818), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2822), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2828), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2830), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2833), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2836), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2839), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 104, DateTimeKind.Unspecified).AddTicks(2841), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 56, 104, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 98, DateTimeKind.Unspecified).AddTicks(4764), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4336), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4348), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4353), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4360), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4365), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4372), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4381), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(1963), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4387), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4392), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4398), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4404), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4415), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4421), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4428), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4434), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(3427), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4272), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4284), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 56, 100, DateTimeKind.Unspecified).AddTicks(4289), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(6269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7652), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7655), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7615), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7633), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7635), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7638), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7640), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(7647), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(4845), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(4858), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(5230), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(5238), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(5240), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(5243), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 504, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 504, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 506, DateTimeKind.Local).AddTicks(9550), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(9564), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 506, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 509, DateTimeKind.Local).AddTicks(964), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 509, DateTimeKind.Unspecified).AddTicks(991), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 509, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 509, DateTimeKind.Local).AddTicks(2152), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 509, DateTimeKind.Unspecified).AddTicks(2164), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 509, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 105, DateTimeKind.Local).AddTicks(1111), new DateTime(2026, 8, 4, 16, 31, 56, 104, DateTimeKind.Utc).AddTicks(6912), new DateTime(2026, 1, 25, 16, 31, 56, 104, DateTimeKind.Utc).AddTicks(6841), new DateTime(2026, 2, 4, 21, 1, 56, 105, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 106, DateTimeKind.Local).AddTicks(3288), new DateTime(2026, 9, 4, 16, 31, 56, 106, DateTimeKind.Utc).AddTicks(3257), new DateTime(2026, 1, 30, 16, 31, 56, 106, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 2, 4, 21, 1, 56, 106, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 106, DateTimeKind.Local).AddTicks(6204), new DateTime(2026, 5, 4, 16, 31, 56, 106, DateTimeKind.Utc).AddTicks(6184), new DateTime(2026, 1, 20, 16, 31, 56, 106, DateTimeKind.Utc).AddTicks(6182), new DateTime(2026, 2, 4, 21, 1, 56, 106, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 106, DateTimeKind.Local).AddTicks(9105), new DateTime(2026, 1, 15, 16, 31, 56, 106, DateTimeKind.Utc).AddTicks(9089), new DateTime(2026, 2, 4, 21, 1, 56, 106, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 107, DateTimeKind.Local).AddTicks(9364), new DateTime(2026, 2, 4, 21, 1, 56, 107, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1628), new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 109, DateTimeKind.Local).AddTicks(5655), new DateTime(2026, 2, 4, 21, 1, 56, 109, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 109, DateTimeKind.Local).AddTicks(9040), new DateTime(2026, 2, 4, 21, 1, 56, 109, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1530), new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1574), new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1585), new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1595), new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1604), new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1613), new DateTime(2026, 2, 4, 21, 1, 56, 110, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2034), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(2068), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2964), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2976), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2979), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2983), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(2985), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2986), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2990), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2993), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(6791), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7742), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7744), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7745), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7750), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7658), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7667), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7670), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7693), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7695), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7697), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7698), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7701), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7705), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7731), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7733), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7734), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 503, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 1, 57, 503, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 505, DateTimeKind.Unspecified).AddTicks(5152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(5192), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(3043), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(4162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(4938), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(4957), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(4964), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(4971), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(4987), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 31, 57, 506, DateTimeKind.Unspecified).AddTicks(4994), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Customer_DistrictId",
                table: "Customer",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Email",
                table: "Customer",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IsActive",
                table: "Customer",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IsDeleted",
                table: "Customer",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PhoneNumber",
                table: "Customer",
                column: "PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ProvinceId",
                table: "Customer",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ShopId",
                table: "Customer",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_TaxNumber",
                table: "Customer",
                column: "TaxNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee84b74d-116f-4066-b0e6-844326380262", "AQAAAAIAAYagAAAAEPTSmfpos9zFM583iwlfgjUuNW6qhEf7emjakrH3glYvubwkgWvEIaXgWuX3lEbZsQ==", "5e584b68-2df5-48f0-a637-e27523246111" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b19518e-3037-4308-b83d-91bc5f08fa4e", "AQAAAAIAAYagAAAAEJf7D3u3/U3hyBY7HWR1m5R/SAk1Xoc7R/ag9oADhcciopDMbg51E/pQzr3pXLh7EA==", "f6afc54f-fb01-444d-8d4b-11f234d7c5de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf01bc16-45bc-4f18-8839-468c4f375b3c", "AQAAAAIAAYagAAAAEGLyjLn7HiK93DAN7VYIT4eKujkJlb0uGndF00TvBAb06VhPUrDljnGv///NALowBw==", "1071fd06-8a3e-4838-8a68-df4fd48c1bc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff50ac82-f938-4eb6-befd-51e0214a8bad", "AQAAAAIAAYagAAAAEJJCW/Dm0/HjZM4xEakPfVQkKcURQ4ENOwK7mNoWoeVeY3EAxFvGZfjEW6yIlCF+Xw==", "73d8ca49-eeb9-4d24-9651-ad8e7c538d62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d3dc989-e799-4e65-a6d2-814017b0781f", "AQAAAAIAAYagAAAAEJnolqtkmi2Kg5q6IqmpWOnlU7SZBhzSf5Mynlp39MDGW8q4/fkteh7ymUNVgCYRtw==", "338a12ee-436c-4062-a4d8-0ec0d4263ecf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7114f0d4-715c-4314-9978-fb491c139278", "AQAAAAIAAYagAAAAEL4S8VH3lC6ORmcdCere4TIbMasOJ9hNr7hs/M/TBP0zMMJTUyIpsbfhlyUhJWnFJg==", "2440fe5c-032a-4fac-ab6f-45853d45ceb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9e9a8bf-911d-4e2b-bf85-cae1cc641ae2", "AQAAAAIAAYagAAAAEO8oiCS02nsWACy1L6tMNCHzAQ2SHE1Bj+iQDhNDMmCnqnJBqsNrdtwQrFLuPwtylQ==", "0daee5a7-bc03-4fe8-b51c-e409e9166d1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df02ecbb-40b6-42e5-b1a1-b4a2477ae874", "AQAAAAIAAYagAAAAEBtyt6sETDifp6g/0yEsWc1FM7nVS0qrMrR2KzDexNfAKZA9U7LDD5f9nTkutckfjg==", "92dd6f67-c246-4aaf-9787-1546bc406734" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "facbb78c-690b-4782-b277-ef1bc6ffb67f", "AQAAAAIAAYagAAAAEBC8HSjZCfGYiQ7ad50nDndlTLwa0fDm8SRTKKqA4e7MHvsq/4DMTCW5N/IEGX7KIA==", "4696ae2c-eb12-456c-90f6-881b9eecbd24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc31b357-9d8a-43bd-b7ca-cf2fcd566616", "AQAAAAIAAYagAAAAEIVTBYWeiDzwdpn8DrF1fBmZtFGEiZZt+C1KrturElUTbySzF+45FsFOJ+9JCHf+7A==", "f90dc26e-121b-42d7-9864-b46263aae289" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fbc0175-b424-49b7-846e-74236365e63c", "AQAAAAIAAYagAAAAECbl4XeAxwT6dd/+Jrm6B6Xcp4cuUaCnL1mjLIgM+oDCDWpGxuzUg+IHrObNzJGgBQ==", "7d087796-5781-4ab9-bad7-607702be494a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0947a9e-b670-4012-a65f-68f6fd381523", "AQAAAAIAAYagAAAAEH5WIc7c/DEAUbNyY7bCi+okS/1HiDI2bEp7N4lgR6DSluMCkh5oxoOTCsFd/JiwYg==", "a1e1e3a4-4f56-4243-a54d-83da2e96464a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08bf247e-575e-4da5-9d85-5e2ec333a42c", "AQAAAAIAAYagAAAAEJYqvO03y0vfcOvxoekXSvuvXzhj2to5/fj6fw07l156MXe5YXk1glOuY9o3/q/1bw==", "1b30825b-a029-4cee-a2b6-b545fe86d8b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37d211c0-6f1a-479c-a58d-613780d36b4c", "AQAAAAIAAYagAAAAEJt+DCTcE9D7+PDC/itCAqjoJ6D2wlIQ+dq94vnAbo5eQ0RrbN2vgIMwamRht3QMow==", "9ffad450-a5c0-4fe5-acc6-904aa29b6d7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fbbb7a4-36ba-4293-8cc8-80b5276944dd", "AQAAAAIAAYagAAAAEKQEmBklNXxbGFtaCrYznMLx0gkS2wVsu3nrFDKFFu1uWA21KuIVVNF7iK2SFcMViA==", "2f10be77-2043-4724-a73a-7c6b7dc964d7" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 364, DateTimeKind.Local).AddTicks(464), new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 364, DateTimeKind.Unspecified).AddTicks(499), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 364, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1586), new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1600), new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1603), new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1604), new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1606), new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1606), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6495), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6741), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(6750), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6751), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(6754), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(5019), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(5322), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 361, DateTimeKind.Local).AddTicks(4933), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 361, DateTimeKind.Unspecified).AddTicks(4953), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 361, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7177), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7181), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7190), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7248), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7252), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7259), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7270), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7276), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7283), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7317), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7320), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(3160), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(3200), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(5786), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(5803), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7029), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7038), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7065), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7079), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7097), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7102), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7119), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7131), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7135), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 750, DateTimeKind.Local).AddTicks(8436), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(5913), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9749), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9752), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9754), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9761), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9764), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9765), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9768), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9769), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9772), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9774), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9777), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9778), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9781), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9782), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9785), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9786), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9789), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9790), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(8325), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(8335), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9797), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9801), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9804), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9805), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9808), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9164), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9177), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9663), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9673), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9685), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9688), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9690), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9693), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9695), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9739), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9745), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9748), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 748, DateTimeKind.Unspecified).AddTicks(8233), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8185), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8195), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8202), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8207), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8212), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8217), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8221), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8231), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8235), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8246), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8250), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8255), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8291), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8297), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8302), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8313), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8136), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8145), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8165), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8175), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5490), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5450), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5468), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5482), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4417), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4568), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(4573), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4574), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4578), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(4582), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 359, DateTimeKind.Local).AddTicks(7172), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(7202), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 359, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 360, DateTimeKind.Local).AddTicks(8925), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 360, DateTimeKind.Unspecified).AddTicks(8954), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 360, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 360, DateTimeKind.Local).AddTicks(9647), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 360, DateTimeKind.Unspecified).AddTicks(9656), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 360, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(3861), new DateTime(2026, 8, 4, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(1859), new DateTime(2026, 1, 25, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(1810), new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(8099), new DateTime(2026, 9, 4, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(8088), new DateTime(2026, 1, 30, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(8087), new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(9111), new DateTime(2026, 5, 4, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(9105), new DateTime(2026, 1, 20, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(9104), new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(9963), new DateTime(2026, 1, 15, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(9953), new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 753, DateTimeKind.Local).AddTicks(3659), new DateTime(2026, 2, 4, 17, 14, 14, 753, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1379), new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 753, DateTimeKind.Local).AddTicks(9112), new DateTime(2026, 2, 4, 17, 14, 14, 753, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(407), new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1327), new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1341), new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1349), new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1355), new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1361), new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1373), new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8258), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8296), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8633), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8646), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8704), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8709), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8713), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8717), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8720), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8723), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(751), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(764), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1094), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1099), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1100), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1104), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1104), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1032), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1040), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1042), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1046), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1050), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1053), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1053), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1056), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1057), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1085), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1086), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1090), new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1094), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(2551), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4076), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4536), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4544), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4548), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4553), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4557), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
