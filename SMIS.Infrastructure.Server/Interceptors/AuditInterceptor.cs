using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.Interceptors
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

            foreach (var entry in context.ChangeTracker.Entries<BaseAuditableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    if (entry.Entity.CreatedDate == default)
                    {
                        entry.Entity.CreatedDate = DateTimeService.Now;
                    }
                    if (string.IsNullOrEmpty(entry.Entity.CreatedBy))
                    {
                        entry.Entity.CreatedBy = _currentUser.GetId();
                    }
                    // Respect client-provided LastModifiedUtc (offline sync scenario).
                    // Only stamp server time when the entity was created directly on the server.
                    if (entry.Entity.LastModifiedUtc == default)
                    {
                        entry.Entity.LastModifiedUtc = DateTimeService.UtcNow;
                    }
                }
                else if (entry.State == EntityState.Deleted && entry.Entity is ISoftDeletable softDeletable)
                {
                    // Convert physical delete to soft delete so the row is never removed.
                    // Flipping state to Modified causes EF Core to issue UPDATE instead of DELETE.
                    // LastModifiedUtc is bumped so the pull endpoint's changedSince cursor
                    // picks up this record and propagates the deletion to all other clients.
                    entry.State = EntityState.Modified;

                    softDeletable.IsDeleted = true;
                    softDeletable.DeletedAt = DateTimeService.UtcNow;

                    entry.Entity.UpdatedDate = DateTimeService.UtcNow;
                    entry.Entity.UpdatedBy = _currentUser.GetId();
                    entry.Entity.LastModifiedUtc = DateTimeService.UtcNow;

                    entry.Property(e => e.CreatedDate).IsModified = false; // Ensure CreatedDate is not updated
                }
                else if (entry.State == EntityState.Modified)
                {
                    if (entry.Entity.UpdatedDate == default)
                    {
                        entry.Entity.UpdatedDate = DateTimeService.Now;
                    }
                    if (string.IsNullOrEmpty(entry.Entity.UpdatedBy))
                    {
                        entry.Entity.UpdatedBy = _currentUser.GetId();
                    }
                    // Respect client-provided LastModifiedUtc (offline sync scenario).
                    // Only stamp server time when the update originated directly on the server.
                    if (entry.Entity.LastModifiedUtc == default)
                    {
                        entry.Entity.LastModifiedUtc = DateTimeService.UtcNow;
                    }
                    entry.Property(e => e.CreatedDate).IsModified = false; // Ensure CreatedDate is not updated
                }
            }

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
