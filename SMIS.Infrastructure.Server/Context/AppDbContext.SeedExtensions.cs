using Microsoft.EntityFrameworkCore;
using SMIS.Infrastructure.Server.DatabaseSeeders;

namespace SMIS.Infrastructure.Server.Context;

public partial class AppDbContext
{
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        // Register additional seeds without modifying the main AppDbContext file
        RoleSeeder.DataSeed(modelBuilder);
        UserSeed.DataSeed(modelBuilder);
        UserRoleSeeder.DataSeed(modelBuilder);
        LanguageSeed.DataSeed(modelBuilder);
        TranslationKeySeed.DataSeed(modelBuilder);
        TranslationSeed.DataSeed(modelBuilder);
        ProvinceSeed.DataSeed(modelBuilder);
        DistrictSeed.DataSeed(modelBuilder);
        ShopSeed.DataSeed(modelBuilder);
        UnitOfMeasureSeed.DataSeed(modelBuilder);
        CategorySeed.DataSeed(modelBuilder);
        ProductSeed.DataSeed(modelBuilder);
        ProductUnitSeed.DataSeed(modelBuilder);
        ProductPriceSeed.DataSeed(modelBuilder);
        CustomerSeed.DataSeed(modelBuilder);
        ShopOwnerSeed.DataSeed(modelBuilder);
        StockBatchSeed.DataSeed(modelBuilder);
        StockTransactionSeed.DataSeed(modelBuilder);
        LoanAccountSeed.DataSeed(modelBuilder);
    }
}
