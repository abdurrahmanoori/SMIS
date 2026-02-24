using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Application.Services;
using SMIS.Domain.Common.Interfaces;
using SMIS.Infrastructure.Mobile.Services.Identity;

namespace SMIS.Infrastructure.Mobile.Interceptors;

public class EntityPKInterceptor : SaveChangesInterceptor
{
    private readonly IMobileCurrentUser _currentUser;
    private readonly IPublicIdGenerator _publicIdGenerator;

    public EntityPKInterceptor(IMobileCurrentUser currentUser, IPublicIdGenerator publicIdGenerator)
    {
        _currentUser = currentUser;
        _publicIdGenerator = publicIdGenerator;
    }

    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        var context = eventData.Context;

        if (context == null) return await base.SavingChangesAsync(eventData, result, cancellationToken);

        foreach (var entry in context.ChangeTracker.Entries<IEntityPK>())
        {
            if (entry.State == EntityState.Added)
            {
                await AssignSequenceNumber(entry.Entity, context);
                if (string.IsNullOrEmpty(entry.Entity.Id))
                {
                    entry.Entity.Id = _publicIdGenerator.Generate();
                }
            }
        }

        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private async Task AssignSequenceNumber(IEntityPK entity, DbContext context)
    {
        var entityType = entity.GetType();
        var setMethod = typeof(DbContext).GetMethod("Set", new Type[0])?.MakeGenericMethod(entityType);
        var dbSet = setMethod?.Invoke(context, null) as IQueryable<IEntityPK>;

        if (dbSet != null)
        {
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
                maxDbId = 0;
            }

            var pendingEntities = context.ChangeTracker.Entries<IEntityPK>()
                .Where(e => e.State == EntityState.Added &&
                           e.Entity.GetType() == entityType &&
                           !string.IsNullOrEmpty(e.Entity.Id))
                .Select(e => e.Entity.Id)
                .Where(id => int.TryParse(id, out _))
                .Select(id => int.Parse(id))
                .ToList();

            var maxPendingId = pendingEntities.Any() ? pendingEntities.Max() : 0;

            var nextId = Math.Max(maxDbId, maxPendingId) + 1;
            entity.Id = nextId.ToString();
        }
    }
}
