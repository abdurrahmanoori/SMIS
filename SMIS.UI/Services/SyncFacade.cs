using SMIS.Infrastructure.Mobile.Services.Sync;
using SMIS.UI.Services.Interfaces;

namespace SMIS.UI.Services;

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
