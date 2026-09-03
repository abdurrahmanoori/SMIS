using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class CategorySeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            CreateCategory(SeedIds.CatBeverages,    "Beverages",     SeedIds.Shop1, "BEV",  "Drinks and beverages"),
            CreateCategory(SeedIds.CatFood,         "Food Items",    SeedIds.Shop1, "FOOD", "Edible products and snacks"),
            CreateCategory(SeedIds.CatStationery,   "Stationery",    SeedIds.Shop2, "STAT", "Office and school supplies"),
            CreateCategory(SeedIds.CatGrocery,      "Grocery",       SeedIds.Shop2, "GROC", "Daily household items"),
            CreateCategory(SeedIds.CatPersonalCare, "Personal Care", SeedIds.Shop3, "CARE", "Health and hygiene products"),
            CreateCategory(SeedIds.CatElectronics,  "Electronics",   SeedIds.Shop3, "ELEC", "Electronic devices and accessories")
        );
    }

    private static Category CreateCategory(string id, string name, string shopId, string? code = null, string? description = null)
    {
        var category = Category.Create(name, shopId, code, description, true);
        category.Id = id;
        category.CreatedDate = DateTimeService.NowUtc;
        category.UpdatedDate = DateTimeService.NowUtc;
        category.LastModifiedUtc = DateTimeService.NowUtc;
        return category;


        //typeof(Category).GetProperty(nameof(Category.Id))!.SetValue(category, id);
        //typeof(Category).GetProperty(nameof(Category.CreatedDate))!.SetValue(category, DateTimeService.Now);
        //typeof(Category).GetProperty(nameof(Category.UpdatedDate))!.SetValue(category, DateTimeService.Now);
        //typeof(Category).GetProperty(nameof(Category.LastModifiedUtc))!.SetValue(category, DateTimeService.NowUtc);
    }
}
