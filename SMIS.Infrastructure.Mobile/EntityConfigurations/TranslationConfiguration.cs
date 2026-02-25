using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Mobile.EntityConfigurations;

public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
{
    public void Configure(EntityTypeBuilder<Translation> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasIndex(x => new { x.TranslationKeyId, x.LanguageNo })
            .IsUnique();

        builder.Property(x => x.TranslationKeyId)
            .IsRequired();

        builder.Property(x => x.LanguageNo)
            .IsRequired();
        
        // Ignore navigation properties for offline database
        builder.Ignore(e => e.TranslationKey);
        builder.Ignore(e => e.Language);
    }
}
