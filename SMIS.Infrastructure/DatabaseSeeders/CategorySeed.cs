using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders
{
    public static class CategorySeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = "1", Name = "Beverages", Code = "BEV", Description = "Drinks and beverages", IsActive = true },
                new Category { Id = "2", Name = "Soft Drinks", Code = "SOFT", Description = "Carbonated and non-carbonated drinks", IsActive = true },
                new Category { Id = "3", Name = "Food Items", Code = "FOOD", Description = "Edible products", IsActive = true }
            );
        }
    }
}