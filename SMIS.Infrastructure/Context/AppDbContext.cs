using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.LocationEntities;
using SMIS.Infrastructure.DatabaseSeeders;
using System.Reflection;

namespace SMIS.Infrastructure.Context;

public partial class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply all IEntityTypeConfiguration classes from this assembly
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // Configure EntityState as string for all entities
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var entityStateProperty = entityType.FindProperty(nameof(BaseEntity.EntityState));
            if (entityStateProperty != null)
            {
                modelBuilder.Entity(entityType.ClrType)
                    .Property(nameof(BaseEntity.EntityState))
                    .HasConversion<string>();
            }
        }

        #region Seed Database
        ProductUnitSeed.DataSeed(modelBuilder);
        ProductPriceSeed.DataSeed(modelBuilder);
        StockBatchSeed.DataSeed(modelBuilder);
        StockTransactionSeed.DataSeed(modelBuilder);
        #endregion

        // Allow extension from other layers via partial method
        OnModelCreatingPartial(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);


        optionsBuilder.ConfigureWarnings(warnings =>
   warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Province> Provinces { get; set; }
    public DbSet<ProvinceTranslation> ProvinceTranslations { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<AppLog> AppLogs { get; set; }
    public DbSet<TranslationKey> TranslationKeys { get; set; }
    public DbSet<Translation> Translations { get; set; }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductUnit> ProductUnits { get; set; }
    public DbSet<ProductPrice> ProductPrices { get; set; }
    public DbSet<StockBatch> StockBatches { get; set; }
    public DbSet<StockTransaction> StockTransactions { get; set; }
    public DbSet<ApplicationUserRole> UserRoles { get; set; }
}
