using SMIS.Application.Common.Response;

namespace SMIS.Application.Services;

public interface IIdempotencyService
{
    Task<Result<bool>> ReserveAsync(
        string scope,
        string? key,
        CancellationToken cancellationToken = default
    );
}