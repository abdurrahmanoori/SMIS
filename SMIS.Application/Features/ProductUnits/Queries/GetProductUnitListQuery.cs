using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.ProductUnits;

namespace SMIS.Application.Features.ProductUnits.Queries
{
    public record GetProductUnitListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<ProductUnitDto>>>;

    internal sealed class GetProductUnitListQueryHandler : IRequestHandler<GetProductUnitListQuery, Result<PagedList<ProductUnitDto>>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IMapper _mapper;

        public GetProductUnitListQueryHandler(IProductUnitRepository productUnitRepository, IMapper mapper)
        {
            _productUnitRepository = productUnitRepository;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<ProductUnitDto>>> Handle(GetProductUnitListQuery request, CancellationToken cancellationToken)
        {
            var productUnits = await _productUnitRepository.GetAllQueryable()
                .ToPagedList(request.PageNumber, request.PageSize);

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