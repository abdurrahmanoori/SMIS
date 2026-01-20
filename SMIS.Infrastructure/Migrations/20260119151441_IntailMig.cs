using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IntailMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Level = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    Exception = table.Column<string>(type: "TEXT", nullable: true),
                    Properties = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PublicId = table.Column<string>(type: "TEXT", nullable: true),
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PublicId = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TranslationKeys",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    MessageCode = table.Column<int>(type: "INTEGER", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProvinceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    LanguageCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: false),
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "c3f098f9-4fb4-4c8e-b7cb-a59df53a4be6", "admin@local", true, "System", "Admin", false, null, "ADMIN@LOCAL", "ADMIN", "AQAAAAIAAYagAAAAENTsGBYh0SKmnXk8SlGYXwVstdvixnSoCYYN+DjreLtIDgS4P2KGIbBwmoH6iwjgJg==", null, false, "admin-seed", false, "admin" },
                    { 2, 0, "de2bbebf-b2c2-496a-8840-edeeca5c6f13", "user@local", true, "Default", "User", false, null, "USER@LOCAL", "USER", "AQAAAAIAAYagAAAAECRZANrhX+c12xSiLOSnxy8vhaDYhxMIZXRintS5RMT0zZaEuDHe2HlbQ5urFyK62g==", null, false, "user-seed", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, "en", true, "English" },
                    { 2, "ps", true, "Pashto" },
                    { 3, "fa", true, "Farsi" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsPublic", "Name", "PublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6453), false, "Kabul", "9b304f04-2ea4-4820-8579-46ee622b4080", null, new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6461) },
                    { 2, null, new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6527), false, "Herat", "054edae0-6f68-46fc-b2b4-17bbc3452b39", null, new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6528) },
                    { 3, null, new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6531), false, "Kandahar", "1ef4f354-dc47-41b5-81c9-cd5f11e99084", null, new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6531) },
                    { 4, null, new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6544), false, "Balkh", "29f2d416-4afc-4b36-a7b9-2f8ed5a9f927", null, new DateTime(2026, 1, 19, 19, 44, 40, 464, DateTimeKind.Local).AddTicks(6545) }
                });

            migrationBuilder.InsertData(
                table: "TranslationKeys",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsActive", "IsPublic", "MessageCode", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "district_herat_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1122), 3, true, false, 1003, "Herat Center District", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1123) },
                    { "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 460, DateTimeKind.Local).AddTicks(9499), 1, true, false, 1001, "Kabul Center District", null, new DateTime(2026, 1, 19, 19, 44, 40, 462, DateTimeKind.Local).AddTicks(7345) },
                    { "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1102), 2, true, false, 1002, "Kabul North District", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1107) },
                    { "province_herat", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1141), 5, true, false, 2002, "Herat Province", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1141) },
                    { "province_kabul", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1137), 4, true, false, 2001, "Kabul Province", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(1137) }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsPublic", "Name", "TranslationKeyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "district-herat-center-guid", null, new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1584), 3, false, "Herat Center", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1584) },
                    { "district-kabul-center-guid", null, new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1263), 1, false, "Kabul Center", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1266) },
                    { "district-kabul-north-guid", null, new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1574), 2, false, "Kabul North", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 44, 40, 465, DateTimeKind.Local).AddTicks(1576) }
                });

            migrationBuilder.InsertData(
                table: "ProvinceTranslations",
                columns: new[] { "Id", "IsDefault", "LanguageCode", "LanguageId", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 1, true, "en", 1, "Kabul", 1 },
                    { 2, false, "ps", 2, "کابل", 1 },
                    { 3, false, "fa", 3, "کابل", 1 },
                    { 4, true, "en", 1, "Herat", 2 },
                    { 5, false, "ps", 2, "هرات", 2 },
                    { 6, false, "fa", 3, "هرات", 2 },
                    { 7, true, "en", 1, "Kandahar", 3 },
                    { 8, false, "ps", 2, "کندهار", 3 },
                    { 9, false, "fa", 3, "قندهار", 3 },
                    { 10, true, "en", 1, "Balkh", 4 },
                    { 11, false, "ps", 2, "بلخ", 4 },
                    { 12, false, "fa", 3, "بلخ", 4 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "PublicId", "CreatedBy", "CreatedDate", "Id", "IsPublic", "LanguageNo", "Name", "TranslationKeyPublicId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "0190ce58-1112-4f55-a90a-e96e11c32d12", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7557), 2, false, 2, "", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7559) },
                    { "12e54a53-152d-49da-a420-901848d7d327", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7599), 12, false, 3, "", "province_kabul", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7600) },
                    { "217a1115-ec3c-4cb9-af45-340aa1a9ac93", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7574), 5, false, 2, "", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7574) },
                    { "308ae1f8-abad-4908-8523-b5f25f87ab78", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7577), 6, false, 3, "", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7577) },
                    { "37bd2739-be75-46d5-990b-e834444af56c", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7594), 10, false, 1, "", "province_kabul", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7595) },
                    { "3e85fb43-d242-4a91-a1bf-bd39def471ec", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7586), 7, false, 1, "", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7586) },
                    { "728aeec2-4c25-4335-b4f4-94012c22433b", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7630), 14, false, 2, "", "province_herat", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7631) },
                    { "77c6fc32-80ad-4808-8d65-e1382622590d", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7597), 11, false, 2, "", "province_kabul", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7597) },
                    { "82391871-5c0e-40f1-8b6a-0bd5001d0527", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7635), 15, false, 3, "", "province_herat", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7635) },
                    { "a6783979-a527-4426-a2ca-5d1b42993a84", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(6698), 1, false, 1, "", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(6701) },
                    { "a72f57b6-5b63-4af8-b786-1d44ed4235f5", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7588), 8, false, 2, "", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7589) },
                    { "b482a6e7-6790-4f2f-84c5-85a29342ea9a", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7591), 9, false, 3, "", "district_herat_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7592) },
                    { "bf128153-1822-405c-af47-35c9404d478f", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7568), 3, false, 3, "", "district_kabul_center", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7569) },
                    { "d234cb50-a752-4692-b110-491df6ce1986", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7602), 13, false, 1, "", "province_herat", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7603) },
                    { "daa72ad0-7b53-4f9c-a965-58421ff5fad3", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7571), 4, false, 1, "", "district_kabul_north", null, new DateTime(2026, 1, 19, 19, 44, 40, 463, DateTimeKind.Local).AddTicks(7571) }
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
                name: "IX_ProvinceTranslations_LanguageId",
                table: "ProvinceTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvinceTranslations_ProvinceId_LanguageId",
                table: "ProvinceTranslations",
                columns: new[] { "ProvinceId", "LanguageId" },
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
                name: "Translations");

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
