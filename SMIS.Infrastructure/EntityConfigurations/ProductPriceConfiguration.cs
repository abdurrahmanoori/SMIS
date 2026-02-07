using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations;

public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
{
    public void Configure(EntityTypeBuilder<ProductPrice> builder)
    {
        builder.ToTable(nameof(ProductPrice));

        builder.HasKey(p => p.Id);

        builder.Property(p => p.ProductId)
            .IsRequired();

        builder.Property(p => p.ProductUnitId)
            .IsRequired();

        builder.Property(p => p.BuyPrice)
            .IsRequired();

        builder.Property(p => p.SellPrice)
            .IsRequired();

        builder.Property(p => p.EffectiveDate)
            .IsRequired();

        builder.Property(p => p.EndDate);

        builder.Property(p => p.IsActive)
            .IsRequired();

        builder.HasOne(p => p.Product)
            .WithMany(p => p.ProductPrices)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.ProductUnit)
            .WithMany()
            .HasForeignKey(p => p.ProductUnitId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(p => new { p.ProductId, p.ProductUnitId, p.EffectiveDate });
        builder.HasIndex(p => p.IsActive);
    }
}
