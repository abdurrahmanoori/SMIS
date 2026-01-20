# Shop CRUD Implementation with Generic Translation System

## Overview
This implementation provides a complete CRUD system for the Shop entity with a generic, reusable translation mechanism based on TranslationKey and Translation tables.

## Translation System Architecture

### How It Works

#### 1. **Storage Mechanism**
- **Shop.Name**: Stores the original value (e.g., "Main Store")
- **TranslationKey**: Stores the same value as a key (Name = "Main Store")
- **Translation**: Stores translated values linked to TranslationKey by PublicId and Language

#### 2. **No Direct Foreign Key**
- Shop does NOT have a foreign key to TranslationKey
- The relationship is based on matching Shop.Name with TranslationKey.Name
- This keeps the system generic and reusable for any entity

#### 3. **Create Flow**
```
User creates Shop with Name="Main Store"
  ↓
CreateShopCommand:
  1. Create TranslationKey with Name="Main Store"
  2. Create Shop with Name="Main Store"
  3. Save both to database
  ↓
Translation records can be added separately to TranslationKey
```

#### 4. **Retrieve Flow**
```
User requests Shop list
  ↓
GetShopListQuery:
  1. Query all Shops
  2. For each Shop, find TranslationKey where Name matches Shop.Name
  3. Get Translation for user's language from that TranslationKey
  4. Return translated Name or fallback to original Shop.Name
```

## Implementation Files

### Domain Layer
- `SMIS.Domain/Entities/Shop/Shop.cs` - Shop entity (uses BaseAuditableEntity which includes Name)

### Application Layer

#### DTOs
- `DTO/Shops/ShopDto.cs` - Read model
- `DTO/Shops/ShopCreateDto.cs` - Create/Update model

#### Repositories
- `Repositories/Shops/IShopRepository.cs` - Repository interface

#### Commands
- `Features/Shops/Commands/CreateShopCommand.cs` - Creates Shop + TranslationKey
- `Features/Shops/Commands/UpdateShopCommand.cs` - Updates Shop
- `Features/Shops/Commands/DeleteShopCommand.cs` - Deletes Shop

#### Queries
- `Features/Shops/Queries/GetShopListQuery.cs` - Retrieves translated Shop list
- `Features/Shops/Queries/GetShopByIdQuery.cs` - Retrieves single translated Shop

#### Mappings
- `Mappings/MappingProfile.cs` - AutoMapper configuration

### Infrastructure Layer
- `Repositories/Shops/ShopRepository.cs` - Repository implementation
- `EntityConfigurations/ShopConfiguration.cs` - EF Core configuration
- `Context/AppDbContext.cs` - Added Shops DbSet

### API Layer
- `Controllers/ShopController.cs` - REST API endpoints

## Key Features

### 1. Generic Translation System
- No entity-specific translation tables
- Reusable for any entity in the future
- Based on value matching, not foreign keys

### 2. Language-Aware Retrieval
- Uses `ICurrentUser.GetLangId()` to get user's language preference
- Automatically returns translated values
- Falls back to original value if translation not found

### 3. CQRS Pattern
- Commands for write operations (Create, Update, Delete)
- Queries for read operations (GetList, GetById)
- Follows MediatR pattern used throughout the project

### 4. Clean Architecture
- Domain entities are pure POCOs
- Application layer contains business logic
- Infrastructure handles data access
- API layer provides HTTP endpoints

## Usage Example

### Create a Shop
```http
POST /api/shop
Content-Type: application/json

{
  "name": "Main Store",
  "shopType": 0,
  "address": "123 Main St",
  "phoneNumber": "+1234567890",
  "email": "main@store.com",
  "taxNumber": "TAX123",
  "isActive": true
}
```

### Add Translation (separate operation)
After creating the Shop, translations can be added to the TranslationKey:
```
1. Find TranslationKey where Name = "Main Store"
2. Add Translation records with different LanguageNo values
```

### Retrieve Shop (with translation)
```http
GET /api/shop/{publicId}
Accept-Language: fr
```
Returns Shop with Name translated to French if available, otherwise returns "Main Store"

## Extending to Other Entities

To use this translation system for other entities:

1. Ensure entity inherits from `BaseAuditableEntity` (includes Name property)
2. In Create command: Create TranslationKey with entity's Name
3. In Query: Join TranslationKey by matching Name values
4. Retrieve Translation based on user's language

No code changes needed to the translation tables themselves!
