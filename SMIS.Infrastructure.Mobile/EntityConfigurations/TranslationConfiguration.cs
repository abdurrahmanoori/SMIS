using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Mobile.EntityConfigurations;

public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
{
    public void Configure(EntityTypeBuilder<Translation> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.IsPublic).IsRequired().HasDefaultValue(false);
        builder.Property(x => x.Version).IsRequired().HasDefaultValue(0);
        builder.Property(x => x.EntityState).IsRequired().HasConversion<string>();
        builder.Property(x => x.LastModifiedUtc).IsRequired();
        builder.Property(x => x.IsSyncedToServer).IsRequired().HasDefaultValue(false);
        builder.Property(x => x.LastSyncedAt);
        builder.Property(x => x.CreatedBy);
        builder.Property(x => x.CreatedDate);
        builder.Property(x => x.UpdatedBy);
        builder.Property(x => x.UpdatedDate);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasIndex(x => new { x.TranslationKeyId, x.LanguageNo })
            .IsUnique();

        builder.Property(x => x.TranslationKeyId)
            .IsRequired();

        builder.Property(x => x.LanguageNo)
            .IsRequired();
    }
}
