using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Commands
{
    public record ShopDeleteCommand(string Id) : IRequest<Result<Unit>>;

    internal sealed class ShopDeleteCommandHandler : IRequestHandler<ShopDeleteCommand, Result<Unit>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ShopDeleteCommandHandler(IUnitOfWork unitOfWork, IShopRepository shopRepository)
        {
            _unitOfWork = unitOfWork;
            _shopRepository = shopRepository;
        }

        public async Task<Result<Unit>> Handle(ShopDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _shopRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<Unit>.NotFoundResult(request?.Id);
            }

            await _shopRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}
