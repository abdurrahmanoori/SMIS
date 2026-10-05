using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class ApplicationRefreshTokenConfiguration : IEntityTypeConfiguration<ApplicationRefreshToken>
{
    public void Configure(
        EntityTypeBuilder<ApplicationRefreshToken> builder
    )
    {
        builder.ToTable("ApplicationRefreshTokens");
        builder.HasKey(token => token.Id);

        builder.Property(token => token.UserId)
            .IsRequired()
            .HasMaxLength(450);

        builder.Property(token => token.TokenHash)
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(token => token.ReplacedByTokenHash)
            .HasMaxLength(64);

        builder.HasIndex(token => token.TokenHash)
            .IsUnique();

        builder.HasIndex(token => new { token.UserId, token.ExpiresAtUtc });

        builder.HasOne(token => token.User)
            .WithMany()
            .HasForeignKey(token => token.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}