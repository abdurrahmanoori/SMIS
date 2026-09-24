using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Shops.Commands;

public record ShopSyncCreateCommand(ShopSyncCreateDto Dto) : IRequest<Result<ShopDto>>;

public record ShopSyncUpdateCommand(string Id, ShopSyncUpdateDto Dto) : IRequest<Result<ShopDto>>;

public record ShopSyncDeleteCommand(string Id, ShopSyncDeleteDto Dto) : IRequest<Result<ShopDto>>;

internal sealed class ShopSyncCreateCommandHandler : IRequestHandler<ShopSyncCreateCommand, Result<ShopDto>>
{
    private readonly IShopRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ShopSyncCreateCommandHandler(
        IShopRepository repository,
        IApplicationDbContext db,
        ICurrentUser currentUser,
        IMapper mapper
    )
    {
        _repository = repository;
        _db = db;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<ShopDto>> Handle(
        ShopSyncCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = ShopSyncRules.NormalizeGuid(request.Dto.Id!);
        if (!_currentUser.IsSuperAdmin() && id != _currentUser.GetShopId())
            return ShopSyncRules.Forbidden();

        var existing = await _repository.GetByIdIncludingDeletedAsync(id, cancellationToken);
        if (existing is not null)
        {
            if (!ShopSyncRules.CanAccess(existing, _currentUser))
                return ShopSyncRules.Forbidden();

            var clientModified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
            if (clientModified <= existing.GetConflictModifiedUtc())
                return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(existing));

            ShopCommandRules.Apply(existing, request.Dto);
            existing.SetClientModificationMetadata(clientModified);
            existing.Restore();
            await _db.SaveChangesAsync(cancellationToken);
            return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(existing));
        }

        var shop = ShopCommandRules.Create(request.Dto);
        shop.Id = id;
        shop.SetClientModificationMetadata(DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate));
        await _repository.AddAsync(shop);
        await _db.SaveChangesAsync(cancellationToken);
        return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(shop));
    }
}

internal sealed class ShopSyncUpdateCommandHandler : IRequestHandler<ShopSyncUpdateCommand, Result<ShopDto>>
{
    private readonly IShopRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ShopSyncUpdateCommandHandler(
        IShopRepository repository,
        IApplicationDbContext db,
        ICurrentUser currentUser,
        IMapper mapper
    )
    {
        _repository = repository;
        _db = db;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<ShopDto>> Handle(
        ShopSyncUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = ShopSyncRules.NormalizeGuid(request.Id);
        var shop = await _repository.GetByIdIncludingDeletedAsync(id, cancellationToken);
        if (shop is null)
            return Result<ShopDto>.NotFoundResult(id);
        if (!ShopSyncRules.CanAccess(shop, _currentUser))
            return ShopSyncRules.Forbidden();

        var clientModified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (clientModified <= shop.GetConflictModifiedUtc())
            return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(shop));

        ShopCommandRules.Apply(shop, request.Dto);
        shop.SetClientModificationMetadata(clientModified);
        shop.Restore();
        await _db.SaveChangesAsync(cancellationToken);
        return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(shop));
    }
}

internal sealed class ShopSyncDeleteCommandHandler : IRequestHandler<ShopSyncDeleteCommand, Result<ShopDto>>
{
    private readonly IShopRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ShopSyncDeleteCommandHandler(
        IShopRepository repository,
        IApplicationDbContext db,
        ICurrentUser currentUser,
        IMapper mapper
    )
    {
        _repository = repository;
        _db = db;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<ShopDto>> Handle(
        ShopSyncDeleteCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = ShopSyncRules.NormalizeGuid(request.Id);
        var shop = await _repository.GetByIdIncludingDeletedAsync(id, cancellationToken);
        if (shop is null)
            return Result<ShopDto>.NotFoundResult(id);
        if (!ShopSyncRules.CanAccess(shop, _currentUser))
            return ShopSyncRules.Forbidden();

        var clientModified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (clientModified < shop.GetConflictModifiedUtc())
            return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(shop));

        var referenceCount = await _repository.CountReferencesAsync(
            shop.Id,
            cancellationToken);
        if (referenceCount > 0)
            return Result<ShopDto>.FailureResult(
                "ShopInUse",
                $"Shop contains {referenceCount} related record(s). Remove or reassign them before deleting the shop.");

        shop.SetClientModificationMetadata(clientModified);
        await _repository.RemoveAsync(shop);
        await _db.SaveChangesAsync(cancellationToken);
        return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(shop));
    }
}

internal static class ShopSyncRules
{
    public static string NormalizeGuid(
        string value
    ) => Guid.Parse(value).ToString("D");

    public static bool CanAccess(
        Shop shop,
        ICurrentUser currentUser
    ) =>
        currentUser.IsSuperAdmin() || shop.Id == currentUser.GetShopId();

    public static Result<ShopDto> Forbidden() => Result<ShopDto>.FailureResult(
        "Forbidden", "You can only synchronize your own shop.");
}