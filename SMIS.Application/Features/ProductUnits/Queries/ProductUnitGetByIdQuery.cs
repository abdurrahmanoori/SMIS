using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Repositories.ProductUnits;

namespace SMIS.Application.Features.ProductUnits.Queries
{
    public record ProductUnitGetByIdQuery(string Id, bool IncludeProduct = false, bool IncludeUnitOfMeasure = false) : IRequest<Result<ProductUnitDto>>;

    internal sealed class ProductUnitGetByIdQueryHandler : IRequestHandler<ProductUnitGetByIdQuery, Result<ProductUnitDto>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IMapper _mapper;

        public ProductUnitGetByIdQueryHandler(IProductUnitRepository productUnitRepository, IMapper mapper)
        {
            _productUnitRepository = productUnitRepository;
            _mapper = mapper;
        }

        public async Task<Result<ProductUnitDto>> Handle(ProductUnitGetByIdQuery request, CancellationToken cancellationToken)
        {
            var includeProperties = new List<string>();
            if (request.IncludeProduct) includeProperties.Add("Product");
            if (request.IncludeUnitOfMeasure) includeProperties.Add("UnitOfMeasure");
            var re = string.Join(",", includeProperties);
            var dbProductUnit = await _productUnitRepository.GetFirstOrDefaultAsync(
                x => x.Id == request.Id,
                includeProperties: includeProperties.Any() ? string.Join(",", includeProperties) : null);

            if (dbProductUnit == null)
            {
                return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitDto));
            }

            var productUnit = _mapper.Map<ProductUnitDto>(dbProductUnit);

            return Result<ProductUnitDto>.SuccessResult(productUnit);
        }
    }
}