using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class categoryAddedgfg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7042daa-e5f9-48e2-87d1-c4ad780384d5", "AQAAAAIAAYagAAAAEA6hT5HyzmsH7KR5klvTOPEKtHxjGhrYfdCHhEDyc6kmMQT3m+NO7JeITIut/ihmGQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5d12fcf-5004-4bfe-bec2-e5340155ed80", "AQAAAAIAAYagAAAAEBZC+/lcir2cJ9x02ajE/dHhl12tKJhL/o54qpohvZ99oj73pFHmkoL31G9r5t+ppg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(6976), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(8071), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(8076), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(385), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(710), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(715), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(1786), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(4038), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(4046), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5264), new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5273), new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5275), new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5277), new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(6751), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(8289), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(8295), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 335, DateTimeKind.Local).AddTicks(7280), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1937), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1943), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1945), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1954), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7148), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7817), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7825), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7827), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7829), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7830), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7832), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7800), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7805), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7807), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7809), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7811), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7812), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7814), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7815), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7816) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51781b24-7357-4983-90aa-d28e3f88c205", "AQAAAAIAAYagAAAAEJ7BB1oQ6+RDdFTL7YCj71hMt9Ue2usjfoJfPhI+y6VzmqX3o2mRvGV5zewvsY78Fg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57609190-020f-4cee-896d-44736b2c17e7", "AQAAAAIAAYagAAAAEDJCiC6Y4J+73cvDiC/JVDDjGgNSlE+i4GVIfAl/FVsAkNts4/4jwN8acC31qz68Fg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(3234), new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(4960), new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(4966), new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(8948), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(9471), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(9477), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(5177), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(8809), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(8817), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1550), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1572), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1574), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1577), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 258, DateTimeKind.Local).AddTicks(8281), new DateTime(2026, 1, 21, 20, 52, 34, 258, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(670), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(678), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 253, DateTimeKind.Local).AddTicks(2322), new DateTime(2026, 1, 21, 20, 52, 34, 254, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(316), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(323), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(325), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(327), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(8695), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9771), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9773), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9775), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9778), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9780), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9782), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9749), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9755), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9757), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9760), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9762), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9764), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9767), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9769), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9769) });
        }
    }
}
