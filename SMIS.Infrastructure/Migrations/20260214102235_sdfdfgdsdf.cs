using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfdfgdsdf : Migration
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
                name: "ShopOwner",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    NationalIdCardNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    OwnershipPercentage = table.Column<decimal>(type: "TEXT", precision: 5, scale: 2, nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    table.PrimaryKey("PK_ShopOwner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopOwner_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopOwner_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    BaseUnitId = table.Column<string>(type: "TEXT", nullable: false),
                    BaseUnitName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    SKU = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Barcode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    CategoryId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
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
                    CustomerType = table.Column<string>(type: "TEXT", nullable: false),
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
                name: "LoanAccount",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", precision: 18, scale: 2, nullable: false),
                    UnitId = table.Column<string>(type: "TEXT", nullable: false),
                    UnitName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    PriceAtLoanTime = table.Column<decimal>(type: "TEXT", precision: 18, scale: 2, nullable: false),
                    TotalAmount = table.Column<long>(type: "INTEGER", nullable: false),
                    LoanDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
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
                    table.PrimaryKey("PK_LoanAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanAccount_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanAccount_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanAccount_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanAccount_UnitOfMeasure_UnitId",
                        column: x => x.UnitId,
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
                    ProductUnitId = table.Column<string>(type: "TEXT", nullable: false),
                    BuyPrice = table.Column<long>(type: "INTEGER", nullable: false),
                    SellPrice = table.Column<long>(type: "INTEGER", nullable: false),
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
                        name: "FK_ProductPrice_ProductUnit_ProductUnitId",
                        column: x => x.ProductUnitId,
                        principalTable: "ProductUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "LoanAccountPayment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    LoanAccountId = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<long>(type: "INTEGER", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PaymentMethod = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
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
                    table.PrimaryKey("PK_LoanAccountPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanAccountPayment_LoanAccount_LoanAccountId",
                        column: x => x.LoanAccountId,
                        principalTable: "LoanAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { "1", "en", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 0, 0, 0, 0)), "English", 0 },
                    { "2", "ps", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, 0, 0, 0, 0)), "Pashto", 0 },
                    { "3", "fa", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 0, 0, 0, 0)), "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3144), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3149), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3145), 0 },
                    { "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3266), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 0, 0, 0, 0)), "Herat", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3267), 0 },
                    { "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3269), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3270), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3269), 0 },
                    { "4", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3271), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3272), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(3271), 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 2, 14, 14, 52, 34, 817, DateTimeKind.Local).AddTicks(4281), "main@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(4293), new TimeSpan(0, 0, 0, 0, 0)), "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 2, 14, 14, 52, 34, 817, DateTimeKind.Local).AddTicks(4286), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 2, 14, 14, 52, 34, 818, DateTimeKind.Local).AddTicks(5568), "branch@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 818, DateTimeKind.Unspecified).AddTicks(5587), new TimeSpan(0, 0, 0, 0, 0)), "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 2, 14, 14, 52, 34, 818, DateTimeKind.Local).AddTicks(5574), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 2, 14, 14, 52, 34, 818, DateTimeKind.Local).AddTicks(6422), "warehouse@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 818, DateTimeKind.Unspecified).AddTicks(6428), new TimeSpan(0, 0, 0, 0, 0)), "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 2, 14, 14, 52, 34, 818, DateTimeKind.Local).AddTicks(6423), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(7761), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(7788), new TimeSpan(0, 0, 0, 0, 0)), "1001", "Kabul Center District", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(7778), 0 },
                    { "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8087), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 0, 0, 0, 0)), "1002", "Kabul North District", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8087), 0 },
                    { "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8090), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8091), new TimeSpan(0, 0, 0, 0, 0)), "1003", "Herat Center District", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8091), 0 },
                    { "4", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8092), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, 0, 0, 0, 0)), "2001", "Kabul Province", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8093), 0 },
                    { "5", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8095), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8096), new TimeSpan(0, 0, 0, 0, 0)), "2002", "Herat Province", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8095), 0 },
                    { "6", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8097), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8098), new TimeSpan(0, 0, 0, 0, 0)), "3001", "Welcome Message", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8097), 0 },
                    { "7", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8099), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 0, 0, 0, 0)), "3002", "Error Message", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8099), 0 },
                    { "8", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8101), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 815, DateTimeKind.Unspecified).AddTicks(8102), new TimeSpan(0, 0, 0, 0, 0)), "3003", "Success Message", null, new DateTime(2026, 2, 14, 14, 52, 34, 815, DateTimeKind.Local).AddTicks(8101), 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "79c7668b-e8c6-41a2-9bd0-54e748d4e94a", "superadmin@smis.com", true, "Unchanged", "Super", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEOBoq3Ga15ooMg7TtMXEp3HkLoonywKMaetZ67spqh8PTs/P7S3h5nLKiubcMpUlzg==", "+855123456789", true, "5aadcb02-3bd2-4e4c-ade9-f69fb9f18544", "1", "Main Store", false, "superadmin", 0 },
                    { "10", 0, "a17616e9-95b5-4b9a-b125-c45fe4b9d4e8", "radministration@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEFrhzUq/jT2NfKJQBivWJJEn8CpgTXaSDMDB/hWB0HG8mMYq0etSEmNZHJ6x3up+Xw==", "+855123456798", true, "b9e1c66f-426a-4b04-aecb-b530acedad17", "2", "Branch Store", false, "radministration", 0 },
                    { "11", 0, "36024d27-8650-4fa9-bf5c-c507914a3bda", "rmanager@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAELmj32453UiePxVQu73h+HoUboYCIrwcNwnXvgGLToDep8eKlB09VDdEg1mxhlbALQ==", "+855123456799", true, "002f786f-05ef-40e9-b696-3c03b12b4b44", "2", "Branch Store", false, "rmanager", 0 },
                    { "12", 0, "af827a92-35f0-4188-843c-941f0d7bb4b0", "rstaff@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAELk85C44Of126McAZtNLrHQjYDJbCPy9kj+89U57F/dnVTNOf7B5YHom4iOodWyfOw==", "+855123456800", true, "cbfbac7a-71e5-47cf-b399-ecf4858038f2", "2", "Branch Store", false, "rstaff", 0 },
                    { "13", 0, "aef8a159-5db1-4e34-ab15-6dddab6f31c6", "rviewer@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEHAokqPF9u3Tk1ayMWCbblTeTOEYK7kfZnzCL0WGoE5CRQxfvaOKE29I1Ah27gEidg==", "+855123456801", true, "9faf0d5d-01d5-41a8-83bf-0bc92431fca4", "2", "Branch Store", false, "rviewer", 0 },
                    { "14", 0, "5bb220bc-2fa7-4c11-9f76-cf073bf04312", "reditor@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAEJgyyplPPpF6Zfkl3WHoBeJ2Djcol5BLJ/qC5P068OjesNdp6XiZu51RJHLActZWSg==", "+855123456802", true, "df13aaf5-d9c0-480f-b2be-d188c277d244", "2", "Branch Store", false, "reditor", 0 },
                    { "15", 0, "833da268-e4e2-4334-8e45-860e00e8df8a", "ruser@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEOwwbuVwep+r0PynA3Eih8swW1lqurbqFy5neabP7lo01AD36hfToB6KH9x9aZ7cOw==", "+855123456803", true, "5090af3f-cabf-45a2-987e-39a71fbc88d1", "2", "Branch Store", false, "ruser", 0 },
                    { "2", 0, "b65e18e2-eb7b-4abb-a9d7-b51f4ef40df2", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEBpmjE2AFIClbEc95+aHQsde2TVbnbSzqnII8wcmNQZc5bj5LwXtW+cpoPXNAPqKCg==", "+855123456790", true, "bafa2f29-44ca-41c5-af13-e6da48ef4ef8", "1", "Main Store", false, "wadmin", 0 },
                    { "3", 0, "c1a184d0-a35a-4544-b6dd-f5056ee24ff0", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEFfLv7CDUT/ldyr3tIMpt95BbPQEQgCmHbcfuccf8yVleMjh3f7Y1+ccecHmD5CIyA==", "+855123456791", true, "dc2d4ebf-86da-4c7e-b5ff-8c9295c0cc59", "1", "Main Store", false, "wadministration", 0 },
                    { "4", 0, "03fbf0b4-6350-4af1-96c1-e288de71d1d2", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEEbGdfKv1pcZhNd8cGGzpaF1WThjYc1i9qXyiBlCl949ghh4+lnYtik3yPYTOohiLQ==", "+855123456792", true, "6fb93298-a240-47d3-b405-e439012ee6d0", "1", "Main Store", false, "wmanager", 0 },
                    { "5", 0, "3b87ea56-47b3-44e2-bb30-1a2d42a65f68", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAENt0Hl+PP8bdYNLWbcL2r6spfzEuj2tw0ls0is55bzK80yo1JqECVp2aGWnk2KA0/g==", "+855123456793", true, "d92e5e6f-3c6c-44af-8e71-041c3fe25b30", "1", "Main Store", false, "wstaff", 0 },
                    { "6", 0, "0ed2702e-8ffb-4d36-9e9d-c4221ad67050", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEJFmiyMAHnP6jCLAqrFSpo1MbTyz1PxCcuJiND3IVEoAdzc2qJDz+BqZRs0xXL5C5g==", "+8512345634366", true, "f351e8fa-8b67-4fb8-bd2e-5e070185234a", "1", "Main Store", false, "wviewer", 0 },
                    { "7", 0, "562f501a-8508-44c4-a1ba-e2e85d935282", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEJ8P0piSif4kbHbYY5eD6aNgAoeOeX5hAiRNi+Inr0kJ2c51OJZzhtzGr0B0RDPoTg==", "+855123456795", true, "48afbac9-4462-430a-b5af-cf2ea31a7bfe", "1", "Main Store", false, "weditor", 0 },
                    { "8", 0, "7434af74-c1f8-46b4-b40a-bb578f9418dc", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAELYuGsLKrZQLVA7kq23zyNg8bq7hx+7aYZQAZTU6yOXFYZPQ378xJM8k8dYnXoHb/w==", "+855123456796", true, "f3436cc3-f9a4-465b-b254-e042cbaaff2f", "1", "Main Store", false, "wuser", 0 },
                    { "9", 0, "34874119-d6cf-4441-adad-a620543a653b", "radmin@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEIJ/3ZVPgJJzU/dqe6v7Te5pvo+G+8CAEDfeh2rKZ7SIbkZILAk1sZd8Jub79cj03Q==", "+855123456797", true, "a7cde6f6-ae03-43c0-b0ed-2a6bdc0e14fd", "2", "Branch Store", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(8272), "Drinks and beverages", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Unspecified).AddTicks(8293), new TimeSpan(0, 4, 30, 0, 0)), "Beverages", "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(8273), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7016), "Edible products and snacks", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7018), new TimeSpan(0, 4, 30, 0, 0)), "Food Items", "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7018), 0 },
                    { "3", "STAT", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7031), "Office and school supplies", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 4, 30, 0, 0)), "Stationery", "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7031), 0 },
                    { "4", "GROC", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7033), "Daily household items", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7034), new TimeSpan(0, 4, 30, 0, 0)), "Grocery", "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7033), 0 },
                    { "5", "CARE", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7034), "Health and hygiene products", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7035), new TimeSpan(0, 4, 30, 0, 0)), "Personal Care", "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7034), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7036), "Electronic devices and accessories", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Unspecified).AddTicks(7036), new TimeSpan(0, 4, 30, 0, 0)), "Electronics", "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 821, DateTimeKind.Local).AddTicks(7036), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(4943), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4946), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center", "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(4944), 0 },
                    { "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(5105), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(5107), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North", "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(5105), 0 },
                    { "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(5108), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(5109), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center", "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(5108), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(3699), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4101), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4051), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4089), new TimeSpan(0, 0, 0, 0, 0)), "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4090), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4095), new TimeSpan(0, 0, 0, 0, 0)), "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(4098), new TimeSpan(0, 0, 0, 0, 0)), "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LanguageNo", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(20), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(37), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center District", "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(21), 0 },
                    { "10", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(329), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 0, 0, 0, 0)), "ولایت هرات", "5", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(329), 0 },
                    { "11", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(331), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 0, 0, 0, 0)), "Welcome Message", "6", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(331), 0 },
                    { "12", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(333), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(334), new TimeSpan(0, 0, 0, 0, 0)), "پیام خوش آمدید", "6", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(333), 0 },
                    { "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(276), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(279), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز کابل", "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(277), 0 },
                    { "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(280), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(281), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North District", "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(280), 0 },
                    { "4", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(282), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 0, 0, 0, 0)), "منطقه شمال کابل", "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(282), 0 },
                    { "5", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(284), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(285), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center District", "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(284), 0 },
                    { "6", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(287), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(288), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز هرات", "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(287), 0 },
                    { "7", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(289), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(322), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Province", "4", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(301), 0 },
                    { "8", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(323), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 0, 0, 0, 0)), "ولایت کابل", "4", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(324), 0 },
                    { "9", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(325), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(328), new TimeSpan(0, 0, 0, 0, 0)), "Herat Province", "5", null, new DateTime(2026, 2, 14, 14, 52, 34, 816, DateTimeKind.Local).AddTicks(326), 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 816, DateTimeKind.Unspecified).AddTicks(7208), new TimeSpan(0, 0, 0, 0, 0)), "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1900), new TimeSpan(0, 0, 0, 0, 0)), "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(386), new TimeSpan(0, 0, 0, 0, 0)), "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1426), new TimeSpan(0, 0, 0, 0, 0)), "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 0, 0, 0, 0)), "Box", "1", "box", 0 },
                    { "5", "Large containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1878), new TimeSpan(0, 0, 0, 0, 0)), "Carton", "1", "ctn", 0 },
                    { "6", "Volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), "Liter", "1", "L", 0 },
                    { "7", "Weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 0, 0, 0, 0)), "Kilogram", "1", "kg", 0 },
                    { "8", "Small weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1891), new TimeSpan(0, 0, 0, 0, 0)), "Gram", "1", "g", 0 },
                    { "9", "Small volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 817, DateTimeKind.Unspecified).AddTicks(1893), new TimeSpan(0, 0, 0, 0, 0)), "Milliliter", "1", "ml", 0 }
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
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "CustomerType", "DeletedAt", "DeletedBy", "DistrictId", "Email", "EntityState", "FatherName", "FirstName", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "LastName", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(517), "Individual", null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(531), new TimeSpan(0, 0, 0, 0, 0)), "Doe", "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(519), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6423), "Individual", null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 0, 0, 0, 0)), "Rodriguez", "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6423), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(4779), "Individual", null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(4787), new TimeSpan(0, 0, 0, 0, 0)), "Smith", "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(4781), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(5775), "Enterprise", null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 0, 0, 0, 0)), "Brown", "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(5777), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6353), "Individual", null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6355), new TimeSpan(0, 0, 0, 0, 0)), "Wilson", "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6353), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6375), "Individual", null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6380), new TimeSpan(0, 0, 0, 0, 0)), "Taylor", "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6375), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6386), "Enterprise", null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6388), new TimeSpan(0, 0, 0, 0, 0)), "Garcia", "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6387), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6395), "Individual", null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 0, 0, 0, 0)), "Martinez", "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6395), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6409), "Individual", null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6410), new TimeSpan(0, 0, 0, 0, 0)), "Lopez", "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6409), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6417), "Enterprise", null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 822, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 0, 0, 0, 0)), "Gonzalez", "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 2, 14, 14, 52, 34, 822, DateTimeKind.Local).AddTicks(6417), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "Description", "EntityState", "ImageUrl", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 14, 14, 52, 34, 819, DateTimeKind.Local).AddTicks(1026), "Classic cola drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 819, DateTimeKind.Unspecified).AddTicks(1035), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "COKE-500ML-001", "1", "Main Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 819, DateTimeKind.Local).AddTicks(1028), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6219), "Sunflower cooking oil", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "OIL-1L-010", "1", "Main Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6220), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6225), "Basmati rice", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6232), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "RICE-1KG-011", "2", "Branch Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6226), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6244), "White granulated sugar", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6245), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "SUGAR-1KG-012", "3", "Warehouse", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6244), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6250), "Hair care shampoo", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "SHAMP-400ML-013", "1", "Main Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6250), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6257), "Dental care paste", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6259), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "TOOTH-PASTE-014", "2", "Branch Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6258), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6263), "Type-C charging cable", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6265), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "USB-CABLE-015", "1", "Main Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6264), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6269), "Fast charging adapter", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "CHARGER-016", "3", "Warehouse", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6270), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(4089), "Cola soft drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(4102), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "PEPSI-500ML-002", "1", "Main Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(4093), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(5281), "Pure drinking water", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(5287), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "WATER-1L-003", "2", "Branch Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(5283), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6115), "Chocolate sandwich cookies", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6118), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "OREO-PACK-004", "1", "Main Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6116), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6139), "Potato chips", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6145), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "LAYS-PACK-005", "2", "Branch Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6140), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6191), "Quick meal noodles", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6193), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "NOODLE-PACK-006", "3", "Warehouse", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6192), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6199), "200 pages ruled notebook", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6200), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "NOTE-A4-007", "1", "Main Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6199), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6207), "Ballpoint pen", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6208), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "PEN-BLUE-008", "2", "Branch Store", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6207), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6213), "12 pencils per box", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 820, DateTimeKind.Unspecified).AddTicks(6214), new TimeSpan(0, 0, 0, 0, 0)), "Pencil Set", "PENCIL-BOX-009", "3", "Warehouse", null, new DateTime(2026, 2, 14, 14, 52, 34, 820, DateTimeKind.Local).AddTicks(6213), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsPublic", "LastModifiedUtc", "LastName", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(5186), null, "john.doe@example.com", null, "Unchanged", "John", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 238, DateTimeKind.Unspecified).AddTicks(5196), new TimeSpan(0, 0, 0, 0, 0)), "Doe", "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(5183), null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(5187), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 245, DateTimeKind.Local).AddTicks(9363), null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 245, DateTimeKind.Unspecified).AddTicks(9411), new TimeSpan(0, 0, 0, 0, 0)), "Smith", "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 2, 14, 14, 52, 34, 245, DateTimeKind.Local).AddTicks(9348), null, new DateTime(2026, 2, 14, 14, 52, 34, 245, DateTimeKind.Local).AddTicks(9365), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(299), null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 246, DateTimeKind.Unspecified).AddTicks(310), new TimeSpan(0, 0, 0, 0, 0)), "Johnson", "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(298), null, new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(300), 0 }
                });

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DueDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(7268), "1", "John", new DateTime(2026, 3, 16, 10, 22, 34, 246, DateTimeKind.Utc).AddTicks(4791), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 246, DateTimeKind.Unspecified).AddTicks(7294), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 15, 10, 22, 34, 246, DateTimeKind.Utc).AddTicks(4778), "Coca Cola loan for John", 5000m, "1", "Coca Cola 500ml", 10m, "1", "Main Store", "Active", 50000L, "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 246, DateTimeKind.Local).AddTicks(7273), 0 },
                    { "10", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6797), "9", "James", new DateTime(2026, 3, 13, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6797), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6800), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 11, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6796), "USB cables for James", 1000m, "15", "USB Cable", 100m, "3", "Warehouse", "Active", 100000L, "1", "Piece", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6798), 0 },
                    { "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(3444), "2", "Jane", new DateTime(2026, 3, 1, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(3428), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(3456), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 30, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(3427), "Oreo biscuits for Jane", 4000m, "4", "Oreo Biscuits", 5m, "1", "Main Store", "Active", 20000L, "3", "Pack", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(3446), 0 },
                    { "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(5298), "3", "Michael", new DateTime(2026, 3, 6, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(5294), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(5312), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(5292), "Notebooks for Michael", 3000m, "7", "A4 Notebook", 20m, "1", "Main Store", "Active", 60000L, "1", "Piece", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(5301), 0 },
                    { "4", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6707), "1", "John", new DateTime(2026, 3, 31, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6705), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6718), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6704), "Cooking oil bulk order", 8000m, "10", "Cooking Oil 1L", 15m, "1", "Main Store", "Active", 120000L, "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6709), 0 },
                    { "5", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6736), "4", "Sarah", new DateTime(2026, 2, 24, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6735), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 25, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6734), "Pepsi for Sarah", 4500m, "2", "Pepsi 500ml", 24m, "2", "Branch Store", "Active", 108000L, "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6736), 0 },
                    { "6", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6756), "5", "David", new DateTime(2026, 3, 4, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6755), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6755), "Blue pens for David", 500m, "8", "Blue Pen", 50m, "2", "Branch Store", "Active", 25000L, "1", "Piece", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6756), 0 },
                    { "7", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6766), "6", "Lisa", null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6769), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 20, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6765), "Rice bulk purchase", 2000m, "11", "Rice 1kg", 100m, "2", "Branch Store", "Active", 200000L, "7", "Kilogram", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6766), 0 },
                    { "8", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6777), "7", "Robert", new DateTime(2026, 2, 26, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6776), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 27, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6776), "Mineral water for Robert", 3000m, "3", "Mineral Water 1L", 48m, "3", "Warehouse", "Active", 144000L, "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6777), 0 },
                    { "9", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6787), "8", "Emily", new DateTime(2026, 3, 8, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6787), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 247, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 6, 10, 22, 34, 247, DateTimeKind.Utc).AddTicks(6786), "Instant noodles for Emily", 1500m, "6", "Instant Noodles", 30m, "3", "Warehouse", "Active", 45000L, "3", "Pack", null, new DateTime(2026, 2, 14, 14, 52, 34, 247, DateTimeKind.Local).AddTicks(6788), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 231, DateTimeKind.Unspecified).AddTicks(8794), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "Bottle", "2", 0 },
                    { "10", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6074), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "Pack", "3", 0 },
                    { "11", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "12", 48m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6083), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "13", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6087), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "Pack", "3", 0 },
                    { "14", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6093), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "Box", "4", 0 },
                    { "15", 60m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6097), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "Carton", "5", 0 },
                    { "16", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6101), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "Pack", "3", 0 },
                    { "17", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "Box", "4", 0 },
                    { "18", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6110), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "Carton", "5", 0 },
                    { "19", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "Piece", "1", 0 },
                    { "2", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(4703), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "20", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6119), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "21", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6123), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "Box", "4", 0 },
                    { "22", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6128), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "Piece", "1", 0 },
                    { "23", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6132), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "Dozen", "10", 0 },
                    { "24", 144m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6137), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "Box", "4", 0 },
                    { "25", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 0, 0, 0, 0)), "9", "Pencil Set", "Box", "4", 0 },
                    { "26", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6145), new TimeSpan(0, 0, 0, 0, 0)), "9", "Pencil Set", "Carton", "5", 0 },
                    { "27", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6149), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "Bottle", "2", 0 },
                    { "28", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6153), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "29", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6157), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "3", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "30", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6170), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "Kilogram", "7", 0 },
                    { "31", 10m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6175), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "Box", "4", 0 },
                    { "32", 25m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "Carton", "5", 0 },
                    { "33", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6184), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "Kilogram", "7", 0 },
                    { "34", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6188), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "Box", "4", 0 },
                    { "35", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6192), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "36", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6196), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "Bottle", "2", 0 },
                    { "37", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6200), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "38", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6206), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "39", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "Piece", "1", 0 },
                    { "4", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6035), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "Bottle", "2", 0 },
                    { "40", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6214), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "Box", "4", 0 },
                    { "41", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6218), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "Carton", "5", 0 },
                    { "42", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6222), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "Piece", "1", 0 },
                    { "43", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "Box", "4", 0 },
                    { "44", 200m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6230), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "Carton", "5", 0 },
                    { "45", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6234), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "Piece", "1", 0 },
                    { "46", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6239), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "Box", "4", 0 },
                    { "47", 100m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6243), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "Carton", "5", 0 },
                    { "5", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6045), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "6", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "7", 1m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6061), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "Bottle", "2", 0 },
                    { "8", 6m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6065), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "9", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 232, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "Carton", "5", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(2622), "Unchanged", new DateTime(2026, 8, 14, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(369), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 2, 4, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(311), "Active", "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(2624), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(7135), "Unchanged", new DateTime(2026, 9, 14, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(7121), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 2, 9, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(7120), "Active", "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(7137), 0 },
                    { "3", "OREO-101", null, new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(8246), "Unchanged", new DateTime(2026, 5, 14, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(8237), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 1, 30, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(8236), "Active", "3", "Pack", null, new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(8246), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(8974), "Unchanged", null, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", 120000L, 200m, new DateTime(2026, 1, 25, 10, 22, 34, 236, DateTimeKind.Utc).AddTicks(8969), "Active", "1", "Piece", null, new DateTime(2026, 2, 14, 14, 52, 34, 236, DateTimeKind.Local).AddTicks(8975), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", 140L, null, new DateTime(2026, 2, 14, 14, 52, 34, 233, DateTimeKind.Local).AddTicks(8902), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)), "1", "1", 160L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(1129), 0 },
                    { "10", 230L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7479), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)), "4", "10", 270L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7479), 0 },
                    { "11", 2760L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7485), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)), "4", "11", 3240L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7485), 0 },
                    { "12", 11040L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7494), new TimeSpan(0, 0, 0, 0, 0)), "4", "12", 12960L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7490), 0 },
                    { "13", 160L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7500), new TimeSpan(0, 0, 0, 0, 0)), "5", "13", 190L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7495), 0 },
                    { "14", 3200L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7505), new TimeSpan(0, 0, 0, 0, 0)), "5", "14", 3800L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7502), 0 },
                    { "15", 9600L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7509), new TimeSpan(0, 0, 0, 0, 0)), "5", "15", 11400L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7507), 0 },
                    { "16", 110L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7514), new TimeSpan(0, 0, 0, 0, 0)), "6", "16", 130L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7511), 0 },
                    { "17", 2640L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 0, 0, 0, 0)), "6", "17", 3120L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7515), 0 },
                    { "18", 7920L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7519), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 0, 0, 0, 0)), "6", "18", 9360L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7520), 0 },
                    { "19", 280L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, 0, 0, 0, 0)), "7", "19", 320L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7524), 0 },
                    { "2", 1680L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, 0, 0, 0, 0)), "1", "2", 1920L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(5712), 0 },
                    { "20", 3360L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7528), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7531), new TimeSpan(0, 0, 0, 0, 0)), "7", "20", 3840L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7529), 0 },
                    { "21", 14000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7533), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 0, 0, 0, 0)), "7", "21", 16000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7533), 0 },
                    { "22", 45L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 0, 0, 0, 0)), "8", "22", 55L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7539), 0 },
                    { "23", 540L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7554), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0)), "8", "23", 660L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7557), 0 },
                    { "24", 6480L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7561), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7564), new TimeSpan(0, 0, 0, 0, 0)), "8", "24", 7920L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7562), 0 },
                    { "25", 380L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7566), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 0, 0, 0, 0)), "9", "25", 420L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7566), 0 },
                    { "26", 7600L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7570), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7573), new TimeSpan(0, 0, 0, 0, 0)), "9", "26", 8400L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7571), 0 },
                    { "27", 430L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7578), new TimeSpan(0, 0, 0, 0, 0)), "10", "27", 470L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7575), 0 },
                    { "28", 5160L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7579), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 0, 0, 0, 0)), "10", "28", 5640L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7579), 0 },
                    { "29", 10320L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7583), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 0, 0, 0, 0)), "10", "29", 11280L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7584), 0 },
                    { "3", 3360L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(6914), new TimeSpan(0, 0, 0, 0, 0)), "1", "3", 3840L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(6905), 0 },
                    { "30", 260L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7589), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7592), new TimeSpan(0, 0, 0, 0, 0)), "11", "30", 300L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7589), 0 },
                    { "31", 2600L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7593), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7596), new TimeSpan(0, 0, 0, 0, 0)), "11", "31", 3000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7594), 0 },
                    { "32", 6500L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7597), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7601), new TimeSpan(0, 0, 0, 0, 0)), "11", "32", 7500L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7598), 0 },
                    { "33", 180L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7602), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 0, 0, 0, 0)), "12", "33", 220L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7602), 0 },
                    { "34", 3600L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7606), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7609), new TimeSpan(0, 0, 0, 0, 0)), "12", "34", 4400L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7607), 0 },
                    { "35", 9000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7611), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 0, 0, 0, 0)), "12", "35", 11000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7611), 0 },
                    { "36", 330L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7618), new TimeSpan(0, 0, 0, 0, 0)), "13", "36", 370L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7615), 0 },
                    { "37", 3960L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7619), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7623), new TimeSpan(0, 0, 0, 0, 0)), "13", "37", 4440L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7620), 0 },
                    { "38", 7920L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7625), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7628), new TimeSpan(0, 0, 0, 0, 0)), "13", "38", 8880L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7625), 0 },
                    { "39", 160L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7629), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7632), new TimeSpan(0, 0, 0, 0, 0)), "14", "39", 200L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7629), 0 },
                    { "4", 130L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7426), new TimeSpan(0, 0, 0, 0, 0)), "2", "4", 150L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7421), 0 },
                    { "40", 3840L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7633), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)), "14", "40", 4800L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7634), 0 },
                    { "41", 11520L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7638), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7641), new TimeSpan(0, 0, 0, 0, 0)), "14", "41", 14400L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7638), 0 },
                    { "42", 230L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7642), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7645), new TimeSpan(0, 0, 0, 0, 0)), "15", "42", 270L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7642), 0 },
                    { "43", 11500L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7646), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7649), new TimeSpan(0, 0, 0, 0, 0)), "15", "43", 13500L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7647), 0 },
                    { "44", 46000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)), "15", "44", 54000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7651), 0 },
                    { "45", 750L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7655), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), "16", "45", 850L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7655), 0 },
                    { "46", 15000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7663), new TimeSpan(0, 0, 0, 0, 0)), "16", "46", 17000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7661), 0 },
                    { "47", 75000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7665), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7668), new TimeSpan(0, 0, 0, 0, 0)), "16", "47", 85000L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7665), 0 },
                    { "5", 1560L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7441), new TimeSpan(0, 0, 0, 0, 0)), "2", "5", 1800L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7431), 0 },
                    { "6", 3120L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7447), new TimeSpan(0, 0, 0, 0, 0)), "2", "6", 3600L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7443), 0 },
                    { "7", 70L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7448), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7451), new TimeSpan(0, 0, 0, 0, 0)), "3", "7", 90L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7449), 0 },
                    { "8", 420L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7453), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7456), new TimeSpan(0, 0, 0, 0, 0)), "3", "8", 540L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7453), 0 },
                    { "9", 840L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 14, 10, 22, 34, 235, DateTimeKind.Unspecified).AddTicks(7461), new TimeSpan(0, 0, 0, 0, 0)), "3", "9", 1080L, null, new DateTime(2026, 2, 14, 14, 52, 34, 235, DateTimeKind.Local).AddTicks(7458), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 14, 14, 52, 34, 237, DateTimeKind.Local).AddTicks(3649), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 237, DateTimeKind.Local).AddTicks(3650), 0 },
                    { "10", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1933), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1933), 0 },
                    { "2", null, new DateTime(2026, 2, 14, 14, 52, 34, 237, DateTimeKind.Local).AddTicks(9670), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 237, DateTimeKind.Local).AddTicks(9672), 0 },
                    { "3", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(925), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(926), 0 },
                    { "4", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1877), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1878), 0 },
                    { "5", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1893), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1894), 0 },
                    { "6", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1902), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1902), 0 },
                    { "7", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1909), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "3", "Pack", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1909), 0 },
                    { "8", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1915), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "1", "Piece", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1916), 0 },
                    { "9", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1923), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 2, 14, 14, 52, 34, 238, DateTimeKind.Local).AddTicks(1923), 0 }
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
                name: "IX_LoanAccount_CustomerId",
                table: "LoanAccount",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_ProductId",
                table: "LoanAccount",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_ShopId",
                table: "LoanAccount",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_UnitId",
                table: "LoanAccount",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccountPayment_LoanAccountId",
                table: "LoanAccountPayment",
                column: "LoanAccountId");

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
                name: "IX_ProductPrice_ProductId_ProductUnitId_EffectiveDate",
                table: "ProductPrice",
                columns: new[] { "ProductId", "ProductUnitId", "EffectiveDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductUnitId",
                table: "ProductPrice",
                column: "ProductUnitId");

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
                name: "IX_ShopOwner_ApplicationUserId",
                table: "ShopOwner",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOwner_IsActive",
                table: "ShopOwner",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOwner_ShopId",
                table: "ShopOwner",
                column: "ShopId");

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
                name: "LoanAccountPayment");

            migrationBuilder.DropTable(
                name: "ProductPrice");

            migrationBuilder.DropTable(
                name: "ProvinceTranslations");

            migrationBuilder.DropTable(
                name: "ShopOwner");

            migrationBuilder.DropTable(
                name: "StockTransaction");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "LoanAccount");

            migrationBuilder.DropTable(
                name: "ProductUnit");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "StockBatch");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "UnitOfMeasure");

            migrationBuilder.DropTable(
                name: "TranslationKeys");

            migrationBuilder.DropTable(
                name: "Shop");
        }
    }
}
