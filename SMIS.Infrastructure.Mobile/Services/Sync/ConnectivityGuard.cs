using SMIS.Application.Common.Response;

namespace SMIS.Infrastructure.Mobile.Services.Sync;

internal static class ConnectivityGuard
{
    private const string NoInternetMessage = "No internet connection";

    /// <summary>
    /// Returns <c>true</c> when the device has internet access, <c>false</c> otherwise.
    /// </summary>
    internal static bool IsConnected(IConnectivity? connectivity)
        => connectivity?.NetworkAccess == NetworkAccess.Internet;

    /// <summary>
    /// Builds a standard offline <see cref="SyncResult"/> to return when <see cref="IsConnected"/> is false.
    /// </summary>
    internal static SyncResult OfflineResult()
        => new SyncResult { Success = false, Message = NoInternetMessage };
}
