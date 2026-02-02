using Microsoft.EntityFrameworkCore;
using SMIS.Infrastructure.DatabaseSeeders;

namespace SMIS.Infrastructure.Context;

public partial class AppDbContext
{
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        // Register additional seeds without modifying the main AppDbContext file
        RoleSeeder.DataSeed(modelBuilder);
        LanguageSeed.DataSeed(modelBuilder);
        TranslationKeySeed.DataSeed(modelBuilder);
        TranslationSeed.DataSeed(modelBuilder);
        ProvinceSeed.DataSeed(modelBuilder);
        DistrictSeed.DataSeed(modelBuilder);
        UnitOfMeasureSeed.DataSeed(modelBuilder);
        ShopSeed.DataSeed(modelBuilder);
        ProductSeed.DataSeed(modelBuilder);
        CategorySeed.DataSeed(modelBuilder);
    }
}
