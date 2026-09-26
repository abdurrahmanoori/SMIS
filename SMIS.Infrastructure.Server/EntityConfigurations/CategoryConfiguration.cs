using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(
            EntityTypeBuilder<Category> builder
        )
        {
            builder.ConfigureAuditUserRelationships();
            builder.ToTable(nameof(Category));

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.NameLocalizedTextId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(c => c.Code)
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasMaxLength(500);

            builder.Property(c => c.ShopId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(c => c.IsActive)
                .IsRequired();

            builder.HasIndex(c => new { c.ShopId, c.Name })
                .IsUnique()
                .HasDatabaseName("UX_Category_ShopId_Name")
                .HasFilter("[IsDeleted] = 0");

            builder.HasIndex(c => c.NameLocalizedTextId)
                .IsUnique()
                .HasDatabaseName("UX_Category_NameLocalizedTextId");

            builder.HasOne(c => c.NameLocalizedText)
                .WithOne()
                .HasForeignKey<Category>(c => c.NameLocalizedTextId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Shop)
                .WithMany()
                .HasForeignKey(c => c.ShopId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
