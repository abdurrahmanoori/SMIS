using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class IntalMig : Migration
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
                    { "1", "en", "Added", true, "2026-08-29 10:16:43.624468", "English", 0 },
                    { "2", "ps", "Added", true, "2026-08-29 10:16:43.624503", "Pashto", 0 },
                    { "3", "fa", "Added", true, "2026-08-29 10:16:43.624503", "Farsi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-08-29 10:16:43.625392", null, "Kabul", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-08-29 10:16:43.625407", null, "Herat", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-08-29 10:16:43.625407", null, "Kandahar", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2026-08-29 10:16:43.625407", null, "Balkh", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedAt", "Email", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 8, 29, 10, 16, 43, 628, DateTimeKind.Utc).AddTicks(8277), null, "main@store.local", "Unchanged", true, false, false, "2026-08-29 10:16:43.628845", "Main Store", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 8, 29, 10, 16, 43, 628, DateTimeKind.Utc).AddTicks(8376), 0 },
                    { "2", "Herat Center", null, new DateTime(2026, 8, 29, 10, 16, 43, 628, DateTimeKind.Utc).AddTicks(9624), null, "branch@store.local", "Unchanged", true, false, false, "2026-08-29 10:16:43.629054", "Branch Store", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 8, 29, 10, 16, 43, 629, DateTimeKind.Utc).AddTicks(239), 0 },
                    { "3", "Kandahar Center", null, new DateTime(2026, 8, 29, 10, 16, 43, 629, DateTimeKind.Utc).AddTicks(2256), null, "warehouse@store.local", "Unchanged", true, false, false, "2026-08-29 10:16:43.629409", "Warehouse", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 8, 29, 10, 16, 43, 629, DateTimeKind.Utc).AddTicks(3627), 0 }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "MessageCode", "Name", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", true, false, false, true, "2026-08-29 10:16:43.624755", null, "1001", "Kabul Center District", null, null, 0 },
                    { "2", null, null, null, "Unchanged", true, false, false, true, "2026-08-29 10:16:43.624788", null, "1002", "Kabul North District", null, null, 0 },
                    { "3", null, null, null, "Unchanged", true, false, false, true, "2026-08-29 10:16:43.624788", null, "1003", "Herat Center District", null, null, 0 },
                    { "4", null, null, null, "Unchanged", true, false, false, true, "2026-08-29 10:16:43.624788", null, "2001", "Kabul Province", null, null, 0 },
                    { "5", null, null, null, "Unchanged", true, false, false, true, "2026-08-29 10:16:43.624788", null, "2002", "Herat Province", null, null, 0 },
                    { "6", null, null, null, "Unchanged", true, false, false, true, "2026-08-29 10:16:43.624788", null, "3001", "Welcome Message", null, null, 0 },
                    { "7", null, null, null, "Unchanged", true, false, false, true, "2026-08-29 10:16:43.624789", null, "3002", "Error Message", null, null, 0 },
                    { "8", null, null, null, "Unchanged", true, false, false, true, "2026-08-29 10:16:43.624789", null, "3003", "Success Message", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntityState", "FirstName", "LanguageId", "LastModifiedUtc", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShopId", "ShopName", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { "1", 0, "70d88034-fd64-4649-8e3a-0eef76a3ef95", "superadmin@smis.com", true, "Unchanged", "Super", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "SUPERADMIN@SMIS.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEMqna0puA2W7GB4D5riBubfXEK30yZFMPltQM/HL8PfVodPPrFEYt5VIpQjIcShLMw==", "+855123456789", true, "4e2b54b1-b53b-4929-84d8-fbb9c9b6891b", "1", "Main Store", false, "superadmin", 0 },
                    { "10", 0, "ce1120a4-b320-479a-994b-b9711aa80c60", "radministration@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "RADMINISTRATION@SMIS.COM", "RADMINISTRATION", "AQAAAAIAAYagAAAAEMpfAbO3YXw2vSEmmuHiMuEfsvXLQEMUozffy6kaMukXOJXXuzEqriFo1tsSfPn2Lw==", "+855123456798", true, "c3c170d0-8aa5-4d86-ae75-2b1a4e71231a", "2", "Branch Store", false, "radministration", 0 },
                    { "11", 0, "450fc53e-dacd-4353-99cb-61e487cdc263", "rmanager@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "RMANAGER@SMIS.COM", "RMANAGER", "AQAAAAIAAYagAAAAEJlOBI8VaXuZUU5t4RXfnj4wYk8DURMEhDYaRyobgceei7imHsLQdwKDPIDBuyjzMQ==", "+855123456799", true, "8fc530ed-4789-4a1b-a052-28d920e700a4", "2", "Branch Store", false, "rmanager", 0 },
                    { "12", 0, "42e27227-f243-4f18-abba-867256b0c999", "rstaff@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "RSTAFF@SMIS.COM", "RSTAFF", "AQAAAAIAAYagAAAAEPZKBFdSyUtTSX7Jm1ODRhzwDnFMAVuM76aBIwGdi+56VyebpmlczQmCVwkabLlRAg==", "+855123456800", true, "fe242b02-c756-4d99-8f74-f17ae615ee92", "2", "Branch Store", false, "rstaff", 0 },
                    { "13", 0, "da0ebd6d-d84f-4583-8902-02d0da61a34b", "rviewer@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "RVIEWER@SMIS.COM", "RVIEWER", "AQAAAAIAAYagAAAAEDen6DFqxCQmZ9yj5c8bRfMpPtzV8OwH5wSJDuUeUOzXk4vKitpyJLlrB9Zxh1i4pA==", "+855123456801", true, "ca57168b-4536-4ea4-bf3c-eaf1f8eb88dc", "2", "Branch Store", false, "rviewer", 0 },
                    { "14", 0, "f36c4c7a-25ae-454f-a37d-7407dc830931", "reditor@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "REDITOR@SMIS.COM", "REDITOR", "AQAAAAIAAYagAAAAEHdjqb7AW2eTrYzDV9ksCKnTgDMEXxqdRDiX1c/7jLT1626+Kd1blilP7lGqWysRWA==", "+855123456802", true, "8d62c43d-3e30-452e-837a-a7f868f70cb2", "2", "Branch Store", false, "reditor", 0 },
                    { "15", 0, "cfbdb1ba-dbc1-476d-8bbc-b351e3438497", "ruser@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "User", false, null, "RUSER@SMIS.COM", "RUSER", "AQAAAAIAAYagAAAAEG78w1v6ld+Fhrls2T3nElDtcR4/XG9O+BN0rf9ikApzvU7RcjvYguG3ZuOHW4tYOw==", "+855123456803", true, "86029294-5d97-4a4b-bca6-af6b28ef3f46", "2", "Branch Store", false, "ruser", 0 },
                    { "2", 0, "c8715dd8-d020-4354-84d1-a9edaf949576", "wadmin@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "WADMIN@SMIS.COM", "WADMIN", "AQAAAAIAAYagAAAAEKecufQhYVtjk7fuKZTXjj7wJoEdnguICkS8LgLFOMkxgX4hV2aRoKFObImnWtrtBw==", "+855123456790", true, "bfb63990-4e31-45e9-b694-b288850569cc", "1", "Main Store", false, "wadmin", 0 },
                    { "3", 0, "2ada9264-abf0-4d5f-9334-461643f69d7d", "wadministration@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Administration", false, null, "WADMINISTRATION@SMIS.COM", "WADMINISTRATION", "AQAAAAIAAYagAAAAEA4o6pIGUSq1lHGi0o2CSSstGqJ7C7GxI95kqAXCO7QoPydffNZ0uIuODwSa6JKvvA==", "+855123456791", true, "02f39768-970e-4ff0-88fa-fe95ca8aa8af", "1", "Main Store", false, "wadministration", 0 },
                    { "4", 0, "d9528ce6-1b43-467d-ab67-58e25f8553e8", "wmanager@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Manager", false, null, "WMANAGER@SMIS.COM", "WMANAGER", "AQAAAAIAAYagAAAAEG0JRCZ7OA2jdlf89/TfEfAHXnFS+q3ThVi5ItuyzeqvF3Ly8yll8q+eAJAOeY02Qw==", "+855123456792", true, "809fee13-1eb5-4569-8b02-065b0261cdd3", "1", "Main Store", false, "wmanager", 0 },
                    { "5", 0, "614f3f15-88dd-4b65-88a0-64ecd739d5f5", "wstaff@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Staff", false, null, "WSTAFF@SMIS.COM", "WSTAFF", "AQAAAAIAAYagAAAAEIMimyuUKd1E4svTV6pzmccvQrCqlXZPLQhSjjCnn5rS/9P0iiQ7fBLNtxDNZX78Ww==", "+855123456793", true, "b050de35-d9f0-4ad9-8c4c-5634977273be", "1", "Main Store", false, "wstaff", 0 },
                    { "6", 0, "cbd2ce78-d40a-432c-a89b-e67e382e8aef", "wviewer@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Viewer", false, null, "WVIEWER@SMIS.COM", "WVIEWER", "AQAAAAIAAYagAAAAEMXYAL5F2/U4gprnYJ3SFKmYwlXjM2X/Xs0Wko436iEOVMwzMO59G3C/Xow+8/r48A==", "+8512345634366", true, "da5b02b5-942e-40db-a1b8-bccdad4ffca4", "1", "Main Store", false, "wviewer", 0 },
                    { "7", 0, "d602023f-7abe-49b7-81ec-b41bc503492a", "weditor@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "Editor", false, null, "WEDITOR@SMIS.COM", "WEDITOR", "AQAAAAIAAYagAAAAEAQskVa8Q8y0UTuy55kSFeXTX5iL2BRPbMGwYLz7RYycFhwLjy5vMNQU4s3hcrbxnw==", "+855123456795", true, "6150f35f-cbe7-4edb-8600-99b944287ea4", "1", "Main Store", false, "weditor", 0 },
                    { "8", 0, "2da5acfc-3673-4de8-90af-ccdd2f1fe9f7", "wuser@smis.com", true, "Unchanged", "Wholesale", "1", "0001-01-01 00:00:00.000000", "User", false, null, "WUSER@SMIS.COM", "WUSER", "AQAAAAIAAYagAAAAECu2zMQVQDtrb8gHBCICZUJrqIZDuSAt4k7i4K5ahoFQ7/Kp42pbhEy/FHEpu5uMUQ==", "+855123456796", true, "3d45f96a-da00-4bc0-8a35-477bc26dee3e", "1", "Main Store", false, "wuser", 0 },
                    { "9", 0, "1d8342d7-cbbe-43bf-8468-baa5cf27b210", "radmin@smis.com", true, "Unchanged", "Retail", "1", "0001-01-01 00:00:00.000000", "Admin", false, null, "RADMIN@SMIS.COM", "RADMIN", "AQAAAAIAAYagAAAAEMpi/zum6pFYySCNB5rlR12k9UVadWmSQ0xZDAnnoTNIYEexvFrXll/XItnosLA4LA==", "+855123456797", true, "52630d74-c970-4132-b09a-95ae322672cf", "2", "Branch Store", false, "radmin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ClientCreatedBy", "ClientCreatedDate", "ClientModifiedBy", "ClientModifiedDate", "Code", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "IsActive", "IsDeleted", "IsPublic", "LastModifiedUtc", "Name", "ShopId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, null, "BEV", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5744), null, "Drinks and beverages", "Unchanged", true, false, false, "2026-08-29 10:16:43.632574", "Beverages", "1", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5748), 0 },
                    { "2", null, null, null, null, "FOOD", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5761), null, "Edible products and snacks", "Unchanged", true, false, false, "2026-08-29 10:16:43.632576", "Food Items", "1", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5761), 0 },
                    { "3", null, null, null, null, "STAT", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5768), null, "Office and school supplies", "Unchanged", true, false, false, "2026-08-29 10:16:43.632576", "Stationery", "2", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5768), 0 },
                    { "4", null, null, null, null, "GROC", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5771), null, "Daily household items", "Unchanged", true, false, false, "2026-08-29 10:16:43.632577", "Grocery", "2", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5771), 0 },
                    { "5", null, null, null, null, "CARE", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5773), null, "Health and hygiene products", "Unchanged", true, false, false, "2026-08-29 10:16:43.632577", "Personal Care", "3", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5774), 0 },
                    { "6", null, null, null, null, "ELEC", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5776), null, "Electronic devices and accessories", "Unchanged", true, false, false, "2026-08-29 10:16:43.632577", "Electronics", "3", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(5776), 0 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "2026-08-29 10:16:43.625616", null, "Kabul Center", "1", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2026-08-29 10:16:43.625635", null, "Kabul North", "2", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "2026-08-29 10:16:43.625636", null, "Herat Center", "3", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "EntityState", "IsDefault", "LanguageCode", "LanguageId", "LastModifiedUtc", "Name", "ProvinceId", "Version" },
                values: new object[,]
                {
                    { "1", "Added", true, "en", "1", "2026-08-29 10:16:43.625449", "Kabul", "1", 0 },
                    { "10", "Added", true, "en", "1", "2026-08-29 10:16:43.625490", "Balkh", "4", 0 },
                    { "11", "Added", false, "ps", "2", "2026-08-29 10:16:43.625490", "بلخ", "4", 0 },
                    { "12", "Added", false, "fa", "3", "2026-08-29 10:16:43.625490", "بلخ", "4", 0 },
                    { "2", "Added", false, "ps", "2", "2026-08-29 10:16:43.625488", "کابل", "1", 0 },
                    { "3", "Added", false, "fa", "3", "2026-08-29 10:16:43.625489", "کابل", "1", 0 },
                    { "4", "Added", true, "en", "1", "2026-08-29 10:16:43.625489", "Herat", "2", 0 },
                    { "5", "Added", false, "ps", "2", "2026-08-29 10:16:43.625489", "هرات", "2", 0 },
                    { "6", "Added", false, "fa", "3", "2026-08-29 10:16:43.625489", "هرات", "2", 0 },
                    { "7", "Added", true, "en", "1", "2026-08-29 10:16:43.625490", "Kandahar", "3", 0 },
                    { "8", "Added", false, "ps", "2", "2026-08-29 10:16:43.625490", "کندهار", "3", 0 },
                    { "9", "Added", false, "fa", "3", "2026-08-29 10:16:43.625490", "قندهار", "3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedAt", "EntityState", "IsDeleted", "IsPublic", "IsSyncedToServer", "LanguageNo", "LastModifiedUtc", "LastSyncedAt", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, null, null, "Unchanged", false, false, true, "1", "2026-08-29 10:16:43.625034", null, "Kabul Center District", "1", null, null, 0 },
                    { "10", null, null, null, "Unchanged", false, false, true, "2", "2026-08-29 10:16:43.625068", null, "ولایت هرات", "5", null, null, 0 },
                    { "11", null, null, null, "Unchanged", false, false, true, "1", "2026-08-29 10:16:43.625071", null, "Welcome Message", "6", null, null, 0 },
                    { "12", null, null, null, "Unchanged", false, false, true, "2", "2026-08-29 10:16:43.625071", null, "پیام خوش آمدید", "6", null, null, 0 },
                    { "2", null, null, null, "Unchanged", false, false, true, "2", "2026-08-29 10:16:43.625065", null, "منطقه مرکز کابل", "1", null, null, 0 },
                    { "3", null, null, null, "Unchanged", false, false, true, "1", "2026-08-29 10:16:43.625065", null, "Kabul North District", "2", null, null, 0 },
                    { "4", null, null, null, "Unchanged", false, false, true, "2", "2026-08-29 10:16:43.625065", null, "منطقه شمال کابل", "2", null, null, 0 },
                    { "5", null, null, null, "Unchanged", false, false, true, "1", "2026-08-29 10:16:43.625065", null, "Herat Center District", "3", null, null, 0 },
                    { "6", null, null, null, "Unchanged", false, false, true, "2", "2026-08-29 10:16:43.625067", null, "منطقه مرکز هرات", "3", null, null, 0 },
                    { "7", null, null, null, "Unchanged", false, false, true, "1", "2026-08-29 10:16:43.625068", null, "Kabul Province", "4", null, null, 0 },
                    { "8", null, null, null, "Unchanged", false, false, true, "2", "2026-08-29 10:16:43.625068", null, "ولایت کابل", "4", null, null, 0 },
                    { "9", null, null, null, "Unchanged", false, false, true, "1", "2026-08-29 10:16:43.625068", null, "Herat Province", "5", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "EntityState", "LastModifiedUtc", "Name", "ShopId", "Symbol", "Version" },
                values: new object[,]
                {
                    { "1", "Individual items", "Added", "2026-08-29 10:16:43.626252", "Piece", "1", "pcs", 0 },
                    { "10", "12 pieces", "Added", "2026-08-29 10:16:43.626522", "Dozen", "1", "dz", 0 },
                    { "2", "Liquid containers", "Added", "2026-08-29 10:16:43.626375", "Bottle", "1", "btl", 0 },
                    { "3", "Small packages", "Added", "2026-08-29 10:16:43.626466", "Pack", "1", "pk", 0 },
                    { "4", "Medium containers", "Added", "2026-08-29 10:16:43.626517", "Box", "1", "box", 0 },
                    { "5", "Large containers", "Added", "2026-08-29 10:16:43.626518", "Carton", "1", "ctn", 0 },
                    { "6", "Volume measurement", "Added", "2026-08-29 10:16:43.626520", "Liter", "1", "L", 0 },
                    { "7", "Weight measurement", "Added", "2026-08-29 10:16:43.626520", "Kilogram", "1", "kg", 0 },
                    { "8", "Small weight measurement", "Added", "2026-08-29 10:16:43.626521", "Gram", "1", "g", 0 },
                    { "9", "Small volume measurement", "Added", "2026-08-29 10:16:43.626521", "Milliliter", "1", "ml", 0 }
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
                    { "1", "123 Main St, Phnom Penh", null, new DateTime(2026, 8, 29, 10, 16, 43, 633, DateTimeKind.Utc).AddTicks(9188), "Individual", null, null, "1", "john.doe@email.com", "Unchanged", "Smith", "John", true, false, false, true, "2026-08-29 10:16:43.633936", "Doe", null, "+855123456789", "1", "1", "Main Store", "TAX001", null, new DateTime(2026, 8, 29, 10, 16, 43, 633, DateTimeKind.Utc).AddTicks(9301), 0 },
                    { "10", "741 Ash Dr, Battambang", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3073), "Individual", null, null, "1", "maria.rodriguez@email.com", "Unchanged", "Sanchez", "Maria", true, false, false, true, "2026-08-29 10:16:43.634307", "Rodriguez", null, "+855888987654", "4", "3", "Warehouse", "TAX006", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3074), 0 },
                    { "2", "456 Oak Ave, Phnom Penh", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(510), "Individual", null, null, "2", "jane.smith@email.com", "Unchanged", "Johnson", "Jane", true, false, false, true, "2026-08-29 10:16:43.634106", "Smith", null, "+855987654321", "1", "1", "Main Store", "TAX002", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(852), 0 },
                    { "3", "789 Pine Rd, Phnom Penh", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(1938), "Enterprise", null, null, "3", "michael.brown@email.com", "Unchanged", "Davis", "Michael", true, false, false, true, "2026-08-29 10:16:43.634269", "Brown", null, "+855555123456", "2", "1", "Main Store", null, null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(2391), 0 },
                    { "4", "321 Elm St, Siem Reap", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3002), "Individual", null, null, "1", "sarah.wilson@email.com", "Unchanged", "Miller", "Sarah", true, false, false, true, "2026-08-29 10:16:43.634300", "Wilson", null, "+855444987654", "3", "2", "Branch Store", "TAX003", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3006), 0 },
                    { "5", "654 Maple Dr, Siem Reap", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3017), "Individual", null, null, "2", "david.taylor@email.com", "Unchanged", "Anderson", "David", true, false, false, true, "2026-08-29 10:16:43.634302", "Taylor", null, "+855333456789", "3", "2", "Branch Store", null, null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3019), 0 },
                    { "6", "987 Cedar Ln, Siem Reap", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3029), "Enterprise", null, null, "3", "lisa.garcia@email.com", "Unchanged", "Martinez", "Lisa", true, false, false, true, "2026-08-29 10:16:43.634303", "Garcia", null, "+855222123456", "4", "2", "Branch Store", "TAX004", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3031), 0 },
                    { "7", "147 Birch St, Battambang", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3040), "Individual", null, null, "1", "robert.martinez@email.com", "Unchanged", "Rodriguez", "Robert", true, false, false, true, "2026-08-29 10:16:43.634304", "Martinez", null, "+855111987654", "1", "3", "Warehouse", null, null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3042), 0 },
                    { "8", "258 Spruce Ave, Battambang", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3051), "Individual", null, null, "2", "emily.lopez@email.com", "Unchanged", "Hernandez", "Emily", true, false, false, true, "2026-08-29 10:16:43.634305", "Lopez", null, "+855666456789", "2", "3", "Warehouse", "TAX005", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3053), 0 },
                    { "9", "369 Fir Rd, Battambang", null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3061), "Enterprise", null, null, "3", "james.gonzalez@email.com", "Unchanged", "Perez", "James", true, false, false, true, "2026-08-29 10:16:43.634306", "Gonzalez", null, "+855777123456", "3", "3", "Warehouse", null, null, new DateTime(2026, 8, 29, 10, 16, 43, 634, DateTimeKind.Utc).AddTicks(3063), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "BaseUnitName", "CategoryId", "CategoryName", "CreatedBy", "CreatedDate", "DeletedAt", "Description", "EntityState", "ImageUrl", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "Name", "SKU", "ShopId", "ShopName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "1234567890001", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(5577), null, "Classic cola drink", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631571", null, "Coca Cola 500ml", "COKE-500ML-001", "1", "Main Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(5662), 0 },
                    { "10", "1234567890010", "2", "Bottle", "4", "Grocery", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9931), null, "Sunflower cooking oil", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631993", null, "Cooking Oil 1L", "OIL-1L-010", "1", "Main Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9932), 0 },
                    { "11", "1234567890011", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9943), null, "Basmati rice", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631994", null, "Rice 1kg", "RICE-1KG-011", "2", "Branch Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9944), 0 },
                    { "12", "1234567890012", "7", "Kilogram", "4", "Grocery", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9952), null, "White granulated sugar", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631996", null, "Sugar 1kg", "SUGAR-1KG-012", "3", "Warehouse", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9953), 0 },
                    { "13", "1234567890013", "2", "Bottle", "5", "Personal Care", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9973), null, "Hair care shampoo", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631997", null, "Shampoo 400ml", "SHAMP-400ML-013", "1", "Main Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9975), 0 },
                    { "14", "1234567890014", "1", "Piece", "5", "Personal Care", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9983), null, "Dental care paste", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631998", null, "Toothpaste", "TOOTH-PASTE-014", "2", "Branch Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9984), 0 },
                    { "15", "1234567890015", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9992), null, "Type-C charging cable", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631999", null, "USB Cable", "USB-CABLE-015", "1", "Main Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9993), 0 },
                    { "16", "1234567890016", "1", "Piece", "6", "Electronics", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(1), null, "Fast charging adapter", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.632000", null, "Phone Charger", "CHARGER-016", "3", "Warehouse", null, new DateTime(2026, 8, 29, 10, 16, 43, 632, DateTimeKind.Utc).AddTicks(3), 0 },
                    { "2", "1234567890002", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(7036), null, "Cola soft drink", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631760", null, "Pepsi 500ml", "PEPSI-500ML-002", "1", "Main Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(7341), 0 },
                    { "3", "1234567890003", "2", "Bottle", "1", "Beverages", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(8717), null, "Pure drinking water", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631954", null, "Mineral Water 1L", "WATER-1L-003", "2", "Branch Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9144), 0 },
                    { "4", "1234567890004", "3", "Pack", "2", "Food", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9857), null, "Chocolate sandwich cookies", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631986", null, "Oreo Biscuits", "OREO-PACK-004", "1", "Main Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9862), 0 },
                    { "5", "1234567890005", "3", "Pack", "2", "Food", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9873), null, "Potato chips", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631987", null, "Lay's Chips", "LAYS-PACK-005", "2", "Branch Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9874), 0 },
                    { "6", "1234567890006", "3", "Pack", "2", "Food", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9882), null, "Quick meal noodles", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631988", null, "Instant Noodles", "NOODLE-PACK-006", "3", "Warehouse", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9884), 0 },
                    { "7", "1234567890007", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9899), null, "200 pages ruled notebook", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631990", null, "A4 Notebook", "NOTE-A4-007", "1", "Main Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9900), 0 },
                    { "8", "1234567890008", "1", "Piece", "3", "Stationery", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9908), null, "Ballpoint pen", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631991", null, "Blue Pen", "PEN-BLUE-008", "2", "Branch Store", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9910), 0 },
                    { "9", "1234567890009", "4", "Box", "3", "Stationery", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9918), null, "12 pencils per box", "Unchanged", null, true, false, false, true, "2026-08-29 10:16:43.631992", null, "Pencil Set", "PENCIL-BOX-009", "3", "Warehouse", null, new DateTime(2026, 8, 29, 10, 16, 43, 631, DateTimeKind.Utc).AddTicks(9922), 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopOwner",
                columns: new[] { "Id", "Address", "ApplicationUserId", "CreatedBy", "CreatedDate", "DeletedAt", "DistrictId", "Email", "EndDate", "EntityState", "FirstName", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastName", "LastSyncedAt", "NationalIdCardNumber", "OwnershipPercentage", "PhoneNumber", "ProvinceId", "ShopId", "ShopName", "StartDate", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "123 Main St", "1", null, new DateTime(2026, 8, 29, 10, 16, 43, 6, DateTimeKind.Utc).AddTicks(9612), null, null, "john.doe@example.com", null, "Unchanged", "John", true, false, false, true, "2026-08-29 10:16:43.006976", "Doe", null, "123456789", 100.0m, "+1234567890", null, "1", "Main Store", new DateTime(2026, 8, 29, 14, 46, 42, 999, DateTimeKind.Local).AddTicks(4844), null, new DateTime(2026, 8, 29, 10, 16, 43, 6, DateTimeKind.Utc).AddTicks(9705), 0 },
                    { "2", "456 Oak Ave", "2", null, new DateTime(2026, 8, 29, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(806), null, null, "jane.smith@example.com", null, "Unchanged", "Jane", true, false, false, true, "2026-08-29 10:16:43.007132", "Smith", null, "987654321", 75.0m, "+0987654321", null, "2", "Branch Store", new DateTime(2026, 8, 29, 14, 46, 43, 6, DateTimeKind.Local).AddTicks(9778), null, new DateTime(2026, 8, 29, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(1123), 0 },
                    { "3", "789 Pine Rd", "3", null, new DateTime(2026, 8, 29, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(2323), null, null, "bob.johnson@example.com", null, "Unchanged", "Bob", true, false, false, true, "2026-08-29 10:16:43.007310", "Johnson", null, "555666777", 50.0m, "+1555666777", null, "3", "Warehouse", new DateTime(2026, 8, 29, 14, 46, 43, 7, DateTimeKind.Local).AddTicks(1582), null, new DateTime(2026, 8, 29, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(2780), 0 }
                });

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "CustomerName", "DeletedAt", "DueDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "Notes", "PriceAtLoanTime", "ProductId", "ProductName", "Quantity", "ShopId", "ShopName", "Status", "TotalAmount", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 8, 29, 10, 16, 43, 8, DateTimeKind.Utc).AddTicks(6365), "1", "John", null, new DateTime(2026, 9, 28, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Unchanged", true, false, false, true, "2026-08-29 10:16:43.008648", null, new DateTime(2026, 7, 30, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Coca Cola loan for John", 5000m, "1", "Coca Cola 500ml", 10m, "1", "Main Store", 1, 50000L, "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 43, 8, DateTimeKind.Utc).AddTicks(6431), 0 },
                    { "10", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1189), "9", "James", null, new DateTime(2026, 9, 25, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Unchanged", true, false, false, true, "2026-08-29 10:16:43.009119", null, new DateTime(2026, 8, 26, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "USB cables for James", 1000m, "15", "USB Cable", 100m, "3", "Warehouse", 1, 100000L, "1", "Piece", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1190), 0 },
                    { "2", null, new DateTime(2026, 8, 29, 10, 16, 43, 8, DateTimeKind.Utc).AddTicks(8176), "2", "Jane", null, new DateTime(2026, 9, 13, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Unchanged", true, false, false, true, "2026-08-29 10:16:43.008863", null, new DateTime(2026, 8, 14, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Oreo biscuits for Jane", 4000m, "4", "Oreo Biscuits", 5m, "1", "Main Store", 1, 20000L, "3", "Pack", null, new DateTime(2026, 8, 29, 10, 16, 43, 8, DateTimeKind.Utc).AddTicks(8441), 0 },
                    { "3", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(277), "3", "Michael", null, new DateTime(2026, 9, 18, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Unchanged", true, false, false, true, "2026-08-29 10:16:43.009084", null, new DateTime(2026, 8, 19, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Notebooks for Michael", 3000m, "7", "A4 Notebook", 20m, "1", "Main Store", 1, 60000L, "1", "Piece", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(601), 0 },
                    { "4", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1092), "1", "John", null, new DateTime(2026, 10, 13, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Unchanged", true, false, false, true, "2026-08-29 10:16:43.009109", null, new DateTime(2026, 8, 24, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Cooking oil bulk order", 8000m, "10", "Cooking Oil 1L", 15m, "1", "Main Store", 1, 120000L, "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1096), 0 },
                    { "5", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1110), "4", "Sarah", null, new DateTime(2026, 9, 8, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Unchanged", true, false, false, true, "2026-08-29 10:16:43.009111", null, new DateTime(2026, 8, 9, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Pepsi for Sarah", 4500m, "2", "Pepsi 500ml", 24m, "2", "Branch Store", 1, 108000L, "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1111), 0 },
                    { "6", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1123), "5", "David", null, new DateTime(2026, 9, 16, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Unchanged", true, false, false, true, "2026-08-29 10:16:43.009112", null, new DateTime(2026, 8, 17, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Blue pens for David", 500m, "8", "Blue Pen", 50m, "2", "Branch Store", 1, 25000L, "1", "Piece", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1125), 0 },
                    { "7", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1137), "6", "Lisa", null, null, "Unchanged", true, false, false, true, "2026-08-29 10:16:43.009113", null, new DateTime(2026, 8, 4, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Rice bulk purchase", 2000m, "11", "Rice 1kg", 100m, "2", "Branch Store", 1, 200000L, "7", "Kilogram", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1138), 0 },
                    { "8", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1150), "7", "Robert", null, new DateTime(2026, 9, 10, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Unchanged", true, false, false, true, "2026-08-29 10:16:43.009116", null, new DateTime(2026, 8, 11, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Mineral water for Robert", 3000m, "3", "Mineral Water 1L", 48m, "3", "Warehouse", 1, 144000L, "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1164), 0 },
                    { "9", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1176), "8", "Emily", null, new DateTime(2026, 9, 20, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Unchanged", true, false, false, true, "2026-08-29 10:16:43.009117", null, new DateTime(2026, 8, 21, 10, 16, 43, 7, DateTimeKind.Utc).AddTicks(7068), "Instant noodles for Emily", 1500m, "6", "Instant Noodles", 30m, "3", "Warehouse", 1, 45000L, "3", "Pack", null, new DateTime(2026, 8, 29, 10, 16, 43, 9, DateTimeKind.Utc).AddTicks(1178), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "EntityState", "LastModifiedUtc", "ProductId", "ProductName", "UnitName", "UnitOfMeasureId", "Version" },
                values: new object[,]
                {
                    { "1", 1m, "Added", "2026-08-29 10:16:42.993219", "1", "Coca Cola 500ml", "Bottle", "2", 0 },
                    { "10", 1m, "Added", "2026-08-29 10:16:42.993605", "4", "Oreo Biscuits", "Pack", "3", 0 },
                    { "11", 12m, "Added", "2026-08-29 10:16:42.993605", "4", "Oreo Biscuits", "Box", "4", 0 },
                    { "12", 48m, "Added", "2026-08-29 10:16:42.993659", "4", "Oreo Biscuits", "Carton", "5", 0 },
                    { "13", 1m, "Added", "2026-08-29 10:16:42.993665", "5", "Lay's Chips", "Pack", "3", 0 },
                    { "14", 20m, "Added", "2026-08-29 10:16:42.993672", "5", "Lay's Chips", "Box", "4", 0 },
                    { "15", 60m, "Added", "2026-08-29 10:16:42.993674", "5", "Lay's Chips", "Carton", "5", 0 },
                    { "16", 1m, "Added", "2026-08-29 10:16:42.993676", "6", "Instant Noodles", "Pack", "3", 0 },
                    { "17", 24m, "Added", "2026-08-29 10:16:42.993678", "6", "Instant Noodles", "Box", "4", 0 },
                    { "18", 72m, "Added", "2026-08-29 10:16:42.993679", "6", "Instant Noodles", "Carton", "5", 0 },
                    { "19", 1m, "Added", "2026-08-29 10:16:42.993681", "7", "A4 Notebook", "Piece", "1", 0 },
                    { "2", 12m, "Added", "2026-08-29 10:16:42.993383", "1", "Coca Cola 500ml", "Box", "4", 0 },
                    { "20", 12m, "Added", "2026-08-29 10:16:42.993682", "7", "A4 Notebook", "Dozen", "10", 0 },
                    { "21", 50m, "Added", "2026-08-29 10:16:42.993684", "7", "A4 Notebook", "Box", "4", 0 },
                    { "22", 1m, "Added", "2026-08-29 10:16:42.993685", "8", "Blue Pen", "Piece", "1", 0 },
                    { "23", 12m, "Added", "2026-08-29 10:16:42.993686", "8", "Blue Pen", "Dozen", "10", 0 },
                    { "24", 144m, "Added", "2026-08-29 10:16:42.993687", "8", "Blue Pen", "Box", "4", 0 },
                    { "25", 1m, "Added", "2026-08-29 10:16:42.993689", "9", "Pencil Set", "Box", "4", 0 },
                    { "26", 20m, "Added", "2026-08-29 10:16:42.993690", "9", "Pencil Set", "Carton", "5", 0 },
                    { "27", 1m, "Added", "2026-08-29 10:16:42.993692", "10", "Cooking Oil 1L", "Bottle", "2", 0 },
                    { "28", 12m, "Added", "2026-08-29 10:16:42.993693", "10", "Cooking Oil 1L", "Box", "4", 0 },
                    { "29", 24m, "Added", "2026-08-29 10:16:42.993695", "10", "Cooking Oil 1L", "Carton", "5", 0 },
                    { "3", 24m, "Added", "2026-08-29 10:16:42.993508", "1", "Coca Cola 500ml", "Carton", "5", 0 },
                    { "30", 1m, "Added", "2026-08-29 10:16:42.993696", "11", "Rice 1kg", "Kilogram", "7", 0 },
                    { "31", 10m, "Added", "2026-08-29 10:16:42.993698", "11", "Rice 1kg", "Box", "4", 0 },
                    { "32", 25m, "Added", "2026-08-29 10:16:42.993715", "11", "Rice 1kg", "Carton", "5", 0 },
                    { "33", 1m, "Added", "2026-08-29 10:16:42.993718", "12", "Sugar 1kg", "Kilogram", "7", 0 },
                    { "34", 20m, "Added", "2026-08-29 10:16:42.993719", "12", "Sugar 1kg", "Box", "4", 0 },
                    { "35", 50m, "Added", "2026-08-29 10:16:42.993720", "12", "Sugar 1kg", "Carton", "5", 0 },
                    { "36", 1m, "Added", "2026-08-29 10:16:42.993720", "13", "Shampoo 400ml", "Bottle", "2", 0 },
                    { "37", 12m, "Added", "2026-08-29 10:16:42.993721", "13", "Shampoo 400ml", "Box", "4", 0 },
                    { "38", 24m, "Added", "2026-08-29 10:16:42.993721", "13", "Shampoo 400ml", "Carton", "5", 0 },
                    { "39", 1m, "Added", "2026-08-29 10:16:42.993722", "14", "Toothpaste", "Piece", "1", 0 },
                    { "4", 1m, "Added", "2026-08-29 10:16:42.993587", "2", "Pepsi 500ml", "Bottle", "2", 0 },
                    { "40", 24m, "Added", "2026-08-29 10:16:42.993722", "14", "Toothpaste", "Box", "4", 0 },
                    { "41", 72m, "Added", "2026-08-29 10:16:42.993723", "14", "Toothpaste", "Carton", "5", 0 },
                    { "42", 1m, "Added", "2026-08-29 10:16:42.993724", "15", "USB Cable", "Piece", "1", 0 },
                    { "43", 50m, "Added", "2026-08-29 10:16:42.993724", "15", "USB Cable", "Box", "4", 0 },
                    { "44", 200m, "Added", "2026-08-29 10:16:42.993726", "15", "USB Cable", "Carton", "5", 0 },
                    { "45", 1m, "Added", "2026-08-29 10:16:42.993726", "16", "Phone Charger", "Piece", "1", 0 },
                    { "46", 20m, "Added", "2026-08-29 10:16:42.993727", "16", "Phone Charger", "Box", "4", 0 },
                    { "47", 100m, "Added", "2026-08-29 10:16:42.993727", "16", "Phone Charger", "Carton", "5", 0 },
                    { "5", 12m, "Added", "2026-08-29 10:16:42.993588", "2", "Pepsi 500ml", "Box", "4", 0 },
                    { "6", 24m, "Added", "2026-08-29 10:16:42.993589", "2", "Pepsi 500ml", "Carton", "5", 0 },
                    { "7", 1m, "Added", "2026-08-29 10:16:42.993590", "3", "Mineral Water 1L", "Bottle", "2", 0 },
                    { "8", 6m, "Added", "2026-08-29 10:16:42.993590", "3", "Mineral Water 1L", "Box", "4", 0 },
                    { "9", 12m, "Added", "2026-08-29 10:16:42.993592", "3", "Mineral Water 1L", "Carton", "5", 0 }
                });

            migrationBuilder.InsertData(
                table: "StockBatch",
                columns: new[] { "Id", "BatchNumber", "CreatedBy", "CreatedDate", "EntityState", "ExpirationDate", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "PurchasePrice", "Quantity", "ReceivedDate", "Status", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", "CC-001", null, new DateTime(2026, 8, 29, 10, 16, 42, 996, DateTimeKind.Utc).AddTicks(8663), "Unchanged", new DateTime(2027, 2, 28, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(9668), false, "2026-08-29 10:16:42.996925", "1", "Coca Cola 500ml", 40000L, 100m, new DateTime(2026, 8, 19, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(9668), "Active", "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 42, 996, DateTimeKind.Utc).AddTicks(9013), 0 },
                    { "2", "CC-002", null, new DateTime(2026, 8, 29, 10, 16, 42, 997, DateTimeKind.Utc).AddTicks(1007), "Unchanged", new DateTime(2027, 3, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(9668), false, "2026-08-29 10:16:42.997155", "1", "Coca Cola 500ml", 42000L, 80m, new DateTime(2026, 8, 24, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(9668), "Active", "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 42, 997, DateTimeKind.Utc).AddTicks(1354), 0 },
                    { "3", "OREO-101", null, new DateTime(2026, 8, 29, 10, 16, 42, 997, DateTimeKind.Utc).AddTicks(2818), "Unchanged", new DateTime(2026, 11, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(9668), false, "2026-08-29 10:16:42.997369", "4", "Oreo Biscuits", 25000L, 50m, new DateTime(2026, 8, 14, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(9668), "Active", "3", "Pack", null, new DateTime(2026, 8, 29, 10, 16, 42, 997, DateTimeKind.Utc).AddTicks(3385), 0 },
                    { "4", "NB-009", null, new DateTime(2026, 8, 29, 10, 16, 42, 997, DateTimeKind.Utc).AddTicks(3998), "Unchanged", null, false, "2026-08-29 10:16:42.997400", "7", "A4 Notebook", 120000L, 200m, new DateTime(2026, 8, 9, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(9668), "Active", "1", "Piece", null, new DateTime(2026, 8, 29, 10, 16, 42, 997, DateTimeKind.Utc).AddTicks(4002), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "DeletedAt", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsDeleted", "IsPublic", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", 140L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(2875), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995327", null, "1", "1", 160L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(3127), 0 },
                    { "10", 230L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7236), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995723", null, "4", "10", 270L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7237), 0 },
                    { "11", 2760L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7247), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995724", null, "4", "11", 3240L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7248), 0 },
                    { "12", 11040L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7255), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995725", null, "4", "12", 12960L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7256), 0 },
                    { "13", 160L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7262), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995726", null, "5", "13", 190L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7263), 0 },
                    { "14", 3200L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7269), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995727", null, "5", "14", 3800L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7270), 0 },
                    { "15", 9600L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7275), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995727", null, "5", "15", 11400L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7277), 0 },
                    { "16", 110L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7291), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995729", null, "6", "16", 130L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7292), 0 },
                    { "17", 2640L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7324), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995732", null, "6", "17", 3120L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7326), 0 },
                    { "18", 7920L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7332), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995733", null, "6", "18", 9360L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7333), 0 },
                    { "19", 280L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7340), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995734", null, "7", "19", 320L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7342), 0 },
                    { "2", 1680L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(4420), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995517", null, "1", "2", 1920L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(4931), 0 },
                    { "20", 3360L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7347), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995735", null, "7", "20", 3840L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7349), 0 },
                    { "21", 14000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7354), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995735", null, "7", "21", 16000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7355), 0 },
                    { "22", 45L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7361), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995736", null, "8", "22", 55L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7362), 0 },
                    { "23", 540L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7368), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995737", null, "8", "23", 660L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7369), 0 },
                    { "24", 6480L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7375), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995737", null, "8", "24", 7920L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7377), 0 },
                    { "25", 380L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7383), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995738", null, "9", "25", 420L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7384), 0 },
                    { "26", 7600L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7389), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995739", null, "9", "26", 8400L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7390), 0 },
                    { "27", 430L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7397), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995740", null, "10", "27", 470L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7398), 0 },
                    { "28", 5160L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7404), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995740", null, "10", "28", 5640L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7405), 0 },
                    { "29", 10320L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7410), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995741", null, "10", "29", 11280L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7411), 0 },
                    { "3", 3360L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(5837), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995685", null, "1", "3", 3840L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(6451), 0 },
                    { "30", 260L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7417), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995742", null, "11", "30", 300L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7418), 0 },
                    { "31", 2600L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7424), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995742", null, "11", "31", 3000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7425), 0 },
                    { "32", 6500L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7431), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995743", null, "11", "32", 7500L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7432), 0 },
                    { "33", 180L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7437), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995744", null, "12", "33", 220L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7439), 0 },
                    { "34", 3600L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7444), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995744", null, "12", "34", 4400L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7445), 0 },
                    { "35", 9000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7462), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995746", null, "12", "35", 11000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7463), 0 },
                    { "36", 330L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7470), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995747", null, "13", "36", 370L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7471), 0 },
                    { "37", 3960L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7476), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995747", null, "13", "37", 4440L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7478), 0 },
                    { "38", 7920L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7483), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995748", null, "13", "38", 8880L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7484), 0 },
                    { "39", 160L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7490), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995749", null, "14", "39", 200L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7491), 0 },
                    { "4", 130L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7187), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995719", null, "2", "4", 150L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7191), 0 },
                    { "40", 3840L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7497), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995750", null, "14", "40", 4800L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7499), 0 },
                    { "41", 11520L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7504), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995750", null, "14", "41", 14400L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7506), 0 },
                    { "42", 230L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7511), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995751", null, "15", "42", 270L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7512), 0 },
                    { "43", 11500L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7519), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995752", null, "15", "43", 13500L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7520), 0 },
                    { "44", 46000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7526), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995752", null, "15", "44", 54000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7527), 0 },
                    { "45", 750L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7533), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995753", null, "16", "45", 850L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7534), 0 },
                    { "46", 15000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7539), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995754", null, "16", "46", 17000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7540), 0 },
                    { "47", 75000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7546), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995754", null, "16", "47", 85000L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7547), 0 },
                    { "5", 1560L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7199), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995720", null, "2", "5", 1800L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7200), 0 },
                    { "6", 3120L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7207), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995721", null, "2", "6", 3600L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7208), 0 },
                    { "7", 70L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7215), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995721", null, "3", "7", 90L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7216), 0 },
                    { "8", 420L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7222), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995722", null, "3", "8", 540L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7223), 0 },
                    { "9", 840L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7229), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, false, true, "2026-08-29 10:16:42.995723", null, "3", "9", 1080L, null, new DateTime(2026, 8, 29, 10, 16, 42, 995, DateTimeKind.Utc).AddTicks(7230), 0 }
                });

            migrationBuilder.InsertData(
                table: "StockTransaction",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EntityState", "IsPublic", "LastModifiedUtc", "ProductId", "ProductName", "Quantity", "Reference", "ShopId", "ShopName", "StockBatchId", "TransactionDate", "Type", "UnitId", "UnitName", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 8, 29, 10, 16, 42, 998, DateTimeKind.Utc).AddTicks(6670), "Unchanged", false, "2026-08-29 10:16:42.998679", "1", "Coca Cola 500ml", 100m, "Purchase Order #001", "1", "Main Store", "1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 42, 998, DateTimeKind.Utc).AddTicks(6749), 0 },
                    { "10", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1105), "Unchanged", false, "2026-08-29 10:16:42.999110", "7", "A4 Notebook", 5m, "Sale #005", "1", "Main Store", "4", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1106), 0 },
                    { "2", null, new DateTime(2026, 8, 29, 10, 16, 42, 998, DateTimeKind.Utc).AddTicks(8330), "Unchanged", false, "2026-08-29 10:16:42.998884", "1", "Coca Cola 500ml", 20m, "Sale #001", "1", "Main Store", "1", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 42, 998, DateTimeKind.Utc).AddTicks(8645), 0 },
                    { "3", null, new DateTime(2026, 8, 29, 10, 16, 42, 998, DateTimeKind.Utc).AddTicks(9908), "Unchanged", false, "2026-08-29 10:16:42.999072", "1", "Coca Cola 500ml", 80m, "Purchase Order #002", "1", "Main Store", "2", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(397), 0 },
                    { "4", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1029), "Unchanged", false, "2026-08-29 10:16:42.999103", "1", "Coca Cola 500ml", 15m, "Sale #002", "1", "Main Store", "2", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "2", "Bottle", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1033), 0 },
                    { "5", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1045), "Unchanged", false, "2026-08-29 10:16:42.999104", "4", "Oreo Biscuits", 50m, "Purchase Order #003", "1", "Main Store", "3", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "3", "Pack", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1047), 0 },
                    { "6", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1057), "Unchanged", false, "2026-08-29 10:16:42.999105", "4", "Oreo Biscuits", 10m, "Sale #003", "1", "Main Store", "3", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "3", "Pack", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1058), 0 },
                    { "7", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1067), "Unchanged", false, "2026-08-29 10:16:42.999107", "4", "Oreo Biscuits", 2m, "Damage - Expired", "1", "Main Store", "3", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adujstment", "3", "Pack", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1068), 0 },
                    { "8", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1083), "Unchanged", false, "2026-08-29 10:16:42.999108", "7", "A4 Notebook", 200m, "Purchase Order #004", "1", "Main Store", "4", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In", "1", "Piece", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1085), 0 },
                    { "9", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1093), "Unchanged", false, "2026-08-29 10:16:42.999109", "7", "A4 Notebook", 25m, "Sale #004", "1", "Main Store", "4", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Out", "1", "Piece", null, new DateTime(2026, 8, 29, 10, 16, 42, 999, DateTimeKind.Utc).AddTicks(1095), 0 }
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
