using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Infrastructure.Interceptors
{
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
            var rest = context.ChangeTracker.Entries<EntityPK>();

            foreach (var entry in context.ChangeTracker.Entries<EntityPK>())
            {
                if (entry.State == EntityState.Added)
                {
                    await AssignSequenceNumber(entry.Entity, context);
                    if (string.IsNullOrEmpty(entry.Entity.PublicId))
                    {
                        entry.Entity.PublicId = _publicIdGenerator.Generate();
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
        private async Task AssignSequenceNumber(EntityPK entity, DbContext context)
        {
            var entityType = entity.GetType();
            var setMethod = typeof(DbContext).GetMethod("Set", new Type[0])?.MakeGenericMethod(entityType);
            var dbSet = setMethod?.Invoke(context, null) as IQueryable<EntityPK>;

            if (dbSet != null && string.IsNullOrEmpty(entity.PublicId))
            {
                var lastPublicId = await dbSet
                    .Where(e => !string.IsNullOrEmpty(e.PublicId))
                    .Select(e => e.PublicId)
                    .ToListAsync();
                
                var maxNumericId = lastPublicId
                    .Where(id => int.TryParse(id, out _))
                    .Select(id => int.Parse(id))
                    .DefaultIfEmpty(0)
                    .Max();
                
                entity.PublicId = (maxNumericId + 1).ToString();
            }
        }
    }
}
