using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using System.Reflection;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class ShopSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var shops = new[]
        {
            CreateShop("1", "Main Store", ShopType.RetailShop, "Kabul Center", "0700000001", "main@store.local", "TAX001", true),
            CreateShop("2", "Branch Store", ShopType.WholesaleShop, "Herat Center", "0700000002", "branch@store.local", "TAX002", true),
            CreateShop("3", "Warehouse", ShopType.RetailShop, "Kandahar Center", "0700000003", "warehouse@store.local", "TAX003", true)
        };

        modelBuilder.Entity<Shop>().HasData(shops);
    }

    private static Shop CreateShop(string id, string name, ShopType shopType, string address, string phoneNumber, string email, string taxNumber, bool isActive)
    {
        var shop = Shop.Create(name, shopType, address, phoneNumber, email, taxNumber);
        
        // Set ID for seeding (bypass domain validation for infrastructure concerns)
        typeof(Shop).GetProperty(nameof(Shop.Id))!.SetValue(shop, id);
        
        if (!isActive) shop.Deactivate();
        
        return shop;
    }
}
