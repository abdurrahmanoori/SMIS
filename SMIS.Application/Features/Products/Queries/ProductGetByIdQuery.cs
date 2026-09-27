using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Repositories.Products;

namespace SMIS.Application.Features.Products.Queries
{
    public record ProductGetByIdQuery(string Id, bool IncludeCategory = false) : IRequest<Result<ProductDto>>;

    internal sealed class ProductGetByIdQueryHandler : IRequestHandler<ProductGetByIdQuery, Result<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductGetByIdQueryHandler(
            IProductRepository productRepository,
            IMapper mapper
        )
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Result<ProductDto>> Handle(
            ProductGetByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var dbProduct = await _productRepository.GetFirstOrDefaultAsync(
                x => x.Id == request.Id,
                includeProperties: request.IncludeCategory ? "Category" : null);

            if (dbProduct == null)
            {
                return Result<ProductDto>.NotFoundResult(nameof(ProductDto));
            }

            return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(dbProduct));
        }
    }
}