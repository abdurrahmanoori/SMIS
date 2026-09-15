using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(
            EntityTypeBuilder<Product> builder
        )
        {
            builder.ConfigureAuditUserRelationships();
            builder.ConfigureClientAuditUserRelationships();
            builder.ToTable(nameof(Product));

            builder.HasKey(p => p.Id);

            builder.HasAlternateKey(p => new { p.Id, p.ShopId })
                .HasName("AK_Product_Id_ShopId");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.ShopId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(p => p.ShopName)
                .HasMaxLength(200);

            builder.Property(p => p.BaseUnitId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(p => p.BaseUnitName)
                .HasMaxLength(100);

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
                .HasMaxLength(450);

            builder.Property(p => p.CategoryName)
                .HasMaxLength(200);

            builder.Property(p => p.ClientCreatedBy)
                .HasMaxLength(450);

            builder.Property(p => p.ClientModifiedBy)
                .HasMaxLength(450);

            builder.HasIndex(p => new { p.ShopId, p.SKU })
                .IsUnique()
                .HasFilter("[IsDeleted] = 0")
                .HasDatabaseName("UX_Product_ShopId_SKU_Active");

            builder.HasIndex(p => new { p.ShopId, p.Barcode })
                .IsUnique()
                .HasFilter("[IsDeleted] = 0 AND [Barcode] IS NOT NULL")
                .HasDatabaseName("UX_Product_ShopId_Barcode_Active");

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