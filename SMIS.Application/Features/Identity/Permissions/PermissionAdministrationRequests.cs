using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Permissions;

public sealed record GetPermissionCatalogQuery : IRequest<Result<PermissionCatalogDto>>;
public sealed record PermissionCatalogDto(
    IReadOnlyList<ApplicationComponentAdminDto> Components, IReadOnlyList<PermissionRoleDto> Roles);
public sealed record GetRoleComponentPermissionsQuery(string RoleId)
    : IRequest<Result<IReadOnlyList<RoleComponentPermissionAdminDto>>>;
public sealed record UpdateApplicationComponentCommand(string Id, UpdateApplicationComponentDto Dto) : IRequest<Result>;
public sealed record UpdateRoleComponentPermissionsCommand(string RoleId, UpdateRoleComponentPermissionsDto Dto) : IRequest<Result>;

public sealed class PermissionAdministrationHandler(IApplicationDbContext context, ICurrentUser currentUser)
    : IRequestHandler<GetPermissionCatalogQuery, Result<PermissionCatalogDto>>,
      IRequestHandler<GetRoleComponentPermissionsQuery, Result<IReadOnlyList<RoleComponentPermissionAdminDto>>>,
      IRequestHandler<UpdateApplicationComponentCommand, Result>,
      IRequestHandler<UpdateRoleComponentPermissionsCommand, Result>
{
    // Check current database membership as well as the endpoint authorization policy.
    private Task<bool> IsSuperAdminAsync(CancellationToken ct) =>
        context.UserRoles.AsNoTracking().AnyAsync(
            ur => ur.UserId == currentUser.GetId() &&
                  context.Roles.Any(r => r.Id == ur.RoleId && r.Name == SD.Role_Super_Admin), ct);

    public async Task<Result<PermissionCatalogDto>> Handle(GetPermissionCatalogQuery request, CancellationToken ct)
    {
        if (!await IsSuperAdminAsync(ct))
            return Result<PermissionCatalogDto>.Forbidden("permissions.forbidden", "Only SuperAdmin can manage permissions.");

        var components = await context.ApplicationComponents.AsNoTracking()
            .OrderBy(c => c.DisplayOrder).ThenBy(c => c.Key)
            .Select(c => new ApplicationComponentAdminDto(c.Id, c.Key, c.Name, c.DisplayOrder, c.IsActive))
            .ToListAsync(ct);
        var roles = await context.Roles.AsNoTracking().OrderBy(r => r.Name)
            .Select(r => new PermissionRoleDto(r.Id, r.Name!)).ToListAsync(ct);
        return Result<PermissionCatalogDto>.Success(new(components, roles));
    }

    public async Task<Result<IReadOnlyList<RoleComponentPermissionAdminDto>>> Handle(
        GetRoleComponentPermissionsQuery request, CancellationToken ct)
    {
        if (!await IsSuperAdminAsync(ct))
            return Result<IReadOnlyList<RoleComponentPermissionAdminDto>>.Forbidden(
                "permissions.forbidden", "Only SuperAdmin can manage permissions.");
        if (!await context.Roles.AnyAsync(r => r.Id == request.RoleId, ct))
            return Result<IReadOnlyList<RoleComponentPermissionAdminDto>>.NotFound(request.RoleId);

        var rows = await context.RoleComponentPermissions.AsNoTracking()
            .Where(p => p.RoleId == request.RoleId).OrderBy(p => p.ComponentId)
            .Select(p => new RoleComponentPermissionAdminDto(
                p.ComponentId, p.CanView, p.CanRead, p.CanCreate, p.CanUpdate, p.CanDelete)).ToListAsync(ct);
        return Result<IReadOnlyList<RoleComponentPermissionAdminDto>>.Success(rows);
    }

    public async Task<Result> Handle(UpdateApplicationComponentCommand request, CancellationToken ct)
    {
        if (!await IsSuperAdminAsync(ct))
            return Result.Forbidden("permissions.forbidden", "Only SuperAdmin can manage permissions.");
        var name = request.Dto.Name?.Trim();
        if (string.IsNullOrEmpty(name) || name.Length > 200 || request.Dto.DisplayOrder < 0)
            return Result.Validation("component.invalid", "Provide a name of up to 200 characters and a non-negative display order.");
        var component = await context.ApplicationComponents.SingleOrDefaultAsync(c => c.Id == request.Id, ct);
        if (component is null) return Result.NotFound(request.Id);
        // Keys and relationships are application-owned and cannot be renamed through administration.
        component.Name = name;
        component.DisplayOrder = request.Dto.DisplayOrder;
        component.IsActive = request.Dto.IsActive;
        await context.SaveChangesAsync(ct);
        return Result.Success();
    }

    public async Task<Result> Handle(UpdateRoleComponentPermissionsCommand request, CancellationToken ct)
    {
        if (!await IsSuperAdminAsync(ct))
            return Result.Forbidden("permissions.forbidden", "Only SuperAdmin can manage permissions.");
        var role = await context.Roles.AsNoTracking().SingleOrDefaultAsync(r => r.Id == request.RoleId, ct);
        if (role is null) return Result.NotFound(request.RoleId);
        if (role.Name == SD.Role_Super_Admin)
            return Result.BusinessRule("permissions.superadmin", "SuperAdmin has full access; its permission matrix cannot be changed.");

        var input = request.Dto.Permissions;
        if (input is null || input.Count == 0 || input.Any(p => p is null || string.IsNullOrWhiteSpace(p.ComponentId)) ||
            input.Select(p => p.ComponentId).Distinct().Count() != input.Count)
            return Result.Validation("permissions.invalid", "Supply a non-empty list of unique component permissions.");

        var ids = input.Select(p => p.ComponentId).ToArray();
        if (await context.ApplicationComponents.CountAsync(c => ids.Contains(c.Id), ct) != ids.Length)
            return Result.Validation("permissions.component_not_found", "One or more application components do not exist.");

        var existing = await context.RoleComponentPermissions.Where(p => p.RoleId == request.RoleId && ids.Contains(p.ComponentId))
            .ToDictionaryAsync(p => p.ComponentId, ct);
        foreach (var dto in input)
        {
            if (!existing.TryGetValue(dto.ComponentId, out var row))
            {
                row = new RoleComponentPermission { RoleId = request.RoleId, ComponentId = dto.ComponentId };
                context.RoleComponentPermissions.Add(row);
            }
            row.CanView = dto.CanView;
            row.CanRead = dto.CanRead;
            row.CanCreate = dto.CanCreate;
            row.CanUpdate = dto.CanUpdate;
            row.CanDelete = dto.CanDelete;
        }
        // One SaveChanges commits the entire matrix atomically.
        await context.SaveChangesAsync(ct);
        return Result.Success();
    }
}
