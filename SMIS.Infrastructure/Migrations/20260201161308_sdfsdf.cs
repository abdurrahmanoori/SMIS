using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopId",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName" },
                values: new object[] { "ce8d93aa-28f7-4456-98e6-8c31483b1e44", "admin@smis.com", "Administrator", "ADMIN@SMIS.COM", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456789", true, "ac05168f-ef06-4ee0-bfb7-778a7101e310", "1", "Main Store" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "UserName" },
                values: new object[] { "e436579e-d058-48b0-87cc-d1bab09606b2", "manager1@smis.com", "John", "Manager", "MANAGER1@SMIS.COM", "MANAGER1", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456790", true, "846b79f2-bfae-4211-a7d7-b428938cc15d", "1", "Main Store", "manager1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "3", 0, "cd24a5db-bbca-42d1-bffa-eb28e7bb2009", "staff1@smis.com", true, "Unchanged", "Jane", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "STAFF1@SMIS.COM", "STAFF1", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456791", true, "ed1ccd9a-55fe-4554-b937-b9f6d79b77f5", "1", "Main Store", false, "staff1", 0 },
                    { "4", 0, "002aed97-1639-4ad4-936e-ae39e3c44d9e", "manager2@smis.com", true, "Unchanged", "Mike", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "MANAGER2@SMIS.COM", "MANAGER2", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456792", true, "47b1a85b-1cc6-4cdf-b7aa-6be5affa9ef2", "2", "Branch Store", false, "manager2", 0 },
                    { "5", 0, "30c242cd-fad9-4833-9c63-f1cb6e20a9cc", "staff2@smis.com", true, "Unchanged", "Sarah", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "STAFF2@SMIS.COM", "STAFF2", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456793", true, "da31e707-f934-4402-88b4-a98145b4b84b", "2", "Branch Store", false, "staff2", 0 },
                    { "6", 0, "4edd3563-14f4-45f4-969b-13212cb7582b", "warehouse1@smis.com", true, "Unchanged", "David", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Keeper", false, null, "WAREHOUSE1@SMIS.COM", "WAREHOUSE1", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456794", true, "018f2fef-75e4-4815-95ec-26672a0bbf3f", "3", "Warehouse", false, "warehouse1", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(8615), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Unspecified).AddTicks(8651), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3571), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Unspecified).AddTicks(3578), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3608), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Unspecified).AddTicks(3610), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3614), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3620), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3625), new DateTimeOffset(new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 905, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(9572), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(9589), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 891, DateTimeKind.Local).AddTicks(210), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 891, DateTimeKind.Unspecified).AddTicks(223), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 891, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 891, DateTimeKind.Local).AddTicks(225), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 891, DateTimeKind.Unspecified).AddTicks(231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 891, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 888, DateTimeKind.Unspecified).AddTicks(2126), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 888, DateTimeKind.Unspecified).AddTicks(3088), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 888, DateTimeKind.Unspecified).AddTicks(3100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 897, DateTimeKind.Local).AddTicks(5754), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 897, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 897, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4017), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(4025), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4069), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(4075), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4115), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(4125), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4163), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(4169), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4206), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(4212), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4249), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(4255), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4292), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(4298), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 902, DateTimeKind.Local).AddTicks(7155), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 902, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 902, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(729), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(745), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3627), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(3654), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3720), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(3728), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3767), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(3774), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3811), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3853), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3896), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 903, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 903, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 879, DateTimeKind.Unspecified).AddTicks(668), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4194), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4199), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4208), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4224), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4230), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4234), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4243), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4248), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4253), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4261), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4274), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4282), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4286), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4291), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4143), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4304), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4154), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4175), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 880, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(5659), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7144), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7111), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7116), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7120), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7125), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7135), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(7140), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(4002), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(4022), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(4432), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(4448), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(4455), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 890, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 890, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 893, DateTimeKind.Local).AddTicks(563), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 893, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 893, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 895, DateTimeKind.Local).AddTicks(1611), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 895, DateTimeKind.Unspecified).AddTicks(1635), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 895, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 895, DateTimeKind.Local).AddTicks(2611), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 895, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 895, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 881, DateTimeKind.Local).AddTicks(6761), new DateTime(2026, 8, 1, 16, 13, 6, 881, DateTimeKind.Utc).AddTicks(992), new DateTime(2026, 1, 22, 16, 13, 6, 881, DateTimeKind.Utc).AddTicks(715), new DateTime(2026, 2, 1, 20, 43, 6, 882, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 884, DateTimeKind.Local).AddTicks(3065), new DateTime(2026, 9, 1, 16, 13, 6, 884, DateTimeKind.Utc).AddTicks(3001), new DateTime(2026, 1, 27, 16, 13, 6, 884, DateTimeKind.Utc).AddTicks(2998), new DateTime(2026, 2, 1, 20, 43, 6, 884, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 884, DateTimeKind.Local).AddTicks(8376), new DateTime(2026, 5, 1, 16, 13, 6, 884, DateTimeKind.Utc).AddTicks(8307), new DateTime(2026, 1, 17, 16, 13, 6, 884, DateTimeKind.Utc).AddTicks(8296), new DateTime(2026, 2, 1, 20, 43, 6, 884, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 885, DateTimeKind.Local).AddTicks(862), new DateTime(2026, 1, 12, 16, 13, 6, 885, DateTimeKind.Utc).AddTicks(835), new DateTime(2026, 2, 1, 20, 43, 6, 885, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 885, DateTimeKind.Local).AddTicks(9824), new DateTime(2026, 2, 1, 20, 43, 6, 885, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8425), new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(3015), new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(6051), new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8128), new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8195), new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8296), new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8333), new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8363), new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8395), new DateTime(2026, 2, 1, 20, 43, 6, 887, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 888, DateTimeKind.Local).AddTicks(8359), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 888, DateTimeKind.Unspecified).AddTicks(9079), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 888, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(328), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(346), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(351), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(354), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(362), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(370), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(377), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(385), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(397), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(5517), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(5538), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6573), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6579), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6641), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6647), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6650), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6656), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6500), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6513), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6516), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6521), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6523), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6529), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6531), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6536), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6538), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6543), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6545), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6551), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6552), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6564), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6566), new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 889, DateTimeKind.Unspecified).AddTicks(6571), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 20, 43, 6, 889, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 891, DateTimeKind.Unspecified).AddTicks(5357), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 892, DateTimeKind.Unspecified).AddTicks(5775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 892, DateTimeKind.Unspecified).AddTicks(3555), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 892, DateTimeKind.Unspecified).AddTicks(4856), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 892, DateTimeKind.Unspecified).AddTicks(5671), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 892, DateTimeKind.Unspecified).AddTicks(5703), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 892, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 892, DateTimeKind.Unspecified).AddTicks(5730), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 892, DateTimeKind.Unspecified).AddTicks(5742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 16, 13, 6, 892, DateTimeKind.Unspecified).AddTicks(5762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShopId",
                table: "AspNetUsers",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Shop_ShopId",
                table: "AspNetUsers",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Shop_ShopId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ShopId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "d1b4fdeb-15ff-42e0-a61f-5c88b189bce0", "admin@local", "Admin", "ADMIN@LOCAL", "AQAAAAIAAYagAAAAELeKg4ouDxhvCPD/bPCUqIZz4aHDLxAIFIhWqMkfJ64doBXks4S15WOud4W9PxeIlQ==", null, false, "admin-seed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "UserName" },
                values: new object[] { "4b785a0e-0e86-423f-a4a2-11d6d7bccd41", "user@local", "Default", "User", "USER@LOCAL", "USER", "AQAAAAIAAYagAAAAEASAee8634LSvKHAyKRwml62dl11TTMfXOaRD/4Bq13wixIFOytB30IN1bYmm/67zg==", null, false, "user-seed", "user" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(4485), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Unspecified).AddTicks(4532), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(551), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(560), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(587), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(588), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(590), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(590), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(591), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(592), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(593), new DateTimeOffset(new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Unspecified).AddTicks(593), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 172, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(206), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 151, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(652), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 151, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(661), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 151, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 151, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 146, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 146, DateTimeKind.Unspecified).AddTicks(4043), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 146, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 167, DateTimeKind.Local).AddTicks(8703), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 167, DateTimeKind.Unspecified).AddTicks(8748), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 167, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(900), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(908), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(916), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(925), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(936), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(940), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(945), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(949), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(955), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(958), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(964), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(968), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 169, DateTimeKind.Local).AddTicks(8088), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 169, DateTimeKind.Unspecified).AddTicks(8134), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 169, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 169, DateTimeKind.Local).AddTicks(9765), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 169, DateTimeKind.Unspecified).AddTicks(9776), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 169, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(817), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(841), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(845), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(858), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(870), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(874), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(880), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(884), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(890), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 170, DateTimeKind.Unspecified).AddTicks(894), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 170, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(5181), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9862), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9866), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9881), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9885), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9903), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9912), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9916), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9920), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9932), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9936), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9941), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9950), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9954), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9843), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9848), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 137, DateTimeKind.Unspecified).AddTicks(9857), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(4321), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6362), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6365), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6321), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6331), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6346), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6349), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6352), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6354), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(6357), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(1488), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2328), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(2345), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2348), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(2352), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2354), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 150, DateTimeKind.Unspecified).AddTicks(2356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 150, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 153, DateTimeKind.Local).AddTicks(478), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 153, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 153, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 166, DateTimeKind.Local).AddTicks(8552), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 166, DateTimeKind.Unspecified).AddTicks(8615), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 166, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 166, DateTimeKind.Local).AddTicks(9682), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 166, DateTimeKind.Unspecified).AddTicks(9694), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 166, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 138, DateTimeKind.Local).AddTicks(6960), new DateTime(2026, 8, 1, 12, 56, 12, 138, DateTimeKind.Utc).AddTicks(2878), new DateTime(2026, 1, 22, 12, 56, 12, 138, DateTimeKind.Utc).AddTicks(2810), new DateTime(2026, 2, 1, 17, 26, 12, 139, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 141, DateTimeKind.Local).AddTicks(2241), new DateTime(2026, 9, 1, 12, 56, 12, 141, DateTimeKind.Utc).AddTicks(2147), new DateTime(2026, 1, 27, 12, 56, 12, 141, DateTimeKind.Utc).AddTicks(2141), new DateTime(2026, 2, 1, 17, 26, 12, 141, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 141, DateTimeKind.Local).AddTicks(8998), new DateTime(2026, 5, 1, 12, 56, 12, 141, DateTimeKind.Utc).AddTicks(8919), new DateTime(2026, 1, 17, 12, 56, 12, 141, DateTimeKind.Utc).AddTicks(8911), new DateTime(2026, 2, 1, 17, 26, 12, 141, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 142, DateTimeKind.Local).AddTicks(1548), new DateTime(2026, 1, 12, 12, 56, 12, 142, DateTimeKind.Utc).AddTicks(1502), new DateTime(2026, 2, 1, 17, 26, 12, 142, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 143, DateTimeKind.Local).AddTicks(1570), new DateTime(2026, 2, 1, 17, 26, 12, 143, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4502), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 144, DateTimeKind.Local).AddTicks(7198), new DateTime(2026, 2, 1, 17, 26, 12, 144, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(818), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4328), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4436), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4451), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4465), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4476), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4490), new DateTime(2026, 2, 1, 17, 26, 12, 145, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(1884), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(2743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5912), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(5970), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5973), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(5977), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5978), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(5991), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5992), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(5996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5997), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(6001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(6002), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(6006), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(6007), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 147, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 147, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(5934), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(6024), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7337), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7342), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7344), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7349), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7350), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7216), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7234), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7241), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7249), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7291), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7292), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7299), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7305), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7330), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7331), new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 148, DateTimeKind.Unspecified).AddTicks(7336), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 17, 26, 12, 148, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 151, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(4171), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5074), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5099), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5118), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 1, 12, 56, 12, 152, DateTimeKind.Unspecified).AddTicks(5124), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
