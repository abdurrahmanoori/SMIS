using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "LoanAccount",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "LoanAccount",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "LoanAccount",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitName",
                table: "LoanAccount",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86f0ba79-e735-4f58-8128-b57631733f9f", "AQAAAAIAAYagAAAAEIlLiTvp5Elt/s5DM/1rAHIPKo4Y1QOXeGOlGHurAZ8KrTHAg817Lj8chxUYUvL5/Q==", "2702a617-1b35-42ea-ba5b-1b48aab9c38d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e63f324-684e-4646-8197-51628ec0e0a9", "AQAAAAIAAYagAAAAECE9ue6ij4FssQhwAwmVDy/jiKQ3KU4MQtMUzTEZcZgfkb1ScGQMzi79q3ICyFNpwA==", "3d628282-532f-49c7-b16d-2bc716985dfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0384c816-fe0c-4ef9-bea1-e7b8931775ca", "AQAAAAIAAYagAAAAEG9afcuJu316uoMFCyNezp1P8rA+w4l9H/fmxF5lpyVRSUDDT3xW646/u4WUI4yR7Q==", "5d2c54d9-8fda-4b8a-9be3-d4007aed7d18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a0d525-4344-4d97-978f-85683c47637c", "AQAAAAIAAYagAAAAEAZt3MKqihdPosRoNhQWV4ln/zmdJzpGMs46FsfZXtxttZ9LB8pcQFwJR9WioaQ0kQ==", "c6e6bc5e-4ba0-488b-95ac-3bb3249bdd18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cf1c00a-ab7f-401a-8a93-cdaae46b09f1", "AQAAAAIAAYagAAAAEPvdf4j0k0Ixw57QRDjLjJUCGhwT78beehyGbsw4rU5V5RfY/E82P7sdcsTgp17gvw==", "a5a646c5-d7c0-41df-b912-c75ceaf33f7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e636a3d-6278-4253-9780-8dab21c759fa", "AQAAAAIAAYagAAAAEAQtELEpTI65RZsrUu+T5ZQneROXz7Ro3qV/9iv8Naifag5akiWxb5tp2LLd+w1gmQ==", "6ec460ca-c6c1-43ca-b566-3bc2a01d445b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f89f3141-bae0-4b42-86ce-8a4e34fc4de8", "AQAAAAIAAYagAAAAEIxzZ9qRYMYPJXrCkDjJPa+XYO3ml3jGCX5fi6Z36fIl0svl3HxA7rtr+Gc0j1hIKA==", "a5df2a44-64f5-4b3c-ac89-1e5c2aa71472" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df1dc132-b3d6-4823-b165-a568c7f008da", "AQAAAAIAAYagAAAAEJk83jw+e+lL30ttx7UqUqfbY2CXCR2xBjROq6JrG7m0VMrNrJpDToJFDiK5HeSzJw==", "0951cd5e-d094-4e3a-a439-7361dc120229" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0ef7534-483b-4215-9ba9-f3079a1244d4", "AQAAAAIAAYagAAAAENpSddXxX36nJq91MuykZNIZT4sYFOuKpNeKX6SxEmX3rAAMA67LF8CtDB/044YAjg==", "b9ec665e-a6bc-4068-a64b-374dd2e0b94d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a90f9e2-e27a-4875-a23e-cda7056840aa", "AQAAAAIAAYagAAAAEL3gN5HS7QahzY54C7v9mX+FnuJ0ux8mo14mdrnZKoH4WTUbG1PoDIfLS/WWEh7Nfw==", "8a64cf04-47b3-45ae-a775-c9c2ff36259f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6be4fce6-9479-40b9-933b-edb2fd10296c", "AQAAAAIAAYagAAAAEIzTqcasNsRP28KlNXn4bqu+CLc9PFCxUyUuRyDk7iGcDTNudfDaghjH0UVPAV7UzQ==", "ea12ec5f-f0dd-4124-9848-f572855c72a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "877b228f-156c-4c79-be09-2725ab9de131", "AQAAAAIAAYagAAAAEIn1+zAqbj9Z3rqnLHniMD2sgFLDqK4YFlZxBe5vFws0hSmMRljVTs4UT6cJa1te+g==", "+8512345634366", "c8ad8d5d-bac0-43a9-accd-499975aff376" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31a43d12-21f9-4d41-af81-14541217f284", "AQAAAAIAAYagAAAAEFRy+y1QGDZ0gkQLJJtMArGarW2LpW5646oy8udTx9KLS904GO0EW7MPsiBAG62FnA==", "accca3da-7aa5-405e-a58e-116706cd8ef5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd8d7e07-08b9-4a2d-9ec6-7a6ab321291a", "AQAAAAIAAYagAAAAEJp3F183m/H5cL/GphG4hpCRoW/5uetJVsZLzI3BR+aLE8eOWkgjX1bi+zeG1JZx5w==", "343c1550-1c67-4f4b-a98d-d8f75668dba3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2552191e-66a2-4268-81c8-71cb958df636", "AQAAAAIAAYagAAAAEP/+JUBt8WrfoQSxNK1HwE8L8jXDCUwdtYdTMbpPAmGRpaBByzn1c+P18QTsdHa8fw==", "0893b60c-769d-42a1-b3c5-d8126baf0727" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(5860), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Unspecified).AddTicks(5890), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(6974), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(7201), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(7207), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Unspecified).AddTicks(7207), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(7208), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Unspecified).AddTicks(7209), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(7210), new DateTimeOffset(new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Unspecified).AddTicks(7210), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 985, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 986, DateTimeKind.Local).AddTicks(4551), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 986, DateTimeKind.Unspecified).AddTicks(4624), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 986, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5614), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 987, DateTimeKind.Unspecified).AddTicks(5615), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(3588), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 987, DateTimeKind.Unspecified).AddTicks(3607), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(4869), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 987, DateTimeKind.Unspecified).AddTicks(4874), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5535), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 987, DateTimeKind.Unspecified).AddTicks(5538), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5560), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 987, DateTimeKind.Unspecified).AddTicks(5577), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5583), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 987, DateTimeKind.Unspecified).AddTicks(5585), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5592), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 987, DateTimeKind.Unspecified).AddTicks(5594), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5599), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 987, DateTimeKind.Unspecified).AddTicks(5601), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5607), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 987, DateTimeKind.Unspecified).AddTicks(5609), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 987, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 980, DateTimeKind.Local).AddTicks(3), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(6), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 980, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 980, DateTimeKind.Local).AddTicks(166), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 980, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 980, DateTimeKind.Local).AddTicks(169), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(171), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 980, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(531), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(831), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(835), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "CustomerName", "DueDate", "LastModifiedUtc", "LoanDate", "ProductName", "ShopName", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 407, DateTimeKind.Local).AddTicks(1202), "John Doe", new DateTime(2026, 3, 16, 9, 44, 35, 406, DateTimeKind.Utc).AddTicks(8475), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 407, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 9, 44, 35, 406, DateTimeKind.Utc).AddTicks(8474), "Coca Cola", "Main Wholesale Shop", "Bottle", new DateTime(2026, 2, 14, 14, 14, 35, 407, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "CustomerName", "DueDate", "LastModifiedUtc", "LoanDate", "ProductName", "ShopName", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 407, DateTimeKind.Local).AddTicks(5080), "Jane Smith", new DateTime(2026, 3, 1, 9, 44, 35, 407, DateTimeKind.Utc).AddTicks(5077), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 407, DateTimeKind.Unspecified).AddTicks(5091), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 9, 44, 35, 407, DateTimeKind.Utc).AddTicks(5077), "Oreo Biscuit", "Main Wholesale Shop", "Bottle", new DateTime(2026, 2, 14, 14, 14, 35, 407, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "CustomerName", "LastModifiedUtc", "LoanDate", "ProductName", "ShopName", "UnitName", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 407, DateTimeKind.Local).AddTicks(6073), "John Doe", new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 407, DateTimeKind.Unspecified).AddTicks(6082), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 9, 44, 35, 407, DateTimeKind.Utc).AddTicks(6071), "Notebook A4", "Downtown Retail", "Piece", new DateTime(2026, 2, 14, 14, 14, 35, 407, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 982, DateTimeKind.Local).AddTicks(6258), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 982, DateTimeKind.Unspecified).AddTicks(6271), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 982, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3196), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3198), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3203), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3217), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3218), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3223), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3225), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3229), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3235), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3238), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3244), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3245), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 983, DateTimeKind.Local).AddTicks(9694), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 983, DateTimeKind.Unspecified).AddTicks(9708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 983, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(1995), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(2007), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3066), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3071), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3102), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3103), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3147), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3149), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3155), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3162), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3171), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3173), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3187), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 984, DateTimeKind.Unspecified).AddTicks(3190), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 984, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 396, DateTimeKind.Local).AddTicks(9395), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 397, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 397, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(574), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(579), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(583), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(584), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(598), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(603), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(609), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(611), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(613), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(616), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(617), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(620), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(621), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(624), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(625), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(628), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 397, DateTimeKind.Local).AddTicks(9309), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 397, DateTimeKind.Unspecified).AddTicks(9320), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 397, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(629), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(632), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(634), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(636), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(638), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(642), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(643), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(647), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(651), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(654), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(656), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(660), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(663), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(664), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(668), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(669), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(672), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(72), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(83), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(673), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(679), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(682), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(683), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(687), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(691), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(692), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(695), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(696), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(699), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(700), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(703), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(705), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(709), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(713), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(715), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(718), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(521), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(526), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(719), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(723), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(733), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(738), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(739), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(744), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(748), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(751), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(752), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(756), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(757), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(760), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(532), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(535), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(536), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(544), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(545), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(549), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(550), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(553), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(555), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 398, DateTimeKind.Unspecified).AddTicks(558), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 394, DateTimeKind.Unspecified).AddTicks(8165), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8463), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8468), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8473), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8484), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8488), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8492), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8497), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8513), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8518), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(6864), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8523), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8529), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8534), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8539), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8543), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8548), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8552), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8557), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8562), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8568), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(7927), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8572), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8581), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8585), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8590), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8606), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8615), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8418), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8620), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8629), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8634), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8638), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8648), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8653), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8450), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 395, DateTimeKind.Unspecified).AddTicks(8459), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(8724), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9105), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9108), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9109), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9065), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9094), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9097), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9099), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9102), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(9103), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(8230), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(8354), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(8356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(8357), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(8358), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(8359), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 980, DateTimeKind.Local).AddTicks(9866), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(9877), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 980, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 982, DateTimeKind.Local).AddTicks(826), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 982, DateTimeKind.Unspecified).AddTicks(845), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 982, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 982, DateTimeKind.Local).AddTicks(1616), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 982, DateTimeKind.Unspecified).AddTicks(1625), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 982, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(4459), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 400, DateTimeKind.Unspecified).AddTicks(4473), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(4456), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 406, DateTimeKind.Local).AddTicks(5107), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 406, DateTimeKind.Unspecified).AddTicks(5142), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 406, DateTimeKind.Local).AddTicks(5101), new DateTime(2026, 2, 14, 14, 14, 35, 406, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 406, DateTimeKind.Local).AddTicks(5945), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 406, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 406, DateTimeKind.Local).AddTicks(5944), new DateTime(2026, 2, 14, 14, 14, 35, 406, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(4860), new DateTime(2026, 8, 14, 9, 44, 35, 398, DateTimeKind.Utc).AddTicks(2785), new DateTime(2026, 2, 4, 9, 44, 35, 398, DateTimeKind.Utc).AddTicks(2744), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(8861), new DateTime(2026, 9, 14, 9, 44, 35, 398, DateTimeKind.Utc).AddTicks(8846), new DateTime(2026, 2, 9, 9, 44, 35, 398, DateTimeKind.Utc).AddTicks(8845), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(9799), new DateTime(2026, 5, 14, 9, 44, 35, 398, DateTimeKind.Utc).AddTicks(9792), new DateTime(2026, 1, 30, 9, 44, 35, 398, DateTimeKind.Utc).AddTicks(9790), new DateTime(2026, 2, 14, 14, 14, 35, 398, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 399, DateTimeKind.Local).AddTicks(476), new DateTime(2026, 1, 25, 9, 44, 35, 399, DateTimeKind.Utc).AddTicks(470), new DateTime(2026, 2, 14, 14, 14, 35, 399, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 399, DateTimeKind.Local).AddTicks(4305), new DateTime(2026, 2, 14, 14, 14, 35, 399, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1577), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 399, DateTimeKind.Local).AddTicks(9377), new DateTime(2026, 2, 14, 14, 14, 35, 399, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(660), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1521), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1536), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1544), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1551), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1564), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1571), new DateTime(2026, 2, 14, 14, 14, 35, 400, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(2826), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(2847), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3147), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(3149), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3150), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(3159), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3160), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(3161), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3162), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(3163), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3164), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(3166), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3166), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(3168), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3168), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(3170), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5070), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5079), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5380), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5381), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5382), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5384), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5385), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5322), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5324), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5325), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5330), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5331), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5333), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5334), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5335), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5336), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5337), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5359), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5360), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5361), new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 979, DateTimeKind.Unspecified).AddTicks(5362), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 14, 14, 14, 35, 979, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(2623), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(7615), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(7096), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(7576), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(7590), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(7604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 14, 9, 44, 35, 980, DateTimeKind.Unspecified).AddTicks(7610), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "UnitName",
                table: "LoanAccount");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ba020ee-6736-41d5-8157-037630263e39", "AQAAAAIAAYagAAAAENmxNBbe8u2EjUf2WnObg4dYfy2cWw83s3gIWiN1xJY2lskyZRvL1Sow7VhKapD/UA==", "e9a8f382-2cdd-4608-baa7-c9571964a02a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f16fd5e-5c20-4d30-83cd-f70606f32095", "AQAAAAIAAYagAAAAEEGCPn0Ocgog/D23KLdKVCpgLyM3CrxWdxizXCRvjuo6xlQRUOtAb+li1ExnLwI+AQ==", "eb0f17c2-538c-4602-9ea5-8b705ecdcf02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff745d71-9135-40de-965d-3430bff38954", "AQAAAAIAAYagAAAAEFzJ+bEK2NSaUEsfCX1CDg+7vstv+y5SOCzm/Q7MK0QLPCOxsjVoOD3YqaU6JaJvoA==", "ba01bfb1-87d1-40aa-b5fd-2ea577c9ea67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e99a15f-4244-4b7c-9091-b7eb39161dae", "AQAAAAIAAYagAAAAEOsT62O8L4YrOdNISygb0nW/dc7g5HAhEvNl4cPa4cC4wIStlI+fxlnD0FY0Mh5RDA==", "f64d378c-ddce-43e3-9591-60e38d120ae7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f1a8fc4-95cf-4baf-a505-dacd1f631faa", "AQAAAAIAAYagAAAAEO9XoX564hfp7X+RSuwhBDuOL4RJD22ZiQcauJcXnZR65yFs47SjogSuIlkqQWrMyg==", "5d0da871-830e-4ffd-b128-d3c6464150bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b94098c7-5c85-4686-95bc-720b2cbcc180", "AQAAAAIAAYagAAAAEF6VOmH0zjfi5BRv4KSTT1wfkU3kv3p1q6zAnuajAqdyyrfkIE6/RamLEWDwj4w6BA==", "fab5fc9a-60cd-46e1-928c-5f185792e683" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4316b54-19b0-413d-9a93-a333ba48f959", "AQAAAAIAAYagAAAAEHCYeh2u0qh1lqzl7HKPk7s3maZcU7/hdnbqBmZJKgoYFZpLfyB0mhRhxftEWPjHjA==", "cd082d70-66bc-4e29-a6ff-bf4686254eb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "674a8ab1-7a38-4075-a25d-83ca24dfb445", "AQAAAAIAAYagAAAAEO8FvToZm03QqidIQ1hev4/1rMJ/9mtyFeA+EXPySH7N3Z0rtvch7TXpUDDCX+zrdw==", "35c9e261-84f0-4b6e-82a7-805aaa3f2327" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d989218-c360-45fc-bbc3-b08dff2f640d", "AQAAAAIAAYagAAAAED5cMoyqGKYfVMTqhbA9GsN6iPIJYmP5/xhXsF62+5rNk6vwLmxrzwYC90MYpHT70g==", "eba31eb3-1171-4171-b674-86aadeb7306d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51dbf6fc-430a-43fa-b262-6de25fb8f0a3", "AQAAAAIAAYagAAAAEOYc1OzUYopaTG+U+ZNriNVYaQ2lWKJPQSCPqdtehEhTQR2ZqMEteym2KK2OblVaEg==", "3f5518e2-dfa1-4ce1-827f-8a5c302c2e14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae19688e-ac8c-4cec-9352-f83b4ca0fdd4", "AQAAAAIAAYagAAAAEPAOslESVp23uM00FuPJynu2XWH+jp8YqM9PU2DRo/fbpoUE5JCCj99VzrZYrEql7A==", "c2b2e18e-91ad-46cf-bbab-d6c866cb3a5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "0752e067-5273-47a3-89c0-e90b6a685aba", "AQAAAAIAAYagAAAAEGEo7l0ZcYIhPxlDVHkIaDzGXTVEX6BMVQLs1v2wYk8vENa2mWnHT8osHWWszVwMow==", "+855123456794", "a5a3b330-b8f0-4939-ad1a-1c433cb36bf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04b29cb5-31a6-4b50-aef4-1b75e2ee8fe1", "AQAAAAIAAYagAAAAEHxqRYVadBq2QVuPs2VHgZ/9abgC6yaRLR1hjmo7jH59XxLaeHHEu9oIonD7soiyEA==", "11f98dab-7ab5-4b2d-98f6-7547ba7a65f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2930fd9-5d25-4a0d-9c23-4a36f9bcda25", "AQAAAAIAAYagAAAAEGs4f/MaS4hEG/uIU+tRX+6HoyRVlzcgX0/qtOBm8NrmySb99YAToM3lxtF+5y/gaA==", "281f94ee-1ebf-4180-a0f9-99b2b0d4b76f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa114aa4-eb73-476f-bf54-87f5033c29bd", "AQAAAAIAAYagAAAAEGCkikinRT9Ze5oxpoKJ0xf8/sSQ/3+wBszeLTo0NR/iXqN7/ZnncbLPTZCOeoMNMQ==", "677d0807-a13a-4c98-8e39-d8b98422ee01" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 347, DateTimeKind.Local).AddTicks(1494), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 347, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 347, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6634), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6641), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6662), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6665), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6666), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6668), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6669), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6670), new DateTimeOffset(new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 348, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 349, DateTimeKind.Local).AddTicks(3819), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 349, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 349, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9407), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9410), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(5827), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(7835), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(7847), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9234), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9245), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9316), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9319), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9331), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9333), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9348), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9350), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9360), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9362), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9373), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 350, DateTimeKind.Unspecified).AddTicks(9382), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 350, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(8997), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9560), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(9570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9572), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 334, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 334, DateTimeKind.Unspecified).AddTicks(8112), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 334, DateTimeKind.Unspecified).AddTicks(8116), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 716, DateTimeKind.Local).AddTicks(3093), new DateTime(2026, 3, 11, 17, 59, 35, 715, DateTimeKind.Utc).AddTicks(7183), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 716, DateTimeKind.Unspecified).AddTicks(3119), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 59, 35, 715, DateTimeKind.Utc).AddTicks(7182), new DateTime(2026, 2, 9, 22, 29, 35, 716, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 717, DateTimeKind.Local).AddTicks(9932), new DateTime(2026, 2, 24, 17, 59, 35, 717, DateTimeKind.Utc).AddTicks(9862), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 718, DateTimeKind.Unspecified).AddTicks(13), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 59, 35, 717, DateTimeKind.Utc).AddTicks(9860), new DateTime(2026, 2, 9, 22, 29, 35, 717, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 718, DateTimeKind.Local).AddTicks(3164), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 718, DateTimeKind.Unspecified).AddTicks(3194), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 17, 59, 35, 718, DateTimeKind.Utc).AddTicks(3154), new DateTime(2026, 2, 9, 22, 29, 35, 718, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 342, DateTimeKind.Local).AddTicks(8856), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 342, DateTimeKind.Unspecified).AddTicks(8896), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 342, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7173), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7184), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7195), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7207), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7209), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7230), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7241), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7244), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7253), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 345, DateTimeKind.Local).AddTicks(9759), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 345, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 345, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(4296), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(4381), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7029), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7041), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7092), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7095), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7106), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7118), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7120), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7130), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7146), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 346, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 346, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 683, DateTimeKind.Local).AddTicks(8150), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 685, DateTimeKind.Unspecified).AddTicks(7013), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 685, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2462), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2465), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2472), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2475), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2480), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2484), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2489), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2498), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2507), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2512), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2521), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2546), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2556), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2569), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2578), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2582), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 686, DateTimeKind.Local).AddTicks(9019), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 686, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 686, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2587), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2596), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2599), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2604), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2616), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2620), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2625), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2628), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2633), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2642), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2654), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2657), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2689), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2694), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2700), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2704), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2709), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2713), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(1012), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(1029), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2717), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2741), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2745), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2769), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2772), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2777), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2786), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2789), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2794), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2798), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2803), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2806), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2811), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2815), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2820), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2826), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2832), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2835), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2307), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2322), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2840), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2843), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2849), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2852), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2858), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2861), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2866), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2875), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2884), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2887), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2892), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2904), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2908), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2347), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2351), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2359), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2386), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2390), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2442), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2453), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 687, DateTimeKind.Unspecified).AddTicks(2457), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 687, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 679, DateTimeKind.Unspecified).AddTicks(1163), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(748), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(768), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(773), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(784), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(790), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 680, DateTimeKind.Unspecified).AddTicks(7940), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(797), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(810), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(822), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(828), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(885), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 680, DateTimeKind.Unspecified).AddTicks(9722), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(896), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(903), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(919), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(936), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(942), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(950), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(955), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(968), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(986), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(992), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(997), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(1005), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(1011), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(669), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(710), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 681, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(5676), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6932), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6938), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6879), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6906), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6918), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6925), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(6928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4218), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(4231), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4586), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(4594), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4596), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(4599), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4612), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 336, DateTimeKind.Unspecified).AddTicks(4614), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 336, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 338, DateTimeKind.Local).AddTicks(7867), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(7883), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 338, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 341, DateTimeKind.Local).AddTicks(5316), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 341, DateTimeKind.Unspecified).AddTicks(5388), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 341, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 341, DateTimeKind.Local).AddTicks(7590), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 341, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 341, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 696, DateTimeKind.Local).AddTicks(3771), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 696, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 696, DateTimeKind.Local).AddTicks(3723), new DateTime(2026, 2, 9, 22, 29, 35, 696, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(7210), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 714, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(7197), new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(9811), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 35, 714, DateTimeKind.Unspecified).AddTicks(9827), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(9806), new DateTime(2026, 2, 9, 22, 29, 35, 714, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 688, DateTimeKind.Local).AddTicks(5678), new DateTime(2026, 8, 9, 17, 59, 35, 687, DateTimeKind.Utc).AddTicks(8577), new DateTime(2026, 1, 30, 17, 59, 35, 687, DateTimeKind.Utc).AddTicks(8491), new DateTime(2026, 2, 9, 22, 29, 35, 688, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 690, DateTimeKind.Local).AddTicks(4127), new DateTime(2026, 9, 9, 17, 59, 35, 690, DateTimeKind.Utc).AddTicks(4046), new DateTime(2026, 2, 4, 17, 59, 35, 690, DateTimeKind.Utc).AddTicks(4039), new DateTime(2026, 2, 9, 22, 29, 35, 690, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 690, DateTimeKind.Local).AddTicks(7957), new DateTime(2026, 5, 9, 17, 59, 35, 690, DateTimeKind.Utc).AddTicks(7919), new DateTime(2026, 1, 25, 17, 59, 35, 690, DateTimeKind.Utc).AddTicks(7915), new DateTime(2026, 2, 9, 22, 29, 35, 690, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 691, DateTimeKind.Local).AddTicks(686), new DateTime(2026, 1, 20, 17, 59, 35, 691, DateTimeKind.Utc).AddTicks(651), new DateTime(2026, 2, 9, 22, 29, 35, 691, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 692, DateTimeKind.Local).AddTicks(4173), new DateTime(2026, 2, 9, 22, 29, 35, 692, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4400), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 694, DateTimeKind.Local).AddTicks(5013), new DateTime(2026, 2, 9, 22, 29, 35, 694, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(295), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4214), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4299), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4323), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4341), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4361), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4381), new DateTime(2026, 2, 9, 22, 29, 35, 695, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(1890), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(1916), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2848), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2880), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2883), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2885), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2886), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2901), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2903), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2904), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2906), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2907), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2909), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2911), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(2913), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(7269), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8323), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8327), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8330), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8334), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8232), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8244), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8270), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8272), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8280), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8281), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8283), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8284), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8286), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8288), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8315), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8317), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8319), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8320), new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 335, DateTimeKind.Unspecified).AddTicks(8322), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 22, 29, 37, 335, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 337, DateTimeKind.Unspecified).AddTicks(4183), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(4007), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3948), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3970), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3974), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3978), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 17, 59, 37, 338, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
