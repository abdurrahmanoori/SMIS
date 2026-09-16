using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class StockMovementConfiguration : IEntityTypeConfiguration<StockMovement>
{
    public void Configure(
        EntityTypeBuilder<StockMovement> builder
    )
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(StockMovement));

        builder.HasKey(m => m.Id);

        builder.Property(m => m.ShopId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(m => m.StockBatchId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(m => m.ProductUnitId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(m => m.QuantityEntered)
            .IsRequired()
            .HasPrecision(18, 4);
        builder.Property(m => m.QuantityBase)
            .IsRequired()
            .HasPrecision(18, 4);
        builder.Property(m => m.Direction)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(20);
        builder.Property(m => m.Reason)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(50);
        builder.Property(m => m.OccurredAtUtc)
            .IsRequired();
        builder.Property(m => m.ReferenceType)
            .HasMaxLength(100);
        builder.Property(m => m.ReferenceId)
            .HasMaxLength(450);

        builder.HasOne(m => m.Shop)
            .WithMany()
            .HasForeignKey(m => m.ShopId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(m => m.StockBatch)
            .WithMany(b => b.StockMovements)
            .HasForeignKey(m => new { m.StockBatchId, m.ShopId })
            .HasPrincipalKey(b => new { b.Id, b.ShopId })
            .OnDelete(DeleteBehavior.Restrict);

        // Include ShopId in the FK so cross-tenant movement/batch references are
        // rejected by SQL Server rather than relying only on query filters.

        builder.HasOne(m => m.ProductUnit)
            .WithMany()
            .HasForeignKey(m => m.ProductUnitId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(m => m.ShopId);
        builder.HasIndex(m => m.StockBatchId);
        builder.HasIndex(m => m.ProductUnitId);
        builder.HasIndex(m => m.OccurredAtUtc);
        builder.HasIndex(m => new { m.ReferenceType, m.ReferenceId });
    }
}