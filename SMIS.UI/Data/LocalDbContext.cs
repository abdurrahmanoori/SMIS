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
            // MAUI-specific: Ignore navigation properties (no relationships in local DB)
            b.Ignore(e => e.Shop);
            b.Ignore(e => e.Products);
        });
    }
}
