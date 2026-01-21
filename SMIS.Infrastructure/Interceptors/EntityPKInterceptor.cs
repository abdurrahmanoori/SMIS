using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Infrastructure.Interceptors
{
    public class EntityPKInterceptor : SaveChangesInterceptor
    {
        private readonly ICurrentUser _currentUser;
        //private readonly AppDbContext context;

        public EntityPKInterceptor(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(
            DbContextEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            var context = eventData.Context;

            if (context == null) return await base.SavingChangesAsync(eventData, result, cancellationToken);
            var rest = context.ChangeTracker.Entries<EntityPK>();

            foreach (var entry in context.ChangeTracker.Entries<EntityPK>())
            {
                if (entry.State == EntityState.Added)
                {
                    await AssignSequenceNumber(entry.Entity, context);
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
        private async Task AssignSequenceNumber(EntityPK entity, DbContext context)
        {
            var entityType = entity.GetType();
            var setMethod = typeof(DbContext).GetMethod("Set", new Type[0])?.MakeGenericMethod(entityType);
            var dbSet = setMethod?.Invoke(context, null) as IQueryable<EntityPK>;

            if (dbSet != null)
            {
                var lastId = await dbSet.MaxAsync(e => (int?)e.Id) ?? 0;
                entity.Id = lastId + 1;
            }
        }
    }
}
