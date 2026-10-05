using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoleStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Preserve the specialized seed accounts, but move any other legacy-role
            // memberships to the closest conservative role before the role IDs are
            // repurposed. The current production database only contains seed accounts,
            // so these statements are a safety net for other environments.
            migrationBuilder.Sql("""
                UPDATE dbo.AspNetUserRoles
                SET RoleName = 'ShopAdmin'
                WHERE RoleId = '33333333-0000-0000-0000-000000000002';

                INSERT INTO dbo.AspNetUserRoles (UserId, RoleId, UserName, RoleName)
                SELECT legacy.UserId,
                       '33333333-0000-0000-0000-000000000004',
                       legacy.UserName,
                       'Manager'
                FROM dbo.AspNetUserRoles AS legacy
                WHERE legacy.RoleId = '33333333-0000-0000-0000-000000000003'
                  AND legacy.UserId NOT IN (
                      '44444444-0000-0000-0000-000000000003',
                      '44444444-0000-0000-0000-000000000010')
                  AND NOT EXISTS (
                      SELECT 1
                      FROM dbo.AspNetUserRoles AS existing
                      WHERE existing.UserId = legacy.UserId
                        AND existing.RoleId = '33333333-0000-0000-0000-000000000004');

                DELETE FROM dbo.AspNetUserRoles
                WHERE RoleId = '33333333-0000-0000-0000-000000000003'
                  AND UserId NOT IN (
                      '44444444-0000-0000-0000-000000000003',
                      '44444444-0000-0000-0000-000000000010');

                INSERT INTO dbo.AspNetUserRoles (UserId, RoleId, UserName, RoleName)
                SELECT legacy.UserId,
                       '33333333-0000-0000-0000-000000000005',
                       legacy.UserName,
                       'Staff'
                FROM dbo.AspNetUserRoles AS legacy
                WHERE legacy.RoleId = '33333333-0000-0000-0000-000000000007'
                  AND legacy.UserId NOT IN (
                      '44444444-0000-0000-0000-000000000007',
                      '44444444-0000-0000-0000-000000000014')
                  AND NOT EXISTS (
                      SELECT 1
                      FROM dbo.AspNetUserRoles AS existing
                      WHERE existing.UserId = legacy.UserId
                        AND existing.RoleId = '33333333-0000-0000-0000-000000000005');

                DELETE FROM dbo.AspNetUserRoles
                WHERE RoleId = '33333333-0000-0000-0000-000000000007'
                  AND UserId NOT IN (
                      '44444444-0000-0000-0000-000000000007',
                      '44444444-0000-0000-0000-000000000014');

                INSERT INTO dbo.AspNetUserRoles (UserId, RoleId, UserName, RoleName)
                SELECT legacy.UserId,
                       '33333333-0000-0000-0000-000000000006',
                       legacy.UserName,
                       'Viewer'
                FROM dbo.AspNetUserRoles AS legacy
                WHERE legacy.RoleId = '33333333-0000-0000-0000-000000000008'
                  AND legacy.UserId NOT IN (
                      '44444444-0000-0000-0000-000000000008',
                      '44444444-0000-0000-0000-000000000015')
                  AND NOT EXISTS (
                      SELECT 1
                      FROM dbo.AspNetUserRoles AS existing
                      WHERE existing.UserId = legacy.UserId
                        AND existing.RoleId = '33333333-0000-0000-0000-000000000006');

                DELETE FROM dbo.AspNetUserRoles
                WHERE RoleId = '33333333-0000-0000-0000-000000000008'
                  AND UserId NOT IN (
                      '44444444-0000-0000-0000-000000000008',
                      '44444444-0000-0000-0000-000000000015');
                """);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000002",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "ShopAdmin", "SHOPADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000003",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "InventoryManager", "INVENTORYMANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000007",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "SalesManager", "SALESMANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000008",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Cashier", "CASHIER" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "44444444-0000-0000-0000-000000000002" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "ShopAdmin", "shopadmin@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "44444444-0000-0000-0000-000000000003" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "InventoryManager", "inventorymanager@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "44444444-0000-0000-0000-000000000007" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "SalesManager", "salesmanager@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "44444444-0000-0000-0000-000000000008" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "Cashier", "cashier@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "44444444-0000-0000-0000-000000000009" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "ShopAdmin", "shopadmin@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "44444444-0000-0000-0000-000000000010" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "InventoryManager", "inventorymanager@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "44444444-0000-0000-0000-000000000014" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "SalesManager", "salesmanager@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "44444444-0000-0000-0000-000000000015" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "Cashier", "cashier@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "44444444-0000-0000-0000-000000000016" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "ShopAdmin", "shopadmin@wasilshop.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "shopadmin@mainstore.com", "ShopAdmin", "SHOPADMIN@MAINSTORE.COM", "SHOPADMIN@MAINSTORE.COM", "shopadmin@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "inventorymanager@mainstore.com", "InventoryManager", "INVENTORYMANAGER@MAINSTORE.COM", "INVENTORYMANAGER@MAINSTORE.COM", "inventorymanager@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "salesmanager@mainstore.com", "SalesManager", "SALESMANAGER@MAINSTORE.COM", "SALESMANAGER@MAINSTORE.COM", "salesmanager@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "cashier@mainstore.com", "Cashier", "CASHIER@MAINSTORE.COM", "CASHIER@MAINSTORE.COM", "cashier@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "shopadmin@branchstore.com", "ShopAdmin", "SHOPADMIN@BRANCHSTORE.COM", "SHOPADMIN@BRANCHSTORE.COM", "shopadmin@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "inventorymanager@branchstore.com", "InventoryManager", "INVENTORYMANAGER@BRANCHSTORE.COM", "INVENTORYMANAGER@BRANCHSTORE.COM", "inventorymanager@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "salesmanager@branchstore.com", "SalesManager", "SALESMANAGER@BRANCHSTORE.COM", "SALESMANAGER@BRANCHSTORE.COM", "salesmanager@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "cashier@branchstore.com", "Cashier", "CASHIER@BRANCHSTORE.COM", "CASHIER@BRANCHSTORE.COM", "cashier@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000016",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "shopadmin@wasilshop.com", "ShopAdmin", "SHOPADMIN@WASILSHOP.COM", "SHOPADMIN@WASILSHOP.COM", "shopadmin@wasilshop.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000002",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000003",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Administration", "ADMINISTRATION" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000007",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Editor", "EDITOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33333333-0000-0000-0000-000000000008",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "44444444-0000-0000-0000-000000000002" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "Admin", "admin@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "44444444-0000-0000-0000-000000000003" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "Administration", "administration@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "44444444-0000-0000-0000-000000000007" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "Editor", "editor@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "44444444-0000-0000-0000-000000000008" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "User", "user@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "44444444-0000-0000-0000-000000000009" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "Admin", "admin@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "44444444-0000-0000-0000-000000000010" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "Administration", "administration@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "44444444-0000-0000-0000-000000000014" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "Editor", "editor@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "44444444-0000-0000-0000-000000000015" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "User", "user@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "44444444-0000-0000-0000-000000000016" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "Admin", "admin@wasilshop.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000002",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "admin@mainstore.com", "Admin", "ADMIN@MAINSTORE.COM", "ADMIN@MAINSTORE.COM", "admin@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000003",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "administration@mainstore.com", "Administration", "ADMINISTRATION@MAINSTORE.COM", "ADMINISTRATION@MAINSTORE.COM", "administration@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000007",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "editor@mainstore.com", "Editor", "EDITOR@MAINSTORE.COM", "EDITOR@MAINSTORE.COM", "editor@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000008",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "user@mainstore.com", "User", "USER@MAINSTORE.COM", "USER@MAINSTORE.COM", "user@mainstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000009",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "admin@branchstore.com", "Admin", "ADMIN@BRANCHSTORE.COM", "ADMIN@BRANCHSTORE.COM", "admin@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000010",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "administration@branchstore.com", "Administration", "ADMINISTRATION@BRANCHSTORE.COM", "ADMINISTRATION@BRANCHSTORE.COM", "administration@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000014",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "editor@branchstore.com", "Editor", "EDITOR@BRANCHSTORE.COM", "EDITOR@BRANCHSTORE.COM", "editor@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000015",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "user@branchstore.com", "User", "USER@BRANCHSTORE.COM", "USER@BRANCHSTORE.COM", "user@branchstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-0000-0000-0000-000000000016",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "admin@wasilshop.com", "Admin", "ADMIN@WASILSHOP.COM", "ADMIN@WASILSHOP.COM", "admin@wasilshop.com" });
        }
    }
}
