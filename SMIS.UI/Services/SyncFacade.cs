using SMIS.Application.Common.Response;
using SMIS.Infrastructure.Mobile.Services.Sync;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.UI.Services;

// ISyncService is still from mobile infra — this is intentional.
// SyncFacade is the MAUI-specific implementation of ISyncFacade.
public class SyncFacade : ISyncFacade
{
    private readonly ISyncService _syncService;

    public SyncFacade(ISyncService syncService)
    {
        _syncService = syncService;
    }

    public Task<int> GetTotalPendingCountAsync() => _syncService.GetTotalPendingCountAsync();

    public Task<SyncAllResult> SyncAllAsync() => _syncService.SyncAllAsync();
}
