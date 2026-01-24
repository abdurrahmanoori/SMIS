using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Queries
{
    public record ShopGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<ShopDto>>>;

    internal sealed class ShopGetListQueryHandler : IRequestHandler<ShopGetListQuery, Result<PagedList<ShopDto>>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public ShopGetListQueryHandler(IShopRepository shopRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser, IMapper mapper)
        {
            _shopRepository = shopRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<ShopDto>>> Handle(ShopGetListQuery request, CancellationToken cancellationToken)
        {
            var shops = await _shopRepository.GetAllQueryable()
                .ToPagedList(request.PageNumber, request.PageSize);

            if (!shops.Items.Any())
            {
                return Result<PagedList<ShopDto>>.EmptyResult(nameof(ShopDto));
            }

            var shopDtos = _mapper.Map<List<ShopDto>>(shops.Items);
            var translationKeys = _translationKeyRepository.GetAllQueryable();
            var userLangId = _currentUser.GetLangId();

            shopDtos.ForEach(shop => shop.TranslateEntityByAttributes(translationKeys, userLangId));

            return Result<PagedList<ShopDto>>.SuccessResult(new PagedList<ShopDto>
            {
                Items = shopDtos,
                TotalCount = shops.TotalCount,
                PageNumber = shops.PageNumber,
                PageSize = shops.PageSize,
                TotalPages = shops.TotalPages
            });
        }
    }
}
