using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddDistrictProvinceRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProvinceId",
                table: "Districts",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000001",
                column: "ProvinceId",
                value: "77777777-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000002",
                column: "ProvinceId",
                value: "77777777-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "99999999-0000-0000-0000-000000000003",
                column: "ProvinceId",
                value: "77777777-0000-0000-0000-000000000002");

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceId",
                table: "Districts",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId",
                table: "Districts",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Provinces_ProvinceId",
                table: "Districts",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Provinces_ProvinceId",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_ProvinceId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Districts");
        }
    }
}
