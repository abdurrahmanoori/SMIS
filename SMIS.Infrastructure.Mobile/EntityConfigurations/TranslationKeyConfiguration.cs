using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Mobile.EntityConfigurations;

public class TranslationKeyConfiguration : IEntityTypeConfiguration<TranslationKey>
{
    public void Configure(EntityTypeBuilder<TranslationKey> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.MessageCode)
            .HasMaxLength(100);

        builder.HasIndex(x => x.MessageCode);
        
        // Ignore navigation properties for offline database
        builder.Ignore(e => e.Translations);
    }
}
