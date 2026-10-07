using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Application.Services;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Infrastructure.Server.Interceptors;

/// <summary>
/// Assigns a public entity ID only when an entity does not already have one.
/// BaseEntity and offline clients create stable GUID identities before persistence;
/// persistence must never replace an established identity.
/// </summary>
public class EntityPKInterceptor : SaveChangesInterceptor
{
    private readonly IPublicIdGenerator _publicIdGenerator;

    public EntityPKInterceptor(
        IPublicIdGenerator publicIdGenerator
    )
    {
        _publicIdGenerator = publicIdGenerator;
    }

    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default
    )
    {
        var context = eventData.Context;

        if (context == null) return await base.SavingChangesAsync(eventData, result, cancellationToken);
        //var rest = context.ChangeTracker.Entries<IEntityPK>();

        foreach (var entry in context.ChangeTracker.Entries<IEntityPK>())
        {
            if (entry.State == EntityState.Added)
            {
                if (string.IsNullOrEmpty(entry.Entity.Id))
                {
                    var generated = _publicIdGenerator.Generate();
                    if (!string.IsNullOrEmpty(generated))
                        entry.Entity.Id = generated;
                    else
                        await AssignSequenceNumber(entry.Entity, context);
                }
            }
        }

        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private async Task AssignSequenceNumber(
        IEntityPK entity,
        DbContext context
    )
    {
        // Fallback used when PublicIdGenerator intentionally returns an empty value in
        // Development. Both persisted and not-yet-saved entities are inspected to avoid
        // assigning the same sequence number twice inside one SaveChanges call.
        var entityType = entity.GetType();
        var setMethod = typeof(DbContext).GetMethod("Set", new Type[0])?.MakeGenericMethod(entityType);
        var dbSet = setMethod?.Invoke(context, null) as IQueryable<IEntityPK>;

        if (dbSet != null)
        {
            // Get max ID from database
            var maxDbId = 0;
            try
            {
                var lastPublicId = await dbSet
                    .Where(e => !string.IsNullOrEmpty(e.Id))
                    .Select(e => e.Id)
                    .ToListAsync();

                maxDbId = lastPublicId
                    .Where(id => int.TryParse(id, out _))
                    .Select(id => int.Parse(id))
                    .DefaultIfEmpty(0)
                    .Max();
            }
            catch
            {
                // Handle case when table is empty
                maxDbId = 0;
            }

            // Get max ID from pending entities in change tracker
            var pendingEntities = context.ChangeTracker.Entries<IEntityPK>()
                .Where(e => e.State == EntityState.Added &&
                            e.Entity.GetType() == entityType &&
                            !string.IsNullOrEmpty(e.Entity.Id))
                .Select(e => e.Entity.Id)
                .Where(id => int.TryParse(id, out _))
                .Select(id => int.Parse(id))
                .ToList();

            var maxPendingId = pendingEntities.Any() ? pendingEntities.Max() : 0;

            // Use the higher of the two
            var nextId = Math.Max(maxDbId, maxPendingId) + 1;
            entity.Id = nextId.ToString();
        }
    }
}