namespace SMIS.Application.Common.Response;

public class SyncResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public int SyncedCount { get; set; }
    public int FailedCount { get; set; }
}

public class SyncAllResult
{
    public bool Success { get; set; }
    public List<SyncResult> Results { get; set; } = new();
    public int TotalSynced { get; set; }
    public int TotalFailed { get; set; }
}
