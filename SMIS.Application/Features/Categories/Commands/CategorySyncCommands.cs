using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Categories;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Categories.Commands;

public record CategorySyncCreateCommand(CategorySyncCreateDto Dto)
    : IRequest<Result<CategoryDto>>;

public record CategorySyncUpdateCommand(string Id, CategorySyncUpdateDto Dto)
    : IRequest<Result<CategoryDto>>;

public record CategorySyncDeleteCommand(string Id, CategorySyncDeleteDto Dto)
    : IRequest<Result<CategoryDto>>;

internal sealed class CategorySyncCreateCommandHandler
    : IRequestHandler<CategorySyncCreateCommand, Result<CategoryDto>>
{
    private readonly ICategoryRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public CategorySyncCreateCommandHandler(
        ICategoryRepository repository,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<CategoryDto>> Handle(
        CategorySyncCreateCommand request,
        CancellationToken cancellationToken)
    {
        if (!CategorySyncGuard.TryCanonicalGuid(request.Dto.Id, out var id))
            return CategorySyncGuard.InvalidId();

        if (!CategorySyncGuard.UserMetadataMatches(
                request.Dto.ClientCreatedBy,
                _currentUser) ||
            !CategorySyncGuard.UserMetadataMatches(
                request.Dto.ClientModifiedBy,
                _currentUser))
        {
            return CategorySyncGuard.InvalidUser();
        }

        var clientCreated = DateTimeService.NormalizeUtc(
            request.Dto.ClientCreatedDate);

        var clientModified = DateTimeService.NormalizeUtc(
            request.Dto.ClientModifiedDate);

        var existing = await _repository.GetByIdIncludingDeletedAsync(
            id,
            cancellationToken);

        if (existing != null)
        {
            if (!CategorySyncGuard.CanAccess(existing, _currentUser))
                return CategorySyncGuard.Forbidden();

            if (clientModified <= existing.GetConflictModifiedUtc())
            {
                return Result<CategoryDto>.SuccessResult(
                    _mapper.Map<CategoryDto>(existing));
            }

            CategorySyncGuard.Apply(existing, request.Dto);

            existing.SetClientCreationMetadata(
                clientCreated,
                request.Dto.ClientCreatedBy);

            existing.SetClientModificationMetadata(
                clientModified,
                request.Dto.ClientModifiedBy);

            existing.Restore();

            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<CategoryDto>.SuccessResult(
                _mapper.Map<CategoryDto>(existing));
        }

        var category = Category.Create(
            request.Dto.Name,
            _currentUser.GetShopId(),
            request.Dto.Code,
            request.Dto.Description,
            request.Dto.IsActive);

        category.Id = id;

        category.SetClientCreationMetadata(
            clientCreated,
            request.Dto.ClientCreatedBy);

        category.SetClientModificationMetadata(
            clientModified,
            request.Dto.ClientModifiedBy);

        await _repository.AddAsync(category);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<CategoryDto>.SuccessResult(
            _mapper.Map<CategoryDto>(category));
    }
}

internal sealed class CategorySyncUpdateCommandHandler
    : IRequestHandler<CategorySyncUpdateCommand, Result<CategoryDto>>
{
    private readonly ICategoryRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public CategorySyncUpdateCommandHandler(
        ICategoryRepository repository,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<CategoryDto>> Handle(
        CategorySyncUpdateCommand request,
        CancellationToken cancellationToken)
    {
        if (!CategorySyncGuard.TryCanonicalGuid(request.Id, out var id))
            return CategorySyncGuard.InvalidId();

        if (!CategorySyncGuard.UserMetadataMatches(
                request.Dto.ClientModifiedBy,
                _currentUser))
        {
            return CategorySyncGuard.InvalidUser();
        }

        var category = await _repository.GetByIdIncludingDeletedAsync(
            id,
            cancellationToken);

        if (category == null)
            return Result<CategoryDto>.NotFoundResult(id);

        if (!CategorySyncGuard.CanAccess(category, _currentUser))
            return CategorySyncGuard.Forbidden();

        var clientModified = DateTimeService.NormalizeUtc(
            request.Dto.ClientModifiedDate);

        if (clientModified <= category.GetConflictModifiedUtc())
        {
            return Result<CategoryDto>.SuccessResult(
                _mapper.Map<CategoryDto>(category));
        }

        CategorySyncGuard.Apply(category, request.Dto);

        category.SetClientModificationMetadata(
            clientModified,
            request.Dto.ClientModifiedBy);

        category.Restore();

        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<CategoryDto>.SuccessResult(
            _mapper.Map<CategoryDto>(category));
    }
}

internal sealed class CategorySyncDeleteCommandHandler
    : IRequestHandler<CategorySyncDeleteCommand, Result<CategoryDto>>
{
    private readonly ICategoryRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public CategorySyncDeleteCommandHandler(
        ICategoryRepository repository,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<CategoryDto>> Handle(
        CategorySyncDeleteCommand request,
        CancellationToken cancellationToken)
    {
        if (!CategorySyncGuard.TryCanonicalGuid(request.Id, out var id))
            return CategorySyncGuard.InvalidId();

        if (!CategorySyncGuard.UserMetadataMatches(
                request.Dto.ClientModifiedBy,
                _currentUser))
        {
            return CategorySyncGuard.InvalidUser();
        }

        var category = await _repository.GetByIdIncludingDeletedAsync(
            id,
            cancellationToken);

        if (category == null)
            return Result<CategoryDto>.NotFoundResult(id);

        if (!CategorySyncGuard.CanAccess(category, _currentUser))
            return CategorySyncGuard.Forbidden();

        var clientModified = DateTimeService.NormalizeUtc(
            request.Dto.ClientModifiedDate);

        if (clientModified <= category.GetConflictModifiedUtc())
        {
            return Result<CategoryDto>.SuccessResult(
                _mapper.Map<CategoryDto>(category));
        }

        category.SetClientModificationMetadata(
            clientModified,
            request.Dto.ClientModifiedBy);

        await _repository.RemoveAsync(category);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<CategoryDto>.SuccessResult(
            _mapper.Map<CategoryDto>(category));
    }
}

internal static class CategorySyncGuard
{
    public static bool TryCanonicalGuid(
        string value,
        out string canonical)
    {
        if (Guid.TryParse(value, out var parsed))
        {
            canonical = parsed.ToString("D");
            return true;
        }

        canonical = string.Empty;
        return false;
    }

    public static bool UserMetadataMatches(
        string? clientUserId,
        ICurrentUser currentUser)
    {
        return string.IsNullOrWhiteSpace(clientUserId) ||
               string.Equals(
                   clientUserId.Trim(),
                   currentUser.GetId(),
                   StringComparison.Ordinal);
    }

    public static bool CanAccess(
        Category category,
        ICurrentUser currentUser)
    {
        return currentUser.IsSuperAdmin() ||
               category.ShopId == currentUser.GetShopId();
    }

    public static void Apply(
        Category category,
        CategoryCreateDto dto)
    {
        category.SetName(dto.Name);
        category.SetCode(dto.Code);
        category.SetDescription(dto.Description);

        if (dto.IsActive)
            category.Activate();
        else
            category.Deactivate();
    }

    public static void Apply(
        Category category,
        CategoryUpdateDto dto)
    {
        category.SetName(dto.Name);
        category.SetCode(dto.Code);
        category.SetDescription(dto.Description);

        if (dto.IsActive)
            category.Activate();
        else
            category.Deactivate();
    }

    public static Result<CategoryDto> InvalidId() =>
        Result<CategoryDto>.FailureResult(
            "InvalidClientId",
            "Category sync IDs must be valid GUIDs.");

    public static Result<CategoryDto> InvalidUser() =>
        Result<CategoryDto>.FailureResult(
            "InvalidClientUser",
            "Client user metadata must match the authenticated user.");

    public static Result<CategoryDto> Forbidden() =>
        Result<CategoryDto>.FailureResult(
            "Forbidden",
            "You can only synchronize categories from your own shop.");
}