using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.UI.Data.Interceptors;

namespace SMIS.UI.Data;

public class LocalDbContext : DbContext
{
    private readonly AuditInterceptor _auditInterceptor;

    public DbSet<Category> Categories { get; set; }

    public LocalDbContext(DbContextOptions<LocalDbContext> options, AuditInterceptor auditInterceptor) : base(options)
    {
        _auditInterceptor = auditInterceptor;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditInterceptor);
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
