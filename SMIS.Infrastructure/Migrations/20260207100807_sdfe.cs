using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_ProductId_EffectiveDate",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "SalePricePerBaseUnit",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "ProductPrice",
                newName: "SellPrice");

            migrationBuilder.AddColumn<long>(
                name: "BuyPrice",
                table: "ProductPrice",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ProductUnitId",
                table: "ProductPrice",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddeaa9b4-7eb9-422b-a0cc-54084a2e2172", "AQAAAAIAAYagAAAAECUpwg8kJRGS72A0AtYNLnoCX9pqp15PWPRGLCjx3LQs4lMugtxD1r8M6x75iLyQUw==", "4812a692-666e-4a7f-86eb-4d4fb310e73e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d709dca0-c43c-468d-8f00-aef7d4ee415a", "AQAAAAIAAYagAAAAEMIZWDD+xfBMuaAlynAqXpd+c0xCs9GvBGLc55AZIGmck0YAYgjn5Q7YFt58pDHEBg==", "c7955a21-ad5f-49aa-b603-08fd96c3db9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3474dd28-7c29-49f8-95d4-c0177b2b8ca8", "AQAAAAIAAYagAAAAENzCustLFGozhTxzOwzcDgvE8UXSoGSSAW/RHjsIegEwGyZ1HWPnKutj7lGrUc7xQw==", "b7c148a2-ed3d-4e6e-82da-0338387c8832" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "194c3d84-810a-46fe-b784-23d6f307b35b", "AQAAAAIAAYagAAAAEJlg1XDsqN42XgNGNH385DuRFHx1d6nkxm4z9fxr6XHQu/OChfn1w3Duh6+zZk1m5g==", "4d63a08d-af9c-4fb6-862f-03358416afef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de789933-a687-40df-8d41-cd11e6e1f718", "AQAAAAIAAYagAAAAEJbiU4ubl2dk0ZVOLyhGBSSFMkRXkUzQk0CB/bA6fO6XSg2YjeJW9vHbskGf2X0kKg==", "aac67ae1-1fdd-4a76-9d68-679bc09fcb2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3c8912f-db76-4264-b744-3ef50260c4a8", "AQAAAAIAAYagAAAAEEMYLw2BBjuIJTKzwrQJrANr9VRe5W+oPjWQECsqOBXj4lAouIC3rhiHyDt8eM8EAQ==", "7cde7d24-8bd7-4a37-9b90-695dddeabcd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b3f27c8-975e-4c64-a701-8fc31515bdd0", "AQAAAAIAAYagAAAAEMLIt0jTfu/PBsW6AYf5BVh+mecDS04uwzSi4O3sEpz9rtOz9VUtAUeXyOqtF9hBBw==", "338a5e85-623a-4064-99d7-a2fb062c4826" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a195314-47d1-487a-bc51-d13b41823d0b", "AQAAAAIAAYagAAAAEAqqTcShFLtG8ifqdJBFy3ft5Ryi1A9Qyv5ZZUPqialsffZyh5NWc8egM30ldIdAZA==", "80844af6-3797-452e-8ade-449ccace5f09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b89d7b39-bb7c-47e3-b61f-52f7437597d2", "AQAAAAIAAYagAAAAEA9S6+u6B+w+eS1FcXceE2AUCumQWE6GfdbKSGD9mbMsex8fFcQPFogLVXhDpqzRVw==", "c212077d-4e58-45ac-bc18-4ea4df93f9ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d454b1b-d257-497b-8ade-2667b2caa977", "AQAAAAIAAYagAAAAELVnAbbV00Yne6MErQREhDI+uRHZjpVrfsetZeUF6u3XQk6swTCGfxoEGQrhxJvZXw==", "4760d263-13dd-4817-b2bb-6382522f3342" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1aefa72-855a-4fa6-bcdc-69d1f8adcabb", "AQAAAAIAAYagAAAAEPicsDYzLI7/g9jTpzLrIhF9QsLbwdIW9xz8uuwHoCjzWH+xtURpfamDlQjVuq0KmQ==", "eeaf57ad-0807-41a3-a02c-b17c792bb6e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdf199b5-30ef-4b61-b76a-939be434647c", "AQAAAAIAAYagAAAAEPy18iSOQKdd2GlGi9zbOyyf9fUqYSJ5NltSSERcjuosrTe67+rHd87nfja+7VOJVA==", "d15bc3b6-78ea-4dc9-b483-626670bef9fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc4a8311-7667-4838-a5d9-28ef3c10c9e1", "AQAAAAIAAYagAAAAEGnu+ySGtYNdte2xm/+VAEiEV1B1qrZFQGe7xsIl5+MV0piqdYvLElRMmdT0Q1ehpw==", "c1b0ff78-b19a-4b0a-a069-6b5bd9662ffd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "598c6389-f372-413a-983a-19ff22ee2512", "AQAAAAIAAYagAAAAEJfzLsIJIENZWMPelPPLzkuQvx2f+yRr0jUQ8aKdMZ65BHUgPrFwlWbzH960Znz2Ag==", "0522fd0b-1cea-42c6-91a0-0db45e21d505" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15a93db1-49b4-4be9-bffb-67cd2f2866d1", "AQAAAAIAAYagAAAAEPQQLF1IwK534/QytP7p/LF8gI5k5wa/sKujHRgO0ONEJ/SZh0ft3ryUF0VztH5vMg==", "e7515384-61d1-4853-81ee-5f5337ae2558" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(4487), new DateTimeOffset(new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Unspecified).AddTicks(4509), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2656), new DateTimeOffset(new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2670), new DateTimeOffset(new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Unspecified).AddTicks(2671), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2672), new DateTimeOffset(new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Unspecified).AddTicks(2673), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2673), new DateTimeOffset(new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Unspecified).AddTicks(2674), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2674), new DateTimeOffset(new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Unspecified).AddTicks(2675), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(6435), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 631, DateTimeKind.Unspecified).AddTicks(6448), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 631, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2643), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 632, DateTimeKind.Unspecified).AddTicks(2644), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(1038), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 632, DateTimeKind.Unspecified).AddTicks(1060), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(1942), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 632, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2573), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 632, DateTimeKind.Unspecified).AddTicks(2575), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2595), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 632, DateTimeKind.Unspecified).AddTicks(2597), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2603), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 632, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2611), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 632, DateTimeKind.Unspecified).AddTicks(2612), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2618), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 632, DateTimeKind.Unspecified).AddTicks(2620), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2636), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 632, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 632, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(6840), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(6843), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(7046), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(7049), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(7052), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(6040), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(6351), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 628, DateTimeKind.Local).AddTicks(5766), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 628, DateTimeKind.Unspecified).AddTicks(5783), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 628, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2369), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2376), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2385), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2397), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2402), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2404), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2408), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2410), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2414), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2415), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2420), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(6), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(20), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(1368), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2308), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2312), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2326), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2328), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2336), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2337), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2342), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2343), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2348), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2349), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2354), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 630, DateTimeKind.Unspecified).AddTicks(2355), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 630, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 140L, new DateTime(2026, 2, 7, 14, 38, 6, 39, DateTimeKind.Local).AddTicks(2691), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 0, 0, 0, 0)), "1", 160L, new DateTime(2026, 2, 7, 14, 38, 6, 39, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 115L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4972), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4976), new TimeSpan(0, 0, 0, 0, 0)), "6", 135L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 280L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4978), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4981), new TimeSpan(0, 0, 0, 0, 0)), "7", 320L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 45L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4982), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4985), new TimeSpan(0, 0, 0, 0, 0)), "8", 55L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 380L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4986), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)), "9", 420L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 430L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4991), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4996), new TimeSpan(0, 0, 0, 0, 0)), "10", 470L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 460L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4997), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, 0, 0, 0, 0)), "10", 500L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 260L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5002), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, 0, 0, 0, 0)), "11", 300L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 180L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5006), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(5009), new TimeSpan(0, 0, 0, 0, 0)), "12", 220L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 330L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5011), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, 0, 0, 0, 0)), "13", 370L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 160L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5015), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(5018), new TimeSpan(0, 0, 0, 0, 0)), "14", 200L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 150L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(3455), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 0, 0, 0, 0)), "1", 170L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 230L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5019), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(5022), new TimeSpan(0, 0, 0, 0, 0)), "15", 270L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 750L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5024), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(5027), new TimeSpan(0, 0, 0, 0, 0)), "16", 850L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 700L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5028), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(5033), new TimeSpan(0, 0, 0, 0, 0)), "16", 800L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 130L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4437), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 0, 0, 0, 0)), "2", 150L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 135L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4928), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4934), new TimeSpan(0, 0, 0, 0, 0)), "2", 155L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 70L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4940), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4943), new TimeSpan(0, 0, 0, 0, 0)), "3", 90L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 230L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4945), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4954), new TimeSpan(0, 0, 0, 0, 0)), "4", 270L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 250L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4956), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4960), new TimeSpan(0, 0, 0, 0, 0)), "4", 290L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 160L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4962), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4966), new TimeSpan(0, 0, 0, 0, 0)), "5", 190L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 110L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4967), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 40, DateTimeKind.Unspecified).AddTicks(4971), new TimeSpan(0, 0, 0, 0, 0)), "6", 130L, new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 37, DateTimeKind.Unspecified).AddTicks(2394), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2386), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2397), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2404), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2410), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2415), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2420), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2425), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2431), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(385), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2447), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2469), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2474), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2479), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2483), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2488), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2500), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(1748), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2509), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2352), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2365), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2371), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2376), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 38, DateTimeKind.Unspecified).AddTicks(2381), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5366), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5839), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5842), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5815), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5827), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5829), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5836), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(4658), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(4684), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(4857), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(4859), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(4860), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(4884), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(4885), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 626, DateTimeKind.Local).AddTicks(6323), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(6330), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 626, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 627, DateTimeKind.Local).AddTicks(9691), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 627, DateTimeKind.Unspecified).AddTicks(9726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 627, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 628, DateTimeKind.Local).AddTicks(404), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 628, DateTimeKind.Unspecified).AddTicks(410), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 628, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 43, DateTimeKind.Local).AddTicks(459), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 43, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 43, DateTimeKind.Local).AddTicks(455), new DateTime(2026, 2, 7, 14, 38, 6, 43, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 49, DateTimeKind.Local).AddTicks(8218), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 49, DateTimeKind.Unspecified).AddTicks(8312), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 49, DateTimeKind.Local).AddTicks(8194), new DateTime(2026, 2, 7, 14, 38, 6, 49, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 49, DateTimeKind.Local).AddTicks(9850), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 49, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 49, DateTimeKind.Local).AddTicks(9848), new DateTime(2026, 2, 7, 14, 38, 6, 49, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(9331), new DateTime(2026, 8, 7, 10, 8, 6, 40, DateTimeKind.Utc).AddTicks(7215), new DateTime(2026, 1, 28, 10, 8, 6, 40, DateTimeKind.Utc).AddTicks(7167), new DateTime(2026, 2, 7, 14, 38, 6, 40, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 41, DateTimeKind.Local).AddTicks(3749), new DateTime(2026, 9, 7, 10, 8, 6, 41, DateTimeKind.Utc).AddTicks(3727), new DateTime(2026, 2, 2, 10, 8, 6, 41, DateTimeKind.Utc).AddTicks(3726), new DateTime(2026, 2, 7, 14, 38, 6, 41, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 41, DateTimeKind.Local).AddTicks(4772), new DateTime(2026, 5, 7, 10, 8, 6, 41, DateTimeKind.Utc).AddTicks(4765), new DateTime(2026, 1, 23, 10, 8, 6, 41, DateTimeKind.Utc).AddTicks(4765), new DateTime(2026, 2, 7, 14, 38, 6, 41, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 41, DateTimeKind.Local).AddTicks(5570), new DateTime(2026, 1, 18, 10, 8, 6, 41, DateTimeKind.Utc).AddTicks(5564), new DateTime(2026, 2, 7, 14, 38, 6, 41, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 41, DateTimeKind.Local).AddTicks(9432), new DateTime(2026, 2, 7, 14, 38, 6, 41, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7255), new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(5171), new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(6320), new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7205), new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7221), new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7228), new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7235), new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7241), new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7248), new DateTime(2026, 2, 7, 14, 38, 6, 42, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8409), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(8428), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8755), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8758), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8761), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8763), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(8764), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8765), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(8766), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8767), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(8771), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8772), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 624, DateTimeKind.Unspecified).AddTicks(8773), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 624, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(591), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(604), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(972), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(973), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(974), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(975), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(976), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(977), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(929), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(931), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(932), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(934), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(935), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(936), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(937), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(938), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(938), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(940), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(940), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(968), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(969), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(970), new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(971), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 14, 38, 6, 625, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 625, DateTimeKind.Unspecified).AddTicks(9269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(2720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(3648), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(4108), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(4123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(4126), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(4133), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 10, 8, 6, 626, DateTimeKind.Unspecified).AddTicks(4137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductId_ProductUnitId_EffectiveDate",
                table: "ProductPrice",
                columns: new[] { "ProductId", "ProductUnitId", "EffectiveDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductUnitId",
                table: "ProductPrice",
                column: "ProductUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_ProductUnit_ProductUnitId",
                table: "ProductPrice",
                column: "ProductUnitId",
                principalTable: "ProductUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_ProductUnit_ProductUnitId",
                table: "ProductPrice");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_ProductId_ProductUnitId_EffectiveDate",
                table: "ProductPrice");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrice_ProductUnitId",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "BuyPrice",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ProductUnitId",
                table: "ProductPrice");

            migrationBuilder.RenameColumn(
                name: "SellPrice",
                table: "ProductPrice",
                newName: "Price");

            migrationBuilder.AddColumn<int>(
                name: "SalePricePerBaseUnit",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "352a4794-ab8f-4fdf-a378-2950002b9593", "AQAAAAIAAYagAAAAEICEewUGrGNCkmNYlvk/xNbQjFdnjrfe7eV+U3ax01MNg99XIVR1gNQs8FU03vh8JQ==", "f3a0f6eb-c69a-41b5-b66b-04104f9421b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d055fa8e-6bdf-409c-8541-2a3d32dc364b", "AQAAAAIAAYagAAAAEA+UlIhf4b/tA2LxMGV9/2BWdgg9LbzpYa9a7VmDnT3AF9uRMCED4gMrN2EbYNnZsQ==", "1e8467ad-afc4-4820-bb96-812ec33b6d84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2d3cafa-0f35-4752-8306-9388b9d5a62f", "AQAAAAIAAYagAAAAEB0bgtFhamDaT4Eemd4U5YwM5A+WcW9O/kDafCaZq5fX1IrTOkHavrJLZqihZT4RkA==", "83d4c6a3-27d7-44c0-86f0-04290c466eab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ad66570-5556-4aa2-9283-f69dc5a6c084", "AQAAAAIAAYagAAAAEObJfuUErj0Aiv+QUFmHCDLEI3LzdNdRTQswwKHmOrdA6b2EkyJ2n0XBiHLzPuOxWg==", "cb2f28dc-d6fb-4059-b786-ed51535ae78a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ae53ec9-9d55-438e-8dec-8a3f59f3f848", "AQAAAAIAAYagAAAAEOlNNSLP0eqlVDBOKC7Fpz4vh+OqrJA9GPQ8AJ6H17xoua/M1E8z8TjKGDu4dcc8TA==", "38c0005b-f158-46b5-9170-79ea5eff2c5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ab53e96-c958-40eb-91bd-12242c0749d6", "AQAAAAIAAYagAAAAEK1OLeE0IitjX53QJz+xrMbi/lCVulGp5NU7juUMhlyc4gohcy21tJaEmb1tU0JU6w==", "958b0436-4d42-4a69-9a68-1b77ab7b371f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "358793aa-3708-458d-ab90-35948538663a", "AQAAAAIAAYagAAAAEMuKvKyMI8pUG14anP7idj1JAuqN2GXqH6vwhxhCkFXBopRv7+bO50xbBFdodrqBYA==", "b53c59aa-2ea4-4046-8774-81d15f7664cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d52ab99a-c1ed-4aa7-846b-c61bdbeed274", "AQAAAAIAAYagAAAAEON04zjwszqpltbbDyr59xX7fmPsPbUOnTEPqeSRasU9rNhvCWVS2heFWC7/SYrCjA==", "06811572-e450-4f62-8b21-a42a91a13e58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "806c14fc-ac76-4f10-a113-c741cd822614", "AQAAAAIAAYagAAAAEDMhY9DD6Jbi29g0PHg0SnRonYG0Vdj/p0kJL4+w39ZVAf9xkZJ8MsBPJv9rmxF0wg==", "7a16c63b-fc4d-408a-8bb7-75665536ef51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cc6011f-b71c-495d-9d26-9415b431ce7b", "AQAAAAIAAYagAAAAEBv6az47Ben4rueYt1gcwX43MJiOdpD8WtafBwcwrQlr8VjVR31Peotul1MhptdltQ==", "ac645f82-73fd-465a-b201-50f4c9d999a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82044edc-3510-4234-9a3c-6d15771f0e29", "AQAAAAIAAYagAAAAEGnfcgiHKOL+6k4W3bK3FM+kc1wC0j92+YcPBx72A2l3e3gebebHdfSERcO0NsUrzA==", "36e2eaf8-7084-46a4-82cd-d442a5b46fc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "699cab2b-30db-447f-ab9c-11ad94de3654", "AQAAAAIAAYagAAAAEGPuUnmMYCA6w6Urgzeo3Rf68Zn9ynw1iReBV3DvMMhWZ55cVp+V4e+v17VdXOEK0Q==", "37c08861-4b40-429b-abee-fecc6392b0ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f96e7e92-8c24-47e5-86ab-945ac74d8701", "AQAAAAIAAYagAAAAEG6dzNakiH2nj4EySh8me/QY6zhzi5tWPKPNQIPx0PgmYp63B7bpe7t1u42ltxnjLw==", "4db9b7a2-b7c0-41f4-a786-e8d06cc0e93f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22d4093c-9e66-459f-9374-acf0c3a82475", "AQAAAAIAAYagAAAAEO0qN6atgWT3DfqOQCs9kt/FhlQRYgdevgGrQBcHsrRSRVUKMx/UPUO4V2qlutzlUA==", "bbdc447d-afaa-4b9c-b7cc-1791aa043ce9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c75148ff-70e0-44fd-867b-bee269cd65fd", "AQAAAAIAAYagAAAAEAH5ivrm5wyXjcTwlTM3Sw7YeOer2mCtiDCpcbgK7PfnuKPO6rLGFBpHTqaTlgC6pQ==", "5c2de569-a212-4c2b-93db-2cd8ed0f9bf4" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(5231), new DateTimeOffset(new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Unspecified).AddTicks(5268), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1631), new DateTimeOffset(new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Unspecified).AddTicks(1636), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1665), new DateTimeOffset(new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Unspecified).AddTicks(1666), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1668), new DateTimeOffset(new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Unspecified).AddTicks(1669), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1671), new DateTimeOffset(new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Unspecified).AddTicks(1672), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1673), new DateTimeOffset(new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Unspecified).AddTicks(1674), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 670, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 671, DateTimeKind.Local).AddTicks(223), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 671, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 671, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9751), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 672, DateTimeKind.Unspecified).AddTicks(9761), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(5641), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 672, DateTimeKind.Unspecified).AddTicks(5669), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(7855), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 672, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9573), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 672, DateTimeKind.Unspecified).AddTicks(9587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9653), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 672, DateTimeKind.Unspecified).AddTicks(9658), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9671), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 672, DateTimeKind.Unspecified).AddTicks(9674), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9689), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 672, DateTimeKind.Unspecified).AddTicks(9693), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9705), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 672, DateTimeKind.Unspecified).AddTicks(9708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9736), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 672, DateTimeKind.Unspecified).AddTicks(9739), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 672, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 652, DateTimeKind.Local).AddTicks(2716), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(2729), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 652, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 652, DateTimeKind.Local).AddTicks(3392), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(3402), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 652, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 652, DateTimeKind.Local).AddTicks(3405), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(3407), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 652, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 649, DateTimeKind.Unspecified).AddTicks(7598), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 649, DateTimeKind.Unspecified).AddTicks(8660), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 649, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 663, DateTimeKind.Local).AddTicks(5788), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 663, DateTimeKind.Unspecified).AddTicks(5850), new TimeSpan(0, 0, 0, 0, 0)), 150, new DateTime(2026, 2, 5, 18, 27, 27, 663, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(364), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, 0, 0, 0, 0)), 450, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(387), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(390), new TimeSpan(0, 0, 0, 0, 0)), 280, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(415), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(418), new TimeSpan(0, 0, 0, 0, 0)), 200, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(429), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(432), new TimeSpan(0, 0, 0, 0, 0)), 350, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(444), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(446), new TimeSpan(0, 0, 0, 0, 0)), 180, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(457), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(460), new TimeSpan(0, 0, 0, 0, 0)), 250, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(471), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(474), new TimeSpan(0, 0, 0, 0, 0)), 800, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 667, DateTimeKind.Local).AddTicks(2954), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 667, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 0, 0, 0, 0)), 140, new DateTime(2026, 2, 5, 18, 27, 27, 667, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 667, DateTimeKind.Local).AddTicks(7113), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 667, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), 80, new DateTime(2026, 2, 5, 18, 27, 27, 667, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(215), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(231), new TimeSpan(0, 0, 0, 0, 0)), 250, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(281), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 0, 0, 0, 0)), 180, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(297), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(300), new TimeSpan(0, 0, 0, 0, 0)), 120, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(311), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(314), new TimeSpan(0, 0, 0, 0, 0)), 300, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(325), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(328), new TimeSpan(0, 0, 0, 0, 0)), 50, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "SalePricePerBaseUnit", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(349), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(352), new TimeSpan(0, 0, 0, 0, 0)), 400, new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 233, DateTimeKind.Local).AddTicks(7514), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 269, DateTimeKind.Unspecified).AddTicks(7781), new TimeSpan(0, 0, 0, 0, 0)), 150, new DateTime(2026, 2, 5, 18, 27, 26, 269, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8138), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8141), new TimeSpan(0, 0, 0, 0, 0)), 125, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8144), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8147), new TimeSpan(0, 0, 0, 0, 0)), 300, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8150), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8153), new TimeSpan(0, 0, 0, 0, 0)), 50, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8156), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8159), new TimeSpan(0, 0, 0, 0, 0)), 400, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8162), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8165), new TimeSpan(0, 0, 0, 0, 0)), 450, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8168), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8171), new TimeSpan(0, 0, 0, 0, 0)), 480, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8174), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8177), new TimeSpan(0, 0, 0, 0, 0)), 280, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8180), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8186), new TimeSpan(0, 0, 0, 0, 0)), 200, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8188), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, 0, 0, 0, 0)), 350, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8194), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8197), new TimeSpan(0, 0, 0, 0, 0)), 180, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(4991), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(5009), new TimeSpan(0, 0, 0, 0, 0)), 160, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8200), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, 0, 0, 0, 0)), 250, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8206), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8208), new TimeSpan(0, 0, 0, 0, 0)), 800, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8212), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8214), new TimeSpan(0, 0, 0, 0, 0)), 750, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(7050), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(7069), new TimeSpan(0, 0, 0, 0, 0)), 140, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8056), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 0, 0, 0, 0)), 145, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8095), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8099), new TimeSpan(0, 0, 0, 0, 0)), 80, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8103), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8106), new TimeSpan(0, 0, 0, 0, 0)), 250, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8111), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8114), new TimeSpan(0, 0, 0, 0, 0)), 270, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8117), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8120), new TimeSpan(0, 0, 0, 0, 0)), 180, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "Price", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8123), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8135), new TimeSpan(0, 0, 0, 0, 0)), 120, new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 228, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5116), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5129), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5136), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5143), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5156), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5186), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5194), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5201), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(2205), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5207), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5214), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5220), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5228), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5234), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5256), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5271), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(4032), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5033), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5078), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5091), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 231, DateTimeKind.Unspecified).AddTicks(5108), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(8925), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(370), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(372), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(314), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(347), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(350), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(352), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(354), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(365), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(7193), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(7207), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(7575), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(7584), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(7586), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(7588), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(7589), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(7597), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 654, DateTimeKind.Local).AddTicks(3756), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 654, DateTimeKind.Unspecified).AddTicks(3771), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 654, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 661, DateTimeKind.Local).AddTicks(5384), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 661, DateTimeKind.Unspecified).AddTicks(5452), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 661, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 661, DateTimeKind.Local).AddTicks(7654), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 661, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 661, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 278, DateTimeKind.Local).AddTicks(2884), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 278, DateTimeKind.Unspecified).AddTicks(2925), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 278, DateTimeKind.Local).AddTicks(2875), new DateTime(2026, 2, 5, 18, 27, 26, 278, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(1270), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 302, DateTimeKind.Unspecified).AddTicks(1363), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(1259), new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(3469), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 302, DateTimeKind.Unspecified).AddTicks(3484), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(3465), new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 271, DateTimeKind.Local).AddTicks(8453), new DateTime(2026, 8, 5, 13, 57, 26, 271, DateTimeKind.Utc).AddTicks(3136), new DateTime(2026, 1, 26, 13, 57, 26, 271, DateTimeKind.Utc).AddTicks(3033), new DateTime(2026, 2, 5, 18, 27, 26, 271, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 273, DateTimeKind.Local).AddTicks(2258), new DateTime(2026, 9, 5, 13, 57, 26, 273, DateTimeKind.Utc).AddTicks(2232), new DateTime(2026, 1, 31, 13, 57, 26, 273, DateTimeKind.Utc).AddTicks(2230), new DateTime(2026, 2, 5, 18, 27, 26, 273, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 273, DateTimeKind.Local).AddTicks(5200), new DateTime(2026, 5, 5, 13, 57, 26, 273, DateTimeKind.Utc).AddTicks(5171), new DateTime(2026, 1, 21, 13, 57, 26, 273, DateTimeKind.Utc).AddTicks(5168), new DateTime(2026, 2, 5, 18, 27, 26, 273, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 273, DateTimeKind.Local).AddTicks(8370), new DateTime(2026, 1, 16, 13, 57, 26, 273, DateTimeKind.Utc).AddTicks(8346), new DateTime(2026, 2, 5, 18, 27, 26, 273, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 274, DateTimeKind.Local).AddTicks(8220), new DateTime(2026, 2, 5, 18, 27, 26, 274, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3745), new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 276, DateTimeKind.Local).AddTicks(6885), new DateTime(2026, 2, 5, 18, 27, 26, 276, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(434), new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3615), new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3668), new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3683), new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3706), new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3719), new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3732), new DateTime(2026, 2, 5, 18, 27, 26, 277, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(3209), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 650, DateTimeKind.Unspecified).AddTicks(3231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4190), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 650, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4204), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 650, DateTimeKind.Unspecified).AddTicks(4206), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4207), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 650, DateTimeKind.Unspecified).AddTicks(4209), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4211), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 650, DateTimeKind.Unspecified).AddTicks(4213), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4214), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 650, DateTimeKind.Unspecified).AddTicks(4216), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4217), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 650, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4221), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 650, DateTimeKind.Unspecified).AddTicks(4228), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(9233), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 650, DateTimeKind.Unspecified).AddTicks(9253), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 650, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(265), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(268), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(269), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(272), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(274), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(179), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(189), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(192), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(215), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(216), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(219), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(220), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(222), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(223), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(225), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(226), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(252), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(253), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(262), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 651, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 651, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 652, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 653, DateTimeKind.Unspecified).AddTicks(9269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 653, DateTimeKind.Unspecified).AddTicks(7129), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 653, DateTimeKind.Unspecified).AddTicks(8428), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 653, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 653, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 653, DateTimeKind.Unspecified).AddTicks(9234), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 653, DateTimeKind.Unspecified).AddTicks(9239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 653, DateTimeKind.Unspecified).AddTicks(9248), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 653, DateTimeKind.Unspecified).AddTicks(9258), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductId_EffectiveDate",
                table: "ProductPrice",
                columns: new[] { "ProductId", "EffectiveDate" });
        }
    }
}
