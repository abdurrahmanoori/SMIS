using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.Features.ShopOwners;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ShopOwners;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.ShopOwners.Commands;

public record ShopOwnerUpdateCommand(string Id, ShopOwnerCreateDto ShopOwnerCreateDto) : IRequest<Result<ShopOwnerDto>>;

internal sealed class ShopOwnerUpdateCommandHandler : IRequestHandler<ShopOwnerUpdateCommand, Result<ShopOwnerDto>>
{
    private readonly IShopOwnerRepository _shopOwnerRepository;
    private readonly IShopRepository _shopRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ShopOwnerUpdateCommandHandler(
        IUnitOfWork unitOfWork,
        IShopOwnerRepository shopOwnerRepository,
        IShopRepository shopRepository
    )
    {
        _unitOfWork = unitOfWork;
        _shopOwnerRepository = shopOwnerRepository;
        _shopRepository = shopRepository;
    }

    public async Task<Result<ShopOwnerDto>> Handle(
        ShopOwnerUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        var entity = await _shopOwnerRepository.GetByIdAsync(request.Id);
        if (entity == null)
            return Result<ShopOwnerDto>.NotFoundResult(request.Id);

        entity.SetUserId(request.ShopOwnerCreateDto.ApplicationUserId);
        entity.SetFirstName(request.ShopOwnerCreateDto.FirstName);
        entity.SetLastName(request.ShopOwnerCreateDto.LastName);
        entity.SetNationalIdCardNumber(request.ShopOwnerCreateDto.NationalIdCardNumber);
        entity.SetPhoneNumber(request.ShopOwnerCreateDto.PhoneNumber);
        entity.SetEmail(request.ShopOwnerCreateDto.Email);
        entity.SetAddress(request.ShopOwnerCreateDto.Address);
        entity.SetOwnershipPercentage(request.ShopOwnerCreateDto.OwnershipPercentage);

        if (request.ShopOwnerCreateDto.IsActive) entity.Activate();
        else entity.Deactivate();

        var shop = await _shopRepository.GetByIdAsync(entity.ShopId);
        entity.ShopName = shop?.Name ?? string.Empty;

        await _shopOwnerRepository.UpdateAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<ShopOwnerDto>.SuccessResult(ShopOwnerMapping.ToDto(entity));
    }
}
