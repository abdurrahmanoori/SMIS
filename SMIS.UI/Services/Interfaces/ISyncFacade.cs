using SMIS.Infrastructure.Mobile.Services.Sync;

namespace SMIS.UI.Services.Interfaces;

public interface ISyncFacade
{
    Task<int> GetTotalPendingCountAsync();
    Task<SyncAllResult> SyncAllAsync();
}
