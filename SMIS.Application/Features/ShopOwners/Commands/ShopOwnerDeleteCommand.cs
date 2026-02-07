using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ShopOwners;

namespace SMIS.Application.Features.ShopOwners.Commands;

public record ShopOwnerDeleteCommand(string Id) : IRequest<Result<Unit>>;

internal sealed class ShopOwnerDeleteCommandHandler : IRequestHandler<ShopOwnerDeleteCommand, Result<Unit>>
{
    private readonly IShopOwnerRepository _shopOwnerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ShopOwnerDeleteCommandHandler(IUnitOfWork unitOfWork, IShopOwnerRepository shopOwnerRepository)
    {
        _unitOfWork = unitOfWork;
        _shopOwnerRepository = shopOwnerRepository;
    }

    public async Task<Result<Unit>> Handle(ShopOwnerDeleteCommand request, CancellationToken cancellationToken)
    {
        var entity = await _shopOwnerRepository.GetByIdAsync(request.Id);
        if (entity == null)
            return Result<Unit>.NotFoundResult(request.Id);

        await _shopOwnerRepository.RemoveAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<Unit>.SuccessResult(Unit.Value);
    }
}