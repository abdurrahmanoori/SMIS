using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    ClientCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientCreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ClientModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
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
                    { "33333333-0000-0000-0000-000000000001", null, "Unchanged", "0001-01-01 00:00:00.000000", "SuperAdmin", "SUPERADMIN", 0 },
                    { "33333333-0000-0000-0000-000000000002", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopAdmin", "WSHOPADMIN", 0 },
                    { "33333333-0000-0000-0000-000000000003", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopAdministration", "WSHOPADMINISTRATION", 0 },
                    { "33333333-0000-0000-0000-000000000004", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopManager", "WSHOPMANAGER", 0 },
                    { "33333333-0000-0000-0000-000000000005", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopStaff", "WSHOPSTAFF", 0 },
                    { "33333333-0000-0000-0000-000000000006", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopViewer", "WSHOPVIEWER", 0 },
                    { "33333333-0000-0000-0000-000000000007", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopEditor", "WSHOPEDITOR", 0 },
                    { "33333333-0000-0000-0000-000000000008", null, "Unchanged", "0001-01-01 00:00:00.000000", "WShopUser", "WSHOPUSER", 0 },
                    { "33333333-0000-0000-0000-000000000009", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopAdmin", "RSHOPADMIN", 0 },
                    { "33333333-0000-0000-0000-000000000010", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopAdministration", "RSHOPADMINISTRATION", 0 },
                    { "33333333-0000-0000-0000-000000000011", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopManager", "RSHOPMANAGER", 0 },
                    { "33333333-0000-0000-0000-000000000012", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopStaff", "RSHOPSTAFF", 0 },
                    { "33333333-0000-0000-0000-000000000013", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopViewer", "RSHOPVIEWER", 0 },
                    { "33333333-0000-0000-0000-000000000014", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopEditor", "RSHOPEDITOR", 0 },
                    { "33333333-0000-0000-0000-000000000015", null, "Unchanged", "0001-01-01 00:00:00.000000", "RShopUser", "RSHOPUSER", 0 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "EntityState", "IsActive", "LastModifiedUtc", "Name", "Version" },
                values: new object[,]
                {
                    { "22222222-0000-0000-0000-000000000001", "en", "Added", true, "2026-09-03 10:14:02.523806", "English", 0 },
                    { "22222222-0000-0000-0000-000000000002", "ps", "Added", true, "2026-09-03 10:14:02.523867", "Pashto", 0 },
                    { "22222222-0000-0000-0000-000000000003", "fa", "Added", true, "2026-09-03 10:14:02.523868", "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "77777777-0000-0000-0000-000000000001", null, null, null, "Unchanged", false, false, true, "2026-09-03 10:14:02.525286", null, "Kabul", null, null, 0 },
                    { "77777777-0000-0000-0000-000000000002", null, null, null, "Unchanged", false, false, true, "2026-09-03 10:14:02.525311", null, "Herat", null, null, 0 },
                    { "77777777-0000-0000-0000-000000000003", null, null, null, "Unchanged", false, false, true, "2026-09-03 10:14:02.525311", null, "Kandahar", null, null, 0 },
                    { "77777777-0000-0000-0000-000000000004", null, null, null, "Unchanged", false, false, true, "2026-09-03 10:14:02.525311", null, "Balkh", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedAt", "Email", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "11111111-0000-0000-0000-000000000001", "Kabul Center", null, new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(4118), null, "main@store.local", "Unchanged", true, false, false, "2026-09-03 10:14:02.529495", "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(4667), 0 },
                    { "11111111-0000-0000-0000-000000000002", "Herat Center", null, new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(6743), null, "branch@store.local", "Unchanged", true, false, false, "2026-09-03 10:14:02.529786", "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(7438), 0 },
                    { "11111111-0000-0000-0000-000000000003", "Kandahar Center", null, new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(9003), null, "warehouse@store.local", "Unchanged", true, false, false, "2026-09-03 10:14:02.530032", "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 9, 3, 10, 14, 2, 529, DateTimeKind.Utc).AddTicks(9808), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "55555555-0000-0000-0000-000000000001", null, null, null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.524326", null, "1001", "Kabul Center District", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000002", null, null, null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.524390", null, "1002", "Kabul North District", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000003", null, null, null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.524390", null, "1003", "Herat Center District", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000004", null, null, null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.524391", null, "2001", "Kabul Province", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000005", null, null, null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.524392", null, "2002", "Herat Province", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000006", null, null, null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.524392", null, "3001", "Welcome Message", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000007", null, null, null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.524392", null, "3002", "Error Message", null, null, 0 },
                    { "55555555-0000-0000-0000-000000000008", null, null, null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.524392", null, "3003", "Success Message", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "44444444-0000-0000-0000-000000000001", 0, "7dd0a468-0712-421e-8a57-91a30095756f", "superadmin@smis.com", true, "Unchanged", "Super", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEO7hpnuBvCuMHzyanpTTWYc/rnug3J+oJoYf8nwBlEmv4FDPFlbv+T8uedBuJFhEcw==", "+855123456789", true, "9c3d45bd-d6b6-497d-aec4-59c6eba1e6e1", "11111111-0000-0000-0000-000000000001", "Main Store", false, "superadmin", 0 },
                    { "44444444-0000-0000-0000-000000000002", 0, "688ba3a6-e99e-4a9c-aae1-405d4a39523e", "wadmin@smis.com", true, "Unchanged", "Wholesale", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEL5lN64+UixZjPiksHfBY232KZkiLuphQ+sT1KkNhDPEiVWGC5I3R3RK2li5M5wEdg==", "+855123456790", true, "81512417-d4c0-414e-9484-83633ad4eb95", "11111111-0000-0000-0000-000000000001", "Main Store", false, "wadmin", 0 },
                    { "44444444-0000-0000-0000-000000000003", 0, "e4037663-5d8b-4895-ae24-9e26a11b0779", "wadministration@smis.com", true, "Unchanged", "Wholesale", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEEALFt9iIpwS689b3+go/dDOiEueyVA8Ulg27u3eqobYU1zYkTSvfhNFWkwbDmGm3A==", "+855123456791", true, "93e4a071-bec6-45dc-bd7d-ccb5c9ebe1a5", "11111111-0000-0000-0000-000000000001", "Main Store", false, "wadministration", 0 },
                    { "44444444-0000-0000-0000-000000000004", 0, "e3fdfa1b-051e-4a18-80f9-f3a342210493", "wmanager@smis.com", true, "Unchanged", "Wholesale", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAECT6V6JKi36Mg2FK692H3+Ei5LJr1x2NHLNy62s3tst6kmsJ/t0yvkNLw/D4v+9bQA==", "+855123456792", true, "d7c1ea12-07c1-4829-8d2f-44f9cb80b9ce", "11111111-0000-0000-0000-000000000001", "Main Store", false, "wmanager", 0 },
                    { "44444444-0000-0000-0000-000000000005", 0, "512512bc-f234-4f79-b371-2ebf73fea254", "wstaff@smis.com", true, "Unchanged", "Wholesale", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAENbCRhowzZbdwbEbC/BrlQ32aMHanlDJO1f5EnoSmHc8883DLcXxD3wY3h1Nsjd5PA==", "+855123456793", true, "3c2b5457-4113-49e2-8182-785a8ba22d21", "11111111-0000-0000-0000-000000000001", "Main Store", false, "wstaff", 0 },
                    { "44444444-0000-0000-0000-000000000006", 0, "419ba84b-f5c0-492f-91ca-c9432fe1ebf8", "wviewer@smis.com", true, "Unchanged", "Wholesale", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEMrKJSaRR4p8U3XlmnnnCJvk8Jdlj3OUHNU18iTE0vD9M0vtN1Zm4cl6bTVm4PyhKQ==", "+8512345634366", true, "0fd85a2d-a568-40a5-bc78-0a7f9f1cc232", "11111111-0000-0000-0000-000000000001", "Main Store", false, "wviewer", 0 },
                    { "44444444-0000-0000-0000-000000000007", 0, "a53c4030-c5ba-465c-b50b-53dbd7de273b", "weditor@smis.com", true, "Unchanged", "Wholesale", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEF6W0ie+NPZ3QwRqVKo3W7wyxOqUGB+Jf/EuHAkV2BVSGF+oEXMVMT9331iHlFXWEg==", "+855123456795", true, "af550a63-eead-444d-b1ca-8eb7edee4912", "11111111-0000-0000-0000-000000000001", "Main Store", false, "weditor", 0 },
                    { "44444444-0000-0000-0000-000000000008", 0, "86b7e74a-1755-4610-b714-096f78fbba8b", "wuser@smis.com", true, "Unchanged", "Wholesale", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAEGS45XZnVbc6n9cTfrMCOvYNEpzmmrVW9BuEz2Uixkm5diPdOHX40tt0G6gl8pqPyQ==", "+855123456796", true, "2b684d0a-bcee-4ba1-bc0b-3655d9423fb2", "11111111-0000-0000-0000-000000000001", "Main Store", false, "wuser", 0 },
                    { "44444444-0000-0000-0000-000000000009", 0, "13b5fa3e-2eb4-46ac-bd9a-d877dd760167", "radmin@smis.com", true, "Unchanged", "Retail", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEPE/yD69+WTh8CM+14NLwZz2za9KLCkWtRPDV8eb2etQMMv183nsQ8XE0iVf9TZPng==", "+855123456797", true, "6cd68fbf-628f-41e7-b13e-18dcfa7f165c", "11111111-0000-0000-0000-000000000002", "Branch Store", false, "radmin", 0 },
                    { "44444444-0000-0000-0000-000000000010", 0, "2357cbd1-768b-4205-95ea-70b18fb891f7", "radministration@smis.com", true, "Unchanged", "Retail", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEEJoBPL9EyFut/aCNhVYQMD8dV0545sfI9UpIndRm9pDGAPiUui7sVeJ5aP0AY9+ZQ==", "+855123456798", true, "5d9de234-0e63-4d36-8577-a7ba980312d2", "11111111-0000-0000-0000-000000000002", "Branch Store", false, "radministration", 0 },
                    { "44444444-0000-0000-0000-000000000011", 0, "97495e8f-5914-40b3-b104-6f88b34684df", "rmanager@smis.com", true, "Unchanged", "Retail", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEP6bsg2f7OQu8OlZvxpIIdKW2VEUFFZgvfGeKDm/bit4rE06+1kcu0dQJR0a8g+hxQ==", "+855123456799", true, "5dba43c4-077d-4134-b4bd-9649adecfd98", "11111111-0000-0000-0000-000000000002", "Branch Store", false, "rmanager", 0 },
                    { "44444444-0000-0000-0000-000000000012", 0, "30ca116a-c0bb-4dce-8c64-46548051fcda", "rstaff@smis.com", true, "Unchanged", "Retail", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEOga1jWtvI8ZGX/YSVfiZBxu+dlfKaunwxSde8/LgJmV9KYvROCWXHJqZTNkrltluQ==", "+855123456800", true, "2c08364e-b9f1-4bcb-be35-adb397804f8a", "11111111-0000-0000-0000-000000000002", "Branch Store", false, "rstaff", 0 },
                    { "44444444-0000-0000-0000-000000000013", 0, "b3ec1b7a-46b4-42bf-8921-1ddbefa7da9f", "rviewer@smis.com", true, "Unchanged", "Retail", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAELw3oWGT8PRLBCedzSpNicdODKYgLz3yDOcFrzvEEkITClUj6TG337wskSPbYTxq2A==", "+855123456801", true, "2e9c27d7-120b-4bc0-ad17-8965f60d28c3", "11111111-0000-0000-0000-000000000002", "Branch Store", false, "rviewer", 0 },
                    { "44444444-0000-0000-0000-000000000014", 0, "9412da45-2e25-49fd-ae32-93549f5100c4", "reditor@smis.com", true, "Unchanged", "Retail", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAECFf+9cErokcc5R5XIySkQbIqgOGAA3pPgkePIULg2MSeEPST/YX/C+EHbIlK2XQeg==", "+855123456802", true, "8ad5b59f-8df4-4477-afff-e8b154e36969", "11111111-0000-0000-0000-000000000002", "Branch Store", false, "reditor", 0 },
                    { "44444444-0000-0000-0000-000000000015", 0, "6f9f48d5-02a0-4434-84ca-b468507430d2", "ruser@smis.com", true, "Unchanged", "Retail", "22222222-0000-0000-0000-000000000001", "0001-01-01 00:00:00.000000", "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEMYx2nN7NYnTlGdNKib4QT+5ZxdTFEmKpN9PLVdbUMQFM5FBHcJMRx9kCt1oD6rPFw==", "+855123456803", true, "ddb19305-f3e2-4738-8678-f24a7ffda519", "11111111-0000-0000-0000-000000000002", "Branch Store", false, "ruser", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "Code", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "bbbbbbbb-0000-0000-0000-000000000001", null, null, null, null, "BEV", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(5360), null, "Drinks and beverages", "Unchanged", true, false, false, "2026-09-03 10:14:02.532550", "Beverages", "11111111-0000-0000-0000-000000000001", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(5499), 0 },
                    { "bbbbbbbb-0000-0000-0000-000000000002", null, null, null, null, "FOOD", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6452), null, "Edible products and snacks", "Unchanged", true, false, false, "2026-09-03 10:14:02.532645", "Food Items", "11111111-0000-0000-0000-000000000001", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6454), 0 },
                    { "bbbbbbbb-0000-0000-0000-000000000003", null, null, null, null, "STAT", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6474), null, "Office and school supplies", "Unchanged", true, false, false, "2026-09-03 10:14:02.532647", "Stationery", "11111111-0000-0000-0000-000000000002", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6474), 0 },
                    { "bbbbbbbb-0000-0000-0000-000000000004", null, null, null, null, "GROC", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6486), null, "Daily household items", "Unchanged", true, false, false, "2026-09-03 10:14:02.532648", "Grocery", "11111111-0000-0000-0000-000000000002", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6487), 0 },
                    { "bbbbbbbb-0000-0000-0000-000000000005", null, null, null, null, "CARE", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6492), null, "Health and hygiene products", "Unchanged", true, false, false, "2026-09-03 10:14:02.532649", "Personal Care", "11111111-0000-0000-0000-000000000003", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6493), 0 },
                    { "bbbbbbbb-0000-0000-0000-000000000006", null, null, null, null, "ELEC", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6498), null, "Electronic devices and accessories", "Unchanged", true, false, false, "2026-09-03 10:14:02.532649", "Electronics", "11111111-0000-0000-0000-000000000003", null, new DateTime(2026, 9, 3, 10, 14, 2, 532, DateTimeKind.Utc).AddTicks(6498), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "99999999-0000-0000-0000-000000000001", null, null, null, "Unchanged", false, false, true, "2026-09-03 10:14:02.525697", null, "Kabul Center", "55555555-0000-0000-0000-000000000001", null, null, 0 },
                    { "99999999-0000-0000-0000-000000000002", null, null, null, "Unchanged", false, false, true, "2026-09-03 10:14:02.525729", null, "Kabul North", "55555555-0000-0000-0000-000000000002", null, null, 0 },
                    { "99999999-0000-0000-0000-000000000003", null, null, null, "Unchanged", false, false, true, "2026-09-03 10:14:02.525729", null, "Herat Center", "55555555-0000-0000-0000-000000000003", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "88888888-0000-0000-0000-000000000001", "Added", true, "en", "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.525374", "Kabul", "77777777-0000-0000-0000-000000000001", 0 },
                    { "88888888-0000-0000-0000-000000000002", "Added", false, "ps", "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.525497", "کابل", "77777777-0000-0000-0000-000000000001", 0 },
                    { "88888888-0000-0000-0000-000000000003", "Added", false, "fa", "22222222-0000-0000-0000-000000000003", "2026-09-03 10:14:02.525498", "کابل", "77777777-0000-0000-0000-000000000001", 0 },
                    { "88888888-0000-0000-0000-000000000004", "Added", true, "en", "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.525498", "Herat", "77777777-0000-0000-0000-000000000002", 0 },
                    { "88888888-0000-0000-0000-000000000005", "Added", false, "ps", "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.525499", "هرات", "77777777-0000-0000-0000-000000000002", 0 },
                    { "88888888-0000-0000-0000-000000000006", "Added", false, "fa", "22222222-0000-0000-0000-000000000003", "2026-09-03 10:14:02.525499", "هرات", "77777777-0000-0000-0000-000000000002", 0 },
                    { "88888888-0000-0000-0000-000000000007", "Added", true, "en", "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.525499", "Kandahar", "77777777-0000-0000-0000-000000000003", 0 },
                    { "88888888-0000-0000-0000-000000000008", "Added", false, "ps", "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.525499", "کندهار", "77777777-0000-0000-0000-000000000003", 0 },
                    { "88888888-0000-0000-0000-000000000009", "Added", false, "fa", "22222222-0000-0000-0000-000000000003", "2026-09-03 10:14:02.525500", "قندهار", "77777777-0000-0000-0000-000000000003", 0 },
                    { "88888888-0000-0000-0000-000000000010", "Added", true, "en", "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.525500", "Balkh", "77777777-0000-0000-0000-000000000004", 0 },
                    { "88888888-0000-0000-0000-000000000011", "Added", false, "ps", "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.525500", "بلخ", "77777777-0000-0000-0000-000000000004", 0 },
                    { "88888888-0000-0000-0000-000000000012", "Added", false, "fa", "22222222-0000-0000-0000-000000000003", "2026-09-03 10:14:02.525501", "بلخ", "77777777-0000-0000-0000-000000000004", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LanguageNo", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "66666666-0000-0000-0000-000000000001", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.524728", null, "Kabul Center District", "55555555-0000-0000-0000-000000000001", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000002", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.524770", null, "منطقه مرکز کابل", "55555555-0000-0000-0000-000000000001", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000003", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.524771", null, "Kabul North District", "55555555-0000-0000-0000-000000000002", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000004", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.524771", null, "منطقه شمال کابل", "55555555-0000-0000-0000-000000000002", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000005", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.524772", null, "Herat Center District", "55555555-0000-0000-0000-000000000003", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000006", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.524772", null, "منطقه مرکز هرات", "55555555-0000-0000-0000-000000000003", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000007", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.524772", null, "Kabul Province", "55555555-0000-0000-0000-000000000004", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000008", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.524772", null, "ولایت کابل", "55555555-0000-0000-0000-000000000004", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000009", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.524775", null, "Herat Province", "55555555-0000-0000-0000-000000000005", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000010", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.524775", null, "ولایت هرات", "55555555-0000-0000-0000-000000000005", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000011", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000001", "2026-09-03 10:14:02.524777", null, "Welcome Message", "55555555-0000-0000-0000-000000000006", null, null, 0 },
                    { "66666666-0000-0000-0000-000000000012", null, null, null, "Unchanged", false, false, true, "22222222-0000-0000-0000-000000000002", "2026-09-03 10:14:02.524777", null, "پیام خوش آمدید", "55555555-0000-0000-0000-000000000006", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "aaaaaaaa-0000-0000-0000-000000000001", "Individual items", "Added", "2026-09-03 10:14:02.531252", "Piece", "11111111-0000-0000-0000-000000000001", "pcs", 0 },
                    { "aaaaaaaa-0000-0000-0000-000000000002", "Liquid containers", "Added", "2026-09-03 10:14:02.531406", "Bottle", "11111111-0000-0000-0000-000000000001", "btl", 0 },
                    { "aaaaaaaa-0000-0000-0000-000000000003", "Small packages", "Added", "2026-09-03 10:14:02.531542", "Pack", "11111111-0000-0000-0000-000000000001", "pk", 0 },
                    { "aaaaaaaa-0000-0000-0000-000000000004", "Medium containers", "Added", "2026-09-03 10:14:02.531618", "Box", "11111111-0000-0000-0000-000000000001", "box", 0 },
                    { "aaaaaaaa-0000-0000-0000-000000000005", "Large containers", "Added", "2026-09-03 10:14:02.531619", "Carton", "11111111-0000-0000-0000-000000000001", "ctn", 0 },
                    { "aaaaaaaa-0000-0000-0000-000000000006", "Volume measurement", "Added", "2026-09-03 10:14:02.531621", "Liter", "11111111-0000-0000-0000-000000000001", "L", 0 },
                    { "aaaaaaaa-0000-0000-0000-000000000007", "Weight measurement", "Added", "2026-09-03 10:14:02.531621", "Kilogram", "11111111-0000-0000-0000-000000000001", "kg", 0 },
                    { "aaaaaaaa-0000-0000-0000-000000000008", "Small weight measurement", "Added", "2026-09-03 10:14:02.531622", "Gram", "11111111-0000-0000-0000-000000000001", "g", 0 },
                    { "aaaaaaaa-0000-0000-0000-000000000009", "Small volume measurement", "Added", "2026-09-03 10:14:02.531622", "Milliliter", "11111111-0000-0000-0000-000000000001", "ml", 0 },
                    { "aaaaaaaa-0000-0000-0000-000000000010", "12 pieces", "Added", "2026-09-03 10:14:02.531623", "Dozen", "11111111-0000-0000-0000-000000000001", "dz", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "RoleName", "UserName" },
                values: new object[,]
                {
                    { "33333333-0000-0000-0000-000000000001", "44444444-0000-0000-0000-000000000001", "SuperAdmin", "superadmin" },
                    { "33333333-0000-0000-0000-000000000002", "44444444-0000-0000-0000-000000000002", "WShopAdmin", "wadmin" },
                    { "33333333-0000-0000-0000-000000000003", "44444444-0000-0000-0000-000000000003", "WShopAdministration", "wadministration" },
                    { "33333333-0000-0000-0000-000000000004", "44444444-0000-0000-0000-000000000004", "WShopManager", "wmanager" },
                    { "33333333-0000-0000-0000-000000000005", "44444444-0000-0000-0000-000000000005", "WShopStaff", "wstaff" },
                    { "33333333-0000-0000-0000-000000000006", "44444444-0000-0000-0000-000000000006", "WShopViewer", "wviewer" },
                    { "33333333-0000-0000-0000-000000000007", "44444444-0000-0000-0000-000000000007", "WShopEditor", "weditor" },
                    { "33333333-0000-0000-0000-000000000008", "44444444-0000-0000-0000-000000000008", "WShopUser", "wuser" },
                    { "33333333-0000-0000-0000-000000000009", "44444444-0000-0000-0000-000000000009", "RShopAdmin", "radmin" },
                    { "33333333-0000-0000-0000-000000000010", "44444444-0000-0000-0000-000000000010", "RShopAdministration", "radministration" },
                    { "33333333-0000-0000-0000-000000000011", "44444444-0000-0000-0000-000000000011", "RShopManager", "rmanager" },
                    { "33333333-0000-0000-0000-000000000012", "44444444-0000-0000-0000-000000000012", "RShopStaff", "rstaff" },
                    { "33333333-0000-0000-0000-000000000013", "44444444-0000-0000-0000-000000000013", "RShopViewer", "rviewer" },
                    { "33333333-0000-0000-0000-000000000014", "44444444-0000-0000-0000-000000000014", "RShopEditor", "reditor" },
                    { "33333333-0000-0000-0000-000000000015", "44444444-0000-0000-0000-000000000015", "RShopUser", "ruser" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "CustomerType", "DeletedAt", "DeletedBy", "DistrictId", "Email", "EntityState", "FatherName", "FirstName", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "eeeeeeee-0000-0000-0000-000000000001", "123 Main St, Phnom Penh", null, new DateTime(2026, 9, 3, 10, 14, 2, 545, DateTimeKind.Utc).AddTicks(7831), "Individual", null, null, "99999999-0000-0000-0000-000000000001", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, true, "2026-09-03 10:14:02.545805", "Doe", null, "+855123456789", "77777777-0000-0000-0000-000000000001", "11111111-0000-0000-0000-000000000001", "Main Store", "TAX001", null, new DateTime(2026, 9, 3, 10, 14, 2, 545, DateTimeKind.Utc).AddTicks(7968), 0 },
                    { "eeeeeeee-0000-0000-0000-000000000002", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(15), "Individual", null, null, "99999999-0000-0000-0000-000000000002", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, true, "2026-09-03 10:14:02.546097", "Smith", null, "+855987654321", "77777777-0000-0000-0000-000000000001", "11111111-0000-0000-0000-000000000001", "Main Store", "TAX002", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(588), 0 },
                    { "eeeeeeee-0000-0000-0000-000000000003", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(2392), "Enterprise", null, null, "99999999-0000-0000-0000-000000000003", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, true, "2026-09-03 10:14:02.546355", "Brown", null, "+855555123456", "77777777-0000-0000-0000-000000000002", "11111111-0000-0000-0000-000000000001", "Main Store", null, null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(3073), 0 },
                    { "eeeeeeee-0000-0000-0000-000000000004", "321 Elm St, Siem Reap", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4037), "Individual", null, null, "99999999-0000-0000-0000-000000000001", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, true, "2026-09-03 10:14:02.546404", "Wilson", null, "+855444987654", "77777777-0000-0000-0000-000000000003", "11111111-0000-0000-0000-000000000002", "Branch Store", "TAX003", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4043), 0 },
                    { "eeeeeeee-0000-0000-0000-000000000005", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4059), "Individual", null, null, "99999999-0000-0000-0000-000000000002", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, true, "2026-09-03 10:14:02.546406", "Taylor", null, "+855333456789", "77777777-0000-0000-0000-000000000003", "11111111-0000-0000-0000-000000000002", "Branch Store", null, null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4062), 0 },
                    { "eeeeeeee-0000-0000-0000-000000000006", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4077), "Enterprise", null, null, "99999999-0000-0000-0000-000000000003", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, true, "2026-09-03 10:14:02.546408", "Garcia", null, "+855222123456", "77777777-0000-0000-0000-000000000004", "11111111-0000-0000-0000-000000000002", "Branch Store", "TAX004", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4080), 0 },
                    { "eeeeeeee-0000-0000-0000-000000000007", "147 Birch St, Battambang", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4101), "Individual", null, null, "99999999-0000-0000-0000-000000000001", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, true, "2026-09-03 10:14:02.546410", "Martinez", null, "+855111987654", "77777777-0000-0000-0000-000000000001", "11111111-0000-0000-0000-000000000003", "Warehouse", null, null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4104), 0 },
                    { "eeeeeeee-0000-0000-0000-000000000008", "258 Spruce Ave, Battambang", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4119), "Individual", null, null, "99999999-0000-0000-0000-000000000002", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, true, "2026-09-03 10:14:02.546412", "Lopez", null, "+855666456789", "77777777-0000-0000-0000-000000000002", "11111111-0000-0000-0000-000000000003", "Warehouse", "TAX005", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4121), 0 },
                    { "eeeeeeee-0000-0000-0000-000000000009", "369 Fir Rd, Battambang", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4133), "Enterprise", null, null, "99999999-0000-0000-0000-000000000003", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, true, "2026-09-03 10:14:02.546413", "Gonzalez", null, "+855777123456", "77777777-0000-0000-0000-000000000003", "11111111-0000-0000-0000-000000000003", "Warehouse", null, null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4135), 0 },
                    { "eeeeeeee-0000-0000-0000-000000000010", "741 Ash Dr, Battambang", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4150), "Individual", null, null, "99999999-0000-0000-0000-000000000001", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, true, "2026-09-03 10:14:02.546415", "Rodriguez", null, "+855888987654", "77777777-0000-0000-0000-000000000004", "11111111-0000-0000-0000-000000000003", "Warehouse", "TAX006", null, new DateTime(2026, 9, 3, 10, 14, 2, 546, DateTimeKind.Utc).AddTicks(4152), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "ImageUrl", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "cccccccc-0000-0000-0000-000000000001", "1234567890001", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", "bbbbbbbb-0000-0000-0000-000000000001", "Beverages", null, new DateTime(2026, 9, 3, 10, 14, 2, 537, DateTimeKind.Utc).AddTicks(3620), null, "Classic cola drink", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.537386", null, "Coca Cola 500ml", "COKE-500ML-001", "11111111-0000-0000-0000-000000000001", "Main Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 537, DateTimeKind.Utc).AddTicks(3776), 0 },
                    { "cccccccc-0000-0000-0000-000000000002", "1234567890002", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", "bbbbbbbb-0000-0000-0000-000000000001", "Beverages", null, new DateTime(2026, 9, 3, 10, 14, 2, 537, DateTimeKind.Utc).AddTicks(8181), null, "Cola soft drink", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.538077", null, "Pepsi 500ml", "PEPSI-500ML-002", "11111111-0000-0000-0000-000000000001", "Main Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 537, DateTimeKind.Utc).AddTicks(8700), 0 },
                    { "cccccccc-0000-0000-0000-000000000003", "1234567890003", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", "bbbbbbbb-0000-0000-0000-000000000001", "Beverages", null, new DateTime(2026, 9, 3, 10, 14, 2, 538, DateTimeKind.Utc).AddTicks(8068), null, "Pure drinking water", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539097", null, "Mineral Water 1L", "WATER-1L-003", "11111111-0000-0000-0000-000000000002", "Branch Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 538, DateTimeKind.Utc).AddTicks(9702), 0 },
                    { "cccccccc-0000-0000-0000-000000000004", "1234567890004", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", "bbbbbbbb-0000-0000-0000-000000000002", "Food Items", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2208), null, "Chocolate sandwich cookies", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539223", null, "Oreo Biscuits", "OREO-PACK-004", "11111111-0000-0000-0000-000000000001", "Main Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2225), 0 },
                    { "cccccccc-0000-0000-0000-000000000005", "1234567890005", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", "bbbbbbbb-0000-0000-0000-000000000002", "Food Items", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2276), null, "Potato chips", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539228", null, "Lay's Chips", "LAYS-PACK-005", "11111111-0000-0000-0000-000000000002", "Branch Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2284), 0 },
                    { "cccccccc-0000-0000-0000-000000000006", "1234567890006", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", "bbbbbbbb-0000-0000-0000-000000000002", "Food Items", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2325), null, "Quick meal noodles", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539233", null, "Instant Noodles", "NOODLE-PACK-006", "11111111-0000-0000-0000-000000000003", "Warehouse", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2331), 0 },
                    { "cccccccc-0000-0000-0000-000000000007", "1234567890007", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", "bbbbbbbb-0000-0000-0000-000000000003", "Stationery", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2368), null, "200 pages ruled notebook", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539237", null, "A4 Notebook", "NOTE-A4-007", "11111111-0000-0000-0000-000000000001", "Main Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2375), 0 },
                    { "cccccccc-0000-0000-0000-000000000008", "1234567890008", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", "bbbbbbbb-0000-0000-0000-000000000003", "Stationery", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2412), null, "Ballpoint pen", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539242", null, "Blue Pen", "PEN-BLUE-008", "11111111-0000-0000-0000-000000000002", "Branch Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2419), 0 },
                    { "cccccccc-0000-0000-0000-000000000009", "1234567890009", "aaaaaaaa-0000-0000-0000-000000000004", "Box", "bbbbbbbb-0000-0000-0000-000000000003", "Stationery", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2485), null, "12 pencils per box", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539250", null, "Pencil Set", "PENCIL-BOX-009", "11111111-0000-0000-0000-000000000003", "Warehouse", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2505), 0 },
                    { "cccccccc-0000-0000-0000-000000000010", "1234567890010", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", "bbbbbbbb-0000-0000-0000-000000000004", "Grocery", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2560), null, "Sunflower cooking oil", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539257", null, "Cooking Oil 1L", "OIL-1L-010", "11111111-0000-0000-0000-000000000001", "Main Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2567), 0 },
                    { "cccccccc-0000-0000-0000-000000000011", "1234567890011", "aaaaaaaa-0000-0000-0000-000000000007", "Kilogram", "bbbbbbbb-0000-0000-0000-000000000004", "Grocery", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2606), null, "Basmati rice", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539261", null, "Rice 1kg", "RICE-1KG-011", "11111111-0000-0000-0000-000000000002", "Branch Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2612), 0 },
                    { "cccccccc-0000-0000-0000-000000000012", "1234567890012", "aaaaaaaa-0000-0000-0000-000000000007", "Kilogram", "bbbbbbbb-0000-0000-0000-000000000004", "Grocery", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2650), null, "White granulated sugar", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539267", null, "Sugar 1kg", "SUGAR-1KG-012", "11111111-0000-0000-0000-000000000003", "Warehouse", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2656), 0 },
                    { "cccccccc-0000-0000-0000-000000000013", "1234567890013", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", "bbbbbbbb-0000-0000-0000-000000000005", "Personal Care", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2707), null, "Hair care shampoo", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539271", null, "Shampoo 400ml", "SHAMP-400ML-013", "11111111-0000-0000-0000-000000000001", "Main Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2713), 0 },
                    { "cccccccc-0000-0000-0000-000000000014", "1234567890014", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", "bbbbbbbb-0000-0000-0000-000000000005", "Personal Care", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2751), null, "Dental care paste", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539276", null, "Toothpaste", "TOOTH-PASTE-014", "11111111-0000-0000-0000-000000000002", "Branch Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2757), 0 },
                    { "cccccccc-0000-0000-0000-000000000015", "1234567890015", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", "bbbbbbbb-0000-0000-0000-000000000006", "Electronics", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2793), null, "Type-C charging cable", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539280", null, "USB Cable", "USB-CABLE-015", "11111111-0000-0000-0000-000000000001", "Main Store", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2800), 0 },
                    { "cccccccc-0000-0000-0000-000000000016", "1234567890016", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", "bbbbbbbb-0000-0000-0000-000000000006", "Electronics", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2836), null, "Fast charging adapter", "Unchanged", null, true, false, false, true, "2026-09-03 10:14:02.539284", null, "Phone Charger", "CHARGER-016", "11111111-0000-0000-0000-000000000003", "Warehouse", null, new DateTime(2026, 9, 3, 10, 14, 2, 539, DateTimeKind.Utc).AddTicks(2843), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DeletedAt", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "ffffffff-0000-0000-0000-000000000001", "123 Main St", "44444444-0000-0000-0000-000000000001", null, new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(1629), null, null, "john.doe@example.com", null, "Unchanged", "John", true, false, false, true, "2026-09-03 10:14:02.550191", "Doe", null, "123456789", 100.0m, "+1234567890", null, "11111111-0000-0000-0000-000000000001", "Main Store", new DateTime(2026, 9, 3, 14, 44, 2, 547, DateTimeKind.Local).AddTicks(443), null, new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(1797), 0 },
                    { "ffffffff-0000-0000-0000-000000000002", "456 Oak Ave", "44444444-0000-0000-0000-000000000002", null, new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(3871), null, null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, false, true, "2026-09-03 10:14:02.550477", "Smith", null, "987654321", 75.0m, "+0987654321", null, "11111111-0000-0000-0000-000000000002", "Branch Store", new DateTime(2026, 9, 3, 14, 44, 2, 550, DateTimeKind.Local).AddTicks(1934), null, new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(4411), 0 },
                    { "ffffffff-0000-0000-0000-000000000003", "789 Pine Rd", "44444444-0000-0000-0000-000000000004", null, new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(6210), null, null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, false, true, "2026-09-03 10:14:02.550747", "Johnson", null, "555666777", 50.0m, "+1555666777", null, "11111111-0000-0000-0000-000000000003", "Warehouse", new DateTime(2026, 9, 3, 14, 44, 2, 550, DateTimeKind.Local).AddTicks(5112), null, new DateTime(2026, 9, 3, 10, 14, 2, 550, DateTimeKind.Utc).AddTicks(6956), 0 }
                });

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DeletedAt", "DueDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "44444444-4444-0000-0000-000000000001", null, new DateTime(2026, 9, 3, 10, 14, 2, 557, DateTimeKind.Utc).AddTicks(4065), "eeeeeeee-0000-0000-0000-000000000001", "John", null, new DateTime(2026, 10, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Unchanged", true, false, false, true, "2026-09-03 10:14:02.557427", null, new DateTime(2026, 8, 4, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Coca Cola loan for John", 5000m, "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 10m, "11111111-0000-0000-0000-000000000001", "Main Store", 1, 50000L, "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 557, DateTimeKind.Utc).AddTicks(4176), 0 },
                    { "44444444-4444-0000-0000-000000000002", null, new DateTime(2026, 9, 3, 10, 14, 2, 557, DateTimeKind.Utc).AddTicks(7221), "eeeeeeee-0000-0000-0000-000000000002", "Jane", null, new DateTime(2026, 9, 18, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Unchanged", true, false, false, true, "2026-09-03 10:14:02.557812", null, new DateTime(2026, 8, 19, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Oreo biscuits for Jane", 4000m, "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", 5m, "11111111-0000-0000-0000-000000000001", "Main Store", 1, 20000L, "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 3, 10, 14, 2, 557, DateTimeKind.Utc).AddTicks(7680), 0 },
                    { "44444444-4444-0000-0000-000000000003", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(1605), "eeeeeeee-0000-0000-0000-000000000003", "Michael", null, new DateTime(2026, 9, 23, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Unchanged", true, false, false, true, "2026-09-03 10:14:02.558436", null, new DateTime(2026, 8, 24, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Notebooks for Michael", 3000m, "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", 20m, "11111111-0000-0000-0000-000000000001", "Main Store", 1, 60000L, "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(3079), 0 },
                    { "44444444-4444-0000-0000-000000000004", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5220), "eeeeeeee-0000-0000-0000-000000000001", "John", null, new DateTime(2026, 10, 18, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Unchanged", true, false, false, true, "2026-09-03 10:14:02.558523", null, new DateTime(2026, 8, 29, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Cooking oil bulk order", 8000m, "cccccccc-0000-0000-0000-000000000010", "Cooking Oil 1L", 15m, "11111111-0000-0000-0000-000000000001", "Main Store", 1, 120000L, "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5231), 0 },
                    { "44444444-4444-0000-0000-000000000005", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5272), "eeeeeeee-0000-0000-0000-000000000004", "Sarah", null, new DateTime(2026, 9, 13, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Unchanged", true, false, false, true, "2026-09-03 10:14:02.558527", null, new DateTime(2026, 8, 14, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Pepsi for Sarah", 4500m, "cccccccc-0000-0000-0000-000000000002", "Pepsi 500ml", 24m, "11111111-0000-0000-0000-000000000002", "Branch Store", 1, 108000L, "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5274), 0 },
                    { "44444444-4444-0000-0000-000000000006", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5296), "eeeeeeee-0000-0000-0000-000000000005", "David", null, new DateTime(2026, 9, 21, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Unchanged", true, false, false, true, "2026-09-03 10:14:02.558530", null, new DateTime(2026, 8, 22, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Blue pens for David", 500m, "cccccccc-0000-0000-0000-000000000008", "Blue Pen", 50m, "11111111-0000-0000-0000-000000000002", "Branch Store", 1, 25000L, "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5298), 0 },
                    { "44444444-4444-0000-0000-000000000007", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5316), "eeeeeeee-0000-0000-0000-000000000006", "Lisa", null, null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.558532", null, new DateTime(2026, 8, 9, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Rice bulk purchase", 2000m, "cccccccc-0000-0000-0000-000000000011", "Rice 1kg", 100m, "11111111-0000-0000-0000-000000000002", "Branch Store", 1, 200000L, "aaaaaaaa-0000-0000-0000-000000000007", "Kilogram", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5318), 0 },
                    { "44444444-4444-0000-0000-000000000008", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5345), "eeeeeeee-0000-0000-0000-000000000007", "Robert", null, new DateTime(2026, 9, 15, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Unchanged", true, false, false, true, "2026-09-03 10:14:02.558534", null, new DateTime(2026, 8, 16, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Mineral water for Robert", 3000m, "cccccccc-0000-0000-0000-000000000003", "Mineral Water 1L", 48m, "11111111-0000-0000-0000-000000000003", "Warehouse", 1, 144000L, "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5347), 0 },
                    { "44444444-4444-0000-0000-000000000009", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5366), "eeeeeeee-0000-0000-0000-000000000008", "Emily", null, new DateTime(2026, 9, 25, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Unchanged", true, false, false, true, "2026-09-03 10:14:02.558537", null, new DateTime(2026, 8, 26, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Instant noodles for Emily", 1500m, "cccccccc-0000-0000-0000-000000000006", "Instant Noodles", 30m, "11111111-0000-0000-0000-000000000003", "Warehouse", 1, 45000L, "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5368), 0 },
                    { "44444444-4444-0000-0000-000000000010", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5389), "eeeeeeee-0000-0000-0000-000000000009", "James", null, new DateTime(2026, 9, 30, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "Unchanged", true, false, false, true, "2026-09-03 10:14:02.558539", null, new DateTime(2026, 8, 31, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(8275), "USB cables for James", 1000m, "cccccccc-0000-0000-0000-000000000015", "USB Cable", 100m, "11111111-0000-0000-0000-000000000003", "Warehouse", 1, 100000L, "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 3, 10, 14, 2, 558, DateTimeKind.Utc).AddTicks(5391), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "dddddddd-0000-0000-0000-000000000001", 1m, "Added", "2026-09-03 10:14:02.541803", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", "Bottle", "aaaaaaaa-0000-0000-0000-000000000002", 0 },
                    { "dddddddd-0000-0000-0000-000000000002", 12m, "Added", "2026-09-03 10:14:02.541928", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000003", 24m, "Added", "2026-09-03 10:14:02.542085", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000004", 1m, "Added", "2026-09-03 10:14:02.542160", "cccccccc-0000-0000-0000-000000000002", "Pepsi 500ml", "Bottle", "aaaaaaaa-0000-0000-0000-000000000002", 0 },
                    { "dddddddd-0000-0000-0000-000000000005", 12m, "Added", "2026-09-03 10:14:02.542162", "cccccccc-0000-0000-0000-000000000002", "Pepsi 500ml", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000006", 24m, "Added", "2026-09-03 10:14:02.542163", "cccccccc-0000-0000-0000-000000000002", "Pepsi 500ml", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000007", 1m, "Added", "2026-09-03 10:14:02.542164", "cccccccc-0000-0000-0000-000000000003", "Mineral Water 1L", "Bottle", "aaaaaaaa-0000-0000-0000-000000000002", 0 },
                    { "dddddddd-0000-0000-0000-000000000008", 6m, "Added", "2026-09-03 10:14:02.542165", "cccccccc-0000-0000-0000-000000000003", "Mineral Water 1L", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000009", 12m, "Added", "2026-09-03 10:14:02.542165", "cccccccc-0000-0000-0000-000000000003", "Mineral Water 1L", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000010", 1m, "Added", "2026-09-03 10:14:02.542166", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", "Pack", "aaaaaaaa-0000-0000-0000-000000000003", 0 },
                    { "dddddddd-0000-0000-0000-000000000011", 12m, "Added", "2026-09-03 10:14:02.542167", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000012", 48m, "Added", "2026-09-03 10:14:02.542168", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000013", 1m, "Added", "2026-09-03 10:14:02.542169", "cccccccc-0000-0000-0000-000000000005", "Lay's Chips", "Pack", "aaaaaaaa-0000-0000-0000-000000000003", 0 },
                    { "dddddddd-0000-0000-0000-000000000014", 20m, "Added", "2026-09-03 10:14:02.542169", "cccccccc-0000-0000-0000-000000000005", "Lay's Chips", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000015", 60m, "Added", "2026-09-03 10:14:02.542171", "cccccccc-0000-0000-0000-000000000005", "Lay's Chips", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000016", 1m, "Added", "2026-09-03 10:14:02.542172", "cccccccc-0000-0000-0000-000000000006", "Instant Noodles", "Pack", "aaaaaaaa-0000-0000-0000-000000000003", 0 },
                    { "dddddddd-0000-0000-0000-000000000017", 24m, "Added", "2026-09-03 10:14:02.542173", "cccccccc-0000-0000-0000-000000000006", "Instant Noodles", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000018", 72m, "Added", "2026-09-03 10:14:02.542174", "cccccccc-0000-0000-0000-000000000006", "Instant Noodles", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000019", 1m, "Added", "2026-09-03 10:14:02.542175", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", "Piece", "aaaaaaaa-0000-0000-0000-000000000001", 0 },
                    { "dddddddd-0000-0000-0000-000000000020", 12m, "Added", "2026-09-03 10:14:02.542175", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", "Dozen", "aaaaaaaa-0000-0000-0000-000000000010", 0 },
                    { "dddddddd-0000-0000-0000-000000000021", 50m, "Added", "2026-09-03 10:14:02.542176", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000022", 1m, "Added", "2026-09-03 10:14:02.542177", "cccccccc-0000-0000-0000-000000000008", "Blue Pen", "Piece", "aaaaaaaa-0000-0000-0000-000000000001", 0 },
                    { "dddddddd-0000-0000-0000-000000000023", 12m, "Added", "2026-09-03 10:14:02.542178", "cccccccc-0000-0000-0000-000000000008", "Blue Pen", "Dozen", "aaaaaaaa-0000-0000-0000-000000000010", 0 },
                    { "dddddddd-0000-0000-0000-000000000024", 144m, "Added", "2026-09-03 10:14:02.542179", "cccccccc-0000-0000-0000-000000000008", "Blue Pen", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000025", 1m, "Added", "2026-09-03 10:14:02.542179", "cccccccc-0000-0000-0000-000000000009", "Pencil Set", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000026", 20m, "Added", "2026-09-03 10:14:02.542180", "cccccccc-0000-0000-0000-000000000009", "Pencil Set", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000027", 1m, "Added", "2026-09-03 10:14:02.542181", "cccccccc-0000-0000-0000-000000000010", "Cooking Oil 1L", "Bottle", "aaaaaaaa-0000-0000-0000-000000000002", 0 },
                    { "dddddddd-0000-0000-0000-000000000028", 12m, "Added", "2026-09-03 10:14:02.542182", "cccccccc-0000-0000-0000-000000000010", "Cooking Oil 1L", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000029", 24m, "Added", "2026-09-03 10:14:02.542183", "cccccccc-0000-0000-0000-000000000010", "Cooking Oil 1L", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000030", 1m, "Added", "2026-09-03 10:14:02.542184", "cccccccc-0000-0000-0000-000000000011", "Rice 1kg", "Kilogram", "aaaaaaaa-0000-0000-0000-000000000007", 0 },
                    { "dddddddd-0000-0000-0000-000000000031", 10m, "Added", "2026-09-03 10:14:02.542184", "cccccccc-0000-0000-0000-000000000011", "Rice 1kg", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000032", 25m, "Added", "2026-09-03 10:14:02.542185", "cccccccc-0000-0000-0000-000000000011", "Rice 1kg", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000033", 1m, "Added", "2026-09-03 10:14:02.542186", "cccccccc-0000-0000-0000-000000000012", "Sugar 1kg", "Kilogram", "aaaaaaaa-0000-0000-0000-000000000007", 0 },
                    { "dddddddd-0000-0000-0000-000000000034", 20m, "Added", "2026-09-03 10:14:02.542187", "cccccccc-0000-0000-0000-000000000012", "Sugar 1kg", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000035", 50m, "Added", "2026-09-03 10:14:02.542187", "cccccccc-0000-0000-0000-000000000012", "Sugar 1kg", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000036", 1m, "Added", "2026-09-03 10:14:02.542188", "cccccccc-0000-0000-0000-000000000013", "Shampoo 400ml", "Bottle", "aaaaaaaa-0000-0000-0000-000000000002", 0 },
                    { "dddddddd-0000-0000-0000-000000000037", 12m, "Added", "2026-09-03 10:14:02.542189", "cccccccc-0000-0000-0000-000000000013", "Shampoo 400ml", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000038", 24m, "Added", "2026-09-03 10:14:02.542190", "cccccccc-0000-0000-0000-000000000013", "Shampoo 400ml", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000039", 1m, "Added", "2026-09-03 10:14:02.542191", "cccccccc-0000-0000-0000-000000000014", "Toothpaste", "Piece", "aaaaaaaa-0000-0000-0000-000000000001", 0 },
                    { "dddddddd-0000-0000-0000-000000000040", 24m, "Added", "2026-09-03 10:14:02.542191", "cccccccc-0000-0000-0000-000000000014", "Toothpaste", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000041", 72m, "Added", "2026-09-03 10:14:02.542192", "cccccccc-0000-0000-0000-000000000014", "Toothpaste", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000042", 1m, "Added", "2026-09-03 10:14:02.542193", "cccccccc-0000-0000-0000-000000000015", "USB Cable", "Piece", "aaaaaaaa-0000-0000-0000-000000000001", 0 },
                    { "dddddddd-0000-0000-0000-000000000043", 50m, "Added", "2026-09-03 10:14:02.542194", "cccccccc-0000-0000-0000-000000000015", "USB Cable", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000044", 200m, "Added", "2026-09-03 10:14:02.542194", "cccccccc-0000-0000-0000-000000000015", "USB Cable", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 },
                    { "dddddddd-0000-0000-0000-000000000045", 1m, "Added", "2026-09-03 10:14:02.542195", "cccccccc-0000-0000-0000-000000000016", "Phone Charger", "Piece", "aaaaaaaa-0000-0000-0000-000000000001", 0 },
                    { "dddddddd-0000-0000-0000-000000000046", 20m, "Added", "2026-09-03 10:14:02.542196", "cccccccc-0000-0000-0000-000000000016", "Phone Charger", "Box", "aaaaaaaa-0000-0000-0000-000000000004", 0 },
                    { "dddddddd-0000-0000-0000-000000000047", 100m, "Added", "2026-09-03 10:14:02.542197", "cccccccc-0000-0000-0000-000000000016", "Phone Charger", "Carton", "aaaaaaaa-0000-0000-0000-000000000005", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "11111111-1111-0000-0000-000000000001", "CC-001", null, new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(2686), "Unchanged", new DateTime(2027, 3, 3, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), false, "2026-09-03 10:14:02.552317", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 8, 24, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), "Active", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(2960), 0 },
                    { "11111111-1111-0000-0000-000000000002", "CC-002", null, new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(5121), "Unchanged", new DateTime(2027, 4, 3, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), false, "2026-09-03 10:14:02.552618", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 8, 29, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), "Active", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(5757), 0 },
                    { "11111111-1111-0000-0000-000000000003", "OREO-101", null, new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(7673), "Unchanged", new DateTime(2026, 12, 3, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), false, "2026-09-03 10:14:02.552903", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 8, 19, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), "Active", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(8505), 0 },
                    { "11111111-1111-0000-0000-000000000004", "NB-009", null, new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(9504), "Unchanged", null, false, "2026-09-03 10:14:02.552951", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", 120000L, 200m, new DateTime(2026, 8, 14, 10, 14, 2, 551, DateTimeKind.Utc).AddTicks(1426), "Active", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 3, 10, 14, 2, 552, DateTimeKind.Utc).AddTicks(9510), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "DeletedAt", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "33333333-3333-0000-0000-000000000001", 140L, null, new DateTime(2026, 9, 3, 10, 14, 2, 543, DateTimeKind.Utc).AddTicks(8017), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.543825", null, "cccccccc-0000-0000-0000-000000000001", "dddddddd-0000-0000-0000-000000000001", 160L, null, new DateTime(2026, 9, 3, 10, 14, 2, 543, DateTimeKind.Utc).AddTicks(8163), 0 },
                    { "33333333-3333-0000-0000-000000000002", 1680L, null, new DateTime(2026, 9, 3, 10, 14, 2, 543, DateTimeKind.Utc).AddTicks(9297), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544061", null, "cccccccc-0000-0000-0000-000000000001", "dddddddd-0000-0000-0000-000000000002", 1920L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(80), 0 },
                    { "33333333-3333-0000-0000-000000000003", 3360L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(1826), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544307", null, "cccccccc-0000-0000-0000-000000000001", "dddddddd-0000-0000-0000-000000000003", 3840L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(2577), 0 },
                    { "33333333-3333-0000-0000-000000000004", 130L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3544), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544355", null, "cccccccc-0000-0000-0000-000000000002", "dddddddd-0000-0000-0000-000000000004", 150L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3550), 0 },
                    { "33333333-3333-0000-0000-000000000005", 1560L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3560), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544356", null, "cccccccc-0000-0000-0000-000000000002", "dddddddd-0000-0000-0000-000000000005", 1800L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3562), 0 },
                    { "33333333-3333-0000-0000-000000000006", 3120L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3575), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544358", null, "cccccccc-0000-0000-0000-000000000002", "dddddddd-0000-0000-0000-000000000006", 3600L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3578), 0 },
                    { "33333333-3333-0000-0000-000000000007", 70L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3585), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544358", null, "cccccccc-0000-0000-0000-000000000003", "dddddddd-0000-0000-0000-000000000007", 90L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3587), 0 },
                    { "33333333-3333-0000-0000-000000000008", 420L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3593), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544359", null, "cccccccc-0000-0000-0000-000000000003", "dddddddd-0000-0000-0000-000000000008", 540L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3595), 0 },
                    { "33333333-3333-0000-0000-000000000009", 840L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3602), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544360", null, "cccccccc-0000-0000-0000-000000000003", "dddddddd-0000-0000-0000-000000000009", 1080L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3605), 0 },
                    { "33333333-3333-0000-0000-000000000010", 230L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3611), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544361", null, "cccccccc-0000-0000-0000-000000000004", "dddddddd-0000-0000-0000-000000000010", 270L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3613), 0 },
                    { "33333333-3333-0000-0000-000000000011", 2760L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3619), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544362", null, "cccccccc-0000-0000-0000-000000000004", "dddddddd-0000-0000-0000-000000000011", 3240L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3621), 0 },
                    { "33333333-3333-0000-0000-000000000012", 11040L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3628), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544363", null, "cccccccc-0000-0000-0000-000000000004", "dddddddd-0000-0000-0000-000000000012", 12960L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3630), 0 },
                    { "33333333-3333-0000-0000-000000000013", 160L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3636), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544364", null, "cccccccc-0000-0000-0000-000000000005", "dddddddd-0000-0000-0000-000000000013", 190L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3639), 0 },
                    { "33333333-3333-0000-0000-000000000014", 3200L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3647), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544365", null, "cccccccc-0000-0000-0000-000000000005", "dddddddd-0000-0000-0000-000000000014", 3800L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3649), 0 },
                    { "33333333-3333-0000-0000-000000000015", 9600L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3656), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544366", null, "cccccccc-0000-0000-0000-000000000005", "dddddddd-0000-0000-0000-000000000015", 11400L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3658), 0 },
                    { "33333333-3333-0000-0000-000000000016", 110L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3664), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544366", null, "cccccccc-0000-0000-0000-000000000006", "dddddddd-0000-0000-0000-000000000016", 130L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3666), 0 },
                    { "33333333-3333-0000-0000-000000000017", 2640L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3696), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544370", null, "cccccccc-0000-0000-0000-000000000006", "dddddddd-0000-0000-0000-000000000017", 3120L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3698), 0 },
                    { "33333333-3333-0000-0000-000000000018", 7920L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3714), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544371", null, "cccccccc-0000-0000-0000-000000000006", "dddddddd-0000-0000-0000-000000000018", 9360L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3716), 0 },
                    { "33333333-3333-0000-0000-000000000019", 280L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3723), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544372", null, "cccccccc-0000-0000-0000-000000000007", "dddddddd-0000-0000-0000-000000000019", 320L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3725), 0 },
                    { "33333333-3333-0000-0000-000000000020", 3360L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3731), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544373", null, "cccccccc-0000-0000-0000-000000000007", "dddddddd-0000-0000-0000-000000000020", 3840L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3733), 0 },
                    { "33333333-3333-0000-0000-000000000021", 14000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3740), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544374", null, "cccccccc-0000-0000-0000-000000000007", "dddddddd-0000-0000-0000-000000000021", 16000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3742), 0 },
                    { "33333333-3333-0000-0000-000000000022", 45L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3750), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544375", null, "cccccccc-0000-0000-0000-000000000008", "dddddddd-0000-0000-0000-000000000022", 55L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3753), 0 },
                    { "33333333-3333-0000-0000-000000000023", 540L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3759), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544376", null, "cccccccc-0000-0000-0000-000000000008", "dddddddd-0000-0000-0000-000000000023", 660L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3761), 0 },
                    { "33333333-3333-0000-0000-000000000024", 6480L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3768), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544377", null, "cccccccc-0000-0000-0000-000000000008", "dddddddd-0000-0000-0000-000000000024", 7920L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3770), 0 },
                    { "33333333-3333-0000-0000-000000000025", 380L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3776), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544378", null, "cccccccc-0000-0000-0000-000000000009", "dddddddd-0000-0000-0000-000000000025", 420L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3778), 0 },
                    { "33333333-3333-0000-0000-000000000026", 7600L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3784), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544378", null, "cccccccc-0000-0000-0000-000000000009", "dddddddd-0000-0000-0000-000000000026", 8400L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3786), 0 },
                    { "33333333-3333-0000-0000-000000000027", 430L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3793), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544379", null, "cccccccc-0000-0000-0000-000000000010", "dddddddd-0000-0000-0000-000000000027", 470L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3795), 0 },
                    { "33333333-3333-0000-0000-000000000028", 5160L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3801), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544380", null, "cccccccc-0000-0000-0000-000000000010", "dddddddd-0000-0000-0000-000000000028", 5640L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3803), 0 },
                    { "33333333-3333-0000-0000-000000000029", 10320L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3809), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544381", null, "cccccccc-0000-0000-0000-000000000010", "dddddddd-0000-0000-0000-000000000029", 11280L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3811), 0 },
                    { "33333333-3333-0000-0000-000000000030", 260L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3820), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544382", null, "cccccccc-0000-0000-0000-000000000011", "dddddddd-0000-0000-0000-000000000030", 300L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3822), 0 },
                    { "33333333-3333-0000-0000-000000000031", 2600L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3828), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544383", null, "cccccccc-0000-0000-0000-000000000011", "dddddddd-0000-0000-0000-000000000031", 3000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3830), 0 },
                    { "33333333-3333-0000-0000-000000000032", 6500L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3836), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544384", null, "cccccccc-0000-0000-0000-000000000011", "dddddddd-0000-0000-0000-000000000032", 7500L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3838), 0 },
                    { "33333333-3333-0000-0000-000000000033", 180L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3844), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544384", null, "cccccccc-0000-0000-0000-000000000012", "dddddddd-0000-0000-0000-000000000033", 220L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3846), 0 },
                    { "33333333-3333-0000-0000-000000000034", 3600L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3852), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544385", null, "cccccccc-0000-0000-0000-000000000012", "dddddddd-0000-0000-0000-000000000034", 4400L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3854), 0 },
                    { "33333333-3333-0000-0000-000000000035", 9000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3860), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544386", null, "cccccccc-0000-0000-0000-000000000012", "dddddddd-0000-0000-0000-000000000035", 11000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3862), 0 },
                    { "33333333-3333-0000-0000-000000000036", 330L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3868), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544387", null, "cccccccc-0000-0000-0000-000000000013", "dddddddd-0000-0000-0000-000000000036", 370L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3876), 0 },
                    { "33333333-3333-0000-0000-000000000037", 3960L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3882), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544388", null, "cccccccc-0000-0000-0000-000000000013", "dddddddd-0000-0000-0000-000000000037", 4440L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3884), 0 },
                    { "33333333-3333-0000-0000-000000000038", 7920L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3892), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544389", null, "cccccccc-0000-0000-0000-000000000013", "dddddddd-0000-0000-0000-000000000038", 8880L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3894), 0 },
                    { "33333333-3333-0000-0000-000000000039", 160L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3900), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544390", null, "cccccccc-0000-0000-0000-000000000014", "dddddddd-0000-0000-0000-000000000039", 200L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3902), 0 },
                    { "33333333-3333-0000-0000-000000000040", 3840L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3908), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544391", null, "cccccccc-0000-0000-0000-000000000014", "dddddddd-0000-0000-0000-000000000040", 4800L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3910), 0 },
                    { "33333333-3333-0000-0000-000000000041", 11520L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3916), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544392", null, "cccccccc-0000-0000-0000-000000000014", "dddddddd-0000-0000-0000-000000000041", 14400L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3918), 0 },
                    { "33333333-3333-0000-0000-000000000042", 230L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3924), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544392", null, "cccccccc-0000-0000-0000-000000000015", "dddddddd-0000-0000-0000-000000000042", 270L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3926), 0 },
                    { "33333333-3333-0000-0000-000000000043", 11500L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3932), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544393", null, "cccccccc-0000-0000-0000-000000000015", "dddddddd-0000-0000-0000-000000000043", 13500L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3934), 0 },
                    { "33333333-3333-0000-0000-000000000044", 46000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3940), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544394", null, "cccccccc-0000-0000-0000-000000000015", "dddddddd-0000-0000-0000-000000000044", 54000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3942), 0 },
                    { "33333333-3333-0000-0000-000000000045", 750L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3948), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544395", null, "cccccccc-0000-0000-0000-000000000016", "dddddddd-0000-0000-0000-000000000045", 850L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3951), 0 },
                    { "33333333-3333-0000-0000-000000000046", 15000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3959), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544396", null, "cccccccc-0000-0000-0000-000000000016", "dddddddd-0000-0000-0000-000000000046", 17000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3961), 0 },
                    { "33333333-3333-0000-0000-000000000047", 75000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3967), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-09-03 10:14:02.544397", null, "cccccccc-0000-0000-0000-000000000016", "dddddddd-0000-0000-0000-000000000047", 85000L, null, new DateTime(2026, 9, 3, 10, 14, 2, 544, DateTimeKind.Utc).AddTicks(3968), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "22222222-2222-0000-0000-000000000001", null, new DateTime(2026, 9, 3, 10, 14, 2, 554, DateTimeKind.Utc).AddTicks(5184), "Unchanged", false, "2026-09-03 10:14:02.554536", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 100m, "Purchase Order #001", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000001", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 554, DateTimeKind.Utc).AddTicks(5286), 0 },
                    { "22222222-2222-0000-0000-000000000002", null, new DateTime(2026, 9, 3, 10, 14, 2, 554, DateTimeKind.Utc).AddTicks(8761), "Unchanged", false, "2026-09-03 10:14:02.554964", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 20m, "Sale #001", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000001", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 554, DateTimeKind.Utc).AddTicks(9296), 0 },
                    { "22222222-2222-0000-0000-000000000003", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(1374), "Unchanged", false, "2026-09-03 10:14:02.555255", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 80m, "Purchase Order #002", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000002", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(2061), 0 },
                    { "22222222-2222-0000-0000-000000000004", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3047), "Unchanged", false, "2026-09-03 10:14:02.555305", "cccccccc-0000-0000-0000-000000000001", "Coca Cola 500ml", 15m, "Sale #002", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000002", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000002", "Bottle", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3053), 0 },
                    { "22222222-2222-0000-0000-000000000005", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3077), "Unchanged", false, "2026-09-03 10:14:02.555308", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", 50m, "Purchase Order #003", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000003", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3080), 0 },
                    { "22222222-2222-0000-0000-000000000006", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3091), "Unchanged", false, "2026-09-03 10:14:02.555309", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", 10m, "Sale #003", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000003", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3093), 0 },
                    { "22222222-2222-0000-0000-000000000007", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3103), "Unchanged", false, "2026-09-03 10:14:02.555310", "cccccccc-0000-0000-0000-000000000004", "Oreo Biscuits", 2m, "Damage - Expired", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000003", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "aaaaaaaa-0000-0000-0000-000000000003", "Pack", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3105), 0 },
                    { "22222222-2222-0000-0000-000000000008", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3116), "Unchanged", false, "2026-09-03 10:14:02.555312", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", 200m, "Purchase Order #004", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000004", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3119), 0 },
                    { "22222222-2222-0000-0000-000000000009", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3128), "Unchanged", false, "2026-09-03 10:14:02.555313", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", 25m, "Sale #004", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000004", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3130), 0 },
                    { "22222222-2222-0000-0000-000000000010", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3141), "Unchanged", false, "2026-09-03 10:14:02.555314", "cccccccc-0000-0000-0000-000000000007", "A4 Notebook", 5m, "Sale #005", "11111111-0000-0000-0000-000000000001", "Main Store", "11111111-1111-0000-0000-000000000004", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "aaaaaaaa-0000-0000-0000-000000000001", "Piece", null, new DateTime(2026, 9, 3, 10, 14, 2, 555, DateTimeKind.Utc).AddTicks(3143), 0 }
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
