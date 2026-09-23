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
                // Main Store
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserSuperAdmin, RoleId = SeedIds.RoleSuperAdmin,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Super_Admin, SeedIds.Shop1),
                    RoleName = SD.Role_Super_Admin
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainAdmin, RoleId = SeedIds.RoleAdmin,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Admin, SeedIds.Shop1),
                    RoleName = SD.Role_Admin
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainAdministration, RoleId = SeedIds.RoleAdministration,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Administration, SeedIds.Shop1),
                    RoleName = SD.Role_Administration
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainManager, RoleId = SeedIds.RoleManager,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Manager, SeedIds.Shop1),
                    RoleName = SD.Role_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainStaff, RoleId = SeedIds.RoleStaff,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Staff, SeedIds.Shop1),
                    RoleName = SD.Role_Staff
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainViewer, RoleId = SeedIds.RoleViewer,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Viewer, SeedIds.Shop1),
                    RoleName = SD.Role_Viewer
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainEditor, RoleId = SeedIds.RoleEditor,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Editor, SeedIds.Shop1),
                    RoleName = SD.Role_Editor
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainUser, RoleId = SeedIds.RoleUser,
                    UserName = UserSeed.GetSeedEmail(SD.Role_User, SeedIds.Shop1), RoleName = SD.Role_User
                },

                // Branch Store
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchAdmin, RoleId = SeedIds.RoleAdmin,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Admin, SeedIds.Shop2),
                    RoleName = SD.Role_Admin
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchAdministration, RoleId = SeedIds.RoleAdministration,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Administration, SeedIds.Shop2),
                    RoleName = SD.Role_Administration
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchManager, RoleId = SeedIds.RoleManager,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Manager, SeedIds.Shop2),
                    RoleName = SD.Role_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchStaff, RoleId = SeedIds.RoleStaff,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Staff, SeedIds.Shop2),
                    RoleName = SD.Role_Staff
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchViewer, RoleId = SeedIds.RoleViewer,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Viewer, SeedIds.Shop2),
                    RoleName = SD.Role_Viewer
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchEditor, RoleId = SeedIds.RoleEditor,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Editor, SeedIds.Shop2),
                    RoleName = SD.Role_Editor
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchUser, RoleId = SeedIds.RoleUser,
                    UserName = UserSeed.GetSeedEmail(SD.Role_User, SeedIds.Shop2), RoleName = SD.Role_User
                },

                // Wasil Shop
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWasilAdmin, RoleId = SeedIds.RoleAdmin,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Admin, SeedIds.ShopWasil), RoleName = SD.Role_Admin
                }
            );
        }
    }
}