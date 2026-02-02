using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class UserRoleSeeder
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUserRole>().HasData(
                // SuperAdmin
                new ApplicationUserRole { UserId = "1", RoleId = "1", UserName = "superadmin", RoleName = SD.Role_Super_Admin },

                // Wholesale Shop Users
                new ApplicationUserRole { UserId = "2", RoleId = "2", UserName = "wadmin", RoleName = SD.Role_WShop_Admin },
                new ApplicationUserRole { UserId = "3", RoleId = "3", UserName = "wadministration", RoleName = SD.Role_WShop_Administration },
                new ApplicationUserRole { UserId = "4", RoleId = "4", UserName = "wmanager", RoleName = SD.Role_WShop_Manager },
                new ApplicationUserRole { UserId = "5", RoleId = "5", UserName = "wstaff", RoleName = SD.Role_WShop_Staff },
                new ApplicationUserRole { UserId = "6", RoleId = "6", UserName = "wviewer", RoleName = SD.Role_WShop_Viewer },
                new ApplicationUserRole { UserId = "7", RoleId = "7", UserName = "weditor", RoleName = SD.Role_WShop_Editor },
                new ApplicationUserRole { UserId = "8", RoleId = "8", UserName = "wuser", RoleName = SD.Role_WShop_User },

                // Retail Shop Users
                new ApplicationUserRole { UserId = "9", RoleId = "9", UserName = "radmin", RoleName = SD.Role_RShop_Admin },
                new ApplicationUserRole { UserId = "10", RoleId = "10", UserName = "radministration", RoleName = SD.Role_RShop_Administration },
                new ApplicationUserRole { UserId = "11", RoleId = "11", UserName = "rmanager", RoleName = SD.Role_RShop_Manager },
                new ApplicationUserRole { UserId = "12", RoleId = "12", UserName = "rstaff", RoleName = SD.Role_RShop_Staff },
                new ApplicationUserRole { UserId = "13", RoleId = "13", UserName = "rviewer", RoleName = SD.Role_RShop_Viewer },
                new ApplicationUserRole { UserId = "14", RoleId = "14", UserName = "reditor", RoleName = SD.Role_RShop_Editor },
                new ApplicationUserRole { UserId = "15", RoleId = "15", UserName = "ruser", RoleName = SD.Role_RShop_User }
            );
        }
    }
}
