using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.ShopId)
                .IsRequired();

            builder.Property(p => p.BaseUnitId)
                .IsRequired();

            builder.Property(p => p.SalePricePerBaseUnit)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(500);

            builder.Property(p => p.IsActive)
                .IsRequired();

            builder.Property(p => p.SKU)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Barcode)
                .HasMaxLength(100);

            builder.Property(p => p.ImageUrl)
                .HasMaxLength(500);

            builder.Property(p => p.CategoryId)
                .HasMaxLength(50);

            // Foreign keys
            builder.HasOne(p => p.Shop)
                .WithMany() // Shop has commented navigation to Products
                .HasForeignKey(p => p.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.UnitOfMeasure)
                .WithMany()
                .HasForeignKey(p => p.BaseUnitId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}