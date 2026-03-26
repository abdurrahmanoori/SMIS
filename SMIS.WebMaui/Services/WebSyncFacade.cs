using SMIS.Application.Common.Response;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.WebMaui.Services;

// Web app has no offline queue — sync is a no-op
public class WebSyncFacade : ISyncFacade
{
    public Task<int> GetTotalPendingCountAsync()
        => Task.FromResult(0);

    public Task<SyncAllResult> SyncAllAsync()
        => Task.FromResult(new SyncAllResult { Success = true, TotalSynced = 0, TotalFailed = 0 });
}
