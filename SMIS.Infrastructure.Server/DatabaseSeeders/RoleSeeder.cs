using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders
{
    public static class RoleSeeder
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole { Id = SeedIds.RoleSuperAdmin,          Name = SD.Role_Super_Admin,        NormalizedName = SD.Role_Super_Admin.ToUpper() },

                // Wholesale Shop Roles
                new ApplicationRole { Id = SeedIds.RoleWShopAdmin,          Name = SD.Role_WShop_Admin,        NormalizedName = SD.Role_WShop_Admin.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleWShopAdministration, Name = SD.Role_WShop_Administration, NormalizedName = SD.Role_WShop_Administration.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleWShopManager,        Name = SD.Role_WShop_Manager,      NormalizedName = SD.Role_WShop_Manager.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleWShopStaff,          Name = SD.Role_WShop_Staff,        NormalizedName = SD.Role_WShop_Staff.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleWShopViewer,         Name = SD.Role_WShop_Viewer,       NormalizedName = SD.Role_WShop_Viewer.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleWShopEditor,         Name = SD.Role_WShop_Editor,       NormalizedName = SD.Role_WShop_Editor.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleWShopUser,           Name = SD.Role_WShop_User,         NormalizedName = SD.Role_WShop_User.ToUpper() },

                // Retail Shop Roles
                new ApplicationRole { Id = SeedIds.RoleRShopAdmin,          Name = SD.Role_RShop_Admin,        NormalizedName = SD.Role_RShop_Admin.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleRShopAdministration, Name = SD.Role_RShop_Administration, NormalizedName = SD.Role_RShop_Administration.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleRShopManager,        Name = SD.Role_RShop_Manager,      NormalizedName = SD.Role_RShop_Manager.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleRShopStaff,          Name = SD.Role_RShop_Staff,        NormalizedName = SD.Role_RShop_Staff.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleRShopViewer,         Name = SD.Role_RShop_Viewer,       NormalizedName = SD.Role_RShop_Viewer.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleRShopEditor,         Name = SD.Role_RShop_Editor,       NormalizedName = SD.Role_RShop_Editor.ToUpper() },
                new ApplicationRole { Id = SeedIds.RoleRShopUser,           Name = SD.Role_RShop_User,         NormalizedName = SD.Role_RShop_User.ToUpper() }
            );
        }
    }
}
