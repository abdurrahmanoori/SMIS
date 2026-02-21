using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;
using SMIS.Infrastructure.Mobile.Services.Identity;

namespace SMIS.Infrastructure.Mobile.Interceptors;

public class LocalAuditInterceptor : SaveChangesInterceptor
{
    private readonly ILocalCurrentUser _currentUser;

    public LocalAuditInterceptor(ILocalCurrentUser currentUser)
    {
        _currentUser = currentUser;
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        UpdateEntities(eventData.Context);
        return base.SavingChanges(eventData, result);
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        UpdateEntities(eventData.Context);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private void UpdateEntities(DbContext? context)
    {
        if (context == null) return;

        var userId = _currentUser.GetId();

        foreach (var entry in context.ChangeTracker.Entries<ISyncableEntity>())
        {
            if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
            {
                entry.Entity.LastModifiedUtc = DateTimeService.UtcNow;
                entry.Entity.IsSyncedToServer = false;
            }
        }

        foreach (var entry in context.ChangeTracker.Entries<IAuditableEntity>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedDate = DateTimeService.Now;
                entry.Entity.CreatedBy = userId;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Entity.UpdatedDate = DateTimeService.Now;
                entry.Entity.UpdatedBy = userId;
            }
        }
    }
}
