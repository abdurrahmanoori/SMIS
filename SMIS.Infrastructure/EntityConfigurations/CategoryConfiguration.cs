using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(nameof(Category));

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
