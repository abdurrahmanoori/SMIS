using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class StockBatchConfiguration : IEntityTypeConfiguration<StockBatch>
    {
        public void Configure(
            EntityTypeBuilder<StockBatch> builder
        )
        {
            builder.ConfigureAuditUserRelationships();
            builder.ToTable(nameof(StockBatch));

            builder.HasKey(s => s.Id);

            builder.HasAlternateKey(s => new { s.Id, s.ShopId })
                .HasName("AK_StockBatch_Id_ShopId");

            builder.Property(s => s.ShopId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(s => s.ProductId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(s => s.ReceivedProductUnitId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(s => s.ReceivedQuantity)
                .IsRequired()
                .HasPrecision(18, 4);

            builder.Property(s => s.ReceivedQuantityBase)
                .IsRequired()
                .HasPrecision(18, 4);

            builder.Property(s => s.RemainingQuantityBase)
                .IsRequired()
                .HasPrecision(18, 4);

            builder.Property(s => s.UnitCostBase)
                .IsRequired();

            builder.Property(s => s.BatchNumber)
                .HasMaxLength(50);

            builder.Property(s => s.ReceivedAtUtc)
                .IsRequired();

            builder.Property(s => s.ExpirationDate);

            builder.Property(s => s.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(s => s.Version)
                .IsConcurrencyToken();

            builder.HasOne(s => s.Shop)
                .WithMany()
                .HasForeignKey(s => s.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Product)
                .WithMany()
                .HasForeignKey(s => new { s.ProductId, s.ShopId })
                .HasPrincipalKey(p => new { p.Id, p.ShopId })
                .OnDelete(DeleteBehavior.Restrict);

            // Composite FK makes shop isolation a database invariant: a batch cannot
            // point at a product that belongs to another shop even if application code errs.

            builder.HasOne(s => s.ReceivedProductUnit)
                .WithMany()
                .HasForeignKey(s => new { s.ReceivedProductUnitId, s.ProductId })
                .HasPrincipalKey(pu => new { pu.Id, pu.ProductId })
                .OnDelete(DeleteBehavior.Restrict);

            // The composite relationship guarantees the selected ProductUnit belongs
            // to the same Product represented by this batch.

            builder.HasIndex(s => s.ShopId);
            builder.HasIndex(s => s.ProductId);
            builder.HasIndex(s => s.ReceivedProductUnitId);
            builder.HasIndex(s => s.BatchNumber);
            builder.HasIndex(s => s.ExpirationDate);
            builder.HasIndex(s => s.ReceivedAtUtc);
            builder.HasIndex(s => s.Status);
        }
    }
}