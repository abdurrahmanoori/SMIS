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

        builder.Property(p => p.Price)
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

        builder.HasIndex(p => new { p.ProductId, p.EffectiveDate });
        builder.HasIndex(p => p.IsActive);
    }
}
