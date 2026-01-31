using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigrgfkj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "StockBatch",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitName",
                table: "StockBatch",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79a76cc8-43e2-42e1-a570-b72332c30531", "AQAAAAIAAYagAAAAELlCCnXfkCcPrqeDYo7PwOIFz/pCClYSn0dsSMh5TlA6s9D4ycwQx9A7XGR4NFy01Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5027f1e1-08d9-459f-b3e8-ab9f3a5b2b39", "AQAAAAIAAYagAAAAEL1uwYncZKGQ+tHIlDApQEECOkmI84MR4YqsY2JNFNg1bINb51ILvEyeHzRRxpi2pA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(3750), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(3758), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4059), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4065), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4068), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4069), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4073), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4078), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(4081), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1090), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1198), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(1202), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1203), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(1206), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(778), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(5768), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 798, DateTimeKind.Unspecified).AddTicks(5781), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1580), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1589), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1597), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1600), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1605), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1613), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1616), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1620), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1625), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1630), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 799, DateTimeKind.Local).AddTicks(9216), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 799, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 799, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(521), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(535), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1505), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1512), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1531), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1541), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1550), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1557), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1563), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1571), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 800, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 800, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1389), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1916), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1919), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1926), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1930), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1955), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1958), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1961), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1964), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1969), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1975), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1978), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1981), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1873), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1985), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1988), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1877), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1887), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 788, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(202), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(207), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(210), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(177), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(188), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(191), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(195), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9360), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9367), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9370), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9383), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9384), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9388), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(9391), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(5623), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 791, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(222), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 798, DateTimeKind.Unspecified).AddTicks(262), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(931), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 798, DateTimeKind.Unspecified).AddTicks(939), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 798, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 788, DateTimeKind.Local).AddTicks(6076), new DateTime(2026, 7, 31, 5, 58, 45, 788, DateTimeKind.Utc).AddTicks(3982), null, new DateTime(2026, 1, 21, 5, 58, 45, 788, DateTimeKind.Utc).AddTicks(3940), null, new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(7286), new DateTime(2026, 8, 31, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(7252), null, new DateTime(2026, 1, 26, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(7251), null, new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(8259), new DateTime(2026, 4, 30, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(8229), null, new DateTime(2026, 1, 16, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(8228), null, new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ProductName", "ReceivedDate", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(8757), null, new DateTime(2026, 1, 11, 5, 58, 45, 789, DateTimeKind.Utc).AddTicks(8751), null, new DateTime(2026, 1, 31, 10, 28, 45, 789, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3044), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3724), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3730), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3738), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3739), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3744), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3747), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3748), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3751), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3752), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3756), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6047), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6061), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6293), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6297), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6301), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6302), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6305), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6255), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6262), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6268), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6269), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6273), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6273), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6276), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6277), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6281), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6285), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6289), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 790, DateTimeKind.Unspecified).AddTicks(6292), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 28, 45, 790, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3158), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3433), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3443), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3447), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3450), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3454), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3457), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 58, 45, 791, DateTimeKind.Unspecified).AddTicks(3460), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "StockBatch");

            migrationBuilder.DropColumn(
                name: "UnitName",
                table: "StockBatch");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91857dc4-2cab-4939-b5e2-10f00f730bb0", "AQAAAAIAAYagAAAAEIxElwjIznNUtmPZaG3mo81s9Zc9X/wBxZCeDmuz/jAhq57LMLAdKCCJuNFhAF8PyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5944d536-1a89-41d7-afbb-3f88da590b39", "AQAAAAIAAYagAAAAEI06ggjfoAjBuCP7gU6B0LlOiBdvhjqLvUf22T/z3zgIl8miCD4RNAgHIuI/isAJ1w==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8488), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8510), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8833), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8839), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8842), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8843), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8847), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8850), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8851), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(8855), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(400), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(409), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(504), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(509), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(510), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 504, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 504, DateTimeKind.Unspecified).AddTicks(5518), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 504, DateTimeKind.Unspecified).AddTicks(5522), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 513, DateTimeKind.Local).AddTicks(1584), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 513, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 513, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6322), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6330), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6333), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6338), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6341), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6346), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6353), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6361), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6363), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6368), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(4254), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(5333), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6237), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6247), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6277), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6286), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6294), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6298), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6303), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6311), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 514, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 514, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5197), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5714), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5723), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5734), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5740), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5743), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5648), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5749), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5756), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5759), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5768), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5771), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5774), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5777), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5655), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5707), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 502, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8973), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9406), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9410), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9414), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9378), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9382), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9399), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(9403), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8385), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8396), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8401), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8404), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8404), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(8407), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(4640), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(4646), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 506, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 512, DateTimeKind.Local).AddTicks(6392), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 512, DateTimeKind.Unspecified).AddTicks(6414), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 512, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 512, DateTimeKind.Local).AddTicks(7027), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 512, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 512, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 502, DateTimeKind.Local).AddTicks(9695), new DateTime(2026, 7, 31, 5, 46, 29, 502, DateTimeKind.Utc).AddTicks(7697), new DateTime(2026, 1, 21, 5, 46, 29, 502, DateTimeKind.Utc).AddTicks(7657), new DateTime(2026, 1, 31, 10, 16, 29, 503, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(1914), new DateTime(2026, 8, 31, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(1887), new DateTime(2026, 1, 26, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(1886), new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(2972), new DateTime(2026, 4, 30, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(2956), new DateTime(2026, 1, 16, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(2955), new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(3452), new DateTime(2026, 1, 11, 5, 46, 29, 504, DateTimeKind.Utc).AddTicks(3446), new DateTime(2026, 1, 31, 10, 16, 29, 504, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1151), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1931), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1938), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1942), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1945), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1946), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1955), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1956), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1959), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1960), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1963), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1964), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(1967), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4615), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4990), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4993), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4995), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4999), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(5000), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(5004), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4907), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4913), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4915), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4919), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4920), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4924), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4925), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4933), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4935), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4938), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4939), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4978), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4983), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4985), new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 505, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 31, 10, 16, 29, 505, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2428), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2760), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2719), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2727), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2730), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2747), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2750), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 1, 31, 5, 46, 29, 506, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
