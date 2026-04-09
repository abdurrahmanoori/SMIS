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
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
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
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    TranslationKeyId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
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
                    TranslationKeyId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    LanguageNo = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    BaseUnitId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    BaseUnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
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
                    Id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    ProvinceId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DistrictId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
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
                    ProductId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UnitOfMeasureId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    ProductId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BatchNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    UnitId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    CustomerId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UnitId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    ProductId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    ShopId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StockBatchId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    UnitId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    LoanAccountId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
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
                    { "1", "en", "Added", true, "2026-04-09 19:15:18.636639", "English", 0 },
                    { "2", "ps", "Added", true, "2026-04-09 19:15:18.636768", "Pashto", 0 },
                    { "3", "fa", "Added", true, "2026-04-09 19:15:18.636768", "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:45:18.638598", null, "Kabul", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:45:18.638638", null, "Herat", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:45:18.638639", null, "Kandahar", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:45:18.638639", null, "Balkh", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedAt", "Email", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 4, 9, 23, 45, 18, 643, DateTimeKind.Local).AddTicks(4297), null, "main@store.local", "Unchanged", true, false, false, "2026-04-09 23:45:18.643459", "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 4, 9, 23, 45, 18, 643, DateTimeKind.Local).AddTicks(4443), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 4, 9, 23, 45, 18, 643, DateTimeKind.Local).AddTicks(5989), null, "branch@store.local", "Unchanged", true, false, false, "2026-04-09 23:45:18.643814", "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 4, 9, 23, 45, 18, 643, DateTimeKind.Local).AddTicks(7072), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 4, 9, 23, 45, 18, 643, DateTimeKind.Local).AddTicks(9892), null, "warehouse@store.local", "Unchanged", true, false, false, "2026-04-09 23:45:18.644173", "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 4, 9, 23, 45, 18, 644, DateTimeKind.Local).AddTicks(861), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:45:18.637304", null, "1001", "Kabul Center District", null, null, 0 },
                    { "2", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:45:18.637400", null, "1002", "Kabul North District", null, null, 0 },
                    { "3", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:45:18.637401", null, "1003", "Herat Center District", null, null, 0 },
                    { "4", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:45:18.637401", null, "2001", "Kabul Province", null, null, 0 },
                    { "5", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:45:18.637402", null, "2002", "Herat Province", null, null, 0 },
                    { "6", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:45:18.637403", null, "3001", "Welcome Message", null, null, 0 },
                    { "7", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:45:18.637403", null, "3002", "Error Message", null, null, 0 },
                    { "8", null, null, null, "Unchanged", true, false, false, true, "2026-04-09 23:45:18.637404", null, "3003", "Success Message", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "c744cef7-6ffb-475e-b7e7-9c93ceef136e", "superadmin@smis.com", true, "Unchanged", "Super", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEO0fu3AzvMNpnXR7XrrkQxBcWPjV2Qbz/reOZNok8ZPdPcvsNndOyV/3WiWUNHVvUQ==", "+855123456789", true, "c2c4b850-28f8-4cd7-a107-1c4e8b3e672a", "1", "Main Store", false, "superadmin", 0 },
                    { "10", 0, "f640a6c2-6078-44a4-a150-beb15d3d5d56", "radministration@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEH5KOuCbRIj0ajgJ1t9/5iAlkRuCT3fpbOwkBLWTuB0sl2eydZGGqS0KyePjxHY3JA==", "+855123456798", true, "36fea153-15e8-45ea-bab2-fbca9f2d54fb", "2", "Branch Store", false, "radministration", 0 },
                    { "11", 0, "77a0749c-5b0e-4ff8-8498-e1f9b068d433", "rmanager@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEO3tlnK/zLIl1mvKdDFhupRvfsVdx+rFO+I1OXUI49/MuBQDb/4ZbofzfARq0D8dMQ==", "+855123456799", true, "67738b4a-af82-4b40-8e0a-24616c58413e", "2", "Branch Store", false, "rmanager", 0 },
                    { "12", 0, "4ff57326-06bc-4264-a3fe-0402048fa7e1", "rstaff@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEBIa7pnu9EogK5wudc/W9h8wN3emqoQxNWO+eEMJgc3hg5Idem8Z2dLxXecFkQDy4w==", "+855123456800", true, "a95f352c-7caa-4b0d-b31e-70b2d7550610", "2", "Branch Store", false, "rstaff", 0 },
                    { "13", 0, "015c979d-90ef-4862-a00b-38658c21e3b0", "rviewer@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEDaLYVj5215RJhSSQRn9Runo3OehzyEw4AcDAFpQWzC5RAwh0o1uiLv32IwWerwtLQ==", "+855123456801", true, "c5a7b4c2-ac34-4f31-80b1-fdcf0a144102", "2", "Branch Store", false, "rviewer", 0 },
                    { "14", 0, "38d09008-0705-4485-a955-2903b23da3aa", "reditor@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAEPU3Rp+gky832jnsXF4NpMHVDhhDyeQLR2Zex1ItNkPJvq8s0pGySTQuz7aH4cHimQ==", "+855123456802", true, "6718d3f4-a16b-4d33-8261-bf74131abca6", "2", "Branch Store", false, "reditor", 0 },
                    { "15", 0, "f55e9503-ec2c-4580-9cd5-5793e95e2b58", "ruser@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEFCxKZ7vJLlQmvgVqh69C1AOQYAnlH2+ruWye/u6XVzRjfWrt2sA+BQoz0VXLVoGqA==", "+855123456803", true, "83d9ce1a-53ab-4e38-bcb4-366ec1ed3e06", "2", "Branch Store", false, "ruser", 0 },
                    { "2", 0, "6e88910c-5055-49ff-beaa-5ffb2f83e2d5", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEBzx7tzRlQRzQn1VuMYDUOwdVBg57pXDNumhiX8OVPWIs3Z0qHICIC6wVFVXVne9Yw==", "+855123456790", true, "a461b6c7-77b6-4377-9109-d3936c1e03a1", "1", "Main Store", false, "wadmin", 0 },
                    { "3", 0, "f2fe58f2-005a-42e7-9668-620611f6cae6", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEMXNIOE3cB6Cdt0ffdCBL7MbOZnMgBj62mkIE1vmzThtkE9YWTxRacTOTtOukxwleg==", "+855123456791", true, "b388b5af-21a8-4051-bf94-d4cd4f4987cb", "1", "Main Store", false, "wadministration", 0 },
                    { "4", 0, "eb0c3562-7454-47fd-a429-a92710989a45", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAECTBsmqIFkMO38sk1GP7Eb1wX++UTA8HrU0eHTFL9wZy046eAOerGcKgWisbyWuvYA==", "+855123456792", true, "b592af41-01df-49e5-8f0a-5209750148e7", "1", "Main Store", false, "wmanager", 0 },
                    { "5", 0, "fa9c1851-1754-407d-8c06-d0ebe5c72b0c", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAELjK5iPG0A3YV8fOAD7IJ73M8GsQttNJ9WA9239KFGDVH6xWKGIYrdkCl9kPmuvl3A==", "+855123456793", true, "1f9b2ff5-f01e-4a96-b12f-77fe20d347f3", "1", "Main Store", false, "wstaff", 0 },
                    { "6", 0, "94e50dea-afbb-4b2c-b1ed-ec5ed6895813", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEMaQZTtxIXouehz5mSL19S6inX85iX6jYepPLe/GduSOvnsqgAtvY0RWLVdjiLioTg==", "+8512345634366", true, "339df9e7-638d-4a48-8869-5a2cb341a180", "1", "Main Store", false, "wviewer", 0 },
                    { "7", 0, "1d837cfa-df76-4491-b9fa-2c1735e29abe", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEMOdIM5brmuak2EzZ7Zoe3ZAOe5LhGwijso3pReGFCAUI2svAF9oq5v7w0aLD3s93Q==", "+855123456795", true, "445b746c-85ed-4cc5-873e-552e10127996", "1", "Main Store", false, "weditor", 0 },
                    { "8", 0, "b3d6707a-e300-4f87-b692-0d7a9859e31c", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEF13WpC3pM6wZTUXP/tb7/ttLRlvEkdGIw/UXGgZwlPRCqtTqLvWDrxTLVLR8i6Lgw==", "+855123456796", true, "aa0e39fa-e5cb-4fbb-8c00-d392635d5637", "1", "Main Store", false, "wuser", 0 },
                    { "9", 0, "94b5d9d9-447b-4cf4-bb28-fdc9b8b472b3", "radmin@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEAW57tUnMB5YZwjdwzWU3z8KveQpJoNdhDUqroYutsFhYmfKbXg3g4YnzRRnd5Sg8Q==", "+855123456797", true, "ef735c69-d5d5-4f8d-ae33-f634e718be1c", "2", "Branch Store", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(8977), null, "Drinks and beverages", "Unchanged", true, false, false, "2026-04-09 23:45:18.649898", "Beverages", "1", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(8983), 0 },
                    { "2", "FOOD", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9014), null, "Edible products and snacks", "Unchanged", true, false, false, "2026-04-09 23:45:18.649901", "Food Items", "1", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9015), 0 },
                    { "3", "STAT", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9021), null, "Office and school supplies", "Unchanged", true, false, false, "2026-04-09 23:45:18.649902", "Stationery", "2", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9022), 0 },
                    { "4", "GROC", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9027), null, "Daily household items", "Unchanged", true, false, false, "2026-04-09 23:45:18.649902", "Grocery", "2", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9027), 0 },
                    { "5", "CARE", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9033), null, "Health and hygiene products", "Unchanged", true, false, false, "2026-04-09 23:45:18.649903", "Personal Care", "3", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9033), 0 },
                    { "6", "ELEC", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9038), null, "Electronic devices and accessories", "Unchanged", true, false, false, "2026-04-09 23:45:18.649903", "Electronics", "3", null, new DateTime(2026, 4, 9, 23, 45, 18, 649, DateTimeKind.Local).AddTicks(9038), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:45:18.639095", null, "Kabul Center", "1", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:45:18.639150", null, "Kabul North", "2", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-04-09 23:45:18.639151", null, "Herat Center", "3", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", "2026-04-09 19:15:18.638747", "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", "2026-04-09 19:15:18.638878", "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", "2026-04-09 19:15:18.638878", "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", "2026-04-09 19:15:18.638878", "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", "2026-04-09 19:15:18.638874", "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", "2026-04-09 19:15:18.638875", "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", "2026-04-09 19:15:18.638876", "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", "2026-04-09 19:15:18.638876", "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", "2026-04-09 19:15:18.638877", "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", "2026-04-09 19:15:18.638877", "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", "2026-04-09 19:15:18.638877", "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", "2026-04-09 19:15:18.638878", "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LanguageNo", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:45:18.637900", null, "Kabul Center District", "1", null, null, 0 },
                    { "10", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:45:18.637987", null, "ولایت هرات", "5", null, null, 0 },
                    { "11", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:45:18.637988", null, "Welcome Message", "6", null, null, 0 },
                    { "12", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:45:18.637988", null, "پیام خوش آمدید", "6", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:45:18.637982", null, "منطقه مرکز کابل", "1", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:45:18.637983", null, "Kabul North District", "2", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:45:18.637983", null, "منطقه شمال کابل", "2", null, null, 0 },
                    { "5", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:45:18.637983", null, "Herat Center District", "3", null, null, 0 },
                    { "6", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:45:18.637984", null, "منطقه مرکز هرات", "3", null, null, 0 },
                    { "7", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:45:18.637986", null, "Kabul Province", "4", null, null, 0 },
                    { "8", null, null, null, "Unchanged", false, false, true, "2", "2026-04-09 23:45:18.637987", null, "ولایت کابل", "4", null, null, 0 },
                    { "9", null, null, null, "Unchanged", false, false, true, "1", "2026-04-09 23:45:18.637987", null, "Herat Province", "5", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", "2026-04-09 23:45:18.640526", "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", "2026-04-09 23:45:18.640973", "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", "2026-04-09 23:45:18.640680", "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", "2026-04-09 23:45:18.640859", "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", "2026-04-09 23:45:18.640967", "Box", "1", "box", 0 },
                    { "5", "Large containers", "Added", "2026-04-09 23:45:18.640968", "Carton", "1", "ctn", 0 },
                    { "6", "Volume measurement", "Added", "2026-04-09 23:45:18.640969", "Liter", "1", "L", 0 },
                    { "7", "Weight measurement", "Added", "2026-04-09 23:45:18.640970", "Kilogram", "1", "kg", 0 },
                    { "8", "Small weight measurement", "Added", "2026-04-09 23:45:18.640971", "Gram", "1", "g", 0 },
                    { "9", "Small volume measurement", "Added", "2026-04-09 23:45:18.640972", "Milliliter", "1", "ml", 0 }
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
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 4, 9, 23, 45, 18, 651, DateTimeKind.Local).AddTicks(6625), "Individual", null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, true, "2026-04-09 23:45:18.651691", "Doe", null, "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 4, 9, 23, 45, 18, 651, DateTimeKind.Local).AddTicks(6795), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5609), "Individual", null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, true, "2026-04-09 23:45:18.652561", "Rodriguez", null, "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5612), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 4, 9, 23, 45, 18, 651, DateTimeKind.Local).AddTicks(8678), "Individual", null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, true, "2026-04-09 23:45:18.652017", "Smith", null, "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 4, 9, 23, 45, 18, 651, DateTimeKind.Local).AddTicks(9458), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(2458), "Enterprise", null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, true, "2026-04-09 23:45:18.652423", "Brown", null, "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(3388), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5446), "Individual", null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, true, "2026-04-09 23:45:18.652546", "Wilson", null, "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5458), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5486), "Individual", null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, true, "2026-04-09 23:45:18.652549", "Taylor", null, "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5490), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5513), "Enterprise", null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, true, "2026-04-09 23:45:18.652552", "Garcia", null, "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5516), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5537), "Individual", null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, true, "2026-04-09 23:45:18.652554", "Martinez", null, "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5540), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5562), "Individual", null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, true, "2026-04-09 23:45:18.652556", "Lopez", null, "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5566), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5584), "Enterprise", null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, true, "2026-04-09 23:45:18.652559", "Gonzalez", null, "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 4, 9, 23, 45, 18, 652, DateTimeKind.Local).AddTicks(5588), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "ImageUrl", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 4, 9, 23, 45, 18, 647, DateTimeKind.Local).AddTicks(7364), null, "Classic cola drink", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.647765", null, "Coca Cola 500ml", "COKE-500ML-001", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 647, DateTimeKind.Local).AddTicks(7540), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8123), null, "Sunflower cooking oil", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648813", null, "Cooking Oil 1L", "OIL-1L-010", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8127), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8144), null, "Basmati rice", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648815", null, "Rice 1kg", "RICE-1KG-011", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8147), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8163), null, "White granulated sugar", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648817", null, "Sugar 1kg", "SUGAR-1KG-012", "3", "Warehouse", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8166), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8187), null, "Hair care shampoo", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648819", null, "Shampoo 400ml", "SHAMP-400ML-013", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8190), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8206), null, "Dental care paste", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648821", null, "Toothpaste", "TOOTH-PASTE-014", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8209), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8225), null, "Type-C charging cable", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648823", null, "USB Cable", "USB-CABLE-015", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8228), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8244), null, "Fast charging adapter", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648825", null, "Phone Charger", "CHARGER-016", "3", "Warehouse", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8247), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(611), null, "Cola soft drink", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648214", null, "Pepsi 500ml", "PEPSI-500ML-002", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(1351), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(5355), null, "Pure drinking water", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648714", null, "Mineral Water 1L", "WATER-1L-003", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(6306), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(7957), null, "Chocolate sandwich cookies", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648797", null, "Oreo Biscuits", "OREO-PACK-004", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(7968), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8001), null, "Potato chips", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648800", null, "Lay's Chips", "LAYS-PACK-005", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8005), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8023), null, "Quick meal noodles", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648802", null, "Instant Noodles", "NOODLE-PACK-006", "3", "Warehouse", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8026), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8044), null, "200 pages ruled notebook", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648805", null, "A4 Notebook", "NOTE-A4-007", "1", "Main Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8047), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8064), null, "Ballpoint pen", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648807", null, "Blue Pen", "PEN-BLUE-008", "2", "Branch Store", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8067), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8083), null, "12 pencils per box", "Unchanged", null, true, false, false, true, "2026-04-09 23:45:18.648809", null, "Pencil Set", "PENCIL-BOX-009", "3", "Warehouse", null, new DateTime(2026, 4, 9, 23, 45, 18, 648, DateTimeKind.Local).AddTicks(8089), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DeletedAt", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 4, 9, 23, 45, 17, 329, DateTimeKind.Local).AddTicks(6202), null, null, "john.doe@example.com", null, "Unchanged", "John", true, false, false, true, "2026-04-09 23:45:17.329683", "Doe", null, "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 4, 9, 23, 45, 17, 315, DateTimeKind.Local).AddTicks(2043), null, new DateTime(2026, 4, 9, 23, 45, 17, 329, DateTimeKind.Local).AddTicks(6579), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 4, 9, 23, 45, 17, 329, DateTimeKind.Local).AddTicks(9023), null, null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, false, true, "2026-04-09 23:45:17.330082", "Smith", null, "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 4, 9, 23, 45, 17, 329, DateTimeKind.Local).AddTicks(6859), null, new DateTime(2026, 4, 9, 23, 45, 17, 329, DateTimeKind.Local).AddTicks(9952), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 4, 9, 23, 45, 17, 330, DateTimeKind.Local).AddTicks(3384), null, null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, false, true, "2026-04-09 23:45:17.330566", "Johnson", null, "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 4, 9, 23, 45, 17, 330, DateTimeKind.Local).AddTicks(1605), null, new DateTime(2026, 4, 9, 23, 45, 17, 330, DateTimeKind.Local).AddTicks(4564), 0 }
                });

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DeletedAt", "DueDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 4, 9, 23, 45, 17, 334, DateTimeKind.Local).AddTicks(2584), "1", "John", null, new DateTime(2026, 5, 9, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Unchanged", true, false, false, true, "2026-04-09 23:45:17.334309", null, new DateTime(2026, 3, 10, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Coca Cola loan for John", 5000m, "1", "Coca Cola 500ml", 10m, "1", "Main Store", 1, 50000L, "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 334, DateTimeKind.Local).AddTicks(2859), 0 },
                    { "10", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8602), "9", "James", null, new DateTime(2026, 5, 6, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Unchanged", true, false, false, true, "2026-04-09 23:45:17.335861", null, new DateTime(2026, 4, 6, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "USB cables for James", 1000m, "15", "USB Cable", 100m, "3", "Warehouse", 1, 100000L, "1", "Piece", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8607), 0 },
                    { "2", null, new DateTime(2026, 4, 9, 23, 45, 17, 334, DateTimeKind.Local).AddTicks(8364), "2", "Jane", null, new DateTime(2026, 4, 24, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Unchanged", true, false, false, true, "2026-04-09 23:45:17.334997", null, new DateTime(2026, 3, 25, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Oreo biscuits for Jane", 4000m, "4", "Oreo Biscuits", 5m, "1", "Main Store", 1, 20000L, "3", "Pack", null, new DateTime(2026, 4, 9, 23, 45, 17, 334, DateTimeKind.Local).AddTicks(9182), 0 },
                    { "3", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(5410), "3", "Michael", null, new DateTime(2026, 4, 29, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Unchanged", true, false, false, true, "2026-04-09 23:45:17.335744", null, new DateTime(2026, 3, 30, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Notebooks for Michael", 3000m, "7", "A4 Notebook", 20m, "1", "Main Store", 1, 60000L, "1", "Piece", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(6465), 0 },
                    { "4", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8395), "1", "John", null, new DateTime(2026, 5, 24, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Unchanged", true, false, false, true, "2026-04-09 23:45:17.335841", null, new DateTime(2026, 4, 4, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Cooking oil bulk order", 8000m, "10", "Cooking Oil 1L", 15m, "1", "Main Store", 1, 120000L, "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8410), 0 },
                    { "5", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8455), "4", "Sarah", null, new DateTime(2026, 4, 19, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Unchanged", true, false, false, true, "2026-04-09 23:45:17.335846", null, new DateTime(2026, 3, 20, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Pepsi for Sarah", 4500m, "2", "Pepsi 500ml", 24m, "2", "Branch Store", 1, 108000L, "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8460), 0 },
                    { "6", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8497), "5", "David", null, new DateTime(2026, 4, 27, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Unchanged", true, false, false, true, "2026-04-09 23:45:17.335850", null, new DateTime(2026, 3, 28, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Blue pens for David", 500m, "8", "Blue Pen", 50m, "2", "Branch Store", 1, 25000L, "1", "Piece", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8502), 0 },
                    { "7", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8525), "6", "Lisa", null, null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.335853", null, new DateTime(2026, 3, 15, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Rice bulk purchase", 2000m, "11", "Rice 1kg", 100m, "2", "Branch Store", 1, 200000L, "7", "Kilogram", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8529), 0 },
                    { "8", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8551), "7", "Robert", null, new DateTime(2026, 4, 21, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Unchanged", true, false, false, true, "2026-04-09 23:45:17.335855", null, new DateTime(2026, 3, 22, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Mineral water for Robert", 3000m, "3", "Mineral Water 1L", 48m, "3", "Warehouse", 1, 144000L, "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8555), 0 },
                    { "9", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8577), "8", "Emily", null, new DateTime(2026, 5, 1, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Unchanged", true, false, false, true, "2026-04-09 23:45:17.335858", null, new DateTime(2026, 4, 1, 23, 45, 17, 331, DateTimeKind.Local).AddTicks(5163), "Instant noodles for Emily", 1500m, "6", "Instant Noodles", 30m, "3", "Warehouse", 1, 45000L, "3", "Pack", null, new DateTime(2026, 4, 9, 23, 45, 17, 335, DateTimeKind.Local).AddTicks(8581), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 1m, "Added", "2026-04-09 23:45:17.298774", "1", "Coca Cola 500ml", "Bottle", "2", 0 },
                    { "10", 1m, "Added", "2026-04-09 23:45:17.300746", "4", "Oreo Biscuits", "Pack", "3", 0 },
                    { "11", 12m, "Added", "2026-04-09 23:45:17.300747", "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "12", 48m, "Added", "2026-04-09 23:45:17.300748", "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "13", 1m, "Added", "2026-04-09 23:45:17.300749", "5", "Lay's Chips", "Pack", "3", 0 },
                    { "14", 20m, "Added", "2026-04-09 23:45:17.300750", "5", "Lay's Chips", "Box", "4", 0 },
                    { "15", 60m, "Added", "2026-04-09 23:45:17.300751", "5", "Lay's Chips", "Carton", "5", 0 },
                    { "16", 1m, "Added", "2026-04-09 23:45:17.300752", "6", "Instant Noodles", "Pack", "3", 0 },
                    { "17", 24m, "Added", "2026-04-09 23:45:17.300753", "6", "Instant Noodles", "Box", "4", 0 },
                    { "18", 72m, "Added", "2026-04-09 23:45:17.300753", "6", "Instant Noodles", "Carton", "5", 0 },
                    { "19", 1m, "Added", "2026-04-09 23:45:17.300754", "7", "A4 Notebook", "Piece", "1", 0 },
                    { "2", 12m, "Added", "2026-04-09 23:45:17.300423", "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "20", 12m, "Added", "2026-04-09 23:45:17.300755", "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "21", 50m, "Added", "2026-04-09 23:45:17.300756", "7", "A4 Notebook", "Box", "4", 0 },
                    { "22", 1m, "Added", "2026-04-09 23:45:17.300757", "8", "Blue Pen", "Piece", "1", 0 },
                    { "23", 12m, "Added", "2026-04-09 23:45:17.300758", "8", "Blue Pen", "Dozen", "10", 0 },
                    { "24", 144m, "Added", "2026-04-09 23:45:17.300759", "8", "Blue Pen", "Box", "4", 0 },
                    { "25", 1m, "Added", "2026-04-09 23:45:17.300760", "9", "Pencil Set", "Box", "4", 0 },
                    { "26", 20m, "Added", "2026-04-09 23:45:17.300760", "9", "Pencil Set", "Carton", "5", 0 },
                    { "27", 1m, "Added", "2026-04-09 23:45:17.300761", "10", "Cooking Oil 1L", "Bottle", "2", 0 },
                    { "28", 12m, "Added", "2026-04-09 23:45:17.300762", "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "29", 24m, "Added", "2026-04-09 23:45:17.300763", "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "3", 24m, "Added", "2026-04-09 23:45:17.300610", "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "30", 1m, "Added", "2026-04-09 23:45:17.300764", "11", "Rice 1kg", "Kilogram", "7", 0 },
                    { "31", 10m, "Added", "2026-04-09 23:45:17.300765", "11", "Rice 1kg", "Box", "4", 0 },
                    { "32", 25m, "Added", "2026-04-09 23:45:17.300766", "11", "Rice 1kg", "Carton", "5", 0 },
                    { "33", 1m, "Added", "2026-04-09 23:45:17.300767", "12", "Sugar 1kg", "Kilogram", "7", 0 },
                    { "34", 20m, "Added", "2026-04-09 23:45:17.300767", "12", "Sugar 1kg", "Box", "4", 0 },
                    { "35", 50m, "Added", "2026-04-09 23:45:17.300768", "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "36", 1m, "Added", "2026-04-09 23:45:17.300770", "13", "Shampoo 400ml", "Bottle", "2", 0 },
                    { "37", 12m, "Added", "2026-04-09 23:45:17.300771", "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "38", 24m, "Added", "2026-04-09 23:45:17.300772", "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "39", 1m, "Added", "2026-04-09 23:45:17.300773", "14", "Toothpaste", "Piece", "1", 0 },
                    { "4", 1m, "Added", "2026-04-09 23:45:17.300735", "2", "Pepsi 500ml", "Bottle", "2", 0 },
                    { "40", 24m, "Added", "2026-04-09 23:45:17.300774", "14", "Toothpaste", "Box", "4", 0 },
                    { "41", 72m, "Added", "2026-04-09 23:45:17.300775", "14", "Toothpaste", "Carton", "5", 0 },
                    { "42", 1m, "Added", "2026-04-09 23:45:17.300776", "15", "USB Cable", "Piece", "1", 0 },
                    { "43", 50m, "Added", "2026-04-09 23:45:17.300776", "15", "USB Cable", "Box", "4", 0 },
                    { "44", 200m, "Added", "2026-04-09 23:45:17.300777", "15", "USB Cable", "Carton", "5", 0 },
                    { "45", 1m, "Added", "2026-04-09 23:45:17.300778", "16", "Phone Charger", "Piece", "1", 0 },
                    { "46", 20m, "Added", "2026-04-09 23:45:17.300779", "16", "Phone Charger", "Box", "4", 0 },
                    { "47", 100m, "Added", "2026-04-09 23:45:17.300780", "16", "Phone Charger", "Carton", "5", 0 },
                    { "5", 12m, "Added", "2026-04-09 23:45:17.300741", "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "6", 24m, "Added", "2026-04-09 23:45:17.300743", "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "7", 1m, "Added", "2026-04-09 23:45:17.300744", "3", "Mineral Water 1L", "Bottle", "2", 0 },
                    { "8", 6m, "Added", "2026-04-09 23:45:17.300745", "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "9", 12m, "Added", "2026-04-09 23:45:17.300745", "3", "Mineral Water 1L", "Carton", "5", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 4, 9, 23, 45, 17, 308, DateTimeKind.Local).AddTicks(4886), "Unchanged", new DateTime(2026, 10, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(4783), false, "2026-04-09 23:45:17.308629", "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 3, 30, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(4783), "Active", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 308, DateTimeKind.Local).AddTicks(5609), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 4, 9, 23, 45, 17, 308, DateTimeKind.Local).AddTicks(9345), "Unchanged", new DateTime(2026, 11, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(4783), false, "2026-04-09 23:45:17.309129", "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 4, 4, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(4783), "Active", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 309, DateTimeKind.Local).AddTicks(401), 0 },
                    { "3", "OREO-101", null, new DateTime(2026, 4, 9, 23, 45, 17, 309, DateTimeKind.Local).AddTicks(4622), "Unchanged", new DateTime(2026, 7, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(4783), false, "2026-04-09 23:45:17.309683", "4", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 3, 25, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(4783), "Active", "3", "Pack", null, new DateTime(2026, 4, 9, 23, 45, 17, 309, DateTimeKind.Local).AddTicks(5761), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 4, 9, 23, 45, 17, 309, DateTimeKind.Local).AddTicks(7898), "Unchanged", null, false, "2026-04-09 23:45:17.309791", "7", "A4 Notebook", 120000L, 200m, new DateTime(2026, 3, 20, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(4783), "Active", "1", "Piece", null, new DateTime(2026, 4, 9, 23, 45, 17, 309, DateTimeKind.Local).AddTicks(7912), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "DeletedAt", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", 140L, null, new DateTime(2026, 4, 9, 23, 45, 17, 304, DateTimeKind.Local).AddTicks(7587), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.304930", null, "1", "1", 160L, null, new DateTime(2026, 4, 9, 23, 45, 17, 304, DateTimeKind.Local).AddTicks(8577), 0 },
                    { "10", 230L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9500), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305950", null, "4", "10", 270L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9504), 0 },
                    { "11", 2760L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9583), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305959", null, "4", "11", 3240L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9588), 0 },
                    { "12", 11040L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9600), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305960", null, "4", "12", 12960L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9604), 0 },
                    { "13", 160L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9616), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305962", null, "5", "13", 190L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9620), 0 },
                    { "14", 3200L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9631), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305963", null, "5", "14", 3800L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9635), 0 },
                    { "15", 9600L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9651), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305965", null, "5", "15", 11400L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9655), 0 },
                    { "16", 110L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9667), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305967", null, "6", "16", 130L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9671), 0 },
                    { "17", 2640L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9683), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305969", null, "6", "17", 3120L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9687), 0 },
                    { "18", 7920L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9698), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305970", null, "6", "18", 9360L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9702), 0 },
                    { "19", 280L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9715), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305972", null, "7", "19", 320L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9719), 0 },
                    { "2", 1680L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(2051), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305408", null, "1", "2", 1920L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(3160), 0 },
                    { "20", 3360L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9730), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305973", null, "7", "20", 3840L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9734), 0 },
                    { "21", 14000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9747), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305975", null, "7", "21", 16000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9751), 0 },
                    { "22", 45L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9762), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305976", null, "8", "22", 55L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9766), 0 },
                    { "23", 540L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9781), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305978", null, "8", "23", 660L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9785), 0 },
                    { "24", 6480L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9799), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305980", null, "8", "24", 7920L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9803), 0 },
                    { "25", 380L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9815), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305982", null, "9", "25", 420L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9819), 0 },
                    { "26", 7600L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9831), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305983", null, "9", "26", 8400L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9835), 0 },
                    { "27", 430L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9846), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305985", null, "10", "27", 470L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9850), 0 },
                    { "28", 5160L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9861), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305986", null, "10", "28", 5640L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9865), 0 },
                    { "29", 10320L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9877), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305988", null, "10", "29", 11280L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9880), 0 },
                    { "3", 3360L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(5915), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305832", null, "1", "3", 3840L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(7173), 0 },
                    { "30", 260L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9902), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305991", null, "11", "30", 300L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9906), 0 },
                    { "31", 2600L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9921), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305992", null, "11", "31", 3000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9925), 0 },
                    { "32", 6500L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9936), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305994", null, "11", "32", 7500L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9940), 0 },
                    { "33", 180L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9951), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305995", null, "12", "33", 220L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9955), 0 },
                    { "34", 3600L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9967), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305997", null, "12", "34", 4400L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9971), 0 },
                    { "35", 9000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9982), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305998", null, "12", "35", 11000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9985), 0 },
                    { "36", 330L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9997), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306000", null, "13", "36", 370L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(1), 0 },
                    { "37", 3960L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(13), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306002", null, "13", "37", 4440L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(17), 0 },
                    { "38", 7920L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(29), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306003", null, "13", "38", 8880L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(33), 0 },
                    { "39", 160L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(48), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306005", null, "14", "39", 200L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(52), 0 },
                    { "4", 130L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9375), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305939", null, "2", "4", 150L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9390), 0 },
                    { "40", 3840L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(64), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306007", null, "14", "40", 4800L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(68), 0 },
                    { "41", 11520L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(79), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306008", null, "14", "41", 14400L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(82), 0 },
                    { "42", 230L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(93), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306010", null, "15", "42", 270L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(97), 0 },
                    { "43", 11500L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(111), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306011", null, "15", "43", 13500L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(115), 0 },
                    { "44", 46000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(128), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306013", null, "15", "44", 54000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(132), 0 },
                    { "45", 750L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(144), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306015", null, "16", "45", 850L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(147), 0 },
                    { "46", 15000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(159), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306016", null, "16", "46", 17000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(163), 0 },
                    { "47", 75000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(177), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.306018", null, "16", "47", 85000L, null, new DateTime(2026, 4, 9, 23, 45, 17, 306, DateTimeKind.Local).AddTicks(181), 0 },
                    { "5", 1560L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9408), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305941", null, "2", "5", 1800L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9412), 0 },
                    { "6", 3120L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9424), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305943", null, "2", "6", 3600L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9428), 0 },
                    { "7", 70L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9453), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305946", null, "3", "7", 90L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9457), 0 },
                    { "8", 420L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9469), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305947", null, "3", "8", 540L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9473), 0 },
                    { "9", 840L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9484), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-04-09 23:45:17.305949", null, "3", "9", 1080L, null, new DateTime(2026, 4, 9, 23, 45, 17, 305, DateTimeKind.Local).AddTicks(9488), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 4, 9, 23, 45, 17, 313, DateTimeKind.Local).AddTicks(454), "Unchanged", false, "2026-04-09 23:45:17.313095", "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 313, DateTimeKind.Local).AddTicks(743), 0 },
                    { "10", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3838), "Unchanged", false, "2026-04-09 23:45:17.314384", "7", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3843), 0 },
                    { "2", null, new DateTime(2026, 4, 9, 23, 45, 17, 313, DateTimeKind.Local).AddTicks(4664), "Unchanged", false, "2026-04-09 23:45:17.313647", "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 313, DateTimeKind.Local).AddTicks(5605), 0 },
                    { "3", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(363), "Unchanged", false, "2026-04-09 23:45:17.314262", "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(1552), 0 },
                    { "4", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3664), "Unchanged", false, "2026-04-09 23:45:17.314368", "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3680), 0 },
                    { "5", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3708), "Unchanged", false, "2026-04-09 23:45:17.314371", "4", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3713), 0 },
                    { "6", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3732), "Unchanged", false, "2026-04-09 23:45:17.314374", "4", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3737), 0 },
                    { "7", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3756), "Unchanged", false, "2026-04-09 23:45:17.314376", "4", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "3", "Pack", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3760), 0 },
                    { "8", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3779), "Unchanged", false, "2026-04-09 23:45:17.314378", "7", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "1", "Piece", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3784), 0 },
                    { "9", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3802), "Unchanged", false, "2026-04-09 23:45:17.314381", "7", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 4, 9, 23, 45, 17, 314, DateTimeKind.Local).AddTicks(3806), 0 }
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
