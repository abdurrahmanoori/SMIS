using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductPrices;
using SMIS.Application.Repositories.Products;

namespace SMIS.Application.Features.ProductPrices.Commands;

public record ProductPriceUpdateCommand(string Id, ProductPriceCreateDto ProductPriceCreateDto) : IRequest<Result<ProductPriceDto>>;

internal sealed class ProductPriceUpdateCommandHandler : IRequestHandler<ProductPriceUpdateCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _productPriceRepository;
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProductPriceUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductPriceRepository productPriceRepository, IProductRepository productRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _productPriceRepository = productPriceRepository;
        _productRepository = productRepository;
    }

    public async Task<Result<ProductPriceDto>> Handle(ProductPriceUpdateCommand request, CancellationToken cancellationToken)
    {
        var entity = await _productPriceRepository.GetByIdAsync(request.Id);
        if (entity == null)
        {
            return Result<ProductPriceDto>.NotFoundResult(nameof(ProductPriceDto.Id));
        }

        entity.SetProductId(request.ProductPriceCreateDto.ProductId);
        entity.SetProductUnitId(request.ProductPriceCreateDto.ProductUnitId);
        entity.SetBuyPrice(request.ProductPriceCreateDto.BuyPrice);
        entity.SetSellPrice(request.ProductPriceCreateDto.SellPrice);
        entity.SetEffectiveDate(request.ProductPriceCreateDto.EffectiveDate);
        entity.SetEndDate(request.ProductPriceCreateDto.EndDate);
        if (request.ProductPriceCreateDto.IsActive) entity.Activate(); else entity.Deactivate();

        await _unitOfWork.SaveChanges(cancellationToken);

        var dto = _mapper.Map<ProductPriceDto>(entity);
        return Result<ProductPriceDto>.SuccessResult(dto);
    }
}
