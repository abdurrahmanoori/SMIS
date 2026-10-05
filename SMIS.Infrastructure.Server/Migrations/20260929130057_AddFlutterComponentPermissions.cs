using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddFlutterComponentPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationComponents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Key = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    ShowInMenu = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationComponents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleComponentPermissions",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ComponentId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CanView = table.Column<bool>(type: "bit", nullable: false),
                    CanRead = table.Column<bool>(type: "bit", nullable: false),
                    CanCreate = table.Column<bool>(type: "bit", nullable: false),
                    CanUpdate = table.Column<bool>(type: "bit", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleComponentPermissions", x => new { x.RoleId, x.ComponentId });
                    table.ForeignKey(
                        name: "FK_RoleComponentPermissions_ApplicationComponents_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "ApplicationComponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleComponentPermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ApplicationComponents",
                columns: new[] { "Id", "DisplayOrder", "IsActive", "Key", "Name", "ShowInMenu" },
                values: new object[,]
                {
                    { "55555555-0000-0000-0000-000000000001", 1, true, "Shops", "Shops", true },
                    { "55555555-0000-0000-0000-000000000002", 2, true, "UnitsOfMeasure", "Units of measure", true },
                    { "55555555-0000-0000-0000-000000000003", 3, true, "Categories", "Categories", true },
                    { "55555555-0000-0000-0000-000000000004", 4, true, "Products", "Products", true },
                    { "55555555-0000-0000-0000-000000000005", 5, true, "ProductUnits", "Product units", true },
                    { "55555555-0000-0000-0000-000000000006", 6, true, "ProductPrices", "Product prices", true },
                    { "55555555-0000-0000-0000-000000000007", 7, true, "Inventory", "Inventory", true }
                });

            migrationBuilder.InsertData(
                table: "RoleComponentPermissions",
                columns: new[] { "ComponentId", "RoleId", "CanCreate", "CanDelete", "CanRead", "CanUpdate", "CanView" },
                values: new object[,]
                {
                    { "55555555-0000-0000-0000-000000000001", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000002", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000003", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000004", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000005", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000006", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000007", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000001", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000002", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000003", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000004", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000005", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000006", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000007", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000001", "33333333-0000-0000-0000-000000000003", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000002", "33333333-0000-0000-0000-000000000003", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000003", "33333333-0000-0000-0000-000000000003", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000004", "33333333-0000-0000-0000-000000000003", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000005", "33333333-0000-0000-0000-000000000003", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000006", "33333333-0000-0000-0000-000000000003", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000007", "33333333-0000-0000-0000-000000000003", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000001", "33333333-0000-0000-0000-000000000004", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000002", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000003", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000004", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000005", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000006", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000007", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000001", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000002", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000003", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000004", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000005", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000006", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000007", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000001", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000002", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000003", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000004", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000005", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000006", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000007", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000001", "33333333-0000-0000-0000-000000000007", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000002", "33333333-0000-0000-0000-000000000007", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000003", "33333333-0000-0000-0000-000000000007", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000004", "33333333-0000-0000-0000-000000000007", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000005", "33333333-0000-0000-0000-000000000007", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000006", "33333333-0000-0000-0000-000000000007", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000007", "33333333-0000-0000-0000-000000000007", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000001", "33333333-0000-0000-0000-000000000008", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000002", "33333333-0000-0000-0000-000000000008", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000003", "33333333-0000-0000-0000-000000000008", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000004", "33333333-0000-0000-0000-000000000008", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000005", "33333333-0000-0000-0000-000000000008", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000006", "33333333-0000-0000-0000-000000000008", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000007", "33333333-0000-0000-0000-000000000008", false, false, true, false, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationComponents_Key",
                table: "ApplicationComponents",
                column: "Key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleComponentPermissions_ComponentId",
                table: "RoleComponentPermissions",
                column: "ComponentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleComponentPermissions");

            migrationBuilder.DropTable(
                name: "ApplicationComponents");
        }
    }
}
