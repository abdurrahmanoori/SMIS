using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class TranslationKeyConfiguration : IEntityTypeConfiguration<TranslationKey>
    {
        public void Configure(EntityTypeBuilder<TranslationKey> builder)
        {
            builder.HasKey(x => x.PublicId);
            
            builder.Property(x => x.Id)
                .HasDefaultValue(0);
                
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);
                
            builder.HasIndex(x => x.MessageCode).IsUnique();
            
            builder.HasMany(tk => tk.Translations)
                .WithOne(t => t.TranslationKey)
                .HasForeignKey(t => t.TranslationKeyPublicId)
                .HasPrincipalKey(tk => tk.PublicId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
