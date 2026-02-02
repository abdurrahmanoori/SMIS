using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using Microsoft.AspNetCore.Identity;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class UserRoleSeeder
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                // SuperAdmin
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" }, // superadmin -> SuperAdmin
                
                // Wholesale Shop Users
                new IdentityUserRole<string> { UserId = "2", RoleId = "2" }, // wadmin -> WShopAdmin
                new IdentityUserRole<string> { UserId = "3", RoleId = "3" }, // wadministration -> WShopAdministration
                new IdentityUserRole<string> { UserId = "4", RoleId = "4" }, // wmanager -> WShopManager
                new IdentityUserRole<string> { UserId = "5", RoleId = "5" }, // wstaff -> WShopStaff
                new IdentityUserRole<string> { UserId = "6", RoleId = "6" }, // wviewer -> WShopViewer
                new IdentityUserRole<string> { UserId = "7", RoleId = "7" }, // weditor -> WShopEditor
                new IdentityUserRole<string> { UserId = "8", RoleId = "8" }, // wuser -> WShopUser
                
                // Retail Shop Users
                new IdentityUserRole<string> { UserId = "9", RoleId = "9" }, // radmin -> RShopAdmin
                new IdentityUserRole<string> { UserId = "10", RoleId = "10" }, // radministration -> RShopAdministration
                new IdentityUserRole<string> { UserId = "11", RoleId = "11" }, // rmanager -> RShopManager
                new IdentityUserRole<string> { UserId = "12", RoleId = "12" }, // rstaff -> RShopStaff
                new IdentityUserRole<string> { UserId = "13", RoleId = "13" }, // rviewer -> RShopViewer
                new IdentityUserRole<string> { UserId = "14", RoleId = "14" }, // reditor -> RShopEditor
                new IdentityUserRole<string> { UserId = "15", RoleId = "15" } // ruser -> RShopUser
            );
        }
    }
}