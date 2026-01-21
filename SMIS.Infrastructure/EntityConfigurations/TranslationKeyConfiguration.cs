using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class TranslationKeyConfiguration : IEntityTypeConfiguration<TranslationKey>
    {
        public void Configure(EntityTypeBuilder<TranslationKey> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasIndex(x => x.MessageCode);

            builder.HasMany(tk => tk.Translations)
                .WithOne(t => t.TranslationKey)
                .HasForeignKey(t => t.TranslationKeyId)
                .HasPrincipalKey(tk => tk.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
