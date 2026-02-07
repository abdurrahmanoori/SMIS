# LoanAccount CRUD Implementation Summary

## Overview
Complete CRUD infrastructure for LoanAccount entity following Product implementation pattern with Domain-Driven Design principles.

## Domain Layer

### LoanAccount Entity (Already Exists)
**Location**: `SMIS.Domain\Entities\LoanAccount.cs`

**Key Features**:
- Private setters with domain validation methods
- Factory method: `LoanAccount.Create()`
- Domain validation via `DomainValidationException`
- Computed properties: `PaidAmount`, `RemainingAmount`
- Business methods: `AddPayment()`, `MarkAsOverdue()`, `Activate()`, `Deactivate()`

**Properties**:
- `CustomerId` (required, string)
- `ShopId` (required, string)
- `ProductId` (required, string)
- `Quantity` (required, decimal, > 0)
- `UnitId` (required, string)
- `TotalAmount` (required, long, > 0)
- `LoanDate` (required, DateTime)
- `DueDate` (nullable, DateTime?, must be after LoanDate)
- `Status` (string, default "Active")
- `Notes` (nullable, string?, max 500 chars)
- `IsActive` (bool, default true)

**Navigation Properties**:
- `Customer` (many-to-one)
- `Shop` (many-to-one)
- `Product` (many-to-one)
- `UnitOfMeasure` (many-to-one)
- `Payments` (one-to-many with LoanAccountPayment)

### LoanAccountPayment Entity (Already Exists)
**Location**: `SMIS.Domain\Entities\LoanAccountPayment.cs`

## Application Layer

### DTOs
**Location**: `SMIS.Application\DTO\LoanAccounts\`

1. **LoanAccountDto.cs**
   - Complete entity representation
   - Includes computed properties (PaidAmount, RemainingAmount)
   - Optional navigation properties (Customer, Product)

2. **LoanAccountCreateDto.cs**
   - Input model for create/update operations
   - Excludes computed and system-managed fields

3. **ProductLoanInfoDto.cs** (NEW)
   - Specialized DTO for loan workflow
   - Returns product with base unit and latest price

### Commands
**Location**: `SMIS.Application\Features\LoanAccounts\Commands\`

1. **LoanAccountCreateCommand.cs**
   - Uses domain factory method `LoanAccount.Create()`
   - AutoMapper integration
   - Returns `Result<LoanAccountDto>`

2. **LoanAccountUpdateCommand.cs**
   - Uses domain setter methods
   - Validates entity existence
   - Returns `Result<LoanAccountDto>`

3. **LoanAccountDeleteCommand.cs**
   - Soft delete via repository
   - Returns `Result<Unit>`

### Queries
**Location**: `SMIS.Application\Features\LoanAccounts\Queries\`

1. **LoanAccountGetByIdQuery.cs**
   - Optional includes: Customer, Product
   - Returns `Result<LoanAccountDto>`

2. **LoanAccountGetListQuery.cs**
   - Pagination support
   - Optional includes: Customer, Product
   - Returns `Result<PagedList<LoanAccountDto>>`

3. **ProductGetLoanInfoQuery.cs** (NEW)
   - Fetches product with base unit
   - Calculates latest active price for base unit
   - Filters by: IsActive, EndDate, BaseUnitId
   - Orders by EffectiveDate descending
   - Returns `Result<ProductLoanInfoDto>`

### Validators
**Location**: `SMIS.Application\Features\LoanAccounts\Validators\`

1. **LoanAccountCreateCommandValidator.cs**
   - CustomerId: required
   - ShopId: required
   - ProductId: required
   - Quantity: > 0
   - UnitId: required
   - TotalAmount: > 0
   - DueDate: must be future date (when provided)
   - Notes: max 500 characters (when provided)

2. **LoanAccountUpdateCommandValidator.cs**
   - Id: required
   - Same validations as create

### Repository
**Location**: `SMIS.Application\Repositories\LoanAccounts\`

**ILoanAccountRepository.cs**
- Extends `IGenericRepository<LoanAccount>`
- No custom methods (uses base CRUD)

## Infrastructure Layer

### Repository Implementation
**Location**: `SMIS.Infrastructure\Repositories\LoanAccounts\`

**LoanAccountRepository.cs**
- Extends `GenericRepository<LoanAccount>`
- Auto-registered via Scrutor

### Entity Configuration
**Location**: `SMIS.Infrastructure\EntityConfigurations\`

1. **LoanAccountConfiguration.cs**
   - Table name: "LoanAccount"
   - Primary key: Id
   - Required fields with appropriate constraints
   - Decimal precision: 18,2 for Quantity
   - String max lengths: Status (50), Notes (500)
   - Foreign keys with Restrict delete behavior
   - Cascade delete for Payments collection
   - Ignores computed properties: PaidAmount, RemainingAmount

2. **LoanAccountPaymentConfiguration.cs**
   - Table name: "LoanAccountPayment"
   - Cascade delete with LoanAccount

### Database Seeding
**Location**: `SMIS.Infrastructure\DatabaseSeeders\`

**LoanAccountSeed.cs**
- Seeds 3 sample loan accounts
- Uses reflection to set Id and LoanDate (private setters)
- Registered in `AppDbContext.OnModelCreating()`

### DbContext Updates
**Location**: `SMIS.Infrastructure\Context\AppDbContext.cs`

Added:
- `DbSet<LoanAccount> LoanAccounts`
- `DbSet<LoanAccountPayment> LoanAccountPayments`
- `LoanAccountSeed.DataSeed(modelBuilder)` in OnModelCreating

## API Layer

### Controller
**Location**: `SMIS.Api\Controllers\LoanAccountController.cs`

**Endpoints**:
1. `POST /api/LoanAccount` - Create loan account
2. `GET /api/LoanAccount` - Get paginated list (with optional includes)
3. `GET /api/LoanAccount/{id}` - Get by ID (with optional includes)
4. `PUT /api/LoanAccount/{id}` - Update loan account
5. `DELETE /api/LoanAccount/{id}` - Delete loan account

### Product Controller Enhancement
**Location**: `SMIS.Api\Controllers\ProductController.cs`

**New Endpoint**:
- `GET /api/Product/{id}/loan-info` - Get product info for loan workflow

## AutoMapper Configuration
**Location**: `SMIS.Application\Mappings\MappingProfile.cs`

```csharp
CreateMap<LoanAccount, LoanAccountDto>()
    .ForMember(dest => dest.PaidAmount, opt => opt.MapFrom(src => src.PaidAmount))
    .ForMember(dest => dest.RemainingAmount, opt => opt.MapFrom(src => src.RemainingAmount));

