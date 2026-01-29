# Project Structure

## Solution Architecture
SMIS follows Clean Architecture principles with clear separation of concerns across 7 projects organized in a layered approach.

```
SMIS/
├── SMIS.Api/              # Presentation Layer
├── SMIS.Application/      # Application Layer
├── SMIS.Domain/           # Domain Layer (Core)
├── SMIS.Domain.Shared/    # Shared Domain Models
├── SMIS.Infrastructure/   # Infrastructure Layer
├── SMIS.Identity/         # Identity & Security
├── SMIS.Test/            # Testing Layer
└── SMIS.UI/              # Mobile UI Layer
```

## Layer Responsibilities

### SMIS.Api (Presentation Layer)
**Purpose**: HTTP API endpoints and request/response handling

**Key Components**:
- `Controllers/` - RESTful API endpoints (Category, Product, Shop, Translation, etc.)
- `Controllers/Base/` - Base controller with common functionality
- `Middleware/` - Request pipeline components
  - `ExceptionMiddleware.cs` - Global exception handling
  - `RequestResponseLoggingMiddleware.cs` - HTTP logging
  - `LogEnrichmentMiddleware.cs` - Contextual log enrichment
- `Extentions/` - Service registration and configuration
  - `SwaggerServiceCollectionExtensions.cs` - API documentation
  - `SerilogExtension.cs` - Logging configuration
  - `MiniProfilerExtension.cs` - Performance profiling
  - `CorsServiceExtensions.cs` - CORS policy
- `Converters/` - JSON serialization customization
- `Program.cs` - Application entry point and middleware pipeline

**Dependencies**: SMIS.Application, SMIS.Infrastructure, SMIS.Identity

### SMIS.Application (Application Layer)
**Purpose**: Business logic orchestration and use case implementation

**Key Components**:
- `Features/` - CQRS commands and queries organized by domain
  - `Categories/`, `Products/`, `Shops/`, `Translations/`, etc.
  - Each feature contains Commands, Queries, and Handlers
- `DTO/` - Data Transfer Objects for API contracts
  - Request/Response models for each domain entity
  - Validation rules embedded in DTOs
- `Repositories/` - Repository interfaces (contracts)
  - `Base/IGenericRepository.cs` - Common CRUD operations
  - Domain-specific repository interfaces
- `Services/` - Application service interfaces
  - `ITranslationService.cs` - Translation management
  - `IPublicIdGenerator.cs` - Public ID generation
- `Mappings/MappingProfile.cs` - AutoMapper configuration
- `Common/` - Shared application concerns
  - `Behaviors/` - MediatR pipeline behaviors (validation, logging)
  - `Exceptions/` - Application-specific exceptions
  - `Response/Result.cs` - Standardized response wrapper
  - `PagedList.cs` - Pagination support
- `Attributes/TranslatableAttribute.cs` - Mark translatable properties
- `Extensions/` - Service registration and helper methods

**Dependencies**: SMIS.Domain, SMIS.Domain.Shared

### SMIS.Domain (Domain Layer - Core)
**Purpose**: Core business entities, rules, and domain logic

**Key Components**:
- `Entities/` - Domain entities (aggregate roots)
  - `Product.cs`, `Category.cs`, `Shop.cs` - Core business entities
  - `StockBatch.cs`, `StockTransaction.cs`, `StockConsumption.cs` - Inventory
  - `UnitOfMeasure.cs`, `ProductUnit.cs` - Unit conversion system
  - `AppLog.cs` - Application logging entity
  - `Identity/` - User and role entities
  - `Localization/` - Translation entities (Language, TranslationKey, Translation)
  - `LocationEntities/` - Province, District entities
  - `Shop/` - Shop-related entities
- `Enums/` - Domain enumerations
  - `ShopType.cs`, `TransactionType.cs`, `StatusEnum.cs`, etc.
- `ValueObjects/` - Domain value objects
  - `Email.cs`, `PhoneNumber.cs`, `TaxNumber.cs` - Validated value types
- `Common/` - Shared domain abstractions
  - `BaseAbstract/` - Base entity classes
  - `Interfaces/` - Domain interfaces (IAuditable, ISoftDelete, etc.)
- `Exceptions/DomainValidationException.cs` - Domain-level validation errors

**Dependencies**: None (pure domain logic)

### SMIS.Domain.Shared
**Purpose**: Shared domain models accessible across all layers

**Key Components**:
- `Common/` - Shared abstractions
- `Entities/` - Shared entity definitions
- `Enums/` - Shared enumerations

**Dependencies**: None

### SMIS.Infrastructure (Infrastructure Layer)
**Purpose**: Data access, external services, and infrastructure concerns

**Key Components**:
- `Context/` - Entity Framework DbContext
  - `AppDbContext.cs` - Main database context
  - `AppDbContext.SeedExtensions.cs` - Data seeding extensions
- `Repositories/` - Repository implementations
  - `Base/GenericRepository.cs` - Base repository implementation
  - Domain-specific repositories (Categories, Products, Shops, etc.)
