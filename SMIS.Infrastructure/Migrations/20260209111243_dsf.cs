using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMIS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dsf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cf83680-d27b-4add-824b-b2e61f5b1749", "AQAAAAIAAYagAAAAEBlaM/Jh3Y5x7rPwsbMKjtJsDo7HXua4N/wPWhKL+m5sVZPsNf2SW8LXmQj4ofdp9Q==", "a35f4b24-849b-4957-9f85-fef5bc5b2d07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a12a80f1-6d30-4e99-9720-12993f8d78d8", "AQAAAAIAAYagAAAAEFoR94EIouLHrgMuvxO50yPd82XvhCfrmJ5CPEEMQ63/lCVnZKkg+ttPV9LjRVjR9Q==", "56b6b679-8121-400a-a7ea-96f95e22b160" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9b95afb-c38f-4e6c-a7a0-1a477f7253e0", "AQAAAAIAAYagAAAAEM9L5LA1bdPbRjM8M8i69n3G9ccZ41dQYLN0nNK64GT/D8HuANVNSFJhcTtvtXbb7g==", "fe6f885c-b57f-482e-a9bd-2ec2097336f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be711af5-3465-4a00-af68-20c35bed94f4", "AQAAAAIAAYagAAAAEJGffHsJ4iQJ2zxllnTf/a2qiyQegGmdIXpTvNm/JDLc/TbLBlevANmYYuEryqiSCA==", "a0fd4a0e-eca3-459b-945f-e912926758d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7a91dde-630a-4f8d-bffe-cf9fab78ec2e", "AQAAAAIAAYagAAAAEDeGxwibDnbRmP9A7mrQy7RZQrn96T6wQNtmg+7z5sDKPNcwrNkZflihJ2wFEiCTGw==", "719e2c72-07a3-4437-9bad-2c4670982171" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5f21a20-f916-43ce-a12a-3a0210a43b4d", "AQAAAAIAAYagAAAAEN/B1InP5RedB+5Gdvuymj9qRtItYyjjwwUD0EHUnXhz/XNpjdHxDrfsljTu8DdczA==", "1e1a4be6-c137-4f31-b6ed-bc92094e6032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e72a7afb-4090-4162-a43d-ab035ed4f567", "AQAAAAIAAYagAAAAEIg1/M44+Fj1TkzjrMqJWJNwzpicuMbWlDaqsoys+oH45GRnch7lMhVTo+F6KtIVMw==", "5aea285d-aff7-450a-8dfe-530c481f0d53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95026b81-fd64-4077-a8d5-c3ff7b24c898", "AQAAAAIAAYagAAAAEGARTXs7QTnuN1BEi5RqSVDhfyxt701t3oH6zyoYX6o59ztsoCwxH7vPxp7r8J/xvA==", "074e45ae-8d03-4156-9656-9069029687dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f73c1b9e-b5b6-433f-8bf2-b14591916577", "AQAAAAIAAYagAAAAEK6VHsQ+JJDgCNvMO0E1TpP8vu6dorZD+OmqIROP1lOP0gKhXGltYKjyhgiKSy/qDQ==", "33b02a46-70df-4c23-b3b4-58ef7a22568d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d73e031c-c33b-44a4-8b3d-671c68839dc7", "AQAAAAIAAYagAAAAEJ48YwYuBKUmpYBi1ocJ47Pzk/6ayJhAkvfqTmBPErMdCBMhw2RL3Zrlf8Uybthe9w==", "9f8c087a-83bb-4353-950b-588dc5cf7d7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2a462ae-6f0a-4560-bc7f-ffd3b621557e", "AQAAAAIAAYagAAAAEHFJeX2EcKN6XiQeQAZ5mmOscXbxUc94ay8xqoft5MNSTvxOP0qZpZ5WgG83Xh9T2A==", "154c857f-db35-424d-8f80-7bc52c759c3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47ca64f6-a787-4de2-ba37-f3584bfe7383", "AQAAAAIAAYagAAAAEFgyAycqfbi6+jWZuBA25PCOOB4CXc0Dt0MIgf7eOjD9TnuUCCfg3sb7MjpPabVETw==", "59a61ffe-d626-4a1d-90c3-c6d6f2be8fcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87a0fd96-0e68-432b-b2f0-c86f479a3fa3", "AQAAAAIAAYagAAAAEAp3p+5XrD57uaLeiVviFLj8AuRuUipL39/52x6T63RC3AAlBE3EmSJCgtBJoAKGYg==", "635c147f-2497-49cd-a11f-508024076e06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4eddd4cc-abda-4ccc-94e4-3c2859c9546b", "AQAAAAIAAYagAAAAEI5hFHvfldrrFmmBlWCz8FH5RtEyVMZBMdS0Whl7A/COCR+c8NGTTcAu90f57j4R0A==", "2b3c0c73-7fd4-495c-bd81-ee221783540b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "728dab21-f838-4b71-81e4-2ec58b90ca26", "AQAAAAIAAYagAAAAEBp/oSqXlYl83i4pBrU5iHf6UxGClbW48GCu8Ymu0S7G+ZbT59XTVRP8cwKI0ieH8g==", "e540fcda-3f2f-44a3-ad1b-0f06eb823ba1" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(8932), new DateTimeOffset(new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Unspecified).AddTicks(8984), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7882), new DateTimeOffset(new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Unspecified).AddTicks(7885), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7894), new DateTimeOffset(new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Unspecified).AddTicks(7895), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7896), new DateTimeOffset(new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Unspecified).AddTicks(7897), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7898), new DateTimeOffset(new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Unspecified).AddTicks(7898), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7899), new DateTimeOffset(new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 4, 30, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 935, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(2049), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(2075), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8599), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(8603), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(6993), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(7911), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(7920), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8518), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(8524), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8543), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(8551), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8558), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(8562), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8570), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(8574), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8580), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(8584), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8590), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 936, DateTimeKind.Unspecified).AddTicks(8594), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 936, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(2345), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(2354), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(2552), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(2558), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(2562), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 928, DateTimeKind.Unspecified).AddTicks(8389), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 928, DateTimeKind.Unspecified).AddTicks(8853), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 928, DateTimeKind.Unspecified).AddTicks(8865), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 362, DateTimeKind.Local).AddTicks(8207), new DateTime(2026, 3, 11, 11, 12, 42, 362, DateTimeKind.Utc).AddTicks(5929), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 362, DateTimeKind.Unspecified).AddTicks(8224), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 11, 12, 42, 362, DateTimeKind.Utc).AddTicks(5929), new DateTime(2026, 2, 9, 15, 42, 42, 362, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 363, DateTimeKind.Local).AddTicks(2228), new DateTime(2026, 2, 24, 11, 12, 42, 363, DateTimeKind.Utc).AddTicks(2223), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 363, DateTimeKind.Unspecified).AddTicks(2242), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 11, 12, 42, 363, DateTimeKind.Utc).AddTicks(2223), new DateTime(2026, 2, 9, 15, 42, 42, 363, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 363, DateTimeKind.Local).AddTicks(3424), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 363, DateTimeKind.Unspecified).AddTicks(3432), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 11, 12, 42, 363, DateTimeKind.Utc).AddTicks(3422), new DateTime(2026, 2, 9, 15, 42, 42, 363, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 932, DateTimeKind.Local).AddTicks(9610), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 932, DateTimeKind.Unspecified).AddTicks(9627), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 932, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6663), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6674), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6683), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6693), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6698), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6715), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6718), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6733), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6737), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6744), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6748), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(3801), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(5342), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6543), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6550), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6567), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6575), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6592), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6596), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6603), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6607), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6637), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6647), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 934, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 934, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 1680L, new DateTime(2026, 2, 9, 15, 42, 42, 351, DateTimeKind.Local).AddTicks(1782), null, true, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(639), new TimeSpan(0, 0, 0, 0, 0)), "1", 1920L, new DateTime(2026, 2, 9, 15, 42, 42, 351, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 9600L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5257), new TimeSpan(0, 0, 0, 0, 0)), "5", "10", 11400L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 2640L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5259), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), "6", "11", 3120L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 7920L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5264), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 0, 0, 0, 0)), "6", "12", 9360L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 3360L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5268), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5271), new TimeSpan(0, 0, 0, 0, 0)), "7", "13", 3840L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 14000L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5272), null, true, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5275), new TimeSpan(0, 0, 0, 0, 0)), "7", "14", 16000L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 540L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5277), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5281), new TimeSpan(0, 0, 0, 0, 0)), "8", "15", 660L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 6480L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5296), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 0, 0, 0, 0)), "8", "16", 7920L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 7600L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5302), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5305), new TimeSpan(0, 0, 0, 0, 0)), "9", "17", 8400L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 5160L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5306), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5309), new TimeSpan(0, 0, 0, 0, 0)), "10", "18", 5640L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 10320L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5311), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5314), new TimeSpan(0, 0, 0, 0, 0)), "10", "19", 11280L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "SellPrice", "UpdatedDate" },
                values: new object[] { 3360L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(3789), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(3804), new TimeSpan(0, 0, 0, 0, 0)), 3840L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 2600L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5315), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 0, 0, 0, 0)), "11", "20", 3000L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 6500L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5319), null, true, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5322), new TimeSpan(0, 0, 0, 0, 0)), "11", "21", 7500L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 3600L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5324), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5326), new TimeSpan(0, 0, 0, 0, 0)), "12", "22", 4400L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 1560L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(4721), null, true, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(4731), new TimeSpan(0, 0, 0, 0, 0)), "3", 1800L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 3120L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 0, 0, 0, 0)), "4", 3600L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 420L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5216), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5219), new TimeSpan(0, 0, 0, 0, 0)), "5", 540L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 840L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5221), null, true, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5224), new TimeSpan(0, 0, 0, 0, 0)), "3", "6", 1080L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 2760L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5226), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 0, 0, 0, 0)), "7", 3240L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 11040L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5245), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5248), new TimeSpan(0, 0, 0, 0, 0)), "4", "8", 12960L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 3200L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5250), null, true, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5253), new TimeSpan(0, 0, 0, 0, 0)), "5", "9", 3800L, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.InsertData(
                table: "ProductPrice",
                columns: new[] { "Id", "BuyPrice", "CreatedBy", "CreatedDate", "EffectiveDate", "EndDate", "EntityState", "IsActive", "IsPublic", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedBy", "UpdatedDate", "Version" },
                values: new object[,]
                {
                    { "23", 9000L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 0, 0, 0, 0)), "12", "23", 11000L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5328), 0 },
                    { "24", 3960L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5336), new TimeSpan(0, 0, 0, 0, 0)), "13", "24", 4440L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5334), 0 },
                    { "25", 7920L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5341), new TimeSpan(0, 0, 0, 0, 0)), "13", "25", 8880L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5338), 0 },
                    { "26", 3840L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5345), new TimeSpan(0, 0, 0, 0, 0)), "14", "26", 4800L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5342), 0 },
                    { "27", 11520L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5346), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, 0, 0, 0, 0)), "14", "27", 14400L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5347), 0 },
                    { "28", 11500L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5351), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 0, 0, 0, 0)), "15", "28", 13500L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5351), 0 },
                    { "29", 46000L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5355), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, 0, 0, 0, 0)), "15", "29", 54000L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5355), 0 },
                    { "30", 15000L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5359), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5362), new TimeSpan(0, 0, 0, 0, 0)), "16", "30", 17000L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5360), 0 },
                    { "31", 75000L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5363), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Unchanged", true, false, new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 352, DateTimeKind.Unspecified).AddTicks(5368), new TimeSpan(0, 0, 0, 0, 0)), "16", "31", 85000L, null, new DateTime(2026, 2, 9, 15, 42, 42, 352, DateTimeKind.Local).AddTicks(5364), 0 }
                });

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 349, DateTimeKind.Unspecified).AddTicks(2174), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1572), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1582), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "13",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "14",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "15",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1599), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "16",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "17",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "18",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "19",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(38), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "20",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1623), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "21",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1628), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "22",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "23",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1638), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "24",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1643), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "25",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "26",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1652), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "27",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1657), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "28",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "29",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1666), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "30",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "31",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1676), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1495), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1558), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1563), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductUnit",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 350, DateTimeKind.Unspecified).AddTicks(1567), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(812), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1272), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "11",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1275), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "12",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1229), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1246), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1253), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1256), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1260), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1263), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProvinceTranslations",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(1269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(9864), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(9), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(187), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(197), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(198), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(201), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(202), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(205), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 930, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 931, DateTimeKind.Local).AddTicks(2392), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 931, DateTimeKind.Unspecified).AddTicks(2409), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 931, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 932, DateTimeKind.Local).AddTicks(4154), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 932, DateTimeKind.Unspecified).AddTicks(4174), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 932, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 932, DateTimeKind.Local).AddTicks(4978), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 932, DateTimeKind.Unspecified).AddTicks(4987), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 932, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(8558), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 355, DateTimeKind.Unspecified).AddTicks(8571), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(8555), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 362, DateTimeKind.Local).AddTicks(2614), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 362, DateTimeKind.Unspecified).AddTicks(2644), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 362, DateTimeKind.Local).AddTicks(2609), new DateTime(2026, 2, 9, 15, 42, 42, 362, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "ShopOwner",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 362, DateTimeKind.Local).AddTicks(3532), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 362, DateTimeKind.Unspecified).AddTicks(3540), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 362, DateTimeKind.Local).AddTicks(3531), new DateTime(2026, 2, 9, 15, 42, 42, 362, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 353, DateTimeKind.Local).AddTicks(4916), new DateTime(2026, 8, 9, 11, 12, 42, 353, DateTimeKind.Utc).AddTicks(2372), new DateTime(2026, 1, 30, 11, 12, 42, 353, DateTimeKind.Utc).AddTicks(2313), new DateTime(2026, 2, 9, 15, 42, 42, 353, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 354, DateTimeKind.Local).AddTicks(80), new DateTime(2026, 9, 9, 11, 12, 42, 354, DateTimeKind.Utc).AddTicks(60), new DateTime(2026, 2, 4, 11, 12, 42, 354, DateTimeKind.Utc).AddTicks(59), new DateTime(2026, 2, 9, 15, 42, 42, 354, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "ExpirationDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 354, DateTimeKind.Local).AddTicks(1423), new DateTime(2026, 5, 9, 11, 12, 42, 354, DateTimeKind.Utc).AddTicks(1405), new DateTime(2026, 1, 25, 11, 12, 42, 354, DateTimeKind.Utc).AddTicks(1404), new DateTime(2026, 2, 9, 15, 42, 42, 354, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "StockBatch",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "ReceivedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 354, DateTimeKind.Local).AddTicks(2234), new DateTime(2026, 1, 20, 11, 12, 42, 354, DateTimeKind.Utc).AddTicks(2227), new DateTime(2026, 2, 9, 15, 42, 42, 354, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 354, DateTimeKind.Local).AddTicks(6814), new DateTime(2026, 2, 9, 15, 42, 42, 354, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5373), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(3091), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(4316), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5322), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5338), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5346), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5353), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5360), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "StockTransaction",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5367), new DateTime(2026, 2, 9, 15, 42, 42, 355, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1320), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(1347), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1812), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(1817), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1818), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(1822), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1823), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(1826), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1827), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(1831), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1832), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(1835), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1836), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(1839), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "TranslationKeys",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1840), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(1847), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(5238), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(5435), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6420), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6423), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6424), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6427), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6428), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6431), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6297), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6343), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6351), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6361), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6362), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6365), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6366), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6369), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6370), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6373), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6374), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6408), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6411), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6412), new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 929, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 9, 15, 42, 42, 929, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "1",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(4934), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "10",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(9917), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "2",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(8351), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "3",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "4",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(9871), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "5",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(9878), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "6",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(9884), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "7",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(9893), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "8",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(9898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UnitOfMeasure",
                keyColumn: "Id",
                keyValue: "9",
                column: "LastModifiedUtc",
                value: new DateTimeOffset(new DateTime(2026, 2, 9, 11, 12, 42, 930, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "31");

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

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(2019), new DateTime(2026, 3, 9, 13, 2, 14, 123, DateTimeKind.Utc).AddTicks(8427), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Unspecified).AddTicks(2049), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 13, 2, 14, 123, DateTimeKind.Utc).AddTicks(8425), new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "DueDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(6363), new DateTime(2026, 2, 22, 13, 2, 14, 124, DateTimeKind.Utc).AddTicks(6356), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Unspecified).AddTicks(6376), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Utc).AddTicks(6356), new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "LoanAccount",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "LastModifiedUtc", "LoanDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(7733), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Unspecified).AddTicks(7743), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2026, 2, 7, 13, 2, 14, 124, DateTimeKind.Utc).AddTicks(7730), new DateTime(2026, 2, 7, 17, 32, 14, 124, DateTimeKind.Local).AddTicks(7734) });

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
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 140L, new DateTime(2026, 2, 7, 17, 32, 14, 111, DateTimeKind.Local).AddTicks(1320), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 111, DateTimeKind.Unspecified).AddTicks(9035), new TimeSpan(0, 0, 0, 0, 0)), "2", 160L, new DateTime(2026, 2, 7, 17, 32, 14, 111, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 115L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3637), new TimeSpan(0, 0, 0, 0, 0)), "6", "3", 135L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 280L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3639), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3642), new TimeSpan(0, 0, 0, 0, 0)), "7", "1", 320L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 45L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3643), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)), "8", "1", 55L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 380L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3648), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3651), new TimeSpan(0, 0, 0, 0, 0)), "9", "4", 420L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 430L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 0, 0, 0, 0)), "10", "2", 470L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 460L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 0, 0, 0, 0)), "10", "2", 500L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 260L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3663), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3667), new TimeSpan(0, 0, 0, 0, 0)), "11", "7", 300L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 180L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3668), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3671), new TimeSpan(0, 0, 0, 0, 0)), "12", "7", 220L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 330L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3672), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 0, 0, 0, 0)), "13", "2", 370L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 160L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3676), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 0, 0, 0, 0)), "14", "1", 200L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "SellPrice", "UpdatedDate" },
                values: new object[] { 150L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(2183), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(2195), new TimeSpan(0, 0, 0, 0, 0)), 170L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 230L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3681), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 0, 0, 0, 0)), "15", "1", 270L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 750L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3685), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)), "16", "1", 850L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 700L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3693), new TimeSpan(0, 0, 0, 0, 0)), "16", "1", 800L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 130L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3140), new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3148), new TimeSpan(0, 0, 0, 0, 0)), "2", 150L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 135L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 0, 0, 0, 0)), "2", 155L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 70L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3602), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3606), new TimeSpan(0, 0, 0, 0, 0)), "2", 90L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 230L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), "4", "3", 270L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BuyPrice", "CreatedDate", "EffectiveDate", "LastModifiedUtc", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 250L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 0, 0, 0, 0)), "3", 290L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BuyPrice", "CreatedDate", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 160L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3624), new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 0, 0, 0, 0)), "5", "3", 190L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "ProductPrice",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "BuyPrice", "CreatedDate", "EndDate", "IsActive", "LastModifiedUtc", "ProductId", "ProductUnitId", "SellPrice", "UpdatedDate" },
                values: new object[] { 110L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3629), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTimeOffset(new DateTime(2026, 2, 7, 13, 2, 14, 112, DateTimeKind.Unspecified).AddTicks(3632), new TimeSpan(0, 0, 0, 0, 0)), "6", "3", 130L, new DateTime(2026, 2, 7, 17, 32, 14, 112, DateTimeKind.Local).AddTicks(3630) });

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
        }
    }
}
