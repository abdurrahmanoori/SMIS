using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class ProductSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = "1", Name = "Paracetamol 500mg", ShopId = "1", BaseUnitId = "1", SalePricePerBaseUnit = 50, Description = "Pain reliever", IsActive = true, SKU = "PAR-500MG-001", Barcode = "1234567890123", ImageUrl = "https://example.com/images/paracetamol.jpg", CategoryId = "1" },
                new Product { Id = "2", Name = "Ibuprofen 200mg", ShopId = "1", BaseUnitId = "1", SalePricePerBaseUnit = 30, Description = "Anti-inflammatory", IsActive = true, SKU = "IBU-200MG-002", Barcode = "1234567890124", ImageUrl = "https://example.com/images/ibuprofen.jpg", CategoryId = "1" },
                new Product { Id = "3", Name = "Aspirin 100mg", ShopId = "2", BaseUnitId = "1", SalePricePerBaseUnit = 20, Description = "Blood thinner", IsActive = true, SKU = "ASP-100MG-003", Barcode = "1234567890125", ImageUrl = "https://example.com/images/aspirin.jpg", CategoryId = "2" }
            );
        }
    }
}