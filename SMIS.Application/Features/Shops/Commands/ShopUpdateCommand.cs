using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Services;
using SMIS.Application.Mappings;

namespace SMIS.Application.Features.Shops.Commands
{
    public record ShopUpdateCommand(string Id, ShopUpdateDto ShopUpdateDto) : IRequest<Result<ShopDto>>;

    internal sealed class ShopUpdateCommandHandler : IRequestHandler<ShopUpdateCommand, Result<ShopDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IApplicationDbContext _db;

        public ShopUpdateCommandHandler(
            IApplicationDbContext db,
            IShopRepository shopRepository
        )
        {
            _db = db;
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
                return Result<ShopDto>.NotFound(nameof(ShopDto.Id));
            }

            ShopCommandRules.Apply(entity, request.ShopUpdateDto);

            entity.ClearClientModificationMetadata();

            await _db.SaveChangesAsync(cancellationToken);

            var dto = entity.ToDto();
            return Result<ShopDto>.Success(dto);
        }
    }
}