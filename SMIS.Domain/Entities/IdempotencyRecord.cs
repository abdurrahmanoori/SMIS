using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

/// <summary>
/// Reserves a caller-provided retry key for one business operation. The record is
/// committed in the same database transaction as the operation it protects.
/// </summary>
public sealed class IdempotencyRecord : BaseAuditableEntityWithoutName
{
    public string ActorId { get; private set; } = string.Empty;
    public string Scope { get; private set; } = string.Empty;
    public string Key { get; private set; } = string.Empty;

    internal IdempotencyRecord()
    {
    }

    public static IdempotencyRecord Create(
        string actorId,
        string scope,
        string key
    )
    {
        if (string.IsNullOrWhiteSpace(actorId))
            throw new DomainValidationException("Idempotency actor ID cannot be empty");
        if (string.IsNullOrWhiteSpace(scope))
            throw new DomainValidationException("Idempotency scope cannot be empty");
        if (string.IsNullOrWhiteSpace(key))
            throw new DomainValidationException("Idempotency key cannot be empty");

        return new IdempotencyRecord
        {
            ActorId = actorId.Trim(),
            Scope = scope.Trim(),
            Key = key.Trim()
        };
    }
}