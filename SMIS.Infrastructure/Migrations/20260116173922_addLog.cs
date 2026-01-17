using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Level = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    Exception = table.Column<string>(type: "TEXT", nullable: true),
                    Properties = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ffa29746-9a09-4c4e-b4c2-cb24ba71c05b", "AQAAAAIAAYagAAAAEJX01M2CG7C0LHQ60DetMBeQLb26NpdanH3tRx67Pbrkg+fi37uiphaN1jm4yhGc8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b015644-adff-45b0-ba06-c5b86fb8d530", "AQAAAAIAAYagAAAAEHqFo3n5y5knOzXm9c/FXBoqSf8ktS95fehnKvipCi1e2bv2ORaAc7LPsiaDuhlQRA==" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicId",
                value: "26fb2f48-1455-4550-8469-c69453b604f6");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: "a165ae3d-d95e-44f4-9653-fde5d21811c5");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicId",
                value: "515929d1-3c6a-45ba-baec-24c5ac548046");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicId",
                value: "c568b3b3-dc02-4b7e-b8b4-037f7ca779d3");

            migrationBuilder.CreateIndex(
                name: "IX_AppLogs_CreatedAt",
                table: "AppLogs",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AppLogs_Level",
                table: "AppLogs",
                column: "Level");

            migrationBuilder.CreateIndex(
                name: "IX_AppLogs_UserId",
                table: "AppLogs",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppLogs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c885327-4d29-4764-9158-293d628f1848", "AQAAAAIAAYagAAAAEAwsHlVvjp5ufMHjS+n3+b//c/ms1YvfeAxn6ik/brKNkW3AHTOLX9xYlqFSYpWjSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e50ecd89-5d34-4941-b308-c40ae608c976", "AQAAAAIAAYagAAAAED9+yDp5byfzGEmM28Io1QMU+m1X53VXr3p0TJ0umheJ2VuHlfL9WYbZCsHPvCSZvA==" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicId",
                value: "3c247f4f-eb5c-4cf3-bbf2-ef935f9202aa");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: "94a9b785-371d-4eb2-8b6e-874bebae9f2d");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicId",
                value: "0c67327b-7848-410b-9f02-94d68b17166d");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicId",
                value: "8abc44c2-b91f-47bb-a84b-526562fb9eaf");
        }
    }
}
