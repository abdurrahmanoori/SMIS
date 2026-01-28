# Technology Stack

## Core Technologies

### Framework & Runtime
- **.NET 9.0** - Latest .NET framework with performance improvements and C# 13 features
- **C# 13** - Primary programming language with nullable reference types enabled
- **ASP.NET Core 9.0** - Web API framework for RESTful services

### Database & ORM
- **Entity Framework Core 9.0** - Object-relational mapper
- **SQLite** - Embedded database for development and production
- **Microsoft.Data.Sqlite 9.0.0** - SQLite data provider
- **EF Core Proxies** - Lazy loading support

## Backend Libraries

### API & Web
- **Swashbuckle.AspNetCore 6.6.2** - OpenAPI/Swagger documentation
- **Microsoft.AspNetCore.Authentication.JwtBearer 9.0.0** - JWT authentication
- **Microsoft.AspNetCore.Mvc.Testing 9.0.0** - Integration testing support

### Application Architecture
- **MediatR 11.1.0** - CQRS and mediator pattern implementation
- **MediatR.Extensions.Microsoft.DependencyInjection 11.1.0** - DI integration
- **AutoMapper 13.0.1** - Object-to-object mapping
- **AutoMapper.Collection.EntityFrameworkCore 10.0.0** - EF Core collection mapping
- **FluentValidation 11.11.0** - Fluent validation library
- **FluentValidation.AspNetCore 11.3.0** - ASP.NET Core integration
- **FluentValidation.DependencyInjectionExtensions 11.11.0** - DI integration

### Logging & Monitoring
- **Serilog 4.3.0** - Structured logging framework
- **Serilog.Extensions.Hosting 9.0.0** - .NET hosting integration
- **Serilog.Sinks.Console 6.0.0** - Console output
- **Serilog.Sinks.Seq 9.0.0** - Seq server integration
- **Serilog.Sinks.PeriodicBatching 5.0.0** - Batched logging
- **Seq.Extensions.Logging 6.0.0** - Seq extensions
- **MiniProfiler.AspNetCore 4.3.8** - Performance profiling
- **MiniProfiler.EntityFrameworkCore 4.3.8** - EF Core profiling
- **MiniProfiler.AspNetCore.Mvc 4.3.8** - MVC integration

### Identity & Security
- **Microsoft.AspNetCore.Identity 2.2.0** - Identity framework
- **Microsoft.AspNetCore.Identity.EntityFrameworkCore 9.0.0** - EF Core identity stores
- **Microsoft.Extensions.Identity.Core 9.0.0** - Identity core services

### Utilities
- **Newtonsoft.Json 13.0.3** - JSON serialization
- **Scrutor 4.2.2** - Assembly scanning and decoration

## Frontend Technologies

### Mobile Framework
- **.NET MAUI 9.0.10** - Cross-platform mobile framework
- **Microsoft.Maui.Controls 9.0.10** - UI controls
- **Microsoft.AspNetCore.Components.WebView.Maui 9.0.10** - Blazor Hybrid support

### UI Components
- **Syncfusion Blazor 27.1.48** - Rich UI component library
  - Themes, Buttons, Cards, Charts
  - DataForm, DropDowns, Grid
  - Inputs, Layouts, Lists
  - Navigations, Notifications, Popups
  - Schedule, Spinner

## Testing Stack

### Testing Frameworks
- **xUnit 2.9.2** - Unit testing framework
- **xunit.runner.visualstudio 2.8.2** - Visual Studio test runner
- **Microsoft.NET.Test.Sdk 17.12.0** - .NET test SDK

### Testing Libraries
- **Moq 4.20.72** - Mocking framework
- **FluentAssertions 6.12.1** - Fluent assertion library
- **Shouldly 4.2.1** - Assertion library
- **AutoFixture 4.18.1** - Test data builder
- **Bogus 35.6.1** - Fake data generator
- **coverlet.collector 6.0.2** - Code coverage collector

## Development Tools

