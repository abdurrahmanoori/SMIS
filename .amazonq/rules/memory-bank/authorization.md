# Authorization & Multi-Tenancy

## Role-Based Access Control (RBAC)

### Role Definitions (SD.cs)

#### System-Wide Roles
- **SuperAdmin** - Full system access across all shops

#### Wholesale Shop Roles (W prefix)
- **WShopAdmin** - Wholesale shop administrator
- **WShopAdministration** - Administrative tasks
- **WShopManager** - Shop operations manager
- **WShopStaff** - Daily operations staff
- **WShopViewer** - Read-only access
- **WShopEditor** - Edit permissions
- **WShopUser** - Basic user access

#### Retail Shop Roles (R prefix)
- **RShopAdmin** - Retail shop administrator
- **RShopAdministration** - Administrative tasks
- **RShopManager** - Shop operations manager
- **RShopStaff** - Daily operations staff
- **RShopViewer** - Read-only access
- **RShopEditor** - Edit permissions
- **RShopUser** - Basic user access

## Multi-Tenancy Strategy

### Global Query Filter (Shop Isolation)

**Location**: `SMIS.Infrastructure/Context/AppDbContext.QueryFilters.cs`

**Implementation**:
```csharp
private void SetShopEntityFilter<TEntity>(ModelBuilder modelBuilder) where TEntity : class, IShopEntity
{
    modelBuilder.Entity<TEntity>().HasQueryFilter(e => 
        _currentUser.IsSuperAdmin() ||             
        e.ShopId == _currentUser.GetShopId());
}
```

**Applied To**: All entities implementing `IShopEntity` interface
- Product
- Category
- StockBatch
- StockTransaction
- Customer
- ShopOwner
- LoanAccount
- ProductUnit
- ProductPrice

**Automatic Application**: Configured in `AppDbContext.OnModelCreating()` via reflection

### Data Access Rules

| Role | Data Scope | Filter Applied |
|------|-----------|----------------|
| **SuperAdmin** | All shops | No filter (bypass) |
| **WShopAdmin / RShopAdmin** | Single shop | ShopId = User.ShopId |
| **Manager** | Single shop | ShopId = User.ShopId |
| **Staff** | Single shop | ShopId = User.ShopId |
| **Viewer** | Single shop | ShopId = User.ShopId |
| **Editor** | Single shop | ShopId = User.ShopId |
| **User** | Single shop | ShopId = User.ShopId |

