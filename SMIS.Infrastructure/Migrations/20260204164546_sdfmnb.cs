using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfmnb : Migration
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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ShopId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    FatherName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    TaxNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ProvinceId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    DistrictId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Customers_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Customers_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
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
                    { "1", "en", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 79, DateTimeKind.Unspecified).AddTicks(6124), new TimeSpan(0, 0, 0, 0, 0)), "English", 0 },
                    { "2", "ps", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 79, DateTimeKind.Unspecified).AddTicks(6965), new TimeSpan(0, 0, 0, 0, 0)), "Pashto", 0 },
                    { "3", "fa", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 79, DateTimeKind.Unspecified).AddTicks(6970), new TimeSpan(0, 0, 0, 0, 0)), "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4062), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(4076), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4066), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4454), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(4462), new TimeSpan(0, 0, 0, 0, 0)), "Herat", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4456), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4464), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(4466), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4465), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4467), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(4468), 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 2, 4, 21, 15, 45, 83, DateTimeKind.Local).AddTicks(8519), "main@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(8539), new TimeSpan(0, 0, 0, 0, 0)), "Main Pharmacy", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 2, 4, 21, 15, 45, 83, DateTimeKind.Local).AddTicks(8525), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 2, 4, 21, 15, 45, 86, DateTimeKind.Local).AddTicks(86), "city@pharmacy.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 86, DateTimeKind.Unspecified).AddTicks(121), new TimeSpan(0, 0, 0, 0, 0)), "City Pharmacy", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 2, 4, 21, 15, 45, 86, DateTimeKind.Local).AddTicks(93), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 2, 4, 21, 15, 45, 86, DateTimeKind.Local).AddTicks(1167), "health@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 86, DateTimeKind.Unspecified).AddTicks(1179), new TimeSpan(0, 0, 0, 0, 0)), "Health Store", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 2, 4, 21, 15, 45, 86, DateTimeKind.Local).AddTicks(1171), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(1296), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(1318), new TimeSpan(0, 0, 0, 0, 0)), "1001", "Kabul Center District", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(1308), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2207), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2217), new TimeSpan(0, 0, 0, 0, 0)), "1002", "Kabul North District", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2210), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2242), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2257), new TimeSpan(0, 0, 0, 0, 0)), "1003", "Herat Center District", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2243), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2258), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2260), new TimeSpan(0, 0, 0, 0, 0)), "2001", "Kabul Province", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2259), 0 },
                    { "5", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2262), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2264), new TimeSpan(0, 0, 0, 0, 0)), "2002", "Herat Province", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2262), 0 },
                    { "6", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2265), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, 0, 0, 0, 0)), "3001", "Welcome Message", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2266), 0 },
                    { "7", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2268), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2271), new TimeSpan(0, 0, 0, 0, 0)), "3002", "Error Message", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2269), 0 },
                    { "8", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2272), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(2274), new TimeSpan(0, 0, 0, 0, 0)), "3003", "Success Message", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(2272), 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "db65493c-3e6f-4de5-b194-37f0e9629c01", "superadmin@smis.com", true, "Unchanged", "Super", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAELctAkhMkxxkHr3g1xp8ULSwhlxhY/QE9c1vsfpIsAC0nBe3e9oWSb0gdiRflUiOrQ==", "+855123456789", true, "6a09d362-879d-4c92-8449-02e23d6c57d1", "1", "Wholesale Shop", false, "superadmin", 0 },
                    { "10", 0, "a62f496f-a631-4dcf-aa10-ca93b9d4c628", "radministration@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEC7kE5VASdIGtgy+IksJfgW4RUYT0B+LfNj6KWF2td1KOSd331sc6Nw2pivGpELh+Q==", "+855123456798", true, "b315b88e-de29-4747-ba8a-47d4d5c07044", "2", "Retail Shop", false, "radministration", 0 },
                    { "11", 0, "9b4be7ec-df3d-4daa-83f2-71a324325684", "rmanager@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEIALuX6bkkIp4JChCRmKcYBC0jVjcpwl7n26jRPz6NlOMCKtTU8ktC2wk74OdfCgrw==", "+855123456799", true, "a9de5cf5-d22a-4bbd-8711-c142889c6137", "2", "Retail Shop", false, "rmanager", 0 },
                    { "12", 0, "be72a797-c37a-493a-86c2-a13af2363653", "rstaff@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEG5tvgJpIiPgmyYVpGB3Ra9fjNInh7joUzF1PX3Bp6JaQExtwiPxor7lX4L9PJkRVw==", "+855123456800", true, "1bd00f76-19fd-406b-8bae-0d746cc61aa0", "2", "Retail Shop", false, "rstaff", 0 },
                    { "13", 0, "93d3f83b-ff48-4778-8570-30eddfa8d9cf", "rviewer@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEPPB/B0gEYB31uQ9uLV5eDUNpBZSBWpPv4BUkuOIF3YAyKfAgxTMZPqAuix2IFb6LA==", "+855123456801", true, "e71d61e7-ebf5-4f89-96b9-7a07e0af0c7e", "2", "Retail Shop", false, "rviewer", 0 },
                    { "14", 0, "c292f40a-d277-4f21-ba4f-cc336653e9ac", "reditor@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAEOH1DNQK62s439ZciuyZdJNRvt00rheyeX2OpWAYrM0HtN//DpJTPYDd+JC/SRkeOA==", "+855123456802", true, "2a55c55e-6df6-44c8-bea3-a964dd28be96", "2", "Retail Shop", false, "reditor", 0 },
                    { "15", 0, "3d43f3f9-6c2e-4d7a-97e6-65f988737315", "ruser@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEBu4qr3AXSbsMpSli8kp2B3yM973WEsrmcFrzAjYeTd1znDvgi4IvfXE6CKvIeOPaA==", "+855123456803", true, "163010e4-7301-4172-a743-77c537ad193b", "2", "Retail Shop", false, "ruser", 0 },
                    { "2", 0, "940c030a-a267-42aa-bc5a-8a2c5b06f84a", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAED/mK4Z0nZAcSWBiBbAqqwYcuR9EvQ+h6O5TX1bVo7saHWxjBqp6Efr066VrLoLITw==", "+855123456790", true, "992af901-356d-4317-b738-4253b64e0283", "1", "Wholesale Shop", false, "wadmin", 0 },
                    { "3", 0, "552cf464-11a2-4794-85a4-fae151633926", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEB4c6E8rkfvBF++wsXmycbr5Oqd8uFEORoDpKlVQxxL8mXzFgcB6VjecTOyJT+d12g==", "+855123456791", true, "1fef9497-83e0-43c1-b090-9a9a1f01f31a", "1", "Wholesale Shop", false, "wadministration", 0 },
                    { "4", 0, "73cd26de-f764-4f7c-980b-285f22d21f9c", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEHBnUK/ob1hwLPDeSITJGIhv2v0qh6gcoYq9tz/kez18gj3UGZrKpHRBXXag82Rp4g==", "+855123456792", true, "ef3a3451-eb2d-472a-9669-8a7cf85b2785", "1", "Wholesale Shop", false, "wmanager", 0 },
                    { "5", 0, "8688b458-2148-4d64-9a17-6bb4c05b84df", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAEP2T8JqXZFxfg4GRB23IQG2tfzbRk1RJkOUoUb3L7422ojgrULCSWtXxKrDHCQTiGQ==", "+855123456793", true, "7f41ce44-38cd-47b1-b776-6e1a5308ef92", "1", "Wholesale Shop", false, "wstaff", 0 },
                    { "6", 0, "18b76051-8172-4caf-8d98-8d831f8d2bfa", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEAajJ7SdZ9PPV840TmC2ZcYwQBe3L/hA523DQskSHzRDNvTOFPjlP5Rr3saDXwPf/g==", "+855123456794", true, "e7fd76f5-663e-425a-a848-523ff1dfb044", "1", "Wholesale Shop", false, "wviewer", 0 },
                    { "7", 0, "e25471e7-40ca-454f-8ee6-49eaac911d42", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEGqKzmGzKEcTOmB+9qyS8M4jhVGqiGImCh789WE6FWRe8b6tUOqfHHMujpuE5Fe3gw==", "+855123456795", true, "0a15a7cd-aed8-4668-9814-9d1355ef9482", "1", "Wholesale Shop", false, "weditor", 0 },
                    { "8", 0, "344d2bee-0bf2-4f28-b711-5e86c7c6ab1c", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEFviaf3wSxKe8lPtnpEdhzy0nNj0Lx4fDr4jdjoxTjQA0eQjw4KslBAVhY6CiC0HSA==", "+855123456796", true, "6fc14050-5481-475d-9b10-92f7dc65d1a0", "1", "Wholesale Shop", false, "wuser", 0 },
                    { "9", 0, "6c6e77c6-48a5-49c8-8de8-c9b49fef17ba", "radmin@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEHl8otY3ciyG1xXvSkyzqZKZUxVizOCXtq0RZWOmTGP76V+8XYy4t4D/aXfj02mmUg==", "+855123456797", true, "bbc85a6e-6e14-49bb-8251-8588e6e7bfc5", "2", "Retail Shop", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 2, 4, 21, 15, 45, 91, DateTimeKind.Local).AddTicks(27), "Drinks and beverages", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 91, DateTimeKind.Unspecified).AddTicks(58), new TimeSpan(0, 4, 30, 0, 0)), "Beverages", "1", null, new DateTime(2026, 2, 4, 21, 15, 45, 91, DateTimeKind.Local).AddTicks(31), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6776), "Edible products and snacks", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6786), new TimeSpan(0, 4, 30, 0, 0)), "Food Items", "1", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6785), 0 },
                    { "3", "STAT", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6836), "Office and school supplies", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6837), new TimeSpan(0, 4, 30, 0, 0)), "Stationery", "2", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6837), 0 },
                    { "4", "GROC", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6840), "Daily household items", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6841), new TimeSpan(0, 4, 30, 0, 0)), "Grocery", "2", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6841), 0 },
                    { "5", "CARE", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6843), "Health and hygiene products", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 4, 30, 0, 0)), "Personal Care", "3", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6844), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6846), "Electronic devices and accessories", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Unspecified).AddTicks(6847), new TimeSpan(0, 4, 30, 0, 0)), "Electronics", "3", null, new DateTime(2026, 2, 4, 21, 15, 45, 93, DateTimeKind.Local).AddTicks(6847), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9064), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(9076), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center", "1", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9068), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9674), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(9682), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North", "2", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9676), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9685), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(9687), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center", "3", null, new DateTime(2026, 2, 4, 21, 15, 45, 81, DateTimeKind.Local).AddTicks(9685), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(5507), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6766), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6771), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6719), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6737), new TimeSpan(0, 0, 0, 0, 0)), "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6740), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6742), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6758), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6761), new TimeSpan(0, 0, 0, 0, 0)), "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 81, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 0, 0, 0, 0)), "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LanguageNo", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(6215), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(6234), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center District", "1", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(6219), 0 },
                    { "10", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7154), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 0, 0, 0, 0)), "ولایت هرات", "5", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7154), 0 },
                    { "11", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7157), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 0, 0, 0, 0)), "Welcome Message", "6", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7158), 0 },
                    { "12", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7163), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 0, 0, 0, 0)), "پیام خوش آمدید", "6", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7163), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7067), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز کابل", "1", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7070), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7080), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7087), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North District", "2", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7080), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7089), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 0, 0, 0, 0)), "منطقه شمال کابل", "2", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7089), 0 },
                    { "5", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7092), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7095), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center District", "3", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7093), 0 },
                    { "6", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7096), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7098), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز هرات", "3", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7096), 0 },
                    { "7", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7099), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Province", "4", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7104), 0 },
                    { "8", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7147), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7149), new TimeSpan(0, 0, 0, 0, 0)), "ولایت کابل", "4", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7148), 0 },
                    { "9", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7151), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 80, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 0, 0, 0, 0)), "Herat Province", "5", null, new DateTime(2026, 2, 4, 21, 15, 45, 80, DateTimeKind.Local).AddTicks(7151), 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 82, DateTimeKind.Unspecified).AddTicks(4513), new TimeSpan(0, 0, 0, 0, 0)), "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4052), new TimeSpan(0, 0, 0, 0, 0)), "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(2067), new TimeSpan(0, 0, 0, 0, 0)), "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(3186), new TimeSpan(0, 0, 0, 0, 0)), "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(3975), new TimeSpan(0, 0, 0, 0, 0)), "Box", "2", "box", 0 },
                    { "5", "Large containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4005), new TimeSpan(0, 0, 0, 0, 0)), "Carton", "2", "ctn", 0 },
                    { "6", "Volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 0, 0, 0, 0)), "Liter", "2", "L", 0 },
                    { "7", "Weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4014), new TimeSpan(0, 0, 0, 0, 0)), "Kilogram", "3", "kg", 0 },
                    { "8", "Small weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4031), new TimeSpan(0, 0, 0, 0, 0)), "Gram", "3", "g", 0 },
                    { "9", "Small volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 83, DateTimeKind.Unspecified).AddTicks(4037), new TimeSpan(0, 0, 0, 0, 0)), "Milliliter", "3", "ml", 0 }
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
                table: "Customers",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedAt", "DeletedBy", "DistrictId", "Email", "EntityState", "FatherName", "FirstName", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "LastName", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 2, 4, 21, 15, 45, 94, DateTimeKind.Local).AddTicks(6136), null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 94, DateTimeKind.Unspecified).AddTicks(6182), new TimeSpan(0, 0, 0, 0, 0)), "Doe", "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 2, 4, 21, 15, 45, 94, DateTimeKind.Local).AddTicks(6149), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3599), null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3601), new TimeSpan(0, 0, 0, 0, 0)), "Rodriguez", "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3599), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 2, 4, 21, 15, 45, 95, DateTimeKind.Local).AddTicks(9393), null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 95, DateTimeKind.Unspecified).AddTicks(9412), new TimeSpan(0, 0, 0, 0, 0)), "Smith", "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 2, 4, 21, 15, 45, 95, DateTimeKind.Local).AddTicks(9400), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(1892), null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 0, 0, 0, 0)), "Brown", "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(1896), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3441), null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3453), new TimeSpan(0, 0, 0, 0, 0)), "Wilson", "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3445), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3516), null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 0, 0, 0, 0)), "Taylor", "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3517), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3531), null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3533), new TimeSpan(0, 0, 0, 0, 0)), "Garcia", "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3532), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3547), null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3561), new TimeSpan(0, 0, 0, 0, 0)), "Martinez", "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3547), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3572), null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3575), new TimeSpan(0, 0, 0, 0, 0)), "Lopez", "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3573), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3587), null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 96, DateTimeKind.Unspecified).AddTicks(3589), new TimeSpan(0, 0, 0, 0, 0)), "Gonzalez", "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 2, 4, 21, 15, 45, 96, DateTimeKind.Local).AddTicks(3588), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "Description", "EntityState", "ImageUrl", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "SKU", "SalePricePerBaseUnit", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 4, 21, 15, 45, 87, DateTimeKind.Local).AddTicks(1059), "Classic cola drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 87, DateTimeKind.Unspecified).AddTicks(1074), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "COKE-500ML-001", 150, "1", "Main Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 87, DateTimeKind.Local).AddTicks(1063), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6176), "Sunflower cooking oil", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6178), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "OIL-1L-010", 450, "1", "Main Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6177), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6188), "Basmati rice", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6191), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "RICE-1KG-011", 280, "2", "Branch Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6189), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6200), "White granulated sugar", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6202), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "SUGAR-1KG-012", 200, "3", "Warehouse", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6201), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6212), "Hair care shampoo", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6214), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "SHAMP-400ML-013", 350, "1", "Main Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6212), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6224), "Dental care paste", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "TOOTH-PASTE-014", 180, "2", "Branch Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6224), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6235), "Type-C charging cable", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "USB-CABLE-015", 250, "1", "Main Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6235), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6250), "Fast charging adapter", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "CHARGER-016", 800, "3", "Warehouse", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6250), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(570), "Cola soft drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(599), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "PEPSI-500ML-002", 140, "1", "Main Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(578), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(3584), "Pure drinking water", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "WATER-1L-003", 80, "2", "Branch Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(3588), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6045), "Chocolate sandwich cookies", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "OREO-PACK-004", 250, "1", "Main Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6048), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6098), "Potato chips", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6100), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "LAYS-PACK-005", 180, "2", "Branch Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6099), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6112), "Quick meal noodles", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6115), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "NOODLE-PACK-006", 120, "3", "Warehouse", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6113), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6124), "200 pages ruled notebook", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6137), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "NOTE-A4-007", 300, "1", "Main Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6125), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6148), "Ballpoint pen", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6150), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "PEN-BLUE-008", 50, "2", "Branch Store", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6148), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6164), "12 pencils per box", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 45, 90, DateTimeKind.Unspecified).AddTicks(6166), new TimeSpan(0, 0, 0, 0, 0)), "Pencil Set", "PENCIL-BOX-009", 400, "3", "Warehouse", null, new DateTime(2026, 2, 4, 21, 15, 45, 90, DateTimeKind.Local).AddTicks(6165), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Price", "ProductId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 21, 15, 43, 587, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 588, DateTimeKind.Unspecified).AddTicks(4916), new TimeSpan(0, 0, 0, 0, 0)), 150, "1", null, new DateTime(2026, 2, 4, 21, 15, 43, 588, DateTimeKind.Local).AddTicks(3869), 0 },
                    { "10", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3631), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3634), new TimeSpan(0, 0, 0, 0, 0)), 125, "6", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3632), 0 },
                    { "11", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3637), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3639), new TimeSpan(0, 0, 0, 0, 0)), 300, "7", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3638), 0 },
                    { "12", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3642), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 0, 0, 0, 0)), 50, "8", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3643), 0 },
                    { "13", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3648), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3650), new TimeSpan(0, 0, 0, 0, 0)), 400, "9", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3648), 0 },
                    { "14", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 0, 0, 0, 0)), 450, "10", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3654), 0 },
                    { "15", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3661), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3664), new TimeSpan(0, 0, 0, 0, 0)), 480, "10", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3662), 0 },
                    { "16", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3666), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 0, 0, 0, 0)), 280, "11", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3667), 0 },
                    { "17", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3672), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3674), new TimeSpan(0, 0, 0, 0, 0)), 200, "12", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3672), 0 },
                    { "18", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3677), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 0, 0, 0, 0)), 350, "13", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3677), 0 },
                    { "19", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3682), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3684), new TimeSpan(0, 0, 0, 0, 0)), 180, "14", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3682), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 0, 0, 0, 0)), 160, "1", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(1030), 0 },
                    { "20", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3687), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 0, 0, 0, 0)), 250, "15", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3687), 0 },
                    { "21", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3692), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3694), new TimeSpan(0, 0, 0, 0, 0)), 800, "16", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3693), 0 },
                    { "22", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3702), new TimeSpan(0, 0, 0, 0, 0)), 750, "16", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3698), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(2727), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(2745), new TimeSpan(0, 0, 0, 0, 0)), 140, "2", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(2730), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3569), new TimeSpan(0, 0, 0, 0, 0)), 145, "2", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3559), 0 },
                    { "5", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, 0, 0, 0, 0)), 80, "3", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3591), 0 },
                    { "6", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3597), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3611), new TimeSpan(0, 0, 0, 0, 0)), 250, "4", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3597), 0 },
                    { "7", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3615), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), 270, "4", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3616), 0 },
                    { "8", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 0, 0, 0, 0)), 180, "5", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3621), 0 },
                    { "9", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3626), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 589, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 0, 0, 0, 0)), 120, "6", null, new DateTime(2026, 2, 4, 21, 15, 43, 589, DateTimeKind.Local).AddTicks(3626), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "ShopId", "ShopName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 583, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "1", "Main Store", "Box", "4", 0 },
                    { "10", 60m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2522), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "2", "Branch Store", "Carton", "5", 0 },
                    { "11", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2550), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "3", "Warehouse", "Box", "4", 0 },
                    { "12", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "3", "Warehouse", "Carton", "5", 0 },
                    { "13", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2566), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "1", "Main Store", "Dozen", "10", 0 },
                    { "14", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "1", "Main Store", "Box", "4", 0 },
                    { "15", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2579), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "2", "Branch Store", "Dozen", "10", 0 },
                    { "16", 144m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "2", "Branch Store", "Box", "4", 0 },
                    { "17", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)), "9", "Pencil Set", "3", "Warehouse", "Carton", "5", 0 },
                    { "18", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2598), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "1", "Main Store", "Box", "4", 0 },
                    { "19", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "1", "Main Store", "Carton", "5", 0 },
                    { "2", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(191), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "1", "Main Store", "Carton", "5", 0 },
                    { "20", 10m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "2", "Branch Store", "Box", "4", 0 },
                    { "21", 25m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2625), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "2", "Branch Store", "Carton", "5", 0 },
                    { "22", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2631), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "3", "Warehouse", "Box", "4", 0 },
                    { "23", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "3", "Warehouse", "Carton", "5", 0 },
                    { "24", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "1", "Main Store", "Box", "4", 0 },
                    { "25", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "1", "Main Store", "Carton", "5", 0 },
                    { "26", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2658), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "2", "Branch Store", "Box", "4", 0 },
                    { "27", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2665), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "2", "Branch Store", "Carton", "5", 0 },
                    { "28", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2670), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "1", "Main Store", "Box", "4", 0 },
                    { "29", 200m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "1", "Main Store", "Carton", "5", 0 },
                    { "3", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(1600), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "1", "Main Store", "Box", "4", 0 },
                    { "30", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2684), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "3", "Warehouse", "Box", "4", 0 },
                    { "31", 100m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2690), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "3", "Warehouse", "Carton", "5", 0 },
                    { "4", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2444), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "1", "Main Store", "Carton", "5", 0 },
                    { "5", 6m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "2", "Branch Store", "Box", "4", 0 },
                    { "6", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2496), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "2", "Branch Store", "Carton", "5", 0 },
                    { "7", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2503), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "1", "Main Store", "Box", "4", 0 },
                    { "8", 48m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2510), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "1", "Main Store", "Carton", "5", 0 },
                    { "9", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 4, 16, 45, 43, 585, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "2", "Branch Store", "Box", "4", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 2, 4, 21, 15, 43, 591, DateTimeKind.Local).AddTicks(420), "Unchanged", new DateTime(2026, 8, 4, 16, 45, 43, 589, DateTimeKind.Utc).AddTicks(9559), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 1, 25, 16, 45, 43, 589, DateTimeKind.Utc).AddTicks(9414), "Active", "1", "Bottle", null, new DateTime(2026, 2, 4, 21, 15, 43, 591, DateTimeKind.Local).AddTicks(436), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 2, 4, 21, 15, 43, 592, DateTimeKind.Local).AddTicks(9608), "Unchanged", new DateTime(2026, 9, 4, 16, 45, 43, 592, DateTimeKind.Utc).AddTicks(9516), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 1, 30, 16, 45, 43, 592, DateTimeKind.Utc).AddTicks(9512), "Active", "1", "Bottle", null, new DateTime(2026, 2, 4, 21, 15, 43, 592, DateTimeKind.Local).AddTicks(9621), 0 },
                    { "3", "BS-101", null, new DateTime(2026, 2, 4, 21, 15, 43, 593, DateTimeKind.Local).AddTicks(3256), "Unchanged", new DateTime(2026, 5, 4, 16, 45, 43, 593, DateTimeKind.Utc).AddTicks(3224), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 1, 20, 16, 45, 43, 593, DateTimeKind.Utc).AddTicks(3220), "Active", "2", "Pack", null, new DateTime(2026, 2, 4, 21, 15, 43, 593, DateTimeKind.Local).AddTicks(3261), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 2, 4, 21, 15, 43, 593, DateTimeKind.Local).AddTicks(6143), "Unchanged", null, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 120000L, 200m, new DateTime(2026, 1, 15, 16, 45, 43, 593, DateTimeKind.Utc).AddTicks(6125), "Active", "3", "Piece", null, new DateTime(2026, 2, 4, 21, 15, 43, 593, DateTimeKind.Local).AddTicks(6146), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 4, 21, 15, 43, 594, DateTimeKind.Local).AddTicks(8576), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 4, 21, 15, 43, 594, DateTimeKind.Local).AddTicks(8581), 0 },
                    { "10", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8421), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8421), 0 },
                    { "2", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(291), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(296), 0 },
                    { "3", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(4224), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(4228), 0 },
                    { "4", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8248), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8252), 0 },
                    { "5", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8313), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8314), 0 },
                    { "6", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8347), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8348), 0 },
                    { "7", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8368), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "2", "Bottle", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8369), 0 },
                    { "8", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8385), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8386), 0 },
                    { "9", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8404), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "3", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 4, 21, 15, 43, 597, DateTimeKind.Local).AddTicks(8405), 0 }
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
                name: "IX_Customers_DistrictId",
                table: "Customers",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                table: "Customers",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IsActive",
                table: "Customers",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IsDeleted",
                table: "Customers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PhoneNumber",
                table: "Customers",
                column: "PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProvinceId",
                table: "Customers",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ShopId",
                table: "Customers",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TaxNumber",
                table: "Customers",
                column: "TaxNumber");

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
                name: "Customers");

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
                name: "Districts");

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
