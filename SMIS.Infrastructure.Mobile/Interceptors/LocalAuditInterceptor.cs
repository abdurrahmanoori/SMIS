using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;
using SMIS.Infrastructure.Mobile.Services.Identity;

namespace SMIS.Infrastructure.Mobile.Interceptors;

/// <summary>
/// Handles audit fields and sync flags automatically before every local SaveChanges.
/// Combines both concerns to share the <see cref="IsSyncOnly"/> guard logic.
/// </summary>
public class LocalAuditInterceptor : SaveChangesInterceptor
{
    private readonly IMobileCurrentUser _currentUser;

    // Properties that indicate a sync operation (server confirming the entity is up-to-date).
    // When ONLY these change, we must NOT reset IsSyncedToServer or touch audit fields —
    // otherwise the interceptor would immediately undo the sync result.
    private static readonly HashSet<string> _syncOnlyProperties = new()
    {
        nameof(ISyncableEntity.IsSyncedToServer),
        nameof(ISyncableEntity.LastSyncedAt)
    };

    public LocalAuditInterceptor(IMobileCurrentUser currentUser)
    {
        _currentUser = currentUser;
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        UpdateEntities(eventData.Context);
        return base.SavingChanges(eventData, result);
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        UpdateEntities(eventData.Context);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private void UpdateEntities(DbContext? context)
    {
        if (context == null) return;

        var userId = _currentUser.GetId();

        foreach (var entry in context.ChangeTracker.Entries<ISyncableEntity>())
        {
            if (entry.State == EntityState.Added)
            {
                // New local entities start as unsynced so the sync service picks them up.
                entry.Entity.LastModifiedUtc = DateTimeService.UtcNow;
                entry.Entity.IsSyncedToServer = false;
            }
            else if (entry.State == EntityState.Modified && !IsSyncOnly(entry))
            {
                // Real local change — mark unsynced so the sync service pushes it to the server.
                // IsSyncOnly guard prevents this from firing when the sync service sets IsSyncedToServer = true.
                entry.Entity.IsSyncedToServer = false;
                entry.Entity.LastModifiedUtc = DateTimeService.UtcNow;
            }
        }

        foreach (var entry in context.ChangeTracker.Entries<IAuditableEntity>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedDate = DateTimeService.Now;
                entry.Entity.CreatedBy = userId;
            }
            else if (entry.State == EntityState.Modified && !IsSyncOnly(entry))
            {
                // Skip audit update for sync-only saves to avoid triggering another sync cycle.
                entry.Entity.UpdatedDate = DateTimeService.Now;
                entry.Entity.UpdatedBy = userId;
            }
        }
    }

    // Returns true when the only modified properties are sync-related (IsSyncedToServer / LastSyncedAt).
    // Distinguishes a sync service save from a real user/business logic change.
    private static bool IsSyncOnly(EntityEntry entry) =>
        entry.Properties.Where(p => p.IsModified).Select(p => p.Metadata.Name).All(_syncOnlyProperties.Contains);
}
