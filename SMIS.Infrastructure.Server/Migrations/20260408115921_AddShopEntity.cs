using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddShopEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Shop");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77879582-8d70-4815-ace3-89efa7befc85", "AQAAAAIAAYagAAAAEHBLXIPeE2QPcvdmhRJ+TmAT4Z28BG5FWodknhEGbTH28FLercjXl/XHyIbBCtiMPg==", "f45dda8b-0c98-45b4-a4a4-3a0f7151b389" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3cbc0bd-7d5b-48c5-bd6a-93c0f09b2c0b", "AQAAAAIAAYagAAAAEF8vzs1/qD9mlzOaZIDNdDqnYPZZ7qgMCr4uHZ8hhWo2gO/qLcCRXlzqzXnEv2wXPw==", "2c86b67a-8e29-4415-a490-782ff0385d1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aae2a0d9-0004-4eb5-a4a1-64b5a960e9be", "AQAAAAIAAYagAAAAED4f94Pz4z0pQZ2bVArjlI5rtb2VbNIkbFFwm6frtnF1Awy7/aK9EPVSJpU3/mcuEw==", "7632fb84-b20a-4301-a203-f4d7af4ceec9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "531a91d5-99a1-4b75-aeb3-087876af4fce", "AQAAAAIAAYagAAAAEC/0MK18/eKcB1PLn24pS+YxKJXVr6FqIQ7UtKy5a0+BvMPW9bpGhurlDDovg/6QhA==", "ad9ef81f-a576-4556-9311-031c0ceb20da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52461afa-72b3-456d-9d0a-7d835f496074", "AQAAAAIAAYagAAAAEN3yHH+V3qgTmRwBXE56TVBq/bgyAxLF546wW6iAwuypv3I34U943ngi6j+SuCLm/g==", "14f49321-345c-414b-8c09-be2343de2a1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b012c34-ba10-4efc-bc50-c08ac0f6545c", "AQAAAAIAAYagAAAAELpgun0Z+egvsLOOQlVC+1Pdvt3DCYj8K1L0+IMPFtexSwz33RSmyMnSeWrG+o+1Ow==", "e221d61e-e7d2-4ab5-97d1-6e1fcda590f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec587729-29ad-4c29-8ac2-51be7995cf3a", "AQAAAAIAAYagAAAAELkmIIxHhio4F0CfflgnYpY8JRs0egKPs+1AHb3J6xpdFGSWbqkfZHHGEG2HQ7hB6g==", "0f942662-76b6-4f7f-8866-a2d95d8da3b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7890744-5fff-488a-a20c-1766411a01c1", "AQAAAAIAAYagAAAAEDdqN4jOcO79kVNNOyv45/gsbEH0rMPji6dn3FnD3SogXk+JvtaOlF5a8j1X3/+Maw==", "b028a149-9cba-44b6-a8d9-529d08924abe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d2c5c97-be49-4b13-b872-02b713eeee21", "AQAAAAIAAYagAAAAEC4X92L0uh1AzhO97uFPttrT3yRJUvbr1MHkBGnVWBcYeWhsFjN5IWUm9mxhy7MupQ==", "c9383ee3-0932-4695-b9c8-e2543ff4e6c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "269c5fdb-9fb6-4657-9fd0-e3a4d07643b2", "AQAAAAIAAYagAAAAEEPrcW7YqhAZMoasXZToewGRLPYZR90CkvnGTbzjnJ+rWTZPLqfD/xpAeoPsyPsfCA==", "876cf1a8-a758-4dd6-9d57-64322c8a5150" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3acdc5a7-927b-44d3-9f13-aa344cc9ccd5", "AQAAAAIAAYagAAAAENas9x/ut89uDL68j95/fIg5M7h7iPaf1A6QzgGYXu60C8p+X6vQQaoBGBerED2vgg==", "59dfb13f-27db-4a92-a018-2f0121b15d29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08274940-2ebd-4da3-9fbb-3844a69e3ca4", "AQAAAAIAAYagAAAAEJpDu2ptklS0K4Vh7kso5h0yQq6svC/nRNv+Io6OLWmQEBJg1vAypVYzrEVjrBG9AA==", "86bc57ba-14c5-4736-92f7-526f57e25079" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "425951a3-c9b0-4257-886b-b6f0ca25ed67", "AQAAAAIAAYagAAAAEA4luGFF5MLnmhepV4UBbrNVgPopiNO+iBknT4ma8LDuMHcZtJ8sbQtpURKUbrFsLg==", "7a48abf8-899b-4845-bea3-94da03fdfd0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42305a14-cb3a-41cc-b911-ecc2815da03d", "AQAAAAIAAYagAAAAELFqp672WiFs70S69ynEzOAaaFBztfN1B0G/FKVrPKHtpjBEZOE9vqwvN3W9vHsFKA==", "6d2b26bb-e837-45a0-956c-8e1d84865ae6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c991dbe7-3894-49a5-a80f-a7d3f94c8d63", "AQAAAAIAAYagAAAAEAOo8W6jYi54r4Uf34bonyXer9MO0SMXzgmTBO/ea2Y23ZXFr4HA02ywbChy9DTahg==", "568a0de5-0d43-4875-b559-48feac1c1663" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4682), "2026-04-08 16:29:20.394469", new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4714), "2026-04-08 16:29:20.394471", new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4719), "2026-04-08 16:29:20.394472", new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4724), "2026-04-08 16:29:20.394472", new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4727), "2026-04-08 16:29:20.394472", new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4731), "2026-04-08 16:29:20.394473", new DateTime(2026, 4, 8, 16, 29, 20, 394, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 395, DateTimeKind.Local).AddTicks(5382), "2026-04-08 16:29:20.395559", new DateTime(2026, 4, 8, 16, 29, 20, 395, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(539), "2026-04-08 16:29:20.396054", new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 395, DateTimeKind.Local).AddTicks(7034), "2026-04-08 16:29:20.395777", new DateTime(2026, 4, 8, 16, 29, 20, 395, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 395, DateTimeKind.Local).AddTicks(9109), "2026-04-08 16:29:20.396006", new DateTime(2026, 4, 8, 16, 29, 20, 395, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(454), "2026-04-08 16:29:20.396046", new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(471), "2026-04-08 16:29:20.396047", new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(486), "2026-04-08 16:29:20.396049", new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(499), "2026-04-08 16:29:20.396050", new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(513), "2026-04-08 16:29:20.396051", new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(525), "2026-04-08 16:29:20.396052", new DateTime(2026, 4, 8, 16, 29, 20, 396, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.384508");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.384532");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.384533");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.382657");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.382708");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.382708");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 696, DateTimeKind.Local).AddTicks(7241), new DateTime(2026, 5, 8, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), "2026-04-08 16:29:19.696738", new DateTime(2026, 3, 9, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 696, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3419), new DateTime(2026, 5, 5, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), "2026-04-08 16:29:19.697342", new DateTime(2026, 4, 5, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 696, DateTimeKind.Local).AddTicks(9456), new DateTime(2026, 4, 23, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), "2026-04-08 16:29:19.697011", new DateTime(2026, 3, 24, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 696, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(2236), new DateTime(2026, 4, 28, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), "2026-04-08 16:29:19.697299", new DateTime(2026, 3, 29, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3305), new DateTime(2026, 5, 23, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), "2026-04-08 16:29:19.697331", new DateTime(2026, 4, 3, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3326), new DateTime(2026, 4, 18, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), "2026-04-08 16:29:19.697333", new DateTime(2026, 3, 19, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3342), new DateTime(2026, 4, 26, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), "2026-04-08 16:29:19.697334", new DateTime(2026, 3, 27, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3367), "2026-04-08 16:29:19.697337", new DateTime(2026, 3, 14, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3388), new DateTime(2026, 4, 20, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), "2026-04-08 16:29:19.697339", new DateTime(2026, 3, 21, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3404), new DateTime(2026, 4, 30, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), "2026-04-08 16:29:19.697340", new DateTime(2026, 3, 31, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(6220), new DateTime(2026, 4, 8, 16, 29, 19, 697, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(835), "2026-04-08 16:29:20.393102", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7009), "2026-04-08 16:29:20.393701", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7021), "2026-04-08 16:29:20.393703", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7042), "2026-04-08 16:29:20.393704", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7057), "2026-04-08 16:29:20.393706", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7069), "2026-04-08 16:29:20.393707", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7079), "2026-04-08 16:29:20.393708", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7090), "2026-04-08 16:29:20.393709", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(3036), "2026-04-08 16:29:20.393381", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(5348), "2026-04-08 16:29:20.393649", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6913), "2026-04-08 16:29:20.393692", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6931), "2026-04-08 16:29:20.393693", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6943), "2026-04-08 16:29:20.393694", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6964), "2026-04-08 16:29:20.393696", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6976), "2026-04-08 16:29:20.393698", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6988), "2026-04-08 16:29:20.393699", new DateTime(2026, 4, 8, 16, 29, 20, 393, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(2813), "2026-04-08 16:29:19.683326", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7116), "2026-04-08 16:29:19.683711", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7125), "2026-04-08 16:29:19.683712", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7135), "2026-04-08 16:29:19.683713", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7144), "2026-04-08 16:29:19.683714", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7156), "2026-04-08 16:29:19.683715", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7166), "2026-04-08 16:29:19.683716", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7176), "2026-04-08 16:29:19.683717", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7185), "2026-04-08 16:29:19.683718", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7195), "2026-04-08 16:29:19.683719", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7206), "2026-04-08 16:29:19.683720", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(4136), "2026-04-08 16:29:19.683491", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7215), "2026-04-08 16:29:19.683721", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7234), "2026-04-08 16:29:19.683723", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7246), "2026-04-08 16:29:19.683725", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7266), "2026-04-08 16:29:19.683727", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7276), "2026-04-08 16:29:19.683728", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7286), "2026-04-08 16:29:19.683729", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7297), "2026-04-08 16:29:19.683730", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7307), "2026-04-08 16:29:19.683731", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7316), "2026-04-08 16:29:19.683732", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7327), "2026-04-08 16:29:19.683733", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(5673), "2026-04-08 16:29:19.683667", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7338), "2026-04-08 16:29:19.683734", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7348), "2026-04-08 16:29:19.683735", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7358), "2026-04-08 16:29:19.683736", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7368), "2026-04-08 16:29:19.683737", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7378), "2026-04-08 16:29:19.683738", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7387), "2026-04-08 16:29:19.683739", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7397), "2026-04-08 16:29:19.683740", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7407), "2026-04-08 16:29:19.683741", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7419), "2026-04-08 16:29:19.683742", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7428), "2026-04-08 16:29:19.683743", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7045), "2026-04-08 16:29:19.683705", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7445), "2026-04-08 16:29:19.683744", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7455), "2026-04-08 16:29:19.683745", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7464), "2026-04-08 16:29:19.683746", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7474), "2026-04-08 16:29:19.683747", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7483), "2026-04-08 16:29:19.683748", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7493), "2026-04-08 16:29:19.683749", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7504), "2026-04-08 16:29:19.683750", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7513), "2026-04-08 16:29:19.683751", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7060), "2026-04-08 16:29:19.683706", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7075), "2026-04-08 16:29:19.683707", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7086), "2026-04-08 16:29:19.683709", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7096), "2026-04-08 16:29:19.683709", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7106), "2026-04-08 16:29:19.683710", new DateTime(2026, 4, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.680062");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681550");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681551");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681551");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681552");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681553");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681553");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681554");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681555");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681555");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681556");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681390");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681556");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681558");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681559");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681559");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681560");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681561");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681561");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681562");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681562");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681563");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681487");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681564");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681564");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681565");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681565");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681566");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681567");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681567");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681568");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681568");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681569");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681545");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681570");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681570");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681571");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681571");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681572");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681573");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681573");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681574");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681547");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681548");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681548");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681549");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:19.681550");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384307");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384361");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384361");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384361");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384358");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384359");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384359");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384360");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384360");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384360");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384360");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-04-08 11:59:20.384361");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.384223");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.384244");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.384244");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.384244");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 389, DateTimeKind.Local).AddTicks(8135), "2026-04-08 16:29:20.389836", new DateTime(2026, 4, 8, 16, 29, 20, 389, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 389, DateTimeKind.Local).AddTicks(9669), "2026-04-08 16:29:20.390055", new DateTime(2026, 4, 8, 16, 29, 20, 390, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 20, 390, DateTimeKind.Local).AddTicks(1419), "2026-04-08 16:29:20.390244", new DateTime(2026, 4, 8, 16, 29, 20, 390, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 694, DateTimeKind.Local).AddTicks(7808), "2026-04-08 16:29:19.694797", new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(4340), new DateTime(2026, 4, 8, 16, 29, 19, 694, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 694, DateTimeKind.Local).AddTicks(9133), "2026-04-08 16:29:19.694978", new DateTime(2026, 4, 8, 16, 29, 19, 694, DateTimeKind.Local).AddTicks(7987), new DateTime(2026, 4, 8, 16, 29, 19, 694, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(983), "2026-04-08 16:29:19.695186", new DateTime(2026, 4, 8, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(154), new DateTime(2026, 4, 8, 16, 29, 19, 695, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 684, DateTimeKind.Local).AddTicks(8163), new DateTime(2026, 10, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(9725), "2026-04-08 16:29:19.684854", new DateTime(2026, 3, 29, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(9725), new DateTime(2026, 4, 8, 16, 29, 19, 684, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 685, DateTimeKind.Local).AddTicks(404), new DateTime(2026, 11, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(9725), "2026-04-08 16:29:19.685116", new DateTime(2026, 4, 3, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(9725), new DateTime(2026, 4, 8, 16, 29, 19, 685, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 685, DateTimeKind.Local).AddTicks(2419), new DateTime(2026, 7, 8, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(9725), "2026-04-08 16:29:19.685330", new DateTime(2026, 3, 24, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(9725), new DateTime(2026, 4, 8, 16, 29, 19, 685, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 685, DateTimeKind.Local).AddTicks(3642), "2026-04-08 16:29:19.685364", new DateTime(2026, 3, 19, 16, 29, 19, 683, DateTimeKind.Local).AddTicks(9725), new DateTime(2026, 4, 8, 16, 29, 19, 685, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 686, DateTimeKind.Local).AddTicks(5242), "2026-04-08 16:29:19.686537", new DateTime(2026, 4, 8, 16, 29, 19, 686, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(263), "2026-04-08 16:29:19.687026", new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 686, DateTimeKind.Local).AddTicks(6822), "2026-04-08 16:29:19.686740", new DateTime(2026, 4, 8, 16, 29, 19, 686, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 686, DateTimeKind.Local).AddTicks(8678), "2026-04-08 16:29:19.686975", new DateTime(2026, 4, 8, 16, 29, 19, 686, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(179), "2026-04-08 16:29:19.687018", new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(199), "2026-04-08 16:29:19.687020", new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(212), "2026-04-08 16:29:19.687021", new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(224), "2026-04-08 16:29:19.687022", new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(238), "2026-04-08 16:29:19.687024", new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(250), "2026-04-08 16:29:19.687025", new DateTime(2026, 4, 8, 16, 29, 19, 687, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.382965");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383007");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383007");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383007");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383007");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383008");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383008");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383008");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383508");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383693");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383697");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383697");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383688");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383691");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383692");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383693");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383693");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383693");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383693");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.383693");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.385439");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.386206");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.385708");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.386123");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.386200");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.386201");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.386203");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.386204");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.386204");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-04-08 16:29:20.386205");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Shop",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Shop",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2f96aca-a5d3-44e0-a60d-70ec6fb51766", "AQAAAAIAAYagAAAAEJxrww3uo6WeFp1beujHbndNgC1k3l/WxzgcAkJddHbYseGcgl56WSOUgtxwnlttbw==", "00af08a2-4c91-44b5-8e39-2b522c5be95f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e72084b-3705-4b01-ad8d-c471d4a4626f", "AQAAAAIAAYagAAAAEHgREkka47OlGAzCZwPd+kIdbn5ZAxHHlGxmGvOo2HopNlekPUvXEemDetv6WMBMSg==", "ec425537-dbe2-4ac8-b01b-723f793b03a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc62cca0-0e08-492a-a726-e603dc6f6e55", "AQAAAAIAAYagAAAAEOSeEi09GZRYH8oFjpensQxjFNxtDHHsBV+wjweoOZsTQBKte8vakW2J/VAbyzuT8g==", "0f6bb9e9-161c-401b-a682-63f17b410036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa99ff41-2f50-40f9-a915-b73bc69e4bc8", "AQAAAAIAAYagAAAAEN643g9ldl6oj9+s2fu48J8PAdBsNHJjtZBB1dzehlxZ3s48lIQaJaeiPh5fSkDHIQ==", "cd8c4da0-d00b-4337-b58e-71d2c507dd34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40e5643c-05a4-477c-937c-4869fb855412", "AQAAAAIAAYagAAAAECaGMpE4j5gF4tr0xT0Xi06iXq/zPBYx37E+XRewVS1EcXpZESz1cso6qdWGtGRSWA==", "b1255c6e-e4b2-4776-9364-4c528ee506df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "444a9936-7100-4f97-a32d-5fd71ca7eca8", "AQAAAAIAAYagAAAAEF/kWn31rq+1fZc8XU+QcB+LuxbAKVdE7eHTAGCPyZQWQvmA6kEpe/DTu16cfxpa7g==", "32a5bb0c-65fb-4b76-9ccd-923d1f31dde9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2f44088-4211-4694-94d4-12f5bcb23095", "AQAAAAIAAYagAAAAEOhZno/ysrzxS6Cjn3l3/V/pnezxXOV+GRTjaHXPdm89bFA1SlEUiloEd9Hdsh8LQA==", "f3201b37-0227-414c-90ac-44cf371cac04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "809851df-34cd-48b4-924b-8628cfcd8c9d", "AQAAAAIAAYagAAAAEND+sN1rEgGP1HG8oM7iYfdAQTl6Bh6jnJAtMohfS6ZoULrX12nSZvdD8W5zPrvZ+Q==", "eba2262f-acc6-47cd-a44d-9acf72ec95be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95f69270-4107-43fc-9910-b8d2b369b090", "AQAAAAIAAYagAAAAEH9NAAra0XEuK73mzfg/6J1/EUQuQV/H/9wO9RycP/Dj0GOEDDXmvIpCl+N7iVTELA==", "6c522cd3-06bb-4b2f-88cf-8a91724c60a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a9c64e1-294f-410a-9b0d-a591d7f5857f", "AQAAAAIAAYagAAAAEKl26XdtqrUV+XeGmAZXiiAH2edubZr+1J0h74R6oQdDP7zbc1joSjXDAAVgFokwHA==", "3e53e39b-c427-4950-9db7-2963db902ebb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbbb3a9a-953e-4b06-be83-bb577a533c9b", "AQAAAAIAAYagAAAAEPNwyhYnh6I6ZSg2Q+SfA5HRxp/s3gkIcEP99Jb5GzDJJiNoubTwUhE/PFBL/da9SA==", "7bc6fc56-b6a4-4320-84a4-ce476c0d7389" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62e07292-6015-4fad-8dd0-46a3661f7620", "AQAAAAIAAYagAAAAEJSxAP0TUGWYVwIdrvA/Kzc+8+tMZq0/JvWfZnTQd8wT6kf/V2N64peoODaSKB/mNA==", "3e844f80-08f0-483c-9a66-1a168267749b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b7b6655-2690-4e53-af83-facc3ed06bf5", "AQAAAAIAAYagAAAAEPlm54bGpuhqXgsWu9GubLjcFLQb/guJoLQ2ClFuayaiAz5v+rdPEHlLEZaYCLSs/A==", "a6883dc9-666f-4805-b8ac-39cee9f4e9e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f78e9029-18c8-4e68-a4e1-2285d0583f4f", "AQAAAAIAAYagAAAAEF63Hun2ri1zX8gBT1fQyWN4QiAZygjRO3TPlPPONzaeDXFhlBxcBNjmybcdv62t2w==", "ba1fd03d-0ac2-488e-9455-08551d9f7d9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c47d608c-affc-497c-b4a2-f779e9b4f9bb", "AQAAAAIAAYagAAAAEK73tP/t9GHf1RoMiX3YZaOhius3l7XTGASMkX4gjaXpN2KtRsvvJGMA1kb39rhqrA==", "4c4b3d18-4ca8-431c-866d-8cc423b07b97" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5251), "2026-03-28 13:27:00.540525", new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5267), "2026-03-28 13:27:00.540526", new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5270), "2026-03-28 13:27:00.540527", new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5273), "2026-03-28 13:27:00.540527", new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5307), "2026-03-28 13:27:00.540530", new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5310), "2026-03-28 13:27:00.540531", new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(3987), "2026-03-28 13:27:00.541412", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8339), "2026-03-28 13:27:00.541834", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(5184), "2026-03-28 13:27:00.541586", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(7116), "2026-03-28 13:27:00.541790", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8225), "2026-03-28 13:27:00.541823", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8240), "2026-03-28 13:27:00.541824", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8252), "2026-03-28 13:27:00.541825", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8262), "2026-03-28 13:27:00.541826", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8314), "2026-03-28 13:27:00.541831", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8328), "2026-03-28 13:27:00.541833", new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533920");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533945");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533945");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532252");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532289");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532289");

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 950, DateTimeKind.Utc).AddTicks(2448), new DateTime(2026, 4, 27, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "2026-03-28 13:26:59.950259", new DateTime(2026, 2, 26, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 950, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3541), new DateTime(2026, 4, 24, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "2026-03-28 13:26:59.951354", new DateTime(2026, 3, 25, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 950, DateTimeKind.Utc).AddTicks(5286), new DateTime(2026, 4, 12, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "2026-03-28 13:26:59.950634", new DateTime(2026, 3, 13, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 950, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(768), new DateTime(2026, 4, 17, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "2026-03-28 13:26:59.951283", new DateTime(2026, 3, 18, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3442), new DateTime(2026, 5, 12, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "2026-03-28 13:26:59.951345", new DateTime(2026, 3, 23, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3475), new DateTime(2026, 4, 7, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "2026-03-28 13:26:59.951347", new DateTime(2026, 3, 8, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3488), new DateTime(2026, 4, 15, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "2026-03-28 13:26:59.951349", new DateTime(2026, 3, 16, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3502), "2026-03-28 13:26:59.951350", new DateTime(2026, 3, 3, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3515), new DateTime(2026, 4, 9, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "2026-03-28 13:26:59.951351", new DateTime(2026, 3, 10, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3528), new DateTime(2026, 4, 19, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "2026-03-28 13:26:59.951353", new DateTime(2026, 3, 20, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(3489), "2026-03-28 13:27:00.539364", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9128), "2026-03-28 13:27:00.539913", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9144), "2026-03-28 13:27:00.539914", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9153), "2026-03-28 13:27:00.539916", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9166), "2026-03-28 13:27:00.539917", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9176), "2026-03-28 13:27:00.539917", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9187), "2026-03-28 13:27:00.539918", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9196), "2026-03-28 13:27:00.539919", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(5454), "2026-03-28 13:27:00.539634", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(7735), "2026-03-28 13:27:00.539867", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(8992), "2026-03-28 13:27:00.539899", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9034), "2026-03-28 13:27:00.539903", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9045), "2026-03-28 13:27:00.539908", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9095), "2026-03-28 13:27:00.539909", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9105), "2026-03-28 13:27:00.539910", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9115), "2026-03-28 13:27:00.539912", new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 935, DateTimeKind.Utc).AddTicks(8392), "2026-03-28 13:26:59.935880", new DateTime(2026, 3, 28, 13, 26, 59, 935, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2517), "2026-03-28 13:26:59.936251", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2525), "2026-03-28 13:26:59.936252", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2532), "2026-03-28 13:26:59.936253", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2539), "2026-03-28 13:26:59.936254", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2548), "2026-03-28 13:26:59.936255", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2555), "2026-03-28 13:26:59.936255", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2563), "2026-03-28 13:26:59.936256", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2570), "2026-03-28 13:26:59.936257", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2598), "2026-03-28 13:26:59.936260", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2637), "2026-03-28 13:26:59.936264", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 935, DateTimeKind.Utc).AddTicks(9619), "2026-03-28 13:26:59.936041", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2645), "2026-03-28 13:26:59.936264", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2652), "2026-03-28 13:26:59.936265", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2661), "2026-03-28 13:26:59.936266", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2668), "2026-03-28 13:26:59.936267", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2676), "2026-03-28 13:26:59.936267", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2683), "2026-03-28 13:26:59.936268", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2691), "2026-03-28 13:26:59.936269", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2698), "2026-03-28 13:26:59.936270", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2706), "2026-03-28 13:26:59.936270", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2713), "2026-03-28 13:26:59.936271", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(1096), "2026-03-28 13:26:59.936213", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2723), "2026-03-28 13:26:59.936272", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2730), "2026-03-28 13:26:59.936273", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2737), "2026-03-28 13:26:59.936274", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2745), "2026-03-28 13:26:59.936274", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2752), "2026-03-28 13:26:59.936275", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2759), "2026-03-28 13:26:59.936276", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2767), "2026-03-28 13:26:59.936277", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2774), "2026-03-28 13:26:59.936279", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2805), "2026-03-28 13:26:59.936280", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2813), "2026-03-28 13:26:59.936281", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2461), "2026-03-28 13:26:59.936246", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2820), "2026-03-28 13:26:59.936282", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2827), "2026-03-28 13:26:59.936283", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2835), "2026-03-28 13:26:59.936283", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2842), "2026-03-28 13:26:59.936284", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2849), "2026-03-28 13:26:59.936285", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2857), "2026-03-28 13:26:59.936286", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2865), "2026-03-28 13:26:59.936286", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2873), "2026-03-28 13:26:59.936287", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2475), "2026-03-28 13:26:59.936247", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2487), "2026-03-28 13:26:59.936249", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2494), "2026-03-28 13:26:59.936249", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2502), "2026-03-28 13:26:59.936250", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2509), "2026-03-28 13:26:59.936251", new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.933833");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934282");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934282");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934283");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934284");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934284");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934285");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934285");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934296");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934297");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934297");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934041");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934298");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934299");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934299");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934300");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934300");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934301");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934301");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934302");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934302");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934303");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934166");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934303");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934304");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934304");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934305");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934305");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934306");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934306");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934307");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934308");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934308");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934277");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934309");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934309");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934310");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934310");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934310");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934311");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934312");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934312");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934279");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934279");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934280");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934281");

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:26:59.934281");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533625");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533739");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533740");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533740");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533729");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533737");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533738");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533738");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533738");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533738");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533739");

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533739");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533439");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533466");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533466");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.533467");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(4064), true, "2026-03-28 13:27:00.536420", null, new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(4956), true, "2026-03-28 13:27:00.536575", null, new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(6572), true, "2026-03-28 13:27:00.536804", null, new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(3781), "2026-03-28 13:26:59.947392", new DateTime(2026, 3, 28, 17, 56, 59, 940, DateTimeKind.Local).AddTicks(7956), new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(5283), "2026-03-28 13:26:59.947590", new DateTime(2026, 3, 28, 17, 56, 59, 947, DateTimeKind.Local).AddTicks(3940), new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(6884), "2026-03-28 13:26:59.947821", new DateTime(2026, 3, 28, 17, 56, 59, 947, DateTimeKind.Local).AddTicks(6120), new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(635), new DateTime(2026, 9, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), "2026-03-28 13:26:59.938102", new DateTime(2026, 3, 18, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(2605), new DateTime(2026, 10, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), "2026-03-28 13:26:59.938353", new DateTime(2026, 3, 23, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(4757), new DateTime(2026, 6, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), "2026-03-28 13:26:59.938558", new DateTime(2026, 3, 13, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(5916), "2026-03-28 13:26:59.938592", new DateTime(2026, 3, 8, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 939, DateTimeKind.Utc).AddTicks(9686), "2026-03-28 13:26:59.939980", new DateTime(2026, 3, 28, 13, 26, 59, 939, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4287), "2026-03-28 13:26:59.940429", new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(1123), "2026-03-28 13:26:59.940171", new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(2825), "2026-03-28 13:26:59.940388", new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4217), "2026-03-28 13:26:59.940422", new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4236), "2026-03-28 13:26:59.940423", new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4247), "2026-03-28 13:26:59.940424", new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4257), "2026-03-28 13:26:59.940425", new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4268), "2026-03-28 13:26:59.940427", new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4278), "2026-03-28 13:26:59.940428", new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532547");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532589");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532589");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532589");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532589");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532590");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532590");

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532590");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532882");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532917");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532917");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532917");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532916");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532916");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532916");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532916");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532917");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532917");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532917");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.532917");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534622");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534916");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534735");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534858");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534913");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534913");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534913");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534915");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534915");

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: "2026-03-28 13:27:00.534915");
        }
    }
}
