using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class ProductSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = "1", Name = "Paracetamol 500mg", ShopId = "1", BaseUnitId = "1", SalePricePerBaseUnit = 50, Description = "Pain reliever", IsActive = true },
                new Product { Id = "2", Name = "Ibuprofen 200mg", ShopId = "1", BaseUnitId = "1", SalePricePerBaseUnit = 30, Description = "Anti-inflammatory", IsActive = true },
                new Product { Id = "3", Name = "Aspirin 100mg", ShopId = "2", BaseUnitId = "1", SalePricePerBaseUnit = 20, Description = "Blood thinner", IsActive = true }
            );
        }
    }
}