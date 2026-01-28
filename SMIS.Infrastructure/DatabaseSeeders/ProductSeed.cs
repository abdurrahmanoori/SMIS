using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class ProductSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                // Beverages (Category 1)
                new Product { Id = "1", Name = "Coca Cola 500ml", ShopId = "1", BaseUnitId = "2", CategoryId = "1", SalePricePerBaseUnit = 150, Description = "Classic cola drink", IsActive = true, SKU = "COKE-500ML-001", Barcode = "1234567890001" },
                new Product { Id = "2", Name = "Pepsi 500ml", ShopId = "1", BaseUnitId = "2", CategoryId = "1", SalePricePerBaseUnit = 140, Description = "Cola soft drink", IsActive = true, SKU = "PEPSI-500ML-002", Barcode = "1234567890002" },
                new Product { Id = "3", Name = "Mineral Water 1L", ShopId = "2", BaseUnitId = "2", CategoryId = "1", SalePricePerBaseUnit = 80, Description = "Pure drinking water", IsActive = true, SKU = "WATER-1L-003", Barcode = "1234567890003" },
                
                // Food Items (Category 2)
                new Product { Id = "4", Name = "Oreo Biscuits", ShopId = "1", BaseUnitId = "3", CategoryId = "2", SalePricePerBaseUnit = 250, Description = "Chocolate sandwich cookies", IsActive = true, SKU = "OREO-PACK-004", Barcode = "1234567890004" },
                new Product { Id = "5", Name = "Lay's Chips", ShopId = "2", BaseUnitId = "3", CategoryId = "2", SalePricePerBaseUnit = 180, Description = "Potato chips", IsActive = true, SKU = "LAYS-PACK-005", Barcode = "1234567890005" },
                new Product { Id = "6", Name = "Instant Noodles", ShopId = "3", BaseUnitId = "3", CategoryId = "2", SalePricePerBaseUnit = 120, Description = "Quick meal noodles", IsActive = true, SKU = "NOODLE-PACK-006", Barcode = "1234567890006" },
                
                // Stationery (Category 3)
                new Product { Id = "7", Name = "A4 Notebook", ShopId = "1", BaseUnitId = "1", CategoryId = "3", SalePricePerBaseUnit = 300, Description = "200 pages ruled notebook", IsActive = true, SKU = "NOTE-A4-007", Barcode = "1234567890007" },
                new Product { Id = "8", Name = "Blue Pen", ShopId = "2", BaseUnitId = "1", CategoryId = "3", SalePricePerBaseUnit = 50, Description = "Ballpoint pen", IsActive = true, SKU = "PEN-BLUE-008", Barcode = "1234567890008" },
                new Product { Id = "9", Name = "Pencil Set", ShopId = "3", BaseUnitId = "4", CategoryId = "3", SalePricePerBaseUnit = 400, Description = "12 pencils per box", IsActive = true, SKU = "PENCIL-BOX-009", Barcode = "1234567890009" },
                
                // Grocery (Category 4)
                new Product { Id = "10", Name = "Cooking Oil 1L", ShopId = "1", BaseUnitId = "2", CategoryId = "4", SalePricePerBaseUnit = 450, Description = "Sunflower cooking oil", IsActive = true, SKU = "OIL-1L-010", Barcode = "1234567890010" },
                new Product { Id = "11", Name = "Rice 1kg", ShopId = "2", BaseUnitId = "7", CategoryId = "4", SalePricePerBaseUnit = 280, Description = "Basmati rice", IsActive = true, SKU = "RICE-1KG-011", Barcode = "1234567890011" },
                new Product { Id = "12", Name = "Sugar 1kg", ShopId = "3", BaseUnitId = "7", CategoryId = "4", SalePricePerBaseUnit = 200, Description = "White granulated sugar", IsActive = true, SKU = "SUGAR-1KG-012", Barcode = "1234567890012" },
                
                // Personal Care (Category 5)
                new Product { Id = "13", Name = "Shampoo 400ml", ShopId = "1", BaseUnitId = "2", CategoryId = "5", SalePricePerBaseUnit = 350, Description = "Hair care shampoo", IsActive = true, SKU = "SHAMP-400ML-013", Barcode = "1234567890013" },
                new Product { Id = "14", Name = "Toothpaste", ShopId = "2", BaseUnitId = "1", CategoryId = "5", SalePricePerBaseUnit = 180, Description = "Dental care paste", IsActive = true, SKU = "TOOTH-PASTE-014", Barcode = "1234567890014" },
                
                // Electronics (Category 6)
                new Product { Id = "15", Name = "USB Cable", ShopId = "1", BaseUnitId = "1", CategoryId = "6", SalePricePerBaseUnit = 250, Description = "Type-C charging cable", IsActive = true, SKU = "USB-CABLE-015", Barcode = "1234567890015" },
                new Product { Id = "16", Name = "Phone Charger", ShopId = "3", BaseUnitId = "1", CategoryId = "6", SalePricePerBaseUnit = 800, Description = "Fast charging adapter", IsActive = true, SKU = "CHARGER-016", Barcode = "1234567890016" }
            );
        }
    }
}