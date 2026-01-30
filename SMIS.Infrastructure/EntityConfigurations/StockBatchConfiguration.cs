using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class StockBatchConfiguration : IEntityTypeConfiguration<StockBatch>
    {
        public void Configure(EntityTypeBuilder<StockBatch> builder)
        {
            builder.ToTable(nameof(StockBatch));

            builder.HasKey(s => s.Id);

            builder.Property(s => s.ProductId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.BatchNumber)
                .HasMaxLength(50);

            builder.Property(s => s.Quantity)
                .IsRequired()
                .HasPrecision(18, 4);

            builder.Property(s => s.UnitId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.ReceivedDate)
                .IsRequired();

            builder.Property(s => s.ExpirationDate);

            builder.Property(s => s.PurchasePrice)
                .IsRequired();

            builder.Property(s => s.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.HasIndex(s => s.ProductId);
            builder.HasIndex(s => s.BatchNumber);
            builder.HasIndex(s => s.ExpirationDate);
            builder.HasIndex(s => s.Status);
        }
    }
}