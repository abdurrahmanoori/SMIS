using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddRemainingBusinessAuthorization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationComponents",
                columns: new[] { "Id", "DisplayOrder", "IsActive", "Key", "Name", "ShowInMenu" },
                values: new object[,]
                {
                    { "55555555-0000-0000-0000-000000000008", 8, true, "Customers", "Customers", true },
                    { "55555555-0000-0000-0000-000000000009", 9, true, "Suppliers", "Suppliers", true },
                    { "55555555-0000-0000-0000-000000000010", 10, true, "Purchasing", "Purchasing", true },
                    { "55555555-0000-0000-0000-000000000011", 11, true, "Sales", "Sales", true },
                    { "55555555-0000-0000-0000-000000000012", 12, true, "Receivables", "Receivables", true },
                    { "55555555-0000-0000-0000-000000000013", 13, true, "ShopOwners", "Shop owners", true }
                });

            migrationBuilder.InsertData(
                table: "ApplicationTasks",
                columns: new[] { "Id", "ComponentId", "IsActive", "Key", "Name" },
                values: new object[,]
                {
                    { "66666666-0000-0000-0000-000000000012", "55555555-0000-0000-0000-000000000010", true, "Purchasing.ReceivePurchaseOrder", "Receive purchase order" },
                    { "66666666-0000-0000-0000-000000000013", "55555555-0000-0000-0000-000000000010", true, "Purchasing.ProcessSupplierReturn", "Process purchase-order supplier return" },
                    { "66666666-0000-0000-0000-000000000014", "55555555-0000-0000-0000-000000000010", true, "Purchasing.CancelPurchaseOrder", "Cancel purchase order" },
                    { "66666666-0000-0000-0000-000000000015", "55555555-0000-0000-0000-000000000011", true, "Sales.ProcessReturn", "Process sale return" },
                    { "66666666-0000-0000-0000-000000000016", "55555555-0000-0000-0000-000000000011", true, "Sales.VoidSale", "Void sale" },
                    { "66666666-0000-0000-0000-000000000017", "55555555-0000-0000-0000-000000000012", true, "Receivables.ProcessCustomerPayment", "Process customer payment" }
                });

            migrationBuilder.InsertData(
                table: "RoleComponentPermissions",
                columns: new[] { "ComponentId", "RoleId", "CanCreate", "CanDelete", "CanRead", "CanUpdate", "CanView" },
                values: new object[,]
                {
                    { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000001", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000002", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000003", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000003", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000003", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000003", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000003", false, false, false, false, false },
                    { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000003", false, false, false, false, false },
                    { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000004", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000004", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000005", true, false, true, true, true },
                    { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000005", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000005", false, false, false, false, false },
                    { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000006", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000006", false, false, false, false, false },
                    { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000007", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000007", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000007", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000007", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000007", true, true, true, true, true },
                    { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000007", false, false, false, false, false },
                    { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000008", true, false, true, true, true },
                    { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000008", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000008", false, false, true, false, true },
                    { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000008", true, false, true, true, true },
                    { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000008", false, false, true, true, true },
                    { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000008", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "RoleTaskPermissions",
                columns: new[] { "RoleId", "TaskId", "IsAllowed" },
                values: new object[,]
                {
                    { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000012", true },
                    { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000013", true },
                    { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000014", true },
                    { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000015", true },
                    { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000016", true },
                    { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000017", true },
                    { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000012", true },
                    { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000013", true },
                    { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000014", true },
                    { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000015", true },
                    { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000016", true },
                    { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000017", true },
                    { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000012", true },
                    { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000013", true },
                    { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000014", true },
                    { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000015", false },
                    { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000016", false },
                    { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000017", false },
                    { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000012", true },
                    { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000013", true },
                    { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000014", true },
                    { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000015", true },
                    { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000016", true },
                    { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000017", true },
                    { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000012", false },
                    { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000013", false },
                    { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000014", false },
                    { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000015", false },
                    { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000016", false },
                    { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000017", false },
                    { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000012", false },
                    { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000013", false },
                    { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000014", false },
                    { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000015", false },
                    { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000016", false },
                    { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000017", false },
                    { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000012", false },
                    { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000013", false },
                    { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000014", false },
                    { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000015", true },
                    { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000016", true },
                    { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000017", true },
                    { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000012", false },
                    { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000013", false },
                    { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000014", false },
                    { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000015", true },
                    { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000016", false },
                    { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000017", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000001" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000001" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000001" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000001" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000001" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000001" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000002" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000002" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000002" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000002" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000002" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000002" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000003" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000003" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000003" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000003" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000003" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000003" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000004" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000005" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000005" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000005" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000005" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000005" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000005" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000006" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000006" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000006" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000006" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000006" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000006" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000007" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000007" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000007" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000007" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000007" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000007" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000008", "33333333-0000-0000-0000-000000000008" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000009", "33333333-0000-0000-0000-000000000008" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000010", "33333333-0000-0000-0000-000000000008" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000011", "33333333-0000-0000-0000-000000000008" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000012", "33333333-0000-0000-0000-000000000008" });

            migrationBuilder.DeleteData(
                table: "RoleComponentPermissions",
                keyColumns: new[] { "ComponentId", "RoleId" },
                keyValues: new object[] { "55555555-0000-0000-0000-000000000013", "33333333-0000-0000-0000-000000000008" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000012" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000013" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000014" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000015" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000016" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000001", "66666666-0000-0000-0000-000000000017" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000012" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000013" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000014" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000015" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000016" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000002", "66666666-0000-0000-0000-000000000017" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000012" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000013" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000014" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000015" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000016" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000003", "66666666-0000-0000-0000-000000000017" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000012" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000013" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000014" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000015" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000016" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000004", "66666666-0000-0000-0000-000000000017" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000012" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000013" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000014" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000015" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000016" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000005", "66666666-0000-0000-0000-000000000017" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000012" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000013" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000014" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000015" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000016" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000006", "66666666-0000-0000-0000-000000000017" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000012" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000013" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000014" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000015" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000016" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000007", "66666666-0000-0000-0000-000000000017" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000012" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000013" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000014" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000015" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000016" });

            migrationBuilder.DeleteData(
                table: "RoleTaskPermissions",
                keyColumns: new[] { "RoleId", "TaskId" },
                keyValues: new object[] { "33333333-0000-0000-0000-000000000008", "66666666-0000-0000-0000-000000000017" });

            migrationBuilder.DeleteData(
                table: "ApplicationComponents",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000008");

            migrationBuilder.DeleteData(
                table: "ApplicationComponents",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000009");

            migrationBuilder.DeleteData(
                table: "ApplicationComponents",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000013");

            migrationBuilder.DeleteData(
                table: "ApplicationTasks",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000012");

            migrationBuilder.DeleteData(
                table: "ApplicationTasks",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000013");

            migrationBuilder.DeleteData(
                table: "ApplicationTasks",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000014");

            migrationBuilder.DeleteData(
                table: "ApplicationTasks",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000015");

            migrationBuilder.DeleteData(
                table: "ApplicationTasks",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000016");

            migrationBuilder.DeleteData(
                table: "ApplicationTasks",
                keyColumn: "Id",
                keyValue: "66666666-0000-0000-0000-000000000017");

            migrationBuilder.DeleteData(
                table: "ApplicationComponents",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000010");

            migrationBuilder.DeleteData(
                table: "ApplicationComponents",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000011");

            migrationBuilder.DeleteData(
                table: "ApplicationComponents",
                keyColumn: "Id",
                keyValue: "55555555-0000-0000-0000-000000000012");
        }
    }
}
