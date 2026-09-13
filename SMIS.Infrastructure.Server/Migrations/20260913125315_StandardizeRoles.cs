using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class StandardizeRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var legacyRoleIds = new[]
            {
                "33333333-0000-0000-0000-000000000009",
                "33333333-0000-0000-0000-000000000010",
                "33333333-0000-0000-0000-000000000011",
                "33333333-0000-0000-0000-000000000012",
                "33333333-0000-0000-0000-000000000013",
                "33333333-0000-0000-0000-000000000014",
                "33333333-0000-0000-0000-000000000015",
                "33333333-0000-0000-0000-000000000016"
            };

            var legacyUserIds = new[]
            {
                "44444444-0000-0000-0000-000000000009",
                "44444444-0000-0000-0000-000000000010",
                "44444444-0000-0000-0000-000000000011",
                "44444444-0000-0000-0000-000000000012",
                "44444444-0000-0000-0000-000000000013",
                "44444444-0000-0000-0000-000000000014",
                "44444444-0000-0000-0000-000000000015",
                "44444444-0000-0000-0000-000000000016"
            };

            for (var i = 0; i < legacyRoleIds.Length; i++)
            {
                migrationBuilder.DeleteData(
                    table: "AspNetUserRoles",
                    keyColumns: new[] { "RoleId", "UserId" },
                    keyValues: new object[] { legacyRoleIds[i], legacyUserIds[i] });
            }

            foreach (var roleId in legacyRoleIds)
            {
                migrationBuilder.DeleteData(
                    table: "AspNetRoles",
                    keyColumn: "Id",
                    keyValue: roleId);
            }

            var canonicalRoles = new[]
            {
                new { Id = "33333333-0000-0000-0000-000000000002", Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = "33333333-0000-0000-0000-000000000003", Name = "Administration", NormalizedName = "ADMINISTRATION" },
                new { Id = "33333333-0000-0000-0000-000000000004", Name = "Manager", NormalizedName = "MANAGER" },
                new { Id = "33333333-0000-0000-0000-000000000005", Name = "Staff", NormalizedName = "STAFF" },
                new { Id = "33333333-0000-0000-0000-000000000006", Name = "Viewer", NormalizedName = "VIEWER" },
                new { Id = "33333333-0000-0000-0000-000000000007", Name = "Editor", NormalizedName = "EDITOR" },
                new { Id = "33333333-0000-0000-0000-000000000008", Name = "User", NormalizedName = "USER" }
            };

            foreach (var role in canonicalRoles)
            {
                migrationBuilder.UpdateData(
                    table: "AspNetRoles",
                    keyColumn: "Id",
                    keyValue: role.Id,
                    columns: new[] { "Name", "NormalizedName" },
                    values: new object[] { role.Name, role.NormalizedName });
            }

            var canonicalSeedAssignments = new[]
            {
                new { UserId = "44444444-0000-0000-0000-000000000002", RoleId = canonicalRoles[0].Id, RoleName = canonicalRoles[0].Name, UserName = "wadmin" },
                new { UserId = "44444444-0000-0000-0000-000000000003", RoleId = canonicalRoles[1].Id, RoleName = canonicalRoles[1].Name, UserName = "wadministration" },
                new { UserId = "44444444-0000-0000-0000-000000000004", RoleId = canonicalRoles[2].Id, RoleName = canonicalRoles[2].Name, UserName = "wmanager" },
                new { UserId = "44444444-0000-0000-0000-000000000005", RoleId = canonicalRoles[3].Id, RoleName = canonicalRoles[3].Name, UserName = "wstaff" },
                new { UserId = "44444444-0000-0000-0000-000000000006", RoleId = canonicalRoles[4].Id, RoleName = canonicalRoles[4].Name, UserName = "wviewer" },
                new { UserId = "44444444-0000-0000-0000-000000000007", RoleId = canonicalRoles[5].Id, RoleName = canonicalRoles[5].Name, UserName = "weditor" },
                new { UserId = "44444444-0000-0000-0000-000000000008", RoleId = canonicalRoles[6].Id, RoleName = canonicalRoles[6].Name, UserName = "wuser" }
            };

            foreach (var assignment in canonicalSeedAssignments)
            {
                migrationBuilder.UpdateData(
                    table: "AspNetUserRoles",
                    keyColumns: new[] { "RoleId", "UserId" },
                    keyValues: new object[] { assignment.RoleId, assignment.UserId },
                    column: "RoleName",
                    value: assignment.RoleName);
            }

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "RoleName", "UserName" },
                values: new object[,]
                {
                    { canonicalRoles[0].Id, legacyUserIds[0], canonicalRoles[0].Name, "radmin" },
                    { canonicalRoles[1].Id, legacyUserIds[1], canonicalRoles[1].Name, "radministration" },
                    { canonicalRoles[2].Id, legacyUserIds[2], canonicalRoles[2].Name, "rmanager" },
                    { canonicalRoles[3].Id, legacyUserIds[3], canonicalRoles[3].Name, "rstaff" },
                    { canonicalRoles[4].Id, legacyUserIds[4], canonicalRoles[4].Name, "rviewer" },
                    { canonicalRoles[5].Id, legacyUserIds[5], canonicalRoles[5].Name, "reditor" },
                    { canonicalRoles[6].Id, legacyUserIds[6], canonicalRoles[6].Name, "ruser" },
                    { canonicalRoles[0].Id, legacyUserIds[7], canonicalRoles[0].Name, "wasil" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var canonicalRoleIds = new[]
            {
                "33333333-0000-0000-0000-000000000002",
                "33333333-0000-0000-0000-000000000003",
                "33333333-0000-0000-0000-000000000004",
                "33333333-0000-0000-0000-000000000005",
                "33333333-0000-0000-0000-000000000006",
                "33333333-0000-0000-0000-000000000007",
                "33333333-0000-0000-0000-000000000008"
            };

            var legacyUserIds = new[]
            {
                "44444444-0000-0000-0000-000000000009",
                "44444444-0000-0000-0000-000000000010",
                "44444444-0000-0000-0000-000000000011",
                "44444444-0000-0000-0000-000000000012",
                "44444444-0000-0000-0000-000000000013",
                "44444444-0000-0000-0000-000000000014",
                "44444444-0000-0000-0000-000000000015",
                "44444444-0000-0000-0000-000000000016"
            };

            var canonicalRoleIdsForLegacyUsers = new[]
            {
                canonicalRoleIds[0],
                canonicalRoleIds[1],
                canonicalRoleIds[2],
                canonicalRoleIds[3],
                canonicalRoleIds[4],
                canonicalRoleIds[5],
                canonicalRoleIds[6],
                canonicalRoleIds[0]
            };

            for (var i = 0; i < legacyUserIds.Length; i++)
            {
                migrationBuilder.DeleteData(
                    table: "AspNetUserRoles",
                    keyColumns: new[] { "RoleId", "UserId" },
                    keyValues: new object[] { canonicalRoleIdsForLegacyUsers[i], legacyUserIds[i] });
            }

            var wholesaleRoleNames = new[]
            {
                "WShopAdmin",
                "WShopAdministration",
                "WShopManager",
                "WShopStaff",
                "WShopViewer",
                "WShopEditor",
                "WShopUser"
            };

            for (var i = 0; i < canonicalRoleIds.Length; i++)
            {
                migrationBuilder.UpdateData(
                    table: "AspNetRoles",
                    keyColumn: "Id",
                    keyValue: canonicalRoleIds[i],
                    columns: new[] { "Name", "NormalizedName" },
                    values: new object[] { wholesaleRoleNames[i], wholesaleRoleNames[i].ToUpperInvariant() });

                migrationBuilder.UpdateData(
                    table: "AspNetUserRoles",
                    keyColumns: new[] { "RoleId", "UserId" },
                    keyValues: new object[] { canonicalRoleIds[i], $"44444444-0000-0000-0000-00000000000{i + 2}" },
                    column: "RoleName",
                    value: wholesaleRoleNames[i]);
            }

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "EntityState", "LastModifiedUtc", "Name", "NormalizedName", "Version" },
                values: new object[,]
                {
                    { "33333333-0000-0000-0000-000000000009", "Unchanged", "0001-01-01 00:00:00.000000", "RShopAdmin", "RSHOPADMIN", 0 },
                    { "33333333-0000-0000-0000-000000000010", "Unchanged", "0001-01-01 00:00:00.000000", "RShopAdministration", "RSHOPADMINISTRATION", 0 },
                    { "33333333-0000-0000-0000-000000000011", "Unchanged", "0001-01-01 00:00:00.000000", "RShopManager", "RSHOPMANAGER", 0 },
                    { "33333333-0000-0000-0000-000000000012", "Unchanged", "0001-01-01 00:00:00.000000", "RShopStaff", "RSHOPSTAFF", 0 },
                    { "33333333-0000-0000-0000-000000000013", "Unchanged", "0001-01-01 00:00:00.000000", "RShopViewer", "RSHOPVIEWER", 0 },
                    { "33333333-0000-0000-0000-000000000014", "Unchanged", "0001-01-01 00:00:00.000000", "RShopEditor", "RSHOPEDITOR", 0 },
                    { "33333333-0000-0000-0000-000000000015", "Unchanged", "0001-01-01 00:00:00.000000", "RShopUser", "RSHOPUSER", 0 },
                    { "33333333-0000-0000-0000-000000000016", "Unchanged", "0001-01-01 00:00:00.000000", "WasilShopAdmin", "WASILSHOPADMIN", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "RoleName", "UserName" },
                values: new object[,]
                {
                    { "33333333-0000-0000-0000-000000000009", legacyUserIds[0], "RShopAdmin", "radmin" },
                    { "33333333-0000-0000-0000-000000000010", legacyUserIds[1], "RShopAdministration", "radministration" },
                    { "33333333-0000-0000-0000-000000000011", legacyUserIds[2], "RShopManager", "rmanager" },
                    { "33333333-0000-0000-0000-000000000012", legacyUserIds[3], "RShopStaff", "rstaff" },
                    { "33333333-0000-0000-0000-000000000013", legacyUserIds[4], "RShopViewer", "rviewer" },
                    { "33333333-0000-0000-0000-000000000014", legacyUserIds[5], "RShopEditor", "reditor" },
                    { "33333333-0000-0000-0000-000000000015", legacyUserIds[6], "RShopUser", "ruser" },
                    { "33333333-0000-0000-0000-000000000016", legacyUserIds[7], "WasilShopAdmin", "wasil" }
                });
        }
    }
}
