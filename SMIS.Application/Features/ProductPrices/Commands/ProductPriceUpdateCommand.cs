using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductPrices;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductPrices.Commands;

public record ProductPriceUpdateCommand(string Id, ProductPriceCreateDto ProductPriceCreateDto)
    : IRequest<Result<ProductPriceDto>>;

internal sealed class
    ProductPriceUpdateCommandHandler : IRequestHandler<ProductPriceUpdateCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _productPriceRepository;
    private readonly IProductUnitRepository _productUnitRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductPriceUpdateCommandHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        IProductPriceRepository productPriceRepository,
        IProductUnitRepository productUnitRepository,
        ICurrentUser currentUser
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _productPriceRepository = productPriceRepository;
        _productUnitRepository = productUnitRepository;
        _currentUser = currentUser;
    }

    public async Task<Result<ProductPriceDto>> Handle(
        ProductPriceUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        var existing = await _productPriceRepository.GetByIdAsync(request.Id);
        if (existing == null)
            return Result<ProductPriceDto>.NotFoundResult(nameof(ProductPriceDto.Id));

        var dto = request.ProductPriceCreateDto;
        if (!string.Equals(existing.ProductUnitId, dto.ProductUnitId, StringComparison.Ordinal))
            return ProductPriceCommandRules.ProductUnitCannotChange();

        var productUnit = await ProductPriceCommandRules.GetAccessibleProductUnitAsync(
            existing.ProductUnitId,
            _productUnitRepository,
            _currentUser);
        if (productUnit is null)
            return ProductPriceCommandRules.ProductUnitNotFoundOrForbidden();

        var latest =
            await _productPriceRepository.GetLatestForProductUnitAsync(existing.ProductUnitId, cancellationToken);
        if (latest is null || !string.Equals(latest.Id, existing.Id, StringComparison.Ordinal))
            return ProductPriceCommandRules.HistoricalPriceImmutable();

        var timelineError = ProductPriceCommandRules.ValidateAndCloseLatest(latest, dto.EffectiveDate);
        if (timelineError is not null) return timelineError;

        var successor = ProductPrice.Create(existing.ProductUnitId, dto.SellPrice, dto.EffectiveDate);
        successor.SetEndDate(dto.EndDate);
        successor.ClearClientModificationMetadata();

        await _productPriceRepository.AddAsync(successor);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<ProductPriceDto>.SuccessResult(_mapper.Map<ProductPriceDto>(successor));
    }
}