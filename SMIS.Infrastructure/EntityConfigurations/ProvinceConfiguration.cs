using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasKey(x => x.PublicId);
            
            builder.Property(x => x.Id)
                .HasDefaultValue(0);
                
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();

            // Configure the one-to-many relationship with translations
            builder.HasMany(x => x.Translations)
                   .WithOne(t => t.Province)
                   .HasForeignKey(t => t.ProvinceId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}