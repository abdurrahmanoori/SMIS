using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Products;

namespace SMIS.Application.Features.Products.Queries
{
    public record ProductGetListQuery(int PageNumber = 1, int PageSize = 25, bool IncludeCategory = false) : IRequest<Result<PagedList<ProductDto>>>;

    internal sealed class ProductGetListQueryHandler : IRequestHandler<ProductGetListQuery, Result<PagedList<ProductDto>>>
    {
        private readonly IProductRepository _productRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public ProductGetListQueryHandler(IProductRepository productRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser, IMapper mapper)
        {
            _productRepository = productRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<ProductDto>>> Handle(ProductGetListQuery request, CancellationToken cancellationToken)
        {


            var query = _productRepository.GetAllQueryable(includeProperties: request.IncludeCategory ? "Category" : null);
            var products = await query.ToPagedList(request.PageNumber, request.PageSize);

            if (products.Items.Any())
            {
                return Result<PagedList<ProductDto>>.EmptyResult(nameof(ProductDto));
            }

            var productDtos = _mapper.Map<List<ProductDto>>(products.Items);
            var translationKeys = _translationKeyRepository.GetAllQueryable();
            var userLangId = _currentUser.GetLangId();

            productDtos.ForEach(product => product.TranslateEntityByAttributes(translationKeys, userLangId));

            return Result<PagedList<ProductDto>>.SuccessResult(new PagedList<ProductDto>
            {
                Items = productDtos,
                TotalCount = products.TotalCount,
                PageNumber = products.PageNumber,
                PageSize = products.PageSize
            });
        }
    }
}