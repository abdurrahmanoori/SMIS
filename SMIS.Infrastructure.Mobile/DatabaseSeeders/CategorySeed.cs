using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Mobile.DatabaseSeeders;

public static class CategorySeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            CreateCategory("1", "Beverages", "1", "BEV", "Drinks and beverages"),
            CreateCategory("2", "Food Items", "1", "FOOD", "Edible products and snacks"),
            CreateCategory("3", "Stationery", "1", "STAT", "Office and school supplies"),
            CreateCategory("4", "Grocery", "1", "GROC", "Daily household items"),
            CreateCategory("5", "Personal Care", "1", "CARE", "Health and hygiene products"),
            CreateCategory("6", "Electronics", "1", "ELEC", "Electronic devices and accessories")
        );
    }

    private static Category CreateCategory(string id, string name, string shopId, string? code = null, string? description = null)
    {
        var category = Category.Create(name, shopId, code, description, true);
        
        typeof(Category).GetProperty(nameof(Category.Id))!.SetValue(category, id);
        typeof(Category).GetProperty(nameof(Category.IsSyncedToServer))!.SetValue(category, true);
        typeof(Category).GetProperty(nameof(Category.LastSyncedAt))!.SetValue(category, DateTimeService.UtcNow);
        typeof(Category).GetProperty(nameof(Category.CreatedDate))!.SetValue(category, DateTimeService.UtcNow);
        typeof(Category).GetProperty(nameof(Category.UpdatedDate))!.SetValue(category, DateTimeService.UtcNow);
        typeof(Category).GetProperty(nameof(Category.LastModifiedUtc))!.SetValue(category, DateTimeService.UtcNowOffSet);
        
        return category;
    }
}
