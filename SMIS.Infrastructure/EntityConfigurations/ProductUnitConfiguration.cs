using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class ProductUnitConfiguration : IEntityTypeConfiguration<ProductUnit>
    {
        public void Configure(EntityTypeBuilder<ProductUnit> builder)
        {
            builder.ToTable(nameof(ProductUnit));

            builder.HasKey(pu => pu.Id);

            builder.Property(pu => pu.Id)
                .ValueGeneratedOnAdd();

            builder.Property(pu => pu.ConversionFactor)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(pu => pu.ProductName)
                .HasMaxLength(200);

            builder.Property(pu => pu.UnitName)
                .HasMaxLength(100);

            // Configure relationships
            builder.HasOne(pu => pu.Product)
                .WithMany(p => p.ProductUnits) // Product has a navigation property called ProductUnits
                .HasForeignKey(pu => pu.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pu => pu.UnitOfMeasure)
                .WithMany(u => u.ProductUnits) // UnitOfMeasure has a navigation property called ProductUnits
                .HasForeignKey(pu => pu.UnitOfMeasureId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}