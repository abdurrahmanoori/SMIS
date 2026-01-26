using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
namespace SMIS.Infrastructure.Interceptors;

public class EntityPKInterceptor : SaveChangesInterceptor
{
    private readonly ICurrentUser _currentUser;
    private readonly IPublicIdGenerator _publicIdGenerator;

    public EntityPKInterceptor(ICurrentUser currentUser, IPublicIdGenerator publicIdGenerator)
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
        //var rest = context.ChangeTracker.Entries<IEntityPK>();

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

            //if (entry.State == EntityState.Modified)
            //{
            //    entry.Entity.UpdatedDate = DateTime.UtcNow;
            //    entry.Entity.UpdatedBy = _currentUser.GetId();
            //    entry.Property(e => e.CreatedDate).IsModified = false; // Ensure CreatedDate is not updated
            //}
            //if (entry.State == EntityState.Deleted)
            //{
            //    //entry.State = EntityState.Modified; // Soft-delete the entity
            //    //entry.Entity.IsDeleted = true;
            //    //entry.Entity.DeletedAt = DateTime.UtcNow;
            //    //entry.Entity.DeletedBy = _currentUser.GetId();
            //}
        }

        //foreach (var entry in context.ChangeTracker.Entries<AuditableEntity>())
        //{
        //    if (entry.State == EntityState.Added)
        //    {
        //        entry.Entity.CreatedAt = DateTime.UtcNow;
        //        entry.Entity.CreatedBy = _currentUser.GetId();
        //    }

        //    if (entry.State == EntityState.Modified)
        //    {
        //        entry.Entity.UpdatedAt = DateTime.UtcNow;
        //        entry.Entity.UpdatedBy = _currentUser.GetId();
        //        entry.Property(e => e.CreatedAt).IsModified = false; // Ensure CreatedDate is not updated
        //    }
        //    if (entry.State == EntityState.Deleted)
        //    {
        //        entry.State = EntityState.Modified; // Soft-delete the entity
        //        entry.Entity.IsDeleted = true;
        //        entry.Entity.DeletedAt = DateTime.UtcNow;
        //        entry.Entity.DeletedBy = _currentUser.GetId();
        //    }
        //}

        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }
    private async Task AssignSequenceNumber(IEntityPK entity, DbContext context)
    {
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
