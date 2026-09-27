using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public class LocalizedTextTranslationConfiguration : IEntityTypeConfiguration<LocalizedTextTranslation>
{
    public void Configure(EntityTypeBuilder<LocalizedTextTranslation> builder)
    {
        builder.ToTable(nameof(LocalizedTextTranslation));
        builder.HasKey(x => x.Id);

        builder.Property(x => x.LocalizedTextId)
            .IsRequired()
            .HasMaxLength(450);

        builder.Property(x => x.LanguageId)
            .IsRequired()
            .HasMaxLength(450);

        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(1000);

        builder.HasIndex(x => new { x.LocalizedTextId, x.LanguageId })
            .IsUnique();

        builder.HasOne(x => x.Language)
            .WithMany()
            .HasForeignKey(x => x.LanguageId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
