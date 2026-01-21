using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryRelationshipToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "Product",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51781b24-7357-4983-90aa-d28e3f88c205", "AQAAAAIAAYagAAAAEJ7BB1oQ6+RDdFTL7YCj71hMt9Ue2usjfoJfPhI+y6VzmqX3o2mRvGV5zewvsY78Fg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57609190-020f-4cee-896d-44736b2c17e7", "AQAAAAIAAYagAAAAEDJCiC6Y4J+73cvDiC/JVDDjGgNSlE+i4GVIfAl/FVsAkNts4/4jwN8acC31qz68Fg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(3234), new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(4960), new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(4966), new DateTime(2026, 1, 21, 20, 52, 34, 260, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(8948), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(9471), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(9477), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CategoryId", "CreatedDate", "UpdatedDate" },
                values: new object[] { "1", new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(5177), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CategoryId", "CreatedDate", "UpdatedDate" },
                values: new object[] { "1", new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(8809), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CategoryId", "CreatedDate", "UpdatedDate" },
                values: new object[] { "2", new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(8817), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1550), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1572), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1574), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1577), new DateTime(2026, 1, 21, 20, 52, 34, 257, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 258, DateTimeKind.Local).AddTicks(8281), new DateTime(2026, 1, 21, 20, 52, 34, 258, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(670), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(678), new DateTime(2026, 1, 21, 20, 52, 34, 259, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 253, DateTimeKind.Local).AddTicks(2322), new DateTime(2026, 1, 21, 20, 52, 34, 254, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(316), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(323), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(325), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(327), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(8695), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9771), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9773), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9775), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9778), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9780), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9782), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9749), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9755), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9757), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9760), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9762), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9764), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9767), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9769), new DateTime(2026, 1, 21, 20, 52, 34, 255, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c80b9789-1fe4-429e-bd57-c83eab77f3ae", "AQAAAAIAAYagAAAAELeLdIeeW6/hoD1H7V73m1a+k0aWVTcTaRy2LglP4MTdQS6bBxigorUKBnqhMqHc4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83de9ecc-c543-452a-9633-27c65b38e1d5", "AQAAAAIAAYagAAAAELoQxFq7GvqXb6tCd2eoi1pYxT+oJlccEWEZSwGhj+ksoBk2mAOlzQajK4wt0kIz1g==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(9973), new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 695, DateTimeKind.Local).AddTicks(1509), new DateTime(2026, 1, 21, 20, 44, 47, 695, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 695, DateTimeKind.Local).AddTicks(1519), new DateTime(2026, 1, 21, 20, 44, 47, 695, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6491), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6830), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6834), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(3692), new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(6674), new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(6682), new DateTime(2026, 1, 21, 20, 44, 47, 694, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(266), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(291), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(298), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(300), new DateTime(2026, 1, 21, 20, 44, 47, 692, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(5161), new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(7929), new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(7947), new DateTime(2026, 1, 21, 20, 44, 47, 693, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 688, DateTimeKind.Local).AddTicks(7169), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4968), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4976), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4978), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4980), new DateTime(2026, 1, 21, 20, 44, 47, 690, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1116), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1794), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1795), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1797), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1799), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1800), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1802), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1778), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1782), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1784), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1785), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1787), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1789), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1790), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1792), new DateTime(2026, 1, 21, 20, 44, 47, 691, DateTimeKind.Local).AddTicks(1793) });
        }
    }
}
