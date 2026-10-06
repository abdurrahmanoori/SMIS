using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities;

namespace SMIS.Application.Services;

public sealed class IdempotencyService : IIdempotencyService
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public IdempotencyService(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<IdempotencyRecord?>> BeginReplayableAsync<TRequest>(
        string scope, string? key, TRequest request, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(key))
            return Result<IdempotencyRecord?>.Success(null);

        var actorId = _currentUser.GetId();
        if (string.IsNullOrWhiteSpace(actorId))
            return Result<IdempotencyRecord?>.BusinessRule(
                "AuthenticatedUserRequired", "An authenticated user is required for idempotent operations.");

        var normalizedScope = scope.Trim();
        var normalizedKey = key.Trim();
        var hash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(request))));
        var existing = await _db.IdempotencyRecords.AsNoTracking().FirstOrDefaultAsync(record =>
                record.ActorId == actorId && record.Scope == normalizedScope && record.Key == normalizedKey,
            cancellationToken);

        if (existing is not null)
        {
            if (existing.RequestHash != hash)
                return Result<IdempotencyRecord?>.Conflict("IdempotencyKeyReused",
                    "The idempotency key was already used for a different request.");
            if (existing.ResponseJson is null)
                return Result<IdempotencyRecord?>.Conflict("DuplicateOperation",
                    "This operation was already accepted without a replayable response.");
            return Result<IdempotencyRecord?>.Success(existing);
        }

        var reservation = IdempotencyRecord.Create(actorId, normalizedScope, normalizedKey, hash);
        await _db.IdempotencyRecords.AddAsync(reservation, cancellationToken);
        return Result<IdempotencyRecord?>.Success(reservation);
    }

    public Result<TResponse> Replay<TResponse>(IdempotencyRecord record) =>
        Result<TResponse>.Success(JsonSerializer.Deserialize<TResponse>(record.ResponseJson!)
                                  ?? throw new JsonException("Stored idempotency response is empty."));

    public void Complete<TResponse>(IdempotencyRecord? record, TResponse response)
    {
        record?.Complete(JsonSerializer.Serialize(response));
    }

    public async Task<Result<bool>> ReserveAsync(
        string scope,
        string? key,
        CancellationToken cancellationToken = default
    )
    {
        if (string.IsNullOrWhiteSpace(key))
            return Result<bool>.Success(false);

        var actorId = _currentUser.GetId();
        if (string.IsNullOrWhiteSpace(actorId))
            return Result<bool>.BusinessRule(
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
            return Result<bool>.Conflict(
                "DuplicateOperation",
                "This request has already been accepted. Reuse of the same idempotency key is not allowed.");

        await _db.IdempotencyRecords.AddAsync(
            IdempotencyRecord.Create(actorId, normalizedScope, normalizedKey),
            cancellationToken);

        return Result<bool>.Success(true);
    }
}