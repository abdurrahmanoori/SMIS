using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class se : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Provinces",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Provinces",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Provinces",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Provinces",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Districts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Districts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Districts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf2d2e7c-0273-41b0-ae2f-de68232d4dc8", "AQAAAAIAAYagAAAAEP5Y4fNb19Lk6XiFTl69WmVwqa155pER8ifMvj5DzJHnbwHLueSt15WZkVgyYWi8zw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0ccd321-de5c-4ddd-b3e4-a654cf14de0f", "AQAAAAIAAYagAAAAEHV5GS511kzX/LQxJZWY/4marXqLjkpkaRHQhQcz8o9x8x3GFY5jmyz/7b2T1DaAyg==" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "PublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(2032), "a5cd8883-b785-4ea1-af98-b7da4a656e7a", null, new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "PublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9444), "41d70769-fbf0-4340-aa68-4561ffabd2a4", null, new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "PublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9451), "3295dc23-9bd5-4b47-bca1-576e530e3522", null, new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "PublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9461), "e868839c-0c1f-47df-a8c3-6e72bc5b3e27", null, new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9461) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Districts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38ef7a94-0202-4a28-8b83-57e2d66169f6", "AQAAAAIAAYagAAAAEJH1YGiKn8GXWn642b7GV21lk6zN/glF5ksqIK6NadHGTG/0jP2nhCs1EpnP4CyRWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "742671df-a2ab-49f7-a85a-381ed7e25bfe", "AQAAAAIAAYagAAAAEEtPASPf2tSCh1G6VEoig+acAaHIG3SU+0i710cSkAB/iRsUREUPS1U5mVWPNJsJYw==" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicId",
                value: "cad27c1f-be9f-4e2b-93e1-a8f6c11bebae");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: "1fb591d6-4f2e-4929-994d-2ba092a67ac7");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicId",
                value: "8864d9fb-18db-4a55-b1fd-3e2169134a3b");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicId",
                value: "580950a2-5b84-4cae-a1f5-a604bfbc917a");
        }
    }
}
