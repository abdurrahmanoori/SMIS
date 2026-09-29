using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class RoleComponentPermissionSeeder
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<RoleComponentPermission>().HasData(
            // Shops
            Permission(SeedIds.RoleSuperAdmin, AuthorizationSeedIds.ComponentShops, true, true, true, true, true),
            Permission(SeedIds.RoleShopAdmin, AuthorizationSeedIds.ComponentShops, true, true, true, true, true),
            Permission(SeedIds.RoleManager, AuthorizationSeedIds.ComponentShops, true, true, false, false, false),
            Permission(SeedIds.RoleInventoryManager, AuthorizationSeedIds.ComponentShops, true, true, false, false, false),
            Permission(SeedIds.RoleSalesManager, AuthorizationSeedIds.ComponentShops, true, true, false, false, false),
            Permission(SeedIds.RoleCashier, AuthorizationSeedIds.ComponentShops, true, true, false, false, false),
            Permission(SeedIds.RoleStaff, AuthorizationSeedIds.ComponentShops, true, true, false, false, false),
            Permission(SeedIds.RoleViewer, AuthorizationSeedIds.ComponentShops, true, true, false, false, false),

            // Units of measure
            Permission(SeedIds.RoleSuperAdmin, AuthorizationSeedIds.ComponentUnitsOfMeasure, true, true, true, true, true),
            Permission(SeedIds.RoleShopAdmin, AuthorizationSeedIds.ComponentUnitsOfMeasure, true, true, true, true, true),
            Permission(SeedIds.RoleManager, AuthorizationSeedIds.ComponentUnitsOfMeasure, true, true, true, true, true),
            Permission(SeedIds.RoleInventoryManager, AuthorizationSeedIds.ComponentUnitsOfMeasure, true, true, true, true, true),
            Permission(SeedIds.RoleSalesManager, AuthorizationSeedIds.ComponentUnitsOfMeasure, true, true, false, false, false),
            Permission(SeedIds.RoleCashier, AuthorizationSeedIds.ComponentUnitsOfMeasure, true, true, false, false, false),
            Permission(SeedIds.RoleStaff, AuthorizationSeedIds.ComponentUnitsOfMeasure, true, true, false, false, false),
            Permission(SeedIds.RoleViewer, AuthorizationSeedIds.ComponentUnitsOfMeasure, true, true, false, false, false),

            // Categories
            Permission(SeedIds.RoleSuperAdmin, AuthorizationSeedIds.ComponentCategories, true, true, true, true, true),
            Permission(SeedIds.RoleShopAdmin, AuthorizationSeedIds.ComponentCategories, true, true, true, true, true),
            Permission(SeedIds.RoleManager, AuthorizationSeedIds.ComponentCategories, true, true, true, true, true),
            Permission(SeedIds.RoleInventoryManager, AuthorizationSeedIds.ComponentCategories, true, true, true, true, true),
            Permission(SeedIds.RoleSalesManager, AuthorizationSeedIds.ComponentCategories, true, true, false, false, false),
            Permission(SeedIds.RoleCashier, AuthorizationSeedIds.ComponentCategories, true, true, false, false, false),
            Permission(SeedIds.RoleStaff, AuthorizationSeedIds.ComponentCategories, true, true, false, false, false),
            Permission(SeedIds.RoleViewer, AuthorizationSeedIds.ComponentCategories, true, true, false, false, false),

            // Products
            Permission(SeedIds.RoleSuperAdmin, AuthorizationSeedIds.ComponentProducts, true, true, true, true, true),
            Permission(SeedIds.RoleShopAdmin, AuthorizationSeedIds.ComponentProducts, true, true, true, true, true),
            Permission(SeedIds.RoleManager, AuthorizationSeedIds.ComponentProducts, true, true, true, true, true),
            Permission(SeedIds.RoleInventoryManager, AuthorizationSeedIds.ComponentProducts, true, true, true, true, true),
            Permission(SeedIds.RoleSalesManager, AuthorizationSeedIds.ComponentProducts, true, true, false, false, false),
            Permission(SeedIds.RoleCashier, AuthorizationSeedIds.ComponentProducts, true, true, false, false, false),
            Permission(SeedIds.RoleStaff, AuthorizationSeedIds.ComponentProducts, true, true, false, false, false),
            Permission(SeedIds.RoleViewer, AuthorizationSeedIds.ComponentProducts, true, true, false, false, false),

            // Product units
            Permission(SeedIds.RoleSuperAdmin, AuthorizationSeedIds.ComponentProductUnits, true, true, true, true, true),
            Permission(SeedIds.RoleShopAdmin, AuthorizationSeedIds.ComponentProductUnits, true, true, true, true, true),
            Permission(SeedIds.RoleManager, AuthorizationSeedIds.ComponentProductUnits, true, true, true, true, true),
            Permission(SeedIds.RoleInventoryManager, AuthorizationSeedIds.ComponentProductUnits, true, true, true, true, true),
            Permission(SeedIds.RoleSalesManager, AuthorizationSeedIds.ComponentProductUnits, true, true, false, false, false),
            Permission(SeedIds.RoleCashier, AuthorizationSeedIds.ComponentProductUnits, true, true, false, false, false),
            Permission(SeedIds.RoleStaff, AuthorizationSeedIds.ComponentProductUnits, true, true, false, false, false),
            Permission(SeedIds.RoleViewer, AuthorizationSeedIds.ComponentProductUnits, true, true, false, false, false),

            // Product prices
            Permission(SeedIds.RoleSuperAdmin, AuthorizationSeedIds.ComponentProductPrices, true, true, true, true, true),
            Permission(SeedIds.RoleShopAdmin, AuthorizationSeedIds.ComponentProductPrices, true, true, true, true, true),
            Permission(SeedIds.RoleManager, AuthorizationSeedIds.ComponentProductPrices, true, true, true, true, true),
            Permission(SeedIds.RoleInventoryManager, AuthorizationSeedIds.ComponentProductPrices, true, true, true, true, true),
            Permission(SeedIds.RoleSalesManager, AuthorizationSeedIds.ComponentProductPrices, true, true, true, true, true),
            Permission(SeedIds.RoleCashier, AuthorizationSeedIds.ComponentProductPrices, true, true, false, false, false),
            Permission(SeedIds.RoleStaff, AuthorizationSeedIds.ComponentProductPrices, true, true, false, false, false),
            Permission(SeedIds.RoleViewer, AuthorizationSeedIds.ComponentProductPrices, true, true, false, false, false),

            // Inventory
            Permission(SeedIds.RoleSuperAdmin, AuthorizationSeedIds.ComponentInventory, true, true, true, true, true),
            Permission(SeedIds.RoleShopAdmin, AuthorizationSeedIds.ComponentInventory, true, true, true, true, true),
            Permission(SeedIds.RoleManager, AuthorizationSeedIds.ComponentInventory, true, true, true, true, true),
            Permission(SeedIds.RoleInventoryManager, AuthorizationSeedIds.ComponentInventory, true, true, true, true, true),
            Permission(SeedIds.RoleSalesManager, AuthorizationSeedIds.ComponentInventory, true, true, false, false, false),
            Permission(SeedIds.RoleCashier, AuthorizationSeedIds.ComponentInventory, true, true, false, false, false),
            Permission(SeedIds.RoleStaff, AuthorizationSeedIds.ComponentInventory, true, true, false, false, false),
            Permission(SeedIds.RoleViewer, AuthorizationSeedIds.ComponentInventory, true, true, false, false, false));
    }

    private static RoleComponentPermission Permission(
        string roleId,
        string componentId,
        bool canView,
        bool canRead,
        bool canCreate,
        bool canUpdate,
        bool canDelete
    ) =>
        new()
        {
            RoleId = roleId,
            ComponentId = componentId,
            CanView = canView,
            CanRead = canRead,
            CanCreate = canCreate,
            CanUpdate = canUpdate,
            CanDelete = canDelete
        };
}
