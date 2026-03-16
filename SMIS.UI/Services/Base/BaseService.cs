using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Infrastructure.Mobile.Services.Sync;

namespace SMIS.UI.Services.Base;

public abstract class BaseService
{
    protected readonly IMediator Mediator;
    protected readonly IConnectivity Connectivity;
    protected readonly ISyncService SyncService;

    protected BaseService(IMediator mediator, IConnectivity connectivity, ISyncService syncService)
    {
        Mediator = mediator;
        Connectivity = connectivity;
        SyncService = syncService;
    }

    protected async Task<Result<T>> SendAsync<T>(IRequest<Result<T>> request)
        => await Mediator.Send(request);

    protected async Task<Result<T>> SendAndSyncAsync<T>(IRequest<Result<T>> request, Func<Task<SyncResult>> syncFunc)
    {
        var result = await Mediator.Send(request);

        if (result.Success && Connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            var syncResult = await syncFunc();
            if (!syncResult.Success)
                result.Message = string.IsNullOrEmpty(result.Message)
                    ? $"Sync: {syncResult.Message}"
                    : $"{result.Message} (Sync: {syncResult.Message})";
        }

        return result;
    }

    protected static Result<T> NotFound<T>(string id) => Result<T>.NotFoundResult(id);

    protected static Result<T> Failure<T>(string description) => Result<T>.FailureResult(description);
}
