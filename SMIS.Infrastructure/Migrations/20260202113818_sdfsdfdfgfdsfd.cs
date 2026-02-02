using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfsdfdfgfdsfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppLogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    Exception = table.Column<string>(type: "TEXT", nullable: true),
                    Properties = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
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
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ShopType = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    TaxNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
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
                name: "TranslationKeys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    MessageCode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ShopId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Category_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasure",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitOfMeasure_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    TranslationKeyId = table.Column<string>(type: "TEXT", nullable: true),
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
                    Name = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    TranslationKeyId = table.Column<string>(type: "TEXT", nullable: false),
                    LanguageNo = table.Column<string>(type: "TEXT", nullable: false),
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
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
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
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    UnitOfMeasureId = table.Column<string>(type: "TEXT", nullable: false),
                    UnitName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
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

            migrationBuilder.CreateTable(
                name: "StockBatch",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    BatchNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", precision: 18, scale: 4, nullable: false),
                    UnitId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UnitName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
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
                    table.ForeignKey(
                        name: "FK_StockBatch_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockBatch_UnitOfMeasure_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitOfMeasure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockTransaction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    StockBatchId = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", precision: 18, scale: 4, nullable: false),
                    UnitId = table.Column<string>(type: "TEXT", nullable: false),
                    UnitName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Reference = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
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
                    table.PrimaryKey("PK_StockTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockTransaction_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_StockBatch_StockBatchId",
                        column: x => x.StockBatchId,
                        principalTable: "StockBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_UnitOfMeasure_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitOfMeasure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EntityState", "LastModifiedUtc", "Name", "NormalizedName", "Version" },
                values: new object[,]
                {
                    { "1", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "SuperAdmin", "SUPERADMIN", 0 },
                    { "10", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopAdministration", "RSHOPADMINISTRATION", 0 },
                    { "11", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopManager", "RSHOPMANAGER", 0 },
                    { "12", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopStaff", "RSHOPSTAFF", 0 },
                    { "13", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopViewer", "RSHOPVIEWER", 0 },
                    { "14", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopEditor", "RSHOPEDITOR", 0 },
                    { "15", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopUser", "RSHOPUSER", 0 },
                    { "2", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopAdmin", "WSHOPADMIN", 0 },
                    { "3", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopAdministration", "WSHOPADMINISTRATION", 0 },
                    { "4", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopManager", "WSHOPMANAGER", 0 },
                    { "5", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopStaff", "WSHOPSTAFF", 0 },
                    { "6", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopViewer", "WSHOPVIEWER", 0 },
                    { "7", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopEditor", "WSHOPEDITOR", 0 },
                    { "8", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "WShopUser", "WSHOPUSER", 0 },
                    { "9", null, "Unchanged", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RShopAdmin", "RSHOPADMIN", 0 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "EntityState", "IsActive", "LastModifiedUtc", "Name", "Version" },
                values: new object[,]
                {
                    { "1", "en", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(6254), new TimeSpan(0, 0, 0, 0, 0)), "English", 0 },
                    { "2", "ps", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 0, 0, 0, 0)), "Pashto", 0 },
                    { "3", "fa", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 0, 0, 0, 0)), "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5072), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5079), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5073), 0 },
                    { "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5191), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5194), new TimeSpan(0, 0, 0, 0, 0)), "Herat", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5191), 0 },
                    { "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5195), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5196), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5195), 0 },
                    { "4", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5197), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5198), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5197), 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 2, 2, 16, 8, 17, 858, DateTimeKind.Local).AddTicks(7097), "main@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(7151), new TimeSpan(0, 0, 0, 0, 0)), "Main Pharmacy", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 2, 2, 16, 8, 17, 858, DateTimeKind.Local).AddTicks(7102), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 2, 2, 16, 8, 17, 859, DateTimeKind.Local).AddTicks(8690), "city@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 859, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 0, 0, 0, 0)), "City Pharmacy", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 2, 2, 16, 8, 17, 859, DateTimeKind.Local).AddTicks(8695), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 2, 2, 16, 8, 17, 859, DateTimeKind.Local).AddTicks(9438), "health@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 859, DateTimeKind.Unspecified).AddTicks(9442), new TimeSpan(0, 0, 0, 0, 0)), "Health Store", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 2, 2, 16, 8, 17, 859, DateTimeKind.Local).AddTicks(9439), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9119), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9492), new TimeSpan(0, 0, 0, 0, 0)), "1001", "Kabul Center District", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9132), 0 },
                    { "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9859), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9862), new TimeSpan(0, 0, 0, 0, 0)), "1002", "Kabul North District", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9859), 0 },
                    { "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9863), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9872), new TimeSpan(0, 0, 0, 0, 0)), "1003", "Herat Center District", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9863), 0 },
                    { "4", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9873), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9874), new TimeSpan(0, 0, 0, 0, 0)), "2001", "Kabul Province", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9873), 0 },
                    { "5", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9875), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 0, 0, 0, 0)), "2002", "Herat Province", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9875), 0 },
                    { "6", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9877), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9878), new TimeSpan(0, 0, 0, 0, 0)), "3001", "Welcome Message", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9878), 0 },
                    { "7", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9879), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9881), new TimeSpan(0, 0, 0, 0, 0)), "3002", "Error Message", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9880), 0 },
                    { "8", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9881), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9961), new TimeSpan(0, 0, 0, 0, 0)), "3003", "Success Message", null, new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9882), 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "ac0224e6-a771-4f4b-b84f-c620dd2c9882", "superadmin@smis.com", true, "Unchanged", "Super", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAENVo5G/ESNasXxv0SL6RQtyfOML9csdi3/uFVMB9NHrKEfyslRLJwWwxh0RkWLNleQ==", "+855123456789", true, "0f225ba1-1e56-4aee-b6cc-c3fff98989df", "1", "Wholesale Shop", false, "superadmin", 0 },
                    { "10", 0, "73792fcc-b355-4cab-928a-a22e8b0d2a2a", "radministration@smis.com", true, "Unchanged", "Retail", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEB8uORgWcVS5NlUUhS6kGrvX0J2EAYr/lUO2m/sOLLCNSfQfOMMs2fzklk6pT/pmEw==", "+855123456798", true, "8025c7b5-9146-4988-b367-9eaf4d3ede28", "2", "Retail Shop", false, "radministration", 0 },
                    { "11", 0, "56dd6d2e-c3b2-4965-b139-0bdf1516c291", "rmanager@smis.com", true, "Unchanged", "Retail", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEIyvi6qCsizSw9hxJ+jvFtN191/ESDfnpqvuEHJ/5ZO/6ZznUub4C9TAAwDnSdj+Tg==", "+855123456799", true, "5d35b4cd-7abc-4e20-a20b-92aa9686b115", "2", "Retail Shop", false, "rmanager", 0 },
                    { "12", 0, "f7465f1b-f50b-46d9-9f0c-0e1109d67169", "rstaff@smis.com", true, "Unchanged", "Retail", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEGeF0Yv4T8y5nv5lL5RbvRdE0t3d3au4kRDJBF78wBGi4aoPJclux534BE5PWrjjKw==", "+855123456800", true, "26defee9-2510-4343-a0ea-6cb0721d7c22", "2", "Retail Shop", false, "rstaff", 0 },
                    { "13", 0, "7db0d89e-337e-4360-9c13-0414d560f05e", "rviewer@smis.com", true, "Unchanged", "Retail", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEA2LvkSphd9vt0iuzQJlt5u0bItlo3qqgmI2iYsIJtn/myBopMpItJw7d2m0OnxoXA==", "+855123456801", true, "c39fd495-27c8-43ae-bcf1-f8cea450b246", "2", "Retail Shop", false, "rviewer", 0 },
                    { "14", 0, "29085be5-b346-4cf0-a728-9756cfa7c50d", "reditor@smis.com", true, "Unchanged", "Retail", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAELh5Ry4Y/Kc89oS8oJlH7HVyQJ38FijEdBPfsHUUbzUpkiFD8zXRUB6GBes0sK/5ag==", "+855123456802", true, "8c74f49d-4acc-4b69-bdd3-14dbb1ae6845", "2", "Retail Shop", false, "reditor", 0 },
                    { "15", 0, "9caf25c1-cb87-4e10-b073-e825469e4668", "ruser@smis.com", true, "Unchanged", "Retail", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEEqawh4HfebVvtcfJbWJGWLkwya2oB4IXywOxlSn286YVEM0+MekLrXY2RLDC9H6dA==", "+855123456803", true, "f0987f5d-6d5e-4f8c-bdac-538018d8cda2", "2", "Retail Shop", false, "ruser", 0 },
                    { "2", 0, "bf5a966f-4663-4bdc-9e81-57b1c5031fba", "wadmin@smis.com", true, "Unchanged", "Wholesale", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEJi3IHi9gfsRV1Xs3zpx62es3oJaXgWz8YBhtcN6t0Z/uyq9wnWyc1a62M3d89kK3A==", "+855123456790", true, "9283cdab-a4af-4979-b6f7-ac78d6b5bcb8", "1", "Wholesale Shop", false, "wadmin", 0 },
                    { "3", 0, "15895cb4-2eec-400e-929d-452419c989f9", "wadministration@smis.com", true, "Unchanged", "Wholesale", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAECKCrxdci7sFGtxnNJCWcJtJkGGcSwPRlROXCGLfRgRm87hSwO1NNQYS6hJJVUQy+g==", "+855123456791", true, "7a644b5a-13b0-4ff6-92de-a454642e9c6d", "1", "Wholesale Shop", false, "wadministration", 0 },
                    { "4", 0, "eb01f2a3-9e76-4533-a640-887ff55f24fd", "wmanager@smis.com", true, "Unchanged", "Wholesale", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEJTDonZk9BGBmYSn6/jg7J5u2t6LE6vKZ+8zSkIGHcDdp2ajEFxyW63jc+V2SvjteQ==", "+855123456792", true, "e52ccd50-0d5e-4b24-99e8-2dbde2703d6f", "1", "Wholesale Shop", false, "wmanager", 0 },
                    { "5", 0, "3cada99f-f1a4-471b-8d14-1442cd64c830", "wstaff@smis.com", true, "Unchanged", "Wholesale", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAEOzy383Kh5hYXTcFA3ZZt3vx6pDM1aWpJQs91bIZ+W3HtSNkzh9APWmyl6hLp9xClQ==", "+855123456793", true, "0b4c5848-18fd-46a4-861d-3aa7304c71c1", "1", "Wholesale Shop", false, "wstaff", 0 },
                    { "6", 0, "06441d82-2b3b-4dfc-9fb1-e888508a7979", "wviewer@smis.com", true, "Unchanged", "Wholesale", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEPpAxCuOAth02DZRRt0qVd7ToRA1ZACVtF4RpckeeD2Sq3DBTxXApbqx0LHTNK1QGA==", "+855123456794", true, "6b4fe4f3-1311-497e-b3a3-f766aa2bdb08", "1", "Wholesale Shop", false, "wviewer", 0 },
                    { "7", 0, "920b4ec7-eb83-40ba-88c9-403cce071501", "weditor@smis.com", true, "Unchanged", "Wholesale", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAELZepdenwJKh/IyRYRUhMlEVtCBKIqHsA6gvmGM2MFTKuQO6IElueJ7M2vs3wDL+vw==", "+855123456795", true, "9fbb6ded-e3e6-4a52-b2c4-07e5fda3373e", "1", "Wholesale Shop", false, "weditor", 0 },
                    { "8", 0, "8e5203d2-3287-48e5-98cb-1896e784f93e", "wuser@smis.com", true, "Unchanged", "Wholesale", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEKD/TjpOCz5nBnZbrYScacq9esJSmyUV1O+aKKFn9hz12zayKsW18xNBwSZJZUnuMg==", "+855123456796", true, "5762b7ad-1d00-4d5f-bb70-1b0006528f62", "1", "Wholesale Shop", false, "wuser", 0 },
                    { "9", 0, "77083826-27db-4cc5-a379-0c4fdc79d0e2", "radmin@smis.com", true, "Unchanged", "Retail", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEBLVdajdOaDoXJdT/i7pvBahgI0JbBnvEHHPi7C7ORPgua5ymwkxhH3iDQBhMS144Q==", "+855123456797", true, "14906db8-9f31-482c-a108-d8ebdfa65cdd", "2", "Retail Shop", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(8625), "Drinks and beverages", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Unspecified).AddTicks(8664), new TimeSpan(0, 4, 30, 0, 0)), "Beverages", "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(8627), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6200), "Edible products and snacks", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6207), new TimeSpan(0, 4, 30, 0, 0)), "Food Items", "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6206), 0 },
                    { "3", "STAT", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6219), "Office and school supplies", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 4, 30, 0, 0)), "Stationery", "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6219), 0 },
                    { "4", "GROC", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6221), "Daily household items", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6222), new TimeSpan(0, 4, 30, 0, 0)), "Grocery", "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6222), 0 },
                    { "5", "CARE", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6223), "Health and hygiene products", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6223), new TimeSpan(0, 4, 30, 0, 0)), "Personal Care", "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6223), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6224), "Electronic devices and accessories", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6224), new TimeSpan(0, 4, 30, 0, 0)), "Electronics", "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6224), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(6991), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6995), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center", "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(6992), 0 },
                    { "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(7425), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(7428), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North", "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(7426), 0 },
                    { "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(7429), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(7430), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center", "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(7429), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6022), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6025), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5973), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6012), new TimeSpan(0, 0, 0, 0, 0)), "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6014), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6016), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6017), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, 0, 0, 0, 0)), "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 0, 0, 0, 0)), "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LanguageNo", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(1916), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(1924), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center District", "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(1917), 0 },
                    { "10", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2206), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2207), new TimeSpan(0, 0, 0, 0, 0)), "ولایت هرات", "5", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2206), 0 },
                    { "11", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2208), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, 0, 0, 0, 0)), "Welcome Message", "6", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2208), 0 },
                    { "12", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2211), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, 0, 0, 0, 0)), "پیام خوش آمدید", "6", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2211), 0 },
                    { "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2172), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2173), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز کابل", "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2172), 0 },
                    { "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2175), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2179), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North District", "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2175), 0 },
                    { "4", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2179), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2181), new TimeSpan(0, 0, 0, 0, 0)), "منطقه شمال کابل", "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2180), 0 },
                    { "5", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2181), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2183), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center District", "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2182), 0 },
                    { "6", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2183), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2185), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز هرات", "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2184), 0 },
                    { "7", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2185), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2201), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Province", "4", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2187), 0 },
                    { "8", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2202), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2203), new TimeSpan(0, 0, 0, 0, 0)), "ولایت کابل", "4", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2202), 0 },
                    { "9", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2204), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2205), new TimeSpan(0, 0, 0, 0, 0)), "Herat Province", "5", null, new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2204), 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 0, 0, 0, 0)), "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4756), new TimeSpan(0, 0, 0, 0, 0)), "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(3185), new TimeSpan(0, 0, 0, 0, 0)), "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4251), new TimeSpan(0, 0, 0, 0, 0)), "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4724), new TimeSpan(0, 0, 0, 0, 0)), "Box", "2", "box", 0 },
                    { "5", "Large containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4733), new TimeSpan(0, 0, 0, 0, 0)), "Carton", "2", "ctn", 0 },
                    { "6", "Volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4736), new TimeSpan(0, 0, 0, 0, 0)), "Liter", "2", "L", 0 },
                    { "7", "Weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4738), new TimeSpan(0, 0, 0, 0, 0)), "Kilogram", "3", "kg", 0 },
                    { "8", "Small weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4744), new TimeSpan(0, 0, 0, 0, 0)), "Gram", "3", "g", 0 },
                    { "9", "Small volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4747), new TimeSpan(0, 0, 0, 0, 0)), "Milliliter", "3", "ml", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "10", "10" },
                    { "11", "11" },
                    { "12", "12" },
                    { "13", "13" },
                    { "14", "14" },
                    { "15", "15" },
                    { "2", "2" },
                    { "3", "3" },
                    { "4", "4" },
                    { "5", "5" },
                    { "6", "6" },
                    { "7", "7" },
                    { "8", "8" },
                    { "9", "9" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "Description", "EntityState", "ImageUrl", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 2, 16, 8, 17, 860, DateTimeKind.Local).AddTicks(4900), "Classic cola drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 860, DateTimeKind.Unspecified).AddTicks(4918), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "COKE-500ML-001", 150, "1", "Main Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 860, DateTimeKind.Local).AddTicks(4904), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5533), "Sunflower cooking oil", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5535), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "OIL-1L-010", 450, "1", "Main Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5534), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5544), "Basmati rice", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "RICE-1KG-011", 280, "2", "Branch Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5544), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5560), "White granulated sugar", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "SUGAR-1KG-012", 200, "3", "Warehouse", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5560), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5566), "Hair care shampoo", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5567), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "SHAMP-400ML-013", 350, "1", "Main Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5566), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5572), "Dental care paste", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5573), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "TOOTH-PASTE-014", 180, "2", "Branch Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5572), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5580), "Type-C charging cable", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5581), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "USB-CABLE-015", 250, "1", "Main Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5580), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5586), "Fast charging adapter", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5588), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "CHARGER-016", 800, "3", "Warehouse", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5587), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(576), "Cola soft drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(609), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "PEPSI-500ML-002", 140, "1", "Main Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(587), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(4103), "Pure drinking water", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(4128), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "WATER-1L-003", 80, "2", "Branch Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(4111), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5327), "Chocolate sandwich cookies", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "OREO-PACK-004", 250, "1", "Main Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5328), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5370), "Potato chips", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "LAYS-PACK-005", 180, "2", "Branch Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5370), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5475), "Quick meal noodles", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5476), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "NOODLE-PACK-006", 120, "3", "Warehouse", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5475), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5485), "200 pages ruled notebook", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "NOTE-A4-007", 300, "1", "Main Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5485), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5509), "Ballpoint pen", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "PEN-BLUE-008", 50, "2", "Branch Store", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5509), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5519), "12 pencils per box", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 0, 0, 0, 0)), "Pencil Set", "PENCIL-BOX-009", 400, "3", "Warehouse", null, new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5519), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(2496), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "10", 60m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "Carton", "5", 0 },
                    { "11", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "Box", "4", 0 },
                    { "12", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "Carton", "5", 0 },
                    { "13", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "14", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "Box", "4", 0 },
                    { "15", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "Dozen", "10", 0 },
                    { "16", 144m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5685), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "Box", "4", 0 },
                    { "17", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, 0, 0, 0, 0)), "9", "Pencil Set", "Carton", "5", 0 },
                    { "18", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "19", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5697), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "2", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5627), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "20", 10m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "Box", "4", 0 },
                    { "21", 25m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5704), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "Carton", "5", 0 },
                    { "22", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "Box", "4", 0 },
                    { "23", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "24", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5714), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "25", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5719), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "26", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "Box", "4", 0 },
                    { "27", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5725), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "Carton", "5", 0 },
                    { "28", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5729), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "Box", "4", 0 },
                    { "29", 200m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "Carton", "5", 0 },
                    { "3", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5634), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "30", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "Box", "4", 0 },
                    { "31", 100m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "Carton", "5", 0 },
                    { "4", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "5", 6m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "6", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5645), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "Carton", "5", 0 },
                    { "7", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5649), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "8", 48m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "9", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "Box", "4", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 2, 2, 16, 8, 17, 270, DateTimeKind.Local).AddTicks(3530), "Unchanged", new DateTime(2026, 8, 2, 11, 38, 17, 270, DateTimeKind.Utc).AddTicks(1068), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 1, 23, 11, 38, 17, 270, DateTimeKind.Utc).AddTicks(1017), "Active", "1", "Bottle", null, new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(411), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(6140), "Unchanged", new DateTime(2026, 9, 2, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(6099), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 1, 28, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(6097), "Active", "1", "Bottle", null, new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(6143), 0 },
                    { "3", "BS-101", null, new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(7775), "Unchanged", new DateTime(2026, 5, 2, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(7762), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 1, 18, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(7761), "Active", "2", "Pack", null, new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(7776), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(8587), "Unchanged", null, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 120000L, 200m, new DateTime(2026, 1, 13, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(8581), "Active", "3", "Piece", null, new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(8588), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(2523), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(2526), 0 },
                    { "10", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9850), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 5m, "Sale #005", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9851), 0 },
                    { "2", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(7684), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 20m, "Sale #001", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(7687), 0 },
                    { "3", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9020), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9023), 0 },
                    { "4", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9765), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 15m, "Sale #002", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9765), 0 },
                    { "5", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9813), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 50m, "Purchase Order #003", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9813), 0 },
                    { "6", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9826), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 10m, "Sale #003", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9826), 0 },
                    { "7", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9832), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 2m, "Damage - Expired", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "2", "Bottle", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9832), 0 },
                    { "8", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9838), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 200m, "Purchase Order #004", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9838), 0 },
                    { "9", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9844), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 25m, "Sale #004", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9845), 0 }
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
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShopId",
                table: "AspNetUsers",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_ShopId",
                table: "Category",
                column: "ShopId");

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
                name: "IX_StockBatch_UnitId",
                table: "StockBatch",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_ProductId",
                table: "StockTransaction",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_StockBatchId",
                table: "StockTransaction",
                column: "StockBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_TransactionDate",
                table: "StockTransaction",
                column: "TransactionDate");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_Type",
                table: "StockTransaction",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_UnitId",
                table: "StockTransaction",
                column: "UnitId");

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

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfMeasure_ShopId",
                table: "UnitOfMeasure",
                column: "ShopId");
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
                name: "StockTransaction");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "StockBatch");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "TranslationKeys");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "UnitOfMeasure");

            migrationBuilder.DropTable(
                name: "Shop");
        }
    }
}
