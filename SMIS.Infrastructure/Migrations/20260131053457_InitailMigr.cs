using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppLogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    Exception = table.Column<string>(type: "TEXT", nullable: true),
                    Properties = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ShopType = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    TaxNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockBatch",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BatchNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", precision: 18, scale: 4, nullable: false),
                    UnitId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PurchasePrice = table.Column<long>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockBatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TranslationKeys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    MessageCode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslationKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasure",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProvinceTranslations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProvinceId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LanguageCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    LanguageId = table.Column<string>(type: "TEXT", nullable: false),
                    IsDefault = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvinceTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProvinceTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProvinceTranslations_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationKeyId = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_TranslationKeys_TranslationKeyId",
                        column: x => x.TranslationKeyId,
                        principalTable: "TranslationKeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationKeyId = table.Column<string>(type: "TEXT", nullable: false),
                    LanguageNo = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translations_Languages_LanguageNo",
                        column: x => x.LanguageNo,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Translations_TranslationKeys_TranslationKeyId",
                        column: x => x.TranslationKeyId,
                        principalTable: "TranslationKeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    BaseUnitId = table.Column<string>(type: "TEXT", nullable: false),
                    BaseUnitName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    SalePricePerBaseUnit = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    SKU = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Barcode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    CategoryId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Product_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_UnitOfMeasure_BaseUnitId",
                        column: x => x.BaseUnitId,
                        principalTable: "UnitOfMeasure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnit",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    UnitOfMeasureId = table.Column<string>(type: "TEXT", nullable: false),
                    ConversionFactor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductUnit_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductUnit_UnitOfMeasure_UnitOfMeasureId",
                        column: x => x.UnitOfMeasureId,
                        principalTable: "UnitOfMeasure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "70ba9a48-3193-4ab4-bc59-e7d68968a796", "admin@local", true, "System", "Admin", false, null, "ADMIN@LOCAL", "ADMIN", "AQAAAAIAAYagAAAAEMAx8pwooWaldmpfgVvuX61e3TOsAE7Pg/fEF1KGPhKzNZ9gSXLNQcKYe1WxQBwWMw==", null, false, "admin-seed", false, "admin" },
                    { "2", 0, "c5c25039-835a-4dd6-a7eb-afef8104adaa", "user@local", true, "Default", "User", false, null, "USER@LOCAL", "USER", "AQAAAAIAAYagAAAAEDLIiRYx3e4Jgq6NZFj/Xp4NPywksaS8TOQkZ9B0F3llBZiub6bVuI/EBLGFygVX0w==", null, false, "user-seed", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(7760), "Drinks and beverages", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(7771), new TimeSpan(0, 0, 0, 0, 0)), "Beverages", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(7762), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8104), "Edible products and snacks", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8109), new TimeSpan(0, 0, 0, 0, 0)), "Food Items", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8105), 0 },
                    { "3", "STAT", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8111), "Office and school supplies", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8114), new TimeSpan(0, 0, 0, 0, 0)), "Stationery", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8111), 0 },
                    { "4", "GROC", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8115), "Daily household items", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8118), new TimeSpan(0, 0, 0, 0, 0)), "Grocery", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8115), 0 },
                    { "5", "CARE", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8119), "Health and hygiene products", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 0, 0, 0, 0)), "Personal Care", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8120), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8123), "Electronic devices and accessories", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(8127), new TimeSpan(0, 0, 0, 0, 0)), "Electronics", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(8124), 0 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "EntityState", "IsActive", "LastModifiedUtc", "Name", "Version" },
                values: new object[,]
                {
                    { "1", "en", "Added", true, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 335, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 0, 0, 0, 0)), "English", 0 },
                    { "2", "ps", "Added", true, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 335, DateTimeKind.Unspecified).AddTicks(7512), new TimeSpan(0, 0, 0, 0, 0)), "Pashto", 0 },
                    { "3", "fa", "Added", true, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 335, DateTimeKind.Unspecified).AddTicks(7516), new TimeSpan(0, 0, 0, 0, 0)), "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6214), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6236), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6218), 0 },
                    { "2", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6238), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6242), new TimeSpan(0, 0, 0, 0, 0)), "Herat", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6238), 0 },
                    { "3", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6243), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6243), 0 },
                    { "4", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6250), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6253), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(6250), 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 1, 31, 10, 4, 57, 337, DateTimeKind.Local).AddTicks(2309), "main@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(2317), new TimeSpan(0, 0, 0, 0, 0)), "Main Pharmacy", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 1, 31, 10, 4, 57, 337, DateTimeKind.Local).AddTicks(2311), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 1, 31, 10, 4, 57, 344, DateTimeKind.Local).AddTicks(8834), "city@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 344, DateTimeKind.Unspecified).AddTicks(8888), new TimeSpan(0, 0, 0, 0, 0)), "City Pharmacy", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 1, 31, 10, 4, 57, 344, DateTimeKind.Local).AddTicks(8844), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 1, 31, 10, 4, 57, 344, DateTimeKind.Local).AddTicks(9598), "health@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 344, DateTimeKind.Unspecified).AddTicks(9606), new TimeSpan(0, 0, 0, 0, 0)), "Health Store", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 1, 31, 10, 4, 57, 344, DateTimeKind.Local).AddTicks(9598), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 1, 31, 10, 4, 57, 334, DateTimeKind.Local).AddTicks(2853), "Unchanged", new DateTime(2026, 7, 31, 5, 34, 57, 334, DateTimeKind.Utc).AddTicks(876), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", 40000L, 100m, new DateTime(2026, 1, 21, 5, 34, 57, 334, DateTimeKind.Utc).AddTicks(835), "Active", "1", null, new DateTime(2026, 1, 31, 10, 4, 57, 334, DateTimeKind.Local).AddTicks(9070), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(3969), "Unchanged", new DateTime(2026, 8, 31, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(3943), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", 42000L, 80m, new DateTime(2026, 1, 26, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(3942), "Active", "1", null, new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(3971), 0 },
                    { "3", "BS-101", null, new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(4976), "Unchanged", new DateTime(2026, 4, 30, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(4966), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", 25000L, 50m, new DateTime(2026, 1, 16, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(4965), "Active", "2", null, new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(4977), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(5461), "Unchanged", null, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", 120000L, 200m, new DateTime(2026, 1, 11, 5, 34, 57, 335, DateTimeKind.Utc).AddTicks(5455), "Active", "3", null, new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(5461), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(9796), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(113), new TimeSpan(0, 0, 0, 0, 0)), "1001", "Kabul Center District", null, new DateTime(2026, 1, 31, 10, 4, 57, 335, DateTimeKind.Local).AddTicks(9799), 0 },
                    { "2", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(568), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(590), new TimeSpan(0, 0, 0, 0, 0)), "1002", "Kabul North District", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(568), 0 },
                    { "3", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(591), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(595), new TimeSpan(0, 0, 0, 0, 0)), "1003", "Herat Center District", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(592), 0 },
                    { "4", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(596), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(599), new TimeSpan(0, 0, 0, 0, 0)), "2001", "Kabul Province", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(597), 0 },
                    { "5", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(600), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(603), new TimeSpan(0, 0, 0, 0, 0)), "2002", "Herat Province", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(601), 0 },
                    { "6", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(604), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 0, 0, 0, 0)), "3001", "Welcome Message", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(605), 0 },
                    { "7", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(608), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 0, 0, 0, 0)), "3002", "Error Message", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(609), 0 },
                    { "8", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(616), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0)), "3003", "Success Message", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(616), 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 0, 0, 0, 0)), "Piece", "pcs", 0 },
                    { "10", "12 pieces", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(496), new TimeSpan(0, 0, 0, 0, 0)), "Dozen", "dz", 0 },
                    { "2", "Liquid containers", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(465), new TimeSpan(0, 0, 0, 0, 0)), "Bottle", "btl", 0 },
                    { "3", "Small packages", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 0, 0, 0, 0)), "Pack", "pk", 0 },
                    { "4", "Medium containers", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(473), new TimeSpan(0, 0, 0, 0, 0)), "Box", "box", 0 },
                    { "5", "Large containers", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, 0, 0, 0, 0)), "Carton", "ctn", 0 },
                    { "6", "Volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 0, 0, 0, 0)), "Liter", "L", 0 },
                    { "7", "Weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(483), new TimeSpan(0, 0, 0, 0, 0)), "Kilogram", "kg", 0 },
                    { "8", "Small weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(489), new TimeSpan(0, 0, 0, 0, 0)), "Gram", "g", 0 },
                    { "9", "Small volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 337, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 0, 0, 0, 0)), "Milliliter", "ml", 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8124), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center", "1", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8125), 0 },
                    { "2", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8230), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North", "2", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8230), 0 },
                    { "3", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8235), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(8240), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center", "3", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(8235), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "Description", "EntityState", "ImageUrl", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 1, 31, 10, 4, 57, 345, DateTimeKind.Local).AddTicks(5025), "Classic cola drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 345, DateTimeKind.Unspecified).AddTicks(5051), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "COKE-500ML-001", 150, "1", "Main Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 345, DateTimeKind.Local).AddTicks(5030), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4952), "Sunflower cooking oil", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4956), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "OIL-1L-010", 450, "1", "Main Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4952), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4965), "Basmati rice", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4969), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "RICE-1KG-011", 280, "2", "Branch Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4965), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4977), "White granulated sugar", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4982), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "SUGAR-1KG-012", 200, "3", "Warehouse", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4978), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4989), "Hair care shampoo", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4994), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "SHAMP-400ML-013", 350, "1", "Main Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4990), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5003), "Dental care paste", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(5006), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "TOOTH-PASTE-014", 180, "2", "Branch Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5003), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5013), "Type-C charging cable", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(5017), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "USB-CABLE-015", 250, "1", "Main Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5013), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5026), "Fast charging adapter", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(5032), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "CHARGER-016", 800, "3", "Warehouse", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(5026), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(1563), "Cola soft drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "PEPSI-500ML-002", 140, "1", "Main Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(1571), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(3375), "Pure drinking water", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(3395), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "WATER-1L-003", 80, "2", "Branch Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(3379), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4831), "Chocolate sandwich cookies", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "OREO-PACK-004", 250, "1", "Main Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4834), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4886), "Potato chips", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "LAYS-PACK-005", 180, "2", "Branch Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4886), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4898), "Quick meal noodles", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4902), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "NOODLE-PACK-006", 120, "3", "Warehouse", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4899), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4909), "200 pages ruled notebook", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4912), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "NOTE-A4-007", 300, "1", "Main Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4909), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4920), "Ballpoint pen", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4934), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "PEN-BLUE-008", 50, "2", "Branch Store", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4920), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4941), "12 pencils per box", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 347, DateTimeKind.Unspecified).AddTicks(4945), new TimeSpan(0, 0, 0, 0, 0)), "Pencil Set", "PENCIL-BOX-009", 400, "3", "Warehouse", null, new DateTime(2026, 1, 31, 10, 4, 57, 347, DateTimeKind.Local).AddTicks(4941), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(6715), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7168), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7172), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7176), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7126), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 0, 0, 0, 0)), "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7137), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7151), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 0, 0, 0, 0)), "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 0, 0, 0, 0)), "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LanguageNo", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2604), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center District", "1", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2605), 0 },
                    { "10", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2816), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2820), new TimeSpan(0, 0, 0, 0, 0)), "ولایت هرات", "5", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2817), 0 },
                    { "11", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2820), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2823), new TimeSpan(0, 0, 0, 0, 0)), "Welcome Message", "6", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2821), 0 },
                    { "12", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2824), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 0, 0, 0, 0)), "پیام خوش آمدید", "6", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2825), 0 },
                    { "2", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2780), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز کابل", "1", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2781), 0 },
                    { "3", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2786), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2789), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North District", "2", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2786), 0 },
                    { "4", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2790), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2793), new TimeSpan(0, 0, 0, 0, 0)), "منطقه شمال کابل", "2", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2791), 0 },
                    { "5", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2794), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center District", "3", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2794), 0 },
                    { "6", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2798), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز هرات", "3", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2798), 0 },
                    { "7", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2802), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Province", "4", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2802), 0 },
                    { "8", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2808), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2812), new TimeSpan(0, 0, 0, 0, 0)), "ولایت کابل", "4", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2809), 0 },
                    { "9", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2812), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 336, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 0, 0, 0, 0)), "Herat Province", "5", null, new DateTime(2026, 1, 31, 10, 4, 57, 336, DateTimeKind.Local).AddTicks(2813), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 12m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8296), new TimeSpan(0, 0, 0, 0, 0)), "1", "4", 0 },
                    { "10", 60m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8785), new TimeSpan(0, 0, 0, 0, 0)), "5", "5", 0 },
                    { "11", 24m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0)), "6", "4", 0 },
                    { "12", 72m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 0, 0, 0, 0)), "6", "5", 0 },
                    { "13", 12m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)), "7", "10", 0 },
                    { "14", 50m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8799), new TimeSpan(0, 0, 0, 0, 0)), "7", "4", 0 },
                    { "15", 12m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 0, 0, 0, 0)), "8", "10", 0 },
                    { "16", 144m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 0, 0, 0, 0)), "8", "4", 0 },
                    { "17", 20m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 0, 0, 0, 0)), "9", "5", 0 },
                    { "18", 12m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 0, 0, 0, 0)), "10", "4", 0 },
                    { "19", 24m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 0, 0, 0, 0)), "10", "5", 0 },
                    { "2", 24m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 0, 0, 0, 0)), "1", "5", 0 },
                    { "20", 10m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 0, 0, 0, 0)), "11", "4", 0 },
                    { "21", 25m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8824), new TimeSpan(0, 0, 0, 0, 0)), "11", "5", 0 },
                    { "22", 20m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)), "12", "4", 0 },
                    { "23", 50m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 0, 0, 0, 0)), "12", "5", 0 },
                    { "24", 12m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8834), new TimeSpan(0, 0, 0, 0, 0)), "13", "4", 0 },
                    { "25", 24m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 0, 0, 0, 0)), "13", "5", 0 },
                    { "26", 24m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 0, 0, 0, 0)), "14", "4", 0 },
                    { "27", 72m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, 0, 0, 0, 0)), "14", "5", 0 },
                    { "28", 50m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 0, 0, 0, 0)), "15", "4", 0 },
                    { "29", 200m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 0, 0, 0, 0)), "15", "5", 0 },
                    { "3", 12m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8753), new TimeSpan(0, 0, 0, 0, 0)), "2", "4", 0 },
                    { "30", 20m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8874), new TimeSpan(0, 0, 0, 0, 0)), "16", "4", 0 },
                    { "31", 100m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8877), new TimeSpan(0, 0, 0, 0, 0)), "16", "5", 0 },
                    { "4", 24m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 0, 0, 0, 0)), "2", "5", 0 },
                    { "5", 6m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8768), new TimeSpan(0, 0, 0, 0, 0)), "3", "4", 0 },
                    { "6", 12m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8772), new TimeSpan(0, 0, 0, 0, 0)), "3", "5", 0 },
                    { "7", 12m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8775), new TimeSpan(0, 0, 0, 0, 0)), "4", "4", 0 },
                    { "8", 48m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 0, 0, 0, 0)), "4", "5", 0 },
                    { "9", 20m, "Added", new DateTimeOffset(new DateTime(2026, 1, 31, 5, 34, 57, 333, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, 0, 0, 0, 0)), "5", "4", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppLogs_CreatedAt",
                table: "AppLogs",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AppLogs_Level",
                table: "AppLogs",
                column: "Level");

            migrationBuilder.CreateIndex(
                name: "IX_AppLogs_UserId",
                table: "AppLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_TranslationKeyId",
                table: "Districts",
                column: "TranslationKeyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                table: "Languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_BaseUnitId",
                table: "Product",
                column: "BaseUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShopId",
                table: "Product",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_ProductId",
                table: "ProductUnit",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_UnitOfMeasureId",
                table: "ProductUnit",
                column: "UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvinceTranslations_LanguageId",
                table: "ProvinceTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvinceTranslations_ProvinceId_LanguageId",
                table: "ProvinceTranslations",
                columns: new[] { "ProvinceId", "LanguageId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_BatchNumber",
                table: "StockBatch",
                column: "BatchNumber");

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_ExpirationDate",
                table: "StockBatch",
                column: "ExpirationDate");

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_ProductId",
                table: "StockBatch",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockBatch_Status",
                table: "StockBatch",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_TranslationKeys_MessageCode",
                table: "TranslationKeys",
                column: "MessageCode");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageNo",
                table: "Translations",
                column: "LanguageNo");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_TranslationKeyId_LanguageNo",
                table: "Translations",
                columns: new[] { "TranslationKeyId", "LanguageNo" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppLogs");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "ProductUnit");

            migrationBuilder.DropTable(
                name: "ProvinceTranslations");

            migrationBuilder.DropTable(
                name: "StockBatch");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "TranslationKeys");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "UnitOfMeasure");
        }
    }
}
