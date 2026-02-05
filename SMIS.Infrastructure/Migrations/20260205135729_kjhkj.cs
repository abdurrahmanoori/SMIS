using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kjhkj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopOwner",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    NationalIdCardNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    OwnershipPercentage = table.Column<decimal>(type: "TEXT", precision: 5, scale: 2, nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    table.PrimaryKey("PK_ShopOwner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopOwner_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopOwner_Shop_ShopId",
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
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 663, DateTimeKind.Local).AddTicks(5788), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 663, DateTimeKind.Unspecified).AddTicks(5850), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 663, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(364), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(387), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(390), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(415), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(418), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(429), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(444), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(446), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(457), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(460), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(471), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(474), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 667, DateTimeKind.Local).AddTicks(2954), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 667, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 667, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 667, DateTimeKind.Local).AddTicks(7113), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 667, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 667, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(215), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(281), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(297), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(300), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(311), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(314), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(325), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(328), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(349), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 27, 668, DateTimeKind.Unspecified).AddTicks(352), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 27, 668, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 233, DateTimeKind.Local).AddTicks(7514), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 269, DateTimeKind.Unspecified).AddTicks(7781), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 269, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8138), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8141), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8144), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8147), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8150), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8153), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8156), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8159), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8162), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8165), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8168), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8171), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8174), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8177), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8180), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8186), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8188), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8194), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8197), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(4991), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(5009), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8200), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8206), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8208), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8212), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8214), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(7050), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(7069), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8056), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8095), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8099), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8103), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8106), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8111), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8117), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8120), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8123), new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 270, DateTimeKind.Unspecified).AddTicks(8135), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 18, 27, 26, 270, DateTimeKind.Local).AddTicks(8124) });

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

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsPublic", "LastModifiedUtc", "LastName", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 2, 5, 18, 27, 26, 278, DateTimeKind.Local).AddTicks(2884), null, "john.doe@example.com", null, "Unchanged", "John", true, false, new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 278, DateTimeKind.Unspecified).AddTicks(2925), new TimeSpan(0, 0, 0, 0, 0)), "Doe", "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 2, 5, 18, 27, 26, 278, DateTimeKind.Local).AddTicks(2875), null, new DateTime(2026, 2, 5, 18, 27, 26, 278, DateTimeKind.Local).AddTicks(2887), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(1270), null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 302, DateTimeKind.Unspecified).AddTicks(1363), new TimeSpan(0, 0, 0, 0, 0)), "Smith", "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(1259), null, new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(1273), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(3469), null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, new DateTimeOffset(new DateTime(2026, 2, 5, 13, 57, 26, 302, DateTimeKind.Unspecified).AddTicks(3484), new TimeSpan(0, 0, 0, 0, 0)), "Johnson", "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(3465), null, new DateTime(2026, 2, 5, 18, 27, 26, 302, DateTimeKind.Local).AddTicks(3470), 0 }
                });

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
                name: "IX_ShopOwner_ApplicationUserId",
                table: "ShopOwner",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOwner_IsActive",
                table: "ShopOwner",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOwner_ShopId",
                table: "ShopOwner",
                column: "ShopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopOwner");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2172e06-12c2-45c4-9682-18889f387782", "AQAAAAIAAYagAAAAEA2VhHZiazvCRa+HwtUlGCuMoU/5+KB36anBhlER0XlGB7xOhNBcqwaxlj0egI/wVw==", "703a544f-f5ae-4995-86f9-c97701ecd797" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "160dc5f9-e76a-4091-aef0-c1bfdae01c92", "AQAAAAIAAYagAAAAEEd5adBbrRj9Ujvs/tLt/za2ALMRYwnX9ghcxoE/WoxoRGzaoNdgq/tR+RHIa5dyDA==", "34522468-bcaf-4cd1-8677-4fc5660ceba2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d693c99-3f60-4745-8fea-21b7774b5016", "AQAAAAIAAYagAAAAELZJ4s1nxkQ05jUnNSjMnZv1Zaqyvsd0D2DUPIkCRngJ0u9Sbui2gQSs6bRN6X2NmQ==", "514c6ee0-c3c8-4744-aee1-98f6fb3f8b5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f65743-4b1a-437c-a390-540910772264", "AQAAAAIAAYagAAAAEG21Q06185ENy3xPTgaCIYRivfrdJbzhXABiKqpTaXsGCDHcrszjJA4JmG87vbLKMg==", "16650a33-65f6-47fe-b6db-67b1667e38dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2361ebf-c031-4d25-9536-e75ba0fcdc1d", "AQAAAAIAAYagAAAAEJJ5n2VCgnxDxlLzmXHREFNZIB8BBIimHkgQD7FRmJtMYA5Th0cZqey4Yn+oueWskA==", "4a86e9ea-3668-470d-9ab9-eceebdf09655" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d131e88b-3ac4-4a8c-8d10-11ca8adbd503", "AQAAAAIAAYagAAAAEO9dnviCX2pWQnXrtZvvfPnXHg/NNLBLEV6qozgrpcnRvPSNu9Djf81WlSb+na7Sug==", "8cd8ca10-ac8e-4675-a675-51f46708498b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b736d10-9d18-49d9-b31d-8e31f8c0479c", "AQAAAAIAAYagAAAAEJomZDlKtHynQKNxy2NdPefDzADsXO3nggvWGvqFZ2DjStjkp0RFXQCdtXAB31i09Q==", "ef8a39ab-8de6-47e7-8b10-25e55701f940" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec5e2bce-a388-4ad0-b70c-699706775451", "AQAAAAIAAYagAAAAEJcgXs9XKFkHxMHiItemCXBYZLQI8WG7z4aRmO4DPgWyfVOdL+5Xzeu2CGdzQIAndw==", "b5dc0b5e-a37b-4c5c-88ba-6834260780c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10015fcb-167c-464e-84dc-0a5ebd4ccfa5", "AQAAAAIAAYagAAAAEGc6NQIxEA9umnN212FVwOx/aQwi/bUvEkYyoq/zRXybZBJgxa3ZjaPxObEivrspeA==", "22145523-e8f8-4fa3-8555-70eda89cdfe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfa2fd42-1923-4b74-815c-ea63e6eb1fee", "AQAAAAIAAYagAAAAEDrSsyXyrQaBVhbfGUD1ZmZyNRAiFXUmHyw45gfGLFrQczMJzlGuJqK71W9E1XoOHA==", "0f7e877f-167d-452a-bdbe-23a706f8781f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dc3e11e-317c-4e49-ada5-33cd6e91a043", "AQAAAAIAAYagAAAAEJo+liF1o/KC1YWT/OXJqaW44VXhkGena/bxflZwxEjxOgvhb6aJw6iTd6p6oNK79w==", "49c4fe19-0762-4ac5-814d-f8fe3ffdd5d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90417809-4f54-4b64-8bd3-a5905052b2dc", "AQAAAAIAAYagAAAAEFPJmbixM4JwHmLEkO3XPcauId4KY5FqhEaQmlP7lziJRuIzTRyIEDa8HCggQ4tZJQ==", "4c1296e0-3a3c-4e8a-838b-36d3ecc87c34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efdc4847-1582-4f9c-bbd3-32ca25f87a57", "AQAAAAIAAYagAAAAEMA7m5rAbJ6l42iztQPnIdjindly1ErVZT9oxknO0jK/bCXvoIcxwMESUXBjJgV9sg==", "cf1bd1cd-a8a6-4091-ae49-470b83689bc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ac5d021-1259-40c3-bb1c-f4c0c25f91ce", "AQAAAAIAAYagAAAAENTr5fCqSrL/zV9pfIkaR/pbirPXvH/PTNeBT2y5GcJS2um8Yo50uX5ny6NfZmhfcg==", "5c6adfb5-2ad0-4fbe-9e77-2a892ab195bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe408b05-62c6-47ac-9958-f4987563f47f", "AQAAAAIAAYagAAAAEMcibaXSz5Gu19QtwDgKLIq7Wj9+StxX7OZAUfIzC8DOcugEc0zGyGH0KfVXz7laDg==", "27e748ba-6f26-43e7-9bea-ca0f2650ac91" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(7160), new DateTimeOffset(new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Unspecified).AddTicks(7193), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6770), new DateTimeOffset(new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Unspecified).AddTicks(6773), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6790), new DateTimeOffset(new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6792), new DateTimeOffset(new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Unspecified).AddTicks(6792), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6793), new DateTimeOffset(new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Unspecified).AddTicks(6793), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6794), new DateTimeOffset(new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Unspecified).AddTicks(6794), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 695, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(1688), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 696, DateTimeKind.Unspecified).AddTicks(1739), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1876), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(7639), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 696, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(8914), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 696, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1430), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1501), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1676), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1687), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1723), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1731), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1766), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1801), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1809), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1841), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(8000), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(8023), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(8192), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(8197), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(8198), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(8201), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 688, DateTimeKind.Unspecified).AddTicks(7447), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 688, DateTimeKind.Unspecified).AddTicks(7761), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 688, DateTimeKind.Unspecified).AddTicks(7766), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 692, DateTimeKind.Local).AddTicks(5276), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 692, DateTimeKind.Unspecified).AddTicks(5299), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 692, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3709), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3723), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3728), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3737), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3742), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3750), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3757), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3766), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3771), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3786), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3800), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(923), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(970), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(2524), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(2537), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3602), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3609), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3631), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3642), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3652), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3667), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3672), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3682), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3696), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 694, DateTimeKind.Unspecified).AddTicks(3701), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 694, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 98, DateTimeKind.Local).AddTicks(5052), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(2496), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6437), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6441), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6444), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6446), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6449), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6451), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6454), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6455), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6459), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6462), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6463), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6469), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6472), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6473), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6488), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6490), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(5044), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(5057), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6492), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6495), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6496), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6501), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(5958), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(5968), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6394), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6399), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6406), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6409), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6411), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6414), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6416), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6421), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6430), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6432), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 99, DateTimeKind.Unspecified).AddTicks(6435), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 99, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 95, DateTimeKind.Unspecified).AddTicks(9352), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3194), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3208), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3214), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3220), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3230), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3235), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3240), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 96, DateTimeKind.Unspecified).AddTicks(9974), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3245), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3250), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3261), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3270), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3275), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3280), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(2524), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3301), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3139), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3166), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3178), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3184), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 97, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(6762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7160), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7163), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7167), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7128), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7136), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7141), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7145), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(6154), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(6166), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(6281), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(6285), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(6286), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(6290), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(6293), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 690, DateTimeKind.Local).AddTicks(8589), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(8615), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 690, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 691, DateTimeKind.Local).AddTicks(9963), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 691, DateTimeKind.Unspecified).AddTicks(9991), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 691, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 692, DateTimeKind.Local).AddTicks(557), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 692, DateTimeKind.Unspecified).AddTicks(566), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 692, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 100, DateTimeKind.Local).AddTicks(448), new DateTime(2026, 8, 5, 8, 3, 34, 99, DateTimeKind.Utc).AddTicks(8490), new DateTime(2026, 1, 26, 8, 3, 34, 99, DateTimeKind.Utc).AddTicks(8437), new DateTime(2026, 2, 5, 12, 33, 34, 100, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 100, DateTimeKind.Local).AddTicks(4922), new DateTime(2026, 9, 5, 8, 3, 34, 100, DateTimeKind.Utc).AddTicks(4898), new DateTime(2026, 1, 31, 8, 3, 34, 100, DateTimeKind.Utc).AddTicks(4897), new DateTime(2026, 2, 5, 12, 33, 34, 100, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 100, DateTimeKind.Local).AddTicks(5955), new DateTime(2026, 5, 5, 8, 3, 34, 100, DateTimeKind.Utc).AddTicks(5947), new DateTime(2026, 1, 21, 8, 3, 34, 100, DateTimeKind.Utc).AddTicks(5946), new DateTime(2026, 2, 5, 12, 33, 34, 100, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 100, DateTimeKind.Local).AddTicks(6670), new DateTime(2026, 1, 16, 8, 3, 34, 100, DateTimeKind.Utc).AddTicks(6665), new DateTime(2026, 2, 5, 12, 33, 34, 100, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(1076), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8341), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(6393), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(7510), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8288), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8301), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8313), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8320), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8327), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8334), new DateTime(2026, 2, 5, 12, 33, 34, 101, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(549), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(588), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(904), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(909), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(910), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(914), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(915), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(919), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(920), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(931), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(932), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(935), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(936), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(939), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(940), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(943), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3059), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3075), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3393), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3396), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3397), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3400), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3401), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3405), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3353), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3358), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3359), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3363), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3364), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3367), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3368), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3375), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3376), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3379), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3380), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3384), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3388), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3389), new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 689, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 689, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(4006), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(5780), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(5789), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(5801), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(5806), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(5811), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 690, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
