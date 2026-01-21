using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDbSeedeFroShopsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MessageCode",
                table: "TranslationKeys",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 673, DateTimeKind.Local).AddTicks(7080), "1001", new DateTime(2026, 1, 21, 13, 29, 30, 674, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(621), "1002", new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(626), "1003", new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(627), "2001", new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(629), "2002", new DateTime(2026, 1, 21, 13, 29, 30, 675, DateTimeKind.Local).AddTicks(630) });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MessageCode",
                table: "TranslationKeys",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86282817-376a-42ad-947f-1611e67b264d", "AQAAAAIAAYagAAAAEIgY7+DydSdK9UAE5UIE/0iSHfxl+IDcQ1cCHMdIpqYh+TrzHIoRjZlWRzRroeJoiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a502a25-569e-44f3-9988-6f986e9db6fd", "AQAAAAIAAYagAAAAEN2GGpwqvwq8oR6eAi8InNPQQkKofWMALVKF8uXLZ88BmaIgoEf9RGfjGOSEubnoMA==" });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(3970), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(4113), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(4114), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1541), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1545), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1546), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1548), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(7539), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(8264), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(8268), new DateTime(2026, 1, 21, 12, 38, 36, 970, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 968, DateTimeKind.Local).AddTicks(6936), 1001, new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4807), 1002, new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4810), 1003, new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4812), 2001, new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "MessageCode", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4813), 2002, new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7685), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7936), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7938), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7939), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7940), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7941), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7942), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7926), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7928), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7929), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7931), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7932), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7933), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7934), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "PublicId",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7935), new DateTime(2026, 1, 21, 12, 38, 36, 969, DateTimeKind.Local).AddTicks(7936) });
        }
    }
}
