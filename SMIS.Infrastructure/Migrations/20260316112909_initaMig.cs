using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class initaMig : Migration
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
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    Status = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    PaymentStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    PaymentMethod = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
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
                    { "1", "en", "Added", true, new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 358, DateTimeKind.Unspecified).AddTicks(5998), new TimeSpan(0, 0, 0, 0, 0)), "English", 0 },
                    { "2", "ps", "Added", true, new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 358, DateTimeKind.Unspecified).AddTicks(6535), new TimeSpan(0, 0, 0, 0, 0)), "Pashto", 0 },
                    { "3", "fa", "Added", true, new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 358, DateTimeKind.Unspecified).AddTicks(6542), new TimeSpan(0, 0, 0, 0, 0)), "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, "Unchanged", false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Kabul", null, null, 0 },
                    { "2", null, null, "Unchanged", false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Herat", null, null, 0 },
                    { "3", null, null, "Unchanged", false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Kandahar", null, null, 0 },
                    { "4", null, null, "Unchanged", false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Balkh", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "EntityState", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 3, 16, 15, 59, 9, 363, DateTimeKind.Local).AddTicks(7339), "main@store.local", "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 363, DateTimeKind.Unspecified).AddTicks(7551), new TimeSpan(0, 4, 30, 0, 0)), null, "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 3, 16, 15, 59, 9, 363, DateTimeKind.Local).AddTicks(7458), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 3, 16, 15, 59, 9, 363, DateTimeKind.Local).AddTicks(8534), "branch@store.local", "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 363, DateTimeKind.Unspecified).AddTicks(9623), new TimeSpan(0, 4, 30, 0, 0)), null, "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 3, 16, 15, 59, 9, 363, DateTimeKind.Local).AddTicks(9157), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 3, 16, 15, 59, 9, 364, DateTimeKind.Local).AddTicks(697), "warehouse@store.local", "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 364, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 4, 30, 0, 0)), null, "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 3, 16, 15, 59, 9, 364, DateTimeKind.Local).AddTicks(1367), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "1001", "Kabul Center District", null, null, 0 },
                    { "2", null, null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "1002", "Kabul North District", null, null, 0 },
                    { "3", null, null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "1003", "Herat Center District", null, null, 0 },
                    { "4", null, null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "2001", "Kabul Province", null, null, 0 },
                    { "5", null, null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "2002", "Herat Province", null, null, 0 },
                    { "6", null, null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "3001", "Welcome Message", null, null, 0 },
                    { "7", null, null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "3002", "Error Message", null, null, 0 },
                    { "8", null, null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "3003", "Success Message", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "81c71e35-21cf-4ffd-a650-1d39a6a57ca0", "superadmin@smis.com", true, "Unchanged", "Super", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAENEZPM1NNGGz6yOn5LUfHL5ivEv7QIVb22LMWj0WJTB0LzZhDNxw+nh/8bRsgIjjgg==", "+855123456789", true, "50c1867a-f7ba-4110-b803-7c13d28ff205", "1", "Main Store", false, "superadmin", 0 },
                    { "10", 0, "13ffa3b3-58dd-4623-abef-2b42c08aa2de", "radministration@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAECbTEBDCBC6kfzEuSYHtYwfpVGdYQLQNPq+EVHNrXbyDXd1rFsmQz/ZRi06QShc64Q==", "+855123456798", true, "2a84b322-cb9c-4631-b256-106c74c67673", "2", "Branch Store", false, "radministration", 0 },
                    { "11", 0, "d2c0b61b-5d2e-4d42-8812-3c161059798e", "rmanager@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEBY6pH0FPpfzvtM7gNDg1ifmBMatE6ySDZbo7qxDDQyOamGvs3w3Yp4P7V4YM4bhpA==", "+855123456799", true, "237dc8fd-e663-4388-9ba6-c8ad64a334e3", "2", "Branch Store", false, "rmanager", 0 },
                    { "12", 0, "0f57be70-cd67-471d-8bdd-726ee0e378dc", "rstaff@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEEViG0irOrM2C0jxMlRbMIRGsNtZyExFFMb/i0kNUCX75uTuwjF31nko7CjnBa/0aA==", "+855123456800", true, "5f2dca20-e3d2-4ab6-8e21-ae9726df3ff6", "2", "Branch Store", false, "rstaff", 0 },
                    { "13", 0, "7607da8b-160b-414e-92eb-f979bbe4a957", "rviewer@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEAyZa+4EKGfiPdwfwFD7I9TlCiu/KROPcC43TPdI/lDA7RnoG9GttLxktK1MB837mg==", "+855123456801", true, "dbc97a67-7561-4a1c-b0fc-7b8c5d4b5f7e", "2", "Branch Store", false, "rviewer", 0 },
                    { "14", 0, "120d5315-f3c1-429d-951a-f182b7001442", "reditor@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAELMiD66wN4VhepX0gpiqsVMOZWkELmUmdGrVQUtobrNFkGrrA1T2CRh9hIfy7xbWaw==", "+855123456802", true, "51e165a5-f026-4281-b555-771874c53d50", "2", "Branch Store", false, "reditor", 0 },
                    { "15", 0, "3b5b4a21-365c-4c0f-bf5c-0b7e76ab34f5", "ruser@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEHDIgk15tt2q98/0ouOOjTlJDHUGzWZXBq1W+1jTLDsu3i3PSYWwEoFoa1eLkzSskw==", "+855123456803", true, "7ce7cf6b-e18f-43a6-9134-396182197e92", "2", "Branch Store", false, "ruser", 0 },
                    { "2", 0, "404cd4c4-1115-4c41-a0ab-712fbf5a014b", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAELOrjAELNjKBz5FiyfUqXYfAg3iCHIIAyDg8/eQMmQeCtD7tWeNLgnJ5FyrfWm5bmA==", "+855123456790", true, "0b1e3609-fe72-4f42-a913-3187b14ccb4c", "1", "Main Store", false, "wadmin", 0 },
                    { "3", 0, "d915e027-e4b5-48a5-bdc5-a3b979741333", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEHJgTcwfXNbbsdEESAqJkhx5HE/7YscSClbRNSfhIsqyE/YVRZTQDEB53MaAa0gAfQ==", "+855123456791", true, "5379c3e1-7980-4caa-8d40-5f0726595d14", "1", "Main Store", false, "wadministration", 0 },
                    { "4", 0, "2e5724ec-0600-49e1-b235-44bf1c903baa", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAECirzDv0Dr9fBofy/07AqI1dfyRQDx5nJjycJjtl5e8G+OYU0FEGj7Tzk1Dr0hY9Eg==", "+855123456792", true, "8b54ac42-d919-4969-8688-9114170a7ccd", "1", "Main Store", false, "wmanager", 0 },
                    { "5", 0, "79d47e21-ce07-49eb-a0ad-c813d2aeef35", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAEGbbXCLCyTzaokjlogu2Pu/NYIPeomlfqwK/WB4xAmAohmEAN4JLKx1m+ahKLsjXTA==", "+855123456793", true, "1bb2d2be-7a5e-4323-83fc-86635781305c", "1", "Main Store", false, "wstaff", 0 },
                    { "6", 0, "166fe22d-dac8-4a60-9eba-ecfb55e3122a", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEL+EJUO66TXH6CfUSIAItI8OGOp+DBUQXn1rq3HFhJsXVcJB+ZS/GOgmAU226d3bCA==", "+8512345634366", true, "e092b450-2750-43fb-b2d5-97644ebd0e78", "1", "Main Store", false, "wviewer", 0 },
                    { "7", 0, "d82d7aa0-85e1-4baa-a4a1-5a08e8ec9be7", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEBwmYl0C324PelZlHTHtksB7efzfcR12lVhQ0ovO+dguHuEXmYa4nTiFPVsvu9PAnw==", "+855123456795", true, "a5c79a32-038a-4d3c-a518-5f9aeba624a2", "1", "Main Store", false, "weditor", 0 },
                    { "8", 0, "6d92aebf-b88a-44da-aa8a-7fdbc9b15eb7", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEArO6kU6t3LONIAkjQTgBCEpVqEutt4bULU5q/72BMOUl6KQnFuk0OnR1llWsC+X8A==", "+855123456796", true, "c8d501a1-33af-4ef2-890e-bbd7c38829bd", "1", "Main Store", false, "wuser", 0 },
                    { "9", 0, "f1fe402e-1503-4f7d-9e7e-456323478a64", "radmin@smis.com", true, "Unchanged", "Retail", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEBRLKHlcp7l7IHrdRkklT9xKPMfW+8eYZwsUcnI3DX1HjQ4gWrE8pCDEsc54xvgACQ==", "+855123456797", true, "230b6bb3-5b0c-4757-83e0-08de6b49c24f", "2", "Branch Store", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 3, 16, 15, 59, 9, 368, DateTimeKind.Local).AddTicks(6814), "Drinks and beverages", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 368, DateTimeKind.Unspecified).AddTicks(7020), new TimeSpan(0, 4, 30, 0, 0)), "Beverages", "1", null, new DateTime(2026, 3, 16, 15, 59, 9, 368, DateTimeKind.Local).AddTicks(6915), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 3, 16, 15, 59, 9, 368, DateTimeKind.Local).AddTicks(7913), "Edible products and snacks", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 368, DateTimeKind.Unspecified).AddTicks(9067), new TimeSpan(0, 4, 30, 0, 0)), "Food Items", "1", null, new DateTime(2026, 3, 16, 15, 59, 9, 368, DateTimeKind.Local).AddTicks(8650), 0 },
                    { "3", "STAT", null, new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Local).AddTicks(44), "Office and school supplies", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Unspecified).AddTicks(1191), new TimeSpan(0, 4, 30, 0, 0)), "Stationery", "2", null, new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Local).AddTicks(699), 0 },
                    { "4", "GROC", null, new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Local).AddTicks(1686), "Daily household items", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Unspecified).AddTicks(1699), new TimeSpan(0, 4, 30, 0, 0)), "Grocery", "2", null, new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Local).AddTicks(1695), 0 },
                    { "5", "CARE", null, new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Local).AddTicks(1708), "Health and hygiene products", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 4, 30, 0, 0)), "Personal Care", "3", null, new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Local).AddTicks(1712), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Local).AddTicks(1722), "Electronic devices and accessories", "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 4, 30, 0, 0)), "Electronics", "3", null, new DateTime(2026, 3, 16, 15, 59, 9, 369, DateTimeKind.Local).AddTicks(1724), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, "Unchanged", false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Kabul Center", "1", null, null, 0 },
                    { "2", null, null, "Unchanged", false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Kabul North", "2", null, null, 0 },
                    { "3", null, null, "Unchanged", false, true, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Herat Center", "3", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1113), new TimeSpan(0, 0, 0, 0, 0)), "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1961), new TimeSpan(0, 0, 0, 0, 0)), "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1964), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1966), new TimeSpan(0, 0, 0, 0, 0)), "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1911), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 0, 0, 0, 0)), "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1943), new TimeSpan(0, 0, 0, 0, 0)), "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1945), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1948), new TimeSpan(0, 0, 0, 0, 0)), "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1954), new TimeSpan(0, 0, 0, 0, 0)), "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1956), new TimeSpan(0, 0, 0, 0, 0)), "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", new DateTimeOffset(new DateTime(2026, 3, 16, 11, 29, 9, 360, DateTimeKind.Unspecified).AddTicks(1959), new TimeSpan(0, 0, 0, 0, 0)), "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "IsSyncedToServer", "LanguageNo", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, "Unchanged", false, true, "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Kabul Center District", "1", null, null, 0 },
                    { "10", null, null, "Unchanged", false, true, "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "ولایت هرات", "5", null, null, 0 },
                    { "11", null, null, "Unchanged", false, true, "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Welcome Message", "6", null, null, 0 },
                    { "12", null, null, "Unchanged", false, true, "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "پیام خوش آمدید", "6", null, null, 0 },
                    { "2", null, null, "Unchanged", false, true, "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "منطقه مرکز کابل", "1", null, null, 0 },
                    { "3", null, null, "Unchanged", false, true, "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Kabul North District", "2", null, null, 0 },
                    { "4", null, null, "Unchanged", false, true, "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "منطقه شمال کابل", "2", null, null, 0 },
                    { "5", null, null, "Unchanged", false, true, "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Herat Center District", "3", null, null, 0 },
                    { "6", null, null, "Unchanged", false, true, "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "منطقه مرکز هرات", "3", null, null, 0 },
                    { "7", null, null, "Unchanged", false, true, "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Kabul Province", "4", null, null, 0 },
                    { "8", null, null, "Unchanged", false, true, "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "ولایت کابل", "4", null, null, 0 },
                    { "9", null, null, "Unchanged", false, true, "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Herat Province", "5", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(3420), new TimeSpan(0, 4, 30, 0, 0)), "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(7435), new TimeSpan(0, 4, 30, 0, 0)), "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(4916), new TimeSpan(0, 4, 30, 0, 0)), "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(6434), new TimeSpan(0, 4, 30, 0, 0)), "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(7371), new TimeSpan(0, 4, 30, 0, 0)), "Box", "1", "box", 0 },
                    { "5", "Large containers", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, 4, 30, 0, 0)), "Carton", "1", "ctn", 0 },
                    { "6", "Volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 4, 30, 0, 0)), "Liter", "1", "L", 0 },
                    { "7", "Weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(7402), new TimeSpan(0, 4, 30, 0, 0)), "Kilogram", "1", "kg", 0 },
                    { "8", "Small weight measurement", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 4, 30, 0, 0)), "Gram", "1", "g", 0 },
                    { "9", "Small volume measurement", "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 361, DateTimeKind.Unspecified).AddTicks(7425), new TimeSpan(0, 4, 30, 0, 0)), "Milliliter", "1", "ml", 0 }
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
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 3, 16, 15, 59, 9, 370, DateTimeKind.Local).AddTicks(5924), "Individual", null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 370, DateTimeKind.Unspecified).AddTicks(6150), new TimeSpan(0, 4, 30, 0, 0)), "Doe", null, "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 3, 16, 15, 59, 9, 370, DateTimeKind.Local).AddTicks(6041), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(746), "Individual", null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 4, 30, 0, 0)), "Rodriguez", null, "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(747), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 3, 16, 15, 59, 9, 370, DateTimeKind.Local).AddTicks(7733), "Individual", null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 370, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 4, 30, 0, 0)), "Smith", null, "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 3, 16, 15, 59, 9, 370, DateTimeKind.Local).AddTicks(8176), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 3, 16, 15, 59, 9, 370, DateTimeKind.Local).AddTicks(9484), "Enterprise", null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Unspecified).AddTicks(276), new TimeSpan(0, 4, 30, 0, 0)), "Brown", null, "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 3, 16, 15, 59, 9, 370, DateTimeKind.Local).AddTicks(9950), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(598), "Individual", null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Unspecified).AddTicks(604), new TimeSpan(0, 4, 30, 0, 0)), "Wilson", null, "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(602), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(684), "Individual", null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Unspecified).AddTicks(688), new TimeSpan(0, 4, 30, 0, 0)), "Taylor", null, "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(686), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(700), "Enterprise", null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Unspecified).AddTicks(703), new TimeSpan(0, 4, 30, 0, 0)), "Garcia", null, "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(701), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(711), "Individual", null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 4, 30, 0, 0)), "Martinez", null, "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(713), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(723), "Individual", null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 4, 30, 0, 0)), "Lopez", null, "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(725), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(734), "Enterprise", null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Unspecified).AddTicks(737), new TimeSpan(0, 4, 30, 0, 0)), "Gonzalez", null, "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 3, 16, 15, 59, 9, 371, DateTimeKind.Local).AddTicks(735), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "Description", "EntityState", "ImageUrl", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(618), "Classic cola drink", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(879), new TimeSpan(0, 4, 30, 0, 0)), null, "Coca Cola 500ml", "COKE-500ML-001", "1", "Main Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(771), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7909), "Sunflower cooking oil", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 4, 30, 0, 0)), null, "Cooking Oil 1L", "OIL-1L-010", "1", "Main Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7914), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7947), "Basmati rice", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7953), new TimeSpan(0, 4, 30, 0, 0)), null, "Rice 1kg", "RICE-1KG-011", "2", "Branch Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7950), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7966), "White granulated sugar", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7985), new TimeSpan(0, 4, 30, 0, 0)), null, "Sugar 1kg", "SUGAR-1KG-012", "3", "Warehouse", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7972), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7998), "Hair care shampoo", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 4, 30, 0, 0)), null, "Shampoo 400ml", "SHAMP-400ML-013", "1", "Main Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(8002), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(8017), "Dental care paste", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(8023), new TimeSpan(0, 4, 30, 0, 0)), null, "Toothpaste", "TOOTH-PASTE-014", "2", "Branch Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(8020), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(8036), "Type-C charging cable", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(8042), new TimeSpan(0, 4, 30, 0, 0)), null, "USB Cable", "USB-CABLE-015", "1", "Main Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(8039), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(8055), "Fast charging adapter", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(8107), new TimeSpan(0, 4, 30, 0, 0)), null, "Phone Charger", "CHARGER-016", "3", "Warehouse", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(8104), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(2893), "Cola soft drink", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 4, 30, 0, 0)), null, "Pepsi 500ml", "PEPSI-500ML-002", "1", "Main Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(3442), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(6030), "Pure drinking water", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7225), new TimeSpan(0, 4, 30, 0, 0)), null, "Mineral Water 1L", "WATER-1L-003", "2", "Branch Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(6693), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7735), "Chocolate sandwich cookies", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 4, 30, 0, 0)), null, "Oreo Biscuits", "OREO-PACK-004", "1", "Main Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7741), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7798), "Potato chips", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7805), new TimeSpan(0, 4, 30, 0, 0)), null, "Lay's Chips", "LAYS-PACK-005", "2", "Branch Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7801), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7820), "Quick meal noodles", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, 4, 30, 0, 0)), null, "Instant Noodles", "NOODLE-PACK-006", "3", "Warehouse", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7823), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7845), "200 pages ruled notebook", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7851), new TimeSpan(0, 4, 30, 0, 0)), null, "A4 Notebook", "NOTE-A4-007", "1", "Main Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7848), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7865), "Ballpoint pen", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7871), new TimeSpan(0, 4, 30, 0, 0)), null, "Blue Pen", "PEN-BLUE-008", "2", "Branch Store", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7868), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7884), "12 pencils per box", "Unchanged", null, true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 4, 30, 0, 0)), null, "Pencil Set", "PENCIL-BOX-009", "3", "Warehouse", null, new DateTime(2026, 3, 16, 15, 59, 9, 367, DateTimeKind.Local).AddTicks(7890), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Local).AddTicks(6453), null, "john.doe@example.com", null, "Unchanged", "John", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 4, 30, 0, 0)), "Doe", null, "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(4087), null, new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Local).AddTicks(6536), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Local).AddTicks(7652), null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Unspecified).AddTicks(8214), new TimeSpan(0, 4, 30, 0, 0)), "Smith", null, "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Local).AddTicks(6615), null, new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Local).AddTicks(7966), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Local).AddTicks(9064), null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 4, 30, 0, 0)), "Johnson", null, "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Local).AddTicks(8405), null, new DateTime(2026, 3, 16, 15, 59, 8, 761, DateTimeKind.Local).AddTicks(9507), 0 }
                });

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DueDate", "EntityState", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(3400), "1", "John", new DateTime(2026, 4, 15, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 2, 14, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Coca Cola loan for John", 5000m, "1", "Coca Cola 500ml", 10m, "1", "Main Store", 1, 50000L, "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(3458), 0 },
                    { "10", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8816), "9", "James", new DateTime(2026, 4, 12, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(8818), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 3, 13, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "USB cables for James", 1000m, "15", "USB Cable", 100m, "3", "Warehouse", 1, 100000L, "1", "Piece", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8817), 0 },
                    { "2", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(5511), "2", "Jane", new DateTime(2026, 3, 31, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(6017), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 3, 1, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Oreo biscuits for Jane", 4000m, "4", "Oreo Biscuits", 5m, "1", "Main Store", 1, 20000L, "3", "Pack", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(5817), 0 },
                    { "3", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(7787), "3", "Michael", new DateTime(2026, 4, 5, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(8428), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 3, 6, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Notebooks for Michael", 3000m, "7", "A4 Notebook", 20m, "1", "Main Store", 1, 60000L, "1", "Piece", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8137), 0 },
                    { "4", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8723), "1", "John", new DateTime(2026, 4, 30, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(8731), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 3, 11, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Cooking oil bulk order", 8000m, "10", "Cooking Oil 1L", 15m, "1", "Main Store", 1, 120000L, "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8728), 0 },
                    { "5", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8745), "4", "Sarah", new DateTime(2026, 3, 26, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 2, 24, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Pepsi for Sarah", 4500m, "2", "Pepsi 500ml", 24m, "2", "Branch Store", 1, 108000L, "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8747), 0 },
                    { "6", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8759), "5", "David", new DateTime(2026, 4, 3, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 3, 4, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Blue pens for David", 500m, "8", "Blue Pen", 50m, "2", "Branch Store", 1, 25000L, "1", "Piece", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8761), 0 },
                    { "7", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8774), "6", "Lisa", null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 2, 19, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Rice bulk purchase", 2000m, "11", "Rice 1kg", 100m, "2", "Branch Store", 1, 200000L, "7", "Kilogram", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8776), 0 },
                    { "8", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8788), "7", "Robert", new DateTime(2026, 3, 28, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(8791), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 2, 26, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Mineral water for Robert", 3000m, "3", "Mineral Water 1L", 48m, "3", "Warehouse", 1, 144000L, "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8789), 0 },
                    { "9", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8802), "8", "Emily", new DateTime(2026, 4, 7, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Unspecified).AddTicks(8805), new TimeSpan(0, 4, 30, 0, 0)), null, new DateTime(2026, 3, 8, 15, 59, 8, 762, DateTimeKind.Local).AddTicks(3622), "Instant noodles for Emily", 1500m, "6", "Instant Noodles", 30m, "3", "Warehouse", 1, 45000L, "3", "Pack", null, new DateTime(2026, 3, 16, 15, 59, 8, 763, DateTimeKind.Local).AddTicks(8803), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 748, DateTimeKind.Unspecified).AddTicks(2074), new TimeSpan(0, 4, 30, 0, 0)), "1", "Coca Cola 500ml", "Bottle", "2", 0 },
                    { "10", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1478), new TimeSpan(0, 4, 30, 0, 0)), "4", "Oreo Biscuits", "Pack", "3", 0 },
                    { "11", 12m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1487), new TimeSpan(0, 4, 30, 0, 0)), "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "12", 48m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 4, 30, 0, 0)), "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "13", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1499), new TimeSpan(0, 4, 30, 0, 0)), "5", "Lay's Chips", "Pack", "3", 0 },
                    { "14", 20m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1504), new TimeSpan(0, 4, 30, 0, 0)), "5", "Lay's Chips", "Box", "4", 0 },
                    { "15", 60m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1509), new TimeSpan(0, 4, 30, 0, 0)), "5", "Lay's Chips", "Carton", "5", 0 },
                    { "16", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1515), new TimeSpan(0, 4, 30, 0, 0)), "6", "Instant Noodles", "Pack", "3", 0 },
                    { "17", 24m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1521), new TimeSpan(0, 4, 30, 0, 0)), "6", "Instant Noodles", "Box", "4", 0 },
                    { "18", 72m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1526), new TimeSpan(0, 4, 30, 0, 0)), "6", "Instant Noodles", "Carton", "5", 0 },
                    { "19", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1533), new TimeSpan(0, 4, 30, 0, 0)), "7", "A4 Notebook", "Piece", "1", 0 },
                    { "2", 12m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 749, DateTimeKind.Unspecified).AddTicks(9763), new TimeSpan(0, 4, 30, 0, 0)), "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "20", 12m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1539), new TimeSpan(0, 4, 30, 0, 0)), "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "21", 50m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 4, 30, 0, 0)), "7", "A4 Notebook", "Box", "4", 0 },
                    { "22", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 4, 30, 0, 0)), "8", "Blue Pen", "Piece", "1", 0 },
                    { "23", 12m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1556), new TimeSpan(0, 4, 30, 0, 0)), "8", "Blue Pen", "Dozen", "10", 0 },
                    { "24", 144m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1561), new TimeSpan(0, 4, 30, 0, 0)), "8", "Blue Pen", "Box", "4", 0 },
                    { "25", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1568), new TimeSpan(0, 4, 30, 0, 0)), "9", "Pencil Set", "Box", "4", 0 },
                    { "26", 20m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1573), new TimeSpan(0, 4, 30, 0, 0)), "9", "Pencil Set", "Carton", "5", 0 },
                    { "27", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 4, 30, 0, 0)), "10", "Cooking Oil 1L", "Bottle", "2", 0 },
                    { "28", 12m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1585), new TimeSpan(0, 4, 30, 0, 0)), "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "29", 24m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 4, 30, 0, 0)), "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "3", 24m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(847), new TimeSpan(0, 4, 30, 0, 0)), "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "30", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 4, 30, 0, 0)), "11", "Rice 1kg", "Kilogram", "7", 0 },
                    { "31", 10m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1671), new TimeSpan(0, 4, 30, 0, 0)), "11", "Rice 1kg", "Box", "4", 0 },
                    { "32", 25m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, 4, 30, 0, 0)), "11", "Rice 1kg", "Carton", "5", 0 },
                    { "33", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1684), new TimeSpan(0, 4, 30, 0, 0)), "12", "Sugar 1kg", "Kilogram", "7", 0 },
                    { "34", 20m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1689), new TimeSpan(0, 4, 30, 0, 0)), "12", "Sugar 1kg", "Box", "4", 0 },
                    { "35", 50m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 4, 30, 0, 0)), "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "36", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1702), new TimeSpan(0, 4, 30, 0, 0)), "13", "Shampoo 400ml", "Bottle", "2", 0 },
                    { "37", 12m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1707), new TimeSpan(0, 4, 30, 0, 0)), "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "38", 24m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1712), new TimeSpan(0, 4, 30, 0, 0)), "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "39", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1718), new TimeSpan(0, 4, 30, 0, 0)), "14", "Toothpaste", "Piece", "1", 0 },
                    { "4", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1440), new TimeSpan(0, 4, 30, 0, 0)), "2", "Pepsi 500ml", "Bottle", "2", 0 },
                    { "40", 24m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1723), new TimeSpan(0, 4, 30, 0, 0)), "14", "Toothpaste", "Box", "4", 0 },
                    { "41", 72m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1729), new TimeSpan(0, 4, 30, 0, 0)), "14", "Toothpaste", "Carton", "5", 0 },
                    { "42", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 4, 30, 0, 0)), "15", "USB Cable", "Piece", "1", 0 },
                    { "43", 50m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1741), new TimeSpan(0, 4, 30, 0, 0)), "15", "USB Cable", "Box", "4", 0 },
                    { "44", 200m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1746), new TimeSpan(0, 4, 30, 0, 0)), "15", "USB Cable", "Carton", "5", 0 },
                    { "45", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1751), new TimeSpan(0, 4, 30, 0, 0)), "16", "Phone Charger", "Piece", "1", 0 },
                    { "46", 20m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1757), new TimeSpan(0, 4, 30, 0, 0)), "16", "Phone Charger", "Box", "4", 0 },
                    { "47", 100m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1763), new TimeSpan(0, 4, 30, 0, 0)), "16", "Phone Charger", "Carton", "5", 0 },
                    { "5", 12m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1448), new TimeSpan(0, 4, 30, 0, 0)), "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "6", 24m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 4, 30, 0, 0)), "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "7", 1m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 4, 30, 0, 0)), "3", "Mineral Water 1L", "Bottle", "2", 0 },
                    { "8", 6m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1466), new TimeSpan(0, 4, 30, 0, 0)), "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "9", 12m, "Added", new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 750, DateTimeKind.Unspecified).AddTicks(1472), new TimeSpan(0, 4, 30, 0, 0)), "3", "Mineral Water 1L", "Carton", "5", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Local).AddTicks(1463), "Unchanged", new DateTime(2026, 9, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(4150), false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Unspecified).AddTicks(1765), new TimeSpan(0, 4, 30, 0, 0)), "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 3, 6, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(4150), "Active", "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Local).AddTicks(1630), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Local).AddTicks(2939), "Unchanged", new DateTime(2026, 10, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(4150), false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Unspecified).AddTicks(3536), new TimeSpan(0, 4, 30, 0, 0)), "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 3, 11, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(4150), "Active", "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Local).AddTicks(3260), 0 },
                    { "3", "OREO-101", null, new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Local).AddTicks(4647), "Unchanged", new DateTime(2026, 6, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(4150), false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, 4, 30, 0, 0)), "4", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 3, 1, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(4150), "Active", "3", "Pack", null, new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Local).AddTicks(5195), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Local).AddTicks(5855), "Unchanged", null, false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Unspecified).AddTicks(5860), new TimeSpan(0, 4, 30, 0, 0)), "7", "A4 Notebook", 120000L, 200m, new DateTime(2026, 2, 24, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(4150), "Active", "1", "Piece", null, new DateTime(2026, 3, 16, 15, 59, 8, 753, DateTimeKind.Local).AddTicks(5858), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", 140L, null, new DateTime(2026, 3, 16, 15, 59, 8, 751, DateTimeKind.Local).AddTicks(7244), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 751, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 4, 30, 0, 0)), null, "1", "1", 160L, null, new DateTime(2026, 3, 16, 15, 59, 8, 751, DateTimeKind.Local).AddTicks(7954), 0 },
                    { "10", 230L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1677), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1679), new TimeSpan(0, 4, 30, 0, 0)), null, "4", "10", 270L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1678), 0 },
                    { "11", 2760L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1687), new TimeSpan(0, 4, 30, 0, 0)), null, "4", "11", 3240L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1685), 0 },
                    { "12", 11040L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1693), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 4, 30, 0, 0)), null, "4", "12", 12960L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1694), 0 },
                    { "13", 160L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1701), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 4, 30, 0, 0)), null, "5", "13", 190L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1702), 0 },
                    { "14", 3200L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1708), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, 4, 30, 0, 0)), null, "5", "14", 3800L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1710), 0 },
                    { "15", 9600L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1716), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1719), new TimeSpan(0, 4, 30, 0, 0)), null, "5", "15", 11400L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1718), 0 },
                    { "16", 110L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1727), new TimeSpan(0, 4, 30, 0, 0)), null, "6", "16", 130L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1725), 0 },
                    { "17", 2640L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1731), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 4, 30, 0, 0)), null, "6", "17", 3120L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1733), 0 },
                    { "18", 7920L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1739), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1741), new TimeSpan(0, 4, 30, 0, 0)), null, "6", "18", 9360L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1740), 0 },
                    { "19", 280L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1761), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1764), new TimeSpan(0, 4, 30, 0, 0)), null, "7", "19", 320L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1762), 0 },
                    { "2", 1680L, null, new DateTime(2026, 3, 16, 15, 59, 8, 751, DateTimeKind.Local).AddTicks(9010), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 751, DateTimeKind.Unspecified).AddTicks(9755), new TimeSpan(0, 4, 30, 0, 0)), null, "1", "2", 1920L, null, new DateTime(2026, 3, 16, 15, 59, 8, 751, DateTimeKind.Local).AddTicks(9447), 0 },
                    { "20", 3360L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1771), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 4, 30, 0, 0)), null, "7", "20", 3840L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1772), 0 },
                    { "21", 14000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1782), new TimeSpan(0, 4, 30, 0, 0)), null, "7", "21", 16000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1780), 0 },
                    { "22", 45L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1786), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1789), new TimeSpan(0, 4, 30, 0, 0)), null, "8", "22", 55L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1788), 0 },
                    { "23", 540L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1794), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1797), new TimeSpan(0, 4, 30, 0, 0)), null, "8", "23", 660L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1795), 0 },
                    { "24", 6480L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1801), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1804), new TimeSpan(0, 4, 30, 0, 0)), null, "8", "24", 7920L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1803), 0 },
                    { "25", 380L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1833), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1836), new TimeSpan(0, 4, 30, 0, 0)), null, "9", "25", 420L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1835), 0 },
                    { "26", 7600L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1842), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1845), new TimeSpan(0, 4, 30, 0, 0)), null, "9", "26", 8400L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1843), 0 },
                    { "27", 430L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1850), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1852), new TimeSpan(0, 4, 30, 0, 0)), null, "10", "27", 470L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1851), 0 },
                    { "28", 5160L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1858), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1861), new TimeSpan(0, 4, 30, 0, 0)), null, "10", "28", 5640L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1860), 0 },
                    { "29", 10320L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1866), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 4, 30, 0, 0)), null, "10", "29", 11280L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1867), 0 },
                    { "3", 3360L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(400), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1268), new TimeSpan(0, 4, 30, 0, 0)), null, "1", "3", 3840L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(914), 0 },
                    { "30", 260L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1873), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1877), new TimeSpan(0, 4, 30, 0, 0)), null, "11", "30", 300L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1875), 0 },
                    { "31", 2600L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1882), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 4, 30, 0, 0)), null, "11", "31", 3000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1883), 0 },
                    { "32", 6500L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1889), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1892), new TimeSpan(0, 4, 30, 0, 0)), null, "11", "32", 7500L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1890), 0 },
                    { "33", 180L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1896), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1899), new TimeSpan(0, 4, 30, 0, 0)), null, "12", "33", 220L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1897), 0 },
                    { "34", 3600L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 4, 30, 0, 0)), null, "12", "34", 4400L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1905), 0 },
                    { "35", 9000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1911), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 4, 30, 0, 0)), null, "12", "35", 11000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1913), 0 },
                    { "36", 330L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1920), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 4, 30, 0, 0)), null, "13", "36", 370L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1921), 0 },
                    { "37", 3960L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1927), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1930), new TimeSpan(0, 4, 30, 0, 0)), null, "13", "37", 4440L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1929), 0 },
                    { "38", 7920L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1934), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 4, 30, 0, 0)), null, "13", "38", 8880L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1936), 0 },
                    { "39", 160L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1942), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1945), new TimeSpan(0, 4, 30, 0, 0)), null, "14", "39", 200L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1944), 0 },
                    { "4", 130L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1581), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1588), new TimeSpan(0, 4, 30, 0, 0)), null, "2", "4", 150L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1585), 0 },
                    { "40", 3840L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1950), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1952), new TimeSpan(0, 4, 30, 0, 0)), null, "14", "40", 4800L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1951), 0 },
                    { "41", 11520L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1957), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1959), new TimeSpan(0, 4, 30, 0, 0)), null, "14", "41", 14400L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1958), 0 },
                    { "42", 230L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1964), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1966), new TimeSpan(0, 4, 30, 0, 0)), null, "15", "42", 270L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1965), 0 },
                    { "43", 11500L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1971), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1974), new TimeSpan(0, 4, 30, 0, 0)), null, "15", "43", 13500L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1972), 0 },
                    { "44", 46000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1999), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(2002), new TimeSpan(0, 4, 30, 0, 0)), null, "15", "44", 54000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(2001), 0 },
                    { "45", 750L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(2007), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 4, 30, 0, 0)), null, "16", "45", 850L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(2009), 0 },
                    { "46", 15000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(2015), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(2018), new TimeSpan(0, 4, 30, 0, 0)), null, "16", "46", 17000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(2016), 0 },
                    { "47", 75000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(2022), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 4, 30, 0, 0)), null, "16", "47", 85000L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(2023), 0 },
                    { "5", 1560L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1595), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1599), new TimeSpan(0, 4, 30, 0, 0)), null, "2", "5", 1800L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1597), 0 },
                    { "6", 3120L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1604), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, 4, 30, 0, 0)), null, "2", "6", 3600L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1605), 0 },
                    { "7", 70L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1653), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1656), new TimeSpan(0, 4, 30, 0, 0)), null, "3", "7", 90L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1654), 0 },
                    { "8", 420L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1661), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1664), new TimeSpan(0, 4, 30, 0, 0)), null, "3", "8", 540L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1662), 0 },
                    { "9", 840L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1668), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, true, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Unspecified).AddTicks(1671), new TimeSpan(0, 4, 30, 0, 0)), null, "3", "9", 1080L, null, new DateTime(2026, 3, 16, 15, 59, 8, 752, DateTimeKind.Local).AddTicks(1670), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 3, 16, 15, 59, 8, 754, DateTimeKind.Local).AddTicks(6096), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 754, DateTimeKind.Unspecified).AddTicks(6205), new TimeSpan(0, 4, 30, 0, 0)), "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 754, DateTimeKind.Local).AddTicks(6160), 0 },
                    { "10", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(530), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Unspecified).AddTicks(533), new TimeSpan(0, 4, 30, 0, 0)), "7", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(532), 0 },
                    { "2", null, new DateTime(2026, 3, 16, 15, 59, 8, 754, DateTimeKind.Local).AddTicks(7581), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 754, DateTimeKind.Unspecified).AddTicks(8235), new TimeSpan(0, 4, 30, 0, 0)), "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 754, DateTimeKind.Local).AddTicks(7922), 0 },
                    { "3", null, new DateTime(2026, 3, 16, 15, 59, 8, 754, DateTimeKind.Local).AddTicks(9383), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Unspecified).AddTicks(133), new TimeSpan(0, 4, 30, 0, 0)), "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 754, DateTimeKind.Local).AddTicks(9828), 0 },
                    { "4", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(418), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Unspecified).AddTicks(424), new TimeSpan(0, 4, 30, 0, 0)), "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(421), 0 },
                    { "5", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(470), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Unspecified).AddTicks(474), new TimeSpan(0, 4, 30, 0, 0)), "4", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(472), 0 },
                    { "6", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(482), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Unspecified).AddTicks(485), new TimeSpan(0, 4, 30, 0, 0)), "4", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(484), 0 },
                    { "7", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(494), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Unspecified).AddTicks(496), new TimeSpan(0, 4, 30, 0, 0)), "4", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "3", "Pack", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(495), 0 },
                    { "8", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(504), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Unspecified).AddTicks(507), new TimeSpan(0, 4, 30, 0, 0)), "7", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "1", "Piece", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(506), 0 },
                    { "9", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(519), "Unchanged", false, new DateTimeOffset(new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Unspecified).AddTicks(522), new TimeSpan(0, 4, 30, 0, 0)), "7", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 3, 16, 15, 59, 8, 755, DateTimeKind.Local).AddTicks(521), 0 }
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
