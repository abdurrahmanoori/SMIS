using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ShopOwners;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ShopOwners.Commands;

public record ShopOwnerCreateCommand(ShopOwnerCreateDto ShopOwnerCreateDto) : IRequest<Result<ShopOwnerDto>>;

internal sealed class ShopOwnerCreateCommandHandler : IRequestHandler<ShopOwnerCreateCommand, Result<ShopOwnerDto>>
{
    private readonly IShopOwnerRepository _shopOwnerRepository;
    private readonly IShopRepository _shopRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ICurrentUser _currentUser;

    public ShopOwnerCreateCommandHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        IShopOwnerRepository shopOwnerRepository,
        IShopRepository shopRepository,
        ICurrentUser currentUser
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _shopOwnerRepository = shopOwnerRepository;
        _shopRepository = shopRepository;
        _currentUser = currentUser;
    }

    public async Task<Result<ShopOwnerDto>> Handle(
        ShopOwnerCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(shopId))
            return Result<ShopOwnerDto>.FailureResult("ShopContextRequired", "An active shop is required.");

        var dto = request.ShopOwnerCreateDto;
        var entity = ShopOwner.Create(
            dto.ApplicationUserId,
            shopId,
            dto.FirstName,
            dto.LastName,
            dto.PhoneNumber,
            dto.Email,
            dto.Address,
            dto.OwnershipPercentage);
        entity.SetNationalIdCardNumber(dto.NationalIdCardNumber);
        if (!dto.IsActive) entity.Deactivate();

        // Populate name fields
        var shop = await _shopRepository.GetByIdAsync(shopId);
        entity.ShopName = shop?.Name ?? string.Empty;

        await _shopOwnerRepository.AddAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<ShopOwnerDto>.SuccessResult(_mapper.Map<ShopOwnerDto>(entity));
    }
}