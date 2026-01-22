using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigraiton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppLogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    Exception = table.Column<string>(type: "TEXT", nullable: true),
                    Properties = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false)
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
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
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
                    ShopType = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TaxNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    MessageCode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
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
                name: "UnitOfMeasure",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasure", x => x.Id);
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
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                name: "ProvinceTranslations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProvinceId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
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
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationKeyId = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    TranslationKeyId = table.Column<string>(type: "TEXT", nullable: false),
                    LanguageNo = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
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
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    BaseUnitId = table.Column<string>(type: "TEXT", nullable: false),
                    SalePricePerBaseUnit = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    SKU = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Barcode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    CategoryId = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
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
                name: "ProductUnit",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    UnitOfMeasureId = table.Column<string>(type: "TEXT", nullable: false),
                    ConversionFactor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "11ccf456-d270-472b-89e0-38d26c0305d7", "admin@local", true, "System", "Admin", false, null, "ADMIN@LOCAL", "ADMIN", "AQAAAAIAAYagAAAAEFvqRn2KCmjYvMDdZ1ubID5Zgb8/eGQmUVxI7fVF51FFwhE3yQk726Ehqb6QuMjlAg==", null, false, "admin-seed", false, "admin" },
                    { "2", 0, "68c05f9c-6cb6-4948-9732-91c6032fc72d", "user@local", true, "Default", "User", false, null, "USER@LOCAL", "USER", "AQAAAAIAAYagAAAAEAb1FV00CELiQcmlhCs4qFO7RQyLaYehn8T0Rf4elXtzAUoHRDRY+eVFoQDDGoup2A==", null, false, "user-seed", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsPublic", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "BEV", null, new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(2583), "Drinks and beverages", true, false, "Beverages", null, new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(2594) },
                    { "2", "SOFT", null, new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(4916), "Carbonated and non-carbonated drinks", true, false, "Soft Drinks", null, new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(4924) },
                    { "3", "FOOD", null, new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(4931), "Edible products", true, false, "Food Items", null, new DateTime(2026, 1, 22, 20, 50, 52, 729, DateTimeKind.Local).AddTicks(4933) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "IsActive", "Name" },
                values: new object[,]
                {
                    { "1", "en", true, "English" },
                    { "2", "ps", true, "Pashto" },
                    { "3", "fa", true, "Farsi" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsPublic", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7931), false, "Kabul", null, new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7948) },
                    { "2", null, new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7963), false, "Herat", null, new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7965) },
                    { "3", null, new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7970), false, "Kandahar", null, new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7972) },
                    { "4", null, new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7976), false, "Balkh", null, new DateTime(2026, 1, 22, 20, 50, 52, 722, DateTimeKind.Local).AddTicks(7978) }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "IsActive", "IsPublic", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 1, 22, 20, 50, 52, 725, DateTimeKind.Local).AddTicks(6626), "main@pharmacy.local", true, false, "Main Pharmacy", "0700000001", "RetailShop", "TAX001", null, new DateTime(2026, 1, 22, 20, 50, 52, 725, DateTimeKind.Local).AddTicks(6638) },
                    { "2", "Herat Center", null, new DateTime(2026, 1, 22, 20, 50, 52, 726, DateTimeKind.Local).AddTicks(185), "city@pharmacy.local", true, false, "City Pharmacy", "0700000002", "WholesaleShop", "TAX002", null, new DateTime(2026, 1, 22, 20, 50, 52, 726, DateTimeKind.Local).AddTicks(192) },
                    { "3", "Kandahar Center", null, new DateTime(2026, 1, 22, 20, 50, 52, 726, DateTimeKind.Local).AddTicks(205), "health@store.local", true, false, "Health Store", "0700000003", "RetailShop", "TAX003", null, new DateTime(2026, 1, 22, 20, 50, 52, 726, DateTimeKind.Local).AddTicks(207) }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsPublic", "MessageCode", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 716, DateTimeKind.Local).AddTicks(2632), true, false, "1001", "Kabul Center District", null, new DateTime(2026, 1, 22, 20, 50, 52, 718, DateTimeKind.Local).AddTicks(6913) },
                    { "2", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2208), true, false, "1002", "Kabul North District", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2221) },
                    { "3", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2236), true, false, "1003", "Herat Center District", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2236) },
                    { "4", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2241), true, false, "2001", "Kabul Province", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2241) },
                    { "5", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2244), true, false, "2002", "Herat Province", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2244) },
                    { "6", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2246), true, false, "3001", "Welcome Message", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2246) },
                    { "7", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2249), true, false, "3002", "Error Message", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2249) },
                    { "8", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2251), true, false, "3003", "Success Message", null, new DateTime(2026, 1, 22, 20, 50, 52, 719, DateTimeKind.Local).AddTicks(2252) }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "Id", "Description", "Name", "Symbol" },
                values: new object[,]
                {
                    { "1", null, "Piece", "pcs" },
                    { "2", null, "Gram", "g" },
                    { "3", null, "Milliliter", "ml" },
                    { "4", null, "Box", "box" },
                    { "5", null, "Bottle", "btl" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsPublic", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7019), false, "Kabul Center", "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7032) },
                    { "2", null, new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7547), false, "Kabul North", "2", null, new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7549) },
                    { "3", null, new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7553), false, "Herat Center", "3", null, new DateTime(2026, 1, 22, 20, 50, 52, 723, DateTimeKind.Local).AddTicks(7553) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Barcode", "BaseUnitId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsPublic", "Name", "SKU", "SalePricePerBaseUnit", "ShopId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "1234567890123", "1", "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 727, DateTimeKind.Local).AddTicks(4254), "Pain reliever", "https://example.com/images/paracetamol.jpg", true, false, "Paracetamol 500mg", "PAR-500MG-001", 50, "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 727, DateTimeKind.Local).AddTicks(4271) },
                    { "2", "1234567890124", "1", "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 728, DateTimeKind.Local).AddTicks(5873), "Anti-inflammatory", "https://example.com/images/ibuprofen.jpg", true, false, "Ibuprofen 200mg", "IBU-200MG-002", 30, "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 728, DateTimeKind.Local).AddTicks(5886) },
                    { "3", "1234567890125", "1", "2", null, new DateTime(2026, 1, 22, 20, 50, 52, 728, DateTimeKind.Local).AddTicks(5910), "Blood thinner", "https://example.com/images/aspirin.jpg", true, false, "Aspirin 100mg", "ASP-100MG-003", 20, "2", null, new DateTime(2026, 1, 22, 20, 50, 52, 728, DateTimeKind.Local).AddTicks(5910) }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "IsDefault", "LanguageCode", "LanguageId", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { "1", true, "en", "1", "Kabul", "1" },
                    { "10", true, "en", "1", "Balkh", "4" },
                    { "11", false, "ps", "2", "بلخ", "4" },
                    { "12", false, "fa", "3", "بلخ", "4" },
                    { "2", false, "ps", "2", "کابل", "1" },
                    { "3", false, "fa", "3", "کابل", "1" },
                    { "4", true, "en", "1", "Herat", "2" },
                    { "5", false, "ps", "2", "هرات", "2" },
                    { "6", false, "fa", "3", "هرات", "2" },
                    { "7", true, "en", "1", "Kandahar", "3" },
                    { "8", false, "ps", "2", "کندهار", "3" },
                    { "9", false, "fa", "3", "قندهار", "3" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsPublic", "LanguageNo", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 720, DateTimeKind.Local).AddTicks(1881), false, "1", "Kabul Center District", "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 720, DateTimeKind.Local).AddTicks(1889) },
                    { "10", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1823), false, "2", "ولایت هرات", "5", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1823) },
                    { "11", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1825), false, "1", "Welcome Message", "6", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1826) },
                    { "12", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1828), false, "2", "پیام خوش آمدید", "6", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1829) },
                    { "2", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1763), false, "2", "منطقه مرکز کابل", "1", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1778) },
                    { "3", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1789), false, "1", "Kabul North District", "2", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1790) },
                    { "4", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1792), false, "2", "منطقه شمال کابل", "2", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1793) },
                    { "5", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1795), false, "1", "Herat Center District", "3", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1795) },
                    { "6", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1797), false, "2", "منطقه مرکز هرات", "3", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1797) },
                    { "7", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1799), false, "1", "Kabul Province", "4", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1815) },
                    { "8", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1818), false, "2", "ولایت کابل", "4", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1818) },
                    { "9", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1820), false, "1", "Herat Province", "5", null, new DateTime(2026, 1, 22, 20, 50, 52, 721, DateTimeKind.Local).AddTicks(1821) }
                });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "ProductId", "UnitOfMeasureId" },
                values: new object[,]
                {
                    { "1", 10m, "1", "1" },
                    { "2", 100m, "1", "2" },
                    { "3", 12m, "2", "1" }
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "Districts");

            migrationBuilder.DropTable(
                name: "ProductUnit");

            migrationBuilder.DropTable(
                name: "ProvinceTranslations");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "TranslationKeys");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "UnitOfMeasure");
        }
    }
}
