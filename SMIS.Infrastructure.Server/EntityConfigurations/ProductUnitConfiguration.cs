using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    // ProductUnit is the product-specific conversion contract. Inventory stores the
    // resulting normalized base quantity, so historical conversions must stay stable.
    public class ProductUnitConfiguration : IEntityTypeConfiguration<ProductUnit>
    {
        public void Configure(
            EntityTypeBuilder<ProductUnit> builder
        )
        {
            builder.ConfigureAuditUserRelationships();
            builder.ConfigureClientAuditUserRelationships();
            builder.ToTable(nameof(ProductUnit));

            builder.HasKey(pu => pu.Id);

            builder.HasAlternateKey(pu => new { pu.Id, pu.ProductId })
                .HasName("AK_ProductUnit_Id_ProductId");

            builder.Property(pu => pu.Id)
                .ValueGeneratedOnAdd();

            builder.Property(pu => pu.ProductId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(pu => pu.UnitOfMeasureId)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasAlternateKey(pu => new { pu.ProductId, pu.UnitOfMeasureId })
                .HasName("AK_ProductUnit_ProductId_UnitOfMeasureId");

            builder.Property(pu => pu.BaseUnitQuantity)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(pu => pu.ProductName)
                .HasMaxLength(200);

            builder.Property(pu => pu.UnitName)
                .HasMaxLength(100);

            builder.Property(pu => pu.ClientCreatedBy).HasMaxLength(450);
            builder.Property(pu => pu.ClientModifiedBy).HasMaxLength(450);

            // Configure relationships
            builder.HasOne(pu => pu.Product)
                .WithMany(p => p.ProductUnits) // Product has a navigation property called ProductUnits
                .HasForeignKey(pu => pu.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pu => pu.UnitOfMeasure)
                .WithMany(u => u.ProductUnits) // UnitOfMeasure has a navigation property called ProductUnits
                .HasForeignKey(pu => pu.UnitOfMeasureId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}