- `EntityConfigurations/` - EF Core entity configurations
  - Fluent API configurations for each entity
  - Relationships, indexes, constraints
- `Migrations/` - EF Core database migrations
  - `AppDbContextModelSnapshot.cs` - Current schema snapshot
- `DatabaseSeeders/` - Initial data seeders
  - `CategorySeed.cs`, `ProductSeed.cs`, `LanguageSeed.cs`, etc.
- `Interceptors/` - EF Core interceptors
  - `AuditInterceptor.cs` - Automatic audit field population
  - `EntityPKInterceptor.cs` - Primary key generation
- `Services/` - Infrastructure service implementations
  - `TranslationService.cs` - Translation logic
  - `PublicIdGenerator.cs` - Public ID generation
- `Logging/DatabaseSink.cs` - Serilog database sink
- `Databases/` - SQLite database files
- `Extensions/` - Service registration

**Dependencies**: SMIS.Domain, SMIS.Application

### SMIS.Identity (Identity & Security Layer)
**Purpose**: Authentication, authorization, and user management

**Key Components**:
- `Services/` - Identity services
  - `UserService.cs` - User management operations
  - `CurrentUser.cs` - Current user context
- `Extensions/IdentityServicesRegistration.cs` - Identity configuration
- `Seed/IdentityDataSeeder.cs` - Default user/role seeding

**Dependencies**: SMIS.Domain, SMIS.Application

### SMIS.Test (Testing Layer)
**Purpose**: Automated testing (unit, integration, and end-to-end tests)

**Key Components**:
- `Controllers/` - Integration tests for API endpoints
  - `CategoryIntegrationTests.cs`, `ProductIntegrationTests.cs`, etc.
- `TestInfrastructure/` - Test setup and utilities
  - `BaseIntegrationTest.cs` - Base test class
  - `CustomWebApplicationFactory.cs` - Test server factory
- `TestDataBuilders/` - Builder pattern for test data
  - `LanguageFixtureBuilder.cs` - Language test data
- `Utilities/` - Test helpers
  - `ProductFixtureBuilder.cs`, `CategoryFixtureBuilder.cs` - AutoFixture builders
  - `ApiEndpoints.cs` - Centralized endpoint definitions
  - `ExceptionFormatter.cs` - Test exception formatting
- `Extensions/` - Test extension methods
  - `HttpClientJsonExtensions.cs` - HTTP client helpers
  - `TestCleanupExtensions.cs` - Test cleanup utilities

**Dependencies**: All projects (for testing)

### SMIS.UI (Mobile UI Layer)
**Purpose**: Cross-platform mobile application using .NET MAUI Blazor Hybrid

**Key Components**:
- `Components/` - Blazor components
  - `Layout/` - Layout components
  - `Pages/` - Page components
  - `_Imports.razor`, `Routes.razor` - Blazor configuration
- `Platforms/` - Platform-specific code
  - `Android/`, `iOS/`, `Windows/`, `MacCatalyst/`, `Tizen/`
- `Resources/` - Application resources
  - `AppIcon/`, `Splash/` - Branding assets
  - `Fonts/`, `Images/` - UI assets
- `Services/Offline/` - Offline synchronization services
- `wwwroot/` - Static web assets
- `App.xaml`, `MainPage.xaml` - MAUI application structure
- `MauiProgram.cs` - MAUI application configuration

**Dependencies**: SMIS.Application (via HTTP API)

## Architectural Patterns

### Clean Architecture
- **Domain Layer**: Core business logic, no external dependencies
- **Application Layer**: Use cases and business workflows
- **Infrastructure Layer**: External concerns (database, file system, etc.)
- **Presentation Layer**: User interfaces (API, Mobile)

### CQRS (Command Query Responsibility Segregation)
- Commands: Modify state (Create, Update, Delete)
- Queries: Read state (Get, List, Search)
- Implemented via MediatR handlers in SMIS.Application/Features/

### Repository Pattern
- Abstraction over data access
- Interfaces in SMIS.Application/Repositories/
- Implementations in SMIS.Infrastructure/Repositories/

### Unit of Work
- Managed by Entity Framework DbContext
- Transaction management in repository layer

### Dependency Injection
- Service registration in Extensions/ folders
- Constructor injection throughout application

### Middleware Pipeline
- Exception handling → Logging → Authentication → Authorization → MVC

## Key Relationships

### Data Flow
1. **Request**: API Controller → MediatR Handler → Repository → DbContext → Database
2. **Response**: Database → DbContext → Repository → Handler → DTO → Controller → JSON

### Dependency Direction
- All dependencies point inward toward Domain layer
- Domain has no external dependencies
- Infrastructure and API depend on Application
- Application depends on Domain

### Cross-Cutting Concerns
- **Logging**: Serilog configured in SMIS.Api, used throughout
- **Validation**: FluentValidation in Application layer
- **Mapping**: AutoMapper profiles in Application layer
- **Authentication**: JWT tokens managed by Identity layer
- **Auditing**: Interceptors in Infrastructure layer
