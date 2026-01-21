using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class ShopSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().HasData(
                new Shop { Id = "1", Name = "Main Pharmacy", ShopType = ShopType.RetailShop, Address = "Kabul Center", PhoneNumber = "0700000001", Email = "main@pharmacy.local", TaxNumber = "TAX001", IsActive = true },
                new Shop { Id = "2", Name = "City Pharmacy", ShopType = ShopType.WholesaleShop, Address = "Herat Center", PhoneNumber = "0700000002", Email = "city@pharmacy.local", TaxNumber = "TAX002", IsActive = true },
                new Shop { Id = "3", Name = "Health Store", ShopType = ShopType.RetailShop, Address = "Kandahar Center", PhoneNumber = "0700000003", Email = "health@store.local", TaxNumber = "TAX003", IsActive = true }
            );
        }
    }
}
