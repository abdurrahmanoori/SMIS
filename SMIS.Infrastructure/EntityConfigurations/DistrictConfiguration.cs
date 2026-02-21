using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();

            // Configure one-to-one relationship with TranslationKey using Id
            builder.HasOne(d => d.TranslationKey)
                .WithOne()
                .HasForeignKey<District>(d => d.TranslationKeyId)
                .HasPrincipalKey<TranslationKey>(tk => tk.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}