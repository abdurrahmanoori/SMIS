using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.EntityConfigurations
{
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

            builder.HasOne(t => t.TranslationKey)
                .WithMany(tk => tk.Translations)
                .HasForeignKey(t => t.TranslationKeyId)
                .HasPrincipalKey(tk => tk.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Language)
                .WithMany()
                .HasForeignKey(t => t.LanguageNo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}