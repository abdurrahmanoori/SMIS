using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockTransactions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.StockTransactions;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.StockTransactions.Commands;

public record StockTransactionUpdateCommand(string Id, StockTransactionCreateDto StockTransactionCreateDto) : IRequest<Result<StockTransactionDto>>;

internal sealed class StockTransactionUpdateCommandHandler : IRequestHandler<StockTransactionUpdateCommand, Result<StockTransactionDto>>
{
    private readonly IStockTransactionRepository _stockTransactionRepository;
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public StockTransactionUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IStockTransactionRepository stockTransactionRepository, IProductRepository productRepository, IUnitOfMeasureRepository unitOfMeasureRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _stockTransactionRepository = stockTransactionRepository;
        _productRepository = productRepository;
        _unitOfMeasureRepository = unitOfMeasureRepository;
    }

    public async Task<Result<StockTransactionDto>> Handle(StockTransactionUpdateCommand request, CancellationToken cancellationToken)
    {
        var entity = await _stockTransactionRepository.GetByIdAsync(request.Id);
        if (entity == null)
            return Result<StockTransactionDto>.NotFoundResult(request.Id);

        var dto = request.StockTransactionCreateDto;
        
        entity.SetProductId(dto.ProductId);
        entity.SetStockBatchId(dto.StockBatchId);
        entity.SetQuantity(dto.Quantity);
        entity.SetUnitId(dto.UnitId);
        entity.SetType(dto.Type);
        entity.SetTransactionDate(dto.TransactionDate);
        entity.SetReference(dto.Reference);

        // Update name fields
        var product = await _productRepository.GetByIdAsync(dto.ProductId);
        entity.ProductName = product?.Name;
        
        var unit = await _unitOfMeasureRepository.GetByIdAsync(dto.UnitId);
        entity.UnitName = unit?.Name;

       await _stockTransactionRepository.UpdateAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<StockTransactionDto>.SuccessResult(_mapper.Map<StockTransactionDto>(entity));
    }
}