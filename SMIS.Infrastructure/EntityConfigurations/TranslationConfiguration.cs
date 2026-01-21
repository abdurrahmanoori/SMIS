using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {
            builder.HasKey(x => x.PublicId);

            builder.HasOne(t => t.TranslationKey)
                .WithMany(tk => tk.Translations)
                .HasForeignKey(t => t.TranslationKeyPublicId)
                .HasPrincipalKey(tk => tk.PublicId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Language)
                .WithMany()
                .HasForeignKey(t => t.LanguageNo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}