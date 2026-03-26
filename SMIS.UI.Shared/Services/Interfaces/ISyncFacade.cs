using SMIS.Application.Common.Response;

namespace SMIS.UI.Shared.Services.Interfaces;

public interface ISyncFacade
{
    Task<int> GetTotalPendingCountAsync();
    Task<SyncAllResult> SyncAllAsync();
}
