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

    private static object CreateCategory(string id, string name, string shopId, string? code = null, string? description = null)
    {
        return new
        {
            Id = id,
            Name = name,
            ShopId = shopId,
            Code = code,
            Description = description,
            IsActive = true,
            IsSyncedToServer = true,
            LastSyncedAt = DateTimeService.UtcNow,
            LastModifiedUtc = DateTimeService.UtcNowOffSet,
            CreatedDate = DateTimeService.UtcNow,
            UpdatedDate = DateTimeService.UtcNow,
            EntityState = SMIS.Domain.Enums.EntityStateEnum.Unchanged,
            IsPublic = false,
            Version = 0
        };
    }
}
