# Shop Entity Domain Validation Implementation

## Overview
This document describes the domain validation approach implemented for the Shop entity following Domain-Driven Design (DDD) best practices.

## Architecture

### 1. Domain Exceptions (`SMIS.Domain/Exceptions/`)
- **DomainValidationException**: Custom exception for domain rule violations
- Provides clear, business-focused error messages
- Separates domain validation errors from infrastructure/application errors

### 2. Value Objects (`SMIS.Domain/ValueObjects/`)
Value objects encapsulate validation logic for complex domain concepts:

#### Email
- Validates email format using regex
- Max length: 100 characters
- Normalizes to lowercase
- Immutable once created

#### PhoneNumber
- Validates phone format (supports international formats)
- Length: 8-20 characters
- Allows digits, spaces, hyphens, parentheses, and plus sign
- Immutable once created

#### TaxNumber
- Validates tax number format
- Length: 5-20 characters
- Allows uppercase letters, numbers, and hyphens
- Normalizes to uppercase
- Immutable once created

### 3. Shop Entity (`SMIS.Domain/Entities/Shop.cs`)

#### Key Design Decisions:

**Private Setters**
- All properties use `private set` to enforce encapsulation
- Prevents direct property modification bypassing validation

**Factory Method**
```csharp
Shop.Create(name, shopType, address, phoneNumber, email, taxNumber)
```
- Single entry point for creating valid Shop instances
- Ensures all validation rules are applied at creation

**Validation Methods**
- `SetName()`: Validates shop name (required, max 200 chars)
- `SetShopType()`: Validates enum value
- `SetAddress()`: Validates address (required, max 500 chars)
- `SetPhoneNumber()`: Uses PhoneNumber value object
- `SetEmail()`: Uses Email value object
- `SetTaxNumber()`: Uses TaxNumber value object

**State Management**
- `Activate()`: Marks shop as active
- `Deactivate()`: Marks shop as inactive

**EF Core Compatibility**
- Private parameterless constructor for EF Core materialization
- Properties remain accessible to EF Core through reflection

## Usage Examples

### Creating a Shop
```csharp
var shop = Shop.Create(
    name: "ABC Retail Store",
    shopType: ShopType.RetailShop,
    address: "123 Main Street, City",
    phoneNumber: "+855-12-345-678",
    email: "contact@abcstore.com",
    taxNumber: "TAX-12345"
);
```

### Updating Shop Properties
```csharp
shop.SetName("New Shop Name");
shop.SetEmail("newemail@shop.com");
shop.Deactivate();
```

### Handling Validation Errors
```csharp
try
{
    var shop = Shop.Create(name: "", ...); // Will throw
}
catch (DomainValidationException ex)
{
    // Handle validation error
    Console.WriteLine(ex.Message); // "Shop name cannot be empty"
}
```

## Benefits

1. **Domain Integrity**: Impossible to create invalid Shop instances
2. **Clear Business Rules**: Validation logic lives in the domain, not scattered across layers
3. **Reusable Value Objects**: Email, PhoneNumber, TaxNumber can be reused in other entities
4. **Testability**: Easy to unit test domain rules in isolation
5. **Maintainability**: Single source of truth for validation rules
6. **Type Safety**: Value objects provide compile-time safety

## Best Practices Applied

✅ **Encapsulation**: Private setters, factory method  
✅ **Immutability**: Value objects are immutable  
✅ **Single Responsibility**: Each class has one reason to change  
✅ **Domain-Driven Design**: Rich domain model with behavior  
✅ **Fail Fast**: Validation at creation time  
✅ **Clear Intent**: Method names express business operations  

## Next Steps

To apply this pattern to other entities:
1. Create value objects for complex properties
2. Add domain-specific exceptions if needed
3. Implement factory methods and validation methods
4. Use private setters to enforce encapsulation
5. Add domain behavior methods (not just getters/setters)
