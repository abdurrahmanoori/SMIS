using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders
{
    public static class RoleSeeder
    {
        public static void DataSeed(
            ModelBuilder modelBuilder
        )
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = SeedIds.RoleSuperAdmin, Name = SD.Role_Super_Admin,
                    NormalizedName = SD.Role_Super_Admin.ToUpper()
                },
                new ApplicationRole
                {
                    Id = SeedIds.RoleShopAdmin, Name = SD.Role_Shop_Admin, NormalizedName = SD.Role_Shop_Admin.ToUpper()
                },
                new ApplicationRole
                {
                    Id = SeedIds.RoleManager, Name = SD.Role_Manager,
                    NormalizedName = SD.Role_Manager.ToUpper()
                },
                new ApplicationRole
                {
                    Id = SeedIds.RoleInventoryManager, Name = SD.Role_Inventory_Manager,
                    NormalizedName = SD.Role_Inventory_Manager.ToUpper()
                },
                new ApplicationRole
                {
                    Id = SeedIds.RoleSalesManager, Name = SD.Role_Sales_Manager,
                    NormalizedName = SD.Role_Sales_Manager.ToUpper()
                },
                new ApplicationRole
                    { Id = SeedIds.RoleCashier, Name = SD.Role_Cashier, NormalizedName = SD.Role_Cashier.ToUpper() },
                new ApplicationRole
                    { Id = SeedIds.RoleStaff, Name = SD.Role_Staff, NormalizedName = SD.Role_Staff.ToUpper() },
                new ApplicationRole
                    { Id = SeedIds.RoleViewer, Name = SD.Role_Viewer, NormalizedName = SD.Role_Viewer.ToUpper() }
            );
        }
    }
}