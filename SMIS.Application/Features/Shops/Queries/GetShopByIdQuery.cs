using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Shops;
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

        public GetShopByIdQueryHandler(IShopRepository shopRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser)
        {
            _shopRepository = shopRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<ShopDto>> Handle(GetShopByIdQuery request, CancellationToken cancellationToken)
        {
            var userLangId = _currentUser.GetLangId();
            var translationKeys = _translationKeyRepository.GetAllQueryable();

            var shop = await _shopRepository.GetAllQueryable()
                .Where(s => s.PublicId == request.PublicId)
                .Select(s => new ShopDto
                {
                    Id = s.Id,
                    PublicId = s.PublicId,
                    Name = translationKeys
                        .Where(tk => tk.Name == s.Name)
                        .SelectMany(tk => tk.Translations)
                        .Where(t => t.LanguageNo == userLangId)
                        .Select(t => t.Name)
                        .FirstOrDefault() ?? s.Name,
                    ShopType = s.ShopType,
                    Address = s.Address,
                    PhoneNumber = s.PhoneNumber,
                    Email = s.Email,
                    TaxNumber = s.TaxNumber,
                    IsActive = s.IsActive
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (shop == null)
            {
                return Result<ShopDto>.NotFoundResult(nameof(ShopDto));
            }

            return Result<ShopDto>.SuccessResult(shop);
        }
    }
}
