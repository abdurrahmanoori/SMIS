using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class clinetRelatedFiledAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "LastSyncedAt",
                table: "Customers",
                newName: "ClientModifiedDate");

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "UnitOfMeasure",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "UnitOfMeasure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "UnitOfMeasure",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientModifiedDate",
                table: "UnitOfMeasure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "UnitOfMeasure",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UnitOfMeasure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "UnitOfMeasure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UnitOfMeasure",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "UnitOfMeasure",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "UnitOfMeasure",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "UnitOfMeasure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "UnitOfMeasure",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "UnitOfMeasure",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "Shop",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientModifiedDate",
                table: "Shop",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "ProductUnit",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "ProductUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "ProductUnit",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientModifiedDate",
                table: "ProductUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductUnit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "ProductUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "ProductUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "ProductUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ProductUnit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ProductUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "ProductPrice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "ProductPrice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "ProductPrice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientModifiedDate",
                table: "ProductPrice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "Product",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "Product",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientModifiedDate",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCreatedBy",
                table: "Customers",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClientCreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientModifiedBy",
                table: "Customers",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa6100ff-1d21-43cf-a183-5a144a162878", "AQAAAAIAAYagAAAAED76YzVtW2FavBuyzGdLJesLx3sVq8uxahlR6Qb+pWHm/iMN0k4j2iaVSge+/W1Lew==", "acd9cce8-ad13-4d1c-ac51-2d7be2f3b10a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b460112d-130a-4ac4-96d8-6b079f30e3e8", "AQAAAAIAAYagAAAAECzzQ7hiMOuCcs5Ldseuo9HgFT/Ki77iMWquvKoqq8Acbd+kUscrVuVGUAGjqx8M/w==", "27002c7e-2a54-4d62-8b7b-591097b2ab1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a2abad8-5bef-4c4f-b535-5bec94cfec20", "AQAAAAIAAYagAAAAEC4o+rH7OMgLdpp+nPmxdmelFQOOqvTuTEEy1JvOjNFjaZgRpJChaU9VgudJbRS99w==", "53bbc95f-8fbd-4503-b611-e9553d2c7225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f137402-8a6d-4463-82a1-4afbb6a5847e", "AQAAAAIAAYagAAAAEMcI62rlssqts5mPiUqltJcbsh0/R3oDtKxFDXmJtggJjg3bphptR0Z7Y0t2BywGrg==", "3e6a463c-cb76-4f51-8900-4519e26052d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a1a206c-691b-45fb-b802-1e11ff387cc4", "AQAAAAIAAYagAAAAEPo9md6NHRG2klg3PU0wzh1eYALooZ1LCMEEOaJzRUj+jIhE6CZEsq/q0cMf0TkegQ==", "62a3ef6e-fbf6-4bc5-bcc0-63ec34124691" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7e42162-f89a-474b-8e96-dd4d2e70705f", "AQAAAAIAAYagAAAAEBrRmP5BzBXEJet1ySXwCbP5V2wCfMoapGJJLG9mcucRcYGwylLLptPB0D2dk0yQdQ==", "174ebaed-c468-4ee3-9d44-7b09f1011ffd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d80059c-4bb0-42ec-98f5-576db9d4aa07", "AQAAAAIAAYagAAAAEOH5oEnvi++hQaxRUC3hB+Nboy+4Q03UB/XdHoJpLy1GOcW8p2rvG+0YzZy5cly4Lg==", "402bebd1-02ae-49e2-b6f4-b1b158346ef4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16871a85-06b5-4d2b-adfd-81107e82b2c7", "AQAAAAIAAYagAAAAEKBB7kjMfrlY6WK5BgjelEKCLhZa/1utJMU+/3t0fvM9my/elR36ikiR9XBZNZJjoA==", "74ffe48f-3ec6-44af-9a8d-1cac4773ed33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "800006d0-ae8f-47d2-86ae-2add7f4dd363", "AQAAAAIAAYagAAAAEENlJEy0V4dKDLWkq1xm/io8p5UgdPKtPPbazrCMK7r0IL4v5N/uQMTL1dS3+sKb6A==", "201f34b3-d610-4e10-a5f3-846abfa74818" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17352f72-b148-4b90-86c3-c16921a40b99", "AQAAAAIAAYagAAAAEImW0y591CQ1HXjow8h97kZ/1Cyyys9v3TMZKyhiqIwvGbqpv1dMtXhHIDr2PAVLEQ==", "10510f8a-0904-4703-8634-e3bfe7722fac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e899841-bda6-4922-a5b6-a02d2cb6e6ae", "AQAAAAIAAYagAAAAEICZKiyjG9Ayfsw9jjlCDOF5ZA48N/doIo3r7cXFI9Wv4wGyEUAo2jhrjzhuS6Bd/A==", "adaa1f34-b2a6-486b-93dd-c8deb580e093" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "612846a0-2f20-4510-a07a-841d8b8abf58", "AQAAAAIAAYagAAAAENlT2MD8ayd4iDNTGndhDXCEzUIjymXk41lwSN0q1UZM2sf85Xmr1GuTDIzYl1me3A==", "78e52712-86bf-4451-b897-afa5a645517b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b7245ec-990b-4dca-905e-e06e8307a0f4", "AQAAAAIAAYagAAAAEIK619Y7DtVVzeZo7MdFZReLP0+Wo4nx8JKmsqC6H17B58gOFdHMimN9JiRoQirJWA==", "4c971b9c-8b33-4601-96a9-cc099ed6643b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f03a6f44-e230-4c80-afd2-02e2868c5dab", "AQAAAAIAAYagAAAAEAuFquC07leDZylTgzlgOPd2sJby5VdxduEXD9xX9q0zXgrTJEsTT3/gIVa4d/pdFQ==", "176b0b09-0293-47a2-9a7d-883798571fcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04a9321a-595f-40ca-97f0-b25daa91fc4d", "AQAAAAIAAYagAAAAEF06DB82Ry7tiXj07KEkpzG/zuWekQ/byG84732XnaH7lqaj2ENa0d1JXTUHG0x+Qg==", "333e9c0d-10fc-4ae0-90e2-2ae8cf27581a" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(7944), "2026-09-06 12:36:54.988805", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8079), "2026-09-06 12:36:54.988808", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8084), "2026-09-06 12:36:54.988808", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8087), "2026-09-06 12:36:54.988808", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8101), "2026-09-06 12:36:54.988810", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8105), "2026-09-06 12:36:54.988810", new DateTime(2026, 9, 6, 12, 36, 54, 988, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 996, DateTimeKind.Utc).AddTicks(7374), "2026-09-06 12:36:54.996754", new DateTime(2026, 9, 6, 12, 36, 54, 996, DateTimeKind.Utc).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 996, DateTimeKind.Utc).AddTicks(9068), "2026-09-06 12:36:54.997001", new DateTime(2026, 9, 6, 12, 36, 54, 996, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(1311), "2026-09-06 12:36:54.997447", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5192), "2026-09-06 12:36:54.997521", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5223), "2026-09-06 12:36:54.997522", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5237), "2026-09-06 12:36:54.997524", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5250), "2026-09-06 12:36:54.997525", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5267), "2026-09-06 12:36:54.997527", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5280), "2026-09-06 12:36:54.997528", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5293), "2026-09-06 12:36:54.997529", new DateTime(2026, 9, 6, 12, 36, 54, 997, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982477");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982509");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982510");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.980791");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.980845");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.980846");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(2653), new DateTime(2026, 10, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006288", new DateTime(2026, 8, 7, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(5597), new DateTime(2026, 9, 21, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006633", new DateTime(2026, 8, 22, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(8449), new DateTime(2026, 9, 26, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006923", new DateTime(2026, 8, 27, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9581), new DateTime(2026, 10, 21, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006958", new DateTime(2026, 9, 1, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9605), new DateTime(2026, 9, 16, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006960", new DateTime(2026, 8, 17, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9690), new DateTime(2026, 9, 24, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006969", new DateTime(2026, 8, 25, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9706), "2026-09-06 12:36:55.006971", new DateTime(2026, 8, 12, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9723), new DateTime(2026, 9, 18, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006972", new DateTime(2026, 8, 19, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9739), new DateTime(2026, 9, 28, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006974", new DateTime(2026, 8, 29, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9759), new DateTime(2026, 10, 3, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), "2026-09-06 12:36:55.006976", new DateTime(2026, 9, 3, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(9005), new DateTime(2026, 9, 6, 12, 36, 55, 6, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(2284), "2026-09-06 12:36:54.991248", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(4686), "2026-09-06 12:36:54.991559", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(7161), "2026-09-06 12:36:54.991818", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8567), "2026-09-06 12:36:54.991857", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8587), "2026-09-06 12:36:54.991859", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8601), "2026-09-06 12:36:54.991860", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8615), "2026-09-06 12:36:54.991861", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8629), "2026-09-06 12:36:54.991863", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8643), "2026-09-06 12:36:54.991865", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8659), "2026-09-06 12:36:54.991866", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8671), "2026-09-06 12:36:54.991867", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8686), "2026-09-06 12:36:54.991869", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8744), "2026-09-06 12:36:54.991874", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8756), "2026-09-06 12:36:54.991876", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8769), "2026-09-06 12:36:54.991877", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8781), "2026-09-06 12:36:54.991878", new DateTime(2026, 9, 6, 12, 36, 54, 991, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(1884), "2026-09-06 12:36:54.995216", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(3400), "2026-09-06 12:36:54.995453", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(5427), "2026-09-06 12:36:54.995646", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6844), "2026-09-06 12:36:54.995685", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6863), "2026-09-06 12:36:54.995686", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6870), "2026-09-06 12:36:54.995687", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6956), "2026-09-06 12:36:54.995696", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6964), "2026-09-06 12:36:54.995696", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6972), "2026-09-06 12:36:54.995697", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6979), "2026-09-06 12:36:54.995698", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6985), "2026-09-06 12:36:54.995698", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6991), "2026-09-06 12:36:54.995699", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7019), "2026-09-06 12:36:54.995702", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7026), "2026-09-06 12:36:54.995702", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7032), "2026-09-06 12:36:54.995703", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7039), "2026-09-06 12:36:54.995704", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7046), "2026-09-06 12:36:54.995704", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7053), "2026-09-06 12:36:54.995705", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7060), "2026-09-06 12:36:54.995706", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7067), "2026-09-06 12:36:54.995707", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7075), "2026-09-06 12:36:54.995707", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7082), "2026-09-06 12:36:54.995708", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7088), "2026-09-06 12:36:54.995709", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7133), "2026-09-06 12:36:54.995713", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7141), "2026-09-06 12:36:54.995714", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7148), "2026-09-06 12:36:54.995715", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7155), "2026-09-06 12:36:54.995715", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7162), "2026-09-06 12:36:54.995716", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7170), "2026-09-06 12:36:54.995717", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7176), "2026-09-06 12:36:54.995717", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7183), "2026-09-06 12:36:54.995718", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7189), "2026-09-06 12:36:54.995719", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7195), "2026-09-06 12:36:54.995719", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7201), "2026-09-06 12:36:54.995720", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7212), "2026-09-06 12:36:54.995721", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7219), "2026-09-06 12:36:54.995722", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7226), "2026-09-06 12:36:54.995722", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7232), "2026-09-06 12:36:54.995723", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7238), "2026-09-06 12:36:54.995724", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7244), "2026-09-06 12:36:54.995724", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7279), "2026-09-06 12:36:54.995728", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7286), "2026-09-06 12:36:54.995728", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7293), "2026-09-06 12:36:54.995729", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7299), "2026-09-06 12:36:54.995730", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7307), "2026-09-06 12:36:54.995731", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7313), "2026-09-06 12:36:54.995731", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7319), "2026-09-06 12:36:54.995732", new DateTime(2026, 9, 6, 12, 36, 54, 995, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993418", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993544", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993663", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993731", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993732", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993733", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993734", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993734", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993735", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993736", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993736", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993737", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993740", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993741", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993741", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993747", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993748", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993748", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993749", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993750", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993751", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993751", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993752", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993753", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993753", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993754", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993755", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993755", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993756", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993757", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993757", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993758", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993758", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993759", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993760", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993764", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993764", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993765", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993766", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993766", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993767", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993768", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993768", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993769", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993770", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993770", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.993771", null, null, null });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982136");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982191");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982193");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982193");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982194");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982194");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982194");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982194");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982198");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982199");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982199");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982199");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982058");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982079");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982079");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.982080");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(858), "2026-09-06 12:36:54.985152", new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(3139), "2026-09-06 12:36:54.985426", new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { null, null, null, null, new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(5652), "2026-09-06 12:36:54.985682", new DateTime(2026, 9, 6, 12, 36, 54, 985, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(4741), "2026-09-06 12:36:54.999496", new DateTime(2026, 9, 6, 17, 6, 54, 998, DateTimeKind.Local).AddTicks(43), new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(6220), "2026-09-06 12:36:54.999697", new DateTime(2026, 9, 6, 17, 6, 54, 999, DateTimeKind.Local).AddTicks(4980), new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(8182), "2026-09-06 12:36:54.999913", new DateTime(2026, 9, 6, 17, 6, 54, 999, DateTimeKind.Local).AddTicks(7316), new DateTime(2026, 9, 6, 12, 36, 54, 999, DateTimeKind.Utc).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(901), new DateTime(2027, 3, 6, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), "2026-09-06 12:36:55.001134", new DateTime(2026, 8, 27, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(3392), new DateTime(2027, 4, 6, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), "2026-09-06 12:36:55.001419", new DateTime(2026, 9, 1, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(5427), new DateTime(2026, 12, 6, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), "2026-09-06 12:36:55.001632", new DateTime(2026, 8, 22, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(6677), "2026-09-06 12:36:55.001668", new DateTime(2026, 8, 17, 12, 36, 55, 0, DateTimeKind.Utc).AddTicks(1931), new DateTime(2026, 9, 6, 12, 36, 55, 1, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 3, DateTimeKind.Utc).AddTicks(7857), "2026-09-06 12:36:55.003801", new DateTime(2026, 9, 6, 12, 36, 55, 3, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(283), "2026-09-06 12:36:55.004110", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(2558), "2026-09-06 12:36:55.004354", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4196), "2026-09-06 12:36:55.004420", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4218), "2026-09-06 12:36:55.004422", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4276), "2026-09-06 12:36:55.004428", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4288), "2026-09-06 12:36:55.004429", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4299), "2026-09-06 12:36:55.004430", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4309), "2026-09-06 12:36:55.004431", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4318), "2026-09-06 12:36:55.004432", new DateTime(2026, 9, 6, 12, 36, 55, 4, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981220");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981267");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981268");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981268");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981268");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981275");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981275");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981276");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981583");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981618");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981619");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981619");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981619");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981619");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981621");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981622");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981622");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981623");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981623");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-06 12:36:54.981623");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.987748", null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.987886", null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.987995", null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.988059", null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.988059", null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.988061", null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.988061", null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.988071", null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.988072", null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                columns: new[] { "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, null, null, null, null, null, null, "Unchanged", false, false, true, "2026-09-06 12:36:54.988072", null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "ClientModifiedDate",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "UnitOfMeasure");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ClientModifiedDate",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ClientModifiedDate",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ProductUnit");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ClientModifiedDate",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ClientModifiedDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ClientCreatedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ClientCreatedDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ClientModifiedBy",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ClientModifiedDate",
                table: "Customers",
                newName: "LastSyncedAt");

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd0a468-0712-421e-8a57-91a30095756f", "AQAAAAIAAYagAAAAEO7hpnuBvCuMHzyanpTTWYc/rnug3J+oJoYf8nwBlEmv4FDPFlbv+T8uedBuJFhEcw==", "9c3d45bd-d6b6-497d-aec4-59c6eba1e6e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "688ba3a6-e99e-4a9c-aae1-405d4a39523e", "AQAAAAIAAYagAAAAEL5lN64+UixZjPiksHfBY232KZkiLuphQ+sT1KkNhDPEiVWGC5I3R3RK2li5M5wEdg==", "81512417-d4c0-414e-9484-83633ad4eb95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4037663-5d8b-4895-ae24-9e26a11b0779", "AQAAAAIAAYagAAAAEEALFt9iIpwS689b3+go/dDOiEueyVA8Ulg27u3eqobYU1zYkTSvfhNFWkwbDmGm3A==", "93e4a071-bec6-45dc-bd7d-ccb5c9ebe1a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3fdfa1b-051e-4a18-80f9-f3a342210493", "AQAAAAIAAYagAAAAECT6V6JKi36Mg2FK692H3+Ei5LJr1x2NHLNy62s3tst6kmsJ/t0yvkNLw/D4v+9bQA==", "d7c1ea12-07c1-4829-8d2f-44f9cb80b9ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "512512bc-f234-4f79-b371-2ebf73fea254", "AQAAAAIAAYagAAAAENbCRhowzZbdwbEbC/BrlQ32aMHanlDJO1f5EnoSmHc8883DLcXxD3wY3h1Nsjd5PA==", "3c2b5457-4113-49e2-8182-785a8ba22d21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "419ba84b-f5c0-492f-91ca-c9432fe1ebf8", "AQAAAAIAAYagAAAAEMrKJSaRR4p8U3XlmnnnCJvk8Jdlj3OUHNU18iTE0vD9M0vtN1Zm4cl6bTVm4PyhKQ==", "0fd85a2d-a568-40a5-bc78-0a7f9f1cc232" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a53c4030-c5ba-465c-b50b-53dbd7de273b", "AQAAAAIAAYagAAAAEF6W0ie+NPZ3QwRqVKo3W7wyxOqUGB+Jf/EuHAkV2BVSGF+oEXMVMT9331iHlFXWEg==", "af550a63-eead-444d-b1ca-8eb7edee4912" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86b7e74a-1755-4610-b714-096f78fbba8b", "AQAAAAIAAYagAAAAEGS45XZnVbc6n9cTfrMCOvYNEpzmmrVW9BuEz2Uixkm5diPdOHX40tt0G6gl8pqPyQ==", "2b684d0a-bcee-4ba1-bc0b-3655d9423fb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13b5fa3e-2eb4-46ac-bd9a-d877dd760167", "AQAAAAIAAYagAAAAEPE/yD69+WTh8CM+14NLwZz2za9KLCkWtRPDV8eb2etQMMv183nsQ8XE0iVf9TZPng==", "6cd68fbf-628f-41e7-b13e-18dcfa7f165c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2357cbd1-768b-4205-95ea-70b18fb891f7", "AQAAAAIAAYagAAAAEEJoBPL9EyFut/aCNhVYQMD8dV0545sfI9UpIndRm9pDGAPiUui7sVeJ5aP0AY9+ZQ==", "5d9de234-0e63-4d36-8577-a7ba980312d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97495e8f-5914-40b3-b104-6f88b34684df", "AQAAAAIAAYagAAAAEP6bsg2f7OQu8OlZvxpIIdKW2VEUFFZgvfGeKDm/bit4rE06+1kcu0dQJR0a8g+hxQ==", "5dba43c4-077d-4134-b4bd-9649adecfd98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30ca116a-c0bb-4dce-8c64-46548051fcda", "AQAAAAIAAYagAAAAEOga1jWtvI8ZGX/YSVfiZBxu+dlfKaunwxSde8/LgJmV9KYvROCWXHJqZTNkrltluQ==", "2c08364e-b9f1-4bcb-be35-adb397804f8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3ec1b7a-46b4-42bf-8921-1ddbefa7da9f", "AQAAAAIAAYagAAAAELw3oWGT8PRLBCedzSpNicdODKYgLz3yDOcFrzvEEkITClUj6TG337wskSPbYTxq2A==", "2e9c27d7-120b-4bc0-ad17-8965f60d28c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9412da45-2e25-49fd-ae32-93549f5100c4", "AQAAAAIAAYagAAAAECFf+9cErokcc5R5XIySkQbIqgOGAA3pPgkePIULg2MSeEPST/YX/C+EHbIlK2XQeg==", "8ad5b59f-8df4-4477-afff-e8b154e36969" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f9f48d5-02a0-4434-84ca-b468507430d2", "AQAAAAIAAYagAAAAEMYx2nN7NYnTlGdNKib4QT+5ZxdTFEmKpN9PLVdbUMQFM5FBHcJMRx9kCt1oD6rPFw==", "ddb19305-f3e2-4738-8678-f24a7ffda519" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(5360), "2026-09-03 10:14:02.532550", new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6452), "2026-09-03 10:14:02.532645", new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6474), "2026-09-03 10:14:02.532647", new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6486), "2026-09-03 10:14:02.532648", new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6492), "2026-09-03 10:14:02.532649", new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6498), "2026-09-03 10:14:02.532649", new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 545, DateTimeKind.Utc).AddTicks(7831), true, "2026-09-03 10:14:02.545805", new DateTime(2026, 9, 3, 10, 14, 2, 545, DateTimeKind.Utc).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(15), true, "2026-09-03 10:14:02.546097", new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(2392), true, "2026-09-03 10:14:02.546355", new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4037), true, "2026-09-03 10:14:02.546404", new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4059), true, "2026-09-03 10:14:02.546406", new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4077), true, "2026-09-03 10:14:02.546408", new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4101), true, "2026-09-03 10:14:02.546410", new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4119), true, "2026-09-03 10:14:02.546412", new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4133), true, "2026-09-03 10:14:02.546413", new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "eeeeeeee-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4150), true, "2026-09-03 10:14:02.546415", new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525697");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525729");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525729");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.523806");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.523867");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "22222222-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.523868");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 557, DateTimeKind.Utc).AddTicks(4065), new DateTime(2026, 10, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "2026-09-03 10:14:02.557427", new DateTime(2026, 8, 4, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 557, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 557, DateTimeKind.Utc).AddTicks(7221), new DateTime(2026, 9, 18, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "2026-09-03 10:14:02.557812", new DateTime(2026, 8, 19, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 557, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(1605), new DateTime(2026, 9, 23, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "2026-09-03 10:14:02.558436", new DateTime(2026, 8, 24, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5220), new DateTime(2026, 10, 18, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "2026-09-03 10:14:02.558523", new DateTime(2026, 8, 29, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5272), new DateTime(2026, 9, 13, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "2026-09-03 10:14:02.558527", new DateTime(2026, 8, 14, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5296), new DateTime(2026, 9, 21, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "2026-09-03 10:14:02.558530", new DateTime(2026, 8, 22, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5316), "2026-09-03 10:14:02.558532", new DateTime(2026, 8, 9, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5345), new DateTime(2026, 9, 15, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "2026-09-03 10:14:02.558534", new DateTime(2026, 8, 16, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5366), new DateTime(2026, 9, 25, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "2026-09-03 10:14:02.558537", new DateTime(2026, 8, 26, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "44444444-4444-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5389), new DateTime(2026, 9, 30, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "2026-09-03 10:14:02.558539", new DateTime(2026, 8, 31, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 537, DateTimeKind.Utc).AddTicks(3620), "2026-09-03 10:14:02.537386", new DateTime(2026, 9, 3, 10, 14, 2, 537, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 537, DateTimeKind.Utc).AddTicks(8181), "2026-09-03 10:14:02.538077", new DateTime(2026, 9, 3, 10, 14, 2, 537, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 538, DateTimeKind.Utc).AddTicks(8068), "2026-09-03 10:14:02.539097", new DateTime(2026, 9, 3, 10, 14, 2, 538, DateTimeKind.Utc).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2208), "2026-09-03 10:14:02.539223", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2276), "2026-09-03 10:14:02.539228", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2325), "2026-09-03 10:14:02.539233", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2368), "2026-09-03 10:14:02.539237", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2412), "2026-09-03 10:14:02.539242", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2485), "2026-09-03 10:14:02.539250", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2560), "2026-09-03 10:14:02.539257", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2606), "2026-09-03 10:14:02.539261", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2650), "2026-09-03 10:14:02.539267", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2707), "2026-09-03 10:14:02.539271", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2751), "2026-09-03 10:14:02.539276", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2793), "2026-09-03 10:14:02.539280", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "cccccccc-0000-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2836), "2026-09-03 10:14:02.539284", new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 543, DateTimeKind.Utc).AddTicks(8017), "2026-09-03 10:14:02.543825", new DateTime(2026, 9, 3, 10, 14, 2, 543, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 543, DateTimeKind.Utc).AddTicks(9297), "2026-09-03 10:14:02.544061", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(1826), "2026-09-03 10:14:02.544307", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3544), "2026-09-03 10:14:02.544355", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3560), "2026-09-03 10:14:02.544356", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3575), "2026-09-03 10:14:02.544358", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3585), "2026-09-03 10:14:02.544358", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3593), "2026-09-03 10:14:02.544359", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3602), "2026-09-03 10:14:02.544360", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3611), "2026-09-03 10:14:02.544361", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000011",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3619), "2026-09-03 10:14:02.544362", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000012",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3628), "2026-09-03 10:14:02.544363", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000013",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3636), "2026-09-03 10:14:02.544364", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000014",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3647), "2026-09-03 10:14:02.544365", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000015",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3656), "2026-09-03 10:14:02.544366", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000016",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3664), "2026-09-03 10:14:02.544366", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000017",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3696), "2026-09-03 10:14:02.544370", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000018",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3714), "2026-09-03 10:14:02.544371", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000019",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3723), "2026-09-03 10:14:02.544372", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000020",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3731), "2026-09-03 10:14:02.544373", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000021",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3740), "2026-09-03 10:14:02.544374", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000022",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3750), "2026-09-03 10:14:02.544375", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000023",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3759), "2026-09-03 10:14:02.544376", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000024",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3768), "2026-09-03 10:14:02.544377", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000025",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3776), "2026-09-03 10:14:02.544378", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000026",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3784), "2026-09-03 10:14:02.544378", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000027",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3793), "2026-09-03 10:14:02.544379", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000028",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3801), "2026-09-03 10:14:02.544380", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000029",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3809), "2026-09-03 10:14:02.544381", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000030",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3820), "2026-09-03 10:14:02.544382", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000031",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3828), "2026-09-03 10:14:02.544383", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000032",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3836), "2026-09-03 10:14:02.544384", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000033",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3844), "2026-09-03 10:14:02.544384", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000034",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3852), "2026-09-03 10:14:02.544385", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000035",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3860), "2026-09-03 10:14:02.544386", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000036",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3868), "2026-09-03 10:14:02.544387", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000037",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3882), "2026-09-03 10:14:02.544388", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000038",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3892), "2026-09-03 10:14:02.544389", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000039",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3900), "2026-09-03 10:14:02.544390", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000040",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3908), "2026-09-03 10:14:02.544391", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000041",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3916), "2026-09-03 10:14:02.544392", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000042",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3924), "2026-09-03 10:14:02.544392", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000043",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3932), "2026-09-03 10:14:02.544393", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000044",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3940), "2026-09-03 10:14:02.544394", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000045",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3948), "2026-09-03 10:14:02.544395", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000046",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3959), "2026-09-03 10:14:02.544396", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33333333-3333-0000-0000-000000000047",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3967), "2026-09-03 10:14:02.544397", new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000001",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.541803" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000002",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.541928" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000003",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542085" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000004",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542160" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000005",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542162" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000006",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542163" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000007",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542164" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000008",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542165" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000009",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542165" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000010",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542166" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000011",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542167" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000012",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542168" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000013",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542169" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000014",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542169" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000015",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542171" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000016",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542172" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000017",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542173" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000018",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542174" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000019",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542175" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000020",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542175" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000021",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542176" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000022",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542177" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000023",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542178" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000024",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542179" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000025",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542179" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000026",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542180" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000027",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542181" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000028",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542182" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000029",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542183" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000030",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542184" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000031",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542184" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000032",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542185" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000033",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542186" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000034",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542187" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000035",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542187" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000036",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542188" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000037",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542189" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000038",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542190" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000039",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542191" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000040",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542191" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000041",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542192" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000042",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542193" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000043",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542194" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000044",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542194" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000045",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542195" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000046",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542196" });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "dddddddd-0000-0000-0000-000000000047",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.542197" });

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525374");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525497");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525498");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525498");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525499");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525499");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525499");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525499");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525500");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525500");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525500");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "88888888-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525501");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525286");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525311");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525311");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "77777777-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.525311");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(4118), "2026-09-03 10:14:02.529495", new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(6743), "2026-09-03 10:14:02.529786", new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "11111111-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(9003), "2026-09-03 10:14:02.530032", new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(1629), "2026-09-03 10:14:02.550191", new DateTime(2026, 9, 3, 14, 44, 2, 547, DateTimeKind.Local).AddTicks(443), new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(3871), "2026-09-03 10:14:02.550477", new DateTime(2026, 9, 3, 14, 44, 2, 550, DateTimeKind.Local).AddTicks(1934), new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(6210), "2026-09-03 10:14:02.550747", new DateTime(2026, 9, 3, 14, 44, 2, 550, DateTimeKind.Local).AddTicks(5112), new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(2686), new DateTime(2027, 3, 3, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), "2026-09-03 10:14:02.552317", new DateTime(2026, 8, 24, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(5121), new DateTime(2027, 4, 3, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), "2026-09-03 10:14:02.552618", new DateTime(2026, 8, 29, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(7673), new DateTime(2026, 12, 3, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), "2026-09-03 10:14:02.552903", new DateTime(2026, 8, 19, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "11111111-1111-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(9504), "2026-09-03 10:14:02.552951", new DateTime(2026, 8, 14, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 554, DateTimeKind.Utc).AddTicks(5184), "2026-09-03 10:14:02.554536", new DateTime(2026, 9, 3, 10, 14, 2, 554, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 554, DateTimeKind.Utc).AddTicks(8761), "2026-09-03 10:14:02.554964", new DateTime(2026, 9, 3, 10, 14, 2, 554, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(1374), "2026-09-03 10:14:02.555255", new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3047), "2026-09-03 10:14:02.555305", new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000005",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3077), "2026-09-03 10:14:02.555308", new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000006",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3091), "2026-09-03 10:14:02.555309", new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000007",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3103), "2026-09-03 10:14:02.555310", new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000008",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3116), "2026-09-03 10:14:02.555312", new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000009",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3128), "2026-09-03 10:14:02.555313", new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000010",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3141), "2026-09-03 10:14:02.555314", new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524326");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524390");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524390");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524391");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524392");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524392");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524392");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524392");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000001",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524728");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000002",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524770");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000003",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524771");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000004",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524771");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000005",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524772");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000006",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524772");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000007",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524772");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000008",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524772");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000009",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524775");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000010",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524775");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000011",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524777");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012",
                column: "LastModifiedUtc",
                value: "2026-09-03 10:14:02.524777");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000001",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531252" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000002",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531406" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000003",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531542" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000004",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531618" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000005",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531619" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000006",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531621" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000007",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531621" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000008",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531622" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000009",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531622" });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-0000-0000-0000-000000000010",
                columns: new[] { "EntityState", "LastModifiedUtc" },
                values: new object[] { "Added", "2026-09-03 10:14:02.531623" });
        }
    }
}
