using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sdfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LanguageId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9ad862d-f716-4f4a-a442-1b598913f7b3", "1", "AQAAAAIAAYagAAAAEPoC8lMH0Gl4utZhska3AgBa43C5Sy1x3KzEQ7PuGQ/dzMxWCA2Vcp+YVYLS2DM7Uw==", "3adaa2a7-61ed-4fb9-9a5d-39ac4e893508" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49a62f11-2c42-491a-8362-67bd14250709", "1", "AQAAAAIAAYagAAAAEHHwI+Onl3F0xHxiCxunq+sXbG9eIEj9mQGzu/Z/NDBlmcdLNNW14ITELD3IIR+B7w==", "c46067ad-1dfa-4ce0-a49e-c65e4fedf89a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ead31bf2-1445-4eb3-bf79-1c72bf3ad0ae", "1", "AQAAAAIAAYagAAAAEGswhjIWzethWZSA1snI0d43umeZ+OJ9JLw7gQJbmHKA3iem0BEdVmDPo1pS5qcIYQ==", "5d5c5768-e512-473c-a59f-ee0159926f9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5db04cc-df11-433d-b8ad-1d2a1411e2b2", "1", "AQAAAAIAAYagAAAAEC9uzPb8R4FmPf0EnJIAPlbFELsz9j4QfWmCOPAUC8xo2vcYNGlPpKD4LmYo/y45mA==", "a611ec1b-2035-4c87-a9a7-8a026de4fb17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31e512b8-bdcc-4b9f-91ce-285d9863e809", "1", "AQAAAAIAAYagAAAAELlJd3E18/f0fsCU226WCRQnCekA7/e5X/v84HFWSzGh5rx1B95dfckhR4S+8lKzyA==", "9f203b7a-f538-4b9d-bd59-ab24ef6f9b3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45c1b0d1-2857-4005-a392-3c9fcd35e0e6", "1", "AQAAAAIAAYagAAAAENhpB5LU7rl/anSUjfT8majNhfbmcCXoEGTYi75yj3pweGU+pPjyM9jdEVBNW8kM8Q==", "745b07e0-c2f1-40b5-a584-6b9a7bb0074e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "501f9c5e-d4da-4cb5-9327-b41c22e34c98", "1", "AQAAAAIAAYagAAAAEDSNooNQ7d4ZqDC5BDxywodJMjKy6meI2lLE/KnhmIsJbQLYUlN9R4N4mY7dEbLLnQ==", "271a559f-1c43-4021-a45e-8a4d3cbd6c92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecfe2700-1720-433b-8b44-c3dcb9b1eb7e", "1", "AQAAAAIAAYagAAAAEMc4uZ5nl48Kj1GDTt9hrlsHZjggGynNJPiWsMWKJ6GZ0ebZLEeGl1rHdbRUUV6NEw==", "5731d9af-6e37-4785-b528-8f8c74450937" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ee02919-d8da-45fe-9895-b19246a9bb09", "1", "AQAAAAIAAYagAAAAENJoWDjs2dQXNBeT9qaGPvXpvCmH8OumyBUdD1jTV+IkLnT/JbDIXx6fqeU+ILrdQw==", "26a62cbc-0edd-4956-ac68-1875b6d2aa6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5be600a1-60ab-41a0-8c21-6baa6695cf87", "1", "AQAAAAIAAYagAAAAEB3AavP0+ygAbUS6ftF4kt5+79QSxW3JUNlgzwRT0HyFY+wPawloBkjgX4G5U2Ctbg==", "d8be3fa9-367c-4d5c-b3e7-e65ad6db737d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5acd0768-8b81-4460-b1b1-3e512b5adbe2", "1", "AQAAAAIAAYagAAAAEEjg5x/GN3r75tZpPCqA7rWOgtddiH0jivCyQhpYVKpr6jSddazRqicKi0t0bwaT0Q==", "7c675b2b-8ae4-4620-b889-6d8b687bc240" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27e63506-ac07-43a3-a06c-f784aa97fcc6", "1", "AQAAAAIAAYagAAAAEMj1e5Hf2BJ8o/Bm/p+NSgzRgr07NkFh8rp5us3jH9lvz3xcZvnUDGA1MQrfABFUoQ==", "ad98ca2f-7b6c-4af2-8eb5-f8e9507927ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9f28c78-9ab2-447d-a95c-550e803c3c24", "1", "AQAAAAIAAYagAAAAEGdAPBoUGuZoLuyAh5zcUKWhF2vmMLhAzWuigejvU8rru/Umeu7efAisqv+1QcEL9g==", "0b0039a9-becb-49e3-8c2d-aab5ab6856d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d44cdf32-b3ac-43e2-88cf-06d866101281", "1", "AQAAAAIAAYagAAAAECZDdCVnd/vifkMMAuQieFfv6QLMKfUVal6ECYpLT6liXlNXKuXsx2ZWfMW3FSYRjw==", "e531f174-0a33-460e-b58b-cc169f201579" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "LanguageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d21ffac-4857-4f33-ae5a-2186081e16d5", "1", "AQAAAAIAAYagAAAAEL4zdLXs45Bz2z88WiZS8Uoz7EggDDaWVYDkWS/vBoQpYEdPpXg/4iblKJomHuNz2Q==", "0780a8f2-9674-4d98-b7b8-83addd5a6b13" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(1718), new DateTimeOffset(new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Unspecified).AddTicks(1737), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9512), new DateTimeOffset(new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Unspecified).AddTicks(9515), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9523), new DateTimeOffset(new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Unspecified).AddTicks(9524), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9525), new DateTimeOffset(new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Unspecified).AddTicks(9526), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9527), new DateTimeOffset(new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Unspecified).AddTicks(9527), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9528), new DateTimeOffset(new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Unspecified).AddTicks(9528), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 673, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(6584), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(6759), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(6764), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(6769), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(5724), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(5729), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 671, DateTimeKind.Local).AddTicks(4134), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 671, DateTimeKind.Unspecified).AddTicks(4152), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 671, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9611), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9615), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9623), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9629), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9655), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9659), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9665), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9669), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9683), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9686), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9723), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9726), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9734), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9737), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(7458), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(8685), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9529), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9535), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9554), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9558), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9566), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9569), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9576), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9580), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9587), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9597), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 672, DateTimeKind.Unspecified).AddTicks(9600), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 672, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 90, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9591), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9705), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9727), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9741), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9767), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9779), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9792), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9804), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9819), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9832), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9843), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9856), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 92, DateTimeKind.Unspecified).AddTicks(18), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 92, DateTimeKind.Unspecified).AddTicks(76), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 92, DateTimeKind.Unspecified).AddTicks(85), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 92, DateTimeKind.Unspecified).AddTicks(91), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 92, DateTimeKind.Unspecified).AddTicks(96), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(6907), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 92, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 92, DateTimeKind.Unspecified).AddTicks(107), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9458), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9521), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9538), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9552), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9565), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 91, DateTimeKind.Unspecified).AddTicks(9577), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5633), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5595), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5609), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5612), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5616), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5622), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(5629), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(4662), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(4674), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(4795), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(4800), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(4806), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(4807), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(4848), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 669, DateTimeKind.Local).AddTicks(7128), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(7152), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 669, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 670, DateTimeKind.Local).AddTicks(8330), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 670, DateTimeKind.Unspecified).AddTicks(8356), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 670, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 670, DateTimeKind.Local).AddTicks(8991), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 670, DateTimeKind.Unspecified).AddTicks(8999), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 670, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 93, DateTimeKind.Local).AddTicks(521), new DateTime(2026, 8, 3, 9, 34, 23, 92, DateTimeKind.Utc).AddTicks(7334), new DateTime(2026, 1, 24, 9, 34, 23, 92, DateTimeKind.Utc).AddTicks(7275), new DateTime(2026, 2, 3, 14, 4, 23, 93, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 94, DateTimeKind.Local).AddTicks(3291), new DateTime(2026, 9, 3, 9, 34, 23, 94, DateTimeKind.Utc).AddTicks(3266), new DateTime(2026, 1, 29, 9, 34, 23, 94, DateTimeKind.Utc).AddTicks(3265), new DateTime(2026, 2, 3, 14, 4, 23, 94, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 94, DateTimeKind.Local).AddTicks(4819), new DateTime(2026, 5, 3, 9, 34, 23, 94, DateTimeKind.Utc).AddTicks(4801), new DateTime(2026, 1, 19, 9, 34, 23, 94, DateTimeKind.Utc).AddTicks(4800), new DateTime(2026, 2, 3, 14, 4, 23, 94, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 94, DateTimeKind.Local).AddTicks(5627), new DateTime(2026, 1, 14, 9, 34, 23, 94, DateTimeKind.Utc).AddTicks(5621), new DateTime(2026, 2, 3, 14, 4, 23, 94, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(189), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7692), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(5553), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(6792), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7640), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7651), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7659), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7670), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7677), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7684), new DateTime(2026, 2, 3, 14, 4, 23, 95, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8236), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(8560), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8914), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(8919), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8921), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8925), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8929), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(8932), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8933), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(8936), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8937), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(8991), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8992), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 667, DateTimeKind.Unspecified).AddTicks(8996), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 667, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1111), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1123), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1436), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1439), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1440), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1443), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1444), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1446), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1379), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1383), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1384), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1387), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1388), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1392), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1392), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1395), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1396), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1399), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1400), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1427), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1428), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1431), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1432), new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(1435), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 3, 14, 4, 23, 668, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 668, DateTimeKind.Unspecified).AddTicks(8969), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(4202), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(2461), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(4155), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(4164), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(4176), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(4181), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(4190), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 3, 9, 34, 23, 669, DateTimeKind.Unspecified).AddTicks(4194), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LanguageId",
                table: "AspNetUsers",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Languages_LanguageId",
                table: "AspNetUsers",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Languages_LanguageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LanguageId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4c260c6-a22e-43d6-912d-6c31d2506cc1", "AQAAAAIAAYagAAAAENxz1jgVkguLWVOEId+5cFFyo3PTiuLLYQgBo/Fj36IN5DO1w3pmeYKU0/MPFsJFvg==", "2d6329df-45f8-4ab3-bd54-f1c76899cba3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73dbaaf4-b147-4010-9775-4c19b24c70f3", "AQAAAAIAAYagAAAAEJjFRyGEob+DiUaiaqZLKnLhybAwYZwoOFNo1C1bDDaBUFLvTW2npyTmKPZcKb6P2w==", "87017e04-ec9d-4bec-bd52-1d6ad34f759e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a8fd8b1-412d-4dd4-adc7-3a62c83040a2", "AQAAAAIAAYagAAAAEOsG55n50U05MX7dlblp5AQHuIxEXP6yhJcJK9fvIyVCbguvQJal5fAF1EyxhL1PGQ==", "2308dd0b-6bde-4433-9811-5a3de262dfa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d7687d8-cab3-4ef0-8980-7b9cb6e52be7", "AQAAAAIAAYagAAAAEFb1fcZcrvKAB2lxAquIaNxA/BRyGVr1yTUVfCR2L6xxd9sAJFjHYoksEBwFVQZdWQ==", "34e255e9-6574-4d05-b2ac-e8d8ed8e894f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c10e86a-7344-40fa-a408-9db7155fd3e4", "AQAAAAIAAYagAAAAEBWTS4HtStYHOP4xx/+jljJSyeFpFVRD0OzxukRsLtQ1GWRwtQwTs/gPHCZuBvpNxQ==", "dc4fdc58-ee9e-4c31-b02a-dc7f9a25cf24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3c4708a-d143-4667-82c6-305d2c494205", "AQAAAAIAAYagAAAAEKeWupWHE1eOtpwtjeCqDxGV7mkEu9kPQooJHmgZIeuVrkgT9ZVfn1mpIHOf5NyGGg==", "bd5f74dc-fea4-48bb-931c-e28b5cddd330" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c3dbc8b-2afe-4653-9025-cd7b313a212d", "AQAAAAIAAYagAAAAEDf73cxg/C9WnfubdFAd0FzaV1E1S2wh8n+uIJZCFTnhGeNGmORXtiRQurWfRen1gg==", "8d00c0ca-0359-4bd3-b625-3760e25de715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32f8ad84-ba15-45d2-9505-550e7a229f11", "AQAAAAIAAYagAAAAEIcGDDkZ0YQUz1949BTVFsSDt+yGikOA5xieb+W7v2OM/fY/WTgkiBl30DTIkOVfWg==", "ef2a183b-e755-4c4c-9711-c35e3d2280ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be4fecbc-10d5-46a8-ae65-25b6fe30fec8", "AQAAAAIAAYagAAAAEPUdAZJnrovLNAHaIcBgZIaLagYkEUWNSVPFa8v6IdRqMvK7lkUqMB7MKD3+TghqhQ==", "3d0922f2-b655-4ab3-82b9-ecb473492d1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "449085d0-cd15-40e4-a92f-9946810b47ec", "AQAAAAIAAYagAAAAEC0QHeTlplffVd6yFoxHN2PhIS1z02UWJ+vNiZDCSxm0WqvHotJtPTBV0/whBNsT2Q==", "f34d8086-f2c9-4e41-9011-e646e39f667d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "375e438d-4bd2-433c-9f5a-a61e07cd2a47", "AQAAAAIAAYagAAAAEB4bQlDgF1L0v0lQDmMgKe5+ihXx/8dRKws0mC0xH9vI4H0jpoRgeK+t2cdAkiYxtA==", "72bcee7f-a744-4c23-a644-52d3d464ab6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62445901-e599-4eff-816a-d2da86478ba1", "AQAAAAIAAYagAAAAELBcheJV6WSmRyg5U/zKYV/vhvEi2ZvcN2VGGBqIHRlH+yLwkRpj9LDoV6FyF8NT2g==", "f419d121-abad-4cb7-b1ac-ca03ed38eff0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff0f4ce-0b01-431f-9a43-2bf8d5370b8b", "AQAAAAIAAYagAAAAEKcwhgZORwYdEw0xHQ61n12MMOX3mWSGXqFMHFnWB5kQUjVww/vPl5DmuIULXqhPKQ==", "3e6fbefa-668a-412b-90f1-b2b390dffaf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2025e34a-5102-4534-9a86-00a55b8cecc8", "AQAAAAIAAYagAAAAEI+4VnVXN3PWWiTfh+mN2L7KYRgjNZWP7qr3+laaAoA/5JaGE+ptTTjkO3Luen9+Hg==", "cc4d98bc-ff8d-47e4-a93e-9723b307f523" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb04c69b-7d51-45da-a8d0-6e3b337fa552", "AQAAAAIAAYagAAAAEPcXBH9Cx/1H14g0j68Z+91Q1P2Rlg7npgp3zFfbY3Nc7M0pyqjLI4Fet1Ata5gaoQ==", "4e52725b-8249-4d4b-aa31-1e79cf7d66a2" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(7628), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Unspecified).AddTicks(7673), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(5971), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(5980), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6022), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6134), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(6135), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6137), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(6138), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6139), new DateTimeOffset(new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Unspecified).AddTicks(6140), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 423, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(378), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 407, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(1055), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 407, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(1068), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 407, DateTimeKind.Unspecified).AddTicks(1164), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 407, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 401, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 401, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 401, DateTimeKind.Unspecified).AddTicks(4454), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 414, DateTimeKind.Local).AddTicks(9394), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 414, DateTimeKind.Unspecified).AddTicks(9437), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 414, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1705), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1708), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1719), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1721), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1731), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1736), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1746), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1749), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1758), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1761), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1771), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1784), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1786), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 420, DateTimeKind.Local).AddTicks(3166), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 420, DateTimeKind.Unspecified).AddTicks(3240), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 420, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 420, DateTimeKind.Local).AddTicks(8420), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 420, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 420, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1397), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1559), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1628), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1646), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1659), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1671), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1674), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1693), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 421, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 421, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 884, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6969), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6981), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6991), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6998), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7004), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7010), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7017), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(3833), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7035), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7050), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7057), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7065), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7143), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(5800), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(7163), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6943), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6949), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6955), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 38, 887, DateTimeKind.Unspecified).AddTicks(6962), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7491), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7467), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7480), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(7485), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(3948), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4421), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(4429), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4431), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(4434), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4435), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 406, DateTimeKind.Unspecified).AddTicks(4438), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 406, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 409, DateTimeKind.Local).AddTicks(5448), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 409, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 409, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 413, DateTimeKind.Local).AddTicks(935), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 413, DateTimeKind.Unspecified).AddTicks(989), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 413, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 413, DateTimeKind.Local).AddTicks(3441), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 413, DateTimeKind.Unspecified).AddTicks(3486), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 413, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 889, DateTimeKind.Local).AddTicks(3077), new DateTime(2026, 8, 2, 16, 11, 38, 888, DateTimeKind.Utc).AddTicks(8341), new DateTime(2026, 1, 23, 16, 11, 38, 888, DateTimeKind.Utc).AddTicks(8252), new DateTime(2026, 2, 2, 20, 41, 38, 890, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 891, DateTimeKind.Local).AddTicks(9395), new DateTime(2026, 9, 2, 16, 11, 38, 891, DateTimeKind.Utc).AddTicks(9353), new DateTime(2026, 1, 28, 16, 11, 38, 891, DateTimeKind.Utc).AddTicks(9350), new DateTime(2026, 2, 2, 20, 41, 38, 891, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 892, DateTimeKind.Local).AddTicks(2407), new DateTime(2026, 5, 2, 16, 11, 38, 892, DateTimeKind.Utc).AddTicks(2391), new DateTime(2026, 1, 18, 16, 11, 38, 892, DateTimeKind.Utc).AddTicks(2388), new DateTime(2026, 2, 2, 20, 41, 38, 892, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 892, DateTimeKind.Local).AddTicks(4574), new DateTime(2026, 1, 13, 16, 11, 38, 892, DateTimeKind.Utc).AddTicks(4559), new DateTime(2026, 2, 2, 20, 41, 38, 892, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 893, DateTimeKind.Local).AddTicks(3062), new DateTime(2026, 2, 2, 20, 41, 38, 893, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3286), new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 894, DateTimeKind.Local).AddTicks(7328), new DateTime(2026, 2, 2, 20, 41, 38, 894, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(486), new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3119), new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3166), new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3178), new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3247), new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3258), new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3269), new DateTime(2026, 2, 2, 20, 41, 38, 895, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(5429), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8784), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8831), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8836), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8843), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8848), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8854), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8859), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8865), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8869), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 403, DateTimeKind.Unspecified).AddTicks(8877), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 403, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 404, DateTimeKind.Local).AddTicks(8979), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 404, DateTimeKind.Unspecified).AddTicks(9192), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 404, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(796), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(804), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(807), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(812), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(649), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(678), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(682), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(724), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(728), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(730), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(733), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(737), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(740), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(743), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(778), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(784), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(788), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(790), new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 405, DateTimeKind.Unspecified).AddTicks(794), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 2, 20, 41, 40, 405, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 407, DateTimeKind.Unspecified).AddTicks(6484), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(5588), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(7766), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8795), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 2, 16, 11, 40, 408, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
