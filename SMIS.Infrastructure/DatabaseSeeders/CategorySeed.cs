using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class CategorySeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            CreateCategory("1", "Beverages", "1", "BEV", "Drinks and beverages"),
            CreateCategory("2", "Food Items", "1", "FOOD", "Edible products and snacks"),
            CreateCategory("3", "Stationery", "2", "STAT", "Office and school supplies"),
            CreateCategory("4", "Grocery", "2", "GROC", "Daily household items"),
            CreateCategory("5", "Personal Care", "3", "CARE", "Health and hygiene products"),
            CreateCategory("6", "Electronics", "3", "ELEC", "Electronic devices and accessories")
        );
    }

    private static Category CreateCategory(string id, string name, string shopId, string? code = null, string? description = null)
    {
        var category = Category.Create(name, shopId, code, description, true);
        
        typeof(Category).GetProperty(nameof(Category.Id))!.SetValue(category, id);
        typeof(Category).GetProperty(nameof(Category.CreatedDate))!.SetValue(category, DateTimeService.Now);
        typeof(Category).GetProperty(nameof(Category.UpdatedDate))!.SetValue(category, DateTimeService.Now);
        typeof(Category).GetProperty(nameof(Category.LastModifiedUtc))!.SetValue(category, DateTimeService.NowOffSet);
        
        return category;
    }
}