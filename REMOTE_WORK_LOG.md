# REMOTE WORK LOG

## REMOTE-01 - Require product category across application

- **Task number:** REMOTE-01
- **Task title:** Require product category across application
- **Summary of request:** Make product category mandatory in the backend and Flutter application, enforce the requirement in Azure SQL and the local PowerSync/SQLite flow, and repair any existing products with null category values by assigning a valid category.
- **What was implemented:**
  - Made `CategoryId` required in the Product domain model, API DTOs, sync DTOs, validators, command rules, EF Core configuration, and seed data.
  - Changed the Product-to-Category relationship from nullable/`SetNull` semantics to required/restrict semantics.
  - Updated Flutter product models, drafts, local/remote models, PowerSync repository validation, and product form so a category must be selected.
  - Removed the Flutter "No category" option and added required-category validation.
  - Added local PowerSync startup repair logic that assigns a valid category from the same shop to legacy products with a null category, and fails if no valid category exists for that shop.
  - Added the `RequireProductCategory` EF migration. It repairs legacy null category values, adds `CK_Product_CategoryId_Required`, and recreates the FK with restrictive delete behavior.
  - Azure SQL was inspected and contained 0 null product categories. Because Product is CDC-tracked, the physical column nullability was left unchanged and the requirement is enforced with the enabled `CK_Product_CategoryId_Required` check constraint plus restrictive FK behavior.
- **Important files changed:**
  - `SMIS.Domain/Entities/Product.cs`
  - `SMIS.Application/DTO/Products/ProductCreateDto.cs`
  - `SMIS.Application/DTO/Products/ProductDto.cs`
  - `SMIS.Application/DTO/Products/ProductSyncDtos.cs`
  - Product command/validator files under `SMIS.Application/Features/Products`
  - `SMIS.Infrastructure.Server/EntityConfigurations/ProductConfiguration.cs`
  - `SMIS.Infrastructure.Server/DatabaseSeeders/ProductSeed.cs`
  - `SMIS.Infrastructure.Server/Migrations/20260921143000_RequireProductCategory.cs`
  - `SMIS.Infrastructure.Server/Migrations/20260921143000_RequireProductCategory.Designer.cs`
  - `SMIS.Infrastructure.Server/Migrations/AppDbContextModelSnapshot.cs`
  - Flutter product models/repository/form/database files under `smis_flutter/lib`
- **Backend build result:** Passed earlier during implementation. No additional build was run after the final instruction to commit only.
- **Flutter analysis/build result:** Flutter analysis passed earlier with no issues. Flutter APK build was not completed; it was stopped after the user instructed not to build or generate an APK.
- **Tests:** Not run
- **Manual UI Review Required:** Yes
- **Exact manual verification steps:**
  1. Open the Flutter Products screen and create a new product.
  2. Confirm Category is marked required and there is no "No category" option.
  3. Attempt to save without selecting a category and confirm validation prevents saving.
  4. Select a valid category and confirm the product saves successfully.
  5. Edit an existing product and confirm its category remains required.
  6. Confirm synced products continue to upload/download through PowerSync.
  7. In Azure SQL, confirm `CK_Product_CategoryId_Required` is enabled and the Product-to-Category FK uses `NO ACTION`.
- **Known limitations or unfinished items:**
  - PowerSync managed SQLite table columns cannot be declared `NOT NULL` through the standard schema API, so the invariant is enforced in application/repository logic and legacy-null repair instead.
  - Flutter UI appearance was not visually inspected from the development PC.
- **Git commit hash:** TO_BE_FILLED_AFTER_COMMIT
