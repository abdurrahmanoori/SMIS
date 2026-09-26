using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Categories;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Categories.Commands;

public record CategorySyncCreateCommand(CategorySyncCreateDto Dto) : IRequest<Result<CategoryDto>>;

public record CategorySyncUpdateCommand(string Id, CategorySyncUpdateDto Dto) : IRequest<Result<CategoryDto>>;

public record CategorySyncDeleteCommand(string Id, CategorySyncDeleteDto Dto) : IRequest<Result<CategoryDto>>;

internal sealed class CategorySyncCreateCommandHandler : IRequestHandler<CategorySyncCreateCommand, Result<CategoryDto>>
{
    private readonly ICategoryRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public CategorySyncCreateCommandHandler(
        ICategoryRepository repository,
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _repository = repository;
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<CategoryDto>> Handle(
        CategorySyncCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = CategorySyncRules.NormalizeGuid(request.Dto.Id);
        var clientModified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);

        var existing = await _db.Categories
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(category => category.Id == id, cancellationToken);

        if (existing is not null)
        {
            if (!CategorySyncRules.CanAccess(existing, _currentUser))
                return CategorySyncRules.Forbidden();

            if (clientModified <= existing.GetConflictModifiedUtc())
            {
                return Result<CategoryDto>.SuccessResult(
                    CategoryMapping.ToDto(existing));
            }

            if (await _repository.NameExistsInShopAsync(
                    existing.ShopId,
                    request.Dto.Name,
                    existing.Id,
                    cancellationToken))
            {
                return CategoryCommandRules.DuplicateName();
            }

            CategoryCommandRules.Apply(existing, request.Dto);
            existing.SetClientModificationMetadata(clientModified);
            existing.Restore();

            await _db.SaveChangesAsync(cancellationToken);

            return Result<CategoryDto>.SuccessResult(
                CategoryMapping.ToDto(existing));
        }

        var shopId = _currentUser.GetShopId();
        if (await _repository.NameExistsInShopAsync(
                shopId,
                request.Dto.Name,
                cancellationToken: cancellationToken))
        {
            return CategoryCommandRules.DuplicateName();
        }

        var category = CategoryCommandRules.Create(request.Dto, shopId);

        category.Id = id;
        category.SetClientModificationMetadata(clientModified);

        await _repository.AddAsync(category);
        await _db.SaveChangesAsync(cancellationToken);

        return Result<CategoryDto>.SuccessResult(
            CategoryMapping.ToDto(category));
    }
}

internal sealed class CategorySyncUpdateCommandHandler
    : IRequestHandler<CategorySyncUpdateCommand, Result<CategoryDto>>
{
    private readonly ICategoryRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public CategorySyncUpdateCommandHandler(
        ICategoryRepository repository,
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _repository = repository;
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<CategoryDto>> Handle(
        CategorySyncUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = CategorySyncRules.NormalizeGuid(request.Id);

        var category = await _db.Categories
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);

        if (category is null)
            return Result<CategoryDto>.NotFoundResult(id);

        if (!CategorySyncRules.CanAccess(category, _currentUser))
            return CategorySyncRules.Forbidden();

        var clientModified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);

        if (clientModified < category.GetConflictModifiedUtc())
        {
            return Result<CategoryDto>.SuccessResult(
                CategoryMapping.ToDto(category));
        }

        if (await _repository.NameExistsInShopAsync(
                category.ShopId,
                request.Dto.Name,
                category.Id,
                cancellationToken))
        {
            return CategoryCommandRules.DuplicateName();
        }

        CategoryCommandRules.Apply(category, request.Dto);
        category.SetClientModificationMetadata(clientModified);
        category.Restore();

        await _db.SaveChangesAsync(cancellationToken);

        return Result<CategoryDto>.SuccessResult(
            CategoryMapping.ToDto(category));
    }
}

internal sealed class CategorySyncDeleteCommandHandler
    : IRequestHandler<CategorySyncDeleteCommand, Result<CategoryDto>>
{
    private readonly ICategoryRepository _repository;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;
    private readonly IProductRepository _productRepository;

    public CategorySyncDeleteCommandHandler(
        ICategoryRepository repository,
        IApplicationDbContext db,
        IProductRepository productRepository,
        ICurrentUser currentUser
    )
    {
        _repository = repository;
        _db = db;
        _productRepository = productRepository;
        _currentUser = currentUser;
    }

    public async Task<Result<CategoryDto>> Handle(
        CategorySyncDeleteCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = CategorySyncRules.NormalizeGuid(request.Id);

        var category = await _db.Categories
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);

        if (category is null)
            return Result<CategoryDto>.NotFoundResult(id);

        if (!CategorySyncRules.CanAccess(category, _currentUser))
            return CategorySyncRules.Forbidden();

        var clientModified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);

        if (clientModified < category.GetConflictModifiedUtc())
        {
            return Result<CategoryDto>.SuccessResult(
                CategoryMapping.ToDto(category));
        }

        var productCount = await _productRepository.CountByCategoryIdAsync(
            category.Id,
            cancellationToken);
        if (productCount > 0)
        {
            return Result<CategoryDto>.FailureResult(
                "CategoryInUse",
                $"Category is used by {productCount} product(s). Reassign them before deleting the category.");
        }

        category.SetClientModificationMetadata(clientModified);
        var response = CategoryMapping.ToDto(category);

        await _repository.RemoveAsync(category);
        await _db.SaveChangesAsync(cancellationToken);

        return Result<CategoryDto>.SuccessResult(response);
    }
}

internal static class CategorySyncRules
{
    public static string NormalizeGuid(
        string value
    ) =>
        Guid.Parse(value).ToString("D");

    public static bool CanAccess(
        Category category,
        ICurrentUser currentUser
    )
    {
        return category.ShopId == currentUser.GetShopId();
    }

    public static Result<CategoryDto> Forbidden() =>
        Result<CategoryDto>.FailureResult(
            "Forbidden",
            "You can only synchronize categories from your own shop.");
}
