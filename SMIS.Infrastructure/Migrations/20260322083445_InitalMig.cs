using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitalMig : Migration
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    Status = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    PaymentStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    PaymentMethod = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    { "1", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperAdmin", "SUPERADMIN", 0 },
                    { "10", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RShopAdministration", "RSHOPADMINISTRATION", 0 },
                    { "11", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RShopManager", "RSHOPMANAGER", 0 },
                    { "12", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RShopStaff", "RSHOPSTAFF", 0 },
                    { "13", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RShopViewer", "RSHOPVIEWER", 0 },
                    { "14", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RShopEditor", "RSHOPEDITOR", 0 },
                    { "15", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RShopUser", "RSHOPUSER", 0 },
                    { "2", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WShopAdmin", "WSHOPADMIN", 0 },
                    { "3", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WShopAdministration", "WSHOPADMINISTRATION", 0 },
                    { "4", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WShopManager", "WSHOPMANAGER", 0 },
                    { "5", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WShopStaff", "WSHOPSTAFF", 0 },
                    { "6", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WShopViewer", "WSHOPVIEWER", 0 },
                    { "7", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WShopEditor", "WSHOPEDITOR", 0 },
                    { "8", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WShopUser", "WSHOPUSER", 0 },
                    { "9", null, "Unchanged", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RShopAdmin", "RSHOPADMIN", 0 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "EntityState", "IsActive", "LastModifiedUtc", "Name", "Version" },
                values: new object[,]
                {
                    { "1", "en", "Added", true, new DateTime(2026, 3, 22, 8, 34, 44, 105, DateTimeKind.Utc).AddTicks(5877), "English", 0 },
                    { "2", "ps", "Added", true, new DateTime(2026, 3, 22, 8, 34, 44, 105, DateTimeKind.Utc).AddTicks(6724), "Pashto", 0 },
                    { "3", "fa", "Added", true, new DateTime(2026, 3, 22, 8, 34, 44, 105, DateTimeKind.Utc).AddTicks(6729), "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, "Unchanged", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kabul", null, null, 0 },
                    { "2", null, null, "Unchanged", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Herat", null, null, 0 },
                    { "3", null, null, "Unchanged", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kandahar", null, null, 0 },
                    { "4", null, null, "Unchanged", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Balkh", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "EntityState", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 3, 22, 13, 4, 44, 117, DateTimeKind.Local).AddTicks(3515), "main@store.local", "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 117, DateTimeKind.Utc).AddTicks(4309), null, "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 3, 22, 13, 4, 44, 117, DateTimeKind.Local).AddTicks(3950), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 3, 22, 13, 4, 44, 117, DateTimeKind.Local).AddTicks(7009), "branch@store.local", "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 118, DateTimeKind.Utc).AddTicks(183), null, "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 3, 22, 13, 4, 44, 117, DateTimeKind.Local).AddTicks(8773), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 3, 22, 13, 4, 44, 118, DateTimeKind.Local).AddTicks(2423), "warehouse@store.local", "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 118, DateTimeKind.Utc).AddTicks(4844), null, "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 3, 22, 13, 4, 44, 118, DateTimeKind.Local).AddTicks(3722), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, "Unchanged", true, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1001", "Kabul Center District", null, null, 0 },
                    { "2", null, null, "Unchanged", true, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1002", "Kabul North District", null, null, 0 },
                    { "3", null, null, "Unchanged", true, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1003", "Herat Center District", null, null, 0 },
                    { "4", null, null, "Unchanged", true, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2001", "Kabul Province", null, null, 0 },
                    { "5", null, null, "Unchanged", true, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2002", "Herat Province", null, null, 0 },
                    { "6", null, null, "Unchanged", true, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "3001", "Welcome Message", null, null, 0 },
                    { "7", null, null, "Unchanged", true, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "3002", "Error Message", null, null, 0 },
                    { "8", null, null, "Unchanged", true, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "3003", "Success Message", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "dca2c229-5e79-4831-a9e0-b29631a92591", "superadmin@smis.com", true, "Unchanged", "Super", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEGJS9iivfK98BGVqk0wIjX3bz64iG3k45SDVQUMyvs6GJyYYCDiAxfcgEe+wwj9elA==", "+855123456789", true, "88380c71-f73d-43b6-9c50-2b095c1d9899", "1", "Main Store", false, "superadmin", 0 },
                    { "10", 0, "abe1cd54-7406-4a41-8aac-5c903baf544d", "radministration@smis.com", true, "Unchanged", "Retail", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEMh6guSGj0GzCWrxIQYDNSaUoJxDu8A1TSSkVfSYTNoD3LCakcVhopp6LC4G+MKwug==", "+855123456798", true, "310fcd62-b2ff-473a-b777-40c08493343d", "2", "Branch Store", false, "radministration", 0 },
                    { "11", 0, "2d0f2f7e-6a12-48c5-8534-e3715f2723c4", "rmanager@smis.com", true, "Unchanged", "Retail", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAELooVSPwysNC+s1ocdO4Y9Ou9msOysGlCGV+nPG1stMHuVcxPMWzzdK6u7tJ+/NMIg==", "+855123456799", true, "5d3b1b59-3f1f-418d-ad79-f9215db3e0a1", "2", "Branch Store", false, "rmanager", 0 },
                    { "12", 0, "340746a8-4643-4110-afd3-b30994649d08", "rstaff@smis.com", true, "Unchanged", "Retail", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEJAHTlTxle6jjZG10mzg5WW8+/u3Nk1rY5fsvc7RBeMKsmRaxiVvm/a04k4MdMUDeA==", "+855123456800", true, "f4bca185-e282-43b1-87d4-08a3c96484ec", "2", "Branch Store", false, "rstaff", 0 },
                    { "13", 0, "44689f88-c74a-472d-b8ff-ff67597bf80f", "rviewer@smis.com", true, "Unchanged", "Retail", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEKtSIe3HfjP0A3H6Bvkbl8+kphmz0v/3CskRhKLOpId41d6HYoV4rtuHxufselLhcg==", "+855123456801", true, "0211fe31-440a-4bfb-a341-53c8e35ac220", "2", "Branch Store", false, "rviewer", 0 },
                    { "14", 0, "839bec84-a949-4ab2-8348-c34c177e36fb", "reditor@smis.com", true, "Unchanged", "Retail", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAECGjAOpCdinKjhPj8BGXvI4nE+G20fBhf/kt+aUk02acys/pbpkgF9FV+ET6gZWhwA==", "+855123456802", true, "b4285730-af2b-4c41-83a0-c9365cbd8106", "2", "Branch Store", false, "reditor", 0 },
                    { "15", 0, "c263e15e-93a3-4ac7-9368-8e10c05238ce", "ruser@smis.com", true, "Unchanged", "Retail", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEMn2V95QeqOBijQ4P2jLRDNUGzqno66c5R63FI/c3JlrSK6S6ZnybFIGhWDN9PeO4g==", "+855123456803", true, "5fc9afd5-d168-408b-ac81-f050e39f64df", "2", "Branch Store", false, "ruser", 0 },
                    { "2", 0, "862f14f1-9af7-439b-ad19-3a6cbf146072", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAECEXcMpPYbTtWJjOkaL8PzQaAEs6DLvcHX6t96wHg8sNNrcPLUM4LTc7qkjXS8eJ1w==", "+855123456790", true, "fb36c498-6061-4830-9823-9d21a047924e", "1", "Main Store", false, "wadmin", 0 },
                    { "3", 0, "ebc8abda-0403-4028-858c-3c1e720acdb4", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEHDHgB3Xud2/ttOeGg1jXZ3hinY0lq2EEw4fSLVHBHTBBYrIeKmvNMI/TK9UoTthMA==", "+855123456791", true, "84663bbc-c204-40ec-9aa8-c45d917cbd2a", "1", "Main Store", false, "wadministration", 0 },
                    { "4", 0, "dc30f1ec-016a-4acc-b558-27823ff3afaf", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEJEqFAl0m37LU2913Xtn+8KnpsTUPmRO66uLejz/aWKpg7t4yIakLs5u7XyUUn02AQ==", "+855123456792", true, "1d362023-3ea4-4f5a-8623-13a1a6bb4f3b", "1", "Main Store", false, "wmanager", 0 },
                    { "5", 0, "310d12c2-79da-454d-94dc-c14a28cce52a", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAECIlNBfGB+gANOGPZtfIFo2s78feMtzA9lY2lX2f9m+8s99J1KnB29/a/SmvUp8j5w==", "+855123456793", true, "fe15245e-c523-430c-ac4c-42f323deab34", "1", "Main Store", false, "wstaff", 0 },
                    { "6", 0, "006bebac-2bbb-4188-91d3-140997f63df0", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAECuXjRZQIzB9+IrGIY9+DC/Tx2zH2+EBDaFyY2/Ner75aAi63RDuGS9Auh7/dM1sdQ==", "+8512345634366", true, "c21571c7-5bc6-41a6-97b5-4e9944d4a8c6", "1", "Main Store", false, "wviewer", 0 },
                    { "7", 0, "5a5dcc02-e9cd-479b-8752-07643a6c676c", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEKI6Wlh+ROsSrp/F/59hpB+MppznCgWVVJY65Voaf73rooAqrf+Imslrp4B2G2mmJA==", "+855123456795", true, "d840c627-0504-4fec-a213-a171ed9544b9", "1", "Main Store", false, "weditor", 0 },
                    { "8", 0, "d3fd2bb3-27e4-4269-b0c5-6872b176f732", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEJsowrbD/jalTUc5P6Ddzijz6e4zaeUGbTsjQI6GUmo6k04jckRkXUSV9DLqXMFRMQ==", "+855123456796", true, "3b225d10-85e4-4ef0-b70e-06f750f27f5c", "1", "Main Store", false, "wuser", 0 },
                    { "9", 0, "effc4372-73c8-4b82-9de3-0561d0a2be7d", "radmin@smis.com", true, "Unchanged", "Retail", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAECvW6gIcrArLBK2Mbrn/U/4qTXkKyV14DuqAnFQcoQl1XgJK/4zjcaWwC8NYXryh6Q==", "+855123456797", true, "1c1e3874-51fc-48c7-9ea7-22e0edb378c0", "2", "Branch Store", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2315), "Drinks and beverages", "Unchanged", true, false, new DateTime(2026, 3, 22, 8, 34, 44, 126, DateTimeKind.Utc).AddTicks(2327), "Beverages", "1", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2324), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2354), "Edible products and snacks", "Unchanged", true, false, new DateTime(2026, 3, 22, 8, 34, 44, 126, DateTimeKind.Utc).AddTicks(2355), "Food Items", "1", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2354), 0 },
                    { "3", "STAT", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2368), "Office and school supplies", "Unchanged", true, false, new DateTime(2026, 3, 22, 8, 34, 44, 126, DateTimeKind.Utc).AddTicks(2370), "Stationery", "2", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2369), 0 },
                    { "4", "GROC", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2389), "Daily household items", "Unchanged", true, false, new DateTime(2026, 3, 22, 8, 34, 44, 126, DateTimeKind.Utc).AddTicks(2390), "Grocery", "2", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2390), 0 },
                    { "5", "CARE", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2396), "Health and hygiene products", "Unchanged", true, false, new DateTime(2026, 3, 22, 8, 34, 44, 126, DateTimeKind.Utc).AddTicks(2397), "Personal Care", "3", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2396), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2401), "Electronic devices and accessories", "Unchanged", true, false, new DateTime(2026, 3, 22, 8, 34, 44, 126, DateTimeKind.Utc).AddTicks(2402), "Electronics", "3", null, new DateTime(2026, 3, 22, 13, 4, 44, 126, DateTimeKind.Local).AddTicks(2402), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, "Unchanged", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kabul Center", "1", null, null, 0 },
                    { "2", null, null, "Unchanged", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kabul North", "2", null, null, 0 },
                    { "3", null, null, "Unchanged", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Herat Center", "3", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(4800), "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6100), "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6103), "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6106), "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6075), "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6079), "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6082), "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6085), "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6088), "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6090), "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6093), "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", new DateTime(2026, 3, 22, 8, 34, 44, 107, DateTimeKind.Utc).AddTicks(6095), "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "IsSyncedToServer", "LanguageNo", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, "Unchanged", false, true, "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kabul Center District", "1", null, null, 0 },
                    { "10", null, null, "Unchanged", false, true, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ولایت هرات", "5", null, null, 0 },
                    { "11", null, null, "Unchanged", false, true, "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Welcome Message", "6", null, null, 0 },
                    { "12", null, null, "Unchanged", false, true, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "پیام خوش آمدید", "6", null, null, 0 },
                    { "2", null, null, "Unchanged", false, true, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "منطقه مرکز کابل", "1", null, null, 0 },
                    { "3", null, null, "Unchanged", false, true, "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kabul North District", "2", null, null, 0 },
                    { "4", null, null, "Unchanged", false, true, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "منطقه شمال کابل", "2", null, null, 0 },
                    { "5", null, null, "Unchanged", false, true, "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Herat Center District", "3", null, null, 0 },
                    { "6", null, null, "Unchanged", false, true, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "منطقه مرکز هرات", "3", null, null, 0 },
                    { "7", null, null, "Unchanged", false, true, "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kabul Province", "4", null, null, 0 },
                    { "8", null, null, "Unchanged", false, true, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ولایت کابل", "4", null, null, 0 },
                    { "9", null, null, "Unchanged", false, true, "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Herat Province", "5", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(1804), "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(6162), "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(3263), "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(5058), "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(6111), "Box", "1", "box", 0 },
                    { "5", "Large containers", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(6119), "Carton", "1", "ctn", 0 },
                    { "6", "Volume measurement", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(6126), "Liter", "1", "L", 0 },
                    { "7", "Weight measurement", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(6137), "Kilogram", "1", "kg", 0 },
                    { "8", "Small weight measurement", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(6145), "Gram", "1", "g", 0 },
                    { "9", "Small volume measurement", "Added", new DateTime(2026, 3, 22, 8, 34, 44, 109, DateTimeKind.Utc).AddTicks(6152), "Milliliter", "1", "ml", 0 }
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
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "CustomerType", "DeletedAt", "DeletedBy", "DistrictId", "Email", "EntityState", "FatherName", "FirstName", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 3, 22, 13, 4, 44, 128, DateTimeKind.Local).AddTicks(7667), "Individual", null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 128, DateTimeKind.Utc).AddTicks(8247), "Doe", null, "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 3, 22, 13, 4, 44, 128, DateTimeKind.Local).AddTicks(7975), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8870), "Individual", null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 129, DateTimeKind.Utc).AddTicks(8878), "Rodriguez", null, "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8875), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(589), "Individual", null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 129, DateTimeKind.Utc).AddTicks(2472), "Smith", null, "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(1564), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(5358), "Enterprise", null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 129, DateTimeKind.Utc).AddTicks(7609), "Brown", null, "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(6538), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8669), "Individual", null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 129, DateTimeKind.Utc).AddTicks(8693), "Wilson", null, "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8687), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8726), "Individual", null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 129, DateTimeKind.Utc).AddTicks(8735), "Taylor", null, "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8731), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8756), "Enterprise", null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 129, DateTimeKind.Utc).AddTicks(8764), "Garcia", null, "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8761), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8781), "Individual", null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 129, DateTimeKind.Utc).AddTicks(8788), "Martinez", null, "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8785), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8806), "Individual", null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 129, DateTimeKind.Utc).AddTicks(8814), "Lopez", null, "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8810), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8843), "Enterprise", null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 129, DateTimeKind.Utc).AddTicks(8851), "Gonzalez", null, "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 3, 22, 13, 4, 44, 129, DateTimeKind.Local).AddTicks(8847), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "Description", "EntityState", "ImageUrl", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 22, 13, 4, 44, 123, DateTimeKind.Local).AddTicks(3770), "Classic cola drink", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 123, DateTimeKind.Utc).AddTicks(4347), null, "Coca Cola 500ml", "COKE-500ML-001", "1", "Main Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 123, DateTimeKind.Local).AddTicks(4087), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7611), "Sunflower cooking oil", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7619), null, "Cooking Oil 1L", "OIL-1L-010", "1", "Main Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7615), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7644), "Basmati rice", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7652), null, "Rice 1kg", "RICE-1KG-011", "2", "Branch Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7649), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7669), "White granulated sugar", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7707), null, "Sugar 1kg", "SUGAR-1KG-012", "3", "Warehouse", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7684), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7724), "Hair care shampoo", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7732), null, "Shampoo 400ml", "SHAMP-400ML-013", "1", "Main Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7729), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7749), "Dental care paste", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7757), null, "Toothpaste", "TOOTH-PASTE-014", "2", "Branch Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7754), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7775), "Type-C charging cable", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7783), null, "USB Cable", "USB-CABLE-015", "1", "Main Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7779), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7799), "Fast charging adapter", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7807), null, "Phone Charger", "CHARGER-016", "3", "Warehouse", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7803), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 22, 13, 4, 44, 123, DateTimeKind.Local).AddTicks(8143), "Cola soft drink", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(57), null, "Pepsi 500ml", "PEPSI-500ML-002", "1", "Main Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 123, DateTimeKind.Local).AddTicks(9094), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(3987), "Pure drinking water", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(6396), null, "Mineral Water 1L", "WATER-1L-003", "2", "Branch Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(5292), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7419), "Chocolate sandwich cookies", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7442), null, "Oreo Biscuits", "OREO-PACK-004", "1", "Main Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7436), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7468), "Potato chips", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7476), null, "Lay's Chips", "LAYS-PACK-005", "2", "Branch Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7473), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7507), "Quick meal noodles", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7515), null, "Instant Noodles", "NOODLE-PACK-006", "3", "Warehouse", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7511), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7533), "200 pages ruled notebook", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7540), null, "A4 Notebook", "NOTE-A4-007", "1", "Main Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7537), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7557), "Ballpoint pen", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7564), null, "Blue Pen", "PEN-BLUE-008", "2", "Branch Store", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7561), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7581), "12 pencils per box", "Unchanged", null, true, false, true, new DateTime(2026, 3, 22, 8, 34, 44, 124, DateTimeKind.Utc).AddTicks(7594), null, "Pencil Set", "PENCIL-BOX-009", "3", "Warehouse", null, new DateTime(2026, 3, 22, 13, 4, 44, 124, DateTimeKind.Local).AddTicks(7590), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 3, 22, 13, 4, 42, 655, DateTimeKind.Local).AddTicks(9131), null, "john.doe@example.com", null, "Unchanged", "John", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 655, DateTimeKind.Utc).AddTicks(9706), "Doe", null, "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(9376), null, new DateTime(2026, 3, 22, 13, 4, 42, 655, DateTimeKind.Local).AddTicks(9449), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 3, 22, 13, 4, 42, 656, DateTimeKind.Local).AddTicks(2095), null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 656, DateTimeKind.Utc).AddTicks(4019), "Smith", null, "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 3, 22, 13, 4, 42, 655, DateTimeKind.Local).AddTicks(9728), null, new DateTime(2026, 3, 22, 13, 4, 42, 656, DateTimeKind.Local).AddTicks(3069), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 3, 22, 13, 4, 42, 656, DateTimeKind.Local).AddTicks(7412), null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 656, DateTimeKind.Utc).AddTicks(9687), "Johnson", null, "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 3, 22, 13, 4, 42, 656, DateTimeKind.Local).AddTicks(5053), null, new DateTime(2026, 3, 22, 13, 4, 42, 656, DateTimeKind.Local).AddTicks(8608), 0 }
                });

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DueDate", "EntityState", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 3, 22, 13, 4, 42, 660, DateTimeKind.Local).AddTicks(8395), "1", "John", new DateTime(2026, 4, 21, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 660, DateTimeKind.Utc).AddTicks(8916), null, new DateTime(2026, 2, 20, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Coca Cola loan for John", 5000m, "1", "Coca Cola 500ml", 10m, "1", "Main Store", 1, 50000L, "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 660, DateTimeKind.Local).AddTicks(8646), 0 },
                    { "10", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6744), "9", "James", new DateTime(2026, 4, 18, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 662, DateTimeKind.Utc).AddTicks(6752), null, new DateTime(2026, 3, 19, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "USB cables for James", 1000m, "15", "USB Cable", 100m, "3", "Warehouse", 1, 100000L, "1", "Piece", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6748), 0 },
                    { "2", null, new DateTime(2026, 3, 22, 13, 4, 42, 661, DateTimeKind.Local).AddTicks(4432), "2", "Jane", new DateTime(2026, 4, 6, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 661, DateTimeKind.Utc).AddTicks(6339), null, new DateTime(2026, 3, 7, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Oreo biscuits for Jane", 4000m, "4", "Oreo Biscuits", 5m, "1", "Main Store", 1, 20000L, "3", "Pack", null, new DateTime(2026, 3, 22, 13, 4, 42, 661, DateTimeKind.Local).AddTicks(5468), 0 },
                    { "3", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(3053), "3", "Michael", new DateTime(2026, 4, 11, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 662, DateTimeKind.Utc).AddTicks(5395), null, new DateTime(2026, 3, 12, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Notebooks for Michael", 3000m, "7", "A4 Notebook", 20m, "1", "Main Store", 1, 60000L, "1", "Piece", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(4226), 0 },
                    { "4", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6519), "1", "John", new DateTime(2026, 5, 6, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 662, DateTimeKind.Utc).AddTicks(6543), null, new DateTime(2026, 3, 17, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Cooking oil bulk order", 8000m, "10", "Cooking Oil 1L", 15m, "1", "Main Store", 1, 120000L, "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6536), 0 },
                    { "5", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6574), "4", "Sarah", new DateTime(2026, 4, 1, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 662, DateTimeKind.Utc).AddTicks(6584), null, new DateTime(2026, 3, 2, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Pepsi for Sarah", 4500m, "2", "Pepsi 500ml", 24m, "2", "Branch Store", 1, 108000L, "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6580), 0 },
                    { "6", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6605), "5", "David", new DateTime(2026, 4, 9, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 662, DateTimeKind.Utc).AddTicks(6614), null, new DateTime(2026, 3, 10, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Blue pens for David", 500m, "8", "Blue Pen", 50m, "2", "Branch Store", 1, 25000L, "1", "Piece", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6610), 0 },
                    { "7", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6638), "6", "Lisa", null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 662, DateTimeKind.Utc).AddTicks(6646), null, new DateTime(2026, 2, 25, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Rice bulk purchase", 2000m, "11", "Rice 1kg", 100m, "2", "Branch Store", 1, 200000L, "7", "Kilogram", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6642), 0 },
                    { "8", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6683), "7", "Robert", new DateTime(2026, 4, 3, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 662, DateTimeKind.Utc).AddTicks(6692), null, new DateTime(2026, 3, 4, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Mineral water for Robert", 3000m, "3", "Mineral Water 1L", 48m, "3", "Warehouse", 1, 144000L, "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6687), 0 },
                    { "9", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6714), "8", "Emily", new DateTime(2026, 4, 13, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 662, DateTimeKind.Utc).AddTicks(6724), null, new DateTime(2026, 3, 14, 13, 4, 42, 657, DateTimeKind.Local).AddTicks(9023), "Instant noodles for Emily", 1500m, "6", "Instant Noodles", 30m, "3", "Warehouse", 1, 45000L, "3", "Pack", null, new DateTime(2026, 3, 22, 13, 4, 42, 662, DateTimeKind.Local).AddTicks(6719), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(3169), "1", "Coca Cola 500ml", "Bottle", "2", 0 },
                    { "10", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9716), "4", "Oreo Biscuits", "Pack", "3", 0 },
                    { "11", 12m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9735), "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "12", 48m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9743), "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "13", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9751), "5", "Lay's Chips", "Pack", "3", 0 },
                    { "14", 20m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9759), "5", "Lay's Chips", "Box", "4", 0 },
                    { "15", 60m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9767), "5", "Lay's Chips", "Carton", "5", 0 },
                    { "16", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9775), "6", "Instant Noodles", "Pack", "3", 0 },
                    { "17", 24m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9782), "6", "Instant Noodles", "Box", "4", 0 },
                    { "18", 72m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9791), "6", "Instant Noodles", "Carton", "5", 0 },
                    { "19", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9803), "7", "A4 Notebook", "Piece", "1", 0 },
                    { "2", 12m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(5232), "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "20", 12m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9812), "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "21", 50m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9819), "7", "A4 Notebook", "Box", "4", 0 },
                    { "22", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9827), "8", "Blue Pen", "Piece", "1", 0 },
                    { "23", 12m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9852), "8", "Blue Pen", "Dozen", "10", 0 },
                    { "24", 144m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9860), "8", "Blue Pen", "Box", "4", 0 },
                    { "25", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9868), "9", "Pencil Set", "Box", "4", 0 },
                    { "26", 20m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9875), "9", "Pencil Set", "Carton", "5", 0 },
                    { "27", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9887), "10", "Cooking Oil 1L", "Bottle", "2", 0 },
                    { "28", 12m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9894), "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "29", 24m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9902), "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "3", 24m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(7072), "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "30", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9910), "11", "Rice 1kg", "Kilogram", "7", 0 },
                    { "31", 10m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9917), "11", "Rice 1kg", "Box", "4", 0 },
                    { "32", 25m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9925), "11", "Rice 1kg", "Carton", "5", 0 },
                    { "33", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9933), "12", "Sugar 1kg", "Kilogram", "7", 0 },
                    { "34", 20m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9940), "12", "Sugar 1kg", "Box", "4", 0 },
                    { "35", 50m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9950), "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "36", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9958), "13", "Shampoo 400ml", "Bottle", "2", 0 },
                    { "37", 12m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9965), "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "38", 24m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9972), "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "39", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9980), "14", "Toothpaste", "Piece", "1", 0 },
                    { "4", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9656), "2", "Pepsi 500ml", "Bottle", "2", 0 },
                    { "40", 24m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9987), "14", "Toothpaste", "Box", "4", 0 },
                    { "41", 72m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9995), "14", "Toothpaste", "Carton", "5", 0 },
                    { "42", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 581, DateTimeKind.Utc).AddTicks(3), "15", "USB Cable", "Piece", "1", 0 },
                    { "43", 50m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 581, DateTimeKind.Utc).AddTicks(12), "15", "USB Cable", "Box", "4", 0 },
                    { "44", 200m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 581, DateTimeKind.Utc).AddTicks(19), "15", "USB Cable", "Carton", "5", 0 },
                    { "45", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 581, DateTimeKind.Utc).AddTicks(27), "16", "Phone Charger", "Piece", "1", 0 },
                    { "46", 20m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 581, DateTimeKind.Utc).AddTicks(34), "16", "Phone Charger", "Box", "4", 0 },
                    { "47", 100m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 581, DateTimeKind.Utc).AddTicks(42), "16", "Phone Charger", "Carton", "5", 0 },
                    { "5", 12m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9672), "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "6", 24m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9681), "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "7", 1m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9689), "3", "Mineral Water 1L", "Bottle", "2", 0 },
                    { "8", 6m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9697), "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "9", 12m, "Added", new DateTime(2026, 3, 22, 8, 34, 42, 580, DateTimeKind.Utc).AddTicks(9705), "3", "Mineral Water 1L", "Carton", "5", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 3, 22, 13, 4, 42, 626, DateTimeKind.Local).AddTicks(3638), "Unchanged", new DateTime(2026, 9, 22, 13, 4, 42, 624, DateTimeKind.Local).AddTicks(2772), false, new DateTime(2026, 3, 22, 8, 34, 42, 626, DateTimeKind.Utc).AddTicks(5138), "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 3, 12, 13, 4, 42, 624, DateTimeKind.Local).AddTicks(2772), "Active", "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 626, DateTimeKind.Local).AddTicks(4412), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 3, 22, 13, 4, 42, 626, DateTimeKind.Local).AddTicks(8512), "Unchanged", new DateTime(2026, 10, 22, 13, 4, 42, 624, DateTimeKind.Local).AddTicks(2772), false, new DateTime(2026, 3, 22, 8, 34, 42, 627, DateTimeKind.Utc).AddTicks(626), "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 3, 17, 13, 4, 42, 624, DateTimeKind.Local).AddTicks(2772), "Active", "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 626, DateTimeKind.Local).AddTicks(9588), 0 },
                    { "3", "OREO-101", null, new DateTime(2026, 3, 22, 13, 4, 42, 627, DateTimeKind.Local).AddTicks(4041), "Unchanged", new DateTime(2026, 6, 22, 13, 4, 42, 624, DateTimeKind.Local).AddTicks(2772), false, new DateTime(2026, 3, 22, 8, 34, 42, 627, DateTimeKind.Utc).AddTicks(6418), "4", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 3, 7, 13, 4, 42, 624, DateTimeKind.Local).AddTicks(2772), "Active", "3", "Pack", null, new DateTime(2026, 3, 22, 13, 4, 42, 627, DateTimeKind.Local).AddTicks(5294), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 3, 22, 13, 4, 42, 627, DateTimeKind.Local).AddTicks(7482), "Unchanged", null, false, new DateTime(2026, 3, 22, 8, 34, 42, 627, DateTimeKind.Utc).AddTicks(7503), "7", "A4 Notebook", 120000L, 200m, new DateTime(2026, 3, 2, 13, 4, 42, 624, DateTimeKind.Local).AddTicks(2772), "Active", "1", "Piece", null, new DateTime(2026, 3, 22, 13, 4, 42, 627, DateTimeKind.Local).AddTicks(7497), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", 140L, null, new DateTime(2026, 3, 22, 13, 4, 42, 585, DateTimeKind.Local).AddTicks(5793), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 622, DateTimeKind.Utc).AddTicks(8049), null, "1", "1", 160L, null, new DateTime(2026, 3, 22, 13, 4, 42, 622, DateTimeKind.Local).AddTicks(7313), 0 },
                    { "10", 230L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7812), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7820), null, "4", "10", 270L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7816), 0 },
                    { "11", 2760L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7827), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7834), null, "4", "11", 3240L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7830), 0 },
                    { "12", 11040L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7842), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7850), null, "4", "12", 12960L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7846), 0 },
                    { "13", 160L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7862), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7869), null, "5", "13", 190L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7865), 0 },
                    { "14", 3200L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7876), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7883), null, "5", "14", 3800L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7880), 0 },
                    { "15", 9600L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7935), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7943), null, "5", "15", 11400L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7940), 0 },
                    { "16", 110L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7951), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7958), null, "6", "16", 130L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7955), 0 },
                    { "17", 2640L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7965), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7973), null, "6", "17", 3120L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7969), 0 },
                    { "18", 7920L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7981), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7989), null, "6", "18", 9360L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7985), 0 },
                    { "19", 280L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7997), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8004), null, "7", "19", 320L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8001), 0 },
                    { "2", 1680L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(337), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(2375), null, "1", "2", 1920L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(1441), 0 },
                    { "20", 3360L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8011), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8019), null, "7", "20", 3840L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8015), 0 },
                    { "21", 14000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8029), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8037), null, "7", "21", 16000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8033), 0 },
                    { "22", 45L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8059), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8067), null, "8", "22", 55L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8063), 0 },
                    { "23", 540L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8074), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8083), null, "8", "23", 660L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8078), 0 },
                    { "24", 6480L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8090), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8097), null, "8", "24", 7920L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8093), 0 },
                    { "25", 380L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8104), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8112), null, "9", "25", 420L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8108), 0 },
                    { "26", 7600L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8119), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8127), null, "9", "26", 8400L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8123), 0 },
                    { "27", 430L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8134), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8142), null, "10", "27", 470L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8138), 0 },
                    { "28", 5160L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8149), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8156), null, "10", "28", 5640L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8152), 0 },
                    { "29", 10320L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8168), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8176), null, "10", "29", 11280L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8172), 0 },
                    { "3", 3360L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(4208), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(6650), null, "1", "3", 3840L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(5535), 0 },
                    { "30", 260L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8184), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8192), null, "11", "30", 300L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8188), 0 },
                    { "31", 2600L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8199), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8206), null, "11", "31", 3000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8203), 0 },
                    { "32", 6500L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8215), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8223), null, "11", "32", 7500L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8219), 0 },
                    { "33", 180L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8230), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8237), null, "12", "33", 220L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8234), 0 },
                    { "34", 3600L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8252), null, "12", "34", 4400L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8248), 0 },
                    { "35", 9000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8259), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8266), null, "12", "35", 11000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8263), 0 },
                    { "36", 330L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8274), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8282), null, "13", "36", 370L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8278), 0 },
                    { "37", 3960L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8301), null, "13", "37", 4440L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8298), 0 },
                    { "38", 7920L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8312), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8319), null, "13", "38", 8880L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8315), 0 },
                    { "39", 160L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8327), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8335), null, "14", "39", 200L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8331), 0 },
                    { "4", 130L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7685), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7709), null, "2", "4", 150L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7702), 0 },
                    { "40", 3840L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8349), null, "14", "40", 4800L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8345), 0 },
                    { "41", 11520L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8369), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8377), null, "14", "41", 14400L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8373), 0 },
                    { "42", 230L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8392), null, "15", "42", 270L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8389), 0 },
                    { "43", 11500L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8399), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8407), null, "15", "43", 13500L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8403), 0 },
                    { "44", 46000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8422), null, "15", "44", 54000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8417), 0 },
                    { "45", 750L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8433), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8440), null, "16", "45", 850L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8436), 0 },
                    { "46", 15000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8447), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8455), null, "16", "46", 17000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8451), 0 },
                    { "47", 75000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8462), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(8469), null, "16", "47", 85000L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(8465), 0 },
                    { "5", 1560L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7734), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7743), null, "2", "5", 1800L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7739), 0 },
                    { "6", 3120L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7758), null, "2", "6", 3600L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7754), 0 },
                    { "7", 70L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7766), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7774), null, "3", "7", 90L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7770), 0 },
                    { "8", 420L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7781), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7790), null, "3", "8", 540L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7786), 0 },
                    { "9", 840L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7797), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTime(2026, 3, 22, 8, 34, 42, 623, DateTimeKind.Utc).AddTicks(7805), null, "3", "9", 1080L, null, new DateTime(2026, 3, 22, 13, 4, 42, 623, DateTimeKind.Local).AddTicks(7801), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 3, 22, 13, 4, 42, 630, DateTimeKind.Local).AddTicks(6100), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 630, DateTimeKind.Utc).AddTicks(6591), "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 630, DateTimeKind.Local).AddTicks(6359), 0 },
                    { "10", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(717), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 632, DateTimeKind.Utc).AddTicks(726), "7", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(722), 0 },
                    { "2", null, new DateTime(2026, 3, 22, 13, 4, 42, 631, DateTimeKind.Local).AddTicks(37), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 631, DateTimeKind.Utc).AddTicks(1855), "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 631, DateTimeKind.Local).AddTicks(975), 0 },
                    { "3", null, new DateTime(2026, 3, 22, 13, 4, 42, 631, DateTimeKind.Local).AddTicks(6281), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 631, DateTimeKind.Utc).AddTicks(8761), "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 631, DateTimeKind.Local).AddTicks(7510), 0 },
                    { "4", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(299), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 632, DateTimeKind.Utc).AddTicks(379), "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(332), 0 },
                    { "5", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(468), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 632, DateTimeKind.Utc).AddTicks(499), "4", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(484), 0 },
                    { "6", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(590), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 632, DateTimeKind.Utc).AddTicks(609), "4", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(603), 0 },
                    { "7", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(635), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 632, DateTimeKind.Utc).AddTicks(644), "4", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "3", "Pack", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(640), 0 },
                    { "8", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(661), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 632, DateTimeKind.Utc).AddTicks(670), "7", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "1", "Piece", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(666), 0 },
                    { "9", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(685), "Unchanged", false, new DateTime(2026, 3, 22, 8, 34, 42, 632, DateTimeKind.Utc).AddTicks(694), "7", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 3, 22, 13, 4, 42, 632, DateTimeKind.Local).AddTicks(690), 0 }
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
