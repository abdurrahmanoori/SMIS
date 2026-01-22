using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class ProductUnitSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductUnit>().HasData(
                new ProductUnit { Id = "1", ProductId = "1", UnitOfMeasureId = "1", ConversionFactor = 10 }, // Example: 1 Box = 10 Pieces
                new ProductUnit { Id = "2", ProductId = "1", UnitOfMeasureId = "2", ConversionFactor = 100 }, // Example: 1 Carton = 100 Pieces
                new ProductUnit { Id = "3", ProductId = "2", UnitOfMeasureId = "1", ConversionFactor = 12 }  // Example: 1 Box = 12 Bottles
            );
        }
    }
}