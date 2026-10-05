namespace SMIS.Infrastructure.Server.Services.Identity;

public sealed class JwtSettings
{
    public const string SectionName = "JwtSettings";

    public string Key { get; init; } = string.Empty;
    public string Issuer { get; init; } = string.Empty;
    public string Audience { get; init; } = string.Empty;
    public int AccessTokenLifetimeMinutes { get; init; }
    public int RefreshTokenLifetimeDays { get; init; }
    public int RefreshTokenSizeBytes { get; init; }
    public int ClockSkewSeconds { get; init; }
}