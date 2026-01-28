# SMIS - Shop Management Information System

A comprehensive shop management system built with .NET 9, featuring a RESTful API backend and a cross-platform .NET MAUI Blazor Hybrid mobile application.

## 🏗️ Architecture

This solution follows Clean Architecture principles with clear separation of concerns:

```
SMIS/
├── SMIS.Api/              # Web API layer (ASP.NET Core)
├── SMIS.Application/      # Application business logic & DTOs
├── SMIS.Domain/           # Core domain entities & business rules
├── SMIS.Domain.Shared/    # Shared domain models
├── SMIS.Infrastructure/   # Data access & external services
├── SMIS.Identity/         # Authentication & authorization
├── SMIS.Test/            # Unit & integration tests
└── SMIS.UI/              # Cross-platform mobile app (.NET MAUI)
```

## 🚀 Tech Stack

### Backend
- **.NET 9** - Latest .NET framework
- **ASP.NET Core Web API** - RESTful API
- **Entity Framework Core 9** - ORM with SQLite support
- **MediatR** - CQRS pattern implementation
- **AutoMapper** - Object-to-object mapping
- **FluentValidation** - Input validation
- **Serilog** - Structured logging with Seq integration
- **MiniProfiler** - Performance profiling
- **JWT Authentication** - Secure API authentication

### Frontend
- **.NET MAUI** - Cross-platform framework (Android, iOS, Windows, macOS)
- **Blazor Hybrid** - Web UI in native apps
- **Syncfusion Blazor Components** - Rich UI component library

### Testing
- **xUnit** - Testing framework
- **Moq** - Mocking library
- **FluentAssertions** - Fluent assertion library
- **Bogus** - Fake data generator
- **AutoFixture** - Test data builder

## 📋 Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (v17.14+) or [Visual Studio Code](https://code.visualstudio.com/)
- [SQLite](https://www.sqlite.org/) (included with EF Core)
- For mobile development: Android SDK, iOS SDK (macOS only)

## 🔧 Getting Started

### 1. Clone the Repository
```bash
git clone <repository-url>
cd SMIS
```

### 2. Restore Dependencies
```bash
dotnet restore
```

### 3. Update Database
```bash
cd SMIS.Api
dotnet ef database update
```

### 4. Run the API
```bash
cd SMIS.Api
dotnet run
```

The API will be available at `https://localhost:7216`

### 5. Run the Mobile App
```bash
cd SMIS.UI
dotnet build -t:Run -f net9.0-android    # For Android
dotnet build -t:Run -f net9.0-ios        # For iOS
dotnet build -t:Run -f net9.0-windows    # For Windows
```

## 🔑 Configuration

### API Configuration
Update `appsettings.json` in SMIS.Api:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=smis.db"
  },
  "JwtSettings": {
    "Key": "<your-secret-key>",
    "Issuer": "SMIS",
    "Audience": "SMIS-Users",
    "DurationInMinutes": 60
  }
}
```

### Environment-Specific Settings
- `appsettings.Development.json` - Development environment
- `appsettings.Staging.json` - Staging environment
- `appsettings.Production.json` - Production environment

## 📚 API Documentation

Once the API is running, access Swagger UI at:
```
https://localhost:7216/swagger
```

## 🧪 Running Tests

```bash
# Run all tests
dotnet test

