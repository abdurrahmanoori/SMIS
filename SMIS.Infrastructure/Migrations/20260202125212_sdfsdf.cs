using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopId",
                table: "TranslationKeys",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b904be96-1127-498b-8015-510ddfa043e3", "AQAAAAIAAYagAAAAEMYQb9BwExvW83mvMIOCTqZ5EUxSACB7YGSOEzJJu4QEQalecrXGEyVN2Gr8qyNw3g==", "bd0d5c52-3db3-4ed9-b312-5e289fc986be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbb42a1d-80d3-4942-8502-d3bfb28b7456", "AQAAAAIAAYagAAAAEBy88AeG2r76FNhQzj0t9R2t9tpwUEs68fI1tx2yAVK+C8Te1XWNsgkq0DOnHnMU6A==", "7976e22a-a6e5-439c-86ba-a7ffa3eeae13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7c90f5c-95eb-4814-ab12-55090cdc0f4e", "AQAAAAIAAYagAAAAEFEq+wkE5ZAU4fGXPxzCL0dMAiGKu9pf5s+1o86xGgsr57kD8tFZTxcGpL6GK7sb3Q==", "fe53c35d-b6f6-4319-8534-3f7ebcb895e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80d6d4c8-3855-474a-8b66-66b236def257", "AQAAAAIAAYagAAAAEPBh4yY4g40aCj5z0qcIBfxe2j5zKEQrh4jW4/J7VC28rgK/U1RnM2N+McxEogptNQ==", "5b8fe5df-ade4-412b-a6d8-f928dc3f7266" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c095172-7732-4d4f-841a-1f6948100bae", "AQAAAAIAAYagAAAAEK6+hN+X+DSkED+KDKGUHv8qg4upi0RJfWc4SqfD/BNOuUtLk7D4f1cmk82U25ZTmQ==", "fcc75b87-b538-4e25-addd-f75fe99936ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aec16a98-de21-4917-96e8-1ff8b262b80c", "AQAAAAIAAYagAAAAEMBIis74sG1eZJDBkoIbfy7v7wGQHt+OIY4TruOWWdaJUuYJDLfo/D5HmNnP8HlAmQ==", "77460a34-8edb-429e-a841-86e72e08a712" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bfd7119-2ec8-4b34-aa32-0dea861b5778", "AQAAAAIAAYagAAAAENbT7ok05tOxWL7nburQPQbfyRxajsezAozORjFyOvx+aEAoidkQWt00+p8ehJax7Q==", "67138fe8-f9e1-4b86-b00e-88a46dab35fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f271b331-e24f-4515-a3cd-716b6c3d60c8", "AQAAAAIAAYagAAAAEMHXArPTwXRAB+gxV63+t9/OZLIjjzEkAZZ5beq3uKCURAJyxaodJzpRai/9VdxptQ==", "e9b973b7-99f3-4e96-ac0e-0c24f44d59c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7150cb5-04c3-4a5d-9047-e6a5798d38d3", "AQAAAAIAAYagAAAAEGiH9j/k4H+ENmDE8kGy0vEvrxaA4MhVujygxmz0+TclkZa7O0gslzmApWIom4A7Qw==", "e36cfc5e-2967-411d-9075-969c9a8fd083" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "311aa7e0-46d7-433f-b46a-9e9824845cbf", "AQAAAAIAAYagAAAAEIoUvf/gG5baYrq/GKYr4uz8MG6BHJo8J3GYo9j2iUGfFSD89w07nybtVFX+cBG+NA==", "f8b249ba-3121-450e-bfe3-ff660c8ab324" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68e01ff1-b825-4037-a92a-acf835f73c99", "AQAAAAIAAYagAAAAEPLRWQZCLq+KUiSHhfykEclK9dMSRB/Ctb+3ZUE0o6ExhMseUZsTFjYboKT+Yg2EWw==", "32d8983d-12c9-4d4d-a9bf-d4c88223a78c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f73cdc7-f389-4788-b897-888d050f9b6a", "AQAAAAIAAYagAAAAEP2gLFMzhpGxC2UwUiz1FDduJavgPYmHe3gf8xbukZsa+muBaKiebzIbnFqgbqLl/A==", "658cceab-d99f-40a3-9737-4c78b5426bf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20c889e4-2263-4fc3-add5-cf4ab56491fa", "AQAAAAIAAYagAAAAECqG2zndAPGT3qpyM3t5KvfeQF3jAabtXhlkxz3YsnUsdzc2s+zzHjFaike1amVL5g==", "939b7ef7-251e-46d5-bd5b-4916bf220ed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee3b1279-ec27-4037-bcf5-3629d7b050c5", "AQAAAAIAAYagAAAAEDrH38W8pCeqR3rfQkj9jfWM+n1TpFgNl8Ibo+a86ZCTGlO9Q5oJ7ucIxsXcGcOqXQ==", "c7378e68-71e6-4b60-8e07-3928b579e736" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89a11d5d-d6c2-4010-8845-825960aad200", "AQAAAAIAAYagAAAAECzXnf4pTzAPStGTlQtW+8+Dksw2K+mHb6EjKp7D2teLGSBUhNOnXftUFLAjQD5nrQ==", "8d2c8148-51e5-4ed5-becb-35dc9df2f5c8" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(5123), new DateTimeOffset(new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Unspecified).AddTicks(5152), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4005), new DateTimeOffset(new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Unspecified).AddTicks(4008), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4019), new DateTimeOffset(new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4020), new DateTimeOffset(new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Unspecified).AddTicks(4021), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4022), new DateTimeOffset(new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Unspecified).AddTicks(4022), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4023), new DateTimeOffset(new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Unspecified).AddTicks(4023), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 5, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(7570), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(7574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(7895), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(7901), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(7902), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(7907), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(5356), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(5707), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 2, DateTimeKind.Local).AddTicks(6794), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 2, DateTimeKind.Unspecified).AddTicks(6805), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 2, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2949), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2950), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2955), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2959), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2976), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2977), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2982), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2984), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2989), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2994), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(3000), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(554), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(569), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(1981), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(1996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2832), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2835), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2857), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2859), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2880), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2916), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2923), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2924), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2937), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2938), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2943), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 4, DateTimeKind.Unspecified).AddTicks(2944), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 4, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(1915), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5336), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5340), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5352), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5356), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5360), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5367), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5224), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5374), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5377), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5382), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5385), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5389), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5395), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5399), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5403), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5232), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5406), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5236), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5240), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5244), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 380, DateTimeKind.Unspecified).AddTicks(5328), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6158), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6596), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6599), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6552), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6582), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6585), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6587), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6591), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6593), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(5535), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(5543), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(5700), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(5703), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(5709), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(5710), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 0, DateTimeKind.Local).AddTicks(9066), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 0, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 2, DateTimeKind.Local).AddTicks(1008), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 2, DateTimeKind.Unspecified).AddTicks(1026), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 2, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 12, 2, DateTimeKind.Local).AddTicks(1706), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 2, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 12, 2, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 381, DateTimeKind.Local).AddTicks(3763), new DateTime(2026, 8, 2, 12, 52, 11, 381, DateTimeKind.Utc).AddTicks(1223), new DateTime(2026, 1, 23, 12, 52, 11, 381, DateTimeKind.Utc).AddTicks(1170), new DateTime(2026, 2, 2, 17, 22, 11, 382, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 382, DateTimeKind.Local).AddTicks(8619), new DateTime(2026, 9, 2, 12, 52, 11, 382, DateTimeKind.Utc).AddTicks(8580), new DateTime(2026, 1, 28, 12, 52, 11, 382, DateTimeKind.Utc).AddTicks(8578), new DateTime(2026, 2, 2, 17, 22, 11, 382, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 383, DateTimeKind.Local).AddTicks(796), new DateTime(2026, 5, 2, 12, 52, 11, 383, DateTimeKind.Utc).AddTicks(778), new DateTime(2026, 1, 18, 12, 52, 11, 383, DateTimeKind.Utc).AddTicks(776), new DateTime(2026, 2, 2, 17, 22, 11, 383, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 383, DateTimeKind.Local).AddTicks(1631), new DateTime(2026, 1, 13, 12, 52, 11, 383, DateTimeKind.Utc).AddTicks(1624), new DateTime(2026, 2, 2, 17, 22, 11, 383, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 383, DateTimeKind.Local).AddTicks(6603), new DateTime(2026, 2, 2, 17, 22, 11, 383, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(4020), new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(2037), new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3208), new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3937), new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3950), new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3957), new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3964), new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3970), new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3978), new DateTime(2026, 2, 2, 17, 22, 11, 384, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(8858), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(9242), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9689), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(9692), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9693), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(9694), new TimeSpan(0, 0, 0, 0, 0)), "2", new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9695), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(9697), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9698), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), "2", new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9700), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(9701), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9702), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(9710), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "ShopId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9711), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 998, DateTimeKind.Unspecified).AddTicks(9712), new TimeSpan(0, 0, 0, 0, 0)), "2", new DateTime(2026, 2, 2, 17, 22, 11, 998, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(1726), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(1733), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2122), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2123), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2124), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2125), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2126), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(1998), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2002), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2003), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2004), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2005), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2088), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2090), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2092), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2117), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2118), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2119), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2120), new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 11, 999, DateTimeKind.Unspecified).AddTicks(2121), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 17, 22, 11, 999, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(6581), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(4768), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(5967), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(6494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(6505), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(6508), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(6574), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 12, 52, 12, 0, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_TranslationKeys_ShopId",
                table: "TranslationKeys",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_TranslationKeys_Shop_ShopId",
                table: "TranslationKeys",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranslationKeys_Shop_ShopId",
                table: "TranslationKeys");

            migrationBuilder.DropIndex(
                name: "IX_TranslationKeys_ShopId",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "TranslationKeys");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9facdc9-f0c4-4fd5-81d2-0d052fc3e6ad", "AQAAAAIAAYagAAAAEJlTsRLJGO1hFJZKileTT16i4IMcgupuYUwUFrCAdSjAC9yYgz2wEcL7ljhreCtpNw==", "d8999f81-4671-4c84-93fc-92038270e009" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00f975ee-c42d-4a2f-9b70-d0f9d57caaef", "AQAAAAIAAYagAAAAEAdv4om/OY7sHp8nPgSILMWKZgTNvPzHr1JFh8QaA93BxD2SfMl5stCvUeCDIQnigw==", "846fac22-e2e8-46e6-8b05-ee06bae74371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee54f1ef-7237-4fc1-869b-683302a12c9c", "AQAAAAIAAYagAAAAEBzKLB5oZOA2ldukl411OMZxzR/GWxFYTrUFe+f6erUiqthymiKlbNKkApyLbQpcQA==", "0d7cd615-9d67-4871-8acd-c9644899194a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "246e89e4-1f26-423a-bb2c-a186ab02a0ea", "AQAAAAIAAYagAAAAEP4ZX7tza4BIPRNrRDO1VnJrvxUI5hfzh8kj6QWCEVtIUS8q4Ajo7BffQmFDmjX2xA==", "cd99e351-6d27-4a2f-a451-705e4cb61ce7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02932d31-689e-4761-9017-266362398f9f", "AQAAAAIAAYagAAAAEJ0dRr2seenP2jM3cwN+SGIi2uQEdMZwhAE/REyHAglP/8W8cRhM0hooBlKWG0Zh8A==", "5c32663e-1b05-4ecd-8470-0026d2998664" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9a9ce7-4825-4a4d-ae36-354a28d658bf", "AQAAAAIAAYagAAAAEEpZe6JJRUlR1ggG8HSOPYGG4P4PRAz/d4Tsw+OiBdcMjg3wzFerTRAUE0DGPPE/8w==", "1a74b2f5-cd39-4bd8-aa3a-ce19ca7783ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0bf111c-82de-447f-91cd-b54000bcf1c4", "AQAAAAIAAYagAAAAEKWXRwmot2IkgdN/QXQW1ABIYOPpqLXe9lIcvn+lynEsA3lvoumwDlrQqSlaEUJiVA==", "e9a01a6c-35f5-4d05-85f1-c8b27207ee3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e7e2fc1-b240-4e0b-a24c-e5e3334a3a45", "AQAAAAIAAYagAAAAEBpyQNfiy+Pq4yn2f6xVYMZ/ZvMwByZpBT+0YppYoxfmCyyCX2HSyu900aKvbvDN8Q==", "3739eca6-564b-4602-80a5-bcab1195a946" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b53ddd99-d01a-4740-b66e-c1da8b725e7e", "AQAAAAIAAYagAAAAEDPIK2UaC/m4oT3qH6KBSuw0qQJLN9rpU5wqZtCgTBfVLyRiPnLh6hnoTQ+YjIWiLA==", "2863005f-87a7-4ee0-8dfa-293ba0797e3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5102cffe-6860-4285-a7d1-5ada3af0c5c8", "AQAAAAIAAYagAAAAEGIVzKG1jD/GJ2n1BNZ0hRDVfOwH5cvUSYII2qvu72Jxtzl/gqgbBZCZnR22UVwtzg==", "bcf5164d-da6d-4fe9-87ab-e6d82ef49695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb99e6e6-24cf-40e6-8630-acd167507b9c", "AQAAAAIAAYagAAAAEBAEPVVtc5fUl/n6u0hoPs/jSXIU2ndQ+3Obz51QxpUSbKe1NPWdyS95s9R8w2LiTg==", "106a6a5d-a8ae-49fe-afd7-8d352a4a128b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f42354bb-1777-4555-b7a4-dca7d93688e6", "AQAAAAIAAYagAAAAEBYHYxIQPF35nDNKnYW8n2RyJXBwtGGtkYySG+Hjq23bgqRhUqZqo+OMi8T0mNQybA==", "0ec7dfb1-8978-4991-98ad-fc814a5dc462" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "381c570a-c509-46ff-b667-bebe4b42a330", "AQAAAAIAAYagAAAAENLVzhQYX+dzPMgbMF97rhmM7g5R5FkMFYu59SCggqO6EiUeqG5QIKLiAlpke3OHcg==", "f0888707-649c-4db5-8554-24ad54d82eb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0de3c85-aa3c-49e2-bad3-f01d5ac681c2", "AQAAAAIAAYagAAAAEGk+U9IJ5n6mvntA0FRdS9WYiwqummylq7Uo3TtoirtI1dtfKz2+Uhik067LieP03w==", "a18b3a27-9821-45a8-825a-968a95be1e24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4340440-7148-4ef4-9a96-fcfc1e219b0d", "AQAAAAIAAYagAAAAELml67u53a9VP/M1TBsnGt3ti76bHlbw/tU21iVGlBpdOEVgIWxG55k27zcZdC+x/w==", "1ad58caa-c759-4e9b-a832-0fa5bb2b2206" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(6065), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Unspecified).AddTicks(6092), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4638), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4641), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4652), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4652), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4654), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4655), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4655), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4656), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4657), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3004), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(3025), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3268), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3274), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(3278), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(1772), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(1776), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 223, DateTimeKind.Local).AddTicks(3039), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 223, DateTimeKind.Unspecified).AddTicks(3073), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 223, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3637), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3641), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3649), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3652), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3671), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3682), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3700), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3711), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3716), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3723), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(1052), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(1096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(2596), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3489), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3495), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3512), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3524), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3535), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3545), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3561), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3564), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3572), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3605), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4077), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4085), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4089), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4155), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4166), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4034), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4178), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4188), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4191), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4194), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4206), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4209), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4212), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4055), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4066), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1911), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1918), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1921), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1924), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(420), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(442), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(576), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(581), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(582), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(586), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(587), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(590), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 221, DateTimeKind.Local).AddTicks(4200), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(4222), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 221, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(5930), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 222, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(6655), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 222, DateTimeKind.Unspecified).AddTicks(6665), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 615, DateTimeKind.Local).AddTicks(1642), new DateTime(2026, 8, 2, 11, 58, 25, 614, DateTimeKind.Utc).AddTicks(9355), new DateTime(2026, 1, 23, 11, 58, 25, 614, DateTimeKind.Utc).AddTicks(9320), new DateTime(2026, 2, 2, 16, 28, 25, 615, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(3244), new DateTime(2026, 9, 2, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(3225), new DateTime(2026, 1, 28, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(3223), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(4770), new DateTime(2026, 5, 2, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(4759), new DateTime(2026, 1, 18, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(4758), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(5537), new DateTime(2026, 1, 13, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(5502), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(9185), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5983), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(4230), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5234), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5938), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5949), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5955), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5962), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5968), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5974), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4230), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4925), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4929), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4931), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4973), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4974), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4978), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4979), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4990), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4994), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4994), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4998), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4999), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(6994), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7308), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7360), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7362), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7366), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7369), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7255), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7259), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7260), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7264), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7268), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7274), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7275), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7277), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7278), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7299), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7300), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7304), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7307), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(440), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1501), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
