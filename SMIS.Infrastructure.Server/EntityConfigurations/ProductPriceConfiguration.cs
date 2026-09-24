using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
{
    public void Configure(
        EntityTypeBuilder<ProductPrice> builder
    )
    {
        builder.ConfigureAuditUserRelationships();
        builder.IgnoreLegacySyncMetadata();
        builder.ToTable(nameof(ProductPrice));

        builder.HasKey(p => p.Id);

        builder.Property(p => p.ProductUnitId)
            .IsRequired()
            .HasMaxLength(450);

        builder.Property(p => p.SellPrice)
            .IsRequired();

        builder.Property(p => p.EffectiveDate)
            .IsRequired();

        builder.Property(p => p.EndDate);

        builder.HasOne(p => p.ProductUnit)
            .WithMany(pu => pu.ProductPrices)
            .HasForeignKey(p => p.ProductUnitId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(p => new { p.ProductUnitId, p.EffectiveDate });
    }
}