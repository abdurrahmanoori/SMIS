namespace SMIS.Domain.Entities.Identity.Entity;

public sealed class ApplicationRefreshToken
{
    private ApplicationRefreshToken()
    {
    }

    public Guid Id { get; private set; }
    public string UserId { get; private set; } = string.Empty;
    public string TokenHash { get; private set; } = string.Empty;
    public int SecurityVersion { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime ExpiresAtUtc { get; private set; }
    public DateTime? RevokedAtUtc { get; private set; }
    public string? ReplacedByTokenHash { get; private set; }

    public ApplicationUser User { get; private set; } = null!;

    public static ApplicationRefreshToken Create(
        string userId,
        string tokenHash,
        int securityVersion,
        DateTime createdAtUtc,
        DateTime expiresAtUtc
    )
    {
        return new ApplicationRefreshToken
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            TokenHash = tokenHash,
            SecurityVersion = securityVersion,
            CreatedAtUtc = createdAtUtc,
            ExpiresAtUtc = expiresAtUtc
        };
    }

    public void Revoke(
        DateTime revokedAtUtc,
        string? replacedByTokenHash = null
    )
    {
        if (RevokedAtUtc.HasValue) return;

        RevokedAtUtc = revokedAtUtc;
        ReplacedByTokenHash = replacedByTokenHash;
    }
}