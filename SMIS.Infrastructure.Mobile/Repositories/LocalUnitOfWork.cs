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
         await _context.SaveChangesAsync(cancellationToken);
    }
}
