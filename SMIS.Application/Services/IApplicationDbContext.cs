using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Services;

public interface IApplicationDbContext
{
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
    public DbSet<Customer> Customers { get; set; }
    public DbSet<ShopOwner> ShopOwners { get; set; }
    public DbSet<LoanAccount> LoanAccounts { get; set; }
    public DbSet<LoanAccountPayment> LoanAccountPayments { get; set; }
    public DbSet<ApplicationUserRole> UserRoles { get; set; }

    Task<int> SaveChangesAsync(
        CancellationToken cancellationToken
    );
}