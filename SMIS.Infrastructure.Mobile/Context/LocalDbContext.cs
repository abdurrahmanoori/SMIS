using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Mobile.DatabaseSeeders;
using SMIS.Infrastructure.Mobile.EntityConfigurations;

namespace SMIS.Infrastructure.Mobile.Context;

public class LocalDbContext : DbContext
{
    public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options) { }

    public DbSet<Category> Categories => Set<Category>();

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
        
        // Seed data
        CategorySeed.DataSeed(modelBuilder);
    }
}
