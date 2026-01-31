using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.StockBatches;

namespace SMIS.Application.Features.StockBatches.Commands
{
    public record StockBatchDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class StockBatchDeleteCommandHandler : IRequestHandler<StockBatchDeleteCommand, Result<Unit>>
    {
        private readonly IStockBatchRepository _stockBatchRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StockBatchDeleteCommandHandler(IUnitOfWork unitOfWork, IStockBatchRepository stockBatchRepository)
        {
            _unitOfWork = unitOfWork;
            _stockBatchRepository = stockBatchRepository;
        }

        public async Task<Result<Unit>> Handle(StockBatchDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _stockBatchRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request?.Id);
            }

            await _stockBatchRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}