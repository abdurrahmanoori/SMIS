using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "LoanAccountPayment",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "LoanAccount",
                type: "INTEGER",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "116a1778-2231-4ff0-a1dc-dad46a2a7945", "AQAAAAIAAYagAAAAEGK7Dsm0kG09VnUl9ISOEk2FR/jW04O2+AY5RF77/IpbSkLDDkWwS1KVq+j7GjOfeg==", "73758633-b240-4926-811c-05f491a63b4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af1d2d5f-f88c-492b-8aef-dc09195b1034", "AQAAAAIAAYagAAAAEEywq37U99t6pEiC2i/urMdn+MWoOSfXfZgS2489JRzYVBKR5/ViyaJQU5zbbw36xw==", "04c7e5c6-ab4a-4bed-8ea3-e77402a30309" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da71b67a-c40e-4ba8-8fed-0884a2584100", "AQAAAAIAAYagAAAAEKbH0x1P/Ijq99EdMFfcmhgzUGnY/5oCzIX3zjvYFczUraO+d8sM/KXGneh/1EHx8w==", "117349ce-cb02-4e3e-ab0a-6d2d27e84671" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e0227ae-2d45-4203-9257-9fc020bb5613", "AQAAAAIAAYagAAAAEC0l/qLnDA0WYxeZXLl/aQI6EpgEk7ssqyMTSht+1cmjbs5/opGFj+taiPlU6VZmag==", "dd850681-0c14-4562-8d3f-a10cf192ba1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65c298e3-ec74-4b73-b11e-c511632460a2", "AQAAAAIAAYagAAAAEO691XKnn7kPWkbTEw8PLXdD5e2+ChRo7glApr/r1URE+fbbhSYUNr5YGW3u3Hfo8g==", "acbc6887-73e2-44e9-9661-a80fb6a08185" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0080e2f4-7577-4519-957e-56e480303947", "AQAAAAIAAYagAAAAEI+udQompQ9cu9U6w+Ksv6BskhwNBoxmSx14G1JQH6NEc3XsCuftq3YLwwZyncCnqA==", "2c2e3ec7-cbfe-4a39-a2d8-d37a54d68f0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90c7d20d-c773-444d-a3bd-3e8959515a3d", "AQAAAAIAAYagAAAAEC8K9NwE4YQZG1d81pjv3nwKOcH9Ht748pGNAg172niR6oDRaqQidTwtFqqN8YyolQ==", "55325cb7-837a-47c5-b85b-516ea62d9add" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af4a16d-020a-4d39-a172-75215215be6a", "AQAAAAIAAYagAAAAEI1+nYTBu5wVhh0fvZIf5GZOLnVkIq7KpBGB2s7B98rBh152IIcSMfoZKOGUEOXJjA==", "e6817c0c-f71a-4fc7-bdae-0a016d43337d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c21d15b3-da84-4289-b044-d8a3b2dd9ed7", "AQAAAAIAAYagAAAAEE4tNR4MUk9OLFnUC0ZtU7vIXs2TA440r6VXMES2CziOvECyT9IrkgZ2ZYRYw22tTA==", "51e31712-bcac-47b0-9d62-b0b7e9fdd236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d1c591e-3492-42b3-ada2-f7dc20d15278", "AQAAAAIAAYagAAAAEOX2Ku+MH+T2gmQUZmC2CynjiIbsFWELZNoZjdkaPi+Uhjq5X+QCsTu9+UTY+W5TrQ==", "9b846c11-fbb9-4331-8a88-32abd54631a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2735fe-8f31-4f5e-b36c-c07016f9304d", "AQAAAAIAAYagAAAAEIpoFl3TYfxKpfq5dnSz3LEnU5uXiCNsyY7XlGojJkntAmU6F0LLpU0lDD7eZAvZCA==", "74a77d1b-470a-439f-a651-a7ab93fb0bb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4992246-6d11-43c0-a673-571bcaa99770", "AQAAAAIAAYagAAAAEOPmYUjkYwPf/0rElh2YsFJk/Xbu0J/kx96oGOMzT39vd05sXqvduDoHN8i5T9ckIQ==", "3a384611-e4b9-4362-b96c-b874637f4ffd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0c969c1-335f-4807-8e80-39198978a77f", "AQAAAAIAAYagAAAAECdnNXsb79G0XO0ql++008nQ+tt4JeuQq2yDjmW6b08L3qQisPiW1Ln6HeF2FtvTYw==", "a63cab62-a05c-46a0-b978-7347d7f59228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "233fe13d-c330-4984-bbb4-0ae88f709231", "AQAAAAIAAYagAAAAELjGJ0Nw2gpCNl4da5CT1TZySTfgCfYhhmbukM5/MUVAk4wvFV8WlYsILY4vF7zi2w==", "7e33497b-7c21-4576-b518-75d8d3f95180" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ce48b07-3da0-4232-9a71-32df8f39509f", "AQAAAAIAAYagAAAAENj6vWmxA9LnNhytgWJ6cLp8ryiu8XjseQ8Gg8IFzxfNhShVFvq/p1XXy6xAURkk7Q==", "d686b0ec-e412-4db8-a18d-ace5c81d8c0d" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(5890), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Unspecified).AddTicks(5914), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7746), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7762), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7763), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7765), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7766), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7768), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7769), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(1840), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(1868), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8091), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(6198), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(7364), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(7999), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8011), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8037), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8042), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8048), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8052), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8060), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8071), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8081), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8085), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6681), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(6688), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6844), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(6848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6860), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(6864), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(7149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(7162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 867, DateTimeKind.Local).AddTicks(6311), new DateTime(2026, 3, 18, 10, 23, 12, 867, DateTimeKind.Utc).AddTicks(3667), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 867, DateTimeKind.Unspecified).AddTicks(6350), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 17, 10, 23, 12, 867, DateTimeKind.Utc).AddTicks(3656), 1, new DateTime(2026, 2, 16, 14, 53, 12, 867, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6165), new DateTime(2026, 3, 15, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6164), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6171), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 13, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6164), 1, new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(2872), new DateTime(2026, 3, 3, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(2869), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(2867), 1, new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(4696), new DateTime(2026, 3, 8, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(4693), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(4707), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 6, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(4692), 1, new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6080), new DateTime(2026, 4, 2, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6078), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 11, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6077), 1, new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6112), new DateTime(2026, 2, 26, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6105), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6116), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 27, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6104), 1, new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6124), new DateTime(2026, 3, 6, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6123), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6123), 1, new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6134), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6136), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 22, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6133), 1, new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6144), new DateTime(2026, 2, 28, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6144), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6147), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6143), 1, new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6155), new DateTime(2026, 3, 10, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6154), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6158), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 8, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6154), 1, new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 438, DateTimeKind.Local).AddTicks(6819), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 438, DateTimeKind.Unspecified).AddTicks(6847), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 438, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3657), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3661), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3668), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3672), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3679), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3689), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3693), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3717), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3730), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3734), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3741), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3745), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(1532), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(1554), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(2746), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3527), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3558), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3578), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3596), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3632), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3636), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3644), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 855, DateTimeKind.Local).AddTicks(9215), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(2881), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7115), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7118), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7120), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7142), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7148), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7151), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7152), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7156), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7160), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7163), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7164), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7167), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7168), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7173), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(5623), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7177), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7181), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7182), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7185), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7186), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7189), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7191), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7193), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7195), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7197), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7206), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7210), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7211), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7216), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7219), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7220), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7224), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7225), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7229), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(6581), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(6593), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7230), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7234), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7239), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7243), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7246), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7247), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7250), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7251), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7256), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7261), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7265), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7268), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7269), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7272), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7055), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7068), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7273), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7276), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7281), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7285), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7286), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7289), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7290), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7293), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7294), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7299), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7302), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7303), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7306), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7307), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7074), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7097), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7102), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7105), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7106), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7109), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7111), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 853, DateTimeKind.Unspecified).AddTicks(6572), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4297), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4310), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4314), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4328), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4351), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4356), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4362), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(2471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4371), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4375), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4384), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4393), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4398), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4404), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4408), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4412), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4417), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4421), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4261), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4457), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4465), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4479), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4484), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4489), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4278), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5842), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5845), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5807), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5823), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5827), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5835), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(4925), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(4935), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5049), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5053), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5054), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5057), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5058), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5064), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 436, DateTimeKind.Local).AddTicks(6656), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(6675), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 436, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 437, DateTimeKind.Local).AddTicks(7610), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 437, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 437, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 437, DateTimeKind.Local).AddTicks(8589), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 437, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 437, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 860, DateTimeKind.Local).AddTicks(2987), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 860, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 860, DateTimeKind.Local).AddTicks(2985), new DateTime(2026, 2, 16, 14, 53, 12, 860, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(7731), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 866, DateTimeKind.Unspecified).AddTicks(7770), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(7722), new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(8596), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 866, DateTimeKind.Unspecified).AddTicks(8614), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(8595), new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(2205), new DateTime(2026, 8, 16, 10, 23, 12, 857, DateTimeKind.Utc).AddTicks(9460), new DateTime(2026, 2, 6, 10, 23, 12, 857, DateTimeKind.Utc).AddTicks(9423), new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(6556), new DateTime(2026, 9, 16, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(6542), new DateTime(2026, 2, 11, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(6541), new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(7551), new DateTime(2026, 5, 16, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(7543), new DateTime(2026, 2, 1, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(7542), new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(8205), new DateTime(2026, 1, 27, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(8200), new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(2173), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9673), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(7494), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(8633), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9599), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9625), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9634), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9649), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9656), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9666), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9232), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9256), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9550), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9554), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9555), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9558), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9559), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9563), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9567), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9571), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9575), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9582), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1685), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(1724), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2052), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2056), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2059), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2059), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1983), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(1987), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1989), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(1992), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1995), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(1998), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1999), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2002), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2003), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2007), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2039), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2040), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2048), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2051), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(2276), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4021), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4035), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4040), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4052), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "LoanAccountPayment");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "LoanAccount",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79c7668b-e8c6-41a2-9bd0-54e748d4e94a", "AQAAAAIAAYagAAAAEOBoq3Ga15ooMg7TtMXEp3HkLoonywKMaetZ67spqh8PTs/P7S3h5nLKiubcMpUlzg==", "5aadcb02-3bd2-4e4c-ade9-f69fb9f18544" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a17616e9-95b5-4b9a-b125-c45fe4b9d4e8", "AQAAAAIAAYagAAAAEFrhzUq/jT2NfKJQBivWJJEn8CpgTXaSDMDB/hWB0HG8mMYq0etSEmNZHJ6x3up+Xw==", "b9e1c66f-426a-4b04-aecb-b530acedad17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36024d27-8650-4fa9-bf5c-c507914a3bda", "AQAAAAIAAYagAAAAELmj32453UiePxVQu73h+HoUboYCIrwcNwnXvgGLToDep8eKlB09VDdEg1mxhlbALQ==", "002f786f-05ef-40e9-b696-3c03b12b4b44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af827a92-35f0-4188-843c-941f0d7bb4b0", "AQAAAAIAAYagAAAAELk85C44Of126McAZtNLrHQjYDJbCPy9kj+89U57F/dnVTNOf7B5YHom4iOodWyfOw==", "cbfbac7a-71e5-47cf-b399-ecf4858038f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aef8a159-5db1-4e34-ab15-6dddab6f31c6", "AQAAAAIAAYagAAAAEHAokqPF9u3Tk1ayMWCbblTeTOEYK7kfZnzCL0WGoE5CRQxfvaOKE29I1Ah27gEidg==", "9faf0d5d-01d5-41a8-83bf-0bc92431fca4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bb220bc-2fa7-4c11-9f76-cf073bf04312", "AQAAAAIAAYagAAAAEJgyyplPPpF6Zfkl3WHoBeJ2Djcol5BLJ/qC5P068OjesNdp6XiZu51RJHLActZWSg==", "df13aaf5-d9c0-480f-b2be-d188c277d244" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "833da268-e4e2-4334-8e45-860e00e8df8a", "AQAAAAIAAYagAAAAEOwwbuVwep+r0PynA3Eih8swW1lqurbqFy5neabP7lo01AD36hfToB6KH9x9aZ7cOw==", "5090af3f-cabf-45a2-987e-39a71fbc88d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b65e18e2-eb7b-4abb-a9d7-b51f4ef40df2", "AQAAAAIAAYagAAAAEBpmjE2AFIClbEc95+aHQsde2TVbnbSzqnII8wcmNQZc5bj5LwXtW+cpoPXNAPqKCg==", "bafa2f29-44ca-41c5-af13-e6da48ef4ef8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1a184d0-a35a-4544-b6dd-f5056ee24ff0", "AQAAAAIAAYagAAAAEFfLv7CDUT/ldyr3tIMpt95BbPQEQgCmHbcfuccf8yVleMjh3f7Y1+ccecHmD5CIyA==", "dc2d4ebf-86da-4c7e-b5ff-8c9295c0cc59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03fbf0b4-6350-4af1-96c1-e288de71d1d2", "AQAAAAIAAYagAAAAEEbGdfKv1pcZhNd8cGGzpaF1WThjYc1i9qXyiBlCl949ghh4+lnYtik3yPYTOohiLQ==", "6fb93298-a240-47d3-b405-e439012ee6d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b87ea56-47b3-44e2-bb30-1a2d42a65f68", "AQAAAAIAAYagAAAAENt0Hl+PP8bdYNLWbcL2r6spfzEuj2tw0ls0is55bzK80yo1JqECVp2aGWnk2KA0/g==", "d92e5e6f-3c6c-44af-8e71-041c3fe25b30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ed2702e-8ffb-4d36-9e9d-c4221ad67050", "AQAAAAIAAYagAAAAEJFmiyMAHnP6jCLAqrFSpo1MbTyz1PxCcuJiND3IVEoAdzc2qJDz+BqZRs0xXL5C5g==", "f351e8fa-8b67-4fb8-bd2e-5e070185234a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "562f501a-8508-44c4-a1ba-e2e85d935282", "AQAAAAIAAYagAAAAEJ8P0piSif4kbHbYY5eD6aNgAoeOeX5hAiRNi+Inr0kJ2c51OJZzhtzGr0B0RDPoTg==", "48afbac9-4462-430a-b5af-cf2ea31a7bfe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7434af74-c1f8-46b4-b40a-bb578f9418dc", "AQAAAAIAAYagAAAAELYuGsLKrZQLVA7kq23zyNg8bq7hx+7aYZQAZTU6yOXFYZPQ378xJM8k8dYnXoHb/w==", "f3436cc3-f9a4-465b-b254-e042cbaaff2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34874119-d6cf-4441-adad-a620543a653b", "AQAAAAIAAYagAAAAEIJ/3ZVPgJJzU/dqe6v7Te5pvo+G+8CAEDfeh2rKZ7SIbkZILAk1sZd8Jub79cj03Q==", "a7cde6f6-ae03-43c0-b0ed-2a6bdc0e14fd" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(8272), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Unspecified).AddTicks(8293), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7016), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7018), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7031), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7033), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7034), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7034), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7035), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7036), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7036), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(517), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(531), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6423), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(4779), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(4787), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(5775), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6353), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6355), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6375), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6380), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6386), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6388), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6395), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6409), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6410), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6417), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(4943), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4946), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(5105), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(5107), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(5108), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(5109), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(7268), new DateTime(2026, 3, 16, 10, 22, 34, 246, DateTimeKind.Utc).AddTicks(4791), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 246, DateTimeKind.Unspecified).AddTicks(7294), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 15, 10, 22, 34, 246, DateTimeKind.Utc).AddTicks(4778), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6797), new DateTime(2026, 3, 13, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6797), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6800), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 11, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6796), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(3444), new DateTime(2026, 3, 1, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(3428), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(3456), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(3427), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(5298), new DateTime(2026, 3, 6, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(5294), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(5312), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(5292), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6707), new DateTime(2026, 3, 31, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6705), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6718), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6704), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6736), new DateTime(2026, 2, 24, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6735), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 25, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6734), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6756), new DateTime(2026, 3, 4, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6755), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6755), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6766), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6769), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 20, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6765), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6777), new DateTime(2026, 2, 26, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6776), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 27, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6776), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6787), new DateTime(2026, 3, 8, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6787), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 6, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6786), "Active", new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 819, DateTimeKind.Local).AddTicks(1026), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 819, DateTimeKind.Unspecified).AddTicks(1035), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 819, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6219), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6225), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6232), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6244), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6245), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6250), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6257), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6259), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6263), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6265), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6269), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(4089), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(4102), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(5281), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(5287), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6115), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6118), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6139), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6145), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6191), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6193), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6199), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6200), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6207), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6208), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6213), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6214), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 233, DateTimeKind.Local).AddTicks(8902), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7479), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7485), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7490), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7494), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7495), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7500), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7501), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7505), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7506), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7509), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7511), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7514), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7515), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7519), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7524), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(5705), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7528), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7531), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7533), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7539), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7554), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7561), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7564), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7566), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7570), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7573), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7575), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7578), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7579), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7583), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(6904), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(6914), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7589), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7592), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7593), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7596), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7597), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7601), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7602), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7606), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7609), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7611), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7615), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7618), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7619), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7625), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7628), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7629), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7632), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7420), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7426), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7633), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7638), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7641), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7642), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7645), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7646), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7649), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7651), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7655), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7660), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7663), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7665), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7668), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7430), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7441), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7443), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7447), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7448), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7451), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7453), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7456), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7458), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7461), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 231, DateTimeKind.Unspecified).AddTicks(8794), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6074), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6083), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6087), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6093), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6097), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6101), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6110), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(4703), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6128), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6132), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6145), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6153), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6157), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6175), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6184), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6188), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6192), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6196), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6200), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6206), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6035), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6214), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6218), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6222), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6230), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6234), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6243), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6061), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6065), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3699), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4101), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4051), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4089), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4090), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4095), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4098), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3144), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3149), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3266), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3269), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3270), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3271), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3272), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 817, DateTimeKind.Local).AddTicks(4281), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(4293), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 817, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 818, DateTimeKind.Local).AddTicks(5568), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 818, DateTimeKind.Unspecified).AddTicks(5587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 818, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 818, DateTimeKind.Local).AddTicks(6422), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 818, DateTimeKind.Unspecified).AddTicks(6428), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 818, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(5186), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 238, DateTimeKind.Unspecified).AddTicks(5196), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(5183), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 245, DateTimeKind.Local).AddTicks(9363), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 245, DateTimeKind.Unspecified).AddTicks(9411), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 245, DateTimeKind.Local).AddTicks(9348), new DateTime(2026, 2, 14, 14, 52, 34, 245, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(299), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 246, DateTimeKind.Unspecified).AddTicks(310), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(298), new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(2622), new DateTime(2026, 8, 14, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(369), new DateTime(2026, 2, 4, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(311), new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(7135), new DateTime(2026, 9, 14, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(7121), new DateTime(2026, 2, 9, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(7120), new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(8246), new DateTime(2026, 5, 14, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(8237), new DateTime(2026, 1, 30, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(8236), new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(8974), new DateTime(2026, 1, 25, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(8969), new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 237, DateTimeKind.Local).AddTicks(3649), new DateTime(2026, 2, 14, 14, 52, 34, 237, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1933), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 237, DateTimeKind.Local).AddTicks(9670), new DateTime(2026, 2, 14, 14, 52, 34, 237, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(925), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1877), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1893), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1902), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1909), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1915), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1923), new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(7761), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(7788), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8087), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8090), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8092), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8095), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8097), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8098), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8099), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8101), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8102), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(20), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(37), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(329), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(331), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(333), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(334), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(276), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(279), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(280), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(281), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(282), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(284), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(285), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(287), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(288), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(289), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(322), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(323), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(325), new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(328), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(7208), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1900), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(386), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1426), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1878), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1891), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1893), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
