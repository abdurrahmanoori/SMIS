using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(x => x.PublicId);
                
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();

            // Configure one-to-one relationship with TranslationKey using PublicId
            builder.HasOne(d => d.TranslationKey)
                .WithOne()
                .HasForeignKey<District>(d => d.TranslationKeyId)
                .HasPrincipalKey<TranslationKey>(tk => tk.PublicId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}