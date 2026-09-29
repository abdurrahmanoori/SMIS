using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class ApplicationComponentConfiguration : IEntityTypeConfiguration<ApplicationComponent>
{
    public void Configure(
        EntityTypeBuilder<ApplicationComponent> builder
    )
    {
        builder.ToTable("ApplicationComponents");
        builder.HasKey(component => component.Id);

        builder.Property(component => component.Id)
            .HasMaxLength(450);

        builder.Property(component => component.Key)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(component => component.Name)
            .HasMaxLength(200)
            .IsRequired();

        builder.HasIndex(component => component.Key)
            .IsUnique();
    }
}
