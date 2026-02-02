using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kjn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopId",
                table: "StockTransaction",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "StockTransaction",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4c260c6-a22e-43d6-912d-6c31d2506cc1", "AQAAAAIAAYagAAAAENxz1jgVkguLWVOEId+5cFFyo3PTiuLLYQgBo/Fj36IN5DO1w3pmeYKU0/MPFsJFvg==", "2d6329df-45f8-4ab3-bd54-f1c76899cba3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73dbaaf4-b147-4010-9775-4c19b24c70f3", "AQAAAAIAAYagAAAAEJjFRyGEob+DiUaiaqZLKnLhybAwYZwoOFNo1C1bDDaBUFLvTW2npyTmKPZcKb6P2w==", "87017e04-ec9d-4bec-bd52-1d6ad34f759e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a8fd8b1-412d-4dd4-adc7-3a62c83040a2", "AQAAAAIAAYagAAAAEOsG55n50U05MX7dlblp5AQHuIxEXP6yhJcJK9fvIyVCbguvQJal5fAF1EyxhL1PGQ==", "2308dd0b-6bde-4433-9811-5a3de262dfa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d7687d8-cab3-4ef0-8980-7b9cb6e52be7", "AQAAAAIAAYagAAAAEFb1fcZcrvKAB2lxAquIaNxA/BRyGVr1yTUVfCR2L6xxd9sAJFjHYoksEBwFVQZdWQ==", "34e255e9-6574-4d05-b2ac-e8d8ed8e894f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c10e86a-7344-40fa-a408-9db7155fd3e4", "AQAAAAIAAYagAAAAEBWTS4HtStYHOP4xx/+jljJSyeFpFVRD0OzxukRsLtQ1GWRwtQwTs/gPHCZuBvpNxQ==", "dc4fdc58-ee9e-4c31-b02a-dc7f9a25cf24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3c4708a-d143-4667-82c6-305d2c494205", "AQAAAAIAAYagAAAAEKeWupWHE1eOtpwtjeCqDxGV7mkEu9kPQooJHmgZIeuVrkgT9ZVfn1mpIHOf5NyGGg==", "bd5f74dc-fea4-48bb-931c-e28b5cddd330" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c3dbc8b-2afe-4653-9025-cd7b313a212d", "AQAAAAIAAYagAAAAEDf73cxg/C9WnfubdFAd0FzaV1E1S2wh8n+uIJZCFTnhGeNGmORXtiRQurWfRen1gg==", "8d00c0ca-0359-4bd3-b625-3760e25de715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32f8ad84-ba15-45d2-9505-550e7a229f11", "AQAAAAIAAYagAAAAEIcGDDkZ0YQUz1949BTVFsSDt+yGikOA5xieb+W7v2OM/fY/WTgkiBl30DTIkOVfWg==", "ef2a183b-e755-4c4c-9711-c35e3d2280ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be4fecbc-10d5-46a8-ae65-25b6fe30fec8", "AQAAAAIAAYagAAAAEPUdAZJnrovLNAHaIcBgZIaLagYkEUWNSVPFa8v6IdRqMvK7lkUqMB7MKD3+TghqhQ==", "3d0922f2-b655-4ab3-82b9-ecb473492d1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "449085d0-cd15-40e4-a92f-9946810b47ec", "AQAAAAIAAYagAAAAEC0QHeTlplffVd6yFoxHN2PhIS1z02UWJ+vNiZDCSxm0WqvHotJtPTBV0/whBNsT2Q==", "f34d8086-f2c9-4e41-9011-e646e39f667d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "375e438d-4bd2-433c-9f5a-a61e07cd2a47", "AQAAAAIAAYagAAAAEB4bQlDgF1L0v0lQDmMgKe5+ihXx/8dRKws0mC0xH9vI4H0jpoRgeK+t2cdAkiYxtA==", "72bcee7f-a744-4c23-a644-52d3d464ab6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62445901-e599-4eff-816a-d2da86478ba1", "AQAAAAIAAYagAAAAELBcheJV6WSmRyg5U/zKYV/vhvEi2ZvcN2VGGBqIHRlH+yLwkRpj9LDoV6FyF8NT2g==", "f419d121-abad-4cb7-b1ac-ca03ed38eff0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff0f4ce-0b01-431f-9a43-2bf8d5370b8b", "AQAAAAIAAYagAAAAEKcwhgZORwYdEw0xHQ61n12MMOX3mWSGXqFMHFnWB5kQUjVww/vPl5DmuIULXqhPKQ==", "3e6fbefa-668a-412b-90f1-b2b390dffaf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2025e34a-5102-4534-9a86-00a55b8cecc8", "AQAAAAIAAYagAAAAEI+4VnVXN3PWWiTfh+mN2L7KYRgjNZWP7qr3+laaAoA/5JaGE+ptTTjkO3Luen9+Hg==", "cc4d98bc-ff8d-47e4-a93e-9723b307f523" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb04c69b-7d51-45da-a8d0-6e3b337fa552", "AQAAAAIAAYagAAAAEPcXBH9Cx/1H14g0j68Z+91Q1P2Rlg7npgp3zFfbY3Nc7M0pyqjLI4Fet1Ata5gaoQ==", "4e52725b-8249-4d4b-aa31-1e79cf7d66a2" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(7628), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Unspecified).AddTicks(7673), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(5971), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(5980), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6022), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6134), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(6135), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6137), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(6138), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6139), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(6140), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(378), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 407, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(1055), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 407, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(1068), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 407, DateTimeKind.Unspecified).AddTicks(1164), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 401, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 401, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 401, DateTimeKind.Unspecified).AddTicks(4454), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 414, DateTimeKind.Local).AddTicks(9394), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 414, DateTimeKind.Unspecified).AddTicks(9437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 414, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1705), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1719), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1721), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1731), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1736), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1746), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1749), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1758), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1761), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1771), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1784), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1786), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 420, DateTimeKind.Local).AddTicks(3166), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 420, DateTimeKind.Unspecified).AddTicks(3240), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 420, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 420, DateTimeKind.Local).AddTicks(8420), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 420, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 420, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1397), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1559), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1628), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1646), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1659), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1671), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1674), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1693), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 884, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6969), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6981), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6991), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6998), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7004), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7010), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7017), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(3833), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7035), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7050), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7057), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7065), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7143), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(5800), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7163), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6943), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6949), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6955), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6962), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7491), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7467), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7480), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7485), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(3948), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4421), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(4429), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4431), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(4434), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4435), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(4438), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 409, DateTimeKind.Local).AddTicks(5448), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 409, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 409, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 413, DateTimeKind.Local).AddTicks(935), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 413, DateTimeKind.Unspecified).AddTicks(989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 413, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 413, DateTimeKind.Local).AddTicks(3441), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 413, DateTimeKind.Unspecified).AddTicks(3486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 413, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 889, DateTimeKind.Local).AddTicks(3077), new DateTime(2026, 8, 2, 16, 11, 38, 888, DateTimeKind.Utc).AddTicks(8341), new DateTime(2026, 1, 23, 16, 11, 38, 888, DateTimeKind.Utc).AddTicks(8252), new DateTime(2026, 2, 2, 20, 41, 38, 890, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 891, DateTimeKind.Local).AddTicks(9395), new DateTime(2026, 9, 2, 16, 11, 38, 891, DateTimeKind.Utc).AddTicks(9353), new DateTime(2026, 1, 28, 16, 11, 38, 891, DateTimeKind.Utc).AddTicks(9350), new DateTime(2026, 2, 2, 20, 41, 38, 891, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 892, DateTimeKind.Local).AddTicks(2407), new DateTime(2026, 5, 2, 16, 11, 38, 892, DateTimeKind.Utc).AddTicks(2391), new DateTime(2026, 1, 18, 16, 11, 38, 892, DateTimeKind.Utc).AddTicks(2388), new DateTime(2026, 2, 2, 20, 41, 38, 892, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 892, DateTimeKind.Local).AddTicks(4574), new DateTime(2026, 1, 13, 16, 11, 38, 892, DateTimeKind.Utc).AddTicks(4559), new DateTime(2026, 2, 2, 20, 41, 38, 892, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 893, DateTimeKind.Local).AddTicks(3062), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 893, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3286), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 894, DateTimeKind.Local).AddTicks(7328), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 894, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(486), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3119), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3166), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3178), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3247), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3258), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "ShopId", "ShopName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3269), "1", "Main Store", new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(5429), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8784), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8831), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8836), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8843), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8848), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8854), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8859), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8865), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8869), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8877), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 404, DateTimeKind.Local).AddTicks(8979), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 404, DateTimeKind.Unspecified).AddTicks(9192), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 404, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(796), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(804), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(807), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(812), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(649), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(678), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(682), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(724), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(728), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(730), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(733), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(737), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(740), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(743), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(778), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(784), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(788), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(790), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(794), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 407, DateTimeKind.Unspecified).AddTicks(6484), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(5588), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(7766), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8795), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_ShopId",
                table: "StockTransaction",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockTransaction_Shop_ShopId",
                table: "StockTransaction",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockTransaction_Shop_ShopId",
                table: "StockTransaction");

            migrationBuilder.DropIndex(
                name: "IX_StockTransaction_ShopId",
                table: "StockTransaction");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "StockTransaction");

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "StockTransaction");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b4e82f3-1c20-4fe8-95cf-19d2e96ad637", "AQAAAAIAAYagAAAAEEp4zOZxOMtsK5R9WdIGaDRNKU+AJlbdDiORJXUBYHke/Wxs7EPMJYZ7Orx5htj3fg==", "b76231e3-3734-4a26-80e8-fee238b76a21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f75f3b11-0a13-46b7-990d-71c2ed819a29", "AQAAAAIAAYagAAAAEINDq8hiYXwdEnhUOdJH+QL6EeS9esTIz3NSe4VpAm4sHG3GHoUQDtSQ54tovmkRrA==", "803706bf-589f-4947-94f0-f51c08f1b229" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c05a2bfb-b8a1-4e51-9430-1cfd26b17950", "AQAAAAIAAYagAAAAEINtemQwCBoBQhgdbnPEd9Tju8Xcg96QMCwUeoTH1iBck5Q0bGC+mO/gtALcxD4LCw==", "598980f2-5c7d-4767-8413-306acc9aa24e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83b24b56-5ffe-499f-93f2-875da2f9a4db", "AQAAAAIAAYagAAAAEJqk1rLFwJBJR5JUqLdJNE5675YQ4Dt8IYRLyZ1DpWwSdjssei3I6+O0kuaWLC0tAw==", "325e6866-9ca2-4bb4-a2c0-854564fff5b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f34f5e-5d5c-4354-9aea-965b8e122e78", "AQAAAAIAAYagAAAAELntysho0Sc3jz0YunGwxZ7CVe8EA5Kl2Fr3Eeud3Mpd9nCn28n7JFvldCRzwHSw5g==", "ee9ee218-2a59-40e6-90e7-1cc70352489f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98569b3e-37a0-4b39-86f8-8cf581a6788d", "AQAAAAIAAYagAAAAEOp+JWKxZhPGw5IJpyP2VV3byj02Ql1DTOfAwGbccQvTdZ9AvMpOneP3lFYD4tfN+Q==", "ec050207-20f3-417c-a2c0-c8fcce7e9030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1c35a33-1feb-4f46-a94d-49926b3f4a3a", "AQAAAAIAAYagAAAAEKNpsUXRyOAfRmWWZEMD3PWepkgKhSnEnPBKnkKBKx+ieioGG0aA8I/dzDJmDWryyQ==", "8f0ec868-40d6-4aa8-8172-d4491cc0f7d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da839075-7d34-453f-acba-6a56f169bba4", "AQAAAAIAAYagAAAAEJRzymEJ2CKP1ztgeXezZR4+mVARZxlmuXCnMnq5TGpCqLUd16EFMM3OnpPd5Eo4hQ==", "2a2e8319-f4e1-4f5e-9abf-da8b09e830ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3a5523a-8c98-46fd-a9da-6632efecdc52", "AQAAAAIAAYagAAAAEGnctsCsv+DXg2nKo3PIYhxRm1mT6rQUH/8xvn+sPh+oY+7cNLOjYuGJLVf1pzXbqw==", "bbaf2899-4873-4f81-9dd0-d9c5d77c1c9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "104e5841-157d-4f06-8b5b-ab987f533aae", "AQAAAAIAAYagAAAAEE4QHb7ElsHGSCsKp1TF0VEHP9cOLnof5EQnB89IhyDjE3pss6ZcEyCKCoHCo/P7GA==", "2ab3a28d-9778-4b20-8b6d-8f752bfa3e9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10d90644-6a61-409b-9d6b-e1b53f2f169a", "AQAAAAIAAYagAAAAEKkJ2/4CXydLHkTgkH1cOc7QQ5NVJLbuTvFKOyWVZn3cI+b/bqs5RbOOMe8A1ArcKA==", "fcc8893c-ba4e-4f9e-8c97-75a293c43f42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "096d516b-bbd7-4bff-9e2c-754a63205234", "AQAAAAIAAYagAAAAEIkj3N8C1WNjG6qqCqgPvx2f+eTWk2FIosWx5+kKrMXKqEp0BHreUnQYgVaYoC6l/g==", "d934bd49-021a-4682-8e5c-cb6d085e095b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e5ff3a0-4ffd-424b-bcfd-5eab8bbab549", "AQAAAAIAAYagAAAAEMbZlPrGQV9Oc5D7B+CFcwjdcHF+xngvMIzj5yKMgzJut93hNmUy1dElakxd/E2hgQ==", "9df2acfe-c765-42d1-aaf2-9b25cf44f8f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b377e5a8-f194-48b2-88c3-1348adf08b6b", "AQAAAAIAAYagAAAAEI069g3vRtiiQ+Mb9g7myx2etiHbO0ZdZx/Pt0BmSHjX/flWsH3aGTbiJoy9XVUipw==", "7670dba8-a345-49d0-aff5-5092ddf16b08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d0341e5-834d-4d57-bdf2-a5495fabf9ad", "AQAAAAIAAYagAAAAEKBPM72BlW9RPzlS8UtkJ1lWAbQ2s2hz1seXcAoDHLxJzWLE85AXrpBWWPIv/NCrWg==", "40c6dfb1-ffb1-46d9-9a77-14d3021f4c41" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(5431), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Unspecified).AddTicks(5473), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(8976), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(8992), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9041), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9046), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(9047), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9049), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9052), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Unspecified).AddTicks(9054), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 636, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(4835), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(4852), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(5508), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(5518), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(5519), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(5522), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 622, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 618, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 618, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 618, DateTimeKind.Unspecified).AddTicks(6628), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 630, DateTimeKind.Local).AddTicks(302), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 630, DateTimeKind.Unspecified).AddTicks(341), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 630, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(459), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(474), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(549), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(552), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(564), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(581), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(583), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(593), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(606), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 633, DateTimeKind.Local).AddTicks(2585), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 633, DateTimeKind.Unspecified).AddTicks(2635), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 633, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 633, DateTimeKind.Local).AddTicks(7064), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 633, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 633, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(288), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(360), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(385), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(398), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(411), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(413), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(424), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(427), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(446), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 634, DateTimeKind.Unspecified).AddTicks(448), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 634, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 442, DateTimeKind.Unspecified).AddTicks(4190), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7454), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7460), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7465), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7797), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7362), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7815), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7821), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7831), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7836), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7847), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7862), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7405), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7427), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7433), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 23, 443, DateTimeKind.Unspecified).AddTicks(7437), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(133), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1719), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1722), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1670), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1683), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1706), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1709), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1712), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 622, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8053), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 621, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8566), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 621, DateTimeKind.Unspecified).AddTicks(8574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8576), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 621, DateTimeKind.Unspecified).AddTicks(8578), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8580), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 621, DateTimeKind.Unspecified).AddTicks(8583), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 621, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 624, DateTimeKind.Local).AddTicks(9897), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(9933), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 624, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 628, DateTimeKind.Local).AddTicks(4827), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 628, DateTimeKind.Unspecified).AddTicks(4884), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 628, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 628, DateTimeKind.Local).AddTicks(6697), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 628, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 628, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 472, DateTimeKind.Local).AddTicks(9782), new DateTime(2026, 8, 2, 15, 33, 23, 472, DateTimeKind.Utc).AddTicks(2285), new DateTime(2026, 1, 23, 15, 33, 23, 472, DateTimeKind.Utc).AddTicks(2054), new DateTime(2026, 2, 2, 20, 3, 23, 476, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 478, DateTimeKind.Local).AddTicks(6770), new DateTime(2026, 9, 2, 15, 33, 23, 478, DateTimeKind.Utc).AddTicks(6673), new DateTime(2026, 1, 28, 15, 33, 23, 478, DateTimeKind.Utc).AddTicks(6666), new DateTime(2026, 2, 2, 20, 3, 23, 478, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 479, DateTimeKind.Local).AddTicks(1994), new DateTime(2026, 5, 2, 15, 33, 23, 479, DateTimeKind.Utc).AddTicks(1953), new DateTime(2026, 1, 18, 15, 33, 23, 479, DateTimeKind.Utc).AddTicks(1950), new DateTime(2026, 2, 2, 20, 3, 23, 479, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 479, DateTimeKind.Local).AddTicks(5429), new DateTime(2026, 1, 13, 15, 33, 23, 479, DateTimeKind.Utc).AddTicks(5412), new DateTime(2026, 2, 2, 20, 3, 23, 479, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 480, DateTimeKind.Local).AddTicks(7512), new DateTime(2026, 2, 2, 20, 3, 23, 480, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(30), new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(3450), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(7535), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9846), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9962), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9983), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9994), new DateTime(2026, 2, 2, 20, 3, 23, 482, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(4), new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(20), new DateTime(2026, 2, 2, 20, 3, 23, 483, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(5533), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(6624), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8426), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8442), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8446), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8449), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8451), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8456), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8459), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8461), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8464), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8466), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8483), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 619, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 619, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(5399), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(5439), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6494), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6498), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6500), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6501), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6398), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6408), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6410), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6441), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6443), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6447), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6461), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6464), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6465), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6487), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6490), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6491), new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 620, DateTimeKind.Unspecified).AddTicks(6493), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 3, 25, 620, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 623, DateTimeKind.Unspecified).AddTicks(1311), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3348), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(804), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(2368), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3306), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3312), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3317), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 15, 33, 25, 624, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
