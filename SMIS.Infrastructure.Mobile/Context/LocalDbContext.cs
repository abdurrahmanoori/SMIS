using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Localization;
using SMIS.Infrastructure.Mobile.DatabaseSeeders;
using SMIS.Infrastructure.Mobile.EntityConfigurations;

namespace SMIS.Infrastructure.Mobile.Context;

public class LocalDbContext : DbContext
{
    public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options) { }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Language> Languages => Set<Language>();
    public DbSet<TranslationKey> TranslationKeys => Set<TranslationKey>();
    public DbSet<Translation> Translations => Set<Translation>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.ConfigureWarnings(warnings => 
            warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new LanguageConfiguration());
        modelBuilder.ApplyConfiguration(new TranslationKeyConfiguration());
        modelBuilder.ApplyConfiguration(new TranslationConfiguration());
        
        // Seed data
        CategorySeed.DataSeed(modelBuilder);
    }
}
