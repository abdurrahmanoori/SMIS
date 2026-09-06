using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SMIS.Application.Repositories.Base;
using SMIS.Infrastructure.Server.Context;

namespace SMIS.Infrastructure.Server.Repositories.Base;

/// <summary>
/// Unit of work is deprecated and will be removed in future versions. Use the DbContext directly instead. or using dbContext from the repository
/// which is basically in the Generic Repository. The Unit of Work pattern is not necessary
/// when using Entity Framework Core, as it already implements the Unit of Work pattern internally.
/// </summary>
public sealed class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private IDbContextTransaction? _currentTransaction;

    public UnitOfWork(
        AppDbContext context
    )
    {
        _context = context;
    }

    public async Task SaveChanges(
        CancellationToken cancellationToken
    )
    {
        var entities = this._context.ChangeTracker.Entries();
        var result = new
        {
            AddedEntities = this._context.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added)
                .Select(e => new
                {
                    Entity = e.Entity,
                    EntityName = e.Entity.GetType().Name,
                    State = e.State.ToString(),
                }).ToList(),

            ModifiedEntities = this._context.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Modified)
                .Select(e => new
                {
                    Entity = e.Entity,
                    EntityName = e.Entity.GetType().Name,
                    State = e.State.ToString(),
                    ChangedProperties = e.Properties
                        .Where(p => p.IsModified)
                        .Select(p => new
                        {
                            PropertyName = p.Metadata.Name,
                            OriginalValue = p.OriginalValue?.ToString() ?? "null",
                            CurrentValue = p.CurrentValue?.ToString() ?? "null",
                            IsModified = p.IsModified,
                        }).ToList(),
                }).ToList(),

            DeletedEntities = this._context.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Deleted)
                .Select(e => new
                {
                    Entity = e.Entity,
                    EntityName = e.Entity.GetType().Name,
                    State = e.State.ToString(),
                }).ToList(),

            UnchangedEntities = this._context.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Unchanged)
                .Select(e => new
                {
                    Entity = e.Entity,
                    EntityName = e.Entity.GetType().Name,
                    State = e.State.ToString(),
                }).ToList(),

            DetachedEntities = this._context.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Detached)
                .Select(e => new
                {
                    Entity = e.Entity,
                    State = e.State.ToString(),
                    EntityName = e.Entity.GetType().Name,
                }).ToList(),
        };


        // Get all added entities
        var addedEntities = this._context.ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Added)
            .ToList();


        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task StartTransactionAsync(
        CancellationToken cancellationToken
    )
    {
        if (_currentTransaction is null)
        {
            _currentTransaction = await _context.Database.BeginTransactionAsync(cancellationToken);
        }
    }

    public async Task CommitTransactionAsync(
        CancellationToken cancellationToken
    )
    {
        try
        {
            await _context.SaveChangesAsync(cancellationToken);
            if (_currentTransaction is not null)
            {
                await _currentTransaction.CommitAsync(cancellationToken);
            }
        }
        catch
        {
            await RollbackTransactionAsync(cancellationToken);
            throw;
        }
        finally
        {
            DisposeTransaction();
        }
    }

    public async Task RollbackTransactionAsync(
        CancellationToken cancellationToken
    )
    {
        if (_currentTransaction is not null)
        {
            await _currentTransaction.RollbackAsync(cancellationToken);
        }

        DisposeTransaction();
    }

    private void DisposeTransaction()
    {
        _currentTransaction?.Dispose();
        _currentTransaction = null;
    }
}