CreateMap<LoanAccountCreateDto, LoanAccount>()
    .ConstructUsing(src => LoanAccount.Create(
        src.CustomerId,
        src.ShopId,
        src.ProductId,
        src.Quantity,
        src.UnitId,
        src.TotalAmount,
        src.DueDate,
        src.Notes
    ));
```

## Domain-Driven Design Patterns Applied

### 1. Encapsulation
- All properties have private setters
- Public domain methods enforce business rules
- Factory method for object creation

### 2. Domain Validation
- Validation in domain methods (SetCustomerId, SetQuantity, etc.)
- Throws `DomainValidationException` for rule violations
- Examples:
  - Quantity must be > 0
  - TotalAmount must be > 0
  - DueDate must be after LoanDate
  - Notes max 500 characters

### 3. Value Objects
- Not used in LoanAccount (all primitives)
- Could be enhanced with Money value object for TotalAmount

### 4. Computed Properties
- `PaidAmount`: Sum of all payments
- `RemainingAmount`: TotalAmount - PaidAmount
- Calculated at runtime, not stored in database

### 5. Business Logic in Domain
- `AddPayment()`: Validates payment amount, updates status
- `MarkAsOverdue()`: Checks due date and updates status
- Status transitions managed by domain

### 6. Aggregate Root
- LoanAccount is aggregate root
- Manages LoanAccountPayment collection
- Cascade delete ensures consistency

## Frontend Workflow Support

### Product Selection Flow
1. User selects product from dropdown
2. Frontend calls: `GET /api/Product/{productId}/loan-info`
3. Response includes:
   - ProductId, ProductName
   - BaseUnitId, BaseUnitName
   - LatestSellPrice (for base unit)
   - LatestBuyPrice (for base unit)
   - PriceEffectiveDate
   - HasActivePrice (boolean)

4. Frontend auto-populates:
   - UnitId = BaseUnitId
   - Suggested TotalAmount = Quantity × LatestSellPrice

### Price Calculation Logic
```csharp
// Filters active prices for base unit
var baseUnitPrice = product.ProductPrices
    .Where(p => p.IsActive && 
               p.ProductUnit.UnitOfMeasureId == product.BaseUnitId &&
               (p.EndDate == null || p.EndDate >= DateTime.UtcNow))
    .OrderByDescending(p => p.EffectiveDate)
    .FirstOrDefault();
```

## Database Migration
Run: `dotnet ef migrations add AddLoanAccountAndPayment --project SMIS.Infrastructure --startup-project SMIS.Api`

## Testing Recommendations

### Unit Tests
- Domain validation methods
- Computed properties (PaidAmount, RemainingAmount)
- Business methods (AddPayment, MarkAsOverdue)

### Integration Tests
- CRUD operations via API
- Product loan info endpoint
- Pagination and filtering
- Navigation property includes

### Test Data
- Valid loan account creation
- Invalid quantity (≤ 0)
- Invalid total amount (≤ 0)
- Invalid due date (before loan date)
- Notes exceeding 500 characters

## Key Differences from Product Implementation

### Similarities
- Domain factory method pattern
- Private setters with validation
- FluentValidation for DTOs
- Repository pattern
- CQRS with MediatR
- AutoMapper configuration
- Database seeding

### Differences
1. **No Value Objects**: LoanAccount uses primitives (could be enhanced)
2. **Computed Properties**: PaidAmount/RemainingAmount calculated from Payments
3. **Status Management**: Business logic for status transitions
4. **Specialized Query**: ProductGetLoanInfoQuery for workflow support
5. **No Translation**: LoanAccount doesn't use TranslatableAttribute

## Next Steps

1. Run migration to create tables
2. Test all CRUD endpoints
3. Test product loan info endpoint
4. Implement LoanAccountPayment CRUD (if needed)
5. Add business rules for payment validation
6. Consider Money value object for amounts
7. Add unit tests for domain logic
8. Add integration tests for API endpoints
