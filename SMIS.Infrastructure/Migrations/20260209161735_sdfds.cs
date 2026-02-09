using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ShopOwner",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bc4c342-856f-4022-94e7-a2f5fbbbd7ea", "AQAAAAIAAYagAAAAEGcLrFkJf1/MDImREYqxraSdYdfoJno9UE5j1hFdvmYtvge215Yxqu+3SKd3gYUBng==", "83506eb1-02e0-499f-be96-6a0ec6dab475" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d21554e-5251-45f4-895a-1ab9c9357379", "AQAAAAIAAYagAAAAEIrpSxpVK216Phyb3UpreQnkMgnOVu03NYRFyqQwU70ipyouSMBwhgg6JvdghvmoEQ==", "883598f5-ff9a-4921-b3e4-7f78096d99a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "828d48f3-6fb3-42af-a1a3-74630ab44ee4", "AQAAAAIAAYagAAAAELg88IDbvnURnKYhLXuzhNlHlgJhORz5VeDcdZ3VK0e33ser60WAGKapirUMaUtFng==", "074f761c-122d-4940-9764-de6f3623d87e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5f764b9-d364-4ae5-a2ab-5640774ec71d", "AQAAAAIAAYagAAAAEGbAN2hIMn7gY13hkPsRvJZp8snTmZ//rI/trDX+MQ0D9dmdeeYvcUec+lqJq6IzhQ==", "ae15b372-16dd-4c61-b327-7d0f772ee27a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9499159a-35cb-4033-b773-f1f3e77c36c1", "AQAAAAIAAYagAAAAENi51zNT5cZJ3iVWXdN+XcSS6sBUcziYsRRsxUVSBJCYQgsReGECx031kfp6h5pH2g==", "ce941286-e89f-4929-a7c5-adcf18b1b7bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e41e8c4-d4fd-4d0e-b9cc-37f8c1ba9b95", "AQAAAAIAAYagAAAAEO+ovfWawHvzehkFLdJ84XukHgVh5ywc3qDXlwfQujOJp9LE5/hFxdram3cJq1bZIA==", "8c827491-fe16-4787-bee7-074c7ac6fd0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "170c1b5f-cdea-413d-9656-57155b2eb1a1", "AQAAAAIAAYagAAAAEG35GhrOSRci+IxoVxxSdyygqWGBxGV+Y0QVt4L5230kGR7w41zagkM9xBEXnPO0JQ==", "68029492-7c83-49c7-9e7a-f4901f3d7a15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d01dd1-1e86-4964-a181-1bdf0b495b55", "AQAAAAIAAYagAAAAELuz7jwE9Mx9UQgcdXAm4rHtfziikmp3owT9lxJKodZ+uGY64r+bNkckKC3muK341Q==", "073e0e30-3a25-4107-84ad-4b274277d550" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d523ab3b-a434-4a31-a3e3-c242acb2ddb6", "AQAAAAIAAYagAAAAEN0MJZEPt7qtlsV7v2PbE6EYaCOSJRezFqwr0zpO2Zdjyzave+Oy+BcxrowZ/6fYGg==", "7890894c-b8dc-40bc-96f6-76dde1ed5141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eb65b06-b645-4736-a741-51a93f9607dd", "AQAAAAIAAYagAAAAECp1jqWDJ+CMtiPZKRpwCwrH2Xlg2nrO4BQGO9pOpXJgsoZtVxC65OXsnekV1wke0w==", "8fe8ba4b-ba7c-4bfd-92f0-a352d9ea6254" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e9c5f3d-a2f6-4fcb-8d0b-e19506e7b195", "AQAAAAIAAYagAAAAEHzftzjNhSGFykoAIe8eWJKCR5GJQnFpWCsCI+86hNlAwHMiqqh/PjRnRJ92GKdcSQ==", "f0d3fdaf-b8a9-4e98-bc97-75636b7cfaa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "877def42-7ab1-499c-a49a-3d4e7615f784", "AQAAAAIAAYagAAAAEA/2PjfKTB7Zd9bPNRcxT9yEo3ooJEZ8LJJLnlcXHwVbuN16515d8hyGu6gDgklfLQ==", "79122f1f-79a1-41ae-812f-ad9aac4ddfc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10a11b7f-d71e-4319-b5c4-ab1f03acff4f", "AQAAAAIAAYagAAAAEAcj0CtIJktJPhc+v9UQH9ZZQnoqiwACBbp9NYOS2ksa8fpXWBKtjli/nd7W5f/BHA==", "94962834-7937-4f4b-802c-6eb1d5cfb1e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ed46ce-de39-4f4d-b906-d3aa3fd32339", "AQAAAAIAAYagAAAAEM0QztOEj0lrAStjyTiLZpDdzr1Uo1G91LBwz6aGG/KLHbAdyBKufZ5np8fwXxPcdg==", "bda94259-4cdc-407c-84ce-382dbf2f41c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c43b4423-3a14-41d1-824c-8a4ab9a40dc2", "AQAAAAIAAYagAAAAENkyk7AvdILucbsvC10RXQqy2FVhMUH+S+ufKbGysFnRHvL531R8jN5UdCQCYEhY+g==", "beaf175b-b5a5-4026-a8e5-ca4656ee3ca4" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(6772), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(370), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(394), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(397), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(399), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(401), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(402), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 422, DateTimeKind.Local).AddTicks(688), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 422, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 422, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7632), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7635), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(3941), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(3957), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(6058), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7493), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7505), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7557), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7570), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7585), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7597), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7610), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7621), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9251), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(9266), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9859), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(9869), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9871), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(9873), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 408, DateTimeKind.Unspecified).AddTicks(6134), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 408, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 408, DateTimeKind.Unspecified).AddTicks(6984), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 995, DateTimeKind.Local).AddTicks(1560), new DateTime(2026, 3, 11, 16, 17, 31, 994, DateTimeKind.Utc).AddTicks(8000), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 995, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 16, 17, 31, 994, DateTimeKind.Utc).AddTicks(7999), new DateTime(2026, 2, 9, 20, 47, 31, 995, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 996, DateTimeKind.Local).AddTicks(811), new DateTime(2026, 2, 24, 16, 17, 31, 996, DateTimeKind.Utc).AddTicks(802), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 996, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 16, 17, 31, 996, DateTimeKind.Utc).AddTicks(801), new DateTime(2026, 2, 9, 20, 47, 31, 996, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 996, DateTimeKind.Local).AddTicks(2652), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 996, DateTimeKind.Unspecified).AddTicks(2674), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 16, 17, 31, 996, DateTimeKind.Utc).AddTicks(2647), new DateTime(2026, 2, 9, 20, 47, 31, 996, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 416, DateTimeKind.Local).AddTicks(1110), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 416, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 416, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3154), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3156), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3166), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3168), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3177), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3187), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3198), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3200), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3209), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3220), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3225), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 418, DateTimeKind.Local).AddTicks(7357), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 418, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 418, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(591), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(603), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3022), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3079), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3094), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3106), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3108), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3117), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3143), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3145), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 971, DateTimeKind.Local).AddTicks(5918), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 973, DateTimeKind.Unspecified).AddTicks(577), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 972, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(434), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(440), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(443), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(446), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(448), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(451), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(475), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(479), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(482), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(485), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(487), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(490), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(495), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(497), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(500), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(502), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(505), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(508), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 973, DateTimeKind.Local).AddTicks(8127), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 973, DateTimeKind.Unspecified).AddTicks(8142), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 973, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(538), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(544), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(549), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(552), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(554), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(557), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(559), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(562), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(567), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(569), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(572), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(577), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(582), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(584), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(587), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(591), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 973, DateTimeKind.Local).AddTicks(9533), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 973, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 973, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(595), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(597), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(599), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(605), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(609), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(612), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(615), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(617), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(620), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(622), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(625), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(630), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(634), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(637), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(639), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(642), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(644), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(360), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(373), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(647), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(649), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(652), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(654), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(657), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(669), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(673), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(676), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(678), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(681), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(685), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(688), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(690), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(693), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(695), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(396), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(409), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(413), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(416), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(419), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(421), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(424), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(426), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(429), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 966, DateTimeKind.Unspecified).AddTicks(9125), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1008), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1023), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1029), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1034), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1040), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1056), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1061), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 968, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1112), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1117), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1128), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1136), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1142), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1146), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1158), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1163), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1188), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1193), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(950), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1209), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1214), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1227), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1232), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1243), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(978), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(985), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(998), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1003), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6623), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6649), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6580), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6606), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6609), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6614), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6617), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(2973), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(2989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3354), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(3363), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3366), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3369), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(3371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 412, DateTimeKind.Local).AddTicks(9899), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(9938), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 412, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 415, DateTimeKind.Local).AddTicks(721), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 415, DateTimeKind.Unspecified).AddTicks(755), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 415, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 415, DateTimeKind.Local).AddTicks(1745), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 415, DateTimeKind.Unspecified).AddTicks(1766), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 415, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(7795), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 980, DateTimeKind.Unspecified).AddTicks(7817), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(7791), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(954), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 994, DateTimeKind.Unspecified).AddTicks(1001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(941), new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(3370), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 994, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(3365), new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 975, DateTimeKind.Local).AddTicks(1366), new DateTime(2026, 8, 9, 16, 17, 31, 974, DateTimeKind.Utc).AddTicks(7055), new DateTime(2026, 1, 30, 16, 17, 31, 974, DateTimeKind.Utc).AddTicks(6986), new DateTime(2026, 2, 9, 20, 47, 31, 975, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 976, DateTimeKind.Local).AddTicks(5321), new DateTime(2026, 9, 9, 16, 17, 31, 976, DateTimeKind.Utc).AddTicks(5275), new DateTime(2026, 2, 4, 16, 17, 31, 976, DateTimeKind.Utc).AddTicks(5271), new DateTime(2026, 2, 9, 20, 47, 31, 976, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 976, DateTimeKind.Local).AddTicks(8028), new DateTime(2026, 5, 9, 16, 17, 31, 976, DateTimeKind.Utc).AddTicks(8015), new DateTime(2026, 1, 25, 16, 17, 31, 976, DateTimeKind.Utc).AddTicks(8013), new DateTime(2026, 2, 9, 20, 47, 31, 976, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 977, DateTimeKind.Local).AddTicks(87), new DateTime(2026, 1, 20, 16, 17, 31, 977, DateTimeKind.Utc).AddTicks(74), new DateTime(2026, 2, 9, 20, 47, 31, 977, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 977, DateTimeKind.Local).AddTicks(9144), new DateTime(2026, 2, 9, 20, 47, 31, 977, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1068), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 979, DateTimeKind.Local).AddTicks(5256), new DateTime(2026, 2, 9, 20, 47, 31, 979, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 979, DateTimeKind.Local).AddTicks(8191), new DateTime(2026, 2, 9, 20, 47, 31, 979, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(921), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(966), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(980), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(990), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(999), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1057), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(778), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1691), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1703), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1705), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1706), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1718), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1719), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1721), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1722), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1725), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1747), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1750), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1751), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1753), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6044), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(6063), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7071), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7073), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7074), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7076), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7077), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7082), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6986), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(6996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6999), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7021), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7029), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7030), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7034), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7036), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7038), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7064), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7066), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7068), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 411, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5041), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(2605), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(3948), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(4980), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5010), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5025), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5029), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ShopOwner",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f447896-4113-4cc1-a591-4adf19561017", "AQAAAAIAAYagAAAAEMvJNsD7RL3gJQx4Qovm3AEbB2fK0wzxZKB4bNbKNGISQ1PNdcRAuL2HAW+WeyreiQ==", "c2cab56f-6a71-45cd-94cb-b70bb11861f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a35a15cd-c129-4f3c-84c5-1fcb70e64890", "AQAAAAIAAYagAAAAEMiNx+ch7Pts3aIxmee0IzuJewYgZEBN83CD2GTkCXuXXdhVPaKmgLMMX+eMZlRsWw==", "08035ba7-417c-4dba-afce-3e534f5b1100" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1d64d95-51c9-44c7-8187-dfe81ccc726f", "AQAAAAIAAYagAAAAEJfcAag6muxCp+xeLGl6QLHgwYSnjRbooPDSMT6T+ZaWNHdTlwtaT1M7qxaMXuYrNg==", "a6ebe12f-a996-4840-8183-58d0dd3e8b54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39bea930-1053-44df-83e1-813f563ce434", "AQAAAAIAAYagAAAAEGeYFnlqV6+BwxWLvzAd9mpaYkWXuV6fcPJ6fMOz83GNF04dPVJY41TSKD0cMNEhZQ==", "162a5777-d724-4e5a-9703-34caae9b9d75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37d41cc6-777b-42bf-bce3-800debfc1487", "AQAAAAIAAYagAAAAEOUL5SuzSMUS0B01m6Lgn8UsdepsqijPBA3boGbiMedlbLl1EcWIjUV+C22+L6EyCw==", "03b8c079-70ad-42fe-aa16-5fe85c822249" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40dff380-98c5-4023-946b-4cbe1d9d77ea", "AQAAAAIAAYagAAAAEB20bgOTLlhJocxOpPK+RZLnxmjfrLitLMStyadqQS0GnPkR09ThxgmDiS+O/PuqCA==", "ffa91461-793b-4cdd-9f4e-11ea1cb9c9bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81b7af8d-9246-4af1-a535-8ae010f6adf8", "AQAAAAIAAYagAAAAELih9MNJOMINq4eu8FgyBmVTWYA/dUpw1M+jbewvWdaHbnb8CduZWhQ6CcRN6erEjg==", "11bb5448-cd3a-4288-90f2-b5145dbfc377" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76b9bdc2-5748-4280-86d7-694c258f1f3a", "AQAAAAIAAYagAAAAEJ3jeCoSo+sYfJkaompZPjuPn76G58fsGlOHFOzAzhjFCn+JRlxOwcHQZfKFdgSz1g==", "cc38aedc-9232-437b-8640-2947aee1c9f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "996a30db-2a45-42a7-9741-74da09e00dfd", "AQAAAAIAAYagAAAAELzbJ0hQR2/VPrCzQAtujE5Mr52KDYfvAJX7EWT5RDPTA2yZLJEa+2Wj1lcu6ZEFcg==", "4b757ddf-2300-49ff-aea0-381880a6743f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7639260-cdf5-4116-bd4f-aec83870e6b6", "AQAAAAIAAYagAAAAEBNboQveCPttiJX+9n0zlHYdRWuwkjeYKpP+x1O3RD3l76bK0m91lmyXO31f4dFN1Q==", "f90df52e-5897-4a53-b3f0-0bf5bee488d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4637f8f6-6ee5-49c1-83ef-eea0bcd619aa", "AQAAAAIAAYagAAAAEFL07BWHDFiC2t+vDQUkvEec/ybO5wwGbOJ61ExTdFPnti1WnulDn3ottXCK4E5E8A==", "19921a7e-3e48-4e78-aea6-ba91d7c12b8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55b1becd-abab-471d-b3a6-724660332e16", "AQAAAAIAAYagAAAAEGqLUR1B2DBE23/2n30a+EVItjWxVwz6pNxPKEzY2kx56OKyae679wqKffV9bUdEOQ==", "2a7d96cf-4856-4319-a3ff-1b0682b9c437" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fdcf3a5-3770-41dc-8d48-1f99efb3d8dc", "AQAAAAIAAYagAAAAEM9LJOCNmcHvVwU37HTm9yYiTj6BqCIQq7SvAMPDpEwe2oOlruITCZ6BuABT5RahKQ==", "43b7a1df-2f7b-47e5-9ebb-2951e835bc6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaa83efc-f95b-4829-b1b7-5597149b8782", "AQAAAAIAAYagAAAAENb9ffFmsOiWTaedPUMfftqa2nqtRUN6hOvY0IEV8xb65fnvhcNuz3fuSaaz8LBGYQ==", "91f99b89-32c7-413c-abad-c42eb475d07e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa57005c-75a2-408a-a6c4-3ebd9ad50d83", "AQAAAAIAAYagAAAAEEDpdUfTPm7jFmBdYNpNuh35z5r8ZLMF4pg+FmrUPV7/YpGkUaQV57FZR/IKHz41HA==", "723c65ca-58bd-498e-b943-fee0b02b8ad0" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(2166), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Unspecified).AddTicks(2186), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2077), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Unspecified).AddTicks(2080), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2091), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Unspecified).AddTicks(2091), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2093), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2094), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Unspecified).AddTicks(2094), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2095), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Unspecified).AddTicks(2095), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(5670), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 132, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 132, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2048), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 133, DateTimeKind.Unspecified).AddTicks(2050), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(476), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 133, DateTimeKind.Unspecified).AddTicks(487), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(1365), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 133, DateTimeKind.Unspecified).AddTicks(1375), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(1988), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 133, DateTimeKind.Unspecified).AddTicks(1991), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2007), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 133, DateTimeKind.Unspecified).AddTicks(2009), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2014), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 133, DateTimeKind.Unspecified).AddTicks(2015), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2022), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 133, DateTimeKind.Unspecified).AddTicks(2023), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2028), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 133, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2035), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 133, DateTimeKind.Unspecified).AddTicks(2037), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 133, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(9220), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(9225), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(9402), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(9403), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(9404), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(9405), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 124, DateTimeKind.Unspecified).AddTicks(8795), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 124, DateTimeKind.Unspecified).AddTicks(9444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 124, DateTimeKind.Unspecified).AddTicks(9446), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 515, DateTimeKind.Local).AddTicks(4253), new DateTime(2026, 3, 11, 13, 1, 40, 515, DateTimeKind.Utc).AddTicks(1905), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 515, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 13, 1, 40, 515, DateTimeKind.Utc).AddTicks(1903), new DateTime(2026, 2, 9, 17, 31, 40, 515, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 515, DateTimeKind.Local).AddTicks(8441), new DateTime(2026, 2, 24, 13, 1, 40, 515, DateTimeKind.Utc).AddTicks(8422), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 515, DateTimeKind.Unspecified).AddTicks(8472), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 13, 1, 40, 515, DateTimeKind.Utc).AddTicks(8422), new DateTime(2026, 2, 9, 17, 31, 40, 515, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 515, DateTimeKind.Local).AddTicks(9904), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 515, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 13, 1, 40, 515, DateTimeKind.Utc).AddTicks(9901), new DateTime(2026, 2, 9, 17, 31, 40, 515, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 129, DateTimeKind.Local).AddTicks(4171), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 129, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 129, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(130), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(131), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(136), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(140), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(145), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(146), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(157), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(158), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(163), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(164), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(169), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(170), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(174), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(175), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 130, DateTimeKind.Local).AddTicks(7787), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 130, DateTimeKind.Unspecified).AddTicks(7799), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 130, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 130, DateTimeKind.Local).AddTicks(9157), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 130, DateTimeKind.Unspecified).AddTicks(9172), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 130, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(71), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(89), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(96), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(97), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(101), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(102), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(118), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(124), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 131, DateTimeKind.Unspecified).AddTicks(125), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 131, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 503, DateTimeKind.Local).AddTicks(4026), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(2981), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7906), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7915), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7917), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7923), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7927), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7928), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7932), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7934), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7939), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7942), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7943), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7947), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7949), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7978), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7985), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7990), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7992), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7995), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(6437), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(6461), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7997), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8000), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8015), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8018), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8020), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8023), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8025), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8030), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8033), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8035), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8038), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8040), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8046), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8049), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8051), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8056), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7349), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7364), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8061), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8066), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8079), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8083), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8084), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8089), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8093), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8095), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8098), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8099), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8104), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8107), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8109), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8112), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8114), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7864), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8118), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8121), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8123), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8126), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8128), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8132), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8133), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8137), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8138), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8141), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8143), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8148), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8151), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8152), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(8156), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7878), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7882), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7884), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7888), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7890), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7895), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7901), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 504, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 504, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 501, DateTimeKind.Unspecified).AddTicks(2506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2275), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2280), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2285), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2291), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2296), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2304), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2315), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(433), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2321), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2327), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2332), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2338), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2350), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2356), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2361), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2367), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2373), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(1663), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2378), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2384), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2389), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2395), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2400), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2405), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2410), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2416), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2427), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2187), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2449), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2455), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2465), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2477), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2208), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2214), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2222), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 502, DateTimeKind.Unspecified).AddTicks(2252), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(7914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8333), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8335), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8336), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8310), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8321), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8323), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8326), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8327), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(8331), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(7243), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(7250), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(7456), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(7459), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(7470), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(7472), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(7473), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 127, DateTimeKind.Local).AddTicks(1024), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 127, DateTimeKind.Unspecified).AddTicks(1048), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 127, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 128, DateTimeKind.Local).AddTicks(7011), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 128, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 128, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 128, DateTimeKind.Local).AddTicks(7759), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 128, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 128, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(5385), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 507, DateTimeKind.Unspecified).AddTicks(5395), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(5372), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 514, DateTimeKind.Local).AddTicks(7424), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 514, DateTimeKind.Unspecified).AddTicks(7486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 514, DateTimeKind.Local).AddTicks(7412), new DateTime(2026, 2, 9, 17, 31, 40, 514, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 514, DateTimeKind.Local).AddTicks(8739), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 40, 514, DateTimeKind.Unspecified).AddTicks(8760), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 40, 514, DateTimeKind.Local).AddTicks(8737), new DateTime(2026, 2, 9, 17, 31, 40, 514, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 505, DateTimeKind.Local).AddTicks(2984), new DateTime(2026, 8, 9, 13, 1, 40, 505, DateTimeKind.Utc).AddTicks(531), new DateTime(2026, 1, 30, 13, 1, 40, 505, DateTimeKind.Utc).AddTicks(486), new DateTime(2026, 2, 9, 17, 31, 40, 505, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 505, DateTimeKind.Local).AddTicks(7536), new DateTime(2026, 9, 9, 13, 1, 40, 505, DateTimeKind.Utc).AddTicks(7521), new DateTime(2026, 2, 4, 13, 1, 40, 505, DateTimeKind.Utc).AddTicks(7521), new DateTime(2026, 2, 9, 17, 31, 40, 505, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 505, DateTimeKind.Local).AddTicks(8632), new DateTime(2026, 5, 9, 13, 1, 40, 505, DateTimeKind.Utc).AddTicks(8615), new DateTime(2026, 1, 25, 13, 1, 40, 505, DateTimeKind.Utc).AddTicks(8615), new DateTime(2026, 2, 9, 17, 31, 40, 505, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 505, DateTimeKind.Local).AddTicks(9418), new DateTime(2026, 1, 20, 13, 1, 40, 505, DateTimeKind.Utc).AddTicks(9411), new DateTime(2026, 2, 9, 17, 31, 40, 505, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 506, DateTimeKind.Local).AddTicks(3377), new DateTime(2026, 2, 9, 17, 31, 40, 506, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1853), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 506, DateTimeKind.Local).AddTicks(9134), new DateTime(2026, 2, 9, 17, 31, 40, 506, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(723), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1785), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1806), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1816), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1829), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1837), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1845), new DateTime(2026, 2, 9, 17, 31, 40, 507, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1497), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(1517), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1899), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(1922), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1924), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(1926), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1927), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(1929), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1930), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(1931), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1933), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1935), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1939), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(1940), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4037), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4372), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4375), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4375), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4393), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4394), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4395), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4329), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4337), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4338), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4339), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4341), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4343), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4344), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4345), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4367), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4368), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4369), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4370), new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 125, DateTimeKind.Unspecified).AddTicks(4371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 31, 41, 125, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(1619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(8288), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(5948), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(7551), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(8255), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(8262), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(8267), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(8269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 13, 1, 41, 126, DateTimeKind.Unspecified).AddTicks(8271), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
