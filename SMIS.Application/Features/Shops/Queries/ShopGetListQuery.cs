using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Queries
{
    public record ShopGetListQuery(int PageNumber = 1, int PageSize = 25, string? SearchTerm = null) : IRequest<Result<PagedList<ShopDto>>>;

    internal sealed class ShopGetListQueryHandler : IRequestHandler<ShopGetListQuery, Result<PagedList<ShopDto>>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IMapper _mapper;

        public ShopGetListQueryHandler(IShopRepository shopRepository, IMapper mapper)
        {
            _shopRepository = shopRepository;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<ShopDto>>> Handle(ShopGetListQuery request, CancellationToken cancellationToken)
        {
            var query = _shopRepository.GetAllQueryable();

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                var term = request.SearchTerm.ToLower();
                query = query.Where(s =>
                    s.Name.ToLower().Contains(term) ||
                    (s.Address != null && s.Address.ToLower().Contains(term)) ||
                    (s.PhoneNumber != null && s.PhoneNumber.ToLower().Contains(term)) ||
                    (s.Email != null && s.Email.ToLower().Contains(term)) ||
                    (s.TaxNumber != null && s.TaxNumber.ToLower().Contains(term)));
            }

            var shops = await query.ToPagedList(request.PageNumber, request.PageSize);

            if (!shops.Items.Any())
            {
                return Result<PagedList<ShopDto>>.EmptyResult(nameof(ShopDto));
            }

            var shopDtos = _mapper.Map<List<ShopDto>>(shops.Items);

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
