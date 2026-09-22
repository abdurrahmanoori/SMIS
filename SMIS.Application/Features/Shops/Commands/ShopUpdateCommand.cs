using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Shops.Commands
{
    public record ShopUpdateCommand(string Id, ShopUpdateDto ShopUpdateDto) : IRequest<Result<ShopDto>>;

    internal sealed class ShopUpdateCommandHandler : IRequestHandler<ShopUpdateCommand, Result<ShopDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ShopUpdateCommandHandler(
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
            ShopUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _shopRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<ShopDto>.NotFoundResult(nameof(ShopDto.Id));
            }

            ShopCommandRules.Apply(entity, request.ShopUpdateDto);

            entity.ClearClientModificationMetadata();

            await _db.SaveChangesAsync(cancellationToken);

            var dto = _mapper.Map<ShopDto>(entity);
            return Result<ShopDto>.SuccessResult(dto);
        }
    }
}