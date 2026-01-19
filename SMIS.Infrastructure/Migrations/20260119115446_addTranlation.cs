using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addTranlation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TranslationKeyId",
                table: "Districts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TranslationKeys",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    MessageCode = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
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
                name: "Translations",
                columns: table => new
                {
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationKeyPublicId = table.Column<string>(type: "TEXT", nullable: false),
                    LanguageNo = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1669a354-ca9b-4ac4-ba85-e1b58da9c06e", "AQAAAAIAAYagAAAAEFQmfWMWAYvwfYIG63T8m7VdO+eUfokmL/Drdw2C8XZVr7xRKRGQylea8XhVUPz4bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57b54246-52f5-4f24-a823-e6826cf06657", "AQAAAAIAAYagAAAAEEyJaIgrAWbiJCd2gIRQ/rNzPfAXF2BC+HFI5ZRY5lBsuNQmqkxtrEhm85etSxJWXQ==" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 16, 24, 45, 806, DateTimeKind.Local).AddTicks(1384), "57997926-b268-4c70-a48f-372a2f7a98df", new DateTime(2026, 1, 19, 16, 24, 45, 807, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 16, 24, 45, 807, DateTimeKind.Local).AddTicks(6881), "52f264c1-eb97-478c-a604-8d772dd45ca4", new DateTime(2026, 1, 19, 16, 24, 45, 807, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 16, 24, 45, 807, DateTimeKind.Local).AddTicks(6905), "0bdfac84-703b-45a7-9d19-ff215b2c34eb", new DateTime(2026, 1, 19, 16, 24, 45, 807, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 16, 24, 45, 807, DateTimeKind.Local).AddTicks(6914), "1e996013-eee4-40b2-933a-1e8bc3815495", new DateTime(2026, 1, 19, 16, 24, 45, 807, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.CreateIndex(
                name: "IX_Districts_TranslationKeyId",
                table: "Districts",
                column: "TranslationKeyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageNo",
                table: "Translations",
                column: "LanguageNo");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_TranslationKeyPublicId",
                table: "Translations",
                column: "TranslationKeyPublicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_TranslationKeys_TranslationKeyId",
                table: "Districts",
                column: "TranslationKeyId",
                principalTable: "TranslationKeys",
                principalColumn: "PublicId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_TranslationKeys_TranslationKeyId",
                table: "Districts");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "TranslationKeys");

            migrationBuilder.DropIndex(
                name: "IX_Districts_TranslationKeyId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "TranslationKeyId",
                table: "Districts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf2d2e7c-0273-41b0-ae2f-de68232d4dc8", "AQAAAAIAAYagAAAAEP5Y4fNb19Lk6XiFTl69WmVwqa155pER8ifMvj5DzJHnbwHLueSt15WZkVgyYWi8zw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0ccd321-de5c-4ddd-b3e4-a654cf14de0f", "AQAAAAIAAYagAAAAEHV5GS511kzX/LQxJZWY/4marXqLjkpkaRHQhQcz8o9x8x3GFY5jmyz/7b2T1DaAyg==" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(2032), "a5cd8883-b785-4ea1-af98-b7da4a656e7a", new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9444), "41d70769-fbf0-4340-aa68-4561ffabd2a4", new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9451), "3295dc23-9bd5-4b47-bca1-576e530e3522", new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9461), "e868839c-0c1f-47df-a8c3-6e72bc5b3e27", new DateTime(2026, 1, 19, 15, 30, 52, 238, DateTimeKind.Local).AddTicks(9461) });
        }
    }
}
