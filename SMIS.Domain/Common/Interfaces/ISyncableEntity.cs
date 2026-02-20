namespace SMIS.Domain.Common.Interfaces;

public interface ISyncableEntity
{
    string Id { get; }
    bool IsSyncedToServer { get; set; }
    DateTime? LastSyncedAt { get; set; }
}
