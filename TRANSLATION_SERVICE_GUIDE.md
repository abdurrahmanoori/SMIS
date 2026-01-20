# Translation Service Usage Guide

## Overview
The `ITranslationService` provides a simple, reusable way to manage translations for any entity in the system using the TranslationKey and Translation tables.

## Service Interface

```csharp
public interface ITranslationService
{
    Task<TranslationKey> CreateTranslationKeyAsync(string keyValue, CancellationToken cancellationToken = default);
    Task<Translation> AddTranslationAsync(string keyValue, int languageNo, string translatedValue, CancellationToken cancellationToken = default);
    Task<string> GetTranslationAsync(string keyValue, int languageNo, CancellationToken cancellationToken = default);
}
```

## Usage Examples

### 1. Create a Translation Key
When creating an entity, automatically create its translation key:

```csharp
// In CreateShopCommand
var translationKey = await _translationService.CreateTranslationKeyAsync(
    request.ShopCreateDto.Name, 
    cancellationToken
);
```

### 2. Add Translations for Different Languages
Add translated values for multiple languages:

```csharp
// Add French translation
await _translationService.AddTranslationAsync(
    keyValue: "Main Store",
    languageNo: 2, // French
    translatedValue: "Magasin Principal",
    cancellationToken
);

// Add Arabic translation
await _translationService.AddTranslationAsync(
    keyValue: "Main Store",
    languageNo: 3, // Arabic
    translatedValue: "المتجر الرئيسي",
    cancellationToken
);
```

### 3. Retrieve Translated Value
Get the translation for a specific language:

```csharp
var translatedName = await _translationService.GetTranslationAsync(
    keyValue: "Main Store",
    languageNo: 2, // French
    cancellationToken
);
// Returns: "Magasin Principal" or "Main Store" if translation doesn't exist
```

## Creating a Translation Management Command

Here's an example command to add translations for Shop:

```csharp
// AddShopTranslationCommand.cs
public record AddShopTranslationCommand(
    string ShopPublicId, 
    int LanguageNo, 
    string TranslatedName
) : IRequest<Result<Unit>>;

internal sealed class AddShopTranslationCommandHandler 
    : IRequestHandler<AddShopTranslationCommand, Result<Unit>>
{
    private readonly IShopRepository _shopRepository;
    private readonly ITranslationService _translationService;

    public AddShopTranslationCommandHandler(
        IShopRepository shopRepository,
        ITranslationService translationService)
    {
        _shopRepository = shopRepository;
        _translationService = translationService;
    }

    public async Task<Result<Unit>> Handle(
        AddShopTranslationCommand request, 
        CancellationToken cancellationToken)
    {
        var shop = await _shopRepository.GetByIdAsync(request.ShopPublicId);
        if (shop == null)
        {
            return Result<Unit>.NotFoundResult("Shop");
        }

        await _translationService.AddTranslationAsync(
            shop.Name,
            request.LanguageNo,
            request.TranslatedName,
            cancellationToken
        );

        return Result<Unit>.SuccessResult(Unit.Value);
    }
}
```

## API Endpoint Example

```csharp
// In ShopController.cs
[HttpPost("{publicId}/translations")]
public async Task<ActionResult<Unit>> AddTranslation(
    string publicId, 
    [FromBody] AddTranslationDto dto)
{
    return HandleResultResponse(
        await _mediator.Send(
            new AddShopTranslationCommand(publicId, dto.LanguageNo, dto.TranslatedName)
        )
    );
}
```

## DTO Example

```csharp
public class AddTranslationDto
{
    public int LanguageNo { get; set; }
    public string TranslatedName { get; set; } = string.Empty;
}
```

## Complete Workflow

### Step 1: Create Entity
```http
POST /api/shop
{
  "name": "Main Store",
  "shopType": 0,
  ...
}
```
This automatically creates a TranslationKey with Name="Main Store"

### Step 2: Add Translations
```http
POST /api/shop/{publicId}/translations
{
  "languageNo": 2,
  "translatedName": "Magasin Principal"
}
```

### Step 3: Retrieve with Translation
```http
GET /api/shop/{publicId}
Accept-Language: fr
```
Returns Shop with name="Magasin Principal"

## Language Numbers Reference

Assuming your Language table has:
- 1 = English (en)
- 2 = French (fr)
- 3 = Arabic (ar)
- etc.

## Key Benefits

1. **Generic**: Works with any entity that has a Name property
2. **Reusable**: Same service for all entities
3. **Simple**: Three methods cover all translation needs
4. **Safe**: Handles duplicates and missing translations gracefully
5. **Flexible**: No foreign key constraints between entities and translations

## Extending to Other Entities

To use translations for a new entity (e.g., Product):

1. In CreateProductCommand:
```csharp
await _translationService.CreateTranslationKeyAsync(
    request.ProductCreateDto.Name, 
    cancellationToken
);
```

2. In GetProductQuery:
```csharp
var translatedName = await _translationService.GetTranslationAsync(
    product.Name,
    userLangId,
    cancellationToken
);
```

That's it! No additional tables or configurations needed.
