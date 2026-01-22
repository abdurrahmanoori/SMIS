using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e7accd3-fdf3-40e3-bc1f-f53155a36aaf", "AQAAAAIAAYagAAAAEKZJFHXKkYsWoISZcHFGt6LKuPh/NPFCHE75kd5U6y/fW/5Fiadpu7eKLnx2fahzpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc0003cd-1435-4666-9e7a-66abe2b4c855", "AQAAAAIAAYagAAAAEBmY4S4PILC9v77NelOn4BurRM2IGOcIzLts6+El1pvTTVqkCevQNlLFCl3sFmOaOg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(2362), new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(2727), new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(2730), new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(3191), new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(3388), new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(3390), new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(19), new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(870), new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(873), new DateTime(2026, 1, 22, 8, 15, 4, 427, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.InsertData(
                table: "ProductUnit",
                columns: new[] { "Id", "ConversionFactor", "ProductId", "UnitOfMeasureId" },
                values: new object[,]
                {
                    { "1", 10m, "1", "1" },
                    { "2", 100m, "1", "2" },
                    { "3", 12m, "2", "1" }
                });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(9910), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(9916), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(9918), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(9919), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(7978), new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(8518), new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(8521), new DateTime(2026, 1, 22, 8, 15, 4, 426, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 423, DateTimeKind.Local).AddTicks(5798), new DateTime(2026, 1, 22, 8, 15, 4, 424, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 424, DateTimeKind.Local).AddTicks(8910), new DateTime(2026, 1, 22, 8, 15, 4, 424, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 424, DateTimeKind.Local).AddTicks(8918), new DateTime(2026, 1, 22, 8, 15, 4, 424, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 424, DateTimeKind.Local).AddTicks(8920), new DateTime(2026, 1, 22, 8, 15, 4, 424, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 424, DateTimeKind.Local).AddTicks(8921), new DateTime(2026, 1, 22, 8, 15, 4, 424, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(3941), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4362), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4363), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4364), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4365), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4366), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4367), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4352), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4354), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4355), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4356), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4357), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4358), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4359), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4361), new DateTime(2026, 1, 22, 8, 15, 4, 425, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_ProductId",
                table: "ProductUnit",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnit_UnitOfMeasureId",
                table: "ProductUnit",
                column: "UnitOfMeasureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductUnit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7042daa-e5f9-48e2-87d1-c4ad780384d5", "AQAAAAIAAYagAAAAEA6hT5HyzmsH7KR5klvTOPEKtHxjGhrYfdCHhEDyc6kmMQT3m+NO7JeITIut/ihmGQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5d12fcf-5004-4bfe-bec2-e5340155ed80", "AQAAAAIAAYagAAAAEBZC+/lcir2cJ9x02ajE/dHhl12tKJhL/o54qpohvZ99oj73pFHmkoL31G9r5t+ppg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(6976), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(8071), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(8076), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(385), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(710), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(715), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(1786), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(4038), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(4046), new DateTime(2026, 1, 21, 20, 57, 46, 340, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5264), new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5273), new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5275), new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5277), new DateTime(2026, 1, 21, 20, 57, 46, 338, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(6751), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(8289), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(8295), new DateTime(2026, 1, 21, 20, 57, 46, 339, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 335, DateTimeKind.Local).AddTicks(7280), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1937), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1943), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1945), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1954), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7148), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7817), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7825), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7827), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7829), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7830), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7832), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7800), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7805), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7807), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7809), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7811), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7812), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7814), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7815), new DateTime(2026, 1, 21, 20, 57, 46, 337, DateTimeKind.Local).AddTicks(7816) });
        }
    }
}
