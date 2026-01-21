using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppLogs",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    Exception = table.Column<string>(type: "TEXT", nullable: true),
                    Properties = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLogs", x => x.PublicId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
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
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.PublicId);
                    table.UniqueConstraint("AK_Languages_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.PublicId);
                    table.UniqueConstraint("AK_Provinces_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopType = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TaxNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.PublicId);
                });

            migrationBuilder.CreateTable(
                name: "TranslationKeys",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    MessageCode = table.Column<int>(type: "INTEGER", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslationKeys", x => x.PublicId);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasure",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasure", x => x.PublicId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
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
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
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
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
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
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    ProvinceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    LanguageCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsDefault = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvinceTranslations", x => x.PublicId);
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
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationKeyId = table.Column<string>(type: "TEXT", nullable: true),
                    Id = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.PublicId);
                    table.ForeignKey(
                        name: "FK_Districts_TranslationKeys_TranslationKeyId",
                        column: x => x.TranslationKeyId,
                        principalTable: "TranslationKeys",
                        principalColumn: "PublicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationKeyPublicId = table.Column<string>(type: "TEXT", nullable: false),
                    LanguageNo = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.PublicId);
                    table.ForeignKey(
                        name: "FK_Translations_Languages_LanguageNo",
                        column: x => x.LanguageNo,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Translations_TranslationKeys_TranslationKeyPublicId",
                        column: x => x.TranslationKeyPublicId,
                        principalTable: "TranslationKeys",
                        principalColumn: "PublicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PublicId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "2bd06897-de6d-44af-a9e8-367affb98dd2", "admin@local", true, "System", "Admin", false, null, "ADMIN@LOCAL", "ADMIN", "AQAAAAIAAYagAAAAEFo4Wk1Z/eb0FMgSjCDrXoXvdqDejQDSa+rz/e6aWsHwjfGy9GJPT/fJt95/Rwz0Dg==", null, false, "1", "admin-seed", false, "admin" },
                    { 2, 0, "09fe8ffd-72a4-48b4-8cc6-c624495f812f", "user@local", true, "Default", "User", false, null, "USER@LOCAL", "USER", "AQAAAAIAAYagAAAAEFv8//Id7RqUsttTrZJblZittfzfLieQup5NsMS+t3mANiiHbDAEKgJhBGFty5mYEQ==", null, false, "2", "user-seed", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "PublicId", "Code", "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { "1", "en", 1, true, "English" },
                    { "2", "ps", 2, true, "Pashto" },
                    { "3", "fa", 3, true, "Farsi" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsPublic", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5024), 1, false, "Kabul", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5029) },
                    { "2", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5033), 2, false, "Herat", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5033) },
                    { "3", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5035), 3, false, "Kandahar", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5036) },
                    { "4", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5037), 4, false, "Balkh", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(5037) }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsActive", "IsPublic", "MessageCode", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 21, 12, 35, 16, 321, DateTimeKind.Local).AddTicks(3143), 1, true, false, 1001, "Kabul Center District", null, new DateTime(2026, 1, 21, 12, 35, 16, 322, DateTimeKind.Local).AddTicks(9063) },
                    { "2", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2232), 2, true, false, 1002, "Kabul North District", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2236) },
                    { "3", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2240), 3, true, false, 1003, "Herat Center District", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2241) },
                    { "4", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2243), 4, true, false, 2001, "Kabul Province", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2243) },
                    { "5", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2245), 5, true, false, 2002, "Herat Province", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(2246) }
                });

            migrationBuilder.InsertData(
                table: "UnitOfMeasure",
                columns: new[] { "PublicId", "Description", "Id", "Name", "Symbol" },
                values: new object[,]
                {
                    { "1", null, 1, "Piece", "pcs" },
                    { "2", null, 2, "Gram", "g" },
                    { "3", null, 3, "Milliliter", "ml" },
                    { "4", null, 4, "Box", "box" },
                    { "5", null, 5, "Bottle", "btl" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsPublic", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(9899), 1, false, "Kabul Center", "1", null, new DateTime(2026, 1, 21, 12, 35, 16, 324, DateTimeKind.Local).AddTicks(9902) },
                    { "2", null, new DateTime(2026, 1, 21, 12, 35, 16, 325, DateTimeKind.Local).AddTicks(231), 2, false, "Kabul North", "2", null, new DateTime(2026, 1, 21, 12, 35, 16, 325, DateTimeKind.Local).AddTicks(233) },
                    { "3", null, new DateTime(2026, 1, 21, 12, 35, 16, 325, DateTimeKind.Local).AddTicks(236), 3, false, "Herat Center", "3", null, new DateTime(2026, 1, 21, 12, 35, 16, 325, DateTimeKind.Local).AddTicks(236) }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "PublicId", "Id", "IsDefault", "LanguageCode", "LanguageId", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { "1", 1, true, "en", 1, "Kabul", 1 },
                    { "10", 10, true, "en", 1, "Balkh", 4 },
                    { "11", 11, false, "ps", 2, "بلخ", 4 },
                    { "12", 12, false, "fa", 3, "بلخ", 4 },
                    { "2", 2, false, "ps", 2, "کابل", 1 },
                    { "3", 3, false, "fa", 3, "کابل", 1 },
                    { "4", 4, true, "en", 1, "Herat", 2 },
                    { "5", 5, false, "ps", 2, "هرات", 2 },
                    { "6", 6, false, "fa", 3, "هرات", 2 },
                    { "7", 7, true, "en", 1, "Kandahar", 3 },
                    { "8", 8, false, "ps", 2, "کندهار", 3 },
                    { "9", 9, false, "fa", 3, "قندهار", 3 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsPublic", "LanguageNo", "Name", "TranslationKeyPublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(7603), 1, false, 1, "", "1", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(7607) },
                    { "10", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8310), 10, false, 1, "", "4", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8311) },
                    { "11", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8312), 11, false, 2, "", "4", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8313) },
                    { "12", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8314), 12, false, 3, "", "4", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8315) },
                    { "13", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8316), 13, false, 1, "", "5", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8316) },
                    { "14", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8318), 14, false, 2, "", "5", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8318) },
                    { "15", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8319), 15, false, 3, "", "5", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8320) },
                    { "2", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8291), 2, false, 2, "", "1", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8294) },
                    { "3", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8297), 3, false, 3, "", "1", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8298) },
                    { "4", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8299), 4, false, 1, "", "2", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8300) },
                    { "5", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8301), 5, false, 2, "", "2", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8302) },
                    { "6", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8303), 6, false, 3, "", "2", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8304) },
                    { "7", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8305), 7, false, 1, "", "3", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8305) },
                    { "8", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8307), 8, false, 2, "", "3", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8307) },
                    { "9", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8309), 9, false, 3, "", "3", null, new DateTime(2026, 1, 21, 12, 35, 16, 323, DateTimeKind.Local).AddTicks(8309) }
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
                column: "MessageCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageNo",
                table: "Translations",
                column: "LanguageNo");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_TranslationKeyPublicId",
                table: "Translations",
                column: "TranslationKeyPublicId");
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
