using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.ShopOwners;

namespace SMIS.Application.Features.ShopOwners.Queries;

public record ShopOwnerGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<ShopOwnerDto>>>;

internal sealed class ShopOwnerGetListQueryHandler : IRequestHandler<ShopOwnerGetListQuery, Result<PagedList<ShopOwnerDto>>>
{
    private readonly IShopOwnerRepository _shopOwnerRepository;
    private readonly ITranslationKeyRepository _translationKeyRepository;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ShopOwnerGetListQueryHandler(IShopOwnerRepository shopOwnerRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser, IMapper mapper)
    {
        _shopOwnerRepository = shopOwnerRepository;
        _translationKeyRepository = translationKeyRepository;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<PagedList<ShopOwnerDto>>> Handle(ShopOwnerGetListQuery request, CancellationToken cancellationToken)
    {
        var query = _shopOwnerRepository.GetAllQueryable();
        var shopOwners = await query.ToPagedList(request.PageNumber, request.PageSize);

        if (!shopOwners.Items.Any())
        {
            return Result<PagedList<ShopOwnerDto>>.EmptyResult(nameof(ShopOwnerDto));
        }

        var shopOwnerDtos = _mapper.Map<List<ShopOwnerDto>>(shopOwners.Items);
        var translationKeys = _translationKeyRepository.GetAllQueryable();
        var userLangId = _currentUser.GetLangId();

        shopOwnerDtos.ForEach(shopOwner => shopOwner.TranslateEntityByAttributes(translationKeys, userLangId));

        return Result<PagedList<ShopOwnerDto>>.SuccessResult(new PagedList<ShopOwnerDto>
        {
            Items = shopOwnerDtos,
            TotalCount = shopOwners.TotalCount,
            PageNumber = shopOwners.PageNumber,
            PageSize = shopOwners.PageSize
        });
    }
}