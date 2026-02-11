using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfdsgj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PriceAtLoanTime",
                table: "LoanAccount",
                type: "TEXT",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84fb800d-f03e-4764-9f44-3a1dbd878a86", "AQAAAAIAAYagAAAAENOBYyefNEna9fO3t0F4XU6jq+bRFbvpx38y1GFJAlZj+/Is106Bz+6a2SAs5o7UvA==", "9fc25fc7-6278-40e8-b9e0-a42e4f6a5781" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e50db5ce-f577-4598-86f4-cac1de8bd30c", "AQAAAAIAAYagAAAAEH+QNW57hx4iE2LT5aP7qBc8SMhnv3TPIgC72x/d7Mq7qAcIseOM/l2AxV1mUAzvqA==", "8b50993e-5d70-41fa-9ce3-440e9e1ba3f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3461df7-05d0-4846-a88e-592586c9253b", "AQAAAAIAAYagAAAAEJXs3xECTC8IYc+MUSHAXmcOpkjYlJZSdeNaHQ6Qw9/+a/YC2UKuIJqu2iOcqJ0dcQ==", "58b249cb-fd07-48f9-8031-f6d09416e216" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8877a279-9c29-4d3e-a015-90369a6bf552", "AQAAAAIAAYagAAAAEKP2b8UWrZ84y1stjiYjfH0Y0QRmqn5xXHD4al+fLT5dY4jMBAYhBUC6YTLakVPyiA==", "538fb3e8-c1da-4aaa-8acc-c3516cf041f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d41f17d-6050-4bfb-bdc8-a7ece47e163b", "AQAAAAIAAYagAAAAEHI8GHPDu8zrMzZ8Mphx6tkwUOOqDLnxooXRy9KCvexKHRNt49HXzDULwo3F+Pe+tw==", "a77c8d35-ff45-47cf-b447-55ca5eb08710" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6368475a-3fbc-4880-97c3-bd052fda8d5f", "AQAAAAIAAYagAAAAEFRVjUJvK9qNnpg799JzyIXYAHbSFhV6t69Nk/ItQjZAbgpwagdKaGEio7uSYGie4Q==", "b6370187-6907-48d3-a280-f6461bd15a11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35d1c203-82e7-4970-b64a-aa2b50a7b51a", "AQAAAAIAAYagAAAAELD7w7HgDHMYr4B5xXX1c+5DZ/7xfDaY6XEiEwJ02g5ocDFZTCX7Yw3/uGBnfSPAWQ==", "6fffe26e-4349-406c-9224-4ab775ce1dd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e05a771-676e-4252-a9ef-35bd626d05c9", "AQAAAAIAAYagAAAAEDrp8oE8SBPJofZuNQSZmKGPgMQxLDq+no9Pkz/VhoZNHcP5Pr76S2YyFmN2N3ntsQ==", "46f23331-5771-4009-9900-91e27505cc13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d11cd1c-f2a1-4947-ae1e-5eac2dd2ba6a", "AQAAAAIAAYagAAAAEDemQnP4Jkm/KGtEETfuKfTA+aR48IUKUHETt/RJcz92NcsbUGylq9m5ZdMO05iQ0w==", "c0d6f7ba-3e2f-4826-b5a1-9ab36b495c7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d7a874-2a43-4496-ae4b-17604b821450", "AQAAAAIAAYagAAAAEPNVT1AK6lJzT3sT69onnd3laTNKUSMi4gJphzI90husS7P1QmfP+EW56gDS+A2FTQ==", "6a0e8702-a1c8-49dd-8dc0-dcfb2837260d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "110eca8a-aca0-4187-90fa-2df0f2b029f2", "AQAAAAIAAYagAAAAEAt8hgoIPO2GIs5YUpEroRCUciJ+BN05YTU9nIUmouPh5wUWS2wasuk5/vYEqEwp0w==", "fa51cbd0-327f-45ad-b8d0-b8845c3cb243" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aa7ac38-ef3d-4b09-a8fd-80c762164650", "AQAAAAIAAYagAAAAEGL85qYQPNP0lVIkKyVQ+IZyjH2KmXcNGpGTJnubDMJLfygcUUoSi3C/kSVJBqn9Bg==", "ab0c14ef-f4cc-428e-b491-668adc163cab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60c733a2-7eab-4eab-962f-9147b6be484a", "AQAAAAIAAYagAAAAEEUiyHb8aDto/U+MN9x8lk7N7NhjuzbtHmFrtIcZ/YgrbefHghUoqTtHFkuxr0AtkQ==", "7ed0c1dd-8b33-4084-aa79-2cda404aa70f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b1d2288-29af-4452-b4a6-642eae9f740f", "AQAAAAIAAYagAAAAEJym63She2GGxLl+yBu0H0ZO+M1nbLNsg8sdF9n7nkPv3fc8C8uMAnDhPB99zh+yxg==", "795fde35-1620-407d-98b8-10a07b22548c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12337781-1b82-499c-9ecd-51ae7c041271", "AQAAAAIAAYagAAAAEFpJehnb4qCIA7m3MxL3aQ9JiCMlBLcu+IgV4WiQOTzr6Q0DWtARvoAkkIdu5zM1tg==", "c12b38c5-beb7-459d-8628-40c92cf516f4" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 617, DateTimeKind.Local).AddTicks(1436), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 617, DateTimeKind.Unspecified).AddTicks(1484), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 617, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(78), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(84), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(111), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(112), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(114), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(115), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(116), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(117), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(118), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 619, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 620, DateTimeKind.Local).AddTicks(4024), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 620, DateTimeKind.Unspecified).AddTicks(4213), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 620, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5658), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5669), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 622, DateTimeKind.Local).AddTicks(8929), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 622, DateTimeKind.Unspecified).AddTicks(8956), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 622, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(2691), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(2717), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5278), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5314), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5437), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5444), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5478), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5529), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5572), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5578), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5620), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 623, DateTimeKind.Unspecified).AddTicks(5626), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 623, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(9647), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(9663), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 603, DateTimeKind.Local).AddTicks(324), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 603, DateTimeKind.Unspecified).AddTicks(335), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 603, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 603, DateTimeKind.Local).AddTicks(338), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 603, DateTimeKind.Unspecified).AddTicks(340), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 603, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 599, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 599, DateTimeKind.Unspecified).AddTicks(9693), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 599, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 55, DateTimeKind.Local).AddTicks(6338), new DateTime(2026, 3, 11, 17, 34, 37, 55, DateTimeKind.Utc).AddTicks(1508), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 55, DateTimeKind.Unspecified).AddTicks(6356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 34, 37, 55, DateTimeKind.Utc).AddTicks(1507), 5000m, new DateTime(2026, 2, 9, 22, 4, 37, 55, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 56, DateTimeKind.Local).AddTicks(9001), new DateTime(2026, 2, 24, 17, 34, 37, 56, DateTimeKind.Utc).AddTicks(8983), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 56, DateTimeKind.Unspecified).AddTicks(9054), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 34, 37, 56, DateTimeKind.Utc).AddTicks(8981), 5000m, new DateTime(2026, 2, 9, 22, 4, 37, 56, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "PriceAtLoanTime", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 57, DateTimeKind.Local).AddTicks(1524), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 57, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 34, 37, 57, DateTimeKind.Utc).AddTicks(1518), 5000m, new DateTime(2026, 2, 9, 22, 4, 37, 57, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 612, DateTimeKind.Local).AddTicks(626), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 612, DateTimeKind.Unspecified).AddTicks(681), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 612, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6051), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6055), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6074), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6095), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6118), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6122), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6140), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6147), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6211), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6241), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 615, DateTimeKind.Local).AddTicks(8197), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 615, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 615, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(2572), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5756), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5771), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5843), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5902), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5912), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5958), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5993), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(5997), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6017), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 616, DateTimeKind.Unspecified).AddTicks(6031), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 616, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 30, DateTimeKind.Local).AddTicks(6629), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 32, DateTimeKind.Unspecified).AddTicks(1336), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 32, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3004), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3007), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3011), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3020), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3024), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3027), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3030), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3032), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3035), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3041), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3044), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3086), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3093), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3095), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3098), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3118), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3124), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(324), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3127), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3130), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3133), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3139), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3141), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3145), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3150), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3153), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3156), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3159), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3162), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3165), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3168), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3179), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3185), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2038), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2066), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3191), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3193), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3196), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3199), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3203), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3208), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3214), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3217), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3220), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3225), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3229), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3234), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3237), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3240), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3245), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2936), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3252), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3257), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3263), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3266), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3269), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3277), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3283), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3288), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3291), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3294), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3297), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2973), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2980), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2986), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2992), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2998), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 33, DateTimeKind.Unspecified).AddTicks(3001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 33, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 26, DateTimeKind.Unspecified).AddTicks(626), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2481), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2498), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 27, DateTimeKind.Unspecified).AddTicks(9783), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2524), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2530), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2535), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2541), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2546), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2551), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2559), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2605), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2641), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2646), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2402), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2653), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2658), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2665), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2677), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2683), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2689), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2694), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2428), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2434), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2447), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 28, DateTimeKind.Unspecified).AddTicks(2452), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(4753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6474), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6481), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6434), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6439), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6443), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6447), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6458), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(6465), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(2591), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3073), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3087), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3091), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 602, DateTimeKind.Unspecified).AddTicks(3093), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 602, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 606, DateTimeKind.Local).AddTicks(1326), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 606, DateTimeKind.Unspecified).AddTicks(1382), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 606, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 610, DateTimeKind.Local).AddTicks(2512), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 610, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 610, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 610, DateTimeKind.Local).AddTicks(5102), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 610, DateTimeKind.Unspecified).AddTicks(5144), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 610, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 39, DateTimeKind.Local).AddTicks(5027), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 39, DateTimeKind.Unspecified).AddTicks(5042), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 39, DateTimeKind.Local).AddTicks(5023), new DateTime(2026, 2, 9, 22, 4, 37, 39, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(3422), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 54, DateTimeKind.Unspecified).AddTicks(3467), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(3409), new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(5814), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 37, 54, DateTimeKind.Unspecified).AddTicks(5826), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(5811), new DateTime(2026, 2, 9, 22, 4, 37, 54, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 34, DateTimeKind.Local).AddTicks(3157), new DateTime(2026, 8, 9, 17, 34, 37, 33, DateTimeKind.Utc).AddTicks(8498), new DateTime(2026, 1, 30, 17, 34, 37, 33, DateTimeKind.Utc).AddTicks(8398), new DateTime(2026, 2, 9, 22, 4, 37, 34, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(5261), new DateTime(2026, 9, 9, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(5238), new DateTime(2026, 2, 4, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(5237), new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(8003), new DateTime(2026, 5, 9, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(7990), new DateTime(2026, 1, 25, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(7988), new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(9988), new DateTime(2026, 1, 20, 17, 34, 37, 35, DateTimeKind.Utc).AddTicks(9966), new DateTime(2026, 2, 9, 22, 4, 37, 35, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 36, DateTimeKind.Local).AddTicks(8211), new DateTime(2026, 2, 9, 22, 4, 37, 36, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9150), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(3006), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(6202), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9046), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9090), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9102), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9112), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9129), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9140), new DateTime(2026, 2, 9, 22, 4, 37, 38, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(5342), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6437), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6462), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6465), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6466), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6469), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6470), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6474), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6476), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6479), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6481), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6484), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6486), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 600, DateTimeKind.Unspecified).AddTicks(6489), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 600, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(2523), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(2545), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3653), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3659), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3663), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3516), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3534), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3537), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3539), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3540), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3543), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3545), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3548), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3550), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3553), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3555), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3642), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3645), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3649), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 601, DateTimeKind.Unspecified).AddTicks(3651), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 4, 38, 601, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 603, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 604, DateTimeKind.Unspecified).AddTicks(7788), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1810), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1849), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1875), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 34, 38, 605, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceAtLoanTime",
                table: "LoanAccount");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bc4c342-856f-4022-94e7-a2f5fbbbd7ea", "AQAAAAIAAYagAAAAEGcLrFkJf1/MDImREYqxraSdYdfoJno9UE5j1hFdvmYtvge215Yxqu+3SKd3gYUBng==", "83506eb1-02e0-499f-be96-6a0ec6dab475" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d21554e-5251-45f4-895a-1ab9c9357379", "AQAAAAIAAYagAAAAEIrpSxpVK216Phyb3UpreQnkMgnOVu03NYRFyqQwU70ipyouSMBwhgg6JvdghvmoEQ==", "883598f5-ff9a-4921-b3e4-7f78096d99a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "828d48f3-6fb3-42af-a1a3-74630ab44ee4", "AQAAAAIAAYagAAAAELg88IDbvnURnKYhLXuzhNlHlgJhORz5VeDcdZ3VK0e33ser60WAGKapirUMaUtFng==", "074f761c-122d-4940-9764-de6f3623d87e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5f764b9-d364-4ae5-a2ab-5640774ec71d", "AQAAAAIAAYagAAAAEGbAN2hIMn7gY13hkPsRvJZp8snTmZ//rI/trDX+MQ0D9dmdeeYvcUec+lqJq6IzhQ==", "ae15b372-16dd-4c61-b327-7d0f772ee27a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9499159a-35cb-4033-b773-f1f3e77c36c1", "AQAAAAIAAYagAAAAENi51zNT5cZJ3iVWXdN+XcSS6sBUcziYsRRsxUVSBJCYQgsReGECx031kfp6h5pH2g==", "ce941286-e89f-4929-a7c5-adcf18b1b7bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e41e8c4-d4fd-4d0e-b9cc-37f8c1ba9b95", "AQAAAAIAAYagAAAAEO+ovfWawHvzehkFLdJ84XukHgVh5ywc3qDXlwfQujOJp9LE5/hFxdram3cJq1bZIA==", "8c827491-fe16-4787-bee7-074c7ac6fd0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "170c1b5f-cdea-413d-9656-57155b2eb1a1", "AQAAAAIAAYagAAAAEG35GhrOSRci+IxoVxxSdyygqWGBxGV+Y0QVt4L5230kGR7w41zagkM9xBEXnPO0JQ==", "68029492-7c83-49c7-9e7a-f4901f3d7a15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d01dd1-1e86-4964-a181-1bdf0b495b55", "AQAAAAIAAYagAAAAELuz7jwE9Mx9UQgcdXAm4rHtfziikmp3owT9lxJKodZ+uGY64r+bNkckKC3muK341Q==", "073e0e30-3a25-4107-84ad-4b274277d550" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d523ab3b-a434-4a31-a3e3-c242acb2ddb6", "AQAAAAIAAYagAAAAEN0MJZEPt7qtlsV7v2PbE6EYaCOSJRezFqwr0zpO2Zdjyzave+Oy+BcxrowZ/6fYGg==", "7890894c-b8dc-40bc-96f6-76dde1ed5141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eb65b06-b645-4736-a741-51a93f9607dd", "AQAAAAIAAYagAAAAECp1jqWDJ+CMtiPZKRpwCwrH2Xlg2nrO4BQGO9pOpXJgsoZtVxC65OXsnekV1wke0w==", "8fe8ba4b-ba7c-4bfd-92f0-a352d9ea6254" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e9c5f3d-a2f6-4fcb-8d0b-e19506e7b195", "AQAAAAIAAYagAAAAEHzftzjNhSGFykoAIe8eWJKCR5GJQnFpWCsCI+86hNlAwHMiqqh/PjRnRJ92GKdcSQ==", "f0d3fdaf-b8a9-4e98-bc97-75636b7cfaa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "877def42-7ab1-499c-a49a-3d4e7615f784", "AQAAAAIAAYagAAAAEA/2PjfKTB7Zd9bPNRcxT9yEo3ooJEZ8LJJLnlcXHwVbuN16515d8hyGu6gDgklfLQ==", "79122f1f-79a1-41ae-812f-ad9aac4ddfc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10a11b7f-d71e-4319-b5c4-ab1f03acff4f", "AQAAAAIAAYagAAAAEAcj0CtIJktJPhc+v9UQH9ZZQnoqiwACBbp9NYOS2ksa8fpXWBKtjli/nd7W5f/BHA==", "94962834-7937-4f4b-802c-6eb1d5cfb1e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ed46ce-de39-4f4d-b906-d3aa3fd32339", "AQAAAAIAAYagAAAAEM0QztOEj0lrAStjyTiLZpDdzr1Uo1G91LBwz6aGG/KLHbAdyBKufZ5np8fwXxPcdg==", "bda94259-4cdc-407c-84ce-382dbf2f41c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c43b4423-3a14-41d1-824c-8a4ab9a40dc2", "AQAAAAIAAYagAAAAENkyk7AvdILucbsvC10RXQqy2FVhMUH+S+ufKbGysFnRHvL531R8jN5UdCQCYEhY+g==", "beaf175b-b5a5-4026-a8e5-ca4656ee3ca4" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(6772), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(370), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(394), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(397), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(399), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(401), new DateTimeOffset(new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Unspecified).AddTicks(402), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 421, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 422, DateTimeKind.Local).AddTicks(688), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 422, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 422, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7632), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7635), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(3941), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(3957), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(6058), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7493), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7505), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7557), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7570), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7585), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7597), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7610), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7621), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 423, DateTimeKind.Unspecified).AddTicks(7623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 423, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9251), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(9266), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9859), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(9869), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9871), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(9873), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 408, DateTimeKind.Unspecified).AddTicks(6134), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 408, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 408, DateTimeKind.Unspecified).AddTicks(6984), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 995, DateTimeKind.Local).AddTicks(1560), new DateTime(2026, 3, 11, 16, 17, 31, 994, DateTimeKind.Utc).AddTicks(8000), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 995, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 16, 17, 31, 994, DateTimeKind.Utc).AddTicks(7999), new DateTime(2026, 2, 9, 20, 47, 31, 995, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 996, DateTimeKind.Local).AddTicks(811), new DateTime(2026, 2, 24, 16, 17, 31, 996, DateTimeKind.Utc).AddTicks(802), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 996, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 16, 17, 31, 996, DateTimeKind.Utc).AddTicks(801), new DateTime(2026, 2, 9, 20, 47, 31, 996, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 996, DateTimeKind.Local).AddTicks(2652), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 996, DateTimeKind.Unspecified).AddTicks(2674), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 16, 17, 31, 996, DateTimeKind.Utc).AddTicks(2647), new DateTime(2026, 2, 9, 20, 47, 31, 996, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 416, DateTimeKind.Local).AddTicks(1110), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 416, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 416, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3154), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3156), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3166), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3168), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3177), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3187), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3198), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3200), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3209), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3220), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3225), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 418, DateTimeKind.Local).AddTicks(7357), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 418, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 418, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(591), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(603), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3022), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3079), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3094), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3106), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3108), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3117), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3143), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 419, DateTimeKind.Unspecified).AddTicks(3145), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 419, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 971, DateTimeKind.Local).AddTicks(5918), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 973, DateTimeKind.Unspecified).AddTicks(577), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 972, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(434), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(440), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(443), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(446), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(448), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(451), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(475), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(479), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(482), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(485), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(487), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(490), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(495), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(497), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(500), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(502), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(505), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(508), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 973, DateTimeKind.Local).AddTicks(8127), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 973, DateTimeKind.Unspecified).AddTicks(8142), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 973, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(538), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(544), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(549), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(552), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(554), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(557), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(559), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(562), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(567), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(569), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(572), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(577), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(582), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(584), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(587), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(591), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 973, DateTimeKind.Local).AddTicks(9533), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 973, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 973, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(595), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(597), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(599), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(605), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(609), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(612), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(615), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(617), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(620), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(622), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(625), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(630), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(634), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(637), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(639), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(642), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(644), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(360), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(373), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(647), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(649), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(652), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(654), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(657), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(669), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(673), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(676), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(678), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(681), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(685), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(688), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(690), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(693), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(695), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(396), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(409), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(413), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(416), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(419), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(421), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(424), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(426), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(429), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 974, DateTimeKind.Unspecified).AddTicks(432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 974, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 966, DateTimeKind.Unspecified).AddTicks(9125), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1008), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1023), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1029), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1034), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1040), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1056), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1061), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 968, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1112), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1117), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1128), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1136), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1142), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1146), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1158), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1163), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1188), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1193), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(950), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1209), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1214), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1227), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1232), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1243), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(978), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(985), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(998), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 969, DateTimeKind.Unspecified).AddTicks(1003), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6623), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6649), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6580), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6606), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6609), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6614), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6617), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(2973), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(2989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3354), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(3363), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3366), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3369), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 410, DateTimeKind.Unspecified).AddTicks(3371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 410, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 412, DateTimeKind.Local).AddTicks(9899), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(9938), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 412, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 415, DateTimeKind.Local).AddTicks(721), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 415, DateTimeKind.Unspecified).AddTicks(755), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 415, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 415, DateTimeKind.Local).AddTicks(1745), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 415, DateTimeKind.Unspecified).AddTicks(1766), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 415, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(7795), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 980, DateTimeKind.Unspecified).AddTicks(7817), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(7791), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(954), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 994, DateTimeKind.Unspecified).AddTicks(1001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(941), new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(3370), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 31, 994, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(3365), new DateTime(2026, 2, 9, 20, 47, 31, 994, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 975, DateTimeKind.Local).AddTicks(1366), new DateTime(2026, 8, 9, 16, 17, 31, 974, DateTimeKind.Utc).AddTicks(7055), new DateTime(2026, 1, 30, 16, 17, 31, 974, DateTimeKind.Utc).AddTicks(6986), new DateTime(2026, 2, 9, 20, 47, 31, 975, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 976, DateTimeKind.Local).AddTicks(5321), new DateTime(2026, 9, 9, 16, 17, 31, 976, DateTimeKind.Utc).AddTicks(5275), new DateTime(2026, 2, 4, 16, 17, 31, 976, DateTimeKind.Utc).AddTicks(5271), new DateTime(2026, 2, 9, 20, 47, 31, 976, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 976, DateTimeKind.Local).AddTicks(8028), new DateTime(2026, 5, 9, 16, 17, 31, 976, DateTimeKind.Utc).AddTicks(8015), new DateTime(2026, 1, 25, 16, 17, 31, 976, DateTimeKind.Utc).AddTicks(8013), new DateTime(2026, 2, 9, 20, 47, 31, 976, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 977, DateTimeKind.Local).AddTicks(87), new DateTime(2026, 1, 20, 16, 17, 31, 977, DateTimeKind.Utc).AddTicks(74), new DateTime(2026, 2, 9, 20, 47, 31, 977, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 977, DateTimeKind.Local).AddTicks(9144), new DateTime(2026, 2, 9, 20, 47, 31, 977, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1068), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 979, DateTimeKind.Local).AddTicks(5256), new DateTime(2026, 2, 9, 20, 47, 31, 979, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 979, DateTimeKind.Local).AddTicks(8191), new DateTime(2026, 2, 9, 20, 47, 31, 979, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(921), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(966), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(980), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(990), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(999), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1057), new DateTime(2026, 2, 9, 20, 47, 31, 980, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(778), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1691), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1703), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1705), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1706), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1718), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1719), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1721), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1722), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1725), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1747), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1750), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1751), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(1753), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6044), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(6063), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7071), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7073), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7074), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7076), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7077), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7082), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6986), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(6996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6999), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7021), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7029), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7030), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7034), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7036), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7038), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7064), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7066), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7068), new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 409, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 20, 47, 33, 409, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 411, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5041), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(2605), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(3948), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(4980), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5010), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5025), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 16, 17, 33, 412, DateTimeKind.Unspecified).AddTicks(5029), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
