using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Repositories.ProductUnits;

namespace SMIS.Application.Features.ProductUnits.Queries
{
    public record ProductUnitGetListQuery(int PageNumber = 1, int PageSize = 25, bool IncludeProduct = false, bool IncludeUnitOfMeasure = false) : IRequest<Result<PagedList<ProductUnitDto>>>;

    internal sealed class ProductUnitGetListQueryHandler : IRequestHandler<ProductUnitGetListQuery, Result<PagedList<ProductUnitDto>>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IMapper _mapper;

        public ProductUnitGetListQueryHandler(IProductUnitRepository productUnitRepository, IMapper mapper)
        {
            _productUnitRepository = productUnitRepository;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<ProductUnitDto>>> Handle(ProductUnitGetListQuery request, CancellationToken cancellationToken)
        {
            var includeProperties = new List<string>();
            if (request.IncludeProduct) includeProperties.Add("Product");
            if (request.IncludeUnitOfMeasure) includeProperties.Add("UnitOfMeasure");

            var query = _productUnitRepository.GetAllQueryable(includeProperties: includeProperties.Any() ? string.Join(",", includeProperties) : null);
            var productUnits = await query.ToPagedList(request.PageNumber, request.PageSize);

            if (!productUnits.Items.Any())
            {
                return Result<PagedList<ProductUnitDto>>.EmptyResult(nameof(ProductUnitDto));
            }

            var productUnitDtos = _mapper.Map<List<ProductUnitDto>>(productUnits.Items);

            return Result<PagedList<ProductUnitDto>>.SuccessResult(new PagedList<ProductUnitDto>
            {
                Items = productUnitDtos,
                TotalCount = productUnits.TotalCount,
                PageNumber = productUnits.PageNumber,
                PageSize = productUnits.PageSize,
                TotalPages = productUnits.TotalPages
            });
        }
    }
}