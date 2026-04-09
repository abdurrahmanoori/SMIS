using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppLogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ShopType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TranslationKeys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MessageCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslationKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LanguageId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    LanguageId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ShopId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TranslationKeyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TranslationKeyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LanguageNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NationalIdCardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OwnershipPercentage = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DistrictId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BaseUnitId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BaseUnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DistrictId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UnitOfMeasureId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConversionFactor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BatchNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    UnitId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchasePrice = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShopId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UnitId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PriceAtLoanTime = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TotalAmount = table.Column<long>(type: "bigint", nullable: false),
                    LoanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductUnitId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BuyPrice = table.Column<long>(type: "bigint", nullable: false),
                    SellPrice = table.Column<long>(type: "bigint", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StockBatchId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    UnitId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoanAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    EntityState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSyncedToServer = table.Column<bool>(type: "bit", nullable: false),
                    LastSyncedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    { "1", "en", "Added", true, "2026-04-09 18:59:41.358107", "English", 0 },
                    { "2", "ps", "Added", true, "2026-04-09 18:59:41.358197", "Pashto", 0 },
                    { "3", "fa", "Added", true, "2026-04-09 18:59:41.358198", "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:29:41.360102", null, "Kabul", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:29:41.360140", null, "Herat", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:29:41.360142", null, "Kandahar", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:29:41.360142", null, "Balkh", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedAt", "Email", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 4, 9, 23, 29, 41, 365, DateTimeKind.Local).AddTicks(2667), null, "main@store.local", "Unchanged", true, false, false, "2026-04-09 23:29:41.365352", "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 4, 9, 23, 29, 41, 365, DateTimeKind.Local).AddTicks(3285), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 4, 9, 23, 29, 41, 365, DateTimeKind.Local).AddTicks(4933), null, "branch@store.local", "Unchanged", true, false, false, "2026-04-09 23:29:41.365658", "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 4, 9, 23, 29, 41, 365, DateTimeKind.Local).AddTicks(5811), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 4, 9, 23, 29, 41, 365, DateTimeKind.Local).AddTicks(8169), null, "warehouse@store.local", "Unchanged", true, false, false, "2026-04-09 23:29:41.366004", "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 4, 9, 23, 29, 41, 365, DateTimeKind.Local).AddTicks(9141), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:29:41.358676", null, "1001", "Kabul Center District", null, null, 0 },
                    { "2", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:29:41.358771", null, "1002", "Kabul North District", null, null, 0 },
                    { "3", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:29:41.358772", null, "1003", "Herat Center District", null, null, 0 },
                    { "4", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:29:41.358772", null, "2001", "Kabul Province", null, null, 0 },
                    { "5", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:29:41.358773", null, "2002", "Herat Province", null, null, 0 },
                    { "6", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:29:41.358774", null, "3001", "Welcome Message", null, null, 0 },
                    { "7", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:29:41.358774", null, "3002", "Error Message", null, null, 0 },
                    { "8", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:29:41.358774", null, "3003", "Success Message", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "bd6008b1-8062-4991-afc8-5494225f7f24", "superadmin@smis.com", true, "Unchanged", "Super", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEJp0jlN4yf2/pI97qIsNO1MvFUXIP8ZB/K93r/xErpNrMAoxg6uovjYgI8m/KPLpdQ==", "+855123456789", true, "6add506d-2986-44fe-afde-c7a6c0a41f51", "1", "Main Store", false, "superadmin", 0 },
                    { "10", 0, "2a15aa68-3fc9-4d70-ac87-dceab6d6aba2", "radministration@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEIHQh+LMsOPyIcE2drhFw7tkIcCc374Ex/C74jjK5Nix4Xfn14CGahYgVjZ8O4Zd5g==", "+855123456798", true, "b7058591-d630-482e-a4b5-3d9f90750513", "2", "Branch Store", false, "radministration", 0 },
                    { "11", 0, "90819f07-470a-4464-929d-2a291511a7d0", "rmanager@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEArwjZPWHc7mpf8QbpKWCwqEa4nt069QZMFCsLc2wiWc1Hgbj8p4O9BL5FK6xr8SXQ==", "+855123456799", true, "9b90f524-2a52-43cd-b5a6-5ab6cda693b3", "2", "Branch Store", false, "rmanager", 0 },
                    { "12", 0, "efea54ed-e682-4c19-9e18-740080e99258", "rstaff@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEOW8ClxoqCYlkL+/gMH5/xc9zwRLAzcxj4EYD9S+/fjR+P4gEKGQ2jzsNhq2kdeKig==", "+855123456800", true, "75642e85-f8c3-449e-a65c-68e6b1f2ea3e", "2", "Branch Store", false, "rstaff", 0 },
                    { "13", 0, "d974221a-2229-41ce-86c8-0ee21de07b6e", "rviewer@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEAT0sSAgzm/8fcesEeKRLK4zeuCNxXJrvJI4PJKz6Y+JxQ1WBke00VJkVcbEofCPEQ==", "+855123456801", true, "635e33c0-4577-457a-b3b6-a71baf032e44", "2", "Branch Store", false, "rviewer", 0 },
                    { "14", 0, "84079614-8eba-4f1c-8091-d8fc134e8ca6", "reditor@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAEI5UmZGOiIc11PtgYIexU1FNmwyak2u57sifq07MNnU8SnjkrtBT410+K97rN2AN9g==", "+855123456802", true, "41136bac-2146-4ce8-986b-f76ea2c0abe6", "2", "Branch Store", false, "reditor", 0 },
                    { "15", 0, "78448531-4161-41ff-af7d-da8bc1ead969", "ruser@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEIv4iZhevwGhMODyhCIPu3calk3bEm3Uytv3gu51dNoyJI8DRW48WC3+rawO/xlHrA==", "+855123456803", true, "86cde101-7062-41f6-bd3b-4fa2922053a3", "2", "Branch Store", false, "ruser", 0 },
                    { "2", 0, "a1ce2d38-a725-428a-a9d3-6b0d96f13f60", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEKvib1HS7XUOsPJrds87qt4p13tqsz3NEN3QBUKQ07blPczhpy68IjRtki1j0CYfqQ==", "+855123456790", true, "a926b18e-a2fc-4877-8f2c-79e36e8ef0ba", "1", "Main Store", false, "wadmin", 0 },
                    { "3", 0, "b79060f3-29dc-4174-90fb-a37ac519aadd", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEEEZSLGwmFhgRfj1HRybwPlFQzj5IVKF/ondqA1Ntnp2X7FozWmEQXHRVgqOwv6x4Q==", "+855123456791", true, "7b7c240d-e3fc-4e84-afde-b0087e66016e", "1", "Main Store", false, "wadministration", 0 },
                    { "4", 0, "61343975-cf38-414e-8342-b436307d3eac", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEM/aLddB6FZqrS0Kjno5kif0GZJtLhXrT2zVPvs70qEUiHmbS9rBlcTyGI/tGA8DHA==", "+855123456792", true, "ac6ed76b-7f3a-4b42-9638-11137768a800", "1", "Main Store", false, "wmanager", 0 },
                    { "5", 0, "18002c26-182a-4300-b1c6-e481100da019", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAEEyIGha3tgVgE/j2f5rLHmP8lJaV5va0/AHoyyazcZw/R+s6gv3hMUrKwAxs6TMJ1A==", "+855123456793", true, "b37da186-df3d-43b5-be5e-2d93af042ffe", "1", "Main Store", false, "wstaff", 0 },
                    { "6", 0, "08880f3a-b05a-47ab-a8f6-0d1e84f42f1e", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEI7lBI1+NeTAvLdGcRN/oTeyDjqlMCdqHu8qwAZiuNhJ/Dqs3hpg+iB/cnqUR5+jQg==", "+8512345634366", true, "1418b226-e893-47b6-bca7-9037c7c07a9d", "1", "Main Store", false, "wviewer", 0 },
                    { "7", 0, "69981622-2925-494a-83a5-8ab763d5b30a", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEASgQ5Jv0/IyoGiEQuo9BHml5ZBuDr/ySCN+KWR5Cfa8tds74ilu0mto2A0Yg0HZ3w==", "+855123456795", true, "08038fa6-3a49-48ac-ae1a-2f0a2b7402d6", "1", "Main Store", false, "weditor", 0 },
                    { "8", 0, "f8ded3eb-d700-4595-94dc-049de376e208", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEI6IqYMDgazLs+bTx+00f0DgUXri3tYWsLqhE4I+zGIH2yfdqCeCr3b9D9tOgrastg==", "+855123456796", true, "93a0191f-a745-4aeb-980f-6a7260e70ca0", "1", "Main Store", false, "wuser", 0 },
                    { "9", 0, "06238824-e2b4-4e58-9cd1-a52f25112383", "radmin@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAENw1EPvhnmunBo27s28ga81vUD9dNRIP7Xl7suoweRl9r17D6V1xBjTG+krj1bamNA==", "+855123456797", true, "3b39c50f-09d0-41ff-8753-339fe707204b", "2", "Branch Store", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8064), null, "Drinks and beverages", "Unchanged", true, false, false, "2026-04-09 23:29:41.374807", "Beverages", "1", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8071), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8100), null, "Edible products and snacks", "Unchanged", true, false, false, "2026-04-09 23:29:41.374810", "Food Items", "1", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8101), 0 },
                    { "3", "STAT", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8106), null, "Office and school supplies", "Unchanged", true, false, false, "2026-04-09 23:29:41.374810", "Stationery", "2", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8107), 0 },
                    { "4", "GROC", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8112), null, "Daily household items", "Unchanged", true, false, false, "2026-04-09 23:29:41.374811", "Grocery", "2", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8112), 0 },
                    { "5", "CARE", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8128), null, "Health and hygiene products", "Unchanged", true, false, false, "2026-04-09 23:29:41.374812", "Personal Care", "3", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8129), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8134), null, "Electronic devices and accessories", "Unchanged", true, false, false, "2026-04-09 23:29:41.374813", "Electronics", "3", null, new DateTime(2026, 4, 9, 23, 29, 41, 374, DateTimeKind.Local).AddTicks(8135), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:29:41.360693", null, "Kabul Center", "1", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:29:41.360753", null, "Kabul North", "2", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:29:41.360753", null, "Herat Center", "3", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", "2026-04-09 18:59:41.360256", "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", "2026-04-09 18:59:41.360435", "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", "2026-04-09 18:59:41.360435", "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", "2026-04-09 18:59:41.360435", "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", "2026-04-09 18:59:41.360431", "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", "2026-04-09 18:59:41.360432", "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", "2026-04-09 18:59:41.360433", "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", "2026-04-09 18:59:41.360434", "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", "2026-04-09 18:59:41.360434", "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", "2026-04-09 18:59:41.360434", "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", "2026-04-09 18:59:41.360434", "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", "2026-04-09 18:59:41.360435", "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LanguageNo", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:29:41.359267", null, "Kabul Center District", "1", null, null, 0 },
                    { "10", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:29:41.359406", null, "ولایت هرات", "5", null, null, 0 },
                    { "11", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:29:41.359406", null, "Welcome Message", "6", null, null, 0 },
                    { "12", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:29:41.359406", null, "پیام خوش آمدید", "6", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:29:41.359401", null, "منطقه مرکز کابل", "1", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:29:41.359401", null, "Kabul North District", "2", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:29:41.359402", null, "منطقه شمال کابل", "2", null, null, 0 },
                    { "5", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:29:41.359403", null, "Herat Center District", "3", null, null, 0 },
                    { "6", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:29:41.359403", null, "منطقه مرکز هرات", "3", null, null, 0 },
                    { "7", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:29:41.359405", null, "Kabul Province", "4", null, null, 0 },
                    { "8", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:29:41.359405", null, "ولایت کابل", "4", null, null, 0 },
                    { "9", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:29:41.359406", null, "Herat Province", "5", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", "2026-04-09 23:29:41.362136", "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", "2026-04-09 23:29:41.362613", "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", "2026-04-09 23:29:41.362299", "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", "2026-04-09 23:29:41.362497", "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", "2026-04-09 23:29:41.362607", "Box", "1", "box", 0 },
                    { "5", "Large containers", "Added", "2026-04-09 23:29:41.362608", "Carton", "1", "ctn", 0 },
                    { "6", "Volume measurement", "Added", "2026-04-09 23:29:41.362609", "Liter", "1", "L", 0 },
                    { "7", "Weight measurement", "Added", "2026-04-09 23:29:41.362610", "Kilogram", "1", "kg", 0 },
                    { "8", "Small weight measurement", "Added", "2026-04-09 23:29:41.362610", "Gram", "1", "g", 0 },
                    { "9", "Small volume measurement", "Added", "2026-04-09 23:29:41.362612", "Milliliter", "1", "ml", 0 }
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
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 4, 9, 23, 29, 41, 376, DateTimeKind.Local).AddTicks(8115), "Individual", null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, true, "2026-04-09 23:29:41.376850", "Doe", null, "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 4, 9, 23, 29, 41, 376, DateTimeKind.Local).AddTicks(8344), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1627), "Individual", null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, true, "2026-04-09 23:29:41.378163", "Rodriguez", null, "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1633), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 4, 9, 23, 29, 41, 377, DateTimeKind.Local).AddTicks(836), "Individual", null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, true, "2026-04-09 23:29:41.377253", "Smith", null, "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 4, 9, 23, 29, 41, 377, DateTimeKind.Local).AddTicks(1703), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 4, 9, 23, 29, 41, 377, DateTimeKind.Local).AddTicks(5820), "Enterprise", null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, true, "2026-04-09 23:29:41.377984", "Brown", null, "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 4, 9, 23, 29, 41, 377, DateTimeKind.Local).AddTicks(7656), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1341), "Individual", null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, true, "2026-04-09 23:29:41.378137", "Wilson", null, "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1363), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1404), "Individual", null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, true, "2026-04-09 23:29:41.378141", "Taylor", null, "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1410), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1471), "Enterprise", null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, true, "2026-04-09 23:29:41.378148", "Garcia", null, "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1478), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1510), "Individual", null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, true, "2026-04-09 23:29:41.378152", "Martinez", null, "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1516), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1552), "Individual", null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, true, "2026-04-09 23:29:41.378156", "Lopez", null, "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1559), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1588), "Enterprise", null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, true, "2026-04-09 23:29:41.378159", "Gonzalez", null, "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 4, 9, 23, 29, 41, 378, DateTimeKind.Local).AddTicks(1594), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "ImageUrl", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 4, 9, 23, 29, 41, 372, DateTimeKind.Local).AddTicks(1521), null, "Classic cola drink", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.372212", null, "Coca Cola 500ml", "COKE-500ML-001", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 372, DateTimeKind.Local).AddTicks(1857), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5024), null, "Sunflower cooking oil", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373503", null, "Cooking Oil 1L", "OIL-1L-010", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5028), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5046), null, "Basmati rice", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373505", null, "Rice 1kg", "RICE-1KG-011", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5050), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5067), null, "White granulated sugar", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373507", null, "Sugar 1kg", "SUGAR-1KG-012", "3", "Warehouse", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5071), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5096), null, "Hair care shampoo", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373510", null, "Shampoo 400ml", "SHAMP-400ML-013", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5100), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5117), null, "Dental care paste", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373512", null, "Toothpaste", "TOOTH-PASTE-014", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5121), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5139), null, "Type-C charging cable", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373514", null, "USB Cable", "USB-CABLE-015", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5142), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5160), null, "Fast charging adapter", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373516", null, "Phone Charger", "CHARGER-016", "3", "Warehouse", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5164), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 4, 9, 23, 29, 41, 372, DateTimeKind.Local).AddTicks(6193), null, "Cola soft drink", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.372796", null, "Pepsi 500ml", "PEPSI-500ML-002", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 372, DateTimeKind.Local).AddTicks(7092), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(1765), null, "Pure drinking water", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373389", null, "Mineral Water 1L", "WATER-1L-003", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(2939), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4856), null, "Chocolate sandwich cookies", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373487", null, "Oreo Biscuits", "OREO-PACK-004", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4869), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4907), null, "Potato chips", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373491", null, "Lay's Chips", "LAYS-PACK-005", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4911), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4930), null, "Quick meal noodles", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373493", null, "Instant Noodles", "NOODLE-PACK-006", "3", "Warehouse", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4933), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4952), null, "200 pages ruled notebook", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373496", null, "A4 Notebook", "NOTE-A4-007", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4956), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4974), null, "Ballpoint pen", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373498", null, "Blue Pen", "PEN-BLUE-008", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4977), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(4996), null, "12 pencils per box", "Unchanged", null, true, false, false, true, "2026-04-09 23:29:41.373500", null, "Pencil Set", "PENCIL-BOX-009", "3", "Warehouse", null, new DateTime(2026, 4, 9, 23, 29, 41, 373, DateTimeKind.Local).AddTicks(5006), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DeletedAt", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 4, 9, 23, 29, 39, 836, DateTimeKind.Local).AddTicks(4544), null, null, "john.doe@example.com", null, "Unchanged", "John", true, false, false, true, "2026-04-09 23:29:39.836486", "Doe", null, "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 4, 9, 23, 29, 39, 824, DateTimeKind.Local).AddTicks(3168), null, new DateTime(2026, 4, 9, 23, 29, 39, 836, DateTimeKind.Local).AddTicks(4733), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 4, 9, 23, 29, 39, 836, DateTimeKind.Local).AddTicks(6784), null, null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, false, true, "2026-04-09 23:29:39.836831", "Smith", null, "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 4, 9, 23, 29, 39, 836, DateTimeKind.Local).AddTicks(4886), null, new DateTime(2026, 4, 9, 23, 29, 39, 836, DateTimeKind.Local).AddTicks(7572), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 4, 9, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(467), null, null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, false, true, "2026-04-09 23:29:39.837235", "Johnson", null, "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 4, 9, 23, 29, 39, 836, DateTimeKind.Local).AddTicks(8965), null, new DateTime(2026, 4, 9, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(1452), 0 }
                });

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DeletedAt", "DueDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 4, 9, 23, 29, 39, 840, DateTimeKind.Local).AddTicks(1160), "1", "John", null, new DateTime(2026, 5, 9, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Unchanged", true, false, false, true, "2026-04-09 23:29:39.840140", null, new DateTime(2026, 3, 10, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Coca Cola loan for John", 5000m, "1", "Coca Cola 500ml", 10m, "1", "Main Store", 1, 50000L, "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 840, DateTimeKind.Local).AddTicks(1287), 0 },
                    { "10", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5105), "9", "James", null, new DateTime(2026, 5, 6, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Unchanged", true, false, false, true, "2026-04-09 23:29:39.841511", null, new DateTime(2026, 4, 6, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "USB cables for James", 1000m, "15", "USB Cable", 100m, "3", "Warehouse", 1, 100000L, "1", "Piece", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5108), 0 },
                    { "2", null, new DateTime(2026, 4, 9, 23, 29, 39, 840, DateTimeKind.Local).AddTicks(6106), "2", "Jane", null, new DateTime(2026, 4, 24, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Unchanged", true, false, false, true, "2026-04-09 23:29:39.840747", null, new DateTime(2026, 3, 25, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Oreo biscuits for Jane", 4000m, "4", "Oreo Biscuits", 5m, "1", "Main Store", 1, 20000L, "3", "Pack", null, new DateTime(2026, 4, 9, 23, 29, 39, 840, DateTimeKind.Local).AddTicks(6814), 0 },
                    { "3", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(2068), "3", "Michael", null, new DateTime(2026, 4, 29, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Unchanged", true, false, false, true, "2026-04-09 23:29:39.841412", null, new DateTime(2026, 3, 30, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Notebooks for Michael", 3000m, "7", "A4 Notebook", 20m, "1", "Main Store", 1, 60000L, "1", "Piece", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(2935), 0 },
                    { "4", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(4937), "1", "John", null, new DateTime(2026, 5, 24, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Unchanged", true, false, false, true, "2026-04-09 23:29:39.841495", null, new DateTime(2026, 4, 4, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Cooking oil bulk order", 8000m, "10", "Cooking Oil 1L", 15m, "1", "Main Store", 1, 120000L, "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(4950), 0 },
                    { "5", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(4979), "4", "Sarah", null, new DateTime(2026, 4, 19, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Unchanged", true, false, false, true, "2026-04-09 23:29:39.841498", null, new DateTime(2026, 3, 20, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Pepsi for Sarah", 4500m, "2", "Pepsi 500ml", 24m, "2", "Branch Store", 1, 108000L, "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(4983), 0 },
                    { "6", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5003), "5", "David", null, new DateTime(2026, 4, 27, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Unchanged", true, false, false, true, "2026-04-09 23:29:39.841501", null, new DateTime(2026, 3, 28, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Blue pens for David", 500m, "8", "Blue Pen", 50m, "2", "Branch Store", 1, 25000L, "1", "Piece", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5007), 0 },
                    { "7", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5028), "6", "Lisa", null, null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.841503", null, new DateTime(2026, 3, 15, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Rice bulk purchase", 2000m, "11", "Rice 1kg", 100m, "2", "Branch Store", 1, 200000L, "7", "Kilogram", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5031), 0 },
                    { "8", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5059), "7", "Robert", null, new DateTime(2026, 4, 21, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Unchanged", true, false, false, true, "2026-04-09 23:29:39.841506", null, new DateTime(2026, 3, 22, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Mineral water for Robert", 3000m, "3", "Mineral Water 1L", 48m, "3", "Warehouse", 1, 144000L, "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5062), 0 },
                    { "9", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5082), "8", "Emily", null, new DateTime(2026, 5, 1, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Unchanged", true, false, false, true, "2026-04-09 23:29:39.841508", null, new DateTime(2026, 4, 1, 23, 29, 39, 837, DateTimeKind.Local).AddTicks(9320), "Instant noodles for Emily", 1500m, "6", "Instant Noodles", 30m, "3", "Warehouse", 1, 45000L, "3", "Pack", null, new DateTime(2026, 4, 9, 23, 29, 39, 841, DateTimeKind.Local).AddTicks(5086), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 1m, "Added", "2026-04-09 23:29:39.809731", "1", "Coca Cola 500ml", "Bottle", "2", 0 },
                    { "10", 1m, "Added", "2026-04-09 23:29:39.811700", "4", "Oreo Biscuits", "Pack", "3", 0 },
                    { "11", 12m, "Added", "2026-04-09 23:29:39.811701", "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "12", 48m, "Added", "2026-04-09 23:29:39.811702", "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "13", 1m, "Added", "2026-04-09 23:29:39.811707", "5", "Lay's Chips", "Pack", "3", 0 },
                    { "14", 20m, "Added", "2026-04-09 23:29:39.811709", "5", "Lay's Chips", "Box", "4", 0 },
                    { "15", 60m, "Added", "2026-04-09 23:29:39.811710", "5", "Lay's Chips", "Carton", "5", 0 },
                    { "16", 1m, "Added", "2026-04-09 23:29:39.811710", "6", "Instant Noodles", "Pack", "3", 0 },
                    { "17", 24m, "Added", "2026-04-09 23:29:39.811711", "6", "Instant Noodles", "Box", "4", 0 },
                    { "18", 72m, "Added", "2026-04-09 23:29:39.811712", "6", "Instant Noodles", "Carton", "5", 0 },
                    { "19", 1m, "Added", "2026-04-09 23:29:39.811713", "7", "A4 Notebook", "Piece", "1", 0 },
                    { "2", 12m, "Added", "2026-04-09 23:29:39.811357", "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "20", 12m, "Added", "2026-04-09 23:29:39.811714", "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "21", 50m, "Added", "2026-04-09 23:29:39.811716", "7", "A4 Notebook", "Box", "4", 0 },
                    { "22", 1m, "Added", "2026-04-09 23:29:39.811717", "8", "Blue Pen", "Piece", "1", 0 },
                    { "23", 12m, "Added", "2026-04-09 23:29:39.811718", "8", "Blue Pen", "Dozen", "10", 0 },
                    { "24", 144m, "Added", "2026-04-09 23:29:39.811719", "8", "Blue Pen", "Box", "4", 0 },
                    { "25", 1m, "Added", "2026-04-09 23:29:39.811720", "9", "Pencil Set", "Box", "4", 0 },
                    { "26", 20m, "Added", "2026-04-09 23:29:39.811720", "9", "Pencil Set", "Carton", "5", 0 },
                    { "27", 1m, "Added", "2026-04-09 23:29:39.811721", "10", "Cooking Oil 1L", "Bottle", "2", 0 },
                    { "28", 12m, "Added", "2026-04-09 23:29:39.811722", "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "29", 24m, "Added", "2026-04-09 23:29:39.811723", "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "3", 24m, "Added", "2026-04-09 23:29:39.811572", "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "30", 1m, "Added", "2026-04-09 23:29:39.811724", "11", "Rice 1kg", "Kilogram", "7", 0 },
                    { "31", 10m, "Added", "2026-04-09 23:29:39.811725", "11", "Rice 1kg", "Box", "4", 0 },
                    { "32", 25m, "Added", "2026-04-09 23:29:39.811726", "11", "Rice 1kg", "Carton", "5", 0 },
                    { "33", 1m, "Added", "2026-04-09 23:29:39.811727", "12", "Sugar 1kg", "Kilogram", "7", 0 },
                    { "34", 20m, "Added", "2026-04-09 23:29:39.811727", "12", "Sugar 1kg", "Box", "4", 0 },
                    { "35", 50m, "Added", "2026-04-09 23:29:39.811728", "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "36", 1m, "Added", "2026-04-09 23:29:39.811729", "13", "Shampoo 400ml", "Bottle", "2", 0 },
                    { "37", 12m, "Added", "2026-04-09 23:29:39.811730", "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "38", 24m, "Added", "2026-04-09 23:29:39.811731", "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "39", 1m, "Added", "2026-04-09 23:29:39.811731", "14", "Toothpaste", "Piece", "1", 0 },
                    { "4", 1m, "Added", "2026-04-09 23:29:39.811692", "2", "Pepsi 500ml", "Bottle", "2", 0 },
                    { "40", 24m, "Added", "2026-04-09 23:29:39.811732", "14", "Toothpaste", "Box", "4", 0 },
                    { "41", 72m, "Added", "2026-04-09 23:29:39.811733", "14", "Toothpaste", "Carton", "5", 0 },
                    { "42", 1m, "Added", "2026-04-09 23:29:39.811734", "15", "USB Cable", "Piece", "1", 0 },
                    { "43", 50m, "Added", "2026-04-09 23:29:39.811735", "15", "USB Cable", "Box", "4", 0 },
                    { "44", 200m, "Added", "2026-04-09 23:29:39.811735", "15", "USB Cable", "Carton", "5", 0 },
                    { "45", 1m, "Added", "2026-04-09 23:29:39.811736", "16", "Phone Charger", "Piece", "1", 0 },
                    { "46", 20m, "Added", "2026-04-09 23:29:39.811737", "16", "Phone Charger", "Box", "4", 0 },
                    { "47", 100m, "Added", "2026-04-09 23:29:39.811738", "16", "Phone Charger", "Carton", "5", 0 },
                    { "5", 12m, "Added", "2026-04-09 23:29:39.811694", "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "6", 24m, "Added", "2026-04-09 23:29:39.811696", "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "7", 1m, "Added", "2026-04-09 23:29:39.811697", "3", "Mineral Water 1L", "Bottle", "2", 0 },
                    { "8", 6m, "Added", "2026-04-09 23:29:39.811698", "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "9", 12m, "Added", "2026-04-09 23:29:39.811699", "3", "Mineral Water 1L", "Carton", "5", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 4, 9, 23, 29, 39, 818, DateTimeKind.Local).AddTicks(6506), "Unchanged", new DateTime(2026, 10, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(7921), false, "2026-04-09 23:29:39.818789", "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 3, 30, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(7921), "Active", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 818, DateTimeKind.Local).AddTicks(7187), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 4, 9, 23, 29, 39, 819, DateTimeKind.Local).AddTicks(777), "Unchanged", new DateTime(2026, 11, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(7921), false, "2026-04-09 23:29:39.819263", "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 4, 4, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(7921), "Active", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 819, DateTimeKind.Local).AddTicks(1776), 0 },
                    { "3", "OREO-101", null, new DateTime(2026, 4, 9, 23, 29, 39, 819, DateTimeKind.Local).AddTicks(5774), "Unchanged", new DateTime(2026, 7, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(7921), false, "2026-04-09 23:29:39.819785", "4", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 3, 25, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(7921), "Active", "3", "Pack", null, new DateTime(2026, 4, 9, 23, 29, 39, 819, DateTimeKind.Local).AddTicks(6846), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 4, 9, 23, 29, 39, 819, DateTimeKind.Local).AddTicks(8805), "Unchanged", null, false, "2026-04-09 23:29:39.819882", "7", "A4 Notebook", 120000L, 200m, new DateTime(2026, 3, 20, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(7921), "Active", "1", "Piece", null, new DateTime(2026, 4, 9, 23, 29, 39, 819, DateTimeKind.Local).AddTicks(8817), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "DeletedAt", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", 140L, null, new DateTime(2026, 4, 9, 23, 29, 39, 815, DateTimeKind.Local).AddTicks(3474), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.815497", null, "1", "1", 160L, null, new DateTime(2026, 4, 9, 23, 29, 39, 815, DateTimeKind.Local).AddTicks(4295), 0 },
                    { "10", 230L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3499), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816350", null, "4", "10", 270L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3502), 0 },
                    { "11", 2760L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3513), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816352", null, "4", "11", 3240L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3517), 0 },
                    { "12", 11040L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3528), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816353", null, "4", "12", 12960L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3532), 0 },
                    { "13", 160L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3543), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816355", null, "5", "13", 190L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3547), 0 },
                    { "14", 3200L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3557), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816356", null, "5", "14", 3800L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3561), 0 },
                    { "15", 9600L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3615), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816362", null, "5", "15", 11400L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3619), 0 },
                    { "16", 110L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3630), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816363", null, "6", "16", 130L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3634), 0 },
                    { "17", 2640L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3646), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816365", null, "6", "17", 3120L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3650), 0 },
                    { "18", 7920L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3661), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816366", null, "6", "18", 9360L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3665), 0 },
                    { "19", 280L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816368", null, "7", "19", 320L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3680), 0 },
                    { "2", 1680L, null, new DateTime(2026, 4, 9, 23, 29, 39, 815, DateTimeKind.Local).AddTicks(6764), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.815857", null, "1", "2", 1920L, null, new DateTime(2026, 4, 9, 23, 29, 39, 815, DateTimeKind.Local).AddTicks(7731), 0 },
                    { "20", 3360L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3690), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816369", null, "7", "20", 3840L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3694), 0 },
                    { "21", 14000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3705), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816372", null, "7", "21", 16000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3719), 0 },
                    { "22", 45L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3730), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816373", null, "8", "22", 55L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3734), 0 },
                    { "23", 540L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3747), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816375", null, "8", "23", 660L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3751), 0 },
                    { "24", 6480L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3762), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816376", null, "8", "24", 7920L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3766), 0 },
                    { "25", 380L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3776), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816378", null, "9", "25", 420L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3780), 0 },
                    { "26", 7600L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3791), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816379", null, "9", "26", 8400L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3795), 0 },
                    { "27", 430L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3805), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816381", null, "10", "27", 470L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3809), 0 },
                    { "28", 5160L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3820), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816382", null, "10", "28", 5640L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3824), 0 },
                    { "29", 10320L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3835), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816384", null, "10", "29", 11280L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3839), 0 },
                    { "3", 3360L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(240), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816241", null, "1", "3", 3840L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(1380), 0 },
                    { "30", 260L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3849), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816385", null, "11", "30", 300L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3853), 0 },
                    { "31", 2600L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3866), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816387", null, "11", "31", 3000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3870), 0 },
                    { "32", 6500L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3881), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816388", null, "11", "32", 7500L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3884), 0 },
                    { "33", 180L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3895), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816390", null, "12", "33", 220L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3899), 0 },
                    { "34", 3600L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3909), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816391", null, "12", "34", 4400L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3913), 0 },
                    { "35", 9000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3924), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816393", null, "12", "35", 11000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3927), 0 },
                    { "36", 330L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3938), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816394", null, "13", "36", 370L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3942), 0 },
                    { "37", 3960L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3952), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816396", null, "13", "37", 4440L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3956), 0 },
                    { "38", 7920L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3967), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816397", null, "13", "38", 8880L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3970), 0 },
                    { "39", 160L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3983), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816399", null, "14", "39", 200L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3987), 0 },
                    { "4", 130L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3382), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816340", null, "2", "4", 150L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3396), 0 },
                    { "40", 3840L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4007), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816401", null, "14", "40", 4800L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4011), 0 },
                    { "41", 11520L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4022), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816402", null, "14", "41", 14400L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4026), 0 },
                    { "42", 230L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4036), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816404", null, "15", "42", 270L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4040), 0 },
                    { "43", 11500L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4050), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816405", null, "15", "43", 13500L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4054), 0 },
                    { "44", 46000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4064), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816407", null, "15", "44", 54000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4068), 0 },
                    { "45", 750L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4079), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816408", null, "16", "45", 850L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4082), 0 },
                    { "46", 15000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4093), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816410", null, "16", "46", 17000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4096), 0 },
                    { "47", 75000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4110), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816411", null, "16", "47", 85000L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(4113), 0 },
                    { "5", 1560L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3413), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816342", null, "2", "5", 1800L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3417), 0 },
                    { "6", 3120L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3428), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816343", null, "2", "6", 3600L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3432), 0 },
                    { "7", 70L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3453), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816346", null, "3", "7", 90L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3457), 0 },
                    { "8", 420L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3468), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816347", null, "3", "8", 540L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3472), 0 },
                    { "9", 840L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3483), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:29:39.816349", null, "3", "9", 1080L, null, new DateTime(2026, 4, 9, 23, 29, 39, 816, DateTimeKind.Local).AddTicks(3486), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 4, 9, 23, 29, 39, 822, DateTimeKind.Local).AddTicks(4352), "Unchanged", false, "2026-04-09 23:29:39.822480", "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 822, DateTimeKind.Local).AddTicks(4606), 0 },
                    { "10", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6266), "Unchanged", false, "2026-04-09 23:29:39.823627", "7", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6270), 0 },
                    { "2", null, new DateTime(2026, 4, 9, 23, 29, 39, 822, DateTimeKind.Local).AddTicks(7860), "Unchanged", false, "2026-04-09 23:29:39.822948", "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 822, DateTimeKind.Local).AddTicks(8707), 0 },
                    { "3", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(2970), "Unchanged", false, "2026-04-09 23:29:39.823503", "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(4010), 0 },
                    { "4", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6121), "Unchanged", false, "2026-04-09 23:29:39.823614", "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6135), 0 },
                    { "5", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6161), "Unchanged", false, "2026-04-09 23:29:39.823616", "4", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6165), 0 },
                    { "6", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6184), "Unchanged", false, "2026-04-09 23:29:39.823619", "4", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6188), 0 },
                    { "7", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6205), "Unchanged", false, "2026-04-09 23:29:39.823621", "4", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "3", "Pack", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6209), 0 },
                    { "8", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6226), "Unchanged", false, "2026-04-09 23:29:39.823623", "7", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "1", "Piece", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6230), 0 },
                    { "9", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6247), "Unchanged", false, "2026-04-09 23:29:39.823625", "7", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 4, 9, 23, 29, 39, 823, DateTimeKind.Local).AddTicks(6251), 0 }
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
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                unique: true,
                filter: "[TranslationKeyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                table: "Languages",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

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
