using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class RoleSeeder
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole { Id = "1", Name = SD.Role_Super_Admin, NormalizedName = SD.Role_Super_Admin.ToUpper() },
                
                // Wholesale Shop Roles
                new ApplicationRole { Id = "2", Name = SD.Role_WShop_Admin, NormalizedName = SD.Role_WShop_Admin.ToUpper() },
                new ApplicationRole { Id = "3", Name = SD.Role_WShop_Administration, NormalizedName = SD.Role_WShop_Administration.ToUpper() },
                new ApplicationRole { Id = "4", Name = SD.Role_WShop_Manager, NormalizedName = SD.Role_WShop_Manager.ToUpper() },
                new ApplicationRole { Id = "5", Name = SD.Role_WShop_Staff, NormalizedName = SD.Role_WShop_Staff.ToUpper() },
                new ApplicationRole { Id = "6", Name = SD.Role_WShop_Viewer, NormalizedName = SD.Role_WShop_Viewer.ToUpper() },
                new ApplicationRole { Id = "7", Name = SD.Role_WShop_Editor, NormalizedName = SD.Role_WShop_Editor.ToUpper() },
                new ApplicationRole { Id = "8", Name = SD.Role_WShop_User, NormalizedName = SD.Role_WShop_User.ToUpper() },
                
                // Retail Shop Roles
                new ApplicationRole { Id = "9", Name = SD.Role_RShop_Admin, NormalizedName = SD.Role_RShop_Admin.ToUpper() },
                new ApplicationRole { Id = "10", Name = SD.Role_RShop_Administration, NormalizedName = SD.Role_RShop_Administration.ToUpper() },
                new ApplicationRole { Id = "11", Name = SD.Role_RShop_Manager, NormalizedName = SD.Role_RShop_Manager.ToUpper() },
                new ApplicationRole { Id = "12", Name = SD.Role_RShop_Staff, NormalizedName = SD.Role_RShop_Staff.ToUpper() },
                new ApplicationRole { Id = "13", Name = SD.Role_RShop_Viewer, NormalizedName = SD.Role_RShop_Viewer.ToUpper() },
                new ApplicationRole { Id = "14", Name = SD.Role_RShop_Editor, NormalizedName = SD.Role_RShop_Editor.ToUpper() },
                new ApplicationRole { Id = "15", Name = SD.Role_RShop_User, NormalizedName = SD.Role_RShop_User.ToUpper() }
            );
        }
    }
}