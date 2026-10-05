using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Auth.Commands;

public sealed record RevokeRefreshTokenCommand(string RefreshToken) : IRequest<Result>;

internal sealed class RevokeRefreshTokenCommandHandler
    : IRequestHandler<RevokeRefreshTokenCommand, Result>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IRefreshTokenService _refreshTokenService;

    public RevokeRefreshTokenCommandHandler(
        IApplicationDbContext dbContext,
        IRefreshTokenService refreshTokenService
    )
    {
        _dbContext = dbContext;
        _refreshTokenService = refreshTokenService;
    }

    public async Task<Result> Handle(
        RevokeRefreshTokenCommand request,
        CancellationToken cancellationToken
    )
    {
        if (string.IsNullOrWhiteSpace(request.RefreshToken)) return Result.Success();

        var tokenHash = _refreshTokenService.Hash(request.RefreshToken);
        var storedToken = await _dbContext.RefreshTokens.SingleOrDefaultAsync(
            token => token.TokenHash == tokenHash,
            cancellationToken);

        // Deliberately return success for unknown/already-revoked tokens so the
        // endpoint does not reveal whether a supplied refresh token ever existed.
        if (storedToken is null || storedToken.RevokedAtUtc.HasValue) return Result.Success();

        storedToken.Revoke(DateTimeService.NowUtc);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Result.Success();
    }
}