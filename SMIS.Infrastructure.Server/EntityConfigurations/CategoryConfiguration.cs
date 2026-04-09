using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(nameof(Category));

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Code)
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasMaxLength(500);

            builder.Property(c => c.ShopId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(c => c.IsActive)
                .IsRequired();

            // Backend-specific: Relationships
            builder.HasOne(c => c.Shop)
                .WithMany()
                .HasForeignKey(c => c.ShopId)
                .OnDelete(DeleteBehavior.Restrict);
            
            // Backend-specific: Ignore offline properties
            builder.Ignore(c => c.IsSyncedToServer);
            builder.Ignore(c => c.LastSyncedAt);
        }
    }
}
