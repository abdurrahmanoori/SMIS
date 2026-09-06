using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Queries
{
    public record ShopPullQuery(DateTime ChangedSince) : IRequest<Result<List<ShopDto>>>;

    internal sealed class ShopPullQueryHandler : IRequestHandler<ShopPullQuery, Result<List<ShopDto>>>
    {
        private readonly IShopRepository _shopRepository;
    private readonly IMapper _mapper;
    private readonly ICurrentUser _currentUser;

    public ShopPullQueryHandler(
        IShopRepository shopRepository,
        IMapper mapper,
        ICurrentUser currentUser)
    {
        _shopRepository = shopRepository;
        _mapper = mapper;
        _currentUser = currentUser;
        }

        public async Task<Result<List<ShopDto>>> Handle(ShopPullQuery request, CancellationToken cancellationToken)
        {
        var userShopId = _currentUser.GetShopId();
        var isSuperAdmin = _currentUser.IsSuperAdmin();

        var shops = await _shopRepository.GetAllQueryable()
                .IgnoreQueryFilters() // Include soft-deleted records
                .Where(e => e.LastModifiedUtc > request.ChangedSince &&
                            (isSuperAdmin || e.Id == userShopId))
                .ToListAsync(cancellationToken);

            var dtos = _mapper.Map<List<ShopDto>>(shops);
            return Result<List<ShopDto>>.SuccessResult(dtos);
        }
    }
}
