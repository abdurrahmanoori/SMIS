using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000001",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000004",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000005",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000006",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000011",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000012",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000013",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000016",
                column: "IsActive",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");
        }
    }
}
