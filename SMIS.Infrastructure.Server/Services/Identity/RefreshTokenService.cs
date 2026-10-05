using Microsoft.Extensions.Options;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Services;
using System.Security.Cryptography;
using System.Text;

namespace SMIS.Infrastructure.Server.Services.Identity;

public sealed class RefreshTokenService : IRefreshTokenService
{
    private readonly JwtSettings _settings;

    public RefreshTokenService(
        IOptions<JwtSettings> settings
    )
    {
        _settings = settings.Value;
    }

    public RefreshTokenIssue Issue()
    {
        var bytes = RandomNumberGenerator.GetBytes(_settings.RefreshTokenSizeBytes);
        var token = Convert.ToBase64String(bytes)
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');

        return new RefreshTokenIssue(
            token,
            Hash(token),
            DateTimeService.NowUtc.AddDays(_settings.RefreshTokenLifetimeDays));
    }

    public string Hash(
        string token
    )
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(token));
        return Convert.ToHexString(bytes);
    }
}