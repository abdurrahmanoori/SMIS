using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Purchasing.Commands;

public sealed record SupplierSyncCreateCommand(SupplierSyncCreateDto Dto)
    : IRequest<Result<SupplierDto>>;

public sealed record SupplierSyncUpdateCommand(string Id, SupplierSyncUpdateDto Dto)
    : IRequest<Result<SupplierDto>>;

internal sealed class SupplierSyncCreateCommandHandler
    : IRequestHandler<SupplierSyncCreateCommand, Result<SupplierDto>>
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public SupplierSyncCreateCommandHandler(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<SupplierDto>> Handle(
        SupplierSyncCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(shopId))
            return SupplierSyncRules.ShopContextRequired();

        var id = SupplierSyncRules.NormalizeGuid(request.Dto.Id);
        var clientModified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        var existing = await _db.Suppliers
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(supplier => supplier.Id == id, cancellationToken);

        if (existing is not null)
        {
            if (!SupplierSyncRules.CanAccess(existing, shopId))
                return SupplierSyncRules.Forbidden();

            if (clientModified <= existing.GetConflictModifiedUtc())
                return Result<SupplierDto>.Success(PurchasingDtoMapper.ToDto(existing));

            var duplicateResult = await SupplierSyncRules.EnsureUniqueName(
                _db,
                shopId,
                request.Dto.Name,
                existing.Id,
                cancellationToken);
            if (duplicateResult is not null)
                return duplicateResult;

            SupplierSyncRules.Apply(existing, request.Dto.Name, request.Dto.PhoneNumber, request.Dto.Notes,
                request.Dto.IsActive);
            existing.SetClientModificationMetadata(clientModified);
            existing.Restore();

            await _db.SaveChangesAsync(cancellationToken);
            return Result<SupplierDto>.Success(PurchasingDtoMapper.ToDto(existing));
        }

        var createDuplicateResult = await SupplierSyncRules.EnsureUniqueName(
            _db,
            shopId,
            request.Dto.Name,
            null,
            cancellationToken);
        if (createDuplicateResult is not null)
            return createDuplicateResult;

        var supplier = Supplier.Create(
            shopId,
            request.Dto.Name,
            request.Dto.PhoneNumber,
            request.Dto.Notes);
        supplier.Id = id;
        if (!request.Dto.IsActive)
            supplier.Deactivate();
        supplier.SetClientModificationMetadata(clientModified);

        await _db.Suppliers.AddAsync(supplier, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);

        return Result<SupplierDto>.Success(PurchasingDtoMapper.ToDto(supplier));
    }
}

internal sealed class SupplierSyncUpdateCommandHandler
    : IRequestHandler<SupplierSyncUpdateCommand, Result<SupplierDto>>
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public SupplierSyncUpdateCommandHandler(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<SupplierDto>> Handle(
        SupplierSyncUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(shopId))
            return SupplierSyncRules.ShopContextRequired();

        var id = SupplierSyncRules.NormalizeGuid(request.Id);
        var supplier = await _db.Suppliers
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
        if (supplier is null)
            return Result<SupplierDto>.NotFound(
                "supplier.not_found",
                "The supplier does not exist in the active shop.");

        if (!SupplierSyncRules.CanAccess(supplier, shopId))
            return SupplierSyncRules.Forbidden();

        var clientModified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (clientModified <= supplier.GetConflictModifiedUtc())
            return Result<SupplierDto>.Success(PurchasingDtoMapper.ToDto(supplier));

        var duplicateResult = await SupplierSyncRules.EnsureUniqueName(
            _db,
            shopId,
            request.Dto.Name,
            supplier.Id,
            cancellationToken);
        if (duplicateResult is not null)
            return duplicateResult;

        SupplierSyncRules.Apply(supplier, request.Dto.Name, request.Dto.PhoneNumber, request.Dto.Notes,
            request.Dto.IsActive);
        supplier.SetClientModificationMetadata(clientModified);
        supplier.Restore();

        await _db.SaveChangesAsync(cancellationToken);
        return Result<SupplierDto>.Success(PurchasingDtoMapper.ToDto(supplier));
    }
}

internal static class SupplierSyncRules
{
    public static string NormalizeGuid(
        string value
    ) => Guid.Parse(value).ToString("D");

    public static bool CanAccess(
        Supplier supplier,
        string shopId
    ) => string.Equals(supplier.ShopId, shopId, StringComparison.Ordinal);

    public static Result<SupplierDto> Forbidden() =>
        Result<SupplierDto>.Forbidden(
            "supplier.sync_forbidden",
            "You can only synchronize suppliers from your own shop.");

    public static Result<SupplierDto> ShopContextRequired() =>
        Result<SupplierDto>.Forbidden(
            "supplier.shop_context_required",
            "An active shop is required.");

    public static async Task<Result<SupplierDto>?> EnsureUniqueName(
        IApplicationDbContext db,
        string shopId,
        string name,
        string? excludeId,
        CancellationToken cancellationToken
    )
    {
        var normalizedName = name.Trim();
        var duplicate = await db.Suppliers
            .IgnoreQueryFilters()
            .AnyAsync(
                supplier =>
                    !supplier.IsDeleted &&
                    supplier.ShopId == shopId &&
                    supplier.Name == normalizedName &&
                    (excludeId == null || supplier.Id != excludeId),
                cancellationToken);

        return duplicate
            ? Result<SupplierDto>.Conflict(
                "supplier.name_conflict",
                "A supplier with this name already exists in the shop.")
            : null;
    }

    public static void Apply(
        Supplier supplier,
        string name,
        string? phoneNumber,
        string? notes,
        bool isActive
    )
    {
        supplier.Update(name, phoneNumber, notes);
        if (isActive)
            supplier.Activate();
        else
            supplier.Deactivate();
    }
}
