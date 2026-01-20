using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Queries
{
    public record GetShopListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<ShopDto>>>;

    internal sealed class GetShopListQueryHandler : IRequestHandler<GetShopListQuery, Result<PagedList<ShopDto>>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly ICurrentUser _currentUser;

        public GetShopListQueryHandler(IShopRepository shopRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser)
        {
            _shopRepository = shopRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<PagedList<ShopDto>>> Handle(GetShopListQuery request, CancellationToken cancellationToken)
        {
            var userLangId = _currentUser.GetLangId();

            var translationKeys = _translationKeyRepository.GetAllQueryable();

            var query = _shopRepository.GetAllQueryable()
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
                });

            var pagedEntities = await query.ToPagedList(request.PageNumber, request.PageSize);
            if (pagedEntities.Items.Count == 0)
            {
                return Result<PagedList<ShopDto>>.EmptyResult(nameof(ShopDto));
            }

            return Result<PagedList<ShopDto>>.SuccessResult(pagedEntities);
        }
    }
}
