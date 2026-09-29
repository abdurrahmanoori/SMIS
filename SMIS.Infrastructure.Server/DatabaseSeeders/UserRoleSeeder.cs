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
                    UserId = SeedIds.UserMainShopAdmin, RoleId = SeedIds.RoleShopAdmin,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Shop_Admin, SeedIds.Shop1),
                    RoleName = SD.Role_Shop_Admin
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainManager, RoleId = SeedIds.RoleManager,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Manager, SeedIds.Shop1),
                    RoleName = SD.Role_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainInventoryManager, RoleId = SeedIds.RoleInventoryManager,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Inventory_Manager, SeedIds.Shop1),
                    RoleName = SD.Role_Inventory_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainSalesManager, RoleId = SeedIds.RoleSalesManager,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Sales_Manager, SeedIds.Shop1),
                    RoleName = SD.Role_Sales_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserMainCashier, RoleId = SeedIds.RoleCashier,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Cashier, SeedIds.Shop1),
                    RoleName = SD.Role_Cashier
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
                // Branch Store
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchShopAdmin, RoleId = SeedIds.RoleShopAdmin,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Shop_Admin, SeedIds.Shop2),
                    RoleName = SD.Role_Shop_Admin
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchManager, RoleId = SeedIds.RoleManager,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Manager, SeedIds.Shop2),
                    RoleName = SD.Role_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchInventoryManager, RoleId = SeedIds.RoleInventoryManager,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Inventory_Manager, SeedIds.Shop2),
                    RoleName = SD.Role_Inventory_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchSalesManager, RoleId = SeedIds.RoleSalesManager,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Sales_Manager, SeedIds.Shop2),
                    RoleName = SD.Role_Sales_Manager
                },
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserBranchCashier, RoleId = SeedIds.RoleCashier,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Cashier, SeedIds.Shop2),
                    RoleName = SD.Role_Cashier
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
                // Wasil Shop
                new ApplicationUserRole
                {
                    UserId = SeedIds.UserWasilShopAdmin, RoleId = SeedIds.RoleShopAdmin,
                    UserName = UserSeed.GetSeedEmail(SD.Role_Shop_Admin, SeedIds.ShopWasil),
                    RoleName = SD.Role_Shop_Admin
                }
            );
        }
    }
}