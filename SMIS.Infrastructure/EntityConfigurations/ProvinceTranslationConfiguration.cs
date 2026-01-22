using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class ProvinceTranslationConfiguration : IEntityTypeConfiguration<ProvinceTranslation>
    {
        public void Configure(EntityTypeBuilder<ProvinceTranslation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LanguageCode).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();

            builder.HasIndex(x => new { x.ProvinceId, x.LanguageId }).IsUnique();

            builder.HasOne(x => x.Province)
                   .WithMany(p => p.Translations)
                   .HasForeignKey(x => x.ProvinceId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Language)
                   .WithMany()
                   .HasForeignKey(x => x.LanguageId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
