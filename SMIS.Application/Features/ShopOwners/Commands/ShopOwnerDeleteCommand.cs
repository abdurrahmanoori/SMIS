using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ShopOwners;

namespace SMIS.Application.Features.ShopOwners.Commands;

public record ShopOwnerDeleteCommand(string Id) : IRequest<Result>;

internal sealed class ShopOwnerDeleteCommandHandler : IRequestHandler<ShopOwnerDeleteCommand, Result>
{
    private readonly IShopOwnerRepository _shopOwnerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ShopOwnerDeleteCommandHandler(
        IUnitOfWork unitOfWork,
        IShopOwnerRepository shopOwnerRepository
    )
    {
        _unitOfWork = unitOfWork;
        _shopOwnerRepository = shopOwnerRepository;
    }

    public async Task<Result> Handle(
        ShopOwnerDeleteCommand request,
        CancellationToken cancellationToken
    )
    {
        var entity = await _shopOwnerRepository.GetByIdAsync(request.Id);
        if (entity == null)
            return Result.NotFound(request.Id);

        await _shopOwnerRepository.RemoveAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result.Success();
    }
}