using Microsoft.EntityFrameworkCore;
using SMIS.Application.DTO.Categories;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;
using SMIS.UI.Data;
using SMIS.UI.Models;
using SMIS.UI.Services.Base;
using SMIS.UI.Services.Http;

namespace SMIS.UI.Services;

public class CategoryService : BaseService
{
    private readonly IApiClient _apiClient;
    private readonly LocalDbContext _localDb;
    private readonly IConnectivity _connectivity;

    public CategoryService(IApiClient apiClient, LocalDbContext localDb, IConnectivity connectivity)
    {
        _apiClient = apiClient;
        _localDb = localDb;
        _connectivity = connectivity;
    }

    public async Task<ApiResponse<PagedList<CategoryDto>>> GetAllAsync(int pageNumber = 0, int pageSize = 0)
    {
        pageNumber = pageNumber > 0 ? pageNumber : PagedList<CategoryDto>.DefaultPageNumber;
        pageSize = pageSize > 0 ? pageSize : PagedList<CategoryDto>.DefaultPageSize;

        if (_connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            var result = await _apiClient.GetAsync<PagedList<CategoryDto>>($"/api/category?pageNumber={pageNumber}&pageSize={pageSize}");
            
            if (result.Success && result.Response?.Items != null)
            {
                await SyncToLocalAsync(result.Response.Items);
            }
            
            return result;
        }
        else
        {
            return await GetAllOfflineAsync(pageNumber, pageSize);
        }
    }

    public async Task<ApiResponse<CategoryDto>> GetByIdAsync(string id)
    {
        if (_connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            return await _apiClient.GetAsync<CategoryDto>($"/api/category/{id}");
        }
        else
        {
            var category = await _localDb.Categories.FindAsync(id);
            return category != null
                ? new ApiResponse<CategoryDto> { Success = true, Response = MapToDto(category) }
                : CreateError<CategoryDto>("NotFound", "Category not found");
        }
    }

    public async Task<ApiResponse<CategoryDto>> CreateAsync(CategoryCreateDto dto)
    {
        if (_connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            var result = await _apiClient.PostAsync<CategoryCreateDto, CategoryDto>("/api/category", dto);
            
            if (result.Success && result.Response != null)
            {
                await SyncToLocalAsync(new List<CategoryDto> { result.Response });
            }
            
            return result;
        }
        else
        {
            return await CreateOfflineAsync(dto);
        }
    }

    public async Task<ApiResponse<CategoryDto>> UpdateAsync(string id, CategoryUpdateDto dto)
    {
        if (_connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            var result = await _apiClient.PutAsync<CategoryUpdateDto, CategoryDto>($"/api/category/{id}", dto);
            
            if (result.Success && result.Response != null)
            {
                await SyncToLocalAsync(new List<CategoryDto> { result.Response });
            }
            
            return result;
        }
        else
        {
            return await UpdateOfflineAsync(id, dto);
        }
    }

    private async Task<ApiResponse<PagedList<CategoryDto>>> GetAllOfflineAsync(int pageNumber, int pageSize)
    {
        var totalCount = await _localDb.Categories.CountAsync();
        var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
        
        var categories = await _localDb.Categories
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        
        var dtos = categories.Select(MapToDto).ToList();
        
        return new ApiResponse<PagedList<CategoryDto>>
        {
            Success = true,
            Response = new PagedList<CategoryDto>
            {
                Items = dtos,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = totalPages
            },
            Message = "Loaded from offline storage"
        };
    }

    private async Task<ApiResponse<CategoryDto>> CreateOfflineAsync(CategoryCreateDto dto)
    {
        var category = Category.Create(dto.Name, dto.ShopId, dto.Code, dto.Description, dto.IsActive);
        category.IsSyncedToServer = false;
        
        _localDb.Categories.Add(category);
        await _localDb.SaveChangesAsync();
        
        return new ApiResponse<CategoryDto>
        {
            Success = true,
            Response = MapToDto(category),
            Message = "Created offline - will sync when online"
        };
    }

    private async Task<ApiResponse<CategoryDto>> UpdateOfflineAsync(string id, CategoryUpdateDto dto)
    {
        var category = await _localDb.Categories.FindAsync(id);
        
        if (category == null)
            return CreateError<CategoryDto>("NotFound", "Category not found");
        
        category.SetName(dto.Name);
        category.SetCode(dto.Code);
        category.SetDescription(dto.Description);
        if (dto.IsActive) category.Activate(); else category.Deactivate();
        category.IsSyncedToServer = false;
        
        await _localDb.SaveChangesAsync();
        
        return new ApiResponse<CategoryDto>
        {
            Success = true,
            Response = MapToDto(category),
            Message = "Updated offline - will sync when online"
        };
    }

    private async Task SyncToLocalAsync(List<CategoryDto> dtos)
    {
        foreach (var dto in dtos)
        {
            var existing = await _localDb.Categories.FindAsync(dto.Id);
            
            if (existing != null)
            {
                // Conflict resolution: Compare timestamps - only update if server is newer
                if (dto.LastModifiedUtc > existing.LastModifiedUtc)
                {
                    existing.SetName(dto.Name);
                    existing.SetCode(dto.Code);
                    existing.SetDescription(dto.Description);
                    if (dto.IsActive) existing.Activate(); else existing.Deactivate();
                    existing.LastModifiedUtc = dto.LastModifiedUtc;
                }
                
                existing.IsSyncedToServer = true;
                existing.LastSyncedAt = DateTimeService.Now;
            }
            else
            {
                var category = Category.Create(dto.Name, dto.ShopId, dto.Code, dto.Description, dto.IsActive);
                category.Id = dto.Id;
                category.LastModifiedUtc = dto.LastModifiedUtc;
                category.IsSyncedToServer = true;
                category.LastSyncedAt = DateTimeService.Now;
                
                _localDb.Categories.Add(category);
            }
        }
        
        await _localDb.SaveChangesAsync();
    }

    private static CategoryDto MapToDto(Category category)
    {
        return new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            Code = category.Code,
            Description = category.Description,
            IsActive = category.IsActive,
            ShopId = category.ShopId,
            LastModifiedUtc = category.LastModifiedUtc
        };
    }
}
