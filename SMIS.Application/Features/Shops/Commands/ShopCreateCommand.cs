using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Shops.Commands
{
    public record ShopCreateCommand(ShopCreateDto ShopCreateDto) : IRequest<Result<ShopDto>>;

    internal sealed class ShopCreateCommandHandler : IRequestHandler<ShopCreateCommand, Result<ShopDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ShopCreateCommandHandler(
            IApplicationDbContext db,
            IMapper mapper,
            IShopRepository shopRepository
        )
        {
            _db = db;
            _mapper = mapper;
            _shopRepository = shopRepository;
        }

        public async Task<Result<ShopDto>> Handle(
            ShopCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = ShopCommandRules.Create(request.ShopCreateDto);

            await _shopRepository.AddAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(entity), "Shop Created Successfully.");
        }
    }
}