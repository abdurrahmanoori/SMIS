using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Mobile.DatabaseSeeders;

public static class ShopSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Shop>().HasData(
            CreateShop("1", "Main Store", ShopType.RetailShop, "Kabul Center", "0700000001", "main@store.local", "TAX001", true),
            CreateShop("2", "Branch Store", ShopType.WholesaleShop, "Herat Center", "0700000002", "branch@store.local", "TAX002", true),
            CreateShop("3", "Warehouse", ShopType.RetailShop, "Kandahar Center", "0700000003", "warehouse@store.local", "TAX003", true)
        );
    }

    private static Shop CreateShop(string id, string name, ShopType shopType, string? address, string? phoneNumber, string? email, string? taxNumber, bool isActive)
    {
        var shop = Shop.Create(name, shopType, address, phoneNumber, email, taxNumber, isActive);
        shop.Id = id;
        shop.IsSyncedToServer = true;
        shop.LastSyncedAt = DateTimeService.UtcNow;
        shop.CreatedDate = DateTimeService.UtcNow;
        shop.UpdatedDate = DateTimeService.UtcNow;
        shop.LastModifiedUtc = DateTimeService.UtcNow;
        return shop;
    }
}
