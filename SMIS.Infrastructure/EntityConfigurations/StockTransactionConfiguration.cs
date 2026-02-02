using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class StockTransactionConfiguration : IEntityTypeConfiguration<StockTransaction>
    {
        public void Configure(EntityTypeBuilder<StockTransaction> builder)
        {
            builder.ToTable(nameof(StockTransaction));

            builder.HasKey(st => st.Id);

            builder.Property(st => st.ShopId)
                .IsRequired();

            builder.Property(st => st.ShopName)
                .HasMaxLength(200);

            builder.Property(st => st.ProductId)
                .IsRequired();

            builder.Property(st => st.ProductName)
                .HasMaxLength(200);

            builder.Property(st => st.StockBatchId)
                .IsRequired();

            builder.Property(st => st.Quantity)
                .IsRequired()
                .HasPrecision(18, 4);

            builder.Property(st => st.UnitId)
                .IsRequired();

            builder.Property(st => st.UnitName)
                .HasMaxLength(100);

            builder.Property(st => st.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(st => st.TransactionDate)
                .IsRequired();

            builder.Property(st => st.Reference)
                .HasMaxLength(200);

            // Foreign keys
            builder.HasOne(st => st.Shop)
                .WithMany()
                .HasForeignKey(st => st.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(st => st.Product)
                .WithMany()
                .HasForeignKey(st => st.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(st => st.StockBatch)
                .WithMany()
                .HasForeignKey(st => st.StockBatchId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(st => st.UnitOfMeasure)
                .WithMany()
                .HasForeignKey(st => st.UnitId)
                .OnDelete(DeleteBehavior.Restrict);

            // Indexes
            builder.HasIndex(st => st.ShopId);
            builder.HasIndex(st => st.ProductId);
            builder.HasIndex(st => st.StockBatchId);
            builder.HasIndex(st => st.TransactionDate);
            builder.HasIndex(st => st.Type);
        }
    }
}