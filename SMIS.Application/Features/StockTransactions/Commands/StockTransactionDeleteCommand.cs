using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.StockTransactions;

namespace SMIS.Application.Features.StockTransactions.Commands;

public record StockTransactionDeleteCommand(string Id) : IRequest<Result<Unit>>;

internal sealed class StockTransactionDeleteCommandHandler : IRequestHandler<StockTransactionDeleteCommand, Result<Unit>>
{
    private readonly IStockTransactionRepository _stockTransactionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public StockTransactionDeleteCommandHandler(IUnitOfWork unitOfWork, IStockTransactionRepository stockTransactionRepository)
    {
        _unitOfWork = unitOfWork;
        _stockTransactionRepository = stockTransactionRepository;
    }

    public async Task<Result<Unit>> Handle(StockTransactionDeleteCommand request, CancellationToken cancellationToken)
    {
        var entity = await _stockTransactionRepository.GetByIdAsync(request.Id);
        if (entity == null)
            return Result<Unit>.NotFoundResult(request.Id);

        await _stockTransactionRepository.RemoveAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<Unit>.SuccessResult(Unit.Value);
    }
}