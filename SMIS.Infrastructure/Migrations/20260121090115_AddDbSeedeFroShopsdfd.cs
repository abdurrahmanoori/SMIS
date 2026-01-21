using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDbSeedeFroShopsdfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TranslationKeys_MessageCode",
                table: "TranslationKeys");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2ae8189-c5b6-4ac3-aec5-8e31fd23bad3", "AQAAAAIAAYagAAAAEA7dvSyo+IJdYQ2H/3uaTWlb2lBfi2atkasFofnzE32AYmrQSOOeCDrmvjsnrh1K+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dfc8f85d-5431-45f0-861d-403e565a5873", "AQAAAAIAAYagAAAAEBLjtzNNTzhMiONQiQshpAP5rddRmGiCoR7/7WexkjlVBnT7rplwVleR/YleM2cibg==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(1282), new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(1389), new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(1391), new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(9289), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(9292), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(9293), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(9294), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(3843), new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(4373), new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(4375), new DateTime(2026, 1, 21, 13, 31, 15, 434, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 432, DateTimeKind.Local).AddTicks(5061), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(3076), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(3079), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(3080), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(3082), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(5803), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6034), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6035), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6036), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6037), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6039), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6040), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6024), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6025), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6027), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6028), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6029), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6030), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6031), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6032), new DateTime(2026, 1, 21, 13, 31, 15, 433, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.CreateIndex(
                name: "IX_TranslationKeys_MessageCode",
                table: "TranslationKeys",
                column: "MessageCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TranslationKeys_MessageCode",
                table: "TranslationKeys");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff160773-1fcb-48cf-95f0-511ab24006e1", "AQAAAAIAAYagAAAAEH6sG+IZyusHMvVr9zrMDZdL7fgki8JtH61TXzzKPzZxjzaiHfAjgm9Z1O7kOnX1QQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2016792-2b14-47d8-a27d-c8f3496ae04d", "AQAAAAIAAYagAAAAEKuO+vsBoFvJaXjtkZFZTJCBtRCnb83zrZ3JRzhW0B0gb2xc0QRH1T1umWbuZRpFlA==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(2044), new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(2165), new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(2167), new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(9796), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(9801), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(9802), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(9804), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(4750), new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(5270), new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(5273), new DateTime(2026, 1, 21, 13, 29, 30, 676, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 673, DateTimeKind.Local).AddTicks(7080), new DateTime(2026, 1, 21, 13, 29, 30, 674, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(621), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(626), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(627), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(629), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4517), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4797), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4799), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4800), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4801), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4802), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4803), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4766), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4768), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4769), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4770), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4772), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4773), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4774), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4796), new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.CreateIndex(
                name: "IX_TranslationKeys_MessageCode",
                table: "TranslationKeys",
                column: "MessageCode",
                unique: true);
        }
    }
}
