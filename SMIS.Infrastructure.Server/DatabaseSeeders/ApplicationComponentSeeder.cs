using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ApplicationComponentSeeder
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<ApplicationComponent>().HasData(
            Component(AuthorizationSeedIds.ComponentShops, ApplicationComponentKeys.Shops, "Shops", 1),
            Component(AuthorizationSeedIds.ComponentUnitsOfMeasure, ApplicationComponentKeys.UnitsOfMeasure, "Units of measure", 2),
            new ApplicationComponent
            {
                Id = AuthorizationSeedIds.ComponentCategories,
                Key = ApplicationComponentKeys.Categories,
                Name = "Categories",
                DisplayOrder = 3,
                ShowInMenu = true,
                IsActive = true
            },
            Component(AuthorizationSeedIds.ComponentProducts, ApplicationComponentKeys.Products, "Products", 4),
            Component(AuthorizationSeedIds.ComponentProductUnits, ApplicationComponentKeys.ProductUnits, "Product units", 5),
            Component(AuthorizationSeedIds.ComponentProductPrices, ApplicationComponentKeys.ProductPrices, "Product prices", 6),
            Component(AuthorizationSeedIds.ComponentInventory, ApplicationComponentKeys.Inventory, "Inventory", 7),
            Component(AuthorizationSeedIds.ComponentCustomers, ApplicationComponentKeys.Customers, "Customers", 8),
            Component(AuthorizationSeedIds.ComponentSuppliers, ApplicationComponentKeys.Suppliers, "Suppliers", 9),
            Component(AuthorizationSeedIds.ComponentPurchasing, ApplicationComponentKeys.Purchasing, "Purchasing", 10),
            Component(AuthorizationSeedIds.ComponentSales, ApplicationComponentKeys.Sales, "Sales", 11),
            Component(AuthorizationSeedIds.ComponentReceivables, ApplicationComponentKeys.Receivables, "Receivables", 12),
            Component(AuthorizationSeedIds.ComponentShopOwners, ApplicationComponentKeys.ShopOwners, "Shop owners", 13));
    }

    private static ApplicationComponent Component(
        string id,
        string key,
        string name,
        int displayOrder
    ) =>
        new()
        {
            Id = id,
            Key = key,
            Name = name,
            DisplayOrder = displayOrder,
            ShowInMenu = true,
            IsActive = true
        };
}
