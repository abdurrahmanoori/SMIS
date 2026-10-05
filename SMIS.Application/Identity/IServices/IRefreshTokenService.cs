namespace SMIS.Application.Identity.IServices;

public sealed record RefreshTokenIssue(
    string Token,
    string TokenHash,
    DateTime ExpiresAtUtc
);

public interface IRefreshTokenService
{
    RefreshTokenIssue Issue();

    string Hash(
        string token
    );
}