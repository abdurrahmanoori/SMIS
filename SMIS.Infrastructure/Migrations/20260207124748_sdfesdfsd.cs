using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfesdfsd : Migration
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
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
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
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
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
                    { "1", "en", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 262, DateTimeKind.Unspecified).AddTicks(9308), new TimeSpan(0, 0, 0, 0, 0)), "English", 0 },
                    { "2", "ps", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 262, DateTimeKind.Unspecified).AddTicks(9594), new TimeSpan(0, 0, 0, 0, 0)), "Pashto", 0 },
                    { "3", "fa", "Added", true, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 262, DateTimeKind.Unspecified).AddTicks(9606), new TimeSpan(0, 0, 0, 0, 0)), "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7151), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7152), 0 },
                    { "2", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7272), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7284), new TimeSpan(0, 0, 0, 0, 0)), "Herat", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7272), 0 },
                    { "3", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7285), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7312), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7285), 0 },
                    { "4", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7313), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7318), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7313), 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 2, 7, 17, 17, 48, 265, DateTimeKind.Local).AddTicks(2135), "main@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 265, DateTimeKind.Unspecified).AddTicks(2184), new TimeSpan(0, 0, 0, 0, 0)), "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 2, 7, 17, 17, 48, 265, DateTimeKind.Local).AddTicks(2163), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 2, 7, 17, 17, 48, 267, DateTimeKind.Local).AddTicks(4228), "branch@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 267, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 2, 7, 17, 17, 48, 267, DateTimeKind.Local).AddTicks(4248), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 2, 7, 17, 17, 48, 267, DateTimeKind.Local).AddTicks(5598), "warehouse@store.local", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 267, DateTimeKind.Unspecified).AddTicks(5612), new TimeSpan(0, 0, 0, 0, 0)), "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 2, 7, 17, 17, 48, 267, DateTimeKind.Local).AddTicks(5601), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(1766), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(1784), new TimeSpan(0, 0, 0, 0, 0)), "1001", "Kabul Center District", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(1779), 0 },
                    { "2", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2074), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2076), new TimeSpan(0, 0, 0, 0, 0)), "1002", "Kabul North District", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2074), 0 },
                    { "3", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2078), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 0, 0, 0, 0)), "1003", "Herat Center District", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2078), 0 },
                    { "4", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2080), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2081), new TimeSpan(0, 0, 0, 0, 0)), "2001", "Kabul Province", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2080), 0 },
                    { "5", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2082), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2083), new TimeSpan(0, 0, 0, 0, 0)), "2002", "Herat Province", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2082), 0 },
                    { "6", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2084), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2085), new TimeSpan(0, 0, 0, 0, 0)), "3001", "Welcome Message", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2084), 0 },
                    { "7", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2086), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2087), new TimeSpan(0, 0, 0, 0, 0)), "3002", "Error Message", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2087), 0 },
                    { "8", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2088), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 0, 0, 0, 0)), "3003", "Success Message", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2088), 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "6f89d2f0-f4fd-4353-a252-c92cbab820e9", "superadmin@smis.com", true, "Unchanged", "Super", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEK4ugE66pZcdWtu89S8ptSMslgIwTJES3a1X5J7SzlT+Q4Qi5zW8Lvsh7tpegZnKbQ==", "+855123456789", true, "4e4fa79e-6bd3-420a-9c3a-47924de9fa1f", "1", "Main Store", false, "superadmin", 0 },
                    { "10", 0, "e01c2763-c1f5-412c-8a10-f462f8956f1b", "radministration@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAECK3CBTWGcrPF8urwUM63K9oUlADmPv+HJN/+bzeIzx+KcD/s45qIl0skiZS55Q39g==", "+855123456798", true, "64febf48-630b-4b53-b43a-a3617f4c923f", "2", "Branch Store", false, "radministration", 0 },
                    { "11", 0, "092196bb-dbb3-40a9-91df-9e741a16cf28", "rmanager@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEPOv2zGMBoUN4lJqHfoIAoDVU/bCVKNuCGtVjkPKN+WExTV833vKaH6tiQbt1X/gSQ==", "+855123456799", true, "891814a1-de99-4d55-800a-40588e2db391", "2", "Branch Store", false, "rmanager", 0 },
                    { "12", 0, "0988274e-684a-46ed-aeeb-2bac11e6f0f9", "rstaff@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEHgogvmMv/6NNUBM9fPpCmRL5Giix7067wS0sH+LB8dXpoALvcyNYSWauKkwO2mIBA==", "+855123456800", true, "789619d4-8cea-4d11-890a-16b87263d8d1", "2", "Branch Store", false, "rstaff", 0 },
                    { "13", 0, "bb13304a-158a-43ca-a6b8-67838c0a0673", "rviewer@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEKwsD8OrZlFc8rov+O90oJF3C1k7Eb9CEMmHs8u7j977WB0H7OU3A5BVz6Ov/JN65g==", "+855123456801", true, "b21ba7be-46fe-40e9-949d-eb72ca2da467", "2", "Branch Store", false, "rviewer", 0 },
                    { "14", 0, "e64a1380-9adb-49a2-8101-514048e5fc5f", "reditor@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAEPj453varMLLBVwI4UVZK6CbhA4oIGk05sUyQYMVqV5zMxz/NpnQ7oNXfYjH0dmSnQ==", "+855123456802", true, "dc5ec1c2-0b62-4d71-bed9-bf07929084bf", "2", "Branch Store", false, "reditor", 0 },
                    { "15", 0, "53c7ef50-4d26-4e57-b797-7315c2085ac1", "ruser@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEIr0hEn2CLMB4A5AlA5Q3vWAaqwxhvKzbPG6LePbUgD8+Ind46EFx62AlJKffy4lOA==", "+855123456803", true, "840083cf-bd4d-4dba-8ef9-417451a5244b", "2", "Branch Store", false, "ruser", 0 },
                    { "2", 0, "60fb0a22-0128-4bb4-8cac-5f8b8f800ed9", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEBvtv+rUXbHLG+1p3ZhvZfr8ZqWZUW5VgBakP3hvUAVQ1JyPdhmybK+0/Bw+5VrnJw==", "+855123456790", true, "7d580b14-3495-482d-bca4-d1f4916fccb7", "1", "Main Store", false, "wadmin", 0 },
                    { "3", 0, "22e8a1a9-2b45-46f3-9025-849fec4a1dc2", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAECPAbJ5I1F0pLkg7XsUtnmn/DXqJcpBN9EbFfXp7ctFRKqc7NQ2gSOn2i0NtCpHk9w==", "+855123456791", true, "3f46afba-758c-4241-96d0-67fb968a6f15", "1", "Main Store", false, "wadministration", 0 },
                    { "4", 0, "108f3d56-2208-4653-91e7-4c39981751df", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEIiNEAnFw2KsVv3iVZQUYyBY9EDESWu4CFYjSbEdwPPfuO58FT4Ddr+e3gNuuDPVsg==", "+855123456792", true, "fed554ef-c330-4607-b8d0-14db5266bc2e", "1", "Main Store", false, "wmanager", 0 },
                    { "5", 0, "e6d94301-a853-446f-bb2e-786be47d4ac9", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAENUHW38DDV9+V8m9QNYmHzzQXHM7NvqVSKM4v8dUNo7Zc3OZw5xeD3cABXujhmRcTQ==", "+855123456793", true, "b5b0efc7-e5f3-4e12-882e-c1f82cf111f9", "1", "Main Store", false, "wstaff", 0 },
                    { "6", 0, "800dc567-8f86-4277-90c9-8e4bbe29d7e9", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEKrTB3B5sDWkagJXSuqkJSzPvjqiFmCKiLyWzEZZ0iNCHDsDLZYqVIfISSoEsVytMw==", "+855123456794", true, "ef32b3b7-f59c-413d-b7bd-f797a05bf360", "1", "Main Store", false, "wviewer", 0 },
                    { "7", 0, "61403c49-8c33-48ed-8b58-2f5bf4ee7c2d", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEOsmCWI5v1CPap1Lxq+vMXPxgTGsSTjENTbeMsAW/QNXszZuWzfL30OpbMp0756jUQ==", "+855123456795", true, "350ef7fd-bcc3-4413-b4af-c4a328e8fe0b", "1", "Main Store", false, "weditor", 0 },
                    { "8", 0, "7fa005ca-473f-47a8-b032-9d336ce87e95", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEDGrlbpAsPYteM8RP226iqs+feCUluSaKotz3W9MGQ6TVUfeWXO1h7NPDg/D+UZMxA==", "+855123456796", true, "795efcaa-2cab-46a1-81c6-ea8b044752a3", "1", "Main Store", false, "wuser", 0 },
                    { "9", 0, "ca3c0c0a-4288-41f7-83fe-2aff5bbfe865", "radmin@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEK5zlCjQU65wGb3sIizBipmnRDsAzP+IAXanHb2WdapScg82RmtZ5sCQ2TdffvOR3g==", "+855123456797", true, "52d65e5d-8e89-48d8-a41e-807c31d9bdcd", "2", "Branch Store", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(5359), "Drinks and beverages", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 4, 30, 0, 0)), "Beverages", "1", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(5361), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4541), "Edible products and snacks", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4544), new TimeSpan(0, 4, 30, 0, 0)), "Food Items", "1", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4544), 0 },
                    { "3", "STAT", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4560), "Office and school supplies", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 4, 30, 0, 0)), "Stationery", "2", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4560), 0 },
                    { "4", "GROC", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4562), "Daily household items", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4562), new TimeSpan(0, 4, 30, 0, 0)), "Grocery", "2", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4562), 0 },
                    { "5", "CARE", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4563), "Health and hygiene products", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4563), new TimeSpan(0, 4, 30, 0, 0)), "Personal Care", "3", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4563), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4564), "Electronic devices and accessories", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4565), new TimeSpan(0, 4, 30, 0, 0)), "Electronics", "3", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4564), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(8985), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8989), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center", "1", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(8987), 0 },
                    { "2", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(9166), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(9168), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North", "2", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(9167), 0 },
                    { "3", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(9169), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center", "3", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(9170), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8124), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8125), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8110), new TimeSpan(0, 0, 0, 0, 0)), "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8112), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8113), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8115), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8119), new TimeSpan(0, 0, 0, 0, 0)), "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8121), new TimeSpan(0, 0, 0, 0, 0)), "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LanguageNo", "LastModifiedUtc", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(3987), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Center District", "1", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(3987), 0 },
                    { "10", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4340), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, 0, 0, 0, 0)), "ولایت هرات", "5", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4340), 0 },
                    { "11", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4342), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4343), new TimeSpan(0, 0, 0, 0, 0)), "Welcome Message", "6", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4342), 0 },
                    { "12", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4344), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 0, 0, 0, 0)), "پیام خوش آمدید", "6", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4344), 0 },
                    { "2", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4292), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز کابل", "1", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4292), 0 },
                    { "3", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4295), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4297), new TimeSpan(0, 0, 0, 0, 0)), "Kabul North District", "2", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4296), 0 },
                    { "4", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4297), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 0, 0, 0, 0)), "منطقه شمال کابل", "2", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4298), 0 },
                    { "5", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4299), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4301), new TimeSpan(0, 0, 0, 0, 0)), "Herat Center District", "3", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4300), 0 },
                    { "6", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4301), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4303), new TimeSpan(0, 0, 0, 0, 0)), "منطقه مرکز هرات", "3", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4302), 0 },
                    { "7", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4303), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4331), new TimeSpan(0, 0, 0, 0, 0)), "Kabul Province", "4", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4311), 0 },
                    { "8", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4332), "Unchanged", false, "2", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, 0, 0, 0, 0)), "ولایت کابل", "4", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4333), 0 },
                    { "9", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4338), "Unchanged", false, "1", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 0, 0, 0, 0)), "Herat Province", "5", null, new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4338), 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(1346), new TimeSpan(0, 0, 0, 0, 0)), "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, 0, 0, 0, 0)), "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(5177), new TimeSpan(0, 0, 0, 0, 0)), "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)), "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, 0, 0, 0, 0)), "Box", "1", "box", 0 },
                    { "5", "Large containers", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8220), new TimeSpan(0, 0, 0, 0, 0)), "Carton", "1", "ctn", 0 },
                    { "6", "Volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 0, 0, 0, 0)), "Liter", "1", "L", 0 },
                    { "7", "Weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8240), new TimeSpan(0, 0, 0, 0, 0)), "Kilogram", "1", "kg", 0 },
                    { "8", "Small weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8243), new TimeSpan(0, 0, 0, 0, 0)), "Gram", "1", "g", 0 },
                    { "9", "Small volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8252), new TimeSpan(0, 0, 0, 0, 0)), "Milliliter", "1", "ml", 0 }
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
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(8367), "Individual", null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 271, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 0, 0, 0, 0)), "Doe", "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(8370), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4473), "Individual", null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 0, 0, 0, 0)), "Rodriguez", "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4474), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(2970), "Individual", null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(2981), new TimeSpan(0, 0, 0, 0, 0)), "Smith", "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(2973), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(3853), "Enterprise", null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(3858), new TimeSpan(0, 0, 0, 0, 0)), "Brown", "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(3854), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4401), "Individual", null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)), "Wilson", "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4402), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4429), "Individual", null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 0, 0, 0, 0)), "Taylor", "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4429), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4437), "Enterprise", null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4438), new TimeSpan(0, 0, 0, 0, 0)), "Garcia", "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4437), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4445), "Individual", null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4446), new TimeSpan(0, 0, 0, 0, 0)), "Martinez", "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4446), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4452), "Individual", null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 0, 0, 0, 0)), "Lopez", "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4452), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4459), "Enterprise", null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 0, 0, 0, 0)), "Gonzalez", "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4460), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "Description", "EntityState", "ImageUrl", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 7, 17, 17, 48, 268, DateTimeKind.Local).AddTicks(5131), "Classic cola drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 268, DateTimeKind.Unspecified).AddTicks(5161), new TimeSpan(0, 0, 0, 0, 0)), "Coca Cola 500ml", "COKE-500ML-001", "1", "Main Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 268, DateTimeKind.Local).AddTicks(5139), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3140), "Sunflower cooking oil", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3141), new TimeSpan(0, 0, 0, 0, 0)), "Cooking Oil 1L", "OIL-1L-010", "1", "Main Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3140), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3146), "Basmati rice", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0)), "Rice 1kg", "RICE-1KG-011", "2", "Branch Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3146), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3152), "White granulated sugar", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3155), new TimeSpan(0, 0, 0, 0, 0)), "Sugar 1kg", "SUGAR-1KG-012", "3", "Warehouse", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3152), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3168), "Hair care shampoo", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3169), new TimeSpan(0, 0, 0, 0, 0)), "Shampoo 400ml", "SHAMP-400ML-013", "1", "Main Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3168), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3174), "Dental care paste", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3176), new TimeSpan(0, 0, 0, 0, 0)), "Toothpaste", "TOOTH-PASTE-014", "2", "Branch Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3175), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3181), "Type-C charging cable", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0)), "USB Cable", "USB-CABLE-015", "1", "Main Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3181), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3188), "Fast charging adapter", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)), "Phone Charger", "CHARGER-016", "3", "Warehouse", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3188), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(960), "Cola soft drink", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 0, 0, 0, 0)), "Pepsi 500ml", "PEPSI-500ML-002", "1", "Main Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(967), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(2199), "Pure drinking water", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(2205), new TimeSpan(0, 0, 0, 0, 0)), "Mineral Water 1L", "WATER-1L-003", "2", "Branch Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(2201), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3066), "Chocolate sandwich cookies", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3081), new TimeSpan(0, 0, 0, 0, 0)), "Oreo Biscuits", "OREO-PACK-004", "1", "Main Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3067), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3095), "Potato chips", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3097), new TimeSpan(0, 0, 0, 0, 0)), "Lay's Chips", "LAYS-PACK-005", "2", "Branch Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3095), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3104), "Quick meal noodles", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3105), new TimeSpan(0, 0, 0, 0, 0)), "Instant Noodles", "NOODLE-PACK-006", "3", "Warehouse", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3105), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3112), "200 pages ruled notebook", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3113), new TimeSpan(0, 0, 0, 0, 0)), "A4 Notebook", "NOTE-A4-007", "1", "Main Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3112), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3118), "Ballpoint pen", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3119), new TimeSpan(0, 0, 0, 0, 0)), "Blue Pen", "PEN-BLUE-008", "2", "Branch Store", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3118), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3123), "12 pencils per box", "Unchanged", null, true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3125), new TimeSpan(0, 0, 0, 0, 0)), "Pencil Set", "PENCIL-BOX-009", "3", "Warehouse", null, new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3124), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsPublic", "LastModifiedUtc", "LastName", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 2, 7, 17, 17, 47, 592, DateTimeKind.Local).AddTicks(1064), null, "john.doe@example.com", null, "Unchanged", "John", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 592, DateTimeKind.Unspecified).AddTicks(1074), new TimeSpan(0, 0, 0, 0, 0)), "Doe", "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 2, 7, 17, 17, 47, 592, DateTimeKind.Local).AddTicks(1061), null, new DateTime(2026, 2, 7, 17, 17, 47, 592, DateTimeKind.Local).AddTicks(1064), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 2, 7, 17, 17, 47, 598, DateTimeKind.Local).AddTicks(9604), null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 598, DateTimeKind.Unspecified).AddTicks(9661), new TimeSpan(0, 0, 0, 0, 0)), "Smith", "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 2, 7, 17, 17, 47, 598, DateTimeKind.Local).AddTicks(9592), null, new DateTime(2026, 2, 7, 17, 17, 47, 598, DateTimeKind.Local).AddTicks(9605), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 2, 7, 17, 17, 47, 599, DateTimeKind.Local).AddTicks(824), null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 599, DateTimeKind.Unspecified).AddTicks(851), new TimeSpan(0, 0, 0, 0, 0)), "Johnson", "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 2, 7, 17, 17, 47, 599, DateTimeKind.Local).AddTicks(821), null, new DateTime(2026, 2, 7, 17, 17, 47, 599, DateTimeKind.Local).AddTicks(824), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "ShopId", "ShopName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 586, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "1", "Main Store", "Box", "4", 0 },
                    { "10", 60m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6298), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "2", "Branch Store", "Carton", "5", 0 },
                    { "11", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6302), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "3", "Warehouse", "Box", "4", 0 },
                    { "12", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6308), new TimeSpan(0, 0, 0, 0, 0)), "6", "Instant Noodles", "3", "Warehouse", "Carton", "5", 0 },
                    { "13", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6314), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "1", "Main Store", "Dozen", "10", 0 },
                    { "14", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6319), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", "1", "Main Store", "Box", "4", 0 },
                    { "15", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6324), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "2", "Branch Store", "Dozen", "10", 0 },
                    { "16", 144m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 0, 0, 0, 0)), "8", "Blue Pen", "2", "Branch Store", "Box", "4", 0 },
                    { "17", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6333), new TimeSpan(0, 0, 0, 0, 0)), "9", "Pencil Set", "3", "Warehouse", "Carton", "5", 0 },
                    { "18", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6338), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "1", "Main Store", "Box", "4", 0 },
                    { "19", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6343), new TimeSpan(0, 0, 0, 0, 0)), "10", "Cooking Oil 1L", "1", "Main Store", "Carton", "5", 0 },
                    { "2", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(4608), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", "1", "Main Store", "Carton", "5", 0 },
                    { "20", 10m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6347), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "2", "Branch Store", "Box", "4", 0 },
                    { "21", 25m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 0, 0, 0, 0)), "11", "Rice 1kg", "2", "Branch Store", "Carton", "5", 0 },
                    { "22", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6358), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "3", "Warehouse", "Box", "4", 0 },
                    { "23", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6373), new TimeSpan(0, 0, 0, 0, 0)), "12", "Sugar 1kg", "3", "Warehouse", "Carton", "5", 0 },
                    { "24", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6379), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "1", "Main Store", "Box", "4", 0 },
                    { "25", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6383), new TimeSpan(0, 0, 0, 0, 0)), "13", "Shampoo 400ml", "1", "Main Store", "Carton", "5", 0 },
                    { "26", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6388), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "2", "Branch Store", "Box", "4", 0 },
                    { "27", 72m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6392), new TimeSpan(0, 0, 0, 0, 0)), "14", "Toothpaste", "2", "Branch Store", "Carton", "5", 0 },
                    { "28", 50m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "1", "Main Store", "Box", "4", 0 },
                    { "29", 200m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6402), new TimeSpan(0, 0, 0, 0, 0)), "15", "USB Cable", "1", "Main Store", "Carton", "5", 0 },
                    { "3", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(5774), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "1", "Main Store", "Box", "4", 0 },
                    { "30", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "3", "Warehouse", "Box", "4", 0 },
                    { "31", 100m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6411), new TimeSpan(0, 0, 0, 0, 0)), "16", "Phone Charger", "3", "Warehouse", "Carton", "5", 0 },
                    { "4", 24m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 0, 0, 0, 0)), "2", "Pepsi 500ml", "1", "Main Store", "Carton", "5", 0 },
                    { "5", 6m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6271), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "2", "Branch Store", "Box", "4", 0 },
                    { "6", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, 0, 0, 0, 0)), "3", "Mineral Water 1L", "2", "Branch Store", "Carton", "5", 0 },
                    { "7", 12m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6283), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "1", "Main Store", "Box", "4", 0 },
                    { "8", 48m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", "1", "Main Store", "Carton", "5", 0 },
                    { "9", 20m, "Added", new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6293), new TimeSpan(0, 0, 0, 0, 0)), "5", "Lay's Chips", "2", "Branch Store", "Box", "4", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(1632), "Unchanged", new DateTime(2026, 8, 7, 12, 47, 47, 589, DateTimeKind.Utc).AddTicks(9466), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 1, 28, 12, 47, 47, 589, DateTimeKind.Utc).AddTicks(9412), "Active", "2", "Bottle", null, new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(1634), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(5673), "Unchanged", new DateTime(2026, 9, 7, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(5661), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 2, 2, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(5657), "Active", "2", "Bottle", null, new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(5674), 0 },
                    { "3", "OREO-101", null, new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(6592), "Unchanged", new DateTime(2026, 5, 7, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(6582), false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 1, 23, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(6582), "Active", "3", "Pack", null, new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(6593), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(7254), "Unchanged", null, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", 120000L, 200m, new DateTime(2026, 1, 18, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(7248), "Active", "1", "Piece", null, new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(7254), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", 140L, null, new DateTime(2026, 2, 7, 17, 17, 47, 588, DateTimeKind.Local).AddTicks(5181), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(2881), new TimeSpan(0, 0, 0, 0, 0)), "1", "2", 160L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(2219), 0 },
                    { "10", 115L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 0, 0, 0, 0)), "6", "3", 135L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7150), 0 },
                    { "11", 280L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 0, 0, 0, 0)), "7", "1", 320L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7155), 0 },
                    { "12", 45L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 0, 0, 0, 0)), "8", "1", 55L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7159), 0 },
                    { "13", 380L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7163), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 0, 0, 0, 0)), "9", "4", 420L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7163), 0 },
                    { "14", 430L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 0, 0, 0, 0)), "10", "2", 470L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7167), 0 },
                    { "15", 460L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7176), new TimeSpan(0, 0, 0, 0, 0)), "10", "2", 500L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7173), 0 },
                    { "16", 260L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7180), new TimeSpan(0, 0, 0, 0, 0)), "11", "7", 300L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7177), 0 },
                    { "17", 180L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7184), new TimeSpan(0, 0, 0, 0, 0)), "12", "7", 220L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7181), 0 },
                    { "18", 330L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7188), new TimeSpan(0, 0, 0, 0, 0)), "13", "2", 370L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7185), 0 },
                    { "19", 160L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7189), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7192), new TimeSpan(0, 0, 0, 0, 0)), "14", "1", 200L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7189), 0 },
                    { "2", 150L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(5685), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 0, 0, 0, 0)), "1", "2", 170L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(5689), 0 },
                    { "20", 230L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7196), new TimeSpan(0, 0, 0, 0, 0)), "15", "1", 270L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7193), 0 },
                    { "21", 750L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7200), new TimeSpan(0, 0, 0, 0, 0)), "16", "1", 850L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7197), 0 },
                    { "22", 700L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7205), new TimeSpan(0, 0, 0, 0, 0)), "16", "1", 800L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7202), 0 },
                    { "3", 130L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(6658), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 0, 0, 0, 0)), "2", "2", 150L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(6660), 0 },
                    { "4", 135L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7114), new TimeSpan(0, 0, 0, 0, 0)), "2", "2", 155L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7109), 0 },
                    { "5", 70L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7124), new TimeSpan(0, 0, 0, 0, 0)), "3", "2", 90L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7121), 0 },
                    { "6", 230L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 0, 0, 0, 0)), "4", "3", 270L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7126), 0 },
                    { "7", 250L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7136), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7139), new TimeSpan(0, 0, 0, 0, 0)), "4", "3", 290L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7136), 0 },
                    { "8", 160L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7143), new TimeSpan(0, 0, 0, 0, 0)), "5", "3", 190L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7141), 0 },
                    { "9", 110L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7145), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unchanged", false, false, new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 0, 0, 0, 0)), "6", "3", 130L, null, new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7145), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(897), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(899), 0 },
                    { "10", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8198), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8198), 0 },
                    { "2", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(6280), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(6282), 0 },
                    { "3", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(7365), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(7366), 0 },
                    { "4", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8151), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8151), 0 },
                    { "5", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8163), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8163), 0 },
                    { "6", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8171), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8172), 0 },
                    { "7", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8178), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "4", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "3", "Pack", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8178), 0 },
                    { "8", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8184), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "1", "Piece", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8185), 0 },
                    { "9", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8191), "Unchanged", false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "7", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8192), 0 }
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
                name: "Customers");

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
                name: "Districts");

            migrationBuilder.DropTable(
                name: "ProductUnit");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
