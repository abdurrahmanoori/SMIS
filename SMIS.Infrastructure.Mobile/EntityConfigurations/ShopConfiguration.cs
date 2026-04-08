using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Mobile.EntityConfigurations;

public class ShopConfiguration : IEntityTypeConfiguration<Shop>
{
    public void Configure(EntityTypeBuilder<Shop> builder)
    {
        builder.HasKey(e => e.Id);

        // BaseEntity properties
        builder.Property(e => e.Id).IsRequired();
        builder.Property(e => e.IsPublic).IsRequired().HasDefaultValue(false);
        builder.Property(e => e.Version).IsRequired().HasDefaultValue(0);
        builder.Property(e => e.EntityState).IsRequired();
        builder.Property(e => e.LastModifiedUtc).IsRequired();
        builder.Property(e => e.IsSyncedToServer).IsRequired().HasDefaultValue(false);
        builder.Property(e => e.LastSyncedAt);

        // BaseAuditableEntity properties
        builder.Property(e => e.CreatedBy);
        builder.Property(e => e.CreatedDate);
        builder.Property(e => e.UpdatedBy);
        builder.Property(e => e.UpdatedDate);

        // Shop properties
        builder.Property(e => e.Name).IsRequired().HasMaxLength(200);
        builder.Property(e => e.ShopType).IsRequired().HasConversion<string>();
        builder.Property(e => e.Address).HasMaxLength(500);
        builder.Property(e => e.PhoneNumber).HasMaxLength(50);
        builder.Property(e => e.Email).HasMaxLength(100);
        builder.Property(e => e.TaxNumber).HasMaxLength(50);
        builder.Property(e => e.IsActive).IsRequired();

        // Enum as string
        builder.Property(e => e.EntityState).HasConversion<string>();

        // Indexes
        builder.HasIndex(e => e.IsSyncedToServer);
        builder.HasIndex(e => e.LastModifiedUtc);

        // Ignore navigation properties (none currently active on Shop)
    }
}
