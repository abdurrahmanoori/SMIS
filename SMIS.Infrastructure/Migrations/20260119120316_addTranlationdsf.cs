using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addTranlationdsf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TranslationKeys",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20bf741f-ce34-471e-b2ac-a67608667fd7", "AQAAAAIAAYagAAAAEM8mIN38rSCRdyVXzrB9z7osnl3t0gVUUetxN/C2Uz3iXD863GESshiGBOFdijwwwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db1a4e25-03fe-4cf8-acb8-c575f4cc17c5", "AQAAAAIAAYagAAAAEA80jQw7/pwzHGTw38no0zTl4/Yb8RGthUzJsPiKjppX1RoHjjzkT7YPSNvMiDlG9Q==" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 16, 33, 15, 252, DateTimeKind.Local).AddTicks(8252), "372d16df-8f84-40cb-8f78-49e00e46a83b", new DateTime(2026, 1, 19, 16, 33, 15, 254, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 16, 33, 15, 254, DateTimeKind.Local).AddTicks(7593), "e239b6ed-dde5-4f18-a4f3-1d0e1e3bba22", new DateTime(2026, 1, 19, 16, 33, 15, 254, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 16, 33, 15, 254, DateTimeKind.Local).AddTicks(7974), "929c1ac2-1870-4875-a625-f9e73902a552", new DateTime(2026, 1, 19, 16, 33, 15, 254, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PublicId", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 19, 16, 33, 15, 254, DateTimeKind.Local).AddTicks(7993), "3936f804-4c2d-42a3-a880-c80a941bf870", new DateTime(2026, 1, 19, 16, 33, 15, 254, DateTimeKind.Local).AddTicks(7994) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TranslationKeys",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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
        }
    }
}
