
namespace SMIS.Application.Repositories.Base;
/// <summary>
/// Unit of work is deprecated and will be removed in future versions. Use the DbContext directly instead. or using dbContext from the repository
/// which is basically in the Generic Repository. The Unit of Work pattern is not necessary
/// when using Entity Framework Core, as it already implements the Unit of Work pattern internally.
/// </summary>
public interface IUnitOfWork
{
    Task SaveChanges(CancellationToken cancellationToken);
    Task StartTransactionAsync(CancellationToken cancellationToken);
    Task CommitTransactionAsync(CancellationToken cancellationToken);
    Task RollbackTransactionAsync(CancellationToken cancellationToken);
}
