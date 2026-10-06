using SMIS.Application.Common.Response;
using SMIS.Domain.Entities;

namespace SMIS.Application.Services;

public interface IIdempotencyService
{
    Task<Result<IdempotencyRecord?>> BeginReplayableAsync<TRequest>(
        string scope, string? key, TRequest request, CancellationToken cancellationToken = default);

    Result<TResponse> Replay<TResponse>(IdempotencyRecord record);

    void Complete<TResponse>(IdempotencyRecord? record, TResponse response);

    Task<Result<bool>> ReserveAsync(
        string scope,
        string? key,
        CancellationToken cancellationToken = default
    );
}