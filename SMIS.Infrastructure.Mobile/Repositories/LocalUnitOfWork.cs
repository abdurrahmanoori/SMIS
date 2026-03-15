using Microsoft.EntityFrameworkCore;
using SMIS.Application.Repositories.Base;
using SMIS.Infrastructure.Mobile.Context;

namespace SMIS.Infrastructure.Mobile.Repositories;


public class LocalUnitOfWork : IUnitOfWork
{
    private readonly LocalDbContext _context;

    public LocalUnitOfWork(LocalDbContext context)
    {
        _context = context;
    }

  

 

    public async Task StartTransactionAsync(CancellationToken cancellationToken)
    {
        await _context.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync(CancellationToken cancellationToken)
    {
        await _context.Database.CommitTransactionAsync(cancellationToken);
    }

    public async Task RollbackTransactionAsync(CancellationToken cancellationToken)
    {
        await _context.Database.RollbackTransactionAsync(cancellationToken);
    }

    public async Task SaveChanges(CancellationToken cancellationToken)
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

        // Save changes to the database
        await this._context.SaveChangesAsync(cancellationToken);




        //await this._context.Entry(entity!).ReloadAsync(cancellationToken);

        //return entity;
    }
}
