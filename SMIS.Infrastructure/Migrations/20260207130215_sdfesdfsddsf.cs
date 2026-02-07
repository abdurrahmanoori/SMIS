using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfesdfsddsf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanAccount",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: false),
                    ShopId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", precision: 18, scale: 2, nullable: false),
                    UnitId = table.Column<string>(type: "TEXT", nullable: false),
                    TotalAmount = table.Column<long>(type: "INTEGER", nullable: false),
                    LoanDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanAccount_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanAccount_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanAccount_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanAccount_UnitOfMeasure_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitOfMeasure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoanAccountPayment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    LoanAccountId = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<long>(type: "INTEGER", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PaymentMethod = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    EntityState = table.Column<string>(type: "TEXT", nullable: false),
                    LastModifiedUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanAccountPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanAccountPayment_LoanAccount_LoanAccountId",
                        column: x => x.LoanAccountId,
                        principalTable: "LoanAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c43902e1-171a-4992-bd0f-0caecab325c6", "AQAAAAIAAYagAAAAEDT7DZaT3ZxMAtSTVfT1uZ0o2oA8aaE6DVPnO3+8qgNyQOT1M7UXX69VZLSNX8Y+kw==", "20d7da3d-39b3-4982-990c-14925951d9f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef74686-ff93-4ca6-8d52-44d7cee1bbe0", "AQAAAAIAAYagAAAAEJuxFv2kPqYjQHlq1bv6SxB0FHSghHvNhezbGv9AWpM6aQV5+NoealxndHzbhApAjA==", "268c48af-5c0f-4765-a3f0-79d43dbe1ad2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aa62d64-4fec-409e-b465-7c8d7bedc7fc", "AQAAAAIAAYagAAAAEC3WQ4L2oze0S2gAxxZFCPEZRiu/MqpnZrOXzcn6Ow27pJpO9MxPcmmqK7BFxw6Gaw==", "1bf9766f-1399-40e0-a3d4-761b58c057fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be52035a-30bf-4f39-9cbb-f1e7b77e640e", "AQAAAAIAAYagAAAAEBgsus+7qEJfl0VYqLg+0kcSgooKHVplNfNkk2ZXu5ggmCGn7XFSm91/IlO4h50PQg==", "9710950b-a725-445c-b967-fc39383a822c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa8f1067-5a25-4287-a70e-388f2ee76218", "AQAAAAIAAYagAAAAEAUiOgycEuS4y2JMpYdL8VdRgsKD0U6tWenwuVSJsgWhQHX9ZD8Z4bWEq/FQyhecVQ==", "11df953a-9302-4977-801c-e0b32fae2fe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3966ce8e-5c34-4b3b-8a25-e577a60ed900", "AQAAAAIAAYagAAAAEEbO1SNAOvyE5VgUazvg+Ho8vJY9o8U4XkTU1Iewakcw6H3QGBSOI6D1+mblJnZmYQ==", "069d4cbf-c369-43b6-a803-fd0a69719291" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ac92d57-57f2-4f14-9d5a-7c1da31f04e2", "AQAAAAIAAYagAAAAEPeQw/l9PDRzOd8hmtVgKB+IK3a1AgCFJk2Zef/CKhNHqObJ462k/ZUd6NJtDNfUIA==", "8cf3a02c-8319-46ef-a627-03f8a085432c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e71233ee-ba36-4970-a907-a8391418a651", "AQAAAAIAAYagAAAAEErtqZ69uODNmeRFa+p2WMXl7BJi23C4zj16yak/6pF2VwA8nq8+GWTWaFmgPBT8nQ==", "874d3e42-3279-4ba0-9203-3bc88806a872" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd1f1545-9b38-4646-af51-3420375c6a9a", "AQAAAAIAAYagAAAAEGLEbc4QZnCkqzhWeMb0fEm1xpP78BDyvK8Vt8moKdsNAsmIlFT3EdIwNWox7tiYTw==", "f444cb66-e320-4f66-b8df-92a65aadfa1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9e5b472-649b-4172-8ab3-44e6137a4832", "AQAAAAIAAYagAAAAECt07GmiXm2AAUsHn8uHJqyeleSIYDOpda40AuwC7M/QwaLbAT0wHTfIGASfEAZXlg==", "ff084895-c13f-42a4-aae5-e19b859212bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ee27002-377a-44d5-a299-2caf6fd0bf72", "AQAAAAIAAYagAAAAENob4RY8JxfsQ9yT8Lb8MiIB/ybnlg4Yd+wU1CKgePwOecOUnEr5I1BmCoP/omUBew==", "625e1773-cbff-4a4c-a584-67abbee5c914" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "466b1486-353c-490d-90a1-25e0f1befbf0", "AQAAAAIAAYagAAAAEKI++c8ejsecWyyw6pymS96iosLfAGRWA21A/gqXCd8uxgg8cs/WWrgmUmZgJlC4ow==", "b88c83de-6128-4062-9d84-97ba01666a95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f462a390-5931-4582-9fab-6b4c65db5781", "AQAAAAIAAYagAAAAENqBmIvQRUzRcvEHyt38FMn9/Ot4DjsTZQYgKHGHCvtK75MorcKHq/SsNtgWRur26A==", "0b89075c-049d-4633-8733-a5be0268473f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86b43119-c8cc-48b7-8235-28bae76d1ab0", "AQAAAAIAAYagAAAAEErpLevQuehiNV4M4AZGiosB9UQZam4uDA3M9MxCj+I9XDAQRFICvCsi3+SAblneig==", "ffe56914-70a9-4278-94d6-e1ef11797175" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2473487-4a0c-4886-bf51-716b00f85b10", "AQAAAAIAAYagAAAAEEEQuNzqzrc3CbUCyp2d61Z0s8mAQvHZ1jEGtzRP6l1RXCu2QfnlWz/r9Ih9FaaZig==", "a5cc74e5-f3a1-4c20-ba37-9d21e4236ff1" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(8794), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6852), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Unspecified).AddTicks(6855), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6865), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Unspecified).AddTicks(6866), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6867), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Unspecified).AddTicks(6868), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6868), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6869), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Unspecified).AddTicks(6870), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 728, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(487), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6596), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(6597), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(5109), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(5118), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(5945), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(5950), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6531), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(6533), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6549), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(6550), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6562), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(6569), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6576), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6583), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6590), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 729, DateTimeKind.Unspecified).AddTicks(6592), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 729, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 722, DateTimeKind.Local).AddTicks(672), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 722, DateTimeKind.Unspecified).AddTicks(685), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 722, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 722, DateTimeKind.Local).AddTicks(978), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 722, DateTimeKind.Unspecified).AddTicks(981), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 722, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 722, DateTimeKind.Local).AddTicks(983), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 722, DateTimeKind.Unspecified).AddTicks(984), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 722, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 720, DateTimeKind.Unspecified).AddTicks(7509), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 720, DateTimeKind.Unspecified).AddTicks(7952), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 720, DateTimeKind.Unspecified).AddTicks(7956), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "LoanAccount",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "DueDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "LoanDate", "Notes", "ProductId", "Quantity", "ShopId", "Status", "TotalAmount", "UnitId", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "1", null, new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(2019), "1", new DateTime(2026, 3, 9, 13, 2, 14, 123, DateTimeKind.Utc).AddTicks(8427), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Unspecified).AddTicks(2049), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 13, 2, 14, 123, DateTimeKind.Utc).AddTicks(8425), "First loan for Coca Cola", "1", 10m, "1", "Active", 50000L, "3", null, new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(2025), 0 },
                    { "2", null, new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(6363), "2", new DateTime(2026, 2, 22, 13, 2, 14, 124, DateTimeKind.Utc).AddTicks(6356), "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Unspecified).AddTicks(6376), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Utc).AddTicks(6356), "Oreo biscuits loan", "4", 5m, "1", "Active", 25000L, "3", null, new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(6365), 0 },
                    { "3", null, new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(7733), "1", null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Unspecified).AddTicks(7743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Utc).AddTicks(7730), "Notebook purchase", "7", 20m, "2", "Active", 100000L, "1", null, new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(7734), 0 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 726, DateTimeKind.Local).AddTicks(671), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 726, DateTimeKind.Unspecified).AddTicks(681), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 726, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6738), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6740), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6745), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6746), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6757), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6758), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6763), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6769), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6772), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6777), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6778), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6783), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(4277), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(4289), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(5719), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6631), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6656), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6658), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6691), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6705), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6717), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6718), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6723), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 727, DateTimeKind.Unspecified).AddTicks(6724), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 727, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 111, DateTimeKind.Local).AddTicks(1320), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 111, DateTimeKind.Unspecified).AddTicks(9035), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 111, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3634), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3637), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3639), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3642), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3643), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3648), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3651), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3653), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3659), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3663), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3667), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3668), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3671), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3672), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3676), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(2183), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(2195), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3681), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3685), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3689), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3693), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3140), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3148), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3592), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3602), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3606), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3608), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3620), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3624), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3629), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3632), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 109, DateTimeKind.Unspecified).AddTicks(83), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(651), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(658), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(664), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(669), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(674), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(679), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(700), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(705), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 109, DateTimeKind.Unspecified).AddTicks(8586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(709), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(716), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(739), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(744), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(754), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 109, DateTimeKind.Unspecified).AddTicks(9978), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(759), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(764), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(593), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(618), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(626), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(637), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 110, DateTimeKind.Unspecified).AddTicks(641), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(8451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9124), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9126), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9075), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9108), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9117), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(7346), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(7745), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(7749), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(7751), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(7752), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 723, DateTimeKind.Local).AddTicks(9475), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(9494), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 723, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 725, DateTimeKind.Local).AddTicks(4765), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 725, DateTimeKind.Unspecified).AddTicks(4785), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 725, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 725, DateTimeKind.Local).AddTicks(5542), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 725, DateTimeKind.Unspecified).AddTicks(5546), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 725, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 115, DateTimeKind.Local).AddTicks(1797), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 115, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 115, DateTimeKind.Local).AddTicks(1793), new DateTime(2026, 2, 7, 17, 32, 14, 115, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 123, DateTimeKind.Local).AddTicks(1066), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 123, DateTimeKind.Unspecified).AddTicks(1120), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 123, DateTimeKind.Local).AddTicks(1056), new DateTime(2026, 2, 7, 17, 32, 14, 123, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 123, DateTimeKind.Local).AddTicks(2806), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 123, DateTimeKind.Unspecified).AddTicks(2819), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 123, DateTimeKind.Local).AddTicks(2804), new DateTime(2026, 2, 7, 17, 32, 14, 123, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(7946), new DateTime(2026, 8, 7, 13, 2, 14, 112, DateTimeKind.Utc).AddTicks(5719), new DateTime(2026, 1, 28, 13, 2, 14, 112, DateTimeKind.Utc).AddTicks(5676), new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 113, DateTimeKind.Local).AddTicks(3306), new DateTime(2026, 9, 7, 13, 2, 14, 113, DateTimeKind.Utc).AddTicks(3284), new DateTime(2026, 2, 2, 13, 2, 14, 113, DateTimeKind.Utc).AddTicks(3283), new DateTime(2026, 2, 7, 17, 32, 14, 113, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 113, DateTimeKind.Local).AddTicks(4521), new DateTime(2026, 5, 7, 13, 2, 14, 113, DateTimeKind.Utc).AddTicks(4509), new DateTime(2026, 1, 23, 13, 2, 14, 113, DateTimeKind.Utc).AddTicks(4508), new DateTime(2026, 2, 7, 17, 32, 14, 113, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 113, DateTimeKind.Local).AddTicks(5451), new DateTime(2026, 1, 18, 13, 2, 14, 113, DateTimeKind.Utc).AddTicks(5443), new DateTime(2026, 2, 7, 17, 32, 14, 113, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 113, DateTimeKind.Local).AddTicks(9723), new DateTime(2026, 2, 7, 17, 32, 14, 113, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8490), new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(6069), new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(7268), new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8434), new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8454), new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8463), new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8470), new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8476), new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8484), new DateTime(2026, 2, 7, 17, 32, 14, 114, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 720, DateTimeKind.Local).AddTicks(9962), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 720, DateTimeKind.Unspecified).AddTicks(9979), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 720, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(301), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(304), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(306), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(307), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(308), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(309), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(310), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(311), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(312), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(313), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(322), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2175), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2182), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2484), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2486), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2500), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2501), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2502), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2449), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2451), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2452), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2453), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2454), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2455), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2456), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2457), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2458), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2459), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2460), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2480), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2482), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2482), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 721, DateTimeKind.Unspecified).AddTicks(2484), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 32, 14, 721, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 722, DateTimeKind.Unspecified).AddTicks(5222), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(2760), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(4634), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(5698), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 723, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_CustomerId",
                table: "LoanAccount",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_ProductId",
                table: "LoanAccount",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_ShopId",
                table: "LoanAccount",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccount_UnitId",
                table: "LoanAccount",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAccountPayment_LoanAccountId",
                table: "LoanAccountPayment",
                column: "LoanAccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanAccountPayment");

            migrationBuilder.DropTable(
                name: "LoanAccount");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f89d2f0-f4fd-4353-a252-c92cbab820e9", "AQAAAAIAAYagAAAAEK4ugE66pZcdWtu89S8ptSMslgIwTJES3a1X5J7SzlT+Q4Qi5zW8Lvsh7tpegZnKbQ==", "4e4fa79e-6bd3-420a-9c3a-47924de9fa1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01c2763-c1f5-412c-8a10-f462f8956f1b", "AQAAAAIAAYagAAAAECK3CBTWGcrPF8urwUM63K9oUlADmPv+HJN/+bzeIzx+KcD/s45qIl0skiZS55Q39g==", "64febf48-630b-4b53-b43a-a3617f4c923f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "092196bb-dbb3-40a9-91df-9e741a16cf28", "AQAAAAIAAYagAAAAEPOv2zGMBoUN4lJqHfoIAoDVU/bCVKNuCGtVjkPKN+WExTV833vKaH6tiQbt1X/gSQ==", "891814a1-de99-4d55-800a-40588e2db391" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0988274e-684a-46ed-aeeb-2bac11e6f0f9", "AQAAAAIAAYagAAAAEHgogvmMv/6NNUBM9fPpCmRL5Giix7067wS0sH+LB8dXpoALvcyNYSWauKkwO2mIBA==", "789619d4-8cea-4d11-890a-16b87263d8d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb13304a-158a-43ca-a6b8-67838c0a0673", "AQAAAAIAAYagAAAAEKwsD8OrZlFc8rov+O90oJF3C1k7Eb9CEMmHs8u7j977WB0H7OU3A5BVz6Ov/JN65g==", "b21ba7be-46fe-40e9-949d-eb72ca2da467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e64a1380-9adb-49a2-8101-514048e5fc5f", "AQAAAAIAAYagAAAAEPj453varMLLBVwI4UVZK6CbhA4oIGk05sUyQYMVqV5zMxz/NpnQ7oNXfYjH0dmSnQ==", "dc5ec1c2-0b62-4d71-bed9-bf07929084bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53c7ef50-4d26-4e57-b797-7315c2085ac1", "AQAAAAIAAYagAAAAEIr0hEn2CLMB4A5AlA5Q3vWAaqwxhvKzbPG6LePbUgD8+Ind46EFx62AlJKffy4lOA==", "840083cf-bd4d-4dba-8ef9-417451a5244b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60fb0a22-0128-4bb4-8cac-5f8b8f800ed9", "AQAAAAIAAYagAAAAEBvtv+rUXbHLG+1p3ZhvZfr8ZqWZUW5VgBakP3hvUAVQ1JyPdhmybK+0/Bw+5VrnJw==", "7d580b14-3495-482d-bca4-d1f4916fccb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22e8a1a9-2b45-46f3-9025-849fec4a1dc2", "AQAAAAIAAYagAAAAECPAbJ5I1F0pLkg7XsUtnmn/DXqJcpBN9EbFfXp7ctFRKqc7NQ2gSOn2i0NtCpHk9w==", "3f46afba-758c-4241-96d0-67fb968a6f15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "108f3d56-2208-4653-91e7-4c39981751df", "AQAAAAIAAYagAAAAEIiNEAnFw2KsVv3iVZQUYyBY9EDESWu4CFYjSbEdwPPfuO58FT4Ddr+e3gNuuDPVsg==", "fed554ef-c330-4607-b8d0-14db5266bc2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6d94301-a853-446f-bb2e-786be47d4ac9", "AQAAAAIAAYagAAAAENUHW38DDV9+V8m9QNYmHzzQXHM7NvqVSKM4v8dUNo7Zc3OZw5xeD3cABXujhmRcTQ==", "b5b0efc7-e5f3-4e12-882e-c1f82cf111f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "800dc567-8f86-4277-90c9-8e4bbe29d7e9", "AQAAAAIAAYagAAAAEKrTB3B5sDWkagJXSuqkJSzPvjqiFmCKiLyWzEZZ0iNCHDsDLZYqVIfISSoEsVytMw==", "ef32b3b7-f59c-413d-b7bd-f797a05bf360" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61403c49-8c33-48ed-8b58-2f5bf4ee7c2d", "AQAAAAIAAYagAAAAEOsmCWI5v1CPap1Lxq+vMXPxgTGsSTjENTbeMsAW/QNXszZuWzfL30OpbMp0756jUQ==", "350ef7fd-bcc3-4413-b4af-c4a328e8fe0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fa005ca-473f-47a8-b032-9d336ce87e95", "AQAAAAIAAYagAAAAEDGrlbpAsPYteM8RP226iqs+feCUluSaKotz3W9MGQ6TVUfeWXO1h7NPDg/D+UZMxA==", "795efcaa-2cab-46a1-81c6-ea8b044752a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca3c0c0a-4288-41f7-83fe-2aff5bbfe865", "AQAAAAIAAYagAAAAEK5zlCjQU65wGb3sIizBipmnRDsAzP+IAXanHb2WdapScg82RmtZ5sCQ2TdffvOR3g==", "52d65e5d-8e89-48d8-a41e-807c31d9bdcd" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(5359), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4541), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4544), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4560), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4562), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4562), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4563), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4563), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4564), new DateTimeOffset(new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Unspecified).AddTicks(4565), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(8367), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 271, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 271, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4473), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(2970), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(2981), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(3853), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(3858), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4401), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4429), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4437), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4438), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4445), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4446), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4452), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4459), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 272, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 272, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(8985), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(9166), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(9168), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(9169), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 262, DateTimeKind.Unspecified).AddTicks(9308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 262, DateTimeKind.Unspecified).AddTicks(9594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 262, DateTimeKind.Unspecified).AddTicks(9606), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 268, DateTimeKind.Local).AddTicks(5131), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 268, DateTimeKind.Unspecified).AddTicks(5161), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 268, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3140), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3141), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3146), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3152), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3155), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3168), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3169), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3174), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3176), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3181), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3188), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(960), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(2199), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(2205), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3066), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3081), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3095), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3097), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3104), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3105), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3112), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3113), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3118), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3119), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3123), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 270, DateTimeKind.Unspecified).AddTicks(3125), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 270, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 588, DateTimeKind.Local).AddTicks(5181), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(2881), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7150), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7154), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7159), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7163), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7167), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7173), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7176), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7177), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7180), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7181), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7184), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7185), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7188), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7189), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7192), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(5685), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7193), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7196), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7197), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7200), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7201), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7205), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(6658), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7109), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7121), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7124), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7126), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7136), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7139), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7140), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7143), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7145), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 589, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 589, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 586, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6298), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6302), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6314), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6333), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6338), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(4608), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6347), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6358), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6373), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6379), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6392), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6402), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(5774), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6271), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 587, DateTimeKind.Unspecified).AddTicks(6293), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8124), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8125), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8110), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8112), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8113), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8115), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(8121), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7151), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7272), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7284), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7285), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7312), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7313), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(7318), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 265, DateTimeKind.Local).AddTicks(2135), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 265, DateTimeKind.Unspecified).AddTicks(2184), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 265, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 267, DateTimeKind.Local).AddTicks(4228), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 267, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 267, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 267, DateTimeKind.Local).AddTicks(5598), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 267, DateTimeKind.Unspecified).AddTicks(5612), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 267, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 592, DateTimeKind.Local).AddTicks(1064), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 592, DateTimeKind.Unspecified).AddTicks(1074), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 592, DateTimeKind.Local).AddTicks(1061), new DateTime(2026, 2, 7, 17, 17, 47, 592, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 598, DateTimeKind.Local).AddTicks(9604), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 598, DateTimeKind.Unspecified).AddTicks(9661), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 598, DateTimeKind.Local).AddTicks(9592), new DateTime(2026, 2, 7, 17, 17, 47, 598, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 599, DateTimeKind.Local).AddTicks(824), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 47, 599, DateTimeKind.Unspecified).AddTicks(851), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 47, 599, DateTimeKind.Local).AddTicks(821), new DateTime(2026, 2, 7, 17, 17, 47, 599, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(1632), new DateTime(2026, 8, 7, 12, 47, 47, 589, DateTimeKind.Utc).AddTicks(9466), new DateTime(2026, 1, 28, 12, 47, 47, 589, DateTimeKind.Utc).AddTicks(9412), new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(5673), new DateTime(2026, 9, 7, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(5661), new DateTime(2026, 2, 2, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(5657), new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(6592), new DateTime(2026, 5, 7, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(6582), new DateTime(2026, 1, 23, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(6582), new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(7254), new DateTime(2026, 1, 18, 12, 47, 47, 590, DateTimeKind.Utc).AddTicks(7248), new DateTime(2026, 2, 7, 17, 17, 47, 590, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(897), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8198), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(6280), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(7365), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8151), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8163), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8171), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8178), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8184), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8191), new DateTime(2026, 2, 7, 17, 17, 47, 591, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(1766), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(1784), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2074), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2076), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2078), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2080), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2081), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2082), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2083), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2084), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2085), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2086), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2087), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2088), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(3987), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4340), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4342), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4343), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4344), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4292), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4295), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4297), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4297), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4299), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4301), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4301), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4303), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4303), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4331), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4332), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4338), new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 263, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 17, 17, 48, 263, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(1346), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(5177), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8220), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8240), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8243), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 7, 12, 47, 48, 264, DateTimeKind.Unspecified).AddTicks(8252), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
