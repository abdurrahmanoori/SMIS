using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class intia : Migration
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false)
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false)
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false)
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false)
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false)
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
                    LastModifiedUtc = table.Column<string>(type: "TEXT", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    { "1", null, "Unchanged", "0001-01-01 00:00:00.000000", "SuperAdmin", "SUPERADMIN", 0 },
                    { "10", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopAdministration", "RSHOPADMINISTRATION", 0 },
                    { "11", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopManager", "RSHOPMANAGER", 0 },
                    { "12", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopStaff", "RSHOPSTAFF", 0 },
                    { "13", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopViewer", "RSHOPVIEWER", 0 },
                    { "14", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopEditor", "RSHOPEDITOR", 0 },
                    { "15", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopUser", "RSHOPUSER", 0 },
                    { "2", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopAdmin", "WSHOPADMIN", 0 },
                    { "3", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopAdministration", "WSHOPADMINISTRATION", 0 },
                    { "4", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopManager", "WSHOPMANAGER", 0 },
                    { "5", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopStaff", "WSHOPSTAFF", 0 },
                    { "6", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopViewer", "WSHOPVIEWER", 0 },
                    { "7", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopEditor", "WSHOPEDITOR", 0 },
                    { "8", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopUser", "WSHOPUSER", 0 },
                    { "9", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopAdmin", "RSHOPADMIN", 0 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "EntityState", "IsActive", "LastModifiedUtc", "Name", "Version" },
                values: new object[,]
                {
                    { "1", "en", "Added", true, "2026-03-26 17:43:10.869768", "English", 0 },
                    { "2", "ps", "Added", true, "2026-03-26 17:43:10.869858", "Pashto", 0 },
                    { "3", "fa", "Added", true, "2026-03-26 17:43:10.869858", "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-03-26 22:13:10.871675", null, "Kabul", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-03-26 22:13:10.871712", null, "Herat", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-03-26 22:13:10.871714", null, "Kandahar", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2026-03-26 22:13:10.871714", null, "Balkh", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedAt", "Email", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 3, 26, 22, 13, 10, 876, DateTimeKind.Local).AddTicks(7862), null, "main@store.local", "Unchanged", true, false, false, true, "2026-03-26 22:13:10.876814", null, "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 3, 26, 22, 13, 10, 876, DateTimeKind.Local).AddTicks(8026), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 3, 26, 22, 13, 10, 876, DateTimeKind.Local).AddTicks(9301), null, "branch@store.local", "Unchanged", true, false, false, true, "2026-03-26 22:13:10.877137", null, "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 3, 26, 22, 13, 10, 877, DateTimeKind.Local).AddTicks(393), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 3, 26, 22, 13, 10, 877, DateTimeKind.Local).AddTicks(3153), null, "warehouse@store.local", "Unchanged", true, false, false, true, "2026-03-26 22:13:10.877662", null, "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 3, 26, 22, 13, 10, 877, DateTimeKind.Local).AddTicks(5336), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", true, false, false, true, "2026-03-26 22:13:10.870311", null, "1001", "Kabul Center District", null, null, 0 },
                    { "2", null, null, null, "Unchanged", true, false, false, true, "2026-03-26 22:13:10.870406", null, "1002", "Kabul North District", null, null, 0 },
                    { "3", null, null, null, "Unchanged", true, false, false, true, "2026-03-26 22:13:10.870407", null, "1003", "Herat Center District", null, null, 0 },
                    { "4", null, null, null, "Unchanged", true, false, false, true, "2026-03-26 22:13:10.870407", null, "2001", "Kabul Province", null, null, 0 },
                    { "5", null, null, null, "Unchanged", true, false, false, true, "2026-03-26 22:13:10.870408", null, "2002", "Herat Province", null, null, 0 },
                    { "6", null, null, null, "Unchanged", true, false, false, true, "2026-03-26 22:13:10.870408", null, "3001", "Welcome Message", null, null, 0 },
                    { "7", null, null, null, "Unchanged", true, false, false, true, "2026-03-26 22:13:10.870408", null, "3002", "Error Message", null, null, 0 },
                    { "8", null, null, null, "Unchanged", true, false, false, true, "2026-03-26 22:13:10.870408", null, "3003", "Success Message", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "4548da0e-7b80-465b-8932-45d2d143f971", "superadmin@smis.com", true, "Unchanged", "Super", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEMaWN4ozSqRTDio+vxzIr3M1uicO6aYXXA37JIQ7F0fcBaIzE7cq7OXH46zEDYmwhw==", "+855123456789", true, "e26fd31a-b6d0-465f-b58b-75ba6214af70", "1", "Main Store", false, "superadmin", 0 },
                    { "10", 0, "5e2c20ef-dfce-411a-8df5-0eb01930a2ec", "radministration@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEDfWhwXgjIT6E19ZhcaZcL3mAPJ/LpdB7VkHsFhlgeHFqDJ00jbhcYKZ/yWuHWD3cA==", "+855123456798", true, "65dc33e5-f802-40fe-90f8-c4fa4c596bc7", "2", "Branch Store", false, "radministration", 0 },
                    { "11", 0, "2c656cc8-1c09-43ff-b9f7-adfb9a0780da", "rmanager@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEBAYwO4T+Uh8Bnf/nGQrMVFxvEJIX9i0wGutXEN4sBq81ylEk94OwgQUkAp8RX3cVQ==", "+855123456799", true, "de517230-ee9e-4655-98c0-ff118b47d078", "2", "Branch Store", false, "rmanager", 0 },
                    { "12", 0, "a26f3ab6-6d42-4083-8e9f-947f54ec8ff8", "rstaff@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEB9/mQZ3mESR8UkmWLDXak/ebHlzQT3rMqsPeZ5D/jTHdZl6MyF6mbevnurwma8/nQ==", "+855123456800", true, "6fe203e5-e30f-4b48-9f56-56ebc26a58de", "2", "Branch Store", false, "rstaff", 0 },
                    { "13", 0, "79bee118-c748-4a4b-a1e0-c4fd8a4307a8", "rviewer@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAECdsdiMLd7WLJD2a58hoV5fi0yzrXI9I0bUPDsKV9C1t6tqeui/3OrgDKoUBf1vEUg==", "+855123456801", true, "136716a1-aeb3-4404-80ee-1b1d23b47c02", "2", "Branch Store", false, "rviewer", 0 },
                    { "14", 0, "0cf0943d-f1e0-43c9-b609-88c4ed837d30", "reditor@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAEKYbthAiMbOZqvI8cw1eDjpKR20Fp7x0VCBOwXgvitgOTuKeAGXdgv+89VbgVrDtMg==", "+855123456802", true, "0cf14372-0d25-4444-b209-1b72018bd0d2", "2", "Branch Store", false, "reditor", 0 },
                    { "15", 0, "75ff7c5a-56dd-4380-bde4-14ef531ce996", "ruser@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEFQM9Rg9Blt0hKAZ3ETtLMWJY22qkU8mj4QkvrSzr1b6zPJHxSakL/LKYZb1UPwkUg==", "+855123456803", true, "41b99eca-b2ee-45d0-8225-4e1ed8f18d96", "2", "Branch Store", false, "ruser", 0 },
                    { "2", 0, "fd9dd81f-55ac-44c8-92a6-42cca167954f", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEHBNI+pPhCoW1yFU5RczpgY8Q3qi0hVsPOTUSEDyP7FAEKzGAJ2Dq9uMlym4z9B9ow==", "+855123456790", true, "aff9dc50-06d5-43c9-a636-84641608d9cf", "1", "Main Store", false, "wadmin", 0 },
                    { "3", 0, "da667b74-7d2e-48cc-9fb5-f23357eebbfa", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEKZkCZa+Xo4+OiUeipwv1ZoBvbbrl8a6R6Esvoneh22LrJ3GZ0dM4E4a16ehypjMVQ==", "+855123456791", true, "1b179297-01a3-435a-ad0d-a49d0aa087f9", "1", "Main Store", false, "wadministration", 0 },
                    { "4", 0, "46f17ad1-85e9-4a63-ad4e-cbe6c489559b", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEH2As60nzUWez3CHcUS1kEzm+mz97FyrGPAwpZOdPlFr6ZkTLSnk4d4KA+WJWK5FDw==", "+855123456792", true, "d721040d-9866-44bf-b3cc-ab6ef34eccae", "1", "Main Store", false, "wmanager", 0 },
                    { "5", 0, "51a0edec-f170-423f-90a9-11284861a3d8", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAEPLTzNaLJIcgwaRu6tuk8mSVWb000cHeQV4yCQMUJW3dAB61OVhkEPA/XGxU9EuV4w==", "+855123456793", true, "3deb78fe-253f-4c56-86fc-e4319b3a69e7", "1", "Main Store", false, "wstaff", 0 },
                    { "6", 0, "976006a9-f545-4d12-935c-c262bd32c14c", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEC+Tj5CbSanik7xnf6cQdKXPBewZvA/Mygj1myAgu8Js7I6trJxogRze2+9y29j4aA==", "+8512345634366", true, "3a569aaa-7c0e-482b-a176-b1aad4c7d32a", "1", "Main Store", false, "wviewer", 0 },
                    { "7", 0, "161952a0-db28-496a-a69c-b6c80da1561a", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEAbCcWd43DSCTRqxJfw9cT8AXxIQkgr8fJ02R0hF2g0uVGK7bqhbnyq4BiHP9TPixg==", "+855123456795", true, "b44d8b11-923b-4db6-953a-704db00775e2", "1", "Main Store", false, "weditor", 0 },
                    { "8", 0, "b94af871-97af-48c4-add3-3b4640415bef", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEJXPt2HNgbKmrBFPh8Yp7nQbTuL0hQvVSYsEkJpJtNV440b9lbQOhzq5uuL+6agQcA==", "+855123456796", true, "f1c3bab5-6dc1-413f-951e-3246ed6a485a", "1", "Main Store", false, "wuser", 0 },
                    { "9", 0, "d3dce386-1126-41cd-bc05-fffeb1ecbaa1", "radmin@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEMBVV5xsngkFH+7H/0/0mzgHOmTMi2NKAHs4Wo8pykopJTxErFHDRb059nvrUf9Lrg==", "+855123456797", true, "74f2b1a9-d50d-480b-98ca-931dac181c32", "2", "Branch Store", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1262), null, "Drinks and beverages", "Unchanged", true, false, false, "2026-03-26 22:13:10.884126", "Beverages", "1", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1268), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1292), null, "Edible products and snacks", "Unchanged", true, false, false, "2026-03-26 22:13:10.884129", "Food Items", "1", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1293), 0 },
                    { "3", "STAT", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1299), null, "Office and school supplies", "Unchanged", true, false, false, "2026-03-26 22:13:10.884130", "Stationery", "2", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1299), 0 },
                    { "4", "GROC", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1304), null, "Daily household items", "Unchanged", true, false, false, "2026-03-26 22:13:10.884130", "Grocery", "2", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1304), 0 },
                    { "5", "CARE", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1315), null, "Health and hygiene products", "Unchanged", true, false, false, "2026-03-26 22:13:10.884131", "Personal Care", "3", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1315), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1320), null, "Electronic devices and accessories", "Unchanged", true, false, false, "2026-03-26 22:13:10.884132", "Electronics", "3", null, new DateTime(2026, 3, 26, 22, 13, 10, 884, DateTimeKind.Local).AddTicks(1320), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-03-26 22:13:10.872224", null, "Kabul Center", "1", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-03-26 22:13:10.872284", null, "Kabul North", "2", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-03-26 22:13:10.872285", null, "Herat Center", "3", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", "2026-03-26 17:43:10.871829", "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", "2026-03-26 17:43:10.871983", "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", "2026-03-26 17:43:10.871983", "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", "2026-03-26 17:43:10.871983", "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", "2026-03-26 17:43:10.871979", "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", "2026-03-26 17:43:10.871980", "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", "2026-03-26 17:43:10.871981", "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", "2026-03-26 17:43:10.871981", "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", "2026-03-26 17:43:10.871981", "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", "2026-03-26 17:43:10.871982", "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", "2026-03-26 17:43:10.871982", "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", "2026-03-26 17:43:10.871983", "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LanguageNo", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "1", "2026-03-26 22:13:10.870896", null, "Kabul Center District", "1", null, null, 0 },
                    { "10", null, null, null, "Unchanged", false, false, true, "2", "2026-03-26 22:13:10.871001", null, "ولایت هرات", "5", null, null, 0 },
                    { "11", null, null, null, "Unchanged", false, false, true, "1", "2026-03-26 22:13:10.871001", null, "Welcome Message", "6", null, null, 0 },
                    { "12", null, null, null, "Unchanged", false, false, true, "2", "2026-03-26 22:13:10.871001", null, "پیام خوش آمدید", "6", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2", "2026-03-26 22:13:10.870996", null, "منطقه مرکز کابل", "1", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "1", "2026-03-26 22:13:10.870996", null, "Kabul North District", "2", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2", "2026-03-26 22:13:10.870997", null, "منطقه شمال کابل", "2", null, null, 0 },
                    { "5", null, null, null, "Unchanged", false, false, true, "1", "2026-03-26 22:13:10.870997", null, "Herat Center District", "3", null, null, 0 },
                    { "6", null, null, null, "Unchanged", false, false, true, "2", "2026-03-26 22:13:10.870997", null, "منطقه مرکز هرات", "3", null, null, 0 },
                    { "7", null, null, null, "Unchanged", false, false, true, "1", "2026-03-26 22:13:10.870999", null, "Kabul Province", "4", null, null, 0 },
                    { "8", null, null, null, "Unchanged", false, false, true, "2", "2026-03-26 22:13:10.871000", null, "ولایت کابل", "4", null, null, 0 },
                    { "9", null, null, null, "Unchanged", false, false, true, "1", "2026-03-26 22:13:10.871000", null, "Herat Province", "5", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", "2026-03-26 22:13:10.873593", "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", "2026-03-26 22:13:10.874015", "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", "2026-03-26 22:13:10.873737", "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", "2026-03-26 22:13:10.873910", "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", "2026-03-26 22:13:10.874009", "Box", "1", "box", 0 },
                    { "5", "Large containers", "Added", "2026-03-26 22:13:10.874011", "Carton", "1", "ctn", 0 },
                    { "6", "Volume measurement", "Added", "2026-03-26 22:13:10.874011", "Liter", "1", "L", 0 },
                    { "7", "Weight measurement", "Added", "2026-03-26 22:13:10.874012", "Kilogram", "1", "kg", 0 },
                    { "8", "Small weight measurement", "Added", "2026-03-26 22:13:10.874013", "Gram", "1", "g", 0 },
                    { "9", "Small volume measurement", "Added", "2026-03-26 22:13:10.874014", "Milliliter", "1", "ml", 0 }
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
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 3, 26, 22, 13, 10, 885, DateTimeKind.Local).AddTicks(9524), "Individual", null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, true, "2026-03-26 22:13:10.885984", "Doe", null, "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 3, 26, 22, 13, 10, 885, DateTimeKind.Local).AddTicks(9711), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8435), "Individual", null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, true, "2026-03-26 22:13:10.886844", "Rodriguez", null, "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8438), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(1667), "Individual", null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, true, "2026-03-26 22:13:10.886323", "Smith", null, "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(2473), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(5559), "Enterprise", null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, true, "2026-03-26 22:13:10.886739", "Brown", null, "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(6511), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8269), "Individual", null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, true, "2026-03-26 22:13:10.886828", "Wilson", null, "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8281), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8304), "Individual", null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, true, "2026-03-26 22:13:10.886831", "Taylor", null, "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8307), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8342), "Enterprise", null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, true, "2026-03-26 22:13:10.886834", "Garcia", null, "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8345), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8370), "Individual", null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, true, "2026-03-26 22:13:10.886837", "Martinez", null, "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8373), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8393), "Individual", null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, true, "2026-03-26 22:13:10.886839", "Lopez", null, "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8396), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8413), "Enterprise", null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, true, "2026-03-26 22:13:10.886841", "Gonzalez", null, "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 3, 26, 22, 13, 10, 886, DateTimeKind.Local).AddTicks(8416), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "ImageUrl", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 26, 22, 13, 10, 881, DateTimeKind.Local).AddTicks(8785), null, "Classic cola drink", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.881912", null, "Coca Cola 500ml", "COKE-500ML-001", "1", "Main Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 881, DateTimeKind.Local).AddTicks(8983), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(64), null, "Sunflower cooking oil", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883007", null, "Cooking Oil 1L", "OIL-1L-010", "1", "Main Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(67), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(83), null, "Basmati rice", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883009", null, "Rice 1kg", "RICE-1KG-011", "2", "Branch Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(87), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(103), null, "White granulated sugar", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883011", null, "Sugar 1kg", "SUGAR-1KG-012", "3", "Warehouse", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(106), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(129), null, "Hair care shampoo", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883013", null, "Shampoo 400ml", "SHAMP-400ML-013", "1", "Main Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(132), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(148), null, "Dental care paste", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883015", null, "Toothpaste", "TOOTH-PASTE-014", "2", "Branch Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(151), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(167), null, "Type-C charging cable", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883017", null, "USB Cable", "USB-CABLE-015", "1", "Main Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(170), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(185), null, "Fast charging adapter", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883019", null, "Phone Charger", "CHARGER-016", "3", "Warehouse", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(188), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(2188), null, "Cola soft drink", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.882382", null, "Pepsi 500ml", "PEPSI-500ML-002", "1", "Main Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(3000), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(7107), null, "Pure drinking water", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.882908", null, "Mineral Water 1L", "WATER-1L-003", "2", "Branch Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(8218), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(9894), null, "Chocolate sandwich cookies", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.882992", null, "Oreo Biscuits", "OREO-PACK-004", "1", "Main Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(9916), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(9961), null, "Potato chips", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.882996", null, "Lay's Chips", "LAYS-PACK-005", "2", "Branch Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(9965), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(9982), null, "Quick meal noodles", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.882998", null, "Instant Noodles", "NOODLE-PACK-006", "3", "Warehouse", null, new DateTime(2026, 3, 26, 22, 13, 10, 882, DateTimeKind.Local).AddTicks(9985), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(2), null, "200 pages ruled notebook", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883000", null, "A4 Notebook", "NOTE-A4-007", "1", "Main Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(5), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(21), null, "Ballpoint pen", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883002", null, "Blue Pen", "PEN-BLUE-008", "2", "Branch Store", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(24), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(41), null, "12 pencils per box", "Unchanged", null, true, false, false, true, "2026-03-26 22:13:10.883005", null, "Pencil Set", "PENCIL-BOX-009", "3", "Warehouse", null, new DateTime(2026, 3, 26, 22, 13, 10, 883, DateTimeKind.Local).AddTicks(47), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DeletedAt", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 3, 26, 22, 13, 9, 533, DateTimeKind.Local).AddTicks(4782), null, null, "john.doe@example.com", null, "Unchanged", "John", true, false, false, true, "2026-03-26 22:13:09.533513", "Doe", null, "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(8281), null, new DateTime(2026, 3, 26, 22, 13, 9, 533, DateTimeKind.Local).AddTicks(4994), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 3, 26, 22, 13, 9, 533, DateTimeKind.Local).AddTicks(7294), null, null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, false, true, "2026-03-26 22:13:09.533903", "Smith", null, "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 3, 26, 22, 13, 9, 533, DateTimeKind.Local).AddTicks(5153), null, new DateTime(2026, 3, 26, 22, 13, 9, 533, DateTimeKind.Local).AddTicks(8185), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 3, 26, 22, 13, 9, 534, DateTimeKind.Local).AddTicks(1564), null, null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, false, true, "2026-03-26 22:13:09.534391", "Johnson", null, "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 3, 26, 22, 13, 9, 533, DateTimeKind.Local).AddTicks(9767), null, new DateTime(2026, 3, 26, 22, 13, 9, 534, DateTimeKind.Local).AddTicks(2719), 0 }
                });

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DeletedAt", "DueDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 3, 26, 22, 13, 9, 537, DateTimeKind.Local).AddTicks(9120), "1", "John", null, new DateTime(2026, 4, 25, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Unchanged", true, false, false, true, "2026-03-26 22:13:09.537939", null, new DateTime(2026, 2, 24, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Coca Cola loan for John", 5000m, "1", "Coca Cola 500ml", 10m, "1", "Main Store", 1, 50000L, "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 537, DateTimeKind.Local).AddTicks(9270), 0 },
                    { "10", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4824), "9", "James", null, new DateTime(2026, 4, 22, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Unchanged", true, false, false, true, "2026-03-26 22:13:09.539483", null, new DateTime(2026, 3, 23, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "USB cables for James", 1000m, "15", "USB Cable", 100m, "3", "Warehouse", 1, 100000L, "1", "Piece", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4828), 0 },
                    { "2", null, new DateTime(2026, 3, 26, 22, 13, 9, 538, DateTimeKind.Local).AddTicks(4401), "2", "Jane", null, new DateTime(2026, 4, 10, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Unchanged", true, false, false, true, "2026-03-26 22:13:09.538599", null, new DateTime(2026, 3, 11, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Oreo biscuits for Jane", 4000m, "4", "Oreo Biscuits", 5m, "1", "Main Store", 1, 20000L, "3", "Pack", null, new DateTime(2026, 3, 26, 22, 13, 9, 538, DateTimeKind.Local).AddTicks(5218), 0 },
                    { "3", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(1306), "3", "Michael", null, new DateTime(2026, 4, 15, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Unchanged", true, false, false, true, "2026-03-26 22:13:09.539335", null, new DateTime(2026, 3, 16, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Notebooks for Michael", 3000m, "7", "A4 Notebook", 20m, "1", "Main Store", 1, 60000L, "1", "Piece", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(2351), 0 },
                    { "4", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4637), "1", "John", null, new DateTime(2026, 5, 10, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Unchanged", true, false, false, true, "2026-03-26 22:13:09.539465", null, new DateTime(2026, 3, 21, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Cooking oil bulk order", 8000m, "10", "Cooking Oil 1L", 15m, "1", "Main Store", 1, 120000L, "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4652), 0 },
                    { "5", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4685), "4", "Sarah", null, new DateTime(2026, 4, 5, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Unchanged", true, false, false, true, "2026-03-26 22:13:09.539469", null, new DateTime(2026, 3, 6, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Pepsi for Sarah", 4500m, "2", "Pepsi 500ml", 24m, "2", "Branch Store", 1, 108000L, "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4689), 0 },
                    { "6", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4713), "5", "David", null, new DateTime(2026, 4, 13, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Unchanged", true, false, false, true, "2026-03-26 22:13:09.539472", null, new DateTime(2026, 3, 14, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Blue pens for David", 500m, "8", "Blue Pen", 50m, "2", "Branch Store", 1, 25000L, "1", "Piece", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4717), 0 },
                    { "7", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4741), "6", "Lisa", null, null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.539474", null, new DateTime(2026, 3, 1, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Rice bulk purchase", 2000m, "11", "Rice 1kg", 100m, "2", "Branch Store", 1, 200000L, "7", "Kilogram", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4745), 0 },
                    { "8", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4768), "7", "Robert", null, new DateTime(2026, 4, 7, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Unchanged", true, false, false, true, "2026-03-26 22:13:09.539477", null, new DateTime(2026, 3, 8, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Mineral water for Robert", 3000m, "3", "Mineral Water 1L", 48m, "3", "Warehouse", 1, 144000L, "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4772), 0 },
                    { "9", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4796), "8", "Emily", null, new DateTime(2026, 4, 17, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Unchanged", true, false, false, true, "2026-03-26 22:13:09.539480", null, new DateTime(2026, 3, 18, 22, 13, 9, 535, DateTimeKind.Local).AddTicks(2887), "Instant noodles for Emily", 1500m, "6", "Instant Noodles", 30m, "3", "Warehouse", 1, 45000L, "3", "Pack", null, new DateTime(2026, 3, 26, 22, 13, 9, 539, DateTimeKind.Local).AddTicks(4800), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 1m, "Added", "2026-03-26 22:13:09.504075", "1", "Coca Cola 500ml", "Bottle", "2", 0 },
                    { "10", 1m, "Added", "2026-03-26 22:13:09.506032", "4", "Oreo Biscuits", "Pack", "3", 0 },
                    { "11", 12m, "Added", "2026-03-26 22:13:09.506034", "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "12", 48m, "Added", "2026-03-26 22:13:09.506035", "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "13", 1m, "Added", "2026-03-26 22:13:09.506036", "5", "Lay's Chips", "Pack", "3", 0 },
                    { "14", 20m, "Added", "2026-03-26 22:13:09.506037", "5", "Lay's Chips", "Box", "4", 0 },
                    { "15", 60m, "Added", "2026-03-26 22:13:09.506037", "5", "Lay's Chips", "Carton", "5", 0 },
                    { "16", 1m, "Added", "2026-03-26 22:13:09.506038", "6", "Instant Noodles", "Pack", "3", 0 },
                    { "17", 24m, "Added", "2026-03-26 22:13:09.506039", "6", "Instant Noodles", "Box", "4", 0 },
                    { "18", 72m, "Added", "2026-03-26 22:13:09.506040", "6", "Instant Noodles", "Carton", "5", 0 },
                    { "19", 1m, "Added", "2026-03-26 22:13:09.506041", "7", "A4 Notebook", "Piece", "1", 0 },
                    { "2", 12m, "Added", "2026-03-26 22:13:09.505714", "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "20", 12m, "Added", "2026-03-26 22:13:09.506042", "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "21", 50m, "Added", "2026-03-26 22:13:09.506043", "7", "A4 Notebook", "Box", "4", 0 },
                    { "22", 1m, "Added", "2026-03-26 22:13:09.506044", "8", "Blue Pen", "Piece", "1", 0 },
                    { "23", 12m, "Added", "2026-03-26 22:13:09.506045", "8", "Blue Pen", "Dozen", "10", 0 },
                    { "24", 144m, "Added", "2026-03-26 22:13:09.506045", "8", "Blue Pen", "Box", "4", 0 },
                    { "25", 1m, "Added", "2026-03-26 22:13:09.506046", "9", "Pencil Set", "Box", "4", 0 },
                    { "26", 20m, "Added", "2026-03-26 22:13:09.506047", "9", "Pencil Set", "Carton", "5", 0 },
                    { "27", 1m, "Added", "2026-03-26 22:13:09.506048", "10", "Cooking Oil 1L", "Bottle", "2", 0 },
                    { "28", 12m, "Added", "2026-03-26 22:13:09.506049", "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "29", 24m, "Added", "2026-03-26 22:13:09.506050", "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "3", 24m, "Added", "2026-03-26 22:13:09.505906", "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "30", 1m, "Added", "2026-03-26 22:13:09.506051", "11", "Rice 1kg", "Kilogram", "7", 0 },
                    { "31", 10m, "Added", "2026-03-26 22:13:09.506052", "11", "Rice 1kg", "Box", "4", 0 },
                    { "32", 25m, "Added", "2026-03-26 22:13:09.506053", "11", "Rice 1kg", "Carton", "5", 0 },
                    { "33", 1m, "Added", "2026-03-26 22:13:09.506053", "12", "Sugar 1kg", "Kilogram", "7", 0 },
                    { "34", 20m, "Added", "2026-03-26 22:13:09.506054", "12", "Sugar 1kg", "Box", "4", 0 },
                    { "35", 50m, "Added", "2026-03-26 22:13:09.506057", "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "36", 1m, "Added", "2026-03-26 22:13:09.506058", "13", "Shampoo 400ml", "Bottle", "2", 0 },
                    { "37", 12m, "Added", "2026-03-26 22:13:09.506059", "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "38", 24m, "Added", "2026-03-26 22:13:09.506060", "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "39", 1m, "Added", "2026-03-26 22:13:09.506061", "14", "Toothpaste", "Piece", "1", 0 },
                    { "4", 1m, "Added", "2026-03-26 22:13:09.506027", "2", "Pepsi 500ml", "Bottle", "2", 0 },
                    { "40", 24m, "Added", "2026-03-26 22:13:09.506062", "14", "Toothpaste", "Box", "4", 0 },
                    { "41", 72m, "Added", "2026-03-26 22:13:09.506062", "14", "Toothpaste", "Carton", "5", 0 },
                    { "42", 1m, "Added", "2026-03-26 22:13:09.506063", "15", "USB Cable", "Piece", "1", 0 },
                    { "43", 50m, "Added", "2026-03-26 22:13:09.506064", "15", "USB Cable", "Box", "4", 0 },
                    { "44", 200m, "Added", "2026-03-26 22:13:09.506065", "15", "USB Cable", "Carton", "5", 0 },
                    { "45", 1m, "Added", "2026-03-26 22:13:09.506066", "16", "Phone Charger", "Piece", "1", 0 },
                    { "46", 20m, "Added", "2026-03-26 22:13:09.506067", "16", "Phone Charger", "Box", "4", 0 },
                    { "47", 100m, "Added", "2026-03-26 22:13:09.506068", "16", "Phone Charger", "Carton", "5", 0 },
                    { "5", 12m, "Added", "2026-03-26 22:13:09.506028", "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "6", 24m, "Added", "2026-03-26 22:13:09.506029", "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "7", 1m, "Added", "2026-03-26 22:13:09.506030", "3", "Mineral Water 1L", "Bottle", "2", 0 },
                    { "8", 6m, "Added", "2026-03-26 22:13:09.506031", "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "9", 12m, "Added", "2026-03-26 22:13:09.506031", "3", "Mineral Water 1L", "Carton", "5", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 3, 26, 22, 13, 9, 513, DateTimeKind.Local).AddTicks(7632), "Unchanged", new DateTime(2026, 9, 26, 22, 13, 9, 511, DateTimeKind.Local).AddTicks(4721), false, "2026-03-26 22:13:09.513901", "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 3, 16, 22, 13, 9, 511, DateTimeKind.Local).AddTicks(4721), "Active", "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 513, DateTimeKind.Local).AddTicks(8263), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 3, 26, 22, 13, 9, 514, DateTimeKind.Local).AddTicks(2509), "Unchanged", new DateTime(2026, 10, 26, 22, 13, 9, 511, DateTimeKind.Local).AddTicks(4721), false, "2026-03-26 22:13:09.514448", "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 3, 21, 22, 13, 9, 511, DateTimeKind.Local).AddTicks(4721), "Active", "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 514, DateTimeKind.Local).AddTicks(3458), 0 },
                    { "3", "OREO-101", null, new DateTime(2026, 3, 26, 22, 13, 9, 514, DateTimeKind.Local).AddTicks(7806), "Unchanged", new DateTime(2026, 6, 26, 22, 13, 9, 511, DateTimeKind.Local).AddTicks(4721), false, "2026-03-26 22:13:09.515006", "4", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 3, 11, 22, 13, 9, 511, DateTimeKind.Local).AddTicks(4721), "Active", "3", "Pack", null, new DateTime(2026, 3, 26, 22, 13, 9, 514, DateTimeKind.Local).AddTicks(8989), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 3, 26, 22, 13, 9, 515, DateTimeKind.Local).AddTicks(1104), "Unchanged", null, false, "2026-03-26 22:13:09.515112", "7", "A4 Notebook", 120000L, 200m, new DateTime(2026, 3, 6, 22, 13, 9, 511, DateTimeKind.Local).AddTicks(4721), "Active", "1", "Piece", null, new DateTime(2026, 3, 26, 22, 13, 9, 515, DateTimeKind.Local).AddTicks(1118), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "DeletedAt", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", 140L, null, new DateTime(2026, 3, 26, 22, 13, 9, 509, DateTimeKind.Local).AddTicks(7683), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.509910", null, "1", "1", 160L, null, new DateTime(2026, 3, 26, 22, 13, 9, 509, DateTimeKind.Local).AddTicks(8542), 0 },
                    { "10", 230L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8190), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510819", null, "4", "10", 270L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8194), 0 },
                    { "11", 2760L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8222), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510823", null, "4", "11", 3240L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8226), 0 },
                    { "12", 11040L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8238), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510824", null, "4", "12", 12960L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8242), 0 },
                    { "13", 160L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8254), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510826", null, "5", "13", 190L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8258), 0 },
                    { "14", 3200L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8269), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510827", null, "5", "14", 3800L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8273), 0 },
                    { "15", 9600L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8285), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510829", null, "5", "15", 11400L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8289), 0 },
                    { "16", 110L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8300), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510830", null, "6", "16", 130L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8304), 0 },
                    { "17", 2640L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8315), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510832", null, "6", "17", 3120L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8319), 0 },
                    { "18", 7920L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8334), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510834", null, "6", "18", 9360L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8338), 0 },
                    { "19", 280L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8350), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510835", null, "7", "19", 320L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8354), 0 },
                    { "2", 1680L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(1079), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510304", null, "1", "2", 1920L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(2157), 0 },
                    { "20", 3360L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8414), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510842", null, "7", "20", 3840L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8419), 0 },
                    { "21", 14000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8430), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510843", null, "7", "21", 16000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8434), 0 },
                    { "22", 45L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8446), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510845", null, "8", "22", 55L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8450), 0 },
                    { "23", 540L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8461), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510846", null, "8", "23", 660L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8465), 0 },
                    { "24", 6480L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8477), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510848", null, "8", "24", 7920L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8481), 0 },
                    { "25", 380L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8492), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510849", null, "9", "25", 420L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8496), 0 },
                    { "26", 7600L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8510), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510851", null, "9", "26", 8400L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8514), 0 },
                    { "27", 430L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8525), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510853", null, "10", "27", 470L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8529), 0 },
                    { "28", 5160L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8541), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510854", null, "10", "28", 5640L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8545), 0 },
                    { "29", 10320L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8556), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510858", null, "10", "29", 11280L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8576), 0 },
                    { "3", 3360L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(4786), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510708", null, "1", "3", 3840L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(5978), 0 },
                    { "30", 260L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8587), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510859", null, "11", "30", 300L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8591), 0 },
                    { "31", 2600L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8603), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510861", null, "11", "31", 3000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8607), 0 },
                    { "32", 6500L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8618), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510862", null, "11", "32", 7500L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8622), 0 },
                    { "33", 180L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8633), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510864", null, "12", "33", 220L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8637), 0 },
                    { "34", 3600L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8651), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510865", null, "12", "34", 4400L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8655), 0 },
                    { "35", 9000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8666), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510867", null, "12", "35", 11000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8671), 0 },
                    { "36", 330L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8682), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510868", null, "13", "36", 370L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8686), 0 },
                    { "37", 3960L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8697), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510870", null, "13", "37", 4440L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8701), 0 },
                    { "38", 7920L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8713), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510872", null, "13", "38", 8880L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8717), 0 },
                    { "39", 160L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8729), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510873", null, "14", "39", 200L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8733), 0 },
                    { "4", 130L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8066), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510808", null, "2", "4", 150L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8081), 0 },
                    { "40", 3840L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8744), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510875", null, "14", "40", 4800L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8748), 0 },
                    { "41", 11520L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8760), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510876", null, "14", "41", 14400L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8763), 0 },
                    { "42", 230L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8777), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510878", null, "15", "42", 270L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8781), 0 },
                    { "43", 11500L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8793), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510880", null, "15", "43", 13500L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8797), 0 },
                    { "44", 46000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8808), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510881", null, "15", "44", 54000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8812), 0 },
                    { "45", 750L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8824), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510883", null, "16", "45", 850L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8828), 0 },
                    { "46", 15000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8839), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510884", null, "16", "46", 17000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8843), 0 },
                    { "47", 75000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8854), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510886", null, "16", "47", 85000L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8858), 0 },
                    { "5", 1560L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8100), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510810", null, "2", "5", 1800L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8104), 0 },
                    { "6", 3120L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8118), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510812", null, "2", "6", 3600L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8123), 0 },
                    { "7", 70L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8134), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510814", null, "3", "7", 90L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8139), 0 },
                    { "8", 420L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8150), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510815", null, "3", "8", 540L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8154), 0 },
                    { "9", 840L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8165), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-26 22:13:09.510817", null, "3", "9", 1080L, null, new DateTime(2026, 3, 26, 22, 13, 9, 510, DateTimeKind.Local).AddTicks(8169), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 3, 26, 22, 13, 9, 517, DateTimeKind.Local).AddTicks(8118), "Unchanged", false, "2026-03-26 22:13:09.517839", "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 517, DateTimeKind.Local).AddTicks(8282), 0 },
                    { "10", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(723), "Unchanged", false, "2026-03-26 22:13:09.519073", "7", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(727), 0 },
                    { "2", null, new DateTime(2026, 3, 26, 22, 13, 9, 518, DateTimeKind.Local).AddTicks(1817), "Unchanged", false, "2026-03-26 22:13:09.518357", "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 518, DateTimeKind.Local).AddTicks(2711), 0 },
                    { "3", null, new DateTime(2026, 3, 26, 22, 13, 9, 518, DateTimeKind.Local).AddTicks(7326), "Unchanged", false, "2026-03-26 22:13:09.518953", "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 518, DateTimeKind.Local).AddTicks(8444), 0 },
                    { "4", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(545), "Unchanged", false, "2026-03-26 22:13:09.519056", "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(561), 0 },
                    { "5", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(588), "Unchanged", false, "2026-03-26 22:13:09.519059", "4", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(592), 0 },
                    { "6", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(613), "Unchanged", false, "2026-03-26 22:13:09.519062", "4", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(617), 0 },
                    { "7", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(636), "Unchanged", false, "2026-03-26 22:13:09.519064", "4", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "3", "Pack", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(640), 0 },
                    { "8", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(667), "Unchanged", false, "2026-03-26 22:13:09.519067", "7", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "1", "Piece", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(672), 0 },
                    { "9", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(691), "Unchanged", false, "2026-03-26 22:13:09.519071", "7", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 3, 26, 22, 13, 9, 519, DateTimeKind.Local).AddTicks(706), 0 }
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
