using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Repositories.ProductUnits;

namespace SMIS.Application.Features.ProductUnits.Queries
{
    public record GetProductUnitByIdQuery(string Id) : IRequest<Result<ProductUnitDto>>;

    internal sealed class GetProductUnitByIdQueryHandler : IRequestHandler<GetProductUnitByIdQuery, Result<ProductUnitDto>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IMapper _mapper;

        public GetProductUnitByIdQueryHandler(IProductUnitRepository productUnitRepository, IMapper mapper)
        {
            _productUnitRepository = productUnitRepository;
            _mapper = mapper;
        }

        public async Task<Result<ProductUnitDto>> Handle(GetProductUnitByIdQuery request, CancellationToken cancellationToken)
        {
            var dbProductUnit = await _productUnitRepository.GetFirstOrDefaultAsync(x => x.Id == request.Id);

            if (dbProductUnit == null)
            {
                return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitDto));
            }

            var productUnit = _mapper.Map<ProductUnitDto>(dbProductUnit);

            return Result<ProductUnitDto>.SuccessResult(productUnit);
        }
    }
}