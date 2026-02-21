using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;

namespace SMIS.UI.Data.Interceptors;

public class AuditInterceptor : SaveChangesInterceptor
{
    private readonly ICurrentUser _currentUser;

    public AuditInterceptor(ICurrentUser currentUser)
    {
        _currentUser = currentUser;
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        UpdateAuditFields(eventData.Context);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private void UpdateAuditFields(DbContext? context)
    {
        if (context == null) return;

        var userId = _currentUser.GetId();

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
