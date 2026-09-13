using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders
{
    public static class UserRoleSeeder
    {
        public static void DataSeed(
            ModelBuilder modelBuilder
        )
        {
            modelBuilder.Entity<ApplicationUserRole>().HasData(
                // SuperAdmin
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserSuperAdmin, RoleId = SeedIds.RoleSuperAdmin, UserName = "superadmin",
                    RoleName = SD.Role_Super_Admin
                },

                // Wholesale Shop Users
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWAdmin, RoleId = SeedIds.RoleAdmin, UserName = "wadmin",
                    RoleName = SD.Role_Admin
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWAdministration, RoleId = SeedIds.RoleAdministration,
                    UserName = "wadministration", RoleName = SD.Role_Administration
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWManager, RoleId = SeedIds.RoleManager, UserName = "wmanager",
                    RoleName = SD.Role_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWStaff, RoleId = SeedIds.RoleStaff, UserName = "wstaff",
                    RoleName = SD.Role_Staff
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWViewer, RoleId = SeedIds.RoleViewer, UserName = "wviewer",
                    RoleName = SD.Role_Viewer
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWEditor, RoleId = SeedIds.RoleEditor, UserName = "weditor",
                    RoleName = SD.Role_Editor
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWUser, RoleId = SeedIds.RoleUser, UserName = "wuser", RoleName = SD.Role_User
                },

                // Retail Shop Users
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserRAdmin, RoleId = SeedIds.RoleAdmin, UserName = "radmin",
                    RoleName = SD.Role_Admin
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserRAdministration, RoleId = SeedIds.RoleAdministration,
                    UserName = "radministration", RoleName = SD.Role_Administration
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserRManager, RoleId = SeedIds.RoleManager, UserName = "rmanager",
                    RoleName = SD.Role_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserRStaff, RoleId = SeedIds.RoleStaff, UserName = "rstaff",
                    RoleName = SD.Role_Staff
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserRViewer, RoleId = SeedIds.RoleViewer, UserName = "rviewer",
                    RoleName = SD.Role_Viewer
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserREditor, RoleId = SeedIds.RoleEditor, UserName = "reditor",
                    RoleName = SD.Role_Editor
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserRUser, RoleId = SeedIds.RoleUser, UserName = "ruser", RoleName = SD.Role_User
                },

                // Wasil Shop Users
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWasil, RoleId = SeedIds.RoleAdmin, UserName = "wasil", RoleName = SD.Role_Admin
                }
            );
        }
    }
}