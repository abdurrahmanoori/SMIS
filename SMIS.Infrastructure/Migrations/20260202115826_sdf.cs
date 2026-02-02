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
                name: "RoleName",
                table: "AspNetUserRoles",
                type: "TEXT",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AspNetUserRoles",
                type: "TEXT",
                maxLength: 256,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "SuperAdmin", "superadmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "10", "10" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "RShopAdministration", "radministration" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11", "11" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "RShopManager", "rmanager" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12", "12" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "RShopStaff", "rstaff" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13", "13" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "RShopViewer", "rviewer" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14", "14" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "RShopEditor", "reditor" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15", "15" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "RShopUser", "ruser" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "WShopAdmin", "wadmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "WShopAdministration", "wadministration" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "4" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "WShopManager", "wmanager" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5", "5" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "WShopStaff", "wstaff" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6", "6" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "WShopViewer", "wviewer" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7", "7" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "WShopEditor", "weditor" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8", "8" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "WShopUser", "wuser" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9", "9" },
                columns: new[] { "RoleName", "UserName" },
                values: new object[] { "RShopAdmin", "radmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9facdc9-f0c4-4fd5-81d2-0d052fc3e6ad", "AQAAAAIAAYagAAAAEJlTsRLJGO1hFJZKileTT16i4IMcgupuYUwUFrCAdSjAC9yYgz2wEcL7ljhreCtpNw==", "d8999f81-4671-4c84-93fc-92038270e009" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00f975ee-c42d-4a2f-9b70-d0f9d57caaef", "AQAAAAIAAYagAAAAEAdv4om/OY7sHp8nPgSILMWKZgTNvPzHr1JFh8QaA93BxD2SfMl5stCvUeCDIQnigw==", "846fac22-e2e8-46e6-8b05-ee06bae74371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee54f1ef-7237-4fc1-869b-683302a12c9c", "AQAAAAIAAYagAAAAEBzKLB5oZOA2ldukl411OMZxzR/GWxFYTrUFe+f6erUiqthymiKlbNKkApyLbQpcQA==", "0d7cd615-9d67-4871-8acd-c9644899194a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "246e89e4-1f26-423a-bb2c-a186ab02a0ea", "AQAAAAIAAYagAAAAEP4ZX7tza4BIPRNrRDO1VnJrvxUI5hfzh8kj6QWCEVtIUS8q4Ajo7BffQmFDmjX2xA==", "cd99e351-6d27-4a2f-a451-705e4cb61ce7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02932d31-689e-4761-9017-266362398f9f", "AQAAAAIAAYagAAAAEJ0dRr2seenP2jM3cwN+SGIi2uQEdMZwhAE/REyHAglP/8W8cRhM0hooBlKWG0Zh8A==", "5c32663e-1b05-4ecd-8470-0026d2998664" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9a9ce7-4825-4a4d-ae36-354a28d658bf", "AQAAAAIAAYagAAAAEEpZe6JJRUlR1ggG8HSOPYGG4P4PRAz/d4Tsw+OiBdcMjg3wzFerTRAUE0DGPPE/8w==", "1a74b2f5-cd39-4bd8-aa3a-ce19ca7783ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0bf111c-82de-447f-91cd-b54000bcf1c4", "AQAAAAIAAYagAAAAEKWXRwmot2IkgdN/QXQW1ABIYOPpqLXe9lIcvn+lynEsA3lvoumwDlrQqSlaEUJiVA==", "e9a01a6c-35f5-4d05-85f1-c8b27207ee3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e7e2fc1-b240-4e0b-a24c-e5e3334a3a45", "AQAAAAIAAYagAAAAEBpyQNfiy+Pq4yn2f6xVYMZ/ZvMwByZpBT+0YppYoxfmCyyCX2HSyu900aKvbvDN8Q==", "3739eca6-564b-4602-80a5-bcab1195a946" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b53ddd99-d01a-4740-b66e-c1da8b725e7e", "AQAAAAIAAYagAAAAEDPIK2UaC/m4oT3qH6KBSuw0qQJLN9rpU5wqZtCgTBfVLyRiPnLh6hnoTQ+YjIWiLA==", "2863005f-87a7-4ee0-8dfa-293ba0797e3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5102cffe-6860-4285-a7d1-5ada3af0c5c8", "AQAAAAIAAYagAAAAEGIVzKG1jD/GJ2n1BNZ0hRDVfOwH5cvUSYII2qvu72Jxtzl/gqgbBZCZnR22UVwtzg==", "bcf5164d-da6d-4fe9-87ab-e6d82ef49695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb99e6e6-24cf-40e6-8630-acd167507b9c", "AQAAAAIAAYagAAAAEBAEPVVtc5fUl/n6u0hoPs/jSXIU2ndQ+3Obz51QxpUSbKe1NPWdyS95s9R8w2LiTg==", "106a6a5d-a8ae-49fe-afd7-8d352a4a128b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f42354bb-1777-4555-b7a4-dca7d93688e6", "AQAAAAIAAYagAAAAEBYHYxIQPF35nDNKnYW8n2RyJXBwtGGtkYySG+Hjq23bgqRhUqZqo+OMi8T0mNQybA==", "0ec7dfb1-8978-4991-98ad-fc814a5dc462" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "381c570a-c509-46ff-b667-bebe4b42a330", "AQAAAAIAAYagAAAAENLVzhQYX+dzPMgbMF97rhmM7g5R5FkMFYu59SCggqO6EiUeqG5QIKLiAlpke3OHcg==", "f0888707-649c-4db5-8554-24ad54d82eb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0de3c85-aa3c-49e2-bad3-f01d5ac681c2", "AQAAAAIAAYagAAAAEGk+U9IJ5n6mvntA0FRdS9WYiwqummylq7Uo3TtoirtI1dtfKz2+Uhik067LieP03w==", "a18b3a27-9821-45a8-825a-968a95be1e24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4340440-7148-4ef4-9a96-fcfc1e219b0d", "AQAAAAIAAYagAAAAELml67u53a9VP/M1TBsnGt3ti76bHlbw/tU21iVGlBpdOEVgIWxG55k27zcZdC+x/w==", "1ad58caa-c759-4e9b-a832-0fa5bb2b2206" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(6065), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Unspecified).AddTicks(6092), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4638), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4641), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4652), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4652), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4654), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4655), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4655), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4656), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Unspecified).AddTicks(4657), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 227, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3004), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(3025), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3268), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3274), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(3278), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(1772), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(1776), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 223, DateTimeKind.Local).AddTicks(3039), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 223, DateTimeKind.Unspecified).AddTicks(3073), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 223, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3637), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3641), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3649), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3652), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3671), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3682), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3700), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3711), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3716), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3723), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(1052), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(1096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(2596), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3489), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3495), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3512), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3524), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3535), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3545), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3561), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3564), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3572), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 226, DateTimeKind.Unspecified).AddTicks(3605), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 226, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(411), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4077), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4085), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4089), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4155), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4166), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4170), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4034), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4178), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4188), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4191), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4194), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4206), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4209), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4212), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4055), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4066), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 25, 614, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1911), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1918), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1921), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(1924), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(420), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(442), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(576), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(581), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(582), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(586), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(587), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(590), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 220, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 221, DateTimeKind.Local).AddTicks(4200), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(4222), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 221, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(5930), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 222, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(6655), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 222, DateTimeKind.Unspecified).AddTicks(6665), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 222, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 615, DateTimeKind.Local).AddTicks(1642), new DateTime(2026, 8, 2, 11, 58, 25, 614, DateTimeKind.Utc).AddTicks(9355), new DateTime(2026, 1, 23, 11, 58, 25, 614, DateTimeKind.Utc).AddTicks(9320), new DateTime(2026, 2, 2, 16, 28, 25, 615, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(3244), new DateTime(2026, 9, 2, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(3225), new DateTime(2026, 1, 28, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(3223), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(4770), new DateTime(2026, 5, 2, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(4759), new DateTime(2026, 1, 18, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(4758), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(5537), new DateTime(2026, 1, 13, 11, 58, 25, 616, DateTimeKind.Utc).AddTicks(5502), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(9185), new DateTime(2026, 2, 2, 16, 28, 25, 616, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5983), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(4230), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5234), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5938), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5949), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5955), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5962), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5968), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5974), new DateTime(2026, 2, 2, 16, 28, 25, 617, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4230), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4925), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4929), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4931), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4973), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4974), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4978), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4979), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4990), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4994), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4994), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(4998), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4999), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(6994), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7308), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7360), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7362), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7366), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7369), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7255), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7259), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7260), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7264), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7268), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7274), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7275), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7277), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7278), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7299), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7300), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7304), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 219, DateTimeKind.Unspecified).AddTicks(7307), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 28, 26, 219, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 220, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(440), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1501), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 58, 26, 221, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AspNetUserRoles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac0224e6-a771-4f4b-b84f-c620dd2c9882", "AQAAAAIAAYagAAAAENVo5G/ESNasXxv0SL6RQtyfOML9csdi3/uFVMB9NHrKEfyslRLJwWwxh0RkWLNleQ==", "0f225ba1-1e56-4aee-b6cc-c3fff98989df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73792fcc-b355-4cab-928a-a22e8b0d2a2a", "AQAAAAIAAYagAAAAEB8uORgWcVS5NlUUhS6kGrvX0J2EAYr/lUO2m/sOLLCNSfQfOMMs2fzklk6pT/pmEw==", "8025c7b5-9146-4988-b367-9eaf4d3ede28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56dd6d2e-c3b2-4965-b139-0bdf1516c291", "AQAAAAIAAYagAAAAEIyvi6qCsizSw9hxJ+jvFtN191/ESDfnpqvuEHJ/5ZO/6ZznUub4C9TAAwDnSdj+Tg==", "5d35b4cd-7abc-4e20-a20b-92aa9686b115" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7465f1b-f50b-46d9-9f0c-0e1109d67169", "AQAAAAIAAYagAAAAEGeF0Yv4T8y5nv5lL5RbvRdE0t3d3au4kRDJBF78wBGi4aoPJclux534BE5PWrjjKw==", "26defee9-2510-4343-a0ea-6cb0721d7c22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7db0d89e-337e-4360-9c13-0414d560f05e", "AQAAAAIAAYagAAAAEA2LvkSphd9vt0iuzQJlt5u0bItlo3qqgmI2iYsIJtn/myBopMpItJw7d2m0OnxoXA==", "c39fd495-27c8-43ae-bcf1-f8cea450b246" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29085be5-b346-4cf0-a728-9756cfa7c50d", "AQAAAAIAAYagAAAAELh5Ry4Y/Kc89oS8oJlH7HVyQJ38FijEdBPfsHUUbzUpkiFD8zXRUB6GBes0sK/5ag==", "8c74f49d-4acc-4b69-bdd3-14dbb1ae6845" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9caf25c1-cb87-4e10-b073-e825469e4668", "AQAAAAIAAYagAAAAEEqawh4HfebVvtcfJbWJGWLkwya2oB4IXywOxlSn286YVEM0+MekLrXY2RLDC9H6dA==", "f0987f5d-6d5e-4f8c-bdac-538018d8cda2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf5a966f-4663-4bdc-9e81-57b1c5031fba", "AQAAAAIAAYagAAAAEJi3IHi9gfsRV1Xs3zpx62es3oJaXgWz8YBhtcN6t0Z/uyq9wnWyc1a62M3d89kK3A==", "9283cdab-a4af-4979-b6f7-ac78d6b5bcb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15895cb4-2eec-400e-929d-452419c989f9", "AQAAAAIAAYagAAAAECKCrxdci7sFGtxnNJCWcJtJkGGcSwPRlROXCGLfRgRm87hSwO1NNQYS6hJJVUQy+g==", "7a644b5a-13b0-4ff6-92de-a454642e9c6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb01f2a3-9e76-4533-a640-887ff55f24fd", "AQAAAAIAAYagAAAAEJTDonZk9BGBmYSn6/jg7J5u2t6LE6vKZ+8zSkIGHcDdp2ajEFxyW63jc+V2SvjteQ==", "e52ccd50-0d5e-4b24-99e8-2dbde2703d6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cada99f-f1a4-471b-8d14-1442cd64c830", "AQAAAAIAAYagAAAAEOzy383Kh5hYXTcFA3ZZt3vx6pDM1aWpJQs91bIZ+W3HtSNkzh9APWmyl6hLp9xClQ==", "0b4c5848-18fd-46a4-861d-3aa7304c71c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06441d82-2b3b-4dfc-9fb1-e888508a7979", "AQAAAAIAAYagAAAAEPpAxCuOAth02DZRRt0qVd7ToRA1ZACVtF4RpckeeD2Sq3DBTxXApbqx0LHTNK1QGA==", "6b4fe4f3-1311-497e-b3a3-f766aa2bdb08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "920b4ec7-eb83-40ba-88c9-403cce071501", "AQAAAAIAAYagAAAAELZepdenwJKh/IyRYRUhMlEVtCBKIqHsA6gvmGM2MFTKuQO6IElueJ7M2vs3wDL+vw==", "9fbb6ded-e3e6-4a52-b2c4-07e5fda3373e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e5203d2-3287-48e5-98cb-1896e784f93e", "AQAAAAIAAYagAAAAEKD/TjpOCz5nBnZbrYScacq9esJSmyUV1O+aKKFn9hz12zayKsW18xNBwSZJZUnuMg==", "5762b7ad-1d00-4d5f-bb70-1b0006528f62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77083826-27db-4cc5-a379-0c4fdc79d0e2", "AQAAAAIAAYagAAAAEBLVdajdOaDoXJdT/i7pvBahgI0JbBnvEHHPi7C7ORPgua5ymwkxhH3iDQBhMS144Q==", "14906db8-9f31-482c-a108-d8ebdfa65cdd" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(8625), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Unspecified).AddTicks(8664), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6200), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6207), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6219), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6220), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6221), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6222), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6223), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6223), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6224), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Unspecified).AddTicks(6224), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 864, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(6991), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6995), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(7425), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(7428), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(7429), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(7430), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(6254), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 860, DateTimeKind.Local).AddTicks(4900), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 860, DateTimeKind.Unspecified).AddTicks(4918), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 860, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5533), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5535), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5544), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5560), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5566), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5567), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5572), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5573), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5580), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5581), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5586), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5588), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(576), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(609), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(4103), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(4128), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5327), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5370), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5475), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5476), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5485), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5509), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5519), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 862, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 862, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(2496), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5685), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5697), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5627), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5704), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5714), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5719), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5729), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5634), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5645), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5649), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 269, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6022), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6025), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5973), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6012), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6014), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6016), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6017), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5072), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5079), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5191), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5194), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5195), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5196), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5197), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(5198), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 858, DateTimeKind.Local).AddTicks(7097), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(7151), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 858, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 859, DateTimeKind.Local).AddTicks(8690), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 859, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 859, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 859, DateTimeKind.Local).AddTicks(9438), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 859, DateTimeKind.Unspecified).AddTicks(9442), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 859, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 270, DateTimeKind.Local).AddTicks(3530), new DateTime(2026, 8, 2, 11, 38, 17, 270, DateTimeKind.Utc).AddTicks(1068), new DateTime(2026, 1, 23, 11, 38, 17, 270, DateTimeKind.Utc).AddTicks(1017), new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(6140), new DateTime(2026, 9, 2, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(6099), new DateTime(2026, 1, 28, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(6097), new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(7775), new DateTime(2026, 5, 2, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(7762), new DateTime(2026, 1, 18, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(7761), new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(8587), new DateTime(2026, 1, 13, 11, 38, 17, 271, DateTimeKind.Utc).AddTicks(8581), new DateTime(2026, 2, 2, 16, 8, 17, 271, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(2523), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9850), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(7684), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9020), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9765), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9813), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9826), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9832), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9838), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9844), new DateTime(2026, 2, 2, 16, 8, 17, 272, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9119), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9492), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9859), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9862), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9863), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9872), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9873), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9874), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9875), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9877), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9878), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9879), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9881), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9881), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 856, DateTimeKind.Unspecified).AddTicks(9961), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 856, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(1916), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(1924), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2206), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2207), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2208), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2211), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2172), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2173), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2175), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2179), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2179), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2181), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2181), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2183), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2183), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2185), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2185), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2201), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2202), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2203), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2204), new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(2205), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 16, 8, 17, 857, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 857, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4756), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(3185), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4251), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4724), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4733), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4736), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4738), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4744), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 11, 38, 17, 858, DateTimeKind.Unspecified).AddTicks(4747), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
