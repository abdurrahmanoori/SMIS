using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Repositories.ProductPrices;

namespace SMIS.Application.Features.ProductPrices.Queries;

public record ProductPriceGetByIdQuery(string Id, bool IncludeProduct = false) : IRequest<Result<ProductPriceDto>>;

internal sealed class ProductPriceGetByIdQueryHandler : IRequestHandler<ProductPriceGetByIdQuery, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _productPriceRepository;
    private readonly IMapper _mapper;

    public ProductPriceGetByIdQueryHandler(IProductPriceRepository productPriceRepository, IMapper mapper)
    {
        _productPriceRepository = productPriceRepository;
        _mapper = mapper;
    }

    public async Task<Result<ProductPriceDto>> Handle(ProductPriceGetByIdQuery request, CancellationToken cancellationToken)
    {
        var dbProductPrice = await _productPriceRepository.GetFirstOrDefaultAsync(
            x => x.Id == request.Id,
            includeProperties: request.IncludeProduct ? "Product" : null);

        if (dbProductPrice == null)
        {
            return Result<ProductPriceDto>.NotFoundResult(nameof(ProductPriceDto));
        }

        var productPrice = _mapper.Map<ProductPriceDto>(dbProductPrice);

        return Result<ProductPriceDto>.SuccessResult(productPrice);
    }
}
