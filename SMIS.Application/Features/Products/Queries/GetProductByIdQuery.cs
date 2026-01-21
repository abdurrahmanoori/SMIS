using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Products;

namespace SMIS.Application.Features.Products.Queries
{
    public record GetProductByIdQuery(string Id) : IRequest<Result<ProductDto>>;

    internal sealed class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Result<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser, IMapper mapper)
        {
            _productRepository = productRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
            _mapper = mapper;
        }

        public async Task<Result<ProductDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var dbProduct = await _productRepository.GetFirstOrDefaultAsync(x => x.Id == request.Id);

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