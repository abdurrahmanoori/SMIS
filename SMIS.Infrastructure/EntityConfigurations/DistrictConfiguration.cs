using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(x => x.PublicId);
            
            builder.Property(x => x.Id)
                .HasDefaultValue(0);
                
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
        }
    }
}