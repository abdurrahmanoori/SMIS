using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class AppLogConfiguration : IEntityTypeConfiguration<AppLog>
    {
        public void Configure(EntityTypeBuilder<AppLog> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Level)
                .IsRequired()
                .HasMaxLength(50);
                
            builder.Property(x => x.Message)
                .IsRequired();
                
            builder.Property(x => x.Exception);
            
            builder.Property(x => x.Properties);
            
            builder.Property(x => x.UserId);
            
            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.HasIndex(x => x.Level);
            builder.HasIndex(x => x.CreatedAt);
            builder.HasIndex(x => x.UserId);
        }
    }
}