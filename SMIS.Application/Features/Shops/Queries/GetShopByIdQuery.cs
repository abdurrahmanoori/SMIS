using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Queries
{
    public record GetShopByIdQuery(string PublicId) : IRequest<Result<ShopDto>>;

    internal sealed class GetShopByIdQueryHandler : IRequestHandler<GetShopByIdQuery, Result<ShopDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public GetShopByIdQueryHandler(IShopRepository shopRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser, IMapper mapper)
        {
            _shopRepository = shopRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
            _mapper = mapper;
        }

        public async Task<Result<ShopDto>> Handle(GetShopByIdQuery request, CancellationToken cancellationToken)
        {
            var dbShop = await _shopRepository.GetFirstOrDefaultAsync(x => x.PublicId == request.PublicId);
            
            if (dbShop == null)
            {
                return Result<ShopDto>.NotFoundResult(nameof(ShopDto));
            }

            var shop = _mapper.Map<ShopDto>(dbShop);
            shop.TranslateEntityByAttributes(_translationKeyRepository.GetAllQueryable(), _currentUser.GetLangId());

            return Result<ShopDto>.SuccessResult(shop);
        }
    }
}
