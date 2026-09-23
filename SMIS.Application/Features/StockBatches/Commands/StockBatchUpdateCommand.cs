using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.StockBatches.Commands
{
    // Updates descriptive batch metadata only. Received/remaining quantities and the
    // receiving ProductUnit are intentionally immutable after the receipt is posted.
    public record StockBatchUpdateCommand(string Id, StockBatchUpdateDto StockBatchUpdateDto)
        : IRequest<Result<StockBatchDto>>;

    internal sealed class
        StockBatchUpdateCommandHandler : IRequestHandler<StockBatchUpdateCommand, Result<StockBatchDto>>
    {
        private readonly IStockBatchRepository _stockBatchRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICurrentUser _currentUser;

        public StockBatchUpdateCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IStockBatchRepository stockBatchRepository,
            ICurrentUser currentUser
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _stockBatchRepository = stockBatchRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<StockBatchDto>> Handle(
            StockBatchUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _stockBatchRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<StockBatchDto>.NotFoundResult(nameof(StockBatchDto.Id));
            }

            if (!string.Equals(entity.ShopId, _currentUser.GetShopId(), StringComparison.Ordinal))
            {
                return Result<StockBatchDto>.NotFoundResult(nameof(StockBatchDto.Id));
            }

            entity.SetBatchNumber(request.StockBatchUpdateDto.BatchNumber);
            entity.SetExpirationDate(request.StockBatchUpdateDto.ExpirationDate);

            switch (request.StockBatchUpdateDto.Status)
            {
                case Domain.Enums.StatusEnum.Active:
                    entity.Activate();
                    break;
                case Domain.Enums.StatusEnum.Inactive:
                    entity.Deactivate();
                    break;
                case Domain.Enums.StatusEnum.Completed:
                    entity.MarkAsCompleted();
                    break;
                case Domain.Enums.StatusEnum.Cancelled:
                    entity.MarkAsCancelled();
                    break;
                case Domain.Enums.StatusEnum.Pending:
                    return Result<StockBatchDto>.FailureResult(
                        "InvalidStockBatchStatus",
                        "Pending is not a valid persisted state for an existing stock batch.");
                case null:
                    break;
                default:
                    return Result<StockBatchDto>.FailureResult(
                        "InvalidStockBatchStatus",
                        "The requested stock batch status is not supported.");
            }

            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<StockBatchDto>(entity);
            return Result<StockBatchDto>.SuccessResult(dto);
        }
    }
}