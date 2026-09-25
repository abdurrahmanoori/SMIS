using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class CategorySeed
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<Category>().HasData(
            CreateCategory(SeedIds.CatBeverages, SeedIds.CatTextBeverages, "Beverages", SeedIds.Shop1, "BEV", "Drinks and beverages"),
            CreateCategory(SeedIds.CatFood, SeedIds.CatTextFood, "Food Items", SeedIds.Shop1, "FOOD", "Edible products and snacks"),
            CreateCategory(SeedIds.CatStationery, SeedIds.CatTextStationery, "Stationery", SeedIds.Shop2, "STAT", "Office and school supplies"),
            CreateCategory(SeedIds.CatGrocery, SeedIds.CatTextGrocery, "Grocery", SeedIds.Shop2, "GROC", "Daily household items"),
            CreateCategory(SeedIds.CatPersonalCare, SeedIds.CatTextPersonalCare, "Personal Care", SeedIds.Shop3, "CARE",
                "Health and hygiene products"),
            CreateCategory(SeedIds.CatElectronics, SeedIds.CatTextElectronics, "Electronics", SeedIds.Shop3, "ELEC",
                "Electronic devices and accessories")
        );
    }

    private static Category CreateCategory(
        string id,
        string localizedTextId,
        string name,
        string shopId,
        string? code = null,
        string? description = null
    )
    {
        var category = Category.Create(name, shopId, code, description, true);
        category.Id = id;
        category.SetNameLocalizedTextId(localizedTextId);
        category.CreatedDate = SeedIds.SeedTimestampUtc;
        category.UpdatedDate = SeedIds.SeedTimestampUtc;
        category.LastModifiedUtc = SeedIds.SeedTimestampUtc;
        return category;
    }
}
