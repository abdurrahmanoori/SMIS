using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Infrastructure.Interceptors
{
    public class AuditInterceptor : SaveChangesInterceptor
    {
        private readonly ICurrentUser _currentUser;

        public AuditInterceptor(ICurrentUser currentUser)
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

            foreach (var entry in context.ChangeTracker.Entries<BaseAuditableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.UtcNow;
                    entry.Entity.CreatedBy = _currentUser.GetUserId();
                    entry.Entity.HospitalId = _currentUser.GetHospitalId();
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedDate = DateTime.UtcNow;
                    entry.Entity.UpdatedBy = _currentUser.GetUserId();
                    entry.Property(e => e.CreatedDate).IsModified = false; // Ensure CreatedDate is not updated
                    entry.Entity.HospitalId = _currentUser.GetHospitalId();
                }
                if (entry.State == EntityState.Deleted)
                {
                    //entry.State = EntityState.Modified; // Soft-delete the entity
                    //entry.Entity.IsDeleted = true;
                    //entry.Entity.DeletedAt = DateTime.UtcNow;
                    //entry.Entity.DeletedBy = _currentUser.GetUserId();
                }
            }
            //foreach (var entry in context.ChangeTracker.Entries<AuditableEntity>())
            //{
            //    if (entry.State == EntityState.Added)
            //    {
            //        entry.Entity.CreatedAt = DateTime.UtcNow;
            //        entry.Entity.CreatedBy = _currentUser.GetUserId();
            //    }

            //    if (entry.State == EntityState.Modified)
            //    {
            //        entry.Entity.UpdatedAt = DateTime.UtcNow;
            //        entry.Entity.UpdatedBy = _currentUser.GetUserId();
            //        entry.Property(e => e.CreatedAt).IsModified = false; // Ensure CreatedDate is not updated
            //    }
            //    if (entry.State == EntityState.Deleted)
            //    {
            //        entry.State = EntityState.Modified; // Soft-delete the entity
            //        entry.Entity.IsDeleted = true;
            //        entry.Entity.DeletedAt = DateTime.UtcNow;
            //        entry.Entity.DeletedBy = _currentUser.GetUserId();
            //    }
            //}

            return await base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}
