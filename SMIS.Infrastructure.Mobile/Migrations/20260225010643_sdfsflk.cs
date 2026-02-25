using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Mobile.Migrations
{
    /// <inheritdoc />
    public partial class sdfsflk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<int>(type: "INTEGER", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
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
                    EntityState = table.Column<int>(type: "INTEGER", nullable: false),
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
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    TranslationKeyId = table.Column<string>(type: "TEXT", nullable: false),
                    LanguageNo = table.Column<string>(type: "TEXT", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<int>(type: "INTEGER", nullable: false),
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
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 771, DateTimeKind.Utc).AddTicks(4540), new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 771, DateTimeKind.Unspecified).AddTicks(7686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 771, DateTimeKind.Utc).AddTicks(3660), new DateTime(2026, 2, 25, 1, 6, 42, 771, DateTimeKind.Utc).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(1237), new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(2821), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(374), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(6994), new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(8949), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(5974), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9879), new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9867), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9908), new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9904), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9930), new DateTimeOffset(new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Unspecified).AddTicks(9936), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9926), new DateTime(2026, 2, 25, 1, 6, 42, 772, DateTimeKind.Utc).AddTicks(9933) });

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                table: "Languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslationKeys_MessageCode",
                table: "TranslationKeys",
                column: "MessageCode");

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
                name: "Languages");

            migrationBuilder.DropTable(
                name: "TranslationKeys");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(3268), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Unspecified).AddTicks(5450), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(2577), new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(9060), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(8093), new DateTime(2026, 2, 24, 16, 15, 1, 672, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(4600), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(3506), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7647), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(7657), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7635), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7677), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7674), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7701), new DateTimeOffset(new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Unspecified).AddTicks(7707), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7697), new DateTime(2026, 2, 24, 16, 15, 1, 673, DateTimeKind.Utc).AddTicks(7704) });
        }
    }
}
