using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Infrastructure.Mobile.DatabaseSeeders;
using SMIS.Infrastructure.Mobile.EntityConfigurations;

namespace SMIS.Infrastructure.Mobile.Context;

public class LocalDbContext : DbContext
{
    public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options) { }

    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        
        // Ignore navigation properties for offline database
        modelBuilder.Entity<Category>(b =>
        {
            b.Ignore(e => e.Shop);
            b.Ignore(e => e.Products);
        });
        
        // Seed data
        CategorySeed.DataSeed(modelBuilder);
    }
}
