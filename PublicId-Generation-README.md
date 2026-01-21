# PublicId Generation Strategy

## Overview
The PublicId generation has been centralized to support different strategies based on the environment:
- **Development**: Sequential numbers (1, 2, 3, ...) queried from database for easy debugging
- **Production**: GUIDs for security and uniqueness

## Implementation

### 1. Service Interface
**Location**: `SMIS.Application/Services/IPublicIdGenerator.cs`
- Defines the contract for PublicId generation

### 2. Service Implementation
**Location**: `SMIS.Infrastructure/Services/PublicIdGenerator.cs`
- Reads the `Environment` setting from configuration
- Returns empty string in Development (handled by interceptor)
- Returns GUID in Production

### 3. Entity Changes
**Location**: `SMIS.Domain/Common/BaseAbstract/EntityPK.cs`
- Removed auto-initialization of PublicId
- Now handled by the interceptor

### 4. Interceptor Update
**Location**: `SMIS.Infrastructure/Interceptors/EntityPKInterceptor.cs`
- Queries database for the last PublicId per entity type
- In Development: Generates sequential numbers (1, 2, 3...) based on max existing PublicId
- In Production: Uses GUID from the generator service
- Same pattern as Id sequence generation in AuditInterceptor

### 5. Service Registration
**Location**: `SMIS.Infrastructure/Extensions/InfrastructureServicesRegistration.cs`
- Registered as Singleton

### 6. Configuration
**appsettings.Development.json**: `"Environment": "Development"` → Sequential numbers from DB
**appsettings.json**: `"Environment": "Production"` → GUIDs

## Usage
No code changes needed in your application. The PublicId is automatically generated when entities are saved:

```csharp
var shop = new Shop { Name = "My Shop" };
await context.Shops.AddAsync(shop);
await context.SaveChangesAsync();
// shop.PublicId will be "1" in Development, "guid-string" in Production
```

## How It Works (Development Mode)
1. Entity is added to context
2. Interceptor queries database for all PublicIds of that entity type
3. Finds the maximum numeric PublicId
4. Assigns next sequential number (max + 1)
5. Same approach as the Id sequence in AuditInterceptor

## Switching Environments
Simply change the `Environment` value in your appsettings file and restart the application.
