using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfsdf : Migration
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
                table: "Languages",
                columns: new[] { "Id", "Code", "EntityState", "IsActive", "LastModifiedUtc", "Name", "Version" },
                values: new object[,]
                {
                    { "1", "en", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 531, DateTimeKind.Unspecified).AddTicks(9013), new TimeSpan(0, 0, 0, 0, 0)), "English", 0 },
                    { "2", "ps", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 531, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 0, 0, 0, 0)), "Pashto", 0 },
                    { "3", "fa", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 531, DateTimeKind.Unspecified).AddTicks(9920), new TimeSpan(0, 0, 0, 0, 0)), "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(6896), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 535, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", null, new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(6903), 0 },
                    { "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7536), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 535, DateTimeKind.Unspecified).AddTicks(7563), new TimeSpan(0, 0, 0, 0, 0)), "Herat", null, new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7539), 0 },
                    { "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7567), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 535, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", null, new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7570), 0 },
                    { "4", null, new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7580), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 535, DateTimeKind.Unspecified).AddTicks(7590), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", null, new DateTime(2026, 2, 1, 20, 49, 5, 535, DateTimeKind.Local).AddTicks(7583), 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 2, 1, 20, 49, 5, 538, DateTimeKind.Local).AddTicks(9848), "main@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(9884), new TimeSpan(0, 0, 0, 0, 0)), "Main Pharmacy", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 2, 1, 20, 49, 5, 538, DateTimeKind.Local).AddTicks(9858), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 2, 1, 20, 49, 5, 541, DateTimeKind.Local).AddTicks(642), "city@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 541, DateTimeKind.Unspecified).AddTicks(686), new TimeSpan(0, 0, 0, 0, 0)), "City Pharmacy", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 2, 1, 20, 49, 5, 541, DateTimeKind.Local).AddTicks(650), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 2, 1, 20, 49, 5, 541, DateTimeKind.Local).AddTicks(1676), "health@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 541, DateTimeKind.Unspecified).AddTicks(1760), new TimeSpan(0, 0, 0, 0, 0)), "Health Store", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 2, 1, 20, 49, 5, 541, DateTimeKind.Local).AddTicks(1679), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(4790), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(5476), new TimeSpan(0, 0, 0, 0, 0)), "1001", "Kabul Center District", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(4794), 0 },
                    { "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(8923), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(8955), new TimeSpan(0, 0, 0, 0, 0)), "1002", "Kabul North District", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(8928), 0 },
                    { "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(8960), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9130), new TimeSpan(0, 0, 0, 0, 0)), "1003", "Herat Center District", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(8962), 0 },
                    { "4", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9134), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9143), new TimeSpan(0, 0, 0, 0, 0)), "2001", "Kabul Province", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9137), 0 },
                    { "5", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9145), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9152), new TimeSpan(0, 0, 0, 0, 0)), "2002", "Herat Province", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9147), 0 },
                    { "6", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9155), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, 0, 0, 0, 0)), "3001", "Welcome Message", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9156), 0 },
                    { "7", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9174), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9181), new TimeSpan(0, 0, 0, 0, 0)), "3002", "Error Message", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9176), 0 },
                    { "8", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9184), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 532, DateTimeKind.Unspecified).AddTicks(9190), new TimeSpan(0, 0, 0, 0, 0)), "3003", "Success Message", null, new DateTime(2026, 2, 1, 20, 49, 5, 532, DateTimeKind.Local).AddTicks(9186), 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "1405c30d-dceb-4440-bda3-57f11021fb6c", "admin@smis.com", true, "Unchanged", "System", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administrator", false, null, "ADMIN@SMIS.COM", "ADMIN", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456789", true, "94d41659-8c89-4d56-9b65-e24f31853b3b", "1", "Main Store", false, "admin", 0 },
                    { "2", 0, "2835f88c-cfa2-4351-82a6-fca8b3cd8df5", "manager1@smis.com", true, "Unchanged", "John", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "MANAGER1@SMIS.COM", "MANAGER1", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456790", true, "c6fa9d36-8a35-47be-85d9-b177cf3a32a2", "1", "Main Store", false, "manager1", 0 },
                    { "3", 0, "4a9471cc-395d-4754-81c9-07dc65cadc99", "staff1@smis.com", true, "Unchanged", "Jane", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "STAFF1@SMIS.COM", "STAFF1", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456791", true, "5853bbed-afaf-4f7e-a6bf-cb2738bd3de3", "1", "Main Store", false, "staff1", 0 },
                    { "4", 0, "36c3325c-a147-407e-8c4c-8fba92a3d68e", "manager2@smis.com", true, "Unchanged", "Mike", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "MANAGER2@SMIS.COM", "MANAGER2", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456792", true, "4be10e78-53af-41d5-802c-7a9e1072384d", "2", "Branch Store", false, "manager2", 0 },
                    { "5", 0, "d33e60af-ac4f-4292-88f9-a94bfae29f72", "staff2@smis.com", true, "Unchanged", "Sarah", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "STAFF2@SMIS.COM", "STAFF2", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456793", true, "c57f22d7-7876-407e-8a43-001b884f5aca", "2", "Branch Store", false, "staff2", 0 },
                    { "6", 0, "a45a9a3d-1037-48ba-93dc-33ad5d1bd73b", "warehouse1@smis.com", true, "Unchanged", "David", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Keeper", false, null, "WAREHOUSE1@SMIS.COM", "WAREHOUSE1", "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=", "+855123456794", true, "8b8369ee-6ffc-4218-aaa3-c02dbd4bbf1b", "3", "Warehouse", false, "warehouse1", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(7984), "Drinks and beverages", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Unspecified).AddTicks(8014), new TimeSpan(0, 4, 30, 0, 0)), "Beverages", "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(7989), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2442), "Edible products and snacks", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2447), new TimeSpan(0, 4, 30, 0, 0)), "Food Items", "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2445), 0 },
                    { "3", "STAT", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2471), "Office and school supplies", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2472), new TimeSpan(0, 4, 30, 0, 0)), "Stationery", "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2471), 0 },
                    { "4", "GROC", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2475), "Daily household items", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2476), new TimeSpan(0, 4, 30, 0, 0)), "Grocery", "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2476), 0 },
                    { "5", "CARE", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2477), "Health and hygiene products", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, 4, 30, 0, 0)), "Personal Care", "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2478), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2480), "Electronic devices and accessories", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Unspecified).AddTicks(2481), new TimeSpan(0, 4, 30, 0, 0)), "Electronics", "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 547, DateTimeKind.Local).AddTicks(2480), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(7041), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(7061), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center", "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(7045), 0 },
                    { "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(8007), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(8032), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North", "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(8010), 0 },
                    { "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(8035), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(8046), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center", "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 536, DateTimeKind.Local).AddTicks(8038), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(1013), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3378), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3385), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3178), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3187), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3196), new TimeSpan(0, 0, 0, 0, 0)), "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3201), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3216), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 0, 0, 0, 0)), "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 536, DateTimeKind.Unspecified).AddTicks(3364), new TimeSpan(0, 0, 0, 0, 0)), "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LanguageNo", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(1248), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(1303), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center District", "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(1258), 0 },
                    { "10", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3683), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 0, 0, 0, 0)), "ولایت هرات", "5", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3684), 0 },
                    { "11", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3690), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 0, 0, 0, 0)), "Welcome Message", "6", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3692), 0 },
                    { "12", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3704), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3707), new TimeSpan(0, 0, 0, 0, 0)), "پیام خوش آمدید", "6", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3704), 0 },
                    { "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3561), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز کابل", "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3565), 0 },
                    { "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3583), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North District", "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3585), 0 },
                    { "4", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3596), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3606), new TimeSpan(0, 0, 0, 0, 0)), "منطقه شمال کابل", "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3598), 0 },
                    { "5", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3609), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center District", "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3611), 0 },
                    { "6", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3622), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3646), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز هرات", "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3624), 0 },
                    { "7", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3649), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Province", "4", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3650), 0 },
                    { "8", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3656), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3666), new TimeSpan(0, 0, 0, 0, 0)), "ولایت کابل", "4", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3659), 0 },
                    { "9", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3669), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 534, DateTimeKind.Unspecified).AddTicks(3678), new TimeSpan(0, 0, 0, 0, 0)), "Herat Province", "5", null, new DateTime(2026, 2, 1, 20, 49, 5, 534, DateTimeKind.Local).AddTicks(3671), 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 537, DateTimeKind.Unspecified).AddTicks(4858), new TimeSpan(0, 0, 0, 0, 0)), "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(5059), new TimeSpan(0, 0, 0, 0, 0)), "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 0, 0, 0, 0)), "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4077), new TimeSpan(0, 0, 0, 0, 0)), "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4904), new TimeSpan(0, 0, 0, 0, 0)), "Box", "2", "box", 0 },
                    { "5", "Large containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4929), new TimeSpan(0, 0, 0, 0, 0)), "Carton", "2", "ctn", 0 },
                    { "6", "Volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4936), new TimeSpan(0, 0, 0, 0, 0)), "Liter", "2", "L", 0 },
                    { "7", "Weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4942), new TimeSpan(0, 0, 0, 0, 0)), "Kilogram", "3", "kg", 0 },
                    { "8", "Small weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(4948), new TimeSpan(0, 0, 0, 0, 0)), "Gram", "3", "g", 0 },
                    { "9", "Small volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 538, DateTimeKind.Unspecified).AddTicks(5054), new TimeSpan(0, 0, 0, 0, 0)), "Milliliter", "3", "ml", 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "Description", "EntityState", "ImageUrl", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 1, 20, 49, 5, 542, DateTimeKind.Local).AddTicks(491), "Classic cola drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 542, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "COKE-500ML-001", 150, "1", "Main Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 542, DateTimeKind.Local).AddTicks(498), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4334), "Sunflower cooking oil", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "OIL-1L-010", 450, "1", "Main Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4335), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4350), "Basmati rice", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "RICE-1KG-011", 280, "2", "Branch Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4350), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4364), "White granulated sugar", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "SUGAR-1KG-012", 200, "3", "Warehouse", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4364), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4377), "Hair care shampoo", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4379), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "SHAMP-400ML-013", 350, "1", "Main Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4377), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4391), "Dental care paste", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4396), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "TOOTH-PASTE-014", 180, "2", "Branch Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4391), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4407), "Type-C charging cable", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "USB-CABLE-015", 250, "1", "Main Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4407), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4420), "Fast charging adapter", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4423), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "CHARGER-016", 800, "3", "Warehouse", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4421), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 1, 20, 49, 5, 544, DateTimeKind.Local).AddTicks(8321), "Cola soft drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 544, DateTimeKind.Unspecified).AddTicks(8343), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "PEPSI-500ML-002", 140, "1", "Main Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 544, DateTimeKind.Local).AddTicks(8325), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(1484), "Pure drinking water", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(1500), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "WATER-1L-003", 80, "2", "Branch Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(1487), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4150), "Chocolate sandwich cookies", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4165), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "OREO-PACK-004", 250, "1", "Main Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4153), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4223), "Potato chips", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4228), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "LAYS-PACK-005", 180, "2", "Branch Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4224), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4251), "Quick meal noodles", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4266), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "NOODLE-PACK-006", 120, "3", "Warehouse", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4251), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4284), "200 pages ruled notebook", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "NOTE-A4-007", 300, "1", "Main Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4285), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4304), "Ballpoint pen", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4307), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "PEN-BLUE-008", 50, "2", "Branch Store", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4304), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4319), "12 pencils per box", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 545, DateTimeKind.Unspecified).AddTicks(4322), new TimeSpan(0, 0, 0, 0, 0)), "Pencil Set", "PENCIL-BOX-009", 400, "3", "Warehouse", null, new DateTime(2026, 2, 1, 20, 49, 5, 545, DateTimeKind.Local).AddTicks(4320), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 524, DateTimeKind.Unspecified).AddTicks(3430), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "10", 60m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "Carton", "5", 0 },
                    { "11", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "Box", "4", 0 },
                    { "12", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(336), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "Carton", "5", 0 },
                    { "13", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "14", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(350), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "Box", "4", 0 },
                    { "15", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(355), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "Dozen", "10", 0 },
                    { "16", 144m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(361), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "Box", "4", 0 },
                    { "17", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 0, 0, 0, 0)), "9", "Pencil Set", "Carton", "5", 0 },
                    { "18", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(372), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "19", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(378), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "2", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "20", 10m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "Box", "4", 0 },
                    { "21", 25m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(451), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "Carton", "5", 0 },
                    { "22", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(459), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "Box", "4", 0 },
                    { "23", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(465), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "24", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "25", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(476), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "26", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(481), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "Box", "4", 0 },
                    { "27", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "Carton", "5", 0 },
                    { "28", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "Box", "4", 0 },
                    { "29", 200m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(500), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "Carton", "5", 0 },
                    { "3", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(277), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "30", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "Box", "4", 0 },
                    { "31", 100m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(511), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "Carton", "5", 0 },
                    { "4", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "5", 6m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(297), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "6", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "Carton", "5", 0 },
                    { "7", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(309), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "8", 48m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(314), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "9", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 1, 16, 19, 5, 525, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "Box", "4", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 2, 1, 20, 49, 5, 525, DateTimeKind.Local).AddTicks(9043), "Unchanged", new DateTime(2026, 8, 1, 16, 19, 5, 525, DateTimeKind.Utc).AddTicks(4154), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 1, 22, 16, 19, 5, 525, DateTimeKind.Utc).AddTicks(4109), "Active", "1", "Bottle", null, new DateTime(2026, 2, 1, 20, 49, 5, 527, DateTimeKind.Local).AddTicks(3607), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 2, 1, 20, 49, 5, 528, DateTimeKind.Local).AddTicks(5729), "Unchanged", new DateTime(2026, 9, 1, 16, 19, 5, 528, DateTimeKind.Utc).AddTicks(5685), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 1, 27, 16, 19, 5, 528, DateTimeKind.Utc).AddTicks(5683), "Active", "1", "Bottle", null, new DateTime(2026, 2, 1, 20, 49, 5, 528, DateTimeKind.Local).AddTicks(5732), 0 },
                    { "3", "BS-101", null, new DateTime(2026, 2, 1, 20, 49, 5, 528, DateTimeKind.Local).AddTicks(8883), "Unchanged", new DateTime(2026, 5, 1, 16, 19, 5, 528, DateTimeKind.Utc).AddTicks(8867), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 1, 17, 16, 19, 5, 528, DateTimeKind.Utc).AddTicks(8864), "Active", "2", "Pack", null, new DateTime(2026, 2, 1, 20, 49, 5, 528, DateTimeKind.Local).AddTicks(8885), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 2, 1, 20, 49, 5, 529, DateTimeKind.Local).AddTicks(868), "Unchanged", null, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 120000L, 200m, new DateTime(2026, 1, 12, 16, 19, 5, 529, DateTimeKind.Utc).AddTicks(854), "Active", "3", "Piece", null, new DateTime(2026, 2, 1, 20, 49, 5, 529, DateTimeKind.Local).AddTicks(870), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 1, 20, 49, 5, 529, DateTimeKind.Local).AddTicks(8283), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 1, 20, 49, 5, 529, DateTimeKind.Local).AddTicks(8286), 0 },
                    { "10", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5643), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 5m, "Sale #005", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5644), 0 },
                    { "2", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(336), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 20m, "Sale #001", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(340), 0 },
                    { "3", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(3343), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(3346), 0 },
                    { "4", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5434), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 15m, "Sale #002", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5437), 0 },
                    { "5", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5487), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 50m, "Purchase Order #003", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5489), 0 },
                    { "6", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5520), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 10m, "Sale #003", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5522), 0 },
                    { "7", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5549), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 2m, "Damage - Expired", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "2", "Bottle", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5551), 0 },
                    { "8", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5577), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 200m, "Purchase Order #004", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5579), 0 },
                    { "9", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5607), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 25m, "Sale #004", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 1, 20, 49, 5, 531, DateTimeKind.Local).AddTicks(5609), 0 }
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
