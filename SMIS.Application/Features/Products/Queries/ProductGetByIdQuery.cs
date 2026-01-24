using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Products;

namespace SMIS.Application.Features.Products.Queries
{
    public record ProductGetByIdQuery(string Id, bool IncludeCategory = false) : IRequest<Result<ProductDto>>;

    internal sealed class ProductGetByIdQueryHandler : IRequestHandler<ProductGetByIdQuery, Result<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public ProductGetByIdQueryHandler(IProductRepository productRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser, IMapper mapper)
        {
            _productRepository = productRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
            _mapper = mapper;
        }

        public async Task<Result<ProductDto>> Handle(ProductGetByIdQuery request, CancellationToken cancellationToken)
        {
            var dbProduct = await _productRepository.GetFirstOrDefaultAsync(
                x => x.Id == request.Id,
                includeProperties: request.IncludeCategory ? "Category" : null);

            if (dbProduct == null)
            {
                return Result<ProductDto>.NotFoundResult(nameof(ProductDto));
            }

            var product = _mapper.Map<ProductDto>(dbProduct);
            product.TranslateEntityByAttributes(_translationKeyRepository.GetAllQueryable(), _currentUser.GetLangId());

            return Result<ProductDto>.SuccessResult(product);
        }
    }
}