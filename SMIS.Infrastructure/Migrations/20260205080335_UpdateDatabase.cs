using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerType",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(1688), "Individual", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 696, DateTimeKind.Unspecified).AddTicks(1739), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1876), "Individual", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(7639), "Individual", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 696, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(8914), "Enterprise", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 696, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 696, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1430), "Individual", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1501), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1676), "Individual", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1687), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1723), "Enterprise", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1731), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1766), "Individual", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1801), "Individual", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1809), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "CustomerType", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1841), "Enterprise", new DateTimeOffset(new DateTime(2026, 2, 5, 8, 3, 34, 697, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 5, 12, 33, 34, 697, DateTimeKind.Local).AddTicks(1842) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db65493c-3e6f-4de5-b194-37f0e9629c01", "AQAAAAIAAYagAAAAELctAkhMkxxkHr3g1xp8ULSwhlxhY/QE9c1vsfpIsAC0nBe3e9oWSb0gdiRflUiOrQ==", "6a09d362-879d-4c92-8449-02e23d6c57d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a62f496f-a631-4dcf-aa10-ca93b9d4c628", "AQAAAAIAAYagAAAAEC7kE5VASdIGtgy+IksJfgW4RUYT0B+LfNj6KWF2td1KOSd331sc6Nw2pivGpELh+Q==", "b315b88e-de29-4747-ba8a-47d4d5c07044" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b4be7ec-df3d-4daa-83f2-71a324325684", "AQAAAAIAAYagAAAAEIALuX6bkkIp4JChCRmKcYBC0jVjcpwl7n26jRPz6NlOMCKtTU8ktC2wk74OdfCgrw==", "a9de5cf5-d22a-4bbd-8711-c142889c6137" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be72a797-c37a-493a-86c2-a13af2363653", "AQAAAAIAAYagAAAAEG5tvgJpIiPgmyYVpGB3Ra9fjNInh7joUzF1PX3Bp6JaQExtwiPxor7lX4L9PJkRVw==", "1bd00f76-19fd-406b-8bae-0d746cc61aa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93d3f83b-ff48-4778-8570-30eddfa8d9cf", "AQAAAAIAAYagAAAAEPPB/B0gEYB31uQ9uLV5eDUNpBZSBWpPv4BUkuOIF3YAyKfAgxTMZPqAuix2IFb6LA==", "e71d61e7-ebf5-4f89-96b9-7a07e0af0c7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c292f40a-d277-4f21-ba4f-cc336653e9ac", "AQAAAAIAAYagAAAAEOH1DNQK62s439ZciuyZdJNRvt00rheyeX2OpWAYrM0HtN//DpJTPYDd+JC/SRkeOA==", "2a55c55e-6df6-44c8-bea3-a964dd28be96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d43f3f9-6c2e-4d7a-97e6-65f988737315", "AQAAAAIAAYagAAAAEBu4qr3AXSbsMpSli8kp2B3yM973WEsrmcFrzAjYeTd1znDvgi4IvfXE6CKvIeOPaA==", "163010e4-7301-4172-a743-77c537ad193b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "940c030a-a267-42aa-bc5a-8a2c5b06f84a", "AQAAAAIAAYagAAAAED/mK4Z0nZAcSWBiBbAqqwYcuR9EvQ+h6O5TX1bVo7saHWxjBqp6Efr066VrLoLITw==", "992af901-356d-4317-b738-4253b64e0283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "552cf464-11a2-4794-85a4-fae151633926", "AQAAAAIAAYagAAAAEB4c6E8rkfvBF++wsXmycbr5Oqd8uFEORoDpKlVQxxL8mXzFgcB6VjecTOyJT+d12g==", "1fef9497-83e0-43c1-b090-9a9a1f01f31a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73cd26de-f764-4f7c-980b-285f22d21f9c", "AQAAAAIAAYagAAAAEHBnUK/ob1hwLPDeSITJGIhv2v0qh6gcoYq9tz/kez18gj3UGZrKpHRBXXag82Rp4g==", "ef3a3451-eb2d-472a-9669-8a7cf85b2785" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8688b458-2148-4d64-9a17-6bb4c05b84df", "AQAAAAIAAYagAAAAEP2T8JqXZFxfg4GRB23IQG2tfzbRk1RJkOUoUb3L7422ojgrULCSWtXxKrDHCQTiGQ==", "7f41ce44-38cd-47b1-b776-6e1a5308ef92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18b76051-8172-4caf-8d98-8d831f8d2bfa", "AQAAAAIAAYagAAAAEAajJ7SdZ9PPV840TmC2ZcYwQBe3L/hA523DQskSHzRDNvTOFPjlP5Rr3saDXwPf/g==", "e7fd76f5-663e-425a-a848-523ff1dfb044" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e25471e7-40ca-454f-8ee6-49eaac911d42", "AQAAAAIAAYagAAAAEGqKzmGzKEcTOmB+9qyS8M4jhVGqiGImCh789WE6FWRe8b6tUOqfHHMujpuE5Fe3gw==", "0a15a7cd-aed8-4668-9814-9d1355ef9482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "344d2bee-0bf2-4f28-b711-5e86c7c6ab1c", "AQAAAAIAAYagAAAAEFviaf3wSxKe8lPtnpEdhzy0nNj0Lx4fDr4jdjoxTjQA0eQjw4KslBAVhY6CiC0HSA==", "6fc14050-5481-475d-9b10-92f7dc65d1a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c6e77c6-48a5-49c8-8de8-c9b49fef17ba", "AQAAAAIAAYagAAAAEHl8otY3ciyG1xXvSkyzqZKZUxVizOCXtq0RZWOmTGP76V+8XYy4t4D/aXfj02mmUg==", "bbc85a6e-6e14-49bb-8251-8588e6e7bfc5" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 91, DateTimeKind.Local).AddTicks(27), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 91, DateTimeKind.Unspecified).AddTicks(58), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 91, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6776), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6786), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6836), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6837), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6840), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6841), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6843), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6846), new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6847), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 94, DateTimeKind.Local).AddTicks(6136), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 94, DateTimeKind.Unspecified).AddTicks(6182), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 94, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3599), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3601), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 95, DateTimeKind.Local).AddTicks(9393), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 95, DateTimeKind.Unspecified).AddTicks(9412), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 95, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(1892), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3441), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3453), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3516), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3531), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3533), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3547), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3561), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3572), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3575), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3587), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3589), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9064), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(9076), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9674), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(9682), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9685), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(9687), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 79, DateTimeKind.Unspecified).AddTicks(6124), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 79, DateTimeKind.Unspecified).AddTicks(6965), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 79, DateTimeKind.Unspecified).AddTicks(6970), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 87, DateTimeKind.Local).AddTicks(1059), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 87, DateTimeKind.Unspecified).AddTicks(1074), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 87, DateTimeKind.Local).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6176), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6178), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6188), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6191), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6200), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6202), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6212), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6214), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6224), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6235), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6250), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(570), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(599), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(3584), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6045), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6098), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6100), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6112), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6115), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6124), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6137), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6148), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6150), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6164), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6166), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 587, DateTimeKind.Local).AddTicks(636), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 588, DateTimeKind.Unspecified).AddTicks(4916), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 588, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3631), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3634), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3637), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3639), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3642), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3648), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3650), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3653), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3661), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3664), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3666), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3672), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3674), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3677), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3682), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3684), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(1027), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3687), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3692), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3694), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3697), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3702), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(2727), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(2745), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3556), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3569), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3590), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3597), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3611), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3615), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3620), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3626), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 583, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2522), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2550), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2566), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2579), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2598), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(191), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2631), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2658), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2665), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2670), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(1600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2690), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2496), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2503), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2510), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(5507), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6766), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6771), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6719), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6737), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6740), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6758), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6761), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4062), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(4076), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4454), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(4462), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4464), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(4466), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4467), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 83, DateTimeKind.Local).AddTicks(8519), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(8539), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 83, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 86, DateTimeKind.Local).AddTicks(86), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 86, DateTimeKind.Unspecified).AddTicks(121), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 86, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 86, DateTimeKind.Local).AddTicks(1167), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 86, DateTimeKind.Unspecified).AddTicks(1179), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 86, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 591, DateTimeKind.Local).AddTicks(420), new DateTime(2026, 8, 4, 16, 45, 43, 589, DateTimeKind.Utc).AddTicks(9559), new DateTime(2026, 1, 25, 16, 45, 43, 589, DateTimeKind.Utc).AddTicks(9414), new DateTime(2026, 2, 4, 21, 15, 43, 591, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 592, DateTimeKind.Local).AddTicks(9608), new DateTime(2026, 9, 4, 16, 45, 43, 592, DateTimeKind.Utc).AddTicks(9516), new DateTime(2026, 1, 30, 16, 45, 43, 592, DateTimeKind.Utc).AddTicks(9512), new DateTime(2026, 2, 4, 21, 15, 43, 592, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 593, DateTimeKind.Local).AddTicks(3256), new DateTime(2026, 5, 4, 16, 45, 43, 593, DateTimeKind.Utc).AddTicks(3224), new DateTime(2026, 1, 20, 16, 45, 43, 593, DateTimeKind.Utc).AddTicks(3220), new DateTime(2026, 2, 4, 21, 15, 43, 593, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 593, DateTimeKind.Local).AddTicks(6143), new DateTime(2026, 1, 15, 16, 45, 43, 593, DateTimeKind.Utc).AddTicks(6125), new DateTime(2026, 2, 4, 21, 15, 43, 593, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 594, DateTimeKind.Local).AddTicks(8576), new DateTime(2026, 2, 4, 21, 15, 43, 594, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8421), new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(291), new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(4224), new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8248), new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8313), new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8347), new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8368), new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8385), new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8404), new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(1296), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(1318), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2207), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2217), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2242), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2257), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2258), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2262), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2264), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2265), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2268), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2272), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2274), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(6215), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(6234), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7154), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7157), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7163), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7067), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7080), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7087), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7089), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7092), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7095), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7096), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7098), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7099), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7147), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7149), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7151), new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 82, DateTimeKind.Unspecified).AddTicks(4513), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4052), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(2067), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(3186), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(3975), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4005), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4014), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4031), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4037), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
