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
                new Category { Id = "2", Name = "Food Items", Code = "FOOD", Description = "Edible products and snacks", IsActive = true },
                new Category { Id = "3", Name = "Stationery", Code = "STAT", Description = "Office and school supplies", IsActive = true },
                new Category { Id = "4", Name = "Grocery", Code = "GROC", Description = "Daily household items", IsActive = true },
                new Category { Id = "5", Name = "Personal Care", Code = "CARE", Description = "Health and hygiene products", IsActive = true },
                new Category { Id = "6", Name = "Electronics", Code = "ELEC", Description = "Electronic devices and accessories", IsActive = true }
            );
        }
    }
}