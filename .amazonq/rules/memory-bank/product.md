# Product Overview

## Purpose
SMIS (Shop Management Information System) is a comprehensive shop management solution designed to streamline retail operations for small to medium-sized businesses. It provides complete inventory tracking, multi-language support, and cross-platform accessibility through a modern .NET 9 architecture.

## Value Proposition
- **Complete Inventory Control**: Track products with batch-level precision, expiration dates, and FIFO/FEFO consumption patterns
- **Multi-Language Support**: Built-in translation system supporting multiple languages with dynamic key-value translation architecture
- **Cross-Platform Access**: RESTful API backend with .NET MAUI Blazor Hybrid mobile app for Android, iOS, Windows, and macOS
- **Clean Architecture**: Maintainable, testable codebase following SOLID principles and separation of concerns
- **Audit Trail**: Complete transaction history with soft deletes and comprehensive logging

## Key Features

### Inventory Management
- Product catalog with categories, SKUs, barcodes, and images
- Multi-unit conversion system (e.g., Box → Pack → Piece with product-specific conversions)
- Stock batch tracking with expiration dates for perishable goods
- FIFO/FEFO consumption tracking through StockConsumption records
- Stock transaction audit trail (In, Out, Adjustment types)
- Real-time inventory levels across multiple units of measure

### Shop Management
- Multi-shop support with shop types (Retail, Wholesale, etc.)
- Shop-specific product catalogs
- Location tracking (Province/District hierarchy)
- Contact information and tax number management

### Localization System
- Dynamic translation key management
- Multi-language support (English, Khmer, etc.)
- Translatable entity attributes via TranslatableAttribute
- Province/District translations for location data
- Centralized translation service with fallback mechanisms

### User Management
- JWT-based authentication
- Role-based authorization
- User audit tracking (CreatedBy, UpdatedBy fields)
- Identity seeding for default users

### Developer Experience
- Swagger/OpenAPI documentation
- MiniProfiler for performance analysis
- Structured logging with Serilog and Seq integration
- Comprehensive test suite with xUnit, Moq, and FluentAssertions
- AutoFixture and Bogus for test data generation

## Target Users

### Primary Users
- **Shop Owners**: Monitor inventory, track sales, manage multiple locations
- **Store Managers**: Daily operations, stock management, product updates
- **Inventory Clerks**: Stock receiving, batch tracking, expiration monitoring
- **Sales Staff**: Product lookup, pricing information, stock availability

### Technical Users
- **System Administrators**: User management, system configuration, monitoring
- **Developers**: API integration, custom reporting, system extensions
- **Support Teams**: Troubleshooting, log analysis, data verification

## Use Cases

### Daily Operations
- Receive new stock batches with expiration dates
- Process sales with automatic FIFO/FEFO batch consumption
- Check product availability across different units (Box, Pack, Piece)
- Update product prices and information
- Monitor low stock levels and expiring items

### Multi-Language Operations
- Switch interface language dynamically
- Add translations for new products and categories
- Manage location names in multiple languages
- Support customers in their preferred language

### Reporting & Analysis
- View stock transaction history
- Track batch consumption patterns
- Monitor product movement by category
- Analyze inventory levels across shops
- Audit user actions and system changes

### Mobile Operations
- Access inventory on-the-go via MAUI mobile app
- Update stock levels from warehouse or shop floor
- Quick product lookup with barcode scanning
- Offline-capable operations (planned feature)

## Technical Highlights
- **.NET 9**: Latest framework with performance improvements
- **Entity Framework Core 9**: Modern ORM with SQLite support
- **MediatR CQRS**: Clean separation of commands and queries
- **AutoMapper**: Efficient DTO mapping
- **FluentValidation**: Declarative input validation
- **Clean Architecture**: Domain-driven design with clear boundaries
