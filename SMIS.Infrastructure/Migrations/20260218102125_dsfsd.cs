using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class dsfsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Translations",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Translations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "TranslationKeys",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "TranslationKeys",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "ShopOwner",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "ShopOwner",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Shop",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Shop",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Provinces",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Provinces",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "ProductPrice",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "ProductPrice",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Product",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "LoanAccountPayment",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "LoanAccountPayment",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "LoanAccount",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "LoanAccount",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Districts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Districts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "Customers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncedToServer",
                table: "AppLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSyncedAt",
                table: "AppLogs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dcb87f1-2e9e-4827-a2ec-963aa458657a", "AQAAAAIAAYagAAAAEHiquC+13yldGYIRcec98GjGqYbhLBQwomvT1H75goArd9aalBJHX2BDCzaEWsX3EQ==", "6e8e70b2-19da-40d1-9c1b-93bb36994708" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59e7a390-4e74-4902-9a3f-bf076737f849", "AQAAAAIAAYagAAAAENRVCrB1RxCGx2Fx7xeLnbWZJJDqyBK0SlL2vprSmAKKP0amIUt3bnwPzdAb4UpSBw==", "21285f21-00b3-44f7-9753-8fc073c9662d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "722bc9a4-8ac2-4406-9d27-75783d863a42", "AQAAAAIAAYagAAAAEJUjnxDXMYO0cDYGKWdH3fJF/yPVB2JlP5+MLef74Y0HAwf+Esavz4i/KnLqZVlvYQ==", "8cb77aa2-99de-44ca-8636-70916e2faf9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea654379-b4ff-4238-b8ba-841d3b4d8b89", "AQAAAAIAAYagAAAAENF8e1i8KykBMc3NypMHceIT6F9yMBwgHDqooQbXJQJJPcEJ0ML7xaQs/ma10tJjyg==", "e03e8399-5f32-42f4-b112-c673697e58a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "febc2b0c-e23d-41e3-bbb3-51cbe6991784", "AQAAAAIAAYagAAAAEKC+EZP5UKIvjIsd/5JMUPtV4JJRTwubNS7js1WMOfaq40s6dtyj3qHsR516hE3lzw==", "c4076d78-442d-43ce-bd0f-573b69a9d436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8215c60-1856-47fd-a95e-76de91fe832d", "AQAAAAIAAYagAAAAEFpQWZhLdZZLQRfrJqaaOiSmf9FtjEL0IC5W16sUiKRFY7Ck3ZoKePDh/asztgscrg==", "72ec8ec7-2d1d-4aa9-8e5f-406dc5a47724" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4322449b-e0a4-4f65-acd8-339ed6effdd0", "AQAAAAIAAYagAAAAEFzGWqhq1nb/1GLCsUFnNGuNVW+d3zPshjz13xxmx7M6ME0uNryJcoMEyJ3cntUgpw==", "9de26ddf-c6d8-4e60-8ab1-2ca8fab0abde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14c2fd39-6c1f-4110-bd2a-b51929f89394", "AQAAAAIAAYagAAAAEIC5ZI1EDWIY068SMbgUF1Kx5tq7aV3JOYEsgGdervl3pjyuw1LnUeyP9omDOKQfbw==", "67419787-0ba9-4cbd-aff5-ff271aed54de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c6752b8-24a3-4f90-98b6-4bcb1fb1a9fe", "AQAAAAIAAYagAAAAEBAy+xoJriVrAcuhLIJ4n7Sv4DjJzAcL7hqh+rDasq3d6nyyqapphZwBtgXS/KPOwQ==", "559d3c69-f753-4c16-9b77-b748b7d902e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "330532e1-9e63-47a4-a54d-2370a45cc666", "AQAAAAIAAYagAAAAEC9rd0GUrMwqlBWthC68BUqEijibpCTiO+pndLnWbFqkCtYotInttHYAtJFHGUh0bA==", "7df9f963-50e2-4810-8c28-a6f12c43ead2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75cfaafa-8622-4d48-b728-3fc1f0d69267", "AQAAAAIAAYagAAAAEGaHWkl4lTeoPpsE+VLvWQUTSTbEL2Y5pN/kPZEWmFljWVaa6AjWpg8Erlrt/syi1g==", "8a9a6f27-8a64-4fe7-a311-244b06eba81e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "799b271a-a74f-4f1d-a93e-1204be1111d5", "AQAAAAIAAYagAAAAEBXBkeyWzplopDkAFtNWcaKGvAlYQn6Ddmt+LcT1HdJknFSpklrFniEM1AnSymC/QQ==", "ff921be4-60a3-4458-be4a-4ab7768229fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2daf4c50-b85e-4c2f-be81-9f2824b7f572", "AQAAAAIAAYagAAAAEHYmjRrG53vsQk04m1OEmcHCOFhf/hMGFpGK55nHjqfT3ZX7EqoKjTzvXycAtvP0Bg==", "da875027-8412-4b2a-b560-30e120f9ae6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af64df28-a6f2-4379-8d3a-9b34cad8eaea", "AQAAAAIAAYagAAAAEO5fWIjn+q50olPKn5DcgT68heRG++NX52118dyuLeLBOtewAgyk+O0+K4mGePjpzQ==", "476ae383-db5d-46f5-a5ec-06d97281532a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e7f5d51-6614-452e-88ad-0e8264c7fc9e", "AQAAAAIAAYagAAAAEHaRjnIwQY2N63HP5zKF4gJD6oh6LQfutjS3DTw5cBgmCgPEleLHlw2v5v0QpN6pSw==", "dd38e894-65c7-4125-8b75-fa5701d1a559" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(6205), new DateTimeOffset(new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Unspecified).AddTicks(6229), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5329), new DateTimeOffset(new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Unspecified).AddTicks(5334), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5344), new DateTimeOffset(new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Unspecified).AddTicks(5345), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5347), new DateTimeOffset(new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5348), new DateTimeOffset(new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5350), new DateTimeOffset(new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Unspecified).AddTicks(5350), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(9688), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 842, DateTimeKind.Unspecified).AddTicks(9711), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 842, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7413), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 843, DateTimeKind.Unspecified).AddTicks(7415), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(5437), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 843, DateTimeKind.Unspecified).AddTicks(5448), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(6586), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 843, DateTimeKind.Unspecified).AddTicks(6592), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7335), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 843, DateTimeKind.Unspecified).AddTicks(7338), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7361), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 843, DateTimeKind.Unspecified).AddTicks(7363), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7371), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 843, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7382), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 843, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7391), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 843, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7401), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 843, DateTimeKind.Unspecified).AddTicks(7407), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 843, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 836, DateTimeKind.Local).AddTicks(418), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(426), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 836, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 836, DateTimeKind.Local).AddTicks(670), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(672), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 836, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 836, DateTimeKind.Local).AddTicks(673), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(675), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 836, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 834, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 834, DateTimeKind.Unspecified).AddTicks(8206), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 834, DateTimeKind.Unspecified).AddTicks(8208), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 142, DateTimeKind.Local).AddTicks(4014), new DateTime(2026, 3, 20, 10, 21, 24, 142, DateTimeKind.Utc).AddTicks(642), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 142, DateTimeKind.Unspecified).AddTicks(4043), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 1, 19, 10, 21, 24, 142, DateTimeKind.Utc).AddTicks(631), new DateTime(2026, 2, 18, 14, 51, 24, 142, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DueDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8196), new DateTime(2026, 3, 17, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8195), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 143, DateTimeKind.Unspecified).AddTicks(8201), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 15, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8195), new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(3440), new DateTime(2026, 3, 5, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(3436), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 143, DateTimeKind.Unspecified).AddTicks(3460), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 3, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(3434), new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DueDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(6022), new DateTime(2026, 3, 10, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(6018), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 143, DateTimeKind.Unspecified).AddTicks(6034), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 8, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(6016), new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DueDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8076), new DateTime(2026, 4, 4, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8073), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 143, DateTimeKind.Unspecified).AddTicks(8088), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 13, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8072), new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DueDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8114), new DateTime(2026, 2, 28, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8112), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 143, DateTimeKind.Unspecified).AddTicks(8119), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 1, 29, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8112), new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DueDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8130), new DateTime(2026, 3, 8, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8129), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 143, DateTimeKind.Unspecified).AddTicks(8135), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 6, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8129), new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8145), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 143, DateTimeKind.Unspecified).AddTicks(8149), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 1, 24, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8143), new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DueDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8160), new DateTime(2026, 3, 2, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8159), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 143, DateTimeKind.Unspecified).AddTicks(8165), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 1, 31, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8159), new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DueDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8175), new DateTime(2026, 3, 12, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8174), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 143, DateTimeKind.Unspecified).AddTicks(8186), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 10, 10, 21, 24, 143, DateTimeKind.Utc).AddTicks(8174), new DateTime(2026, 2, 18, 14, 51, 24, 143, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 839, DateTimeKind.Local).AddTicks(3710), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 839, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 839, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3674), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3682), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3689), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3696), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3698), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3704), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3706), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3711), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3713), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3718), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(805), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(2438), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(2443), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3594), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3614), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3616), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3629), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3638), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3639), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3646), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3654), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 841, DateTimeKind.Unspecified).AddTicks(3660), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 841, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 128, DateTimeKind.Local).AddTicks(1854), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(710), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 128, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6262), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6267), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6269), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6274), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6276), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6331), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6336), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6338), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6342), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6344), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6350), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6354), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6356), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6363), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6365), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6370), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6372), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6376), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(4693), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(4711), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6394), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6399), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6401), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6408), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6414), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6420), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6426), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6431), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6433), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6438), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6440), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6444), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6446), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6450), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6452), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6456), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(5629), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6458), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6462), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6464), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6470), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6474), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6476), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6481), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6483), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6487), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6489), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6493), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6495), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6501), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6505), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6507), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6511), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6513), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6517), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6211), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6218), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6547), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6552), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6554), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6561), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6562), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6566), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6568), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6572), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6574), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6578), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6580), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6586), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6592), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6596), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6224), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6228), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6231), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6235), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6237), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6242), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6244), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6248), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6250), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 129, DateTimeKind.Unspecified).AddTicks(6260), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 129, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 125, DateTimeKind.Unspecified).AddTicks(4044), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5161), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5168), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5179), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5186), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5191), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5197), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5263), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5270), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(2751), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5288), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5314), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5326), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5331), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(4175), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5348), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5355), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5361), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5366), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5377), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5096), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(6066), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(6107), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(6124), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(6158), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(6181), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5121), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5129), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5136), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5142), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 126, DateTimeKind.Unspecified).AddTicks(5155), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9290), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9292), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9294), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9217), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9223), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9231), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9286), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(9288), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(7981), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(7996), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(8155), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(8157), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(8158), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(8181), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(8182), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 837, DateTimeKind.Local).AddTicks(2928), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 837, DateTimeKind.Unspecified).AddTicks(2942), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 837, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 838, DateTimeKind.Local).AddTicks(6516), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 838, DateTimeKind.Unspecified).AddTicks(6533), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 838, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 838, DateTimeKind.Local).AddTicks(7555), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 838, DateTimeKind.Unspecified).AddTicks(7561), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 838, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 133, DateTimeKind.Local).AddTicks(2791), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 133, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 133, DateTimeKind.Local).AddTicks(2786), new DateTime(2026, 2, 18, 14, 51, 24, 133, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 141, DateTimeKind.Local).AddTicks(3040), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 141, DateTimeKind.Unspecified).AddTicks(3074), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 141, DateTimeKind.Local).AddTicks(3034), new DateTime(2026, 2, 18, 14, 51, 24, 141, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 141, DateTimeKind.Local).AddTicks(4351), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 141, DateTimeKind.Unspecified).AddTicks(4361), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 141, DateTimeKind.Local).AddTicks(4350), new DateTime(2026, 2, 18, 14, 51, 24, 141, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 130, DateTimeKind.Local).AddTicks(2721), new DateTime(2026, 8, 18, 10, 21, 24, 129, DateTimeKind.Utc).AddTicks(9625), new DateTime(2026, 2, 8, 10, 21, 24, 129, DateTimeKind.Utc).AddTicks(9383), new DateTime(2026, 2, 18, 14, 51, 24, 130, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 130, DateTimeKind.Local).AddTicks(8744), new DateTime(2026, 9, 18, 10, 21, 24, 130, DateTimeKind.Utc).AddTicks(8721), new DateTime(2026, 2, 13, 10, 21, 24, 130, DateTimeKind.Utc).AddTicks(8719), new DateTime(2026, 2, 18, 14, 51, 24, 130, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 131, DateTimeKind.Local).AddTicks(528), new DateTime(2026, 5, 18, 10, 21, 24, 131, DateTimeKind.Utc).AddTicks(510), new DateTime(2026, 2, 3, 10, 21, 24, 131, DateTimeKind.Utc).AddTicks(509), new DateTime(2026, 2, 18, 14, 51, 24, 131, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 131, DateTimeKind.Local).AddTicks(1675), new DateTime(2026, 1, 29, 10, 21, 24, 131, DateTimeKind.Utc).AddTicks(1666), new DateTime(2026, 2, 18, 14, 51, 24, 131, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 131, DateTimeKind.Local).AddTicks(6805), new DateTime(2026, 2, 18, 14, 51, 24, 131, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(8029), new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(4818), new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(6544), new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(7910), new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(7929), new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(7992), new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(8002), new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(8011), new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(8020), new DateTime(2026, 2, 18, 14, 51, 24, 132, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(546), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(565), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(957), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(960), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(962), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1028), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(1030), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1031), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(1038), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1039), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(1041), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1042), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1045), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(1046), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(3735), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(3753), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4175), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4177), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4178), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4181), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4182), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4118), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4122), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4123), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4124), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4126), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4127), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4133), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4134), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4136), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4137), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4169), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4170), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4172), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "IsSyncedToServer", "LastModifiedUtc", "LastSyncedAt", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4173), false, new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 835, DateTimeKind.Unspecified).AddTicks(4174), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2026, 2, 18, 14, 51, 24, 835, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(3480), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(9879), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(9794), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(9800), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(9821), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(9868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 18, 10, 21, 24, 836, DateTimeKind.Unspecified).AddTicks(9872), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "TranslationKeys");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "ShopOwner");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "ShopOwner");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "ProductPrice");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "LoanAccountPayment");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "LoanAccountPayment");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "LoanAccount");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsSyncedToServer",
                table: "AppLogs");

            migrationBuilder.DropColumn(
                name: "LastSyncedAt",
                table: "AppLogs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "116a1778-2231-4ff0-a1dc-dad46a2a7945", "AQAAAAIAAYagAAAAEGK7Dsm0kG09VnUl9ISOEk2FR/jW04O2+AY5RF77/IpbSkLDDkWwS1KVq+j7GjOfeg==", "73758633-b240-4926-811c-05f491a63b4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af1d2d5f-f88c-492b-8aef-dc09195b1034", "AQAAAAIAAYagAAAAEEywq37U99t6pEiC2i/urMdn+MWoOSfXfZgS2489JRzYVBKR5/ViyaJQU5zbbw36xw==", "04c7e5c6-ab4a-4bed-8ea3-e77402a30309" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da71b67a-c40e-4ba8-8fed-0884a2584100", "AQAAAAIAAYagAAAAEKbH0x1P/Ijq99EdMFfcmhgzUGnY/5oCzIX3zjvYFczUraO+d8sM/KXGneh/1EHx8w==", "117349ce-cb02-4e3e-ab0a-6d2d27e84671" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e0227ae-2d45-4203-9257-9fc020bb5613", "AQAAAAIAAYagAAAAEC0l/qLnDA0WYxeZXLl/aQI6EpgEk7ssqyMTSht+1cmjbs5/opGFj+taiPlU6VZmag==", "dd850681-0c14-4562-8d3f-a10cf192ba1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65c298e3-ec74-4b73-b11e-c511632460a2", "AQAAAAIAAYagAAAAEO691XKnn7kPWkbTEw8PLXdD5e2+ChRo7glApr/r1URE+fbbhSYUNr5YGW3u3Hfo8g==", "acbc6887-73e2-44e9-9661-a80fb6a08185" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0080e2f4-7577-4519-957e-56e480303947", "AQAAAAIAAYagAAAAEI+udQompQ9cu9U6w+Ksv6BskhwNBoxmSx14G1JQH6NEc3XsCuftq3YLwwZyncCnqA==", "2c2e3ec7-cbfe-4a39-a2d8-d37a54d68f0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90c7d20d-c773-444d-a3bd-3e8959515a3d", "AQAAAAIAAYagAAAAEC8K9NwE4YQZG1d81pjv3nwKOcH9Ht748pGNAg172niR6oDRaqQidTwtFqqN8YyolQ==", "55325cb7-837a-47c5-b85b-516ea62d9add" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af4a16d-020a-4d39-a172-75215215be6a", "AQAAAAIAAYagAAAAEI1+nYTBu5wVhh0fvZIf5GZOLnVkIq7KpBGB2s7B98rBh152IIcSMfoZKOGUEOXJjA==", "e6817c0c-f71a-4fc7-bdae-0a016d43337d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c21d15b3-da84-4289-b044-d8a3b2dd9ed7", "AQAAAAIAAYagAAAAEE4tNR4MUk9OLFnUC0ZtU7vIXs2TA440r6VXMES2CziOvECyT9IrkgZ2ZYRYw22tTA==", "51e31712-bcac-47b0-9d62-b0b7e9fdd236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d1c591e-3492-42b3-ada2-f7dc20d15278", "AQAAAAIAAYagAAAAEOX2Ku+MH+T2gmQUZmC2CynjiIbsFWELZNoZjdkaPi+Uhjq5X+QCsTu9+UTY+W5TrQ==", "9b846c11-fbb9-4331-8a88-32abd54631a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2735fe-8f31-4f5e-b36c-c07016f9304d", "AQAAAAIAAYagAAAAEIpoFl3TYfxKpfq5dnSz3LEnU5uXiCNsyY7XlGojJkntAmU6F0LLpU0lDD7eZAvZCA==", "74a77d1b-470a-439f-a651-a7ab93fb0bb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4992246-6d11-43c0-a673-571bcaa99770", "AQAAAAIAAYagAAAAEOPmYUjkYwPf/0rElh2YsFJk/Xbu0J/kx96oGOMzT39vd05sXqvduDoHN8i5T9ckIQ==", "3a384611-e4b9-4362-b96c-b874637f4ffd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0c969c1-335f-4807-8e80-39198978a77f", "AQAAAAIAAYagAAAAECdnNXsb79G0XO0ql++008nQ+tt4JeuQq2yDjmW6b08L3qQisPiW1Ln6HeF2FtvTYw==", "a63cab62-a05c-46a0-b978-7347d7f59228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "233fe13d-c330-4984-bbb4-0ae88f709231", "AQAAAAIAAYagAAAAELjGJ0Nw2gpCNl4da5CT1TZySTfgCfYhhmbukM5/MUVAk4wvFV8WlYsILY4vF7zi2w==", "7e33497b-7c21-4576-b518-75d8d3f95180" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ce48b07-3da0-4232-9a71-32df8f39509f", "AQAAAAIAAYagAAAAENj6vWmxA9LnNhytgWJ6cLp8ryiu8XjseQ8Gg8IFzxfNhShVFvq/p1XXy6xAURkk7Q==", "d686b0ec-e412-4db8-a18d-ace5c81d8c0d" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(5890), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Unspecified).AddTicks(5914), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7746), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7762), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7763), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7765), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7766), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7768), new DateTimeOffset(new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Unspecified).AddTicks(7769), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 441, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(1840), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(1868), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8091), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(6198), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(7364), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(7999), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8011), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8037), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8042), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8048), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8052), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8060), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8071), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8081), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 442, DateTimeKind.Unspecified).AddTicks(8085), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 442, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6681), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(6688), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6844), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(6848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6860), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(6864), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(7149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(7162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 867, DateTimeKind.Local).AddTicks(6311), new DateTime(2026, 3, 18, 10, 23, 12, 867, DateTimeKind.Utc).AddTicks(3667), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 867, DateTimeKind.Unspecified).AddTicks(6350), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 17, 10, 23, 12, 867, DateTimeKind.Utc).AddTicks(3656), new DateTime(2026, 2, 16, 14, 53, 12, 867, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6165), new DateTime(2026, 3, 15, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6164), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6171), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 13, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6164), new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(2872), new DateTime(2026, 3, 3, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(2869), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 1, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(2867), new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(4696), new DateTime(2026, 3, 8, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(4693), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(4707), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 6, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(4692), new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6080), new DateTime(2026, 4, 2, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6078), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 11, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6077), new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6112), new DateTime(2026, 2, 26, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6105), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6116), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 27, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6104), new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6124), new DateTime(2026, 3, 6, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6123), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 4, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6123), new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6134), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6136), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 22, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6133), new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6144), new DateTime(2026, 2, 28, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6144), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6147), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 1, 29, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6143), new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6155), new DateTime(2026, 3, 10, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6154), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 868, DateTimeKind.Unspecified).AddTicks(6158), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 8, 10, 23, 12, 868, DateTimeKind.Utc).AddTicks(6154), new DateTime(2026, 2, 16, 14, 53, 12, 868, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 438, DateTimeKind.Local).AddTicks(6819), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 438, DateTimeKind.Unspecified).AddTicks(6847), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 438, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3657), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3661), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3668), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3672), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3679), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3689), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3693), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3717), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3730), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3734), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3741), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3745), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(1532), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(1554), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(2746), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3527), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3558), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3578), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3596), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3632), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3636), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3644), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 440, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 440, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 855, DateTimeKind.Local).AddTicks(9215), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(2881), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7115), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7118), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7120), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7142), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7148), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7151), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7152), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7156), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7160), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7163), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7164), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7167), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7168), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7173), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(5623), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7177), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7181), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7182), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7185), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7186), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7189), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7191), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7193), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7195), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7197), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7206), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7210), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7211), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7216), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7219), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7220), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7224), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7225), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7229), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(6581), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(6593), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7230), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7234), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7239), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7243), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7246), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7247), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7250), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7251), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7256), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7261), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7265), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7268), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7269), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7272), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7055), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7068), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7273), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7276), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7281), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7285), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7286), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7289), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7290), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7293), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7294), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7299), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7302), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7303), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7306), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7307), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7074), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7097), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7102), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7105), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7106), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7109), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7111), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 857, DateTimeKind.Unspecified).AddTicks(7114), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 857, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 853, DateTimeKind.Unspecified).AddTicks(6572), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4297), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4310), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4314), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4328), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4351), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4356), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4362), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(2471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4371), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4375), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4384), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4393), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4398), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4404), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4408), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4412), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4417), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "32",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4421), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "33",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "34",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "35",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "36",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "37",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "38",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "39",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4261), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "40",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4457), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "41",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "42",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4465), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "43",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "44",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "45",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4479), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "46",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4484), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "47",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4489), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4278), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 854, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5842), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5845), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5807), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5823), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5827), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5835), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(4925), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(4935), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5049), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5053), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5054), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5057), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5058), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(5064), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 436, DateTimeKind.Local).AddTicks(6656), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(6675), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 436, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 437, DateTimeKind.Local).AddTicks(7610), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 437, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 437, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 437, DateTimeKind.Local).AddTicks(8589), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 437, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 437, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 860, DateTimeKind.Local).AddTicks(2987), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 860, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 860, DateTimeKind.Local).AddTicks(2985), new DateTime(2026, 2, 16, 14, 53, 12, 860, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(7731), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 866, DateTimeKind.Unspecified).AddTicks(7770), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(7722), new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(8596), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 12, 866, DateTimeKind.Unspecified).AddTicks(8614), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(8595), new DateTime(2026, 2, 16, 14, 53, 12, 866, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(2205), new DateTime(2026, 8, 16, 10, 23, 12, 857, DateTimeKind.Utc).AddTicks(9460), new DateTime(2026, 2, 6, 10, 23, 12, 857, DateTimeKind.Utc).AddTicks(9423), new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(6556), new DateTime(2026, 9, 16, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(6542), new DateTime(2026, 2, 11, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(6541), new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(7551), new DateTime(2026, 5, 16, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(7543), new DateTime(2026, 2, 1, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(7542), new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(8205), new DateTime(2026, 1, 27, 10, 23, 12, 858, DateTimeKind.Utc).AddTicks(8200), new DateTime(2026, 2, 16, 14, 53, 12, 858, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(2173), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9673), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(7494), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(8633), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9599), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9625), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9634), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9649), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9656), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9666), new DateTime(2026, 2, 16, 14, 53, 12, 859, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9232), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9256), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9550), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9554), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9555), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9558), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9559), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9563), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9567), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9570), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9571), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9575), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 434, DateTimeKind.Unspecified).AddTicks(9582), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 434, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1685), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(1724), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2052), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2056), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2059), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2059), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1983), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(1987), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1989), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(1992), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1995), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(1998), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(1999), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2002), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2003), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2007), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2039), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2040), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2048), new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(2051), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 16, 14, 53, 13, 435, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 435, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(2276), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4021), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4035), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4040), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 16, 10, 23, 13, 436, DateTimeKind.Unspecified).AddTicks(4052), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
