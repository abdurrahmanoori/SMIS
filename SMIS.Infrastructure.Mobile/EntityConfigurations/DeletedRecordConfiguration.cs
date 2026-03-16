using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Infrastructure.Mobile.Entities;

namespace SMIS.Infrastructure.Mobile.EntityConfigurations;

public class DeletedRecordConfiguration : IEntityTypeConfiguration<DeletedRecord>
{
    public void Configure(EntityTypeBuilder<DeletedRecord> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.EntityType).IsRequired().HasMaxLength(100);
        builder.Property(e => e.EntityId).IsRequired().HasMaxLength(100);
        builder.Property(e => e.ApiEndpoint).IsRequired().HasMaxLength(200);
        builder.Property(e => e.DeletedAt).IsRequired();
        builder.Property(e => e.IsSyncedToServer).IsRequired().HasDefaultValue(false);
        builder.Property(e => e.RetryCount).IsRequired().HasDefaultValue(0);

        builder.HasIndex(e => e.IsSyncedToServer);
        builder.HasIndex(e => e.EntityType);
    }
}
