using SMIS.Domain.Contracts;

namespace SMIS.Infrastructure.Server.ContractsImplementation;

public class DevPKGenerator : IPKGenerator
{
    public string Generate()
    {
        throw new NotImplementedException();
    }

    //private async Task AssignSequenceNumber(IEntityPK entity, DbContext context)
    //{
    //    var entityType = entity.GetType();
    //    var setMethod = typeof(DbContext).GetMethod("Set", new Type[0])?.MakeGenericMethod(entityType);
    //    var dbSet = setMethod?.Invoke(context, null) as IQueryable<IEntityPK>;

    //    if (dbSet != null)
    //    {
    //        // Get max ID from database
    //        var maxDbId = 0;
    //        try
    //        {
    //            var lastPublicId = await dbSet
    //                .Where(e => !string.IsNullOrEmpty(e.Id))
    //                .Select(e => e.Id)
    //                .ToListAsync();

    //            maxDbId = lastPublicId
    //                .Where(id => int.TryParse(id, out _))
    //                .Select(id => int.Parse(id))
    //                .DefaultIfEmpty(0)
    //                .Max();
    //        }
    //        catch
    //        {
    //            // Handle case when table is empty
    //            maxDbId = 0;
    //        }

    //        // Get max ID from pending entities in change tracker
    //        var pendingEntities = context.ChangeTracker.Entries<IEntityPK>()
    //            .Where(e => e.State == EntityState.Added &&
    //                       e.Entity.GetType() == entityType &&
    //                       !string.IsNullOrEmpty(e.Entity.Id))
    //            .Select(e => e.Entity.Id)
    //            .Where(id => int.TryParse(id, out _))
    //            .Select(id => int.Parse(id))
    //            .ToList();

    //        var maxPendingId = pendingEntities.Any() ? pendingEntities.Max() : 0;

    //        // Use the higher of the two
    //        var nextId = Math.Max(maxDbId, maxPendingId) + 1;
    //        entity.Id = nextId.ToString();
    //    }
    //}
}
