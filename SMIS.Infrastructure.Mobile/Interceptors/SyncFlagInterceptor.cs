using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Mobile.Interceptors;

/// <summary>
/// Marks entities as unsynced when they are modified locally.
/// This ensures updates are synced to the server.
/// </summary>
public class SyncFlagInterceptor : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        UpdateSyncFlags(eventData);
        return base.SavingChanges(eventData, result);
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        UpdateSyncFlags(eventData);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private void UpdateSyncFlags(DbContextEventData eventData)
    {
        if (eventData.Context == null) return;

        foreach (var entry in eventData.Context.ChangeTracker.Entries<ISyncableEntity>())
        {
            if (entry.State != EntityState.Modified) continue;

            var changedProperties = entry.Properties
                .Where(p => p.IsModified)
                .Select(p => p.Metadata.Name)
                .ToHashSet();

            var isSyncOnlyUpdate = changedProperties.IsSubsetOf(
                new[] { nameof(ISyncableEntity.IsSyncedToServer), nameof(ISyncableEntity.LastSyncedAt) });

            if (!isSyncOnlyUpdate && entry.Entity.IsSyncedToServer)
            {
                entry.Entity.IsSyncedToServer = false;
                entry.Entity.LastModifiedUtc = DateTimeService.NowOffSet;
            }
        }
    }
}
