using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Common.BaseAbstract;
using SMIS.Infrastructure.Context;

namespace SMIS.Infrastructure.Interceptors
{
    public class AuditInterceptor : SaveChangesInterceptor
    {
        private readonly ICurrentUser _currentUser;
        private readonly IPublicIdGenerator _publicIdGenerator;

        public AuditInterceptor(ICurrentUser currentUser, IPublicIdGenerator publicIdGenerator)
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
            var rest = context.ChangeTracker.Entries<BaseAuditableEntity>();

            foreach (var entry in context.ChangeTracker.Entries<BaseAuditableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.UtcNow;
                    entry.Entity.CreatedBy = _currentUser.GetId();
                    //await AssignSequenceNumber(entry.Entity, context);
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedDate = DateTime.UtcNow;
                    entry.Entity.UpdatedBy = _currentUser.GetId();
                    entry.Property(e => e.CreatedDate).IsModified = false; // Ensure CreatedDate is not updated
                }
                if (entry.State == EntityState.Deleted)
                {
                    //entry.State = EntityState.Modified; // Soft-delete the entity
                    //entry.Entity.IsDeleted = true;
                    //entry.Entity.DeletedAt = DateTime.UtcNow;
                    //entry.Entity.DeletedBy = _currentUser.GetId();
                }
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
        private async Task AssignSequenceNumber(BaseAuditableEntity entity, DbContext context)
        {
            var entityType = entity.GetType();
            var setMethod = typeof(DbContext).GetMethod("Set", new Type[0])?.MakeGenericMethod(entityType);
            var dbSet = setMethod?.Invoke(context, null) as IQueryable<BaseAuditableEntity>;

            if (dbSet != null)
            {
                // Get max ID from database
                var maxDbId = 0;
                try
                {
                    var maxDbIdString = await dbSet.MaxAsync(x => x.Id);
                    if (!string.IsNullOrEmpty(maxDbIdString) && int.TryParse(maxDbIdString, out var parsed))
                    {
                        maxDbId = parsed;
                    }
                }
                catch
                {
                    // Handle case when table is empty
                    maxDbId = 0;
                }

                // Get max ID from pending entities in change tracker
                var pendingEntities = context.ChangeTracker.Entries<BaseAuditableEntity>()
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
}