### Build System
- **MSBuild** - .NET build system
- **Central Package Management** - Centralized version management via Directory.Packages.props
- **Visual Studio 2022** - Primary IDE (v17.14+)

### Database Tools
- **EF Core CLI** - Database migrations and scaffolding
  - `dotnet ef migrations add`
  - `dotnet ef database update`
- **Microsoft.EntityFrameworkCore.Tools 9.0.0** - Package Manager Console tools
- **Microsoft.EntityFrameworkCore.Design 9.0.0** - Design-time support

### API Documentation
- **Swagger UI** - Interactive API documentation at `/swagger`
- **OpenAPI 3.0** - API specification format

### Performance Profiling
- **MiniProfiler UI** - Performance metrics at `/profiler/results-index`

## Configuration Management

### Configuration Files
- `appsettings.json` - Base configuration
- `appsettings.Development.json` - Development overrides
- `appsettings.Staging.json` - Staging overrides
- `appsettings.Production.json` - Production overrides

### Configuration Providers
- **Microsoft.Extensions.Configuration 9.0.0** - Configuration abstraction
- **Microsoft.Extensions.Configuration.Abstractions 9.0.0** - Configuration interfaces
- **Microsoft.Extensions.Configuration.Binder 9.0.0** - Configuration binding
- **Microsoft.Extensions.Options 9.0.0** - Options pattern

## Dependency Injection

### DI Container
- **Microsoft.Extensions.DependencyInjection 9.0.0** - Built-in DI container
- Service lifetimes: Singleton, Scoped, Transient
- Extension methods for service registration in each layer

## Development Commands

### Build & Run
```bash
# Restore dependencies
dotnet restore

# Build solution
dotnet build

# Run API
cd SMIS.Api
dotnet run

# Run with watch (hot reload)
dotnet watch run
```

### Database Management
```bash
# Add migration
cd SMIS.Api
dotnet ef migrations add MigrationName

# Update database
dotnet ef database update

# Remove last migration
dotnet ef migrations remove

# Generate SQL script
dotnet ef migrations script
```

### Testing
```bash
# Run all tests
dotnet test

# Run with coverage
dotnet test /p:CollectCoverage=true

# Run specific test project
dotnet test SMIS.Test/SMIS.Test.csproj

# Run with detailed output
dotnet test --logger "console;verbosity=detailed"
```

### Mobile Development
```bash
# Build for Android
cd SMIS.UI
dotnet build -t:Run -f net9.0-android

# Build for iOS (macOS only)
dotnet build -t:Run -f net9.0-ios

# Build for Windows
dotnet build -t:Run -f net9.0-windows

# Build for macOS
dotnet build -t:Run -f net9.0-maccatalyst
```

### Code Quality
```bash
# Format code
dotnet format

# Analyze code
dotnet build /p:TreatWarningsAsErrors=true
```

## Platform Support

### API (SMIS.Api)
- Windows, Linux, macOS
- Docker containers (planned)

### Mobile App (SMIS.UI)
- Android 5.0+ (API 21+)
- iOS 11.0+
- Windows 10 1809+
- macOS 10.15+

## Environment Requirements

### Development
- .NET 9 SDK
- Visual Studio 2022 (17.14+) or VS Code
- SQLite (included with EF Core)
- Android SDK (for mobile development)
- Xcode (for iOS development on macOS)

### Production
- .NET 9 Runtime
- SQLite database
- HTTPS certificate
- Seq server (optional, for centralized logging)

## API Endpoints
- Base URL: `https://localhost:7216`
- Swagger UI: `https://localhost:7216/swagger`
- MiniProfiler: `https://localhost:7216/profiler/results-index`

## Database
- Provider: SQLite
- Location: `SMIS.Infrastructure/Databases/smis.db`
- Connection String: `Data Source=smis.db`

## Authentication
- Type: JWT Bearer Token
- Header: `Authorization: Bearer <token>`
- Token Duration: Configurable (default 60 minutes)
