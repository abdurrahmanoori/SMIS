using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders
{
    public static class UserRoleSeeder
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUserRole>().HasData(
                // SuperAdmin
                new ApplicationUserRole { UserId = SeedIds.UserSuperAdmin,      RoleId = SeedIds.RoleSuperAdmin,          UserName = "superadmin",      RoleName = SD.Role_Super_Admin },

                // Wholesale Shop Users
                new ApplicationUserRole { UserId = SeedIds.UserWAdmin,          RoleId = SeedIds.RoleWShopAdmin,          UserName = "wadmin",          RoleName = SD.Role_WShop_Admin },
                new ApplicationUserRole { UserId = SeedIds.UserWAdministration, RoleId = SeedIds.RoleWShopAdministration, UserName = "wadministration", RoleName = SD.Role_WShop_Administration },
                new ApplicationUserRole { UserId = SeedIds.UserWManager,        RoleId = SeedIds.RoleWShopManager,        UserName = "wmanager",        RoleName = SD.Role_WShop_Manager },
                new ApplicationUserRole { UserId = SeedIds.UserWStaff,          RoleId = SeedIds.RoleWShopStaff,          UserName = "wstaff",          RoleName = SD.Role_WShop_Staff },
                new ApplicationUserRole { UserId = SeedIds.UserWViewer,         RoleId = SeedIds.RoleWShopViewer,         UserName = "wviewer",         RoleName = SD.Role_WShop_Viewer },
                new ApplicationUserRole { UserId = SeedIds.UserWEditor,         RoleId = SeedIds.RoleWShopEditor,         UserName = "weditor",         RoleName = SD.Role_WShop_Editor },
                new ApplicationUserRole { UserId = SeedIds.UserWUser,           RoleId = SeedIds.RoleWShopUser,           UserName = "wuser",           RoleName = SD.Role_WShop_User },

                // Retail Shop Users
                new ApplicationUserRole { UserId = SeedIds.UserRAdmin,          RoleId = SeedIds.RoleRShopAdmin,          UserName = "radmin",          RoleName = SD.Role_RShop_Admin },
                new ApplicationUserRole { UserId = SeedIds.UserRAdministration, RoleId = SeedIds.RoleRShopAdministration, UserName = "radministration", RoleName = SD.Role_RShop_Administration },
                new ApplicationUserRole { UserId = SeedIds.UserRManager,        RoleId = SeedIds.RoleRShopManager,        UserName = "rmanager",        RoleName = SD.Role_RShop_Manager },
                new ApplicationUserRole { UserId = SeedIds.UserRStaff,          RoleId = SeedIds.RoleRShopStaff,          UserName = "rstaff",          RoleName = SD.Role_RShop_Staff },
                new ApplicationUserRole { UserId = SeedIds.UserRViewer,         RoleId = SeedIds.RoleRShopViewer,         UserName = "rviewer",         RoleName = SD.Role_RShop_Viewer },
                new ApplicationUserRole { UserId = SeedIds.UserREditor,         RoleId = SeedIds.RoleRShopEditor,         UserName = "reditor",         RoleName = SD.Role_RShop_Editor },
                new ApplicationUserRole { UserId = SeedIds.UserRUser,           RoleId = SeedIds.RoleRShopUser,           UserName = "ruser",           RoleName = SD.Role_RShop_User }
            );
        }
    }
}
