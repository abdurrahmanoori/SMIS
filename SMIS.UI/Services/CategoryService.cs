using Microsoft.EntityFrameworkCore;
using SMIS.Application.DTO.Categories;
using SMIS.Domain.Entities;
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

    public async Task<ApiResponse<List<CategoryDto>>> GetAllAsync()
    {
        if (_connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            var result = await _apiClient.GetAsync<List<CategoryDto>>("/api/categories");
            
            if (result.Success && result.Response != null)
            {
                await SyncToLocalAsync(result.Response);
            }
            
            return result;
        }
        else
        {
            return await GetAllOfflineAsync();
        }
    }

    public async Task<ApiResponse<CategoryDto>> GetByIdAsync(string id)
    {
        if (_connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            return await _apiClient.GetAsync<CategoryDto>($"/api/categories/{id}");
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
            var result = await _apiClient.PostAsync<CategoryCreateDto, CategoryDto>("/api/categories", dto);
            
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
            var result = await _apiClient.PutAsync<CategoryUpdateDto, CategoryDto>($"/api/categories/{id}", dto);
            
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

    private async Task<ApiResponse<List<CategoryDto>>> GetAllOfflineAsync()
    {
        var categories = await _localDb.Categories.ToListAsync();
        var dtos = categories.Select(MapToDto).ToList();
        
        return new ApiResponse<List<CategoryDto>>
        {
            Success = true,
            Response = dtos,
            Message = "Loaded from offline storage"
        };
    }

    private async Task<ApiResponse<CategoryDto>> CreateOfflineAsync(CategoryCreateDto dto)
    {
        var category = Category.Create(dto.Name, dto.ShopId, dto.Code, dto.Description, dto.IsActive);
        category.CreatedDate = DateTime.UtcNow;
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
        category.UpdatedDate = DateTime.UtcNow;
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
                existing.SetName(dto.Name);
                existing.SetCode(dto.Code);
                existing.SetDescription(dto.Description);
                if (dto.IsActive) existing.Activate(); else existing.Deactivate();
                existing.IsSyncedToServer = true;
                existing.LastSyncedAt = DateTime.UtcNow;
            }
            else
            {
                var category = Category.Create(dto.Name, dto.ShopId, dto.Code, dto.Description, dto.IsActive);
                category.Id = dto.Id;
                category.CreatedDate = DateTime.UtcNow;
                category.IsSyncedToServer = true;
                category.LastSyncedAt = DateTime.UtcNow;
                
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
            ShopId = category.ShopId
        };
    }

    private static ApiResponse<T> CreateError<T>(string code, string description)
    {
        return new ApiResponse<T>
        {
            Success = false,
            Errors = new List<ValidationError> { new() { Code = code, Description = description } }
        };
    }
}
