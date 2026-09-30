using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class ApplicationTaskConfiguration : IEntityTypeConfiguration<ApplicationTask>
{
    public void Configure(
        EntityTypeBuilder<ApplicationTask> builder
    )
    {
        builder.ToTable("ApplicationTasks");
        builder.HasKey(task => task.Id);

        builder.Property(task => task.Id).HasMaxLength(450);
        builder.Property(task => task.Key).HasMaxLength(150).IsRequired();
        builder.Property(task => task.Name).HasMaxLength(200).IsRequired();
        builder.Property(task => task.ComponentId).HasMaxLength(450);

        builder.HasIndex(task => task.Key).IsUnique();

        builder.HasOne(task => task.Component)
            .WithMany()
            .HasForeignKey(task => task.ComponentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
