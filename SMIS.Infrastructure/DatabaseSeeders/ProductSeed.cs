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
                CreateProduct("1", "Coca Cola 500ml", "1", "2", "COKE-500ML-001", 150, "Classic cola drink", "1234567890001", null, "1", true),
                CreateProduct("2", "Pepsi 500ml", "1", "2", "PEPSI-500ML-002", 140, "Cola soft drink", "1234567890002", null, "1", true),
                CreateProduct("3", "Mineral Water 1L", "2", "2", "WATER-1L-003", 80, "Pure drinking water", "1234567890003", null, "1", true),
                
                // Food Items (Category 2)
                CreateProduct("4", "Oreo Biscuits", "1", "3", "OREO-PACK-004", 250, "Chocolate sandwich cookies", "1234567890004", null, "2", true),
                CreateProduct("5", "Lay's Chips", "2", "3", "LAYS-PACK-005", 180, "Potato chips", "1234567890005", null, "2", true),
                CreateProduct("6", "Instant Noodles", "3", "3", "NOODLE-PACK-006", 120, "Quick meal noodles", "1234567890006", null, "2", true),
                
                // Stationery (Category 3)
                CreateProduct("7", "A4 Notebook", "1", "1", "NOTE-A4-007", 300, "200 pages ruled notebook", "1234567890007", null, "3", true),
                CreateProduct("8", "Blue Pen", "2", "1", "PEN-BLUE-008", 50, "Ballpoint pen", "1234567890008", null, "3", true),
                CreateProduct("9", "Pencil Set", "3", "4", "PENCIL-BOX-009", 400, "12 pencils per box", "1234567890009", null, "3", true),
                
                // Grocery (Category 4)
                CreateProduct("10", "Cooking Oil 1L", "1", "2", "OIL-1L-010", 450, "Sunflower cooking oil", "1234567890010", null, "4", true),
                CreateProduct("11", "Rice 1kg", "2", "7", "RICE-1KG-011", 280, "Basmati rice", "1234567890011", null, "4", true),
                CreateProduct("12", "Sugar 1kg", "3", "7", "SUGAR-1KG-012", 200, "White granulated sugar", "1234567890012", null, "4", true),
                
                // Personal Care (Category 5)
                CreateProduct("13", "Shampoo 400ml", "1", "2", "SHAMP-400ML-013", 350, "Hair care shampoo", "1234567890013", null, "5", true),
                CreateProduct("14", "Toothpaste", "2", "1", "TOOTH-PASTE-014", 180, "Dental care paste", "1234567890014", null, "5", true),
                
                // Electronics (Category 6)
                CreateProduct("15", "USB Cable", "1", "1", "USB-CABLE-015", 250, "Type-C charging cable", "1234567890015", null, "6", true),
                CreateProduct("16", "Phone Charger", "3", "1", "CHARGER-016", 800, "Fast charging adapter", "1234567890016", null, "6", true)
            );
        }

        private static Product CreateProduct(string id, string name, string shopId, string baseUnitId, string sku, int salePricePerBaseUnit, string? description, string? barcode, string? imageUrl, string? categoryId, bool isActive)
        {
            var product = Product.Create(name, shopId, baseUnitId, sku, salePricePerBaseUnit, description, barcode, imageUrl, categoryId);
            
            // Set ID for seeding (bypass domain validation for infrastructure concerns)
            typeof(Product).GetProperty(nameof(Product.Id))!.SetValue(product, id);
            
            if (!isActive) product.Deactivate();
            
            return product;
        }
    }
}