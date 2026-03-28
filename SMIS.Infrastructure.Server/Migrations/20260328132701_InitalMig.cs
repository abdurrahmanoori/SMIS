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
                    { "1", "en", "Added", true, "2026-03-28 13:27:00.532252", "English", 0 },
                    { "2", "ps", "Added", true, "2026-03-28 13:27:00.532289", "Pashto", 0 },
                    { "3", "fa", "Added", true, "2026-03-28 13:27:00.532289", "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-03-28 13:27:00.533439", null, "Kabul", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-03-28 13:27:00.533466", null, "Herat", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-03-28 13:27:00.533466", null, "Kandahar", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2026-03-28 13:27:00.533467", null, "Balkh", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedAt", "Email", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(4064), null, "main@store.local", "Unchanged", true, false, false, true, "2026-03-28 13:27:00.536420", null, "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(4153), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(4956), null, "branch@store.local", "Unchanged", true, false, false, true, "2026-03-28 13:27:00.536575", null, "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(5434), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(6572), null, "warehouse@store.local", "Unchanged", true, false, false, true, "2026-03-28 13:27:00.536804", null, "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 3, 28, 13, 27, 0, 536, DateTimeKind.Utc).AddTicks(7099), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", true, false, false, true, "2026-03-28 13:27:00.532547", null, "1001", "Kabul Center District", null, null, 0 },
                    { "2", null, null, null, "Unchanged", true, false, false, true, "2026-03-28 13:27:00.532589", null, "1002", "Kabul North District", null, null, 0 },
                    { "3", null, null, null, "Unchanged", true, false, false, true, "2026-03-28 13:27:00.532589", null, "1003", "Herat Center District", null, null, 0 },
                    { "4", null, null, null, "Unchanged", true, false, false, true, "2026-03-28 13:27:00.532589", null, "2001", "Kabul Province", null, null, 0 },
                    { "5", null, null, null, "Unchanged", true, false, false, true, "2026-03-28 13:27:00.532589", null, "2002", "Herat Province", null, null, 0 },
                    { "6", null, null, null, "Unchanged", true, false, false, true, "2026-03-28 13:27:00.532590", null, "3001", "Welcome Message", null, null, 0 },
                    { "7", null, null, null, "Unchanged", true, false, false, true, "2026-03-28 13:27:00.532590", null, "3002", "Error Message", null, null, 0 },
                    { "8", null, null, null, "Unchanged", true, false, false, true, "2026-03-28 13:27:00.532590", null, "3003", "Success Message", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "a2f96aca-a5d3-44e0-a60d-70ec6fb51766", "superadmin@smis.com", true, "Unchanged", "Super", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEJxrww3uo6WeFp1beujHbndNgC1k3l/WxzgcAkJddHbYseGcgl56WSOUgtxwnlttbw==", "+855123456789", true, "00af08a2-4c91-44b5-8e39-2b522c5be95f", "1", "Main Store", false, "superadmin", 0 },
                    { "10", 0, "8e72084b-3705-4b01-ad8d-c471d4a4626f", "radministration@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEHgREkka47OlGAzCZwPd+kIdbn5ZAxHHlGxmGvOo2HopNlekPUvXEemDetv6WMBMSg==", "+855123456798", true, "ec425537-dbe2-4ac8-b01b-723f793b03a4", "2", "Branch Store", false, "radministration", 0 },
                    { "11", 0, "fc62cca0-0e08-492a-a726-e603dc6f6e55", "rmanager@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEOSeEi09GZRYH8oFjpensQxjFNxtDHHsBV+wjweoOZsTQBKte8vakW2J/VAbyzuT8g==", "+855123456799", true, "0f6bb9e9-161c-401b-a682-63f17b410036", "2", "Branch Store", false, "rmanager", 0 },
                    { "12", 0, "aa99ff41-2f50-40f9-a915-b73bc69e4bc8", "rstaff@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEN643g9ldl6oj9+s2fu48J8PAdBsNHJjtZBB1dzehlxZ3s48lIQaJaeiPh5fSkDHIQ==", "+855123456800", true, "cd8c4da0-d00b-4337-b58e-71d2c507dd34", "2", "Branch Store", false, "rstaff", 0 },
                    { "13", 0, "40e5643c-05a4-477c-937c-4869fb855412", "rviewer@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAECaGMpE4j5gF4tr0xT0Xi06iXq/zPBYx37E+XRewVS1EcXpZESz1cso6qdWGtGRSWA==", "+855123456801", true, "b1255c6e-e4b2-4776-9364-4c528ee506df", "2", "Branch Store", false, "rviewer", 0 },
                    { "14", 0, "444a9936-7100-4f97-a32d-5fd71ca7eca8", "reditor@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAEF/kWn31rq+1fZc8XU+QcB+LuxbAKVdE7eHTAGCPyZQWQvmA6kEpe/DTu16cfxpa7g==", "+855123456802", true, "32a5bb0c-65fb-4b76-9ccd-923d1f31dde9", "2", "Branch Store", false, "reditor", 0 },
                    { "15", 0, "c2f44088-4211-4694-94d4-12f5bcb23095", "ruser@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEOhZno/ysrzxS6Cjn3l3/V/pnezxXOV+GRTjaHXPdm89bFA1SlEUiloEd9Hdsh8LQA==", "+855123456803", true, "f3201b37-0227-414c-90ac-44cf371cac04", "2", "Branch Store", false, "ruser", 0 },
                    { "2", 0, "809851df-34cd-48b4-924b-8628cfcd8c9d", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEND+sN1rEgGP1HG8oM7iYfdAQTl6Bh6jnJAtMohfS6ZoULrX12nSZvdD8W5zPrvZ+Q==", "+855123456790", true, "eba2262f-acc6-47cd-a44d-9acf72ec95be", "1", "Main Store", false, "wadmin", 0 },
                    { "3", 0, "95f69270-4107-43fc-9910-b8d2b369b090", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEH9NAAra0XEuK73mzfg/6J1/EUQuQV/H/9wO9RycP/Dj0GOEDDXmvIpCl+N7iVTELA==", "+855123456791", true, "6c522cd3-06bb-4b2f-88cf-8a91724c60a2", "1", "Main Store", false, "wadministration", 0 },
                    { "4", 0, "5a9c64e1-294f-410a-9b0d-a591d7f5857f", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEKl26XdtqrUV+XeGmAZXiiAH2edubZr+1J0h74R6oQdDP7zbc1joSjXDAAVgFokwHA==", "+855123456792", true, "3e53e39b-c427-4950-9db7-2963db902ebb", "1", "Main Store", false, "wmanager", 0 },
                    { "5", 0, "dbbb3a9a-953e-4b06-be83-bb577a533c9b", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAEPNwyhYnh6I6ZSg2Q+SfA5HRxp/s3gkIcEP99Jb5GzDJJiNoubTwUhE/PFBL/da9SA==", "+855123456793", true, "7bc6fc56-b6a4-4320-84a4-ce476c0d7389", "1", "Main Store", false, "wstaff", 0 },
                    { "6", 0, "62e07292-6015-4fad-8dd0-46a3661f7620", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEJSxAP0TUGWYVwIdrvA/Kzc+8+tMZq0/JvWfZnTQd8wT6kf/V2N64peoODaSKB/mNA==", "+8512345634366", true, "3e844f80-08f0-483c-9a66-1a168267749b", "1", "Main Store", false, "wviewer", 0 },
                    { "7", 0, "9b7b6655-2690-4e53-af83-facc3ed06bf5", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEPlm54bGpuhqXgsWu9GubLjcFLQb/guJoLQ2ClFuayaiAz5v+rdPEHlLEZaYCLSs/A==", "+855123456795", true, "a6883dc9-666f-4805-b8ac-39cee9f4e9e5", "1", "Main Store", false, "weditor", 0 },
                    { "8", 0, "f78e9029-18c8-4e68-a4e1-2285d0583f4f", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEF63Hun2ri1zX8gBT1fQyWN4QiAZygjRO3TPlPPONzaeDXFhlBxcBNjmybcdv62t2w==", "+855123456796", true, "ba1fd03d-0ac2-488e-9455-08551d9f7d9b", "1", "Main Store", false, "wuser", 0 },
                    { "9", 0, "c47d608c-affc-497c-b4a2-f779e9b4f9bb", "radmin@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEK73tP/t9GHf1RoMiX3YZaOhius3l7XTGASMkX4gjaXpN2KtRsvvJGMA1kb39rhqrA==", "+855123456797", true, "4c4b3d18-4ca8-431c-866d-8cc423b07b97", "2", "Branch Store", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5251), null, "Drinks and beverages", "Unchanged", true, false, false, "2026-03-28 13:27:00.540525", "Beverages", "1", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5254), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5267), null, "Edible products and snacks", "Unchanged", true, false, false, "2026-03-28 13:27:00.540526", "Food Items", "1", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5267), 0 },
                    { "3", "STAT", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5270), null, "Office and school supplies", "Unchanged", true, false, false, "2026-03-28 13:27:00.540527", "Stationery", "2", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5271), 0 },
                    { "4", "GROC", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5273), null, "Daily household items", "Unchanged", true, false, false, "2026-03-28 13:27:00.540527", "Grocery", "2", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5274), 0 },
                    { "5", "CARE", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5307), null, "Health and hygiene products", "Unchanged", true, false, false, "2026-03-28 13:27:00.540530", "Personal Care", "3", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5308), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5310), null, "Electronic devices and accessories", "Unchanged", true, false, false, "2026-03-28 13:27:00.540531", "Electronics", "3", null, new DateTime(2026, 3, 28, 13, 27, 0, 540, DateTimeKind.Utc).AddTicks(5311), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-03-28 13:27:00.533920", null, "Kabul Center", "1", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-03-28 13:27:00.533945", null, "Kabul North", "2", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-03-28 13:27:00.533945", null, "Herat Center", "3", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", "2026-03-28 13:27:00.533625", "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", "2026-03-28 13:27:00.533739", "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", "2026-03-28 13:27:00.533740", "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", "2026-03-28 13:27:00.533740", "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", "2026-03-28 13:27:00.533729", "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", "2026-03-28 13:27:00.533737", "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", "2026-03-28 13:27:00.533738", "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", "2026-03-28 13:27:00.533738", "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", "2026-03-28 13:27:00.533738", "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", "2026-03-28 13:27:00.533738", "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", "2026-03-28 13:27:00.533739", "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", "2026-03-28 13:27:00.533739", "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LanguageNo", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "1", "2026-03-28 13:27:00.532882", null, "Kabul Center District", "1", null, null, 0 },
                    { "10", null, null, null, "Unchanged", false, false, true, "2", "2026-03-28 13:27:00.532917", null, "ولایت هرات", "5", null, null, 0 },
                    { "11", null, null, null, "Unchanged", false, false, true, "1", "2026-03-28 13:27:00.532917", null, "Welcome Message", "6", null, null, 0 },
                    { "12", null, null, null, "Unchanged", false, false, true, "2", "2026-03-28 13:27:00.532917", null, "پیام خوش آمدید", "6", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2", "2026-03-28 13:27:00.532916", null, "منطقه مرکز کابل", "1", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "1", "2026-03-28 13:27:00.532916", null, "Kabul North District", "2", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2", "2026-03-28 13:27:00.532916", null, "منطقه شمال کابل", "2", null, null, 0 },
                    { "5", null, null, null, "Unchanged", false, false, true, "1", "2026-03-28 13:27:00.532916", null, "Herat Center District", "3", null, null, 0 },
                    { "6", null, null, null, "Unchanged", false, false, true, "2", "2026-03-28 13:27:00.532917", null, "منطقه مرکز هرات", "3", null, null, 0 },
                    { "7", null, null, null, "Unchanged", false, false, true, "1", "2026-03-28 13:27:00.532917", null, "Kabul Province", "4", null, null, 0 },
                    { "8", null, null, null, "Unchanged", false, false, true, "2", "2026-03-28 13:27:00.532917", null, "ولایت کابل", "4", null, null, 0 },
                    { "9", null, null, null, "Unchanged", false, false, true, "1", "2026-03-28 13:27:00.532917", null, "Herat Province", "5", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", "2026-03-28 13:27:00.534622", "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", "2026-03-28 13:27:00.534916", "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", "2026-03-28 13:27:00.534735", "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", "2026-03-28 13:27:00.534858", "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", "2026-03-28 13:27:00.534913", "Box", "1", "box", 0 },
                    { "5", "Large containers", "Added", "2026-03-28 13:27:00.534913", "Carton", "1", "ctn", 0 },
                    { "6", "Volume measurement", "Added", "2026-03-28 13:27:00.534913", "Liter", "1", "L", 0 },
                    { "7", "Weight measurement", "Added", "2026-03-28 13:27:00.534915", "Kilogram", "1", "kg", 0 },
                    { "8", "Small weight measurement", "Added", "2026-03-28 13:27:00.534915", "Gram", "1", "g", 0 },
                    { "9", "Small volume measurement", "Added", "2026-03-28 13:27:00.534915", "Milliliter", "1", "ml", 0 }
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
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(3987), "Individual", null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, true, "2026-03-28 13:27:00.541412", "Doe", null, "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(4069), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8339), "Individual", null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, true, "2026-03-28 13:27:00.541834", "Rodriguez", null, "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8341), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(5184), "Individual", null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, true, "2026-03-28 13:27:00.541586", "Smith", null, "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(5537), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(7116), "Enterprise", null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, true, "2026-03-28 13:27:00.541790", "Brown", null, "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(7571), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8225), "Individual", null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, true, "2026-03-28 13:27:00.541823", "Wilson", null, "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8230), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8240), "Individual", null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, true, "2026-03-28 13:27:00.541824", "Taylor", null, "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8242), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8252), "Enterprise", null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, true, "2026-03-28 13:27:00.541825", "Garcia", null, "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8253), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8262), "Individual", null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, true, "2026-03-28 13:27:00.541826", "Martinez", null, "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8264), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8314), "Individual", null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, true, "2026-03-28 13:27:00.541831", "Lopez", null, "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8316), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8328), "Enterprise", null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, true, "2026-03-28 13:27:00.541833", "Gonzalez", null, "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 3, 28, 13, 27, 0, 541, DateTimeKind.Utc).AddTicks(8330), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "ImageUrl", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(3489), null, "Classic cola drink", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539364", null, "Coca Cola 500ml", "COKE-500ML-001", "1", "Main Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(3583), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9128), null, "Sunflower cooking oil", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539913", null, "Cooking Oil 1L", "OIL-1L-010", "1", "Main Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9129), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9144), null, "Basmati rice", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539914", null, "Rice 1kg", "RICE-1KG-011", "2", "Branch Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9145), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9153), null, "White granulated sugar", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539916", null, "Sugar 1kg", "SUGAR-1KG-012", "3", "Warehouse", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9154), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9166), null, "Hair care shampoo", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539917", null, "Shampoo 400ml", "SHAMP-400ML-013", "1", "Main Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9168), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9176), null, "Dental care paste", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539917", null, "Toothpaste", "TOOTH-PASTE-014", "2", "Branch Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9178), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9187), null, "Type-C charging cable", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539918", null, "USB Cable", "USB-CABLE-015", "1", "Main Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9188), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9196), null, "Fast charging adapter", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539919", null, "Phone Charger", "CHARGER-016", "3", "Warehouse", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9197), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(5454), null, "Cola soft drink", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539634", null, "Pepsi 500ml", "PEPSI-500ML-002", "1", "Main Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(5804), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(7735), null, "Pure drinking water", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539867", null, "Mineral Water 1L", "WATER-1L-003", "2", "Branch Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(8318), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(8992), null, "Chocolate sandwich cookies", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539899", null, "Oreo Biscuits", "OREO-PACK-004", "1", "Main Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(8996), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9034), null, "Potato chips", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539903", null, "Lay's Chips", "LAYS-PACK-005", "2", "Branch Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9036), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9045), null, "Quick meal noodles", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539908", null, "Instant Noodles", "NOODLE-PACK-006", "3", "Warehouse", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9079), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9095), null, "200 pages ruled notebook", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539909", null, "A4 Notebook", "NOTE-A4-007", "1", "Main Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9097), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9105), null, "Ballpoint pen", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539910", null, "Blue Pen", "PEN-BLUE-008", "2", "Branch Store", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9107), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9115), null, "12 pencils per box", "Unchanged", null, true, false, false, true, "2026-03-28 13:27:00.539912", null, "Pencil Set", "PENCIL-BOX-009", "3", "Warehouse", null, new DateTime(2026, 3, 28, 13, 27, 0, 539, DateTimeKind.Utc).AddTicks(9119), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DeletedAt", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(3781), null, null, "john.doe@example.com", null, "Unchanged", "John", true, false, false, true, "2026-03-28 13:26:59.947392", "Doe", null, "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 3, 28, 17, 56, 59, 940, DateTimeKind.Local).AddTicks(7956), null, new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(3875), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(5283), null, null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, false, true, "2026-03-28 13:26:59.947590", "Smith", null, "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 3, 28, 17, 56, 59, 947, DateTimeKind.Local).AddTicks(3940), null, new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(5635), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(6884), null, null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, false, true, "2026-03-28 13:26:59.947821", "Johnson", null, "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 3, 28, 17, 56, 59, 947, DateTimeKind.Local).AddTicks(6120), null, new DateTime(2026, 3, 28, 13, 26, 59, 947, DateTimeKind.Utc).AddTicks(7809), 0 }
                });

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DeletedAt", "DueDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 3, 28, 13, 26, 59, 950, DateTimeKind.Utc).AddTicks(2448), "1", "John", null, new DateTime(2026, 4, 27, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Unchanged", true, false, false, true, "2026-03-28 13:26:59.950259", null, new DateTime(2026, 2, 26, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Coca Cola loan for John", 5000m, "1", "Coca Cola 500ml", 10m, "1", "Main Store", 1, 50000L, "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 950, DateTimeKind.Utc).AddTicks(2533), 0 },
                    { "10", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3541), "9", "James", null, new DateTime(2026, 4, 24, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Unchanged", true, false, false, true, "2026-03-28 13:26:59.951354", null, new DateTime(2026, 3, 25, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "USB cables for James", 1000m, "15", "USB Cable", 100m, "3", "Warehouse", 1, 100000L, "1", "Piece", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3542), 0 },
                    { "2", null, new DateTime(2026, 3, 28, 13, 26, 59, 950, DateTimeKind.Utc).AddTicks(5286), "2", "Jane", null, new DateTime(2026, 4, 12, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Unchanged", true, false, false, true, "2026-03-28 13:26:59.950634", null, new DateTime(2026, 3, 13, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Oreo biscuits for Jane", 4000m, "4", "Oreo Biscuits", 5m, "1", "Main Store", 1, 20000L, "3", "Pack", null, new DateTime(2026, 3, 28, 13, 26, 59, 950, DateTimeKind.Utc).AddTicks(5654), 0 },
                    { "3", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(768), "3", "Michael", null, new DateTime(2026, 4, 17, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Unchanged", true, false, false, true, "2026-03-28 13:26:59.951283", null, new DateTime(2026, 3, 18, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Notebooks for Michael", 3000m, "7", "A4 Notebook", 20m, "1", "Main Store", 1, 60000L, "1", "Piece", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(1374), 0 },
                    { "4", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3442), "1", "John", null, new DateTime(2026, 5, 12, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Unchanged", true, false, false, true, "2026-03-28 13:26:59.951345", null, new DateTime(2026, 3, 23, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Cooking oil bulk order", 8000m, "10", "Cooking Oil 1L", 15m, "1", "Main Store", 1, 120000L, "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3452), 0 },
                    { "5", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3475), "4", "Sarah", null, new DateTime(2026, 4, 7, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Unchanged", true, false, false, true, "2026-03-28 13:26:59.951347", null, new DateTime(2026, 3, 8, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Pepsi for Sarah", 4500m, "2", "Pepsi 500ml", 24m, "2", "Branch Store", 1, 108000L, "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3477), 0 },
                    { "6", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3488), "5", "David", null, new DateTime(2026, 4, 15, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Unchanged", true, false, false, true, "2026-03-28 13:26:59.951349", null, new DateTime(2026, 3, 16, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Blue pens for David", 500m, "8", "Blue Pen", 50m, "2", "Branch Store", 1, 25000L, "1", "Piece", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3489), 0 },
                    { "7", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3502), "6", "Lisa", null, null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.951350", null, new DateTime(2026, 3, 3, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Rice bulk purchase", 2000m, "11", "Rice 1kg", 100m, "2", "Branch Store", 1, 200000L, "7", "Kilogram", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3503), 0 },
                    { "8", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3515), "7", "Robert", null, new DateTime(2026, 4, 9, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Unchanged", true, false, false, true, "2026-03-28 13:26:59.951351", null, new DateTime(2026, 3, 10, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Mineral water for Robert", 3000m, "3", "Mineral Water 1L", 48m, "3", "Warehouse", 1, 144000L, "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3516), 0 },
                    { "9", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3528), "8", "Emily", null, new DateTime(2026, 4, 19, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Unchanged", true, false, false, true, "2026-03-28 13:26:59.951353", null, new DateTime(2026, 3, 20, 13, 26, 59, 948, DateTimeKind.Utc).AddTicks(1901), "Instant noodles for Emily", 1500m, "6", "Instant Noodles", 30m, "3", "Warehouse", 1, 45000L, "3", "Pack", null, new DateTime(2026, 3, 28, 13, 26, 59, 951, DateTimeKind.Utc).AddTicks(3529), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 1m, "Added", "2026-03-28 13:26:59.933833", "1", "Coca Cola 500ml", "Bottle", "2", 0 },
                    { "10", 1m, "Added", "2026-03-28 13:26:59.934282", "4", "Oreo Biscuits", "Pack", "3", 0 },
                    { "11", 12m, "Added", "2026-03-28 13:26:59.934282", "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "12", 48m, "Added", "2026-03-28 13:26:59.934283", "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "13", 1m, "Added", "2026-03-28 13:26:59.934284", "5", "Lay's Chips", "Pack", "3", 0 },
                    { "14", 20m, "Added", "2026-03-28 13:26:59.934284", "5", "Lay's Chips", "Box", "4", 0 },
                    { "15", 60m, "Added", "2026-03-28 13:26:59.934285", "5", "Lay's Chips", "Carton", "5", 0 },
                    { "16", 1m, "Added", "2026-03-28 13:26:59.934285", "6", "Instant Noodles", "Pack", "3", 0 },
                    { "17", 24m, "Added", "2026-03-28 13:26:59.934296", "6", "Instant Noodles", "Box", "4", 0 },
                    { "18", 72m, "Added", "2026-03-28 13:26:59.934297", "6", "Instant Noodles", "Carton", "5", 0 },
                    { "19", 1m, "Added", "2026-03-28 13:26:59.934297", "7", "A4 Notebook", "Piece", "1", 0 },
                    { "2", 12m, "Added", "2026-03-28 13:26:59.934041", "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "20", 12m, "Added", "2026-03-28 13:26:59.934298", "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "21", 50m, "Added", "2026-03-28 13:26:59.934299", "7", "A4 Notebook", "Box", "4", 0 },
                    { "22", 1m, "Added", "2026-03-28 13:26:59.934299", "8", "Blue Pen", "Piece", "1", 0 },
                    { "23", 12m, "Added", "2026-03-28 13:26:59.934300", "8", "Blue Pen", "Dozen", "10", 0 },
                    { "24", 144m, "Added", "2026-03-28 13:26:59.934300", "8", "Blue Pen", "Box", "4", 0 },
                    { "25", 1m, "Added", "2026-03-28 13:26:59.934301", "9", "Pencil Set", "Box", "4", 0 },
                    { "26", 20m, "Added", "2026-03-28 13:26:59.934301", "9", "Pencil Set", "Carton", "5", 0 },
                    { "27", 1m, "Added", "2026-03-28 13:26:59.934302", "10", "Cooking Oil 1L", "Bottle", "2", 0 },
                    { "28", 12m, "Added", "2026-03-28 13:26:59.934302", "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "29", 24m, "Added", "2026-03-28 13:26:59.934303", "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "3", 24m, "Added", "2026-03-28 13:26:59.934166", "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "30", 1m, "Added", "2026-03-28 13:26:59.934303", "11", "Rice 1kg", "Kilogram", "7", 0 },
                    { "31", 10m, "Added", "2026-03-28 13:26:59.934304", "11", "Rice 1kg", "Box", "4", 0 },
                    { "32", 25m, "Added", "2026-03-28 13:26:59.934304", "11", "Rice 1kg", "Carton", "5", 0 },
                    { "33", 1m, "Added", "2026-03-28 13:26:59.934305", "12", "Sugar 1kg", "Kilogram", "7", 0 },
                    { "34", 20m, "Added", "2026-03-28 13:26:59.934305", "12", "Sugar 1kg", "Box", "4", 0 },
                    { "35", 50m, "Added", "2026-03-28 13:26:59.934306", "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "36", 1m, "Added", "2026-03-28 13:26:59.934306", "13", "Shampoo 400ml", "Bottle", "2", 0 },
                    { "37", 12m, "Added", "2026-03-28 13:26:59.934307", "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "38", 24m, "Added", "2026-03-28 13:26:59.934308", "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "39", 1m, "Added", "2026-03-28 13:26:59.934308", "14", "Toothpaste", "Piece", "1", 0 },
                    { "4", 1m, "Added", "2026-03-28 13:26:59.934277", "2", "Pepsi 500ml", "Bottle", "2", 0 },
                    { "40", 24m, "Added", "2026-03-28 13:26:59.934309", "14", "Toothpaste", "Box", "4", 0 },
                    { "41", 72m, "Added", "2026-03-28 13:26:59.934309", "14", "Toothpaste", "Carton", "5", 0 },
                    { "42", 1m, "Added", "2026-03-28 13:26:59.934310", "15", "USB Cable", "Piece", "1", 0 },
                    { "43", 50m, "Added", "2026-03-28 13:26:59.934310", "15", "USB Cable", "Box", "4", 0 },
                    { "44", 200m, "Added", "2026-03-28 13:26:59.934310", "15", "USB Cable", "Carton", "5", 0 },
                    { "45", 1m, "Added", "2026-03-28 13:26:59.934311", "16", "Phone Charger", "Piece", "1", 0 },
                    { "46", 20m, "Added", "2026-03-28 13:26:59.934312", "16", "Phone Charger", "Box", "4", 0 },
                    { "47", 100m, "Added", "2026-03-28 13:26:59.934312", "16", "Phone Charger", "Carton", "5", 0 },
                    { "5", 12m, "Added", "2026-03-28 13:26:59.934279", "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "6", 24m, "Added", "2026-03-28 13:26:59.934279", "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "7", 1m, "Added", "2026-03-28 13:26:59.934280", "3", "Mineral Water 1L", "Bottle", "2", 0 },
                    { "8", 6m, "Added", "2026-03-28 13:26:59.934281", "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "9", 12m, "Added", "2026-03-28 13:26:59.934281", "3", "Mineral Water 1L", "Carton", "5", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(635), "Unchanged", new DateTime(2026, 9, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), false, "2026-03-28 13:26:59.938102", "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 3, 18, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), "Active", "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(878), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(2605), "Unchanged", new DateTime(2026, 10, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), false, "2026-03-28 13:26:59.938353", "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 3, 23, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), "Active", "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(2934), 0 },
                    { "3", "OREO-101", null, new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(4757), "Unchanged", new DateTime(2026, 6, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), false, "2026-03-28 13:26:59.938558", "4", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 3, 13, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), "Active", "3", "Pack", null, new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(5242), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(5916), "Unchanged", null, false, "2026-03-28 13:26:59.938592", "7", "A4 Notebook", 120000L, 200m, new DateTime(2026, 3, 8, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(5050), "Active", "1", "Piece", null, new DateTime(2026, 3, 28, 13, 26, 59, 938, DateTimeKind.Utc).AddTicks(5921), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "DeletedAt", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", 140L, null, new DateTime(2026, 3, 28, 13, 26, 59, 935, DateTimeKind.Utc).AddTicks(8392), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.935880", null, "1", "1", 160L, null, new DateTime(2026, 3, 28, 13, 26, 59, 935, DateTimeKind.Utc).AddTicks(8659), 0 },
                    { "10", 230L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2517), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936251", null, "4", "10", 270L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2518), 0 },
                    { "11", 2760L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2525), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936252", null, "4", "11", 3240L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2526), 0 },
                    { "12", 11040L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2532), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936253", null, "4", "12", 12960L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2533), 0 },
                    { "13", 160L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2539), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936254", null, "5", "13", 190L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2541), 0 },
                    { "14", 3200L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2548), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936255", null, "5", "14", 3800L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2549), 0 },
                    { "15", 9600L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2555), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936255", null, "5", "15", 11400L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2557), 0 },
                    { "16", 110L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2563), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936256", null, "6", "16", 130L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2564), 0 },
                    { "17", 2640L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2570), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936257", null, "6", "17", 3120L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2572), 0 },
                    { "18", 7920L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2598), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936260", null, "6", "18", 9360L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2599), 0 },
                    { "19", 280L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2637), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936264", null, "7", "19", 320L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2638), 0 },
                    { "2", 1680L, null, new DateTime(2026, 3, 28, 13, 26, 59, 935, DateTimeKind.Utc).AddTicks(9619), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936041", null, "1", "2", 1920L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(130), 0 },
                    { "20", 3360L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2645), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936264", null, "7", "20", 3840L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2646), 0 },
                    { "21", 14000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2652), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936265", null, "7", "21", 16000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2654), 0 },
                    { "22", 45L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2661), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936266", null, "8", "22", 55L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2662), 0 },
                    { "23", 540L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2668), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936267", null, "8", "23", 660L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2670), 0 },
                    { "24", 6480L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2676), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936267", null, "8", "24", 7920L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2677), 0 },
                    { "25", 380L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2683), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936268", null, "9", "25", 420L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2684), 0 },
                    { "26", 7600L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2691), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936269", null, "9", "26", 8400L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2692), 0 },
                    { "27", 430L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2698), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936270", null, "10", "27", 470L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2700), 0 },
                    { "28", 5160L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2706), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936270", null, "10", "28", 5640L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2707), 0 },
                    { "29", 10320L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2713), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936271", null, "10", "29", 11280L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2715), 0 },
                    { "3", 3360L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(1096), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936213", null, "1", "3", 3840L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(1759), 0 },
                    { "30", 260L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2723), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936272", null, "11", "30", 300L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2724), 0 },
                    { "31", 2600L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2730), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936273", null, "11", "31", 3000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2731), 0 },
                    { "32", 6500L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2737), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936274", null, "11", "32", 7500L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2739), 0 },
                    { "33", 180L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2745), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936274", null, "12", "33", 220L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2746), 0 },
                    { "34", 3600L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2752), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936275", null, "12", "34", 4400L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2753), 0 },
                    { "35", 9000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2759), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936276", null, "12", "35", 11000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2761), 0 },
                    { "36", 330L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2767), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936277", null, "13", "36", 370L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2768), 0 },
                    { "37", 3960L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2774), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936279", null, "13", "37", 4440L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2797), 0 },
                    { "38", 7920L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2805), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936280", null, "13", "38", 8880L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2806), 0 },
                    { "39", 160L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2813), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936281", null, "14", "39", 200L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2814), 0 },
                    { "4", 130L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2461), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936246", null, "2", "4", 150L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2467), 0 },
                    { "40", 3840L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2820), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936282", null, "14", "40", 4800L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2821), 0 },
                    { "41", 11520L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2827), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936283", null, "14", "41", 14400L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2829), 0 },
                    { "42", 230L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2835), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936283", null, "15", "42", 270L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2836), 0 },
                    { "43", 11500L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2842), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936284", null, "15", "43", 13500L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2843), 0 },
                    { "44", 46000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2849), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936285", null, "15", "44", 54000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2851), 0 },
                    { "45", 750L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2857), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936286", null, "16", "45", 850L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2858), 0 },
                    { "46", 15000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2865), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936286", null, "16", "46", 17000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2867), 0 },
                    { "47", 75000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2873), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936287", null, "16", "47", 85000L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2875), 0 },
                    { "5", 1560L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2475), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936247", null, "2", "5", 1800L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2476), 0 },
                    { "6", 3120L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2487), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936249", null, "2", "6", 3600L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2488), 0 },
                    { "7", 70L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2494), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936249", null, "3", "7", 90L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2496), 0 },
                    { "8", 420L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2502), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936250", null, "3", "8", 540L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2503), 0 },
                    { "9", 840L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2509), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-03-28 13:26:59.936251", null, "3", "9", 1080L, null, new DateTime(2026, 3, 28, 13, 26, 59, 936, DateTimeKind.Utc).AddTicks(2511), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 3, 28, 13, 26, 59, 939, DateTimeKind.Utc).AddTicks(9686), "Unchanged", false, "2026-03-28 13:26:59.939980", "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 939, DateTimeKind.Utc).AddTicks(9761), 0 },
                    { "10", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4287), "Unchanged", false, "2026-03-28 13:26:59.940429", "7", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4289), 0 },
                    { "2", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(1123), "Unchanged", false, "2026-03-28 13:26:59.940171", "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(1471), 0 },
                    { "3", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(2825), "Unchanged", false, "2026-03-28 13:26:59.940388", "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(3490), 0 },
                    { "4", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4217), "Unchanged", false, "2026-03-28 13:26:59.940422", "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4222), 0 },
                    { "5", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4236), "Unchanged", false, "2026-03-28 13:26:59.940423", "4", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4237), 0 },
                    { "6", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4247), "Unchanged", false, "2026-03-28 13:26:59.940424", "4", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4248), 0 },
                    { "7", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4257), "Unchanged", false, "2026-03-28 13:26:59.940425", "4", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "3", "Pack", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4258), 0 },
                    { "8", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4268), "Unchanged", false, "2026-03-28 13:26:59.940427", "7", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "1", "Piece", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4269), 0 },
                    { "9", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4278), "Unchanged", false, "2026-03-28 13:26:59.940428", "7", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 3, 28, 13, 26, 59, 940, DateTimeKind.Utc).AddTicks(4279), 0 }
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
