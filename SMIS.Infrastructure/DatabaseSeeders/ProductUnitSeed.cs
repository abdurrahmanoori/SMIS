using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class ProductUnitSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductUnit>().HasData(
                // Coca Cola - Bottle base unit (ID: 1)
                new ProductUnit { Id = "1", ProductId = "1", UnitOfMeasureId = "4", ConversionFactor = 12 }, // 1 Box = 12 Bottles
                new ProductUnit { Id = "2", ProductId = "1", UnitOfMeasureId = "5", ConversionFactor = 24 }, // 1 Carton = 24 Bottles
                
                // Pepsi - Bottle base unit (ID: 2)
                new ProductUnit { Id = "3", ProductId = "2", UnitOfMeasureId = "4", ConversionFactor = 12 }, // 1 Box = 12 Bottles
                new ProductUnit { Id = "4", ProductId = "2", UnitOfMeasureId = "5", ConversionFactor = 24 }, // 1 Carton = 24 Bottles
                
                // Mineral Water - Bottle base unit (ID: 3)
                new ProductUnit { Id = "5", ProductId = "3", UnitOfMeasureId = "4", ConversionFactor = 6 },  // 1 Box = 6 Bottles (1L bottles)
                new ProductUnit { Id = "6", ProductId = "3", UnitOfMeasureId = "5", ConversionFactor = 12 }, // 1 Carton = 12 Bottles
                
                // Oreo Biscuits - Pack base unit (ID: 4)
                new ProductUnit { Id = "7", ProductId = "4", UnitOfMeasureId = "4", ConversionFactor = 12 }, // 1 Box = 12 Packs
                new ProductUnit { Id = "8", ProductId = "4", UnitOfMeasureId = "5", ConversionFactor = 48 }, // 1 Carton = 48 Packs
                
                // Lay's Chips - Pack base unit (ID: 5)
                new ProductUnit { Id = "9", ProductId = "5", UnitOfMeasureId = "4", ConversionFactor = 20 }, // 1 Box = 20 Packs
                new ProductUnit { Id = "10", ProductId = "5", UnitOfMeasureId = "5", ConversionFactor = 60 }, // 1 Carton = 60 Packs
                
                // Instant Noodles - Pack base unit (ID: 6)
                new ProductUnit { Id = "11", ProductId = "6", UnitOfMeasureId = "4", ConversionFactor = 24 }, // 1 Box = 24 Packs
                new ProductUnit { Id = "12", ProductId = "6", UnitOfMeasureId = "5", ConversionFactor = 72 }, // 1 Carton = 72 Packs
                
                // A4 Notebook - Piece base unit (ID: 7)
                new ProductUnit { Id = "13", ProductId = "7", UnitOfMeasureId = "10", ConversionFactor = 12 }, // 1 Dozen = 12 Pieces
                new ProductUnit { Id = "14", ProductId = "7", UnitOfMeasureId = "4", ConversionFactor = 50 }, // 1 Box = 50 Pieces
                
                // Blue Pen - Piece base unit (ID: 8)
                new ProductUnit { Id = "15", ProductId = "8", UnitOfMeasureId = "10", ConversionFactor = 12 }, // 1 Dozen = 12 Pieces
                new ProductUnit { Id = "16", ProductId = "8", UnitOfMeasureId = "4", ConversionFactor = 144 }, // 1 Box = 144 Pieces (12 dozen)
                
                // Pencil Set - Box base unit (ID: 9) - already in boxes
                new ProductUnit { Id = "17", ProductId = "9", UnitOfMeasureId = "5", ConversionFactor = 20 }, // 1 Carton = 20 Boxes
                
                // Cooking Oil - Bottle base unit (ID: 10)
                new ProductUnit { Id = "18", ProductId = "10", UnitOfMeasureId = "4", ConversionFactor = 12 }, // 1 Box = 12 Bottles
                new ProductUnit { Id = "19", ProductId = "10", UnitOfMeasureId = "5", ConversionFactor = 24 }, // 1 Carton = 24 Bottles
                
                // Rice - Kg base unit (ID: 11)
                new ProductUnit { Id = "20", ProductId = "11", UnitOfMeasureId = "4", ConversionFactor = 10 }, // 1 Box = 10 Kg bags
                new ProductUnit { Id = "21", ProductId = "11", UnitOfMeasureId = "5", ConversionFactor = 25 }, // 1 Carton = 25 Kg bags
                
                // Sugar - Kg base unit (ID: 12)
                new ProductUnit { Id = "22", ProductId = "12", UnitOfMeasureId = "4", ConversionFactor = 20 }, // 1 Box = 20 Kg bags
                new ProductUnit { Id = "23", ProductId = "12", UnitOfMeasureId = "5", ConversionFactor = 50 }, // 1 Carton = 50 Kg bags
                
                // Shampoo - Bottle base unit (ID: 13)
                new ProductUnit { Id = "24", ProductId = "13", UnitOfMeasureId = "4", ConversionFactor = 12 }, // 1 Box = 12 Bottles
                new ProductUnit { Id = "25", ProductId = "13", UnitOfMeasureId = "5", ConversionFactor = 24 }, // 1 Carton = 24 Bottles
                
                // Toothpaste - Piece base unit (ID: 14)
                new ProductUnit { Id = "26", ProductId = "14", UnitOfMeasureId = "4", ConversionFactor = 24 }, // 1 Box = 24 Pieces
                new ProductUnit { Id = "27", ProductId = "14", UnitOfMeasureId = "5", ConversionFactor = 72 }, // 1 Carton = 72 Pieces
                
                // USB Cable - Piece base unit (ID: 15)
                new ProductUnit { Id = "28", ProductId = "15", UnitOfMeasureId = "4", ConversionFactor = 50 }, // 1 Box = 50 Pieces
                new ProductUnit { Id = "29", ProductId = "15", UnitOfMeasureId = "5", ConversionFactor = 200 }, // 1 Carton = 200 Pieces
                
                // Phone Charger - Piece base unit (ID: 16)
                new ProductUnit { Id = "30", ProductId = "16", UnitOfMeasureId = "4", ConversionFactor = 20 }, // 1 Box = 20 Pieces
                new ProductUnit { Id = "31", ProductId = "16", UnitOfMeasureId = "5", ConversionFactor = 100 }  // 1 Carton = 100 Pieces
            );
        }
    }
}