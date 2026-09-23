using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class StabilizeRemainingSeedValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                column: "StartDate",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                column: "StartDate",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                column: "StartDate",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000004",
                column: "StartDate",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                column: "OperationId",
                value: "22222222-2222-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                column: "OperationId",
                value: "22222222-2222-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                column: "OperationId",
                value: "22222222-2222-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                column: "OperationId",
                value: "22222222-2222-0000-0000-000000000004");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000001",
                column: "StartDate",
                value: new DateTime(2026, 9, 23, 11, 27, 11, 775, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000002",
                column: "StartDate",
                value: new DateTime(2026, 9, 23, 11, 27, 11, 777, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000003",
                column: "StartDate",
                value: new DateTime(2026, 9, 23, 11, 27, 11, 778, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "ffffffff-0000-0000-0000-000000000004",
                column: "StartDate",
                value: new DateTime(2026, 9, 23, 11, 27, 11, 778, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000001",
                column: "OperationId",
                value: "8fc49455-7047-4bd8-853f-b3699dc42783");

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000002",
                column: "OperationId",
                value: "1019249c-ed6f-4cf5-8e2e-aa8b85edbcbe");

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000003",
                column: "OperationId",
                value: "1b25247f-eaa8-4b10-942b-1f77bcfc060e");

            migrationBuilder.UpdateData(
                table: "StockMovement",
                keyColumn: "Id",
                keyValue: "22222222-2222-0000-0000-000000000004",
                column: "OperationId",
                value: "7b37726c-0103-41d9-9850-0e7bb438f8e8");
        }
    }
}
