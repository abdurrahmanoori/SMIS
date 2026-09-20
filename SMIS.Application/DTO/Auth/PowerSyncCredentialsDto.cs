namespace SMIS.Application.DTO.Auth;

public sealed record PowerSyncCredentialsDto(
    string Endpoint,
    string Token,
    DateTime ExpiresAtUtc
);