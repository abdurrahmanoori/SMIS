using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Queries
{
    public record ShopPullQuery(DateTime ChangedSince) : IRequest<Result<List<ShopDto>>>;

    internal sealed class ShopPullQueryHandler : IRequestHandler<ShopPullQuery, Result<List<ShopDto>>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IMapper _mapper;

        public ShopPullQueryHandler(IShopRepository shopRepository, IMapper mapper)
        {
            _shopRepository = shopRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<ShopDto>>> Handle(ShopPullQuery request, CancellationToken cancellationToken)
        {
            var shops = await _shopRepository.GetAllQueryable()
                .IgnoreQueryFilters() // Include soft-deleted records
                .Where(e => e.LastModifiedUtc > request.ChangedSince)
                .ToListAsync(cancellationToken);

            var dtos = _mapper.Map<List<ShopDto>>(shops);
            return Result<List<ShopDto>>.SuccessResult(dtos);
        }
    }
}
