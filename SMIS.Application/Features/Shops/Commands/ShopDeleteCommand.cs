using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Shops.Commands
{
    public record ShopDeleteCommand(string Id) : IRequest<Result>;

    internal sealed class ShopDeleteCommandHandler : IRequestHandler<ShopDeleteCommand, Result>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IApplicationDbContext _db;

        public ShopDeleteCommandHandler(
            IApplicationDbContext db,
            IShopRepository shopRepository
        )
        {
            _db = db;
            _shopRepository = shopRepository;
        }

        public async Task<Result> Handle(
            ShopDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _shopRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result.NotFound(request?.Id);
            }

            var referenceCount = await _shopRepository.CountReferencesAsync(
                entity.Id,
                cancellationToken);
            if (referenceCount > 0)
                return Result.BusinessRule(
                    "ShopInUse",
                    $"Shop contains {referenceCount} related record(s). Remove or reassign them before deleting the shop.");

            entity.ClearClientModificationMetadata();
            await _shopRepository.RemoveAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);
            return Result.Success();
        }
    }
}