using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfsdsfsd : Migration
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
                    LanguageId = table.Column<string>(type: "TEXT", nullable: false),
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
                        name: "FK_AspNetUsers_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    RoleName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true)
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
                name: "ProductPrice",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    table.PrimaryKey("PK_ProductPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnit",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
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
                        name: "FK_ProductUnit_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
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
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
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
                        name: "FK_StockTransaction_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
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
                    { "1", "en", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(5019), new TimeSpan(0, 0, 0, 0, 0)), "English", 0 },
                    { "2", "ps", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(5322), new TimeSpan(0, 0, 0, 0, 0)), "Pashto", 0 },
                    { "3", "fa", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, 0, 0, 0, 0)), "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4417), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4418), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4568), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(4573), new TimeSpan(0, 0, 0, 0, 0)), "Herat", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4569), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4574), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4574), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4578), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(4582), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(4578), 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 2, 4, 17, 14, 15, 359, DateTimeKind.Local).AddTicks(7172), "main@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(7202), new TimeSpan(0, 0, 0, 0, 0)), "Main Pharmacy", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 2, 4, 17, 14, 15, 359, DateTimeKind.Local).AddTicks(7181), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 2, 4, 17, 14, 15, 360, DateTimeKind.Local).AddTicks(8925), "city@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 360, DateTimeKind.Unspecified).AddTicks(8954), new TimeSpan(0, 0, 0, 0, 0)), "City Pharmacy", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 2, 4, 17, 14, 15, 360, DateTimeKind.Local).AddTicks(8930), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 2, 4, 17, 14, 15, 360, DateTimeKind.Local).AddTicks(9647), "health@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 360, DateTimeKind.Unspecified).AddTicks(9656), new TimeSpan(0, 0, 0, 0, 0)), "Health Store", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 2, 4, 17, 14, 15, 360, DateTimeKind.Local).AddTicks(9647), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8258), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8296), new TimeSpan(0, 0, 0, 0, 0)), "1001", "Kabul Center District", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8273), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8633), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, 0, 0, 0, 0)), "1002", "Kabul North District", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8633), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8646), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0)), "1003", "Herat Center District", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8646), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8704), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8708), new TimeSpan(0, 0, 0, 0, 0)), "2001", "Kabul Province", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8705), 0 },
                    { "5", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8709), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 0, 0, 0, 0)), "2002", "Herat Province", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8709), 0 },
                    { "6", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8713), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 0, 0, 0, 0)), "3001", "Welcome Message", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8713), 0 },
                    { "7", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8717), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 0, 0, 0, 0)), "3002", "Error Message", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8717), 0 },
                    { "8", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8720), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 357, DateTimeKind.Unspecified).AddTicks(8723), new TimeSpan(0, 0, 0, 0, 0)), "3003", "Success Message", null, new DateTime(2026, 2, 4, 17, 14, 15, 357, DateTimeKind.Local).AddTicks(8721), 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "ee84b74d-116f-4066-b0e6-844326380262", "superadmin@smis.com", true, "Unchanged", "Super", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEPTSmfpos9zFM583iwlfgjUuNW6qhEf7emjakrH3glYvubwkgWvEIaXgWuX3lEbZsQ==", "+855123456789", true, "5e584b68-2df5-48f0-a637-e27523246111", "1", "Wholesale Shop", false, "superadmin", 0 },
                    { "10", 0, "0b19518e-3037-4308-b83d-91bc5f08fa4e", "radministration@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEJf7D3u3/U3hyBY7HWR1m5R/SAk1Xoc7R/ag9oADhcciopDMbg51E/pQzr3pXLh7EA==", "+855123456798", true, "f6afc54f-fb01-444d-8d4b-11f234d7c5de", "2", "Retail Shop", false, "radministration", 0 },
                    { "11", 0, "cf01bc16-45bc-4f18-8839-468c4f375b3c", "rmanager@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEGLyjLn7HiK93DAN7VYIT4eKujkJlb0uGndF00TvBAb06VhPUrDljnGv///NALowBw==", "+855123456799", true, "1071fd06-8a3e-4838-8a68-df4fd48c1bc3", "2", "Retail Shop", false, "rmanager", 0 },
                    { "12", 0, "ff50ac82-f938-4eb6-befd-51e0214a8bad", "rstaff@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEJJCW/Dm0/HjZM4xEakPfVQkKcURQ4ENOwK7mNoWoeVeY3EAxFvGZfjEW6yIlCF+Xw==", "+855123456800", true, "73d8ca49-eeb9-4d24-9651-ad8e7c538d62", "2", "Retail Shop", false, "rstaff", 0 },
                    { "13", 0, "3d3dc989-e799-4e65-a6d2-814017b0781f", "rviewer@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEJnolqtkmi2Kg5q6IqmpWOnlU7SZBhzSf5Mynlp39MDGW8q4/fkteh7ymUNVgCYRtw==", "+855123456801", true, "338a12ee-436c-4062-a4d8-0ec0d4263ecf", "2", "Retail Shop", false, "rviewer", 0 },
                    { "14", 0, "7114f0d4-715c-4314-9978-fb491c139278", "reditor@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAEL4S8VH3lC6ORmcdCere4TIbMasOJ9hNr7hs/M/TBP0zMMJTUyIpsbfhlyUhJWnFJg==", "+855123456802", true, "2440fe5c-032a-4fac-ab6f-45853d45ceb1", "2", "Retail Shop", false, "reditor", 0 },
                    { "15", 0, "f9e9a8bf-911d-4e2b-bf85-cae1cc641ae2", "ruser@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEO8oiCS02nsWACy1L6tMNCHzAQ2SHE1Bj+iQDhNDMmCnqnJBqsNrdtwQrFLuPwtylQ==", "+855123456803", true, "0daee5a7-bc03-4fe8-b51c-e409e9166d1e", "2", "Retail Shop", false, "ruser", 0 },
                    { "2", 0, "df02ecbb-40b6-42e5-b1a1-b4a2477ae874", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEBtyt6sETDifp6g/0yEsWc1FM7nVS0qrMrR2KzDexNfAKZA9U7LDD5f9nTkutckfjg==", "+855123456790", true, "92dd6f67-c246-4aaf-9787-1546bc406734", "1", "Wholesale Shop", false, "wadmin", 0 },
                    { "3", 0, "facbb78c-690b-4782-b277-ef1bc6ffb67f", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEBC8HSjZCfGYiQ7ad50nDndlTLwa0fDm8SRTKKqA4e7MHvsq/4DMTCW5N/IEGX7KIA==", "+855123456791", true, "4696ae2c-eb12-456c-90f6-881b9eecbd24", "1", "Wholesale Shop", false, "wadministration", 0 },
                    { "4", 0, "fc31b357-9d8a-43bd-b7ca-cf2fcd566616", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEIVTBYWeiDzwdpn8DrF1fBmZtFGEiZZt+C1KrturElUTbySzF+45FsFOJ+9JCHf+7A==", "+855123456792", true, "f90dc26e-121b-42d7-9864-b46263aae289", "1", "Wholesale Shop", false, "wmanager", 0 },
                    { "5", 0, "4fbc0175-b424-49b7-846e-74236365e63c", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAECbl4XeAxwT6dd/+Jrm6B6Xcp4cuUaCnL1mjLIgM+oDCDWpGxuzUg+IHrObNzJGgBQ==", "+855123456793", true, "7d087796-5781-4ab9-bad7-607702be494a", "1", "Wholesale Shop", false, "wstaff", 0 },
                    { "6", 0, "a0947a9e-b670-4012-a65f-68f6fd381523", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEH5WIc7c/DEAUbNyY7bCi+okS/1HiDI2bEp7N4lgR6DSluMCkh5oxoOTCsFd/JiwYg==", "+855123456794", true, "a1e1e3a4-4f56-4243-a54d-83da2e96464a", "1", "Wholesale Shop", false, "wviewer", 0 },
                    { "7", 0, "08bf247e-575e-4da5-9d85-5e2ec333a42c", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEJYqvO03y0vfcOvxoekXSvuvXzhj2to5/fj6fw07l156MXe5YXk1glOuY9o3/q/1bw==", "+855123456795", true, "1b30825b-a029-4cee-a2b6-b545fe86d8b5", "1", "Wholesale Shop", false, "weditor", 0 },
                    { "8", 0, "37d211c0-6f1a-479c-a58d-613780d36b4c", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEJt+DCTcE9D7+PDC/itCAqjoJ6D2wlIQ+dq94vnAbo5eQ0RrbN2vgIMwamRht3QMow==", "+855123456796", true, "9ffad450-a5c0-4fe5-acc6-904aa29b6d7c", "1", "Wholesale Shop", false, "wuser", 0 },
                    { "9", 0, "8fbbb7a4-36ba-4293-8cc8-80b5276944dd", "radmin@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEKQEmBklNXxbGFtaCrYznMLx0gkS2wVsu3nrFDKFFu1uWA21KuIVVNF7iK2SFcMViA==", "+855123456797", true, "2f10be77-2043-4724-a73a-7c6b7dc964d7", "2", "Retail Shop", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 2, 4, 17, 14, 15, 364, DateTimeKind.Local).AddTicks(464), "Drinks and beverages", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 364, DateTimeKind.Unspecified).AddTicks(499), new TimeSpan(0, 4, 30, 0, 0)), "Beverages", "1", null, new DateTime(2026, 2, 4, 17, 14, 15, 364, DateTimeKind.Local).AddTicks(465), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1586), "Edible products and snacks", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 4, 30, 0, 0)), "Food Items", "1", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1589), 0 },
                    { "3", "STAT", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1600), "Office and school supplies", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 4, 30, 0, 0)), "Stationery", "2", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1601), 0 },
                    { "4", "GROC", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1603), "Daily household items", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 4, 30, 0, 0)), "Grocery", "2", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1603), 0 },
                    { "5", "CARE", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1604), "Health and hygiene products", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 4, 30, 0, 0)), "Personal Care", "3", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1605), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1606), "Electronic devices and accessories", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Unspecified).AddTicks(1606), new TimeSpan(0, 4, 30, 0, 0)), "Electronics", "3", null, new DateTime(2026, 2, 4, 17, 14, 15, 365, DateTimeKind.Local).AddTicks(1606), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6495), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center", "1", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6497), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6741), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(6750), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North", "2", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6742), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6751), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(6754), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center", "3", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(6751), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5490), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5494), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5450), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5464), new TimeSpan(0, 0, 0, 0, 0)), "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5468), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5471), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 0, 0, 0, 0)), "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(5482), new TimeSpan(0, 0, 0, 0, 0)), "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LanguageNo", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(751), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(764), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center District", "1", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(752), 0 },
                    { "10", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1094), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1099), new TimeSpan(0, 0, 0, 0, 0)), "ولایت هرات", "5", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1095), 0 },
                    { "11", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1100), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1104), new TimeSpan(0, 0, 0, 0, 0)), "Welcome Message", "6", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1100), 0 },
                    { "12", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1104), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 0, 0, 0, 0)), "پیام خوش آمدید", "6", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1105), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1032), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1040), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز کابل", "1", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1033), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1042), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North District", "2", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1042), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1046), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 0, 0, 0, 0)), "منطقه شمال کابل", "2", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1046), 0 },
                    { "5", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1050), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1053), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center District", "3", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1050), 0 },
                    { "6", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1053), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1056), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز هرات", "3", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1054), 0 },
                    { "7", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1057), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1085), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Province", "4", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1066), 0 },
                    { "8", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1086), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1089), new TimeSpan(0, 0, 0, 0, 0)), "ولایت کابل", "4", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1086), 0 },
                    { "9", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1090), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(1094), new TimeSpan(0, 0, 0, 0, 0)), "Herat Province", "5", null, new DateTime(2026, 2, 4, 17, 14, 15, 358, DateTimeKind.Local).AddTicks(1091), 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 358, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)), "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, 0, 0, 0, 0)), "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(2551), new TimeSpan(0, 0, 0, 0, 0)), "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4076), new TimeSpan(0, 0, 0, 0, 0)), "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4536), new TimeSpan(0, 0, 0, 0, 0)), "Box", "2", "box", 0 },
                    { "5", "Large containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4544), new TimeSpan(0, 0, 0, 0, 0)), "Carton", "2", "ctn", 0 },
                    { "6", "Volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4548), new TimeSpan(0, 0, 0, 0, 0)), "Liter", "2", "L", 0 },
                    { "7", "Weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4553), new TimeSpan(0, 0, 0, 0, 0)), "Kilogram", "3", "kg", 0 },
                    { "8", "Small weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4557), new TimeSpan(0, 0, 0, 0, 0)), "Gram", "3", "g", 0 },
                    { "9", "Small volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 359, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)), "Milliliter", "3", "ml", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "RoleName", "UserName" },
                values: new object[,]
                {
                    { "1", "1", "SuperAdmin", "superadmin" },
                    { "10", "10", "RShopAdministration", "radministration" },
                    { "11", "11", "RShopManager", "rmanager" },
                    { "12", "12", "RShopStaff", "rstaff" },
                    { "13", "13", "RShopViewer", "rviewer" },
                    { "14", "14", "RShopEditor", "reditor" },
                    { "15", "15", "RShopUser", "ruser" },
                    { "2", "2", "WShopAdmin", "wadmin" },
                    { "3", "3", "WShopAdministration", "wadministration" },
                    { "4", "4", "WShopManager", "wmanager" },
                    { "5", "5", "WShopStaff", "wstaff" },
                    { "6", "6", "WShopViewer", "wviewer" },
                    { "7", "7", "WShopEditor", "weditor" },
                    { "8", "8", "WShopUser", "wuser" },
                    { "9", "9", "RShopAdmin", "radmin" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "Description", "EntityState", "ImageUrl", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 4, 17, 14, 15, 361, DateTimeKind.Local).AddTicks(4933), "Classic cola drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 361, DateTimeKind.Unspecified).AddTicks(4953), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "COKE-500ML-001", 150, "1", "Main Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 361, DateTimeKind.Local).AddTicks(4938), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7177), "Sunflower cooking oil", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7181), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "OIL-1L-010", 450, "1", "Main Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7178), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7190), "Basmati rice", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "RICE-1KG-011", 280, "2", "Branch Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7190), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7248), "White granulated sugar", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7252), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "SUGAR-1KG-012", 200, "3", "Warehouse", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7249), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7259), "Hair care shampoo", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "SHAMP-400ML-013", 350, "1", "Main Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7259), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7270), "Dental care paste", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7276), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "TOOTH-PASTE-014", 180, "2", "Branch Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7271), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7283), "Type-C charging cable", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "USB-CABLE-015", 250, "1", "Main Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7283), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7317), "Fast charging adapter", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7320), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "CHARGER-016", 800, "3", "Warehouse", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7317), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(3160), "Cola soft drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(3200), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "PEPSI-500ML-002", 140, "1", "Main Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(3170), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(5786), "Pure drinking water", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(5803), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "WATER-1L-003", 80, "2", "Branch Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(5789), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7029), "Chocolate sandwich cookies", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7038), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "OREO-PACK-004", 250, "1", "Main Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7031), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7065), "Potato chips", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "LAYS-PACK-005", 180, "2", "Branch Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7066), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7079), "Quick meal noodles", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "NOODLE-PACK-006", 120, "3", "Warehouse", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7080), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7097), "200 pages ruled notebook", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7102), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "NOTE-A4-007", 300, "1", "Main Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7098), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7119), "Ballpoint pen", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "PEN-BLUE-008", 50, "2", "Branch Store", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7120), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7131), "12 pencils per box", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 15, 363, DateTimeKind.Unspecified).AddTicks(7135), new TimeSpan(0, 0, 0, 0, 0)), "Pencil Set", "PENCIL-BOX-009", 400, "3", "Warehouse", null, new DateTime(2026, 2, 4, 17, 14, 15, 363, DateTimeKind.Local).AddTicks(7131), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Price", "ProductId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 17, 14, 14, 750, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(5913), new TimeSpan(0, 0, 0, 0, 0)), 150, "1", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(5303), 0 },
                    { "10", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9749), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9752), new TimeSpan(0, 0, 0, 0, 0)), 125, "6", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9750), 0 },
                    { "11", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9754), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 0, 0, 0, 0)), 300, "7", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9754), 0 },
                    { "12", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9761), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9764), new TimeSpan(0, 0, 0, 0, 0)), 50, "8", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9761), 0 },
                    { "13", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9765), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9768), new TimeSpan(0, 0, 0, 0, 0)), 400, "9", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9766), 0 },
                    { "14", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9769), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9772), new TimeSpan(0, 0, 0, 0, 0)), 450, "10", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9770), 0 },
                    { "15", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9777), new TimeSpan(0, 0, 0, 0, 0)), 480, "10", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9774), 0 },
                    { "16", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9778), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9781), new TimeSpan(0, 0, 0, 0, 0)), 280, "11", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9778), 0 },
                    { "17", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9782), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9785), new TimeSpan(0, 0, 0, 0, 0)), 200, "12", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9783), 0 },
                    { "18", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9786), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9789), new TimeSpan(0, 0, 0, 0, 0)), 350, "13", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9787), 0 },
                    { "19", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, 0, 0, 0, 0)), 180, "14", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9791), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(8325), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(8335), new TimeSpan(0, 0, 0, 0, 0)), 160, "1", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(8327), 0 },
                    { "20", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9797), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 0, 0, 0, 0)), 250, "15", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9797), 0 },
                    { "21", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9801), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9804), new TimeSpan(0, 0, 0, 0, 0)), 800, "16", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9801), 0 },
                    { "22", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9805), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9808), new TimeSpan(0, 0, 0, 0, 0)), 750, "16", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9805), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9177), new TimeSpan(0, 0, 0, 0, 0)), 140, "2", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9165), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9663), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9673), new TimeSpan(0, 0, 0, 0, 0)), 145, "2", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9665), 0 },
                    { "5", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9685), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9688), new TimeSpan(0, 0, 0, 0, 0)), 80, "3", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9685), 0 },
                    { "6", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9693), new TimeSpan(0, 0, 0, 0, 0)), 250, "4", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9690), 0 },
                    { "7", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 0, 0, 0, 0)), 270, "4", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9695), 0 },
                    { "8", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9743), new TimeSpan(0, 0, 0, 0, 0)), 180, "5", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9740), 0 },
                    { "9", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9745), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 751, DateTimeKind.Unspecified).AddTicks(9748), new TimeSpan(0, 0, 0, 0, 0)), 120, "6", null, new DateTime(2026, 2, 4, 17, 14, 14, 751, DateTimeKind.Local).AddTicks(9745), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "ShopId", "ShopName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 748, DateTimeKind.Unspecified).AddTicks(8233), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "1", "Main Store", "Box", "4", 0 },
                    { "10", 60m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "2", "Branch Store", "Carton", "5", 0 },
                    { "11", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8185), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "3", "Warehouse", "Box", "4", 0 },
                    { "12", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "3", "Warehouse", "Carton", "5", 0 },
                    { "13", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8195), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "1", "Main Store", "Dozen", "10", 0 },
                    { "14", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8202), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "1", "Main Store", "Box", "4", 0 },
                    { "15", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8207), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "2", "Branch Store", "Dozen", "10", 0 },
                    { "16", 144m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8212), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "2", "Branch Store", "Box", "4", 0 },
                    { "17", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8217), new TimeSpan(0, 0, 0, 0, 0)), "9", "Pencil Set", "3", "Warehouse", "Carton", "5", 0 },
                    { "18", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8221), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "1", "Main Store", "Box", "4", 0 },
                    { "19", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8226), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "1", "Main Store", "Carton", "5", 0 },
                    { "2", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "1", "Main Store", "Carton", "5", 0 },
                    { "20", 10m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8231), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "2", "Branch Store", "Box", "4", 0 },
                    { "21", 25m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8235), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "2", "Branch Store", "Carton", "5", 0 },
                    { "22", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "3", "Warehouse", "Box", "4", 0 },
                    { "23", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8246), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "3", "Warehouse", "Carton", "5", 0 },
                    { "24", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8250), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "1", "Main Store", "Box", "4", 0 },
                    { "25", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8255), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "1", "Main Store", "Carton", "5", 0 },
                    { "26", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "2", "Branch Store", "Box", "4", 0 },
                    { "27", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8291), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "2", "Branch Store", "Carton", "5", 0 },
                    { "28", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8297), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "1", "Main Store", "Box", "4", 0 },
                    { "29", 200m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8302), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "1", "Main Store", "Carton", "5", 0 },
                    { "3", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "1", "Main Store", "Box", "4", 0 },
                    { "30", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8308), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "3", "Warehouse", "Box", "4", 0 },
                    { "31", 100m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8313), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "3", "Warehouse", "Carton", "5", 0 },
                    { "4", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8136), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "1", "Main Store", "Carton", "5", 0 },
                    { "5", 6m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8145), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "2", "Branch Store", "Box", "4", 0 },
                    { "6", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "2", "Branch Store", "Carton", "5", 0 },
                    { "7", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8165), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "1", "Main Store", "Box", "4", 0 },
                    { "8", 48m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8170), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "1", "Main Store", "Carton", "5", 0 },
                    { "9", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 12, 44, 14, 749, DateTimeKind.Unspecified).AddTicks(8175), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "2", "Branch Store", "Box", "4", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(3861), "Unchanged", new DateTime(2026, 8, 4, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(1859), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 1, 25, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(1810), "Active", "1", "Bottle", null, new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(3862), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(8099), "Unchanged", new DateTime(2026, 9, 4, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(8088), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 1, 30, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(8087), "Active", "1", "Bottle", null, new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(8101), 0 },
                    { "3", "BS-101", null, new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(9111), "Unchanged", new DateTime(2026, 5, 4, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(9105), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 1, 20, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(9104), "Active", "2", "Pack", null, new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(9112), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(9963), "Unchanged", null, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 120000L, 200m, new DateTime(2026, 1, 15, 12, 44, 14, 752, DateTimeKind.Utc).AddTicks(9953), "Active", "3", "Piece", null, new DateTime(2026, 2, 4, 17, 14, 14, 752, DateTimeKind.Local).AddTicks(9965), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 17, 14, 14, 753, DateTimeKind.Local).AddTicks(3659), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 4, 17, 14, 14, 753, DateTimeKind.Local).AddTicks(3660), 0 },
                    { "10", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1379), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1380), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 17, 14, 14, 753, DateTimeKind.Local).AddTicks(9112), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 4, 17, 14, 14, 753, DateTimeKind.Local).AddTicks(9114), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(407), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(409), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1327), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1328), 0 },
                    { "5", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1341), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1342), 0 },
                    { "6", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1349), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1349), 0 },
                    { "7", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1355), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "2", "Bottle", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1356), 0 },
                    { "8", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1361), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1362), 0 },
                    { "9", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1373), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 4, 17, 14, 14, 754, DateTimeKind.Local).AddTicks(1373), 0 }
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
                name: "IX_AspNetUsers_LanguageId",
                table: "AspNetUsers",
                column: "LanguageId");

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
                name: "IX_ProductPrice_IsActive",
                table: "ProductPrice",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductId_EffectiveDate",
                table: "ProductPrice",
                columns: new[] { "ProductId", "EffectiveDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_ProductId",
                table: "ProductUnit",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_ShopId",
                table: "ProductUnit",
                column: "ShopId");

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
                name: "IX_StockTransaction_ShopId",
                table: "StockTransaction",
                column: "ShopId");

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
                name: "ProductPrice");

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
                name: "TranslationKeys");

            migrationBuilder.DropTable(
                name: "Languages");

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
