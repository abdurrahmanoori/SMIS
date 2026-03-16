using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;
using SMIS.Infrastructure.Mobile.Entities;

namespace SMIS.Infrastructure.Mobile.Interceptors;

public class TombstoneInterceptor : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        ProcessDeletions(eventData.Context);
        return base.SavingChanges(eventData, result);
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        ProcessDeletions(eventData.Context);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private static void ProcessDeletions(DbContext? context)
    {
        if (context == null) return;

        var deletedEntries = context.ChangeTracker
            .Entries<ISyncableEntity>()
            .Where(e => e.State == EntityState.Deleted)
            .ToList();

        foreach (var entry in deletedEntries)
        {
            var entityType = entry.Entity.GetType().Name;
            var apiEndpoint = ResolveEndpoint(entityType);

            // Only write tombstone if the entity was previously synced to server.
            // If it was never synced (created offline and deleted before sync),
            // a physical delete is safe — no server record exists.
            if (entry.Entity.IsSyncedToServer)
            {
                context.Set<DeletedRecord>().Add(new DeletedRecord
                {
                    EntityType = entityType,
                    EntityId = entry.Entity.Id,
                    ApiEndpoint = apiEndpoint,
                    DeletedAt = DateTimeService.NowOffSet
                });
            }

            // Cancel the physical delete — let EF skip it
            entry.State = EntityState.Detached;
        }
    }

    // Maps entity type name to its API endpoint.
    // Extend this as more syncable entities are added.
    private static string ResolveEndpoint(string entityType) => entityType switch
    {
        "Category" => "/api/Category",
        _ => $"/api/{entityType}"
    };
}
