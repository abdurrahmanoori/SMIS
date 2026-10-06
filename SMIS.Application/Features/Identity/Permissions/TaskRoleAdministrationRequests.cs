using System.ComponentModel.DataAnnotations;
using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Permissions;

public sealed record ManagedTaskDto(string Id, string Key, string Name, string ComponentId, bool IsActive, bool IsSystem);
public sealed record ManagedRoleDto(string Id, string Name, bool IsSystem, int UserCount);
public sealed record ManagedTaskPermissionDto(string TaskId, bool IsAllowed);
public sealed class SaveTaskDto
{
    [Required, StringLength(150), RegularExpression(@"^[A-Za-z][A-Za-z0-9.]*$")]
    public string Key { get; set; } = string.Empty;
    [Required, StringLength(200)] public string Name { get; set; } = string.Empty;
    [Required] public string ComponentId { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
public sealed class SaveRoleDto
{
    [Required, StringLength(256)] public string Name { get; set; } = string.Empty;
}
public sealed class SaveTaskPermissionsDto
{
    [Required] public List<ManagedTaskPermissionDto> Permissions { get; set; } = [];
}
public sealed record GetManagedTasksQuery : IRequest<Result<IReadOnlyList<ManagedTaskDto>>>;
public sealed record GetManagedRolesQuery : IRequest<Result<IReadOnlyList<ManagedRoleDto>>>;
public sealed record GetManagedTaskPermissionsQuery(string RoleId) : IRequest<Result<IReadOnlyList<ManagedTaskPermissionDto>>>;
public sealed record SaveManagedTaskCommand(string? Id, SaveTaskDto Dto) : IRequest<Result>;
public sealed record DeleteManagedTaskCommand(string Id) : IRequest<Result>;
public sealed record SaveManagedRoleCommand(string? Id, SaveRoleDto Dto) : IRequest<Result>;
public sealed record DeleteManagedRoleCommand(string Id) : IRequest<Result>;
public sealed record SaveManagedTaskPermissionsCommand(string RoleId, SaveTaskPermissionsDto Dto) : IRequest<Result>;
public sealed record DeleteManagedTaskPermissionCommand(string RoleId, string TaskId) : IRequest<Result>;

public sealed class TaskRoleAdministrationHandler(
    IApplicationDbContext context, ICurrentUser currentUser, RoleManager<ApplicationRole> roleManager,
    UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
    : IRequestHandler<GetManagedTasksQuery, Result<IReadOnlyList<ManagedTaskDto>>>,
      IRequestHandler<GetManagedRolesQuery, Result<IReadOnlyList<ManagedRoleDto>>>,
      IRequestHandler<GetManagedTaskPermissionsQuery, Result<IReadOnlyList<ManagedTaskPermissionDto>>>,
      IRequestHandler<SaveManagedTaskCommand, Result>,
      IRequestHandler<DeleteManagedTaskCommand, Result>,
      IRequestHandler<SaveManagedRoleCommand, Result>,
      IRequestHandler<DeleteManagedRoleCommand, Result>,
      IRequestHandler<SaveManagedTaskPermissionsCommand, Result>,
      IRequestHandler<DeleteManagedTaskPermissionCommand, Result>
{
    private static readonly HashSet<string> SystemTaskKeys = typeof(ApplicationTaskKeys)
        .GetFields(BindingFlags.Public | BindingFlags.Static).Where(f => f.IsLiteral && f.FieldType == typeof(string))
        .Select(f => (string)f.GetRawConstantValue()!).ToHashSet(StringComparer.OrdinalIgnoreCase);
    private static bool IsSystemRole(string? name) => SD.AllRoles.Contains(name, StringComparer.OrdinalIgnoreCase);
    private Task<bool> Allowed(CancellationToken ct) => context.UserRoles.AsNoTracking().AnyAsync(
        ur => ur.UserId == currentUser.GetId() && context.Roles.Any(r => r.Id == ur.RoleId && r.Name == SD.Role_Super_Admin), ct);
    private static Result Forbidden() => Result.Forbidden("administration.forbidden", "Only SuperAdmin can manage roles and tasks.");
    private static Result IdentityResultToResult(IdentityResult result) => result.Succeeded ? Result.Success() :
        Result.Failure(result.Errors.Select(e => new Error { Code = e.Code, Description = e.Description }).ToList());

    private async Task<Result> Transaction(Func<Task<Result>> action, CancellationToken ct)
    {
        await unitOfWork.StartTransactionAsync(ct);
        try
        {
            var result = await action();
            if (!result.IsSuccess)
            {
                await unitOfWork.RollbackTransactionAsync(ct);
                return result;
            }
            await unitOfWork.CommitTransactionAsync(ct);
            return result;
        }
        catch (DbUpdateException)
        {
            if (unitOfWork.HasActiveTransaction) await unitOfWork.RollbackTransactionAsync(CancellationToken.None);
            return Result.BusinessRule("administration.conflict", "The record changed, already exists, or is still referenced. Refresh and try again.");
        }
        catch
        {
            if (unitOfWork.HasActiveTransaction) await unitOfWork.RollbackTransactionAsync(CancellationToken.None);
            throw;
        }
    }

    public async Task<Result<IReadOnlyList<ManagedTaskDto>>> Handle(GetManagedTasksQuery request, CancellationToken ct)
    {
        if (!await Allowed(ct)) return Result<IReadOnlyList<ManagedTaskDto>>.Forbidden("administration.forbidden", "Only SuperAdmin can manage tasks.");
        var tasks = await context.ApplicationTasks.AsNoTracking().OrderBy(t => t.Key).ToListAsync(ct);
        return Result<IReadOnlyList<ManagedTaskDto>>.Success(tasks.Select(t =>
            new ManagedTaskDto(t.Id, t.Key, t.Name, t.ComponentId, t.IsActive, SystemTaskKeys.Contains(t.Key))).ToList());
    }
    public async Task<Result<IReadOnlyList<ManagedRoleDto>>> Handle(GetManagedRolesQuery request, CancellationToken ct)
    {
        if (!await Allowed(ct)) return Result<IReadOnlyList<ManagedRoleDto>>.Forbidden("administration.forbidden", "Only SuperAdmin can manage roles.");
        var roles = await context.Roles.AsNoTracking().OrderBy(r => r.Name)
            .Select(r => new { r.Id, r.Name, Count = context.UserRoles.Count(ur => ur.RoleId == r.Id) }).ToListAsync(ct);
        return Result<IReadOnlyList<ManagedRoleDto>>.Success(roles.Select(r =>
            new ManagedRoleDto(r.Id, r.Name!, IsSystemRole(r.Name), r.Count)).ToList());
    }
    public async Task<Result<IReadOnlyList<ManagedTaskPermissionDto>>> Handle(GetManagedTaskPermissionsQuery request, CancellationToken ct)
    {
        if (!await Allowed(ct)) return Result<IReadOnlyList<ManagedTaskPermissionDto>>.Forbidden("administration.forbidden", "Only SuperAdmin can manage task permissions.");
        if (!await context.Roles.AnyAsync(r => r.Id == request.RoleId, ct))
            return Result<IReadOnlyList<ManagedTaskPermissionDto>>.NotFound(request.RoleId);
        var rows = await context.RoleTaskPermissions.AsNoTracking().Where(p => p.RoleId == request.RoleId)
            .OrderBy(p => p.TaskId).Select(p => new ManagedTaskPermissionDto(p.TaskId, p.IsAllowed)).ToListAsync(ct);
        return Result<IReadOnlyList<ManagedTaskPermissionDto>>.Success(rows);
    }
    public async Task<Result> Handle(SaveManagedTaskCommand request, CancellationToken ct)
    {
        if (!await Allowed(ct)) return Forbidden();
        var dto = request.Dto;
        var key = dto.Key?.Trim() ?? "";
        var name = dto.Name?.Trim() ?? "";
        if (name.Length is 0 or > 200 || key.Length is 0 or > 150 ||
            !System.Text.RegularExpressions.Regex.IsMatch(key, @"^[A-Za-z][A-Za-z0-9.]*$"))
            return Result.Validation("task.invalid", "Provide a name and a valid task key.");
        if (!await context.ApplicationComponents.AnyAsync(c => c.Id == dto.ComponentId, ct))
            return Result.Validation("task.component", "The selected component does not exist.");
        var task = request.Id is null ? new ApplicationTask() :
            await context.ApplicationTasks.SingleOrDefaultAsync(t => t.Id == request.Id, ct);
        if (task is null) return Result.NotFound(request.Id!);
        if (request.Id is not null && (task.Key != key ||
            (SystemTaskKeys.Contains(task.Key) && task.ComponentId != dto.ComponentId)))
            return Result.BusinessRule("task.protected", "Task keys are immutable; system tasks must retain their component.");
        if (await context.ApplicationTasks.AnyAsync(t => t.Key == key && t.Id != task.Id, ct))
            return Result.BusinessRule("task.duplicate", "This task key already exists.");
        if (request.Id is null && SystemTaskKeys.Contains(key))
            return Result.BusinessRule("task.reserved", "This key is reserved for an application task.");
        return await Transaction(async () =>
        {
            if (request.Id is null) context.ApplicationTasks.Add(task);
            task.Key = key; task.Name = name; task.ComponentId = dto.ComponentId; task.IsActive = dto.IsActive;
            await context.SaveChangesAsync(ct);
            return Result.Success();
        }, ct);
    }
    public async Task<Result> Handle(DeleteManagedTaskCommand request, CancellationToken ct)
    {
        if (!await Allowed(ct)) return Forbidden();
        var task = await context.ApplicationTasks.SingleOrDefaultAsync(t => t.Id == request.Id, ct);
        if (task is null) return Result.NotFound(request.Id);
        if (SystemTaskKeys.Contains(task.Key)) return Result.BusinessRule("task.protected", "System tasks cannot be deleted. Deactivate the task instead.");
        if (await context.RoleTaskPermissions.AnyAsync(p => p.TaskId == task.Id, ct))
            return Result.BusinessRule("task.in_use", "Remove this task's role permission records before deleting it.");
        return await Transaction(async () => { context.ApplicationTasks.Remove(task); await context.SaveChangesAsync(ct); return Result.Success(); }, ct);
    }
    public async Task<Result> Handle(SaveManagedRoleCommand request, CancellationToken ct)
    {
        if (!await Allowed(ct)) return Forbidden();
        var name = request.Dto.Name?.Trim() ?? "";
        if (name.Length is 0 or > 256) return Result.Validation("role.invalid", "Provide a role name of up to 256 characters.");
        var role = request.Id is null ? new ApplicationRole() : await roleManager.FindByIdAsync(request.Id);
        if (role is null) return Result.NotFound(request.Id!);
        if (request.Id is not null && IsSystemRole(role.Name))
            return Result.BusinessRule("role.protected", "Built-in role names cannot be changed.");
        if (IsSystemRole(name)) return Result.BusinessRule("role.reserved", "This role name is reserved.");
        var duplicate = await roleManager.FindByNameAsync(name);
        if (duplicate is not null && duplicate.Id != role.Id)
            return Result.BusinessRule("role.duplicate", "This role name already exists.");
        return await Transaction(async () =>
        {
            role.Name = name;
            var result = request.Id is null ? await roleManager.CreateAsync(role) : await roleManager.UpdateAsync(role);
            if (!result.Succeeded) return IdentityResultToResult(result);
            if (request.Id is not null)
            {
                var assignments = await context.UserRoles.Where(ur => ur.RoleId == role.Id).ToListAsync(ct);
                foreach (var assignment in assignments) assignment.RoleName = name;
                var ids = assignments.Select(a => a.UserId).ToArray();
                var users = await userManager.Users.Where(u => ids.Contains(u.Id)).ToListAsync(ct);
                foreach (var user in users) user.InvalidateSessions();
            }
            return Result.Success();
        }, ct);
    }
    public async Task<Result> Handle(DeleteManagedRoleCommand request, CancellationToken ct)
    {
        if (!await Allowed(ct)) return Forbidden();
        var role = await roleManager.FindByIdAsync(request.Id);
        if (role is null) return Result.NotFound(request.Id);
        if (IsSystemRole(role.Name)) return Result.BusinessRule("role.protected", "Built-in roles cannot be deleted.");
        if (await context.UserRoles.AnyAsync(ur => ur.RoleId == role.Id, ct))
            return Result.BusinessRule("role.in_use", "Unassign this role from all users before deleting it.");
        return await Transaction(async () =>
        {
            context.RoleTaskPermissions.RemoveRange(await context.RoleTaskPermissions.Where(p => p.RoleId == role.Id).ToListAsync(ct));
            context.RoleComponentPermissions.RemoveRange(await context.RoleComponentPermissions.Where(p => p.RoleId == role.Id).ToListAsync(ct));
            foreach (var claim in await roleManager.GetClaimsAsync(role))
            {
                var removed = await roleManager.RemoveClaimAsync(role, claim);
                if (!removed.Succeeded) return IdentityResultToResult(removed);
            }
            await context.SaveChangesAsync(ct);
            return IdentityResultToResult(await roleManager.DeleteAsync(role));
        }, ct);
    }
    private async Task<Result?> ValidateEditableRole(string roleId, CancellationToken ct)
    {
        var role = await context.Roles.AsNoTracking().SingleOrDefaultAsync(r => r.Id == roleId, ct);
        if (role is null) return Result.NotFound(roleId);
        return role.Name == SD.Role_Super_Admin
            ? Result.BusinessRule("permissions.superadmin", "SuperAdmin has full access; its task grants cannot be changed.") : null;
    }
    public async Task<Result> Handle(SaveManagedTaskPermissionsCommand request, CancellationToken ct)
    {
        if (!await Allowed(ct)) return Forbidden();
        var error = await ValidateEditableRole(request.RoleId, ct);
        if (error is not null) return error;
        var input = request.Dto.Permissions;
        if (input is null || input.Any(p => p is null || string.IsNullOrWhiteSpace(p.TaskId)) ||
            input.Select(p => p.TaskId).Distinct().Count() != input.Count)
            return Result.Validation("tasks.invalid", "Supply unique task permission records.");
        var ids = input.Select(p => p.TaskId).ToArray();
        if (await context.ApplicationTasks.CountAsync(t => ids.Contains(t.Id), ct) != ids.Length)
            return Result.Validation("tasks.not_found", "One or more tasks do not exist.");
        var existing = await context.RoleTaskPermissions.Where(p => p.RoleId == request.RoleId).ToDictionaryAsync(p => p.TaskId, ct);
        // Replace the complete matrix; omission removes a permission record.
        foreach (var row in existing.Values.Where(p => !ids.Contains(p.TaskId))) context.RoleTaskPermissions.Remove(row);
        foreach (var dto in input)
        {
            if (!existing.TryGetValue(dto.TaskId, out var row))
            {
                row = new RoleTaskPermission { RoleId = request.RoleId, TaskId = dto.TaskId };
                context.RoleTaskPermissions.Add(row);
            }
            row.IsAllowed = dto.IsAllowed;
        }
        return await Transaction(async () => { await context.SaveChangesAsync(ct); return Result.Success(); }, ct);
    }
    public async Task<Result> Handle(DeleteManagedTaskPermissionCommand request, CancellationToken ct)
    {
        if (!await Allowed(ct)) return Forbidden();
        var error = await ValidateEditableRole(request.RoleId, ct);
        if (error is not null) return error;
        var row = await context.RoleTaskPermissions.SingleOrDefaultAsync(p => p.RoleId == request.RoleId && p.TaskId == request.TaskId, ct);
        if (row is null) return Result.NotFound(request.TaskId);
        return await Transaction(async () => { context.RoleTaskPermissions.Remove(row); await context.SaveChangesAsync(ct); return Result.Success(); }, ct);
    }
}
