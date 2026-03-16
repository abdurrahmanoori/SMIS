using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Localization;
using SMIS.Infrastructure.Mobile.DatabaseSeeders;
using SMIS.Infrastructure.Mobile.Entities;
using SMIS.Infrastructure.Mobile.EntityConfigurations;
using SMIS.Infrastructure.Mobile.Interceptors;

namespace SMIS.Infrastructure.Mobile.Context;

public class LocalDbContext : DbContext
{
    public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options) { }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Language> Languages => Set<Language>();
    public DbSet<TranslationKey> TranslationKeys => Set<TranslationKey>();
    public DbSet<Translation> Translations => Set<Translation>();
    public DbSet<DeletedRecord> DeletedRecords => Set<DeletedRecord>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        //optionsBuilder.AddInterceptors(new SyncFlagInterceptor());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new LanguageConfiguration());
        modelBuilder.ApplyConfiguration(new TranslationKeyConfiguration());
        modelBuilder.ApplyConfiguration(new TranslationConfiguration());
        modelBuilder.ApplyConfiguration(new DeletedRecordConfiguration());

        // Seed data
        CategorySeed.DataSeed(modelBuilder);
    }
}
