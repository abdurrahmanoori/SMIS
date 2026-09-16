using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities;

namespace SMIS.Application.Services;

public sealed class IdempotencyService : IIdempotencyService
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public IdempotencyService(IApplicationDbContext db, ICurrentUser currentUser)
    {
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<bool>> ReserveAsync(
        string scope,
        string? key,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(key))
            return Result<bool>.SuccessResult(false);

        var actorId = _currentUser.GetId();
        if (string.IsNullOrWhiteSpace(actorId))
            return Result<bool>.FailureResult(
                "AuthenticatedUserRequired",
                "An authenticated user is required for idempotent operations.");

        var normalizedScope = scope.Trim();
        var normalizedKey = key.Trim();
        var exists = await _db.IdempotencyRecords
            .AnyAsync(record =>
                    record.ActorId == actorId &&
                    record.Scope == normalizedScope &&
                    record.Key == normalizedKey,
                cancellationToken);

        if (exists)
            return Result<bool>.FailureResult(
                "DuplicateOperation",
                "This request has already been accepted. Reuse of the same idempotency key is not allowed.");

        await _db.IdempotencyRecords.AddAsync(
            IdempotencyRecord.Create(actorId, normalizedScope, normalizedKey),
            cancellationToken);

        return Result<bool>.SuccessResult(true);
    }
}
