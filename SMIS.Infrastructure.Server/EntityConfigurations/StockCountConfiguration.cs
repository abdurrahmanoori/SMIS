using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class StockCountSessionConfiguration : IEntityTypeConfiguration<StockCountSession>
{
    public void Configure(EntityTypeBuilder<StockCountSession> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(StockCountSession));
        builder.HasKey(session => session.Id);

        builder.Property(session => session.ShopId).IsRequired().HasMaxLength(450);
        builder.Property(session => session.StartedAtUtc).IsRequired();
        builder.Property(session => session.CompletedAtUtc);
        builder.Property(session => session.Status).IsRequired().HasConversion<string>().HasMaxLength(30);
        builder.Property(session => session.Notes).HasMaxLength(500);

        builder.HasOne(session => session.Shop)
            .WithMany()
            .HasForeignKey(session => session.ShopId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(session => session.Lines)
            .WithOne(line => line.StockCountSession)
            .HasForeignKey(line => line.StockCountSessionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(session => session.ShopId);
        builder.HasIndex(session => session.Status);
        builder.HasIndex(session => session.StartedAtUtc);
    }
}

public sealed class StockCountLineConfiguration : IEntityTypeConfiguration<StockCountLine>
{
    public void Configure(EntityTypeBuilder<StockCountLine> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(StockCountLine));
        builder.HasKey(line => line.Id);

        builder.Property(line => line.StockCountSessionId).IsRequired().HasMaxLength(450);
        builder.Property(line => line.StockBatchId).IsRequired().HasMaxLength(450);
        builder.Property(line => line.ExpectedQuantityBase).IsRequired().HasPrecision(18, 4);
        builder.Property(line => line.CountedQuantityBase).HasPrecision(18, 4);
        builder.Property(line => line.DifferenceBase).IsRequired().HasPrecision(18, 4);

        builder.HasOne(line => line.StockBatch)
            .WithMany()
            .HasForeignKey(line => line.StockBatchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(line => new { line.StockCountSessionId, line.StockBatchId })
            .IsUnique();
        builder.HasIndex(line => line.StockBatchId);
    }
}
