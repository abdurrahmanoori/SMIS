using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.ProductPrices;

namespace SMIS.Application.Features.ProductPrices.Queries;

public record ProductPriceGetListQuery(int PageNumber = 1, int PageSize = 25, bool IncludeProduct = false) : IRequest<Result<PagedList<ProductPriceDto>>>;

internal sealed class ProductPriceGetListQueryHandler : IRequestHandler<ProductPriceGetListQuery, Result<PagedList<ProductPriceDto>>>
{
    private readonly IProductPriceRepository _productPriceRepository;
    private readonly IMapper _mapper;

    public ProductPriceGetListQueryHandler(IProductPriceRepository productPriceRepository, IMapper mapper)
    {
        _productPriceRepository = productPriceRepository;
        _mapper = mapper;
    }

    public async Task<Result<PagedList<ProductPriceDto>>> Handle(ProductPriceGetListQuery request, CancellationToken cancellationToken)
    {
        var query = _productPriceRepository.GetAllQueryable(includeProperties: request.IncludeProduct ? "Product" : null);
        var productPrices = await query.ToPagedList(request.PageNumber, request.PageSize);

        if (!productPrices.Items.Any())
        {
            return Result<PagedList<ProductPriceDto>>.EmptyResult(nameof(ProductPriceDto));
        }

        var productPriceDtos = _mapper.Map<List<ProductPriceDto>>(productPrices.Items);

        return Result<PagedList<ProductPriceDto>>.SuccessResult(new PagedList<ProductPriceDto>
        {
            Items = productPriceDtos,
            TotalCount = productPrices.TotalCount,
            PageNumber = productPrices.PageNumber,
            PageSize = productPrices.PageSize
        });
    }
}
