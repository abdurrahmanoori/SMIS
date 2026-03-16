namespace SMIS.Infrastructure.Mobile.Entities;

public class DeletedRecord
{
    public int Id { get; set; }
    public string EntityType { get; set; } = string.Empty;
    public string EntityId { get; set; } = string.Empty;
    public string ApiEndpoint { get; set; } = string.Empty;
    public DateTimeOffset DeletedAt { get; set; }
    public bool IsSyncedToServer { get; set; } = false;
    public int RetryCount { get; set; } = 0;
}