# Run tests with coverage
dotnet test /p:CollectCoverage=true
```

## 📊 Domain Model (SMIS.Domain.Entities)

### Core Entities

#### Shop
Represents a shop/store in the system.
- **Properties**:
  - `Id` (string) - Unique identifier
  - `Name` (string) - Shop name
  - `ShopType` (enum) - Type of shop
  - `Address` (string) - Physical address
  - `PhoneNumber` (string) - Contact number
  - `Email` (string) - Email address
  - `TaxNumber` (string) - Tax identification number
  - `IsActive` (bool) - Active status
  - `CreatedAt`, `UpdatedAt`, `CreatedBy`, `UpdatedBy` - Audit fields

#### Category
Groups products into logical categories (Drinks, Food, Stationery, Grocery).
- **Properties**:
  - `Id` (string) - Unique identifier
  - `Name` (string) - Category name
  - `Code` (string?) - Category code
  - `Description` (string?) - Category description
  - `IsActive` (bool) - Active status
  - `CreatedAt`, `UpdatedAt`, `CreatedBy`, `UpdatedBy` - Audit fields
- **Relationships**: One-to-Many with Products

#### Product
Represents items available for sale.
- **Properties**:
  - `Id` (string) - Unique identifier
  - `Name` (string) - Product name
  - `ShopId` (string) - Foreign key to Shop
  - `BaseUnitId` (string) - Foreign key to UnitOfMeasure
  - `CategoryId` (string?) - Foreign key to Category
  - `SalePricePerBaseUnit` (int) - Sale price per base unit
  - `SKU` (string) - Stock keeping unit
  - `Barcode` (string?) - Product barcode
  - `Description` (string?) - Product description
  - `ImageUrl` (string?) - Product image URL
  - `IsActive` (bool) - Active status
  - `CreatedAt`, `UpdatedAt`, `CreatedBy`, `UpdatedBy` - Audit fields
- **Relationships**: 
  - Belongs to Shop
  - Belongs to Category
  - Has UnitOfMeasure (base unit)
  - Has many ProductUnits (conversion units)

#### UnitOfMeasure
Defines measurement units (Piece, Bottle, Pack, Liter, Box).
- **Properties**:
  - `Id` (string) - Unique identifier
  - `Name` (string) - Unit name
  - `Symbol` (string) - Unit symbol
  - `Description` (string?) - Unit description
  - `CreatedAt`, `UpdatedAt` - Audit fields
- **Relationships**: One-to-Many with ProductUnits

#### ProductUnit
Defines product-specific unit conversions. Critical for inventory accuracy.
- **Purpose**: Same unit name means different quantities for different products
- **Properties**:
  - `Id` (string) - Unique identifier
  - `ProductId` (string) - Foreign key to Product
  - `UnitOfMeasureId` (string) - Foreign key to UnitOfMeasure
  - `ConversionFactor` (decimal) - How many base units in this unit
  - `CreatedAt`, `UpdatedAt` - Audit fields
- **Example**: 
  - Biscuit: 1 Box = 12 Packs (ConversionFactor = 12)
  - Notebook: 1 Box = 10 Pieces (ConversionFactor = 10)
  - Coca Cola: 1 Carton = 24 Bottles (ConversionFactor = 24)

### Inventory Management

#### StockBatch
Tracks individual stock receipts with expiration dates.
- **Purpose**: Manages same product with different expiry dates (FIFO/FEFO)
- **Properties**:
  - `Id` (int) - Unique identifier
  - `ProductId` (int) - Foreign key to Product
  - `BatchNumber` (string?) - Batch identification number
  - `Quantity` (decimal) - Remaining quantity in base unit
  - `UnitId` (int) - Foreign key to UnitOfMeasure
  - `ReceivedDate` (DateTime) - Date batch was received
  - `ExpirationDate` (DateTime) - Expiration date (null for non-perishables)
  - `PurchasePrice` (long) - Purchase price per unit
  - `Status` (enum) - Batch status (Active, Expired, etc.)
  - `CreatedAt`, `UpdatedAt`, `CreatedBy`, `UpdatedBy` - Audit fields
- **Example**: Two batches of Coca Cola with different expiry dates

#### StockTransaction
Records all inventory movements (audit trail).
- **Purpose**: Complete inventory history - nothing is deleted
- **Properties**:
  - `Id` (int) - Unique identifier
  - `ProductId` (int) - Foreign key to Product
  - `StockBatchId` (int) - Foreign key to StockBatch
  - `Quantity` (decimal) - Transaction quantity
  - `UnitId` (int) - Foreign key to UnitOfMeasure
  - `Type` (enum) - Transaction type (In, Out, Adjustment)
  - `TransactionDate` (DateTime) - Date of transaction
  - `Reference` (string?) - Reference number or note
- **Types**: In (Purchase), Out (Sale), Adjustment (Damage/Loss)

#### StockConsumption
Explicit record of batch consumption during sales.
- **Purpose**: Tracks which specific batch was used (FIFO/FEFO enforcement)
- **Properties**:
  - `Id` (int) - Unique identifier
  - `StockBatchId` (int) - Foreign key to StockBatch
  - `Quantity` (decimal) - Consumed quantity
  - `ConsumedDate` (DateTime?) - Date consumed
  - `ConsumedBy` (string?) - User or system that consumed
  - `CreatedAt`, `UpdatedAt`, `CreatedBy`, `UpdatedBy` - Audit fields

### System

#### AppLog
Application logging for monitoring and debugging.
- **Properties**:
  - `Id` (string) - Unique identifier
  - `Level` (string) - Log level (Info, Warning, Error, etc.)
  - `Message` (string) - Log message
  - `Exception` (string?) - Exception details if any
  - `Properties` (string?) - Additional properties (JSON)
  - `UserId` (string?) - User who triggered the log
  - `CreatedAt` (DateTime) - Timestamp

## 📦 Project Structure

### SMIS.Api
- **Controllers/** - API endpoints
- **Middleware/** - Custom middleware components
- **Extensions/** - Service configuration extensions

### SMIS.Application
- **Features/** - CQRS commands & queries
- **DTO/** - Data transfer objects
- **Mappings/** - AutoMapper profiles
- **Services/** - Application services
- **Repositories/** - Repository interfaces

### SMIS.Domain
- **Entities/** - Domain entities
- **Enums/** - Domain enumerations
- **Common/** - Shared domain logic

### SMIS.Infrastructure
- **Context/** - DbContext configuration
- **Repositories/** - Repository implementations
- **Configurations/** - Entity configurations
- **Migrations/** - EF Core migrations
- **Services/** - Infrastructure services

### SMIS.Identity
- **Services/** - Authentication & authorization services
- **Extensions/** - Identity configuration
- **Seed/** - Default user/role seeding

### SMIS.UI
- **Components/** - Reusable Blazor components
- **Services/** - UI services
- **Resources/** - Images, fonts, assets

## 🔐 Authentication

The API uses JWT Bearer token authentication. To authenticate:

1. Register/Login via the authentication endpoints
2. Include the JWT token in the Authorization header:
   ```
   Authorization: Bearer <your-token>
   ```

## 📊 Monitoring & Profiling

### Serilog Logging
Logs are written to:
- Console (Development)
- Seq server (if configured)
- Database (custom sink)

### MiniProfiler
Access profiling data at:
```
https://localhost:7216/profiler/results-index
```

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📄 Additional Documentation

- [Domain Model](DOMAIN_MODEL_CORRECTED.md)
- [Implementation Checklist](IMPLEMENTATION_CHECKLIST.md)
- [Migration Guide](MIGRATION_GUIDE.md)
- [Translation Service Guide](TRANSLATION_SERVICE_GUIDE.md)
- [Shop API Endpoints](SHOP_API_ENDPOINTS.md)
- [Offline-First Preparation](OFFLINE_FIRST_PREPARATION.md)

## 📝 License

This project is proprietary and confidential.

## 👥 Support

For support and questions, please contact the development team.

---

**Built with ❤️ using .NET 9**
