using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(
            EntityTypeBuilder<District> builder
        )
        {
            builder.ConfigureAuditUserRelationships();
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
        }
    }
}