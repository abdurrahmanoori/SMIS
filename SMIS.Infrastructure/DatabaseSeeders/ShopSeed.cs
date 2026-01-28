using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using System.Reflection;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class ShopSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            var shops = new[]
            {
                CreateShop("1", "Main Pharmacy", ShopType.RetailShop, "Kabul Center", "0700000001", "main@pharmacy.local", "TAX001", true),
                CreateShop("2", "City Pharmacy", ShopType.WholesaleShop, "Herat Center", "0700000002", "city@pharmacy.local", "TAX002", true),
                CreateShop("3", "Health Store", ShopType.RetailShop, "Kandahar Center", "0700000003", "health@store.local", "TAX003", true)
            };

            modelBuilder.Entity<Shop>().HasData(shops);
        }

        private static Shop CreateShop(string id, string name, ShopType shopType, string address, string phoneNumber, string email, string taxNumber, bool isActive)
        {
            var shop = (Shop)Activator.CreateInstance(typeof(Shop), true)!;
            
            typeof(Shop).GetProperty("Id")!.SetValue(shop, id);
            typeof(Shop).GetProperty("Name")!.SetValue(shop, name);
            typeof(Shop).GetProperty("ShopType")!.SetValue(shop, shopType);
            typeof(Shop).GetProperty("Address")!.SetValue(shop, address);
            typeof(Shop).GetProperty("PhoneNumber")!.SetValue(shop, phoneNumber);
            typeof(Shop).GetProperty("Email")!.SetValue(shop, email);
            typeof(Shop).GetProperty("TaxNumber")!.SetValue(shop, taxNumber);
            typeof(Shop).GetProperty("IsActive")!.SetValue(shop, isActive);
            
            return shop;
        }
    }
}
