using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.UI.Data;

public class LocalDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "smis_local.db");
        options.UseSqlite($"Data Source={dbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(b =>
        {
            b.HasKey(e => e.Id);
            b.Property(e => e.Name).IsRequired().HasMaxLength(200);
            b.Property(e => e.Code).HasMaxLength(50);
            b.Property(e => e.Description).HasMaxLength(500);
            b.Property(e => e.ShopId).IsRequired();
            
            // Offline properties now in BaseEntity - no shadow properties needed
            b.Property(e => e.IsSyncedToServer);
            b.Property(e => e.LastSyncedAt);
            
            // Ignore navigation properties for local DB
            b.Ignore(e => e.Shop);
            b.Ignore(e => e.Products);
        });
    }
}
