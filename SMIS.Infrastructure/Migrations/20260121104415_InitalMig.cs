using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
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
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ShopType = table.Column<int>(type: "INTEGER", nullable: false),
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
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TranslationKeys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    MessageCode = table.Column<string>(type: "TEXT", nullable: true),
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
                    Name = table.Column<string>(type: "TEXT", nullable: false),
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "706ca6d0-69a8-456c-9fa4-f7a677b4a089", "admin@local", true, "System", "Admin", false, null, "ADMIN@LOCAL", "ADMIN", "AQAAAAIAAYagAAAAEGcfTMnAhd1vwdVvDvoa2q8fSRU5Mn/iKyL+KzLbxyiGNmKEST9aAjzAeousDa4pZg==", null, false, "admin-seed", false, "admin" },
                    { "2", 0, "298e1b4f-240e-4626-8500-2cef7559495a", "user@local", true, "Default", "User", false, null, "USER@LOCAL", "USER", "AQAAAAIAAYagAAAAEPEoAISbUASJ9c2RBAxVW7iwkwzVmgQ5awsb2rA6XEzwrmA/XfOy28GZYil/yIae7w==", null, false, "user-seed", false, "user" }
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
                    { "1", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(182), false, "Kabul", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(185) },
                    { "2", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(188), false, "Herat", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(189) },
                    { "3", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(190), false, "Kandahar", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(190) },
                    { "4", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(191), false, "Balkh", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(192) }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "IsActive", "IsPublic", "Name", "PhoneNumber", "ShopType", "TaxNumber", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "Kabul Center", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(4916), "main@pharmacy.local", true, false, "Main Pharmacy", "0700000001", 1, "TAX001", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(4919) },
                    { "2", "Herat Center", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(5463), "city@pharmacy.local", true, false, "City Pharmacy", "0700000002", 2, "TAX002", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(5464) },
                    { "3", "Kandahar Center", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(5466), "health@store.local", true, false, "Health Store", "0700000003", 1, "TAX003", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(5467) }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsPublic", "MessageCode", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 21, 15, 14, 14, 802, DateTimeKind.Local).AddTicks(4732), true, false, "1001", "Kabul Center District", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(2111) },
                    { "2", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3254), true, false, "1002", "Kabul North District", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3258) },
                    { "3", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3260), true, false, "1003", "Herat Center District", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3261) },
                    { "4", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3262), true, false, "2001", "Kabul Province", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3262) },
                    { "5", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3263), true, false, "2002", "Herat Province", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(3264) }
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
                    { "1", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2251), false, "Kabul Center", "1", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2252) },
                    { "2", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2371), false, "Kabul North", "2", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2372) },
                    { "3", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2373), false, "Herat Center", "3", null, new DateTime(2026, 1, 21, 15, 14, 14, 804, DateTimeKind.Local).AddTicks(2373) }
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
                    { "1", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6213), false, "1", "", "1", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6215) },
                    { "10", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6478), false, "1", "", "4", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6479) },
                    { "11", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6479), false, "2", "", "4", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6480) },
                    { "12", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6481), false, "3", "", "4", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6481) },
                    { "13", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6482), false, "1", "", "5", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6482) },
                    { "14", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6483), false, "2", "", "5", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6483) },
                    { "15", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6484), false, "3", "", "5", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6485) },
                    { "2", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6468), false, "2", "", "1", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6468) },
                    { "3", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6470), false, "3", "", "1", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6470) },
                    { "4", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6471), false, "1", "", "2", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6471) },
                    { "5", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6472), false, "2", "", "2", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6472) },
                    { "6", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6473), false, "3", "", "2", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6474) },
                    { "7", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6475), false, "1", "", "3", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6475) },
                    { "8", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6476), false, "2", "", "3", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6476) },
                    { "9", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6477), false, "3", "", "3", null, new DateTime(2026, 1, 21, 15, 14, 14, 803, DateTimeKind.Local).AddTicks(6477) }
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
                name: "IX_Translations_TranslationKeyId",
                table: "Translations",
                column: "TranslationKeyId");
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
                name: "ProvinceTranslations");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "UnitOfMeasure");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "TranslationKeys");
        }
    }
}
