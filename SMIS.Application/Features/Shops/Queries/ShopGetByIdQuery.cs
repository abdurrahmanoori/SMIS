using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Queries
{
    public record ShopGetByIdQuery(string Id) : IRequest<Result<ShopDto>>;

    internal sealed class ShopGetByIdQueryHandler : IRequestHandler<ShopGetByIdQuery, Result<ShopDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IMapper _mapper;

        public ShopGetByIdQueryHandler(
            IShopRepository shopRepository,
            IMapper mapper
        )
        {
            _shopRepository = shopRepository;
            _mapper = mapper;
        }

        public async Task<Result<ShopDto>> Handle(
            ShopGetByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var dbShop = await _shopRepository.GetFirstOrDefaultAsync(x => x.Id == request.Id);

            if (dbShop == null)
            {
                return Result<ShopDto>.NotFoundResult(nameof(ShopDto));
            }

            return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(dbShop));
        }
    }
}