**Key Point**: All non-SuperAdmin roles see the SAME data (their shop's data). The difference is in PERMISSIONS (what actions they can perform), not data visibility.

## Permission Matrix

### Recommended Authorization Strategy

| Role | Create | Read | Update | Delete | Approve | Manage Users |
|------|--------|------|--------|--------|---------|--------------|
| **SuperAdmin** | ✅ All | ✅ All | ✅ All | ✅ All | ✅ All | ✅ All |
| **Admin** | ✅ Shop | ✅ Shop | ✅ Shop | ✅ Shop | ✅ Shop | ✅ Shop |
| **Manager** | ✅ Shop | ✅ Shop | ✅ Shop | ❌ | ✅ Shop | ❌ |
| **Staff** | ✅ Shop | ✅ Shop | ✅ Shop | ❌ | ❌ | ❌ |
| **Editor** | ❌ | ✅ Shop | ✅ Shop | ❌ | ❌ | ❌ |
| **Viewer** | ❌ | ✅ Shop | ❌ | ❌ | ❌ | ❌ |
| **User** | ✅ Limited | ✅ Shop | ✅ Own | ❌ | ❌ | ❌ |

## Current User Service

**Interface**: `SMIS.Application/Identity/IServices/ICurrentUser.cs`

**Available Methods**:
```csharp
string GetId();              // Current user ID
string GetLangId();          // User's language preference
string GetShopId();          // User's assigned shop ID
bool IsSuperAdmin();         // Check if SuperAdmin
bool IsWholesaleAdmin();     // Check if WShopAdmin
bool IsRetailAdmin();        // Check if RShopAdmin
List<string> Roles();        // Get all user roles
```

**Implementation**: `SMIS.Application/Services/CurrentUser.cs`
- Reads from JWT claims via HttpContext
- Claims stored: NameIdentifier, LanguageId, ShopId, Role(s)

## Query Filtering Behavior

### Automatic Filtering (No Code Required)

**Example**: Product queries automatically filtered by shop

```csharp
// This query is AUTOMATICALLY filtered by ShopId for non-SuperAdmin users
var query = _productRepository.GetAllQueryable();
var products = await query.ToListAsync();

// SuperAdmin: Gets ALL products from ALL shops
// Other roles: Gets ONLY products from their ShopId
```

**No manual filtering needed** - EF Core applies the global filter automatically.

### Bypassing Filters (When Needed)

```csharp
// Use IgnoreQueryFilters() to bypass (typically only for SuperAdmin operations)
var allProducts = await _context.Products
    .IgnoreQueryFilters()
    .ToListAsync();
```

## Authorization Implementation

### Controller-Level Authorization

```csharp
[Authorize(Roles = SD.Role_Super_Admin)]
public class SystemController : BaseController { }

[Authorize(Roles = $"{SD.Role_WShop_Admin},{SD.Role_RShop_Admin}")]
public class ShopAdminController : BaseController { }
```

### Action-Level Authorization

```csharp
[Authorize(Roles = $"{SD.Role_WShop_Manager},{SD.Role_RShop_Manager}")]
[HttpPost("approve")]
public async Task<IActionResult> ApproveOrder([FromBody] ApproveOrderCommand command) { }

[Authorize(Roles = SD.Role_Super_Admin)]
[HttpDelete("{id}")]
public async Task<IActionResult> Delete(string id) { }
```

### Policy-Based Authorization (Recommended)

**Define Policies** in `Program.cs`:
```csharp
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("SuperAdminOnly", policy => 
        policy.RequireRole(SD.Role_Super_Admin));
    
    options.AddPolicy("ShopAdmin", policy => 
        policy.RequireRole(SD.Role_WShop_Admin, SD.Role_RShop_Admin));
    
    options.AddPolicy("CanApprove", policy => 
        policy.RequireRole(SD.Role_Super_Admin, SD.Role_WShop_Manager, SD.Role_RShop_Manager));
    
    options.AddPolicy("CanDelete", policy => 
        policy.RequireRole(SD.Role_Super_Admin, SD.Role_WShop_Admin, SD.Role_RShop_Admin));
});
```

**Use Policies**:
```csharp
[Authorize(Policy = "CanApprove")]
[HttpPost("approve")]
public async Task<IActionResult> ApproveOrder() { }

[Authorize(Policy = "CanDelete")]
[HttpDelete("{id}")]
public async Task<IActionResult> Delete(string id) { }
```

## Best Practices

### 1. Data Filtering
- ✅ Rely on global query filters for shop isolation
- ✅ No manual ShopId filtering needed in queries
- ✅ Use `IShopEntity` interface for all shop-scoped entities
- ❌ Don't manually filter by ShopId in application code

### 2. Authorization
- ✅ Use policy-based authorization for complex rules
- ✅ Apply authorization at controller/action level
- ✅ Check permissions in handlers for business logic
- ❌ Don't mix data filtering with authorization logic

### 3. Role Assignment
- ✅ Assign ShopId when creating non-SuperAdmin users
- ✅ Store ShopId in JWT claims for performance
- ✅ Validate ShopId exists before assignment
- ❌ Don't allow users to change their own ShopId

### 4. Testing
- ✅ Test with different roles to verify filters
- ✅ Test SuperAdmin can access all data
- ✅ Test shop users are isolated
- ✅ Test authorization policies work correctly

## Security Considerations

### Shop Isolation
- Global filters prevent accidental cross-shop data access
- Even if application code has bugs, database enforces isolation
- SuperAdmin bypass is intentional for system management

### JWT Claims
- ShopId stored in JWT token (no database lookup per request)
- Token refresh required if user's shop changes
- Validate ShopId on sensitive operations

### Authorization Bypass
- Never use `IgnoreQueryFilters()` without SuperAdmin check
- Log all filter bypass operations for audit
- Review SuperAdmin actions regularly

## Common Patterns

### Check User Role in Handler
```csharp
public async Task<Result<ProductDto>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
{
    // Automatically uses user's ShopId from global filter
    var product = Product.Create(request.Name, _currentUser.GetShopId(), ...);
    
    // Additional authorization check if needed
    if (!_currentUser.IsSuperAdmin() && !_currentUser.IsWholesaleAdmin())
    {
        return Result<ProductDto>.FailureResult("Insufficient permissions");
    }
    
    await _productRepository.AddAsync(product);
    return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(product));
}
```

### SuperAdmin Override
```csharp
public async Task<Result<List<ProductDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
{
    var query = _productRepository.GetAllQueryable();
    
    // Global filter automatically applied:
    // - SuperAdmin: sees all products
    // - Others: sees only their shop's products
    
    var products = await query.ToListAsync();
    return Result<List<ProductDto>>.SuccessResult(_mapper.Map<List<ProductDto>>(products));
}
```

## Troubleshooting

### Issue: User sees no data
- ✅ Check user has ShopId assigned
- ✅ Verify ShopId exists in Shops table
- ✅ Confirm entity implements IShopEntity
- ✅ Check global filter is applied in AppDbContext

### Issue: User sees other shop's data
- ❌ Global filter not applied (check IShopEntity implementation)
- ❌ Using IgnoreQueryFilters() incorrectly
- ❌ ShopId claim missing from JWT token

### Issue: SuperAdmin sees limited data
- ❌ IsSuperAdmin() returning false
- ❌ Role claim not in JWT token
- ❌ Role name mismatch (check SD.Role_Super_Admin constant)
