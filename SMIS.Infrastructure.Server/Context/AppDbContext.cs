using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.LocationEntities;
using SMIS.Infrastructure.Server.DatabaseSeeders;
using System.Reflection;
using SMIS.Application.Services;

namespace SMIS.Infrastructure.Server.Context;

public partial class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string,
        IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>,
        IdentityUserToken<string>>,
    IApplicationDbContext
{
    private readonly ICurrentUser _currentUser;

    public AppDbContext(
        DbContextOptions options,
        ICurrentUser currentUser
    ) : base(options)
    {
        _currentUser = currentUser;
    }

    protected override void OnModelCreating(
        ModelBuilder modelBuilder
    )
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var entityStateProperty = entityType.FindProperty(nameof(BaseEntity.EntityState));
            if (entityStateProperty != null)
            {
                modelBuilder.Entity(entityType.ClrType)
                    .Property(nameof(BaseEntity.EntityState))
                    .HasConversion<string>();
            }

            var lastModifiedProperty = entityType.FindProperty(nameof(BaseEntity.LastModifiedUtc));
            if (lastModifiedProperty != null)
            {
                var converter = new ValueConverter<DateTime, string>(
                    v => v.ToString("yyyy-MM-dd HH:mm:ss.ffffff"),
                    v => DateTime.ParseExact(v, "yyyy-MM-dd HH:mm:ss.ffffff",
                        System.Globalization.CultureInfo.InvariantCulture));

                modelBuilder.Entity(entityType.ClrType)
                    .Property(nameof(BaseEntity.LastModifiedUtc))
                    .HasConversion(converter);
            }
        }

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var clrType = entityType.ClrType;
            if (typeof(IShopEntity).IsAssignableFrom(clrType) &&
                typeof(ISoftDeletable).IsAssignableFrom(clrType))
            {
                var method = typeof(AppDbContext)
                    .GetMethod(nameof(SetShopEntityFilter), BindingFlags.NonPublic | BindingFlags.Instance)!
                    .MakeGenericMethod(clrType);
                method.Invoke(this, new object[] { modelBuilder });
            }
            else if (typeof(ISoftDeletable).IsAssignableFrom(clrType))
            {
                var method = typeof(AppDbContext)
                    .GetMethod(nameof(SetSoftDeleteFilter), BindingFlags.NonPublic | BindingFlags.Instance)!
                    .MakeGenericMethod(clrType);
                method.Invoke(this, new object[] { modelBuilder });
            }
        }

        OnModelCreatingPartial(modelBuilder);
    }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder
    )
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    partial void OnModelCreatingPartial(
        ModelBuilder modelBuilder
    );

    public DbSet<Province> Provinces { get; set; }
    public DbSet<ProvinceTranslation> ProvinceTranslations { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<AppLog> AppLogs { get; set; }
    public DbSet<TranslationKey> TranslationKeys { get; set; }
    public DbSet<Translation> Translations { get; set; }
    public DbSet<LocalizedText> LocalizedTexts { get; set; }
    public DbSet<LocalizedTextTranslation> LocalizedTextTranslations { get; set; }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductUnit> ProductUnits { get; set; }
    public DbSet<ProductPrice> ProductPrices { get; set; }
    public DbSet<StockBatch> StockBatches { get; set; }
    public DbSet<StockMovement> StockMovements { get; set; }
    public DbSet<IdempotencyRecord> IdempotencyRecords { get; set; }
    public DbSet<StockCountSession> StockCountSessions { get; set; }
    public DbSet<StockCountLine> StockCountLines { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleLine> SaleLines { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<ShopOwner> ShopOwners { get; set; }
    public DbSet<LoanAccount> LoanAccounts { get; set; }
    public DbSet<LoanAccountPayment> LoanAccountPayments { get; set; }
    public DbSet<ApplicationUserRole> UserRoles { get; set; }
}
