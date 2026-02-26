using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Mobile.EntityConfigurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.Version).IsRequired().HasDefaultValue(0);
        builder.Property(x => x.EntityState).IsRequired().HasConversion<string>();
        builder.Property(x => x.LastModifiedUtc).IsRequired();
            
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);
            
        builder.Property(x => x.Code)
            .HasMaxLength(10);
            
        builder.HasIndex(x => x.Code).IsUnique();
    }
}
