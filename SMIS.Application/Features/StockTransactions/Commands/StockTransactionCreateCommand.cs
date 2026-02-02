using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockTransactions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Repositories.StockTransactions;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.StockTransactions.Commands;

public record StockTransactionCreateCommand(StockTransactionCreateDto StockTransactionCreateDto) : IRequest<Result<StockTransactionDto>>;

internal sealed class StockTransactionCreateCommandHandler : IRequestHandler<StockTransactionCreateCommand, Result<StockTransactionDto>>
{
    private readonly IStockTransactionRepository _stockTransactionRepository;
    private readonly IProductRepository _productRepository;
    private readonly IStockBatchRepository _stockBatchRepository;
    private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
    private readonly IShopRepository _shopRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public StockTransactionCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IStockTransactionRepository stockTransactionRepository, IProductRepository productRepository, IStockBatchRepository stockBatchRepository, IUnitOfMeasureRepository unitOfMeasureRepository, IShopRepository shopRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _stockTransactionRepository = stockTransactionRepository;
        _productRepository = productRepository;
        _stockBatchRepository = stockBatchRepository;
        _unitOfMeasureRepository = unitOfMeasureRepository;
        _shopRepository = shopRepository;
    }

    public async Task<Result<StockTransactionDto>> Handle(StockTransactionCreateCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<StockTransaction>(request.StockTransactionCreateDto);
        
        // Populate name fields
        var shop = await _shopRepository.GetByIdAsync(request.StockTransactionCreateDto.ShopId);
        entity.ShopName = shop?.Name;
        
        var product = await _productRepository.GetByIdAsync(request.StockTransactionCreateDto.ProductId);
        entity.ProductName = product?.Name;
        
        var unit = await _unitOfMeasureRepository.GetByIdAsync(request.StockTransactionCreateDto.UnitId);
        entity.UnitName = unit?.Name;
        
        await _stockTransactionRepository.AddAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<StockTransactionDto>.SuccessResult(_mapper.Map<StockTransactionDto>(entity));
    }
}