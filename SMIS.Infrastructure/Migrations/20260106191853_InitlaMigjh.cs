using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitlaMigjh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3ba0179-5463-441e-bad6-375f39795c66", "AQAAAAIAAYagAAAAEHKKgIAMI4HBWCbHbJEKgZ3Uu0wmFDghzNj+qVeTLP5htDXXf8oPzc7G6svhx5KBTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5263204-a010-4194-9713-b212381c4e0e", "AQAAAAIAAYagAAAAELV+VojexBha6WELz5McB96mv1QFPAqTUNQDGUchFGF/7/F+1ZDX5/EL5N3o2dEt4w==" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "PublicId",
                value: "22680a5f-69f7-4e3d-a2d1-c4e8bc12c5a3");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "PublicId",
                value: "bf91c1fc-cc17-4c11-afea-1a0e38aa8354");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "PublicId",
                value: "bf382d84-ceaf-4805-b6cc-3a1fea8f0893");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "PublicId",
                value: "18ae0aca-62a1-45bc-a74e-6182d941e8d4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d7f3e85-a8b2-4e39-ac92-ee5d48bfcdc1", "AQAAAAIAAYagAAAAECnqZQtOYWeqUPuISPwIxRGoMEUpxBTU1gucltMCAnlmkEYshiWNhdBF7PSrNxGfTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c90775e9-9b50-4ae6-ae0b-be920287927b", "AQAAAAIAAYagAAAAEK5qb0fzi5OFFW6ptJ/v3gxiVkPgXxddG4jDLGGP27SyQRHxmVAKTwt+ihA+8SOuLA==" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "PublicId",
                value: "22a2df77-9d8b-4a88-894f-40b7c59e175d");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "PublicId",
                value: "384fc19a-3ff2-402e-b03a-cf6c2b9d06e9");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "PublicId",
                value: "3bdb3156-b0fd-4473-b280-f66ce5b0f739");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "PublicId",
                value: "71e76d8a-c335-4cea-aac8-3258d498f7cc");
        }
    }